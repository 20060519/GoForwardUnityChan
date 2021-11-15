using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIController : MonoBehaviour
{
    private GameObject gameOverText;
    private GameObject runLengthText;
    //走った距離
    private float len = 0;
    //走るスピード
    private float speed = 5f;
    //ゲームオーバーの判断
    private bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        //シーンビューからオブジェクトの実態を探す
        this.gameOverText = GameObject.Find("GameOver");
        this.gameOverText = GameObject.Find("RunLength");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.isGameOver == false)
        {
            //走った距離を更新する
            this.len += this.speed * Time.deltaTime;

            //走った距離を表示する
            this.runLengthText.GetComponent<Text>().text = "Distance:" + len.ToString("F2") + "m";
        }

        //ゲームオーバーになったとき
        if (this.isGameOver == true)
        {
            //クリックされたシーンをロードする
            if (Input.GetMouseButtonDown(0))
            {
                //SampleSceneを読み込む
                SceneManager.LordScene("SampleScene");
            }
        }
    }

    public void GameOver()
    {
        //ゲームオーバーになったときにゲームオーバーと表示する
        this.gameOverText.GetComponent<Text>().text = "GameOver";
        this.isGameOver = true;
    }

}

