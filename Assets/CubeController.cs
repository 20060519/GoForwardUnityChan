using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //キューブの移動速度
    private float speed = -12f;
    //消滅位置
    private float deadline = -10f;

    [SerializeField] private AudioSource blockse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);
        //画面外に出たら消す
        if (this.transform.position.x < deadline)
        {
            Destroy(gameObject);
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Unitychaｎに当たった時はボリュームを０にする
        if (gameObject.tag != "Unitychan")
        {
            blockse.Play();
        }
        
    }
}

