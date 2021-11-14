using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundController : MonoBehaviour
{
    //スクロール速度
    private float scrolSpeed = -1;
    //スクロール終了位置
    private float deadLine = -16;
    //スクロール開始位置
    private float startLine = 15.8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //背景を移動
        transform.Translate(this.scrolSpeed * Time.deltaTime, 0, 0);

        //画面外に出たら右端に移動
        if (transform.position.x < this.deadLine)
        {
            transform.position = new Vector2(this.startLine, 0);
        }
        
    }
}
