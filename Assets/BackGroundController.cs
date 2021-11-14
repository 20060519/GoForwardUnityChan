using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundController : MonoBehaviour
{
    //�X�N���[�����x
    private float scrolSpeed = -1;
    //�X�N���[���I���ʒu
    private float deadLine = -16;
    //�X�N���[���J�n�ʒu
    private float startLine = 15.8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�w�i���ړ�
        transform.Translate(this.scrolSpeed * Time.deltaTime, 0, 0);

        //��ʊO�ɏo����E�[�Ɉړ�
        if (transform.position.x < this.deadLine)
        {
            transform.position = new Vector2(this.startLine, 0);
        }
        
    }
}
