using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitychanController : MonoBehaviour
{
    //アニメーションするためのコンポーネントを入れる
    Animator animator;
    //unitychanを移動させるコンポーネントを入れる
    Rigidbody2D rigid2D;
    //地面の位置
    private float groundLevel = -3.0f;
    //ジャンプの速度
    float jumpVelocity = 20;
    //ジャンプの速度を減衰
    private float dump = 0.8f;
    //ゲームオーバーになる位置
    private float deadline = -9;

    // Start is called before the first frame update
    void Start()
    {
        //アニメーターのコンポーネントを取得する
        this.animator = GetComponent<Animator>();
        //Rigidbody２Dのコンポーネントを取得
        this.rigid2D = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // 走るアニメーションを再生するために、Animatorのパラメータを調節する
        this.animator.SetFloat("Horizontal", 1);
        // 着地しているかどうかを調べる
        bool isGround = (transform.position.y > this.groundLevel) ? false : true;
        this.animator.SetBool("isGround", isGround);

        //ジャンプ状態のときはボリュームを０にする
        GetComponent<AudioSource>().volume = (isGround) ? 1 : 0;

        //着地状態でクリックされた場合
        if (Input.GetMouseButtonDown(0) && isGround) 
        {
            // 上方向の力をかける
            this.rigid2D.velocity = new Vector2(0, this.jumpVelocity);
        }
        // クリックをやめたら上方向への速度を減速する（追加）
        if (Input.GetMouseButton(0) == false) 
        {
            if(this.rigid2D.velocity.y > 0)
            {
                this.rigid2D.velocity *= this.dump;
            }
        }

       //デッドラインを超えたらゲームオーバーにする
        if (transform.position.x < this.deadline)
        {
            // UIControllerのGameOver関数を呼び出して画面上に「GameOver」と表示する
            GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
            //unitychanを破棄する
            Destroy(gameObject);
        }
    }
}
