using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //�L���[�u�̈ړ����x
    private float speed = -12f;
    //���ňʒu
    private float deadline = -10f;

    [SerializeField] private AudioSource blockse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);
        //��ʊO�ɏo�������
        if (this.transform.position.x < deadline)
        {
            Destroy(gameObject);
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Unitycha���ɓ����������̓{�����[�����O�ɂ���
        if (gameObject.tag != "Unitychan")
        {
            blockse.Play();
        }
        
    }
}

