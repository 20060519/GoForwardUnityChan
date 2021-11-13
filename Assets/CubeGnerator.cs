using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGnerator : MonoBehaviour
{
    //�L���[�u�̃v���n�u
    public GameObject cubePrefab;
    //���Ԍv���p�̕ϐ�
    private float delta = 0;
    //�L���[�u�𐶐�����Ԋu
    private float span = 1.0f;
    //�L���[�u�����ʒu�F�����W
    private float genPosx = -12;
    //�L���[�u�����ʒu�I�t�Z�b�g
    private float offsetY = 0.3f;
    //�L���[�u�̏c�����̊Ԋu
    private float spaceY = 6.9f;
    //�L���[�u�����ʒu�I�t�Z�b�g
    private float offsetX = 0.5f;
    //�L���[�u�̏c�����̊Ԋu
    private float spaceX = 0.4f;
    //�L���[�u�̐������
    private int maxBlockNum = 4;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        //�X�p���b�ȏ�̎��Ԃ��o�߂������𒲂ׂ�
        if (this.delta > this.span)
        {
            this.delta = 0;
            //��������L���[�u�������_���Ɍ��߂�
            int n = Random.Range(1, maxBlockNum + 1);

            //��������L���[�u���w�肷��
            for (int i = 0; i < n; i++)
            {
                //�L���[�u�̐���
                GameObject go = Instantiate(cubePrefab);
                go.transform.position = new Vector2(this.genPosx, offsetY + i * this.spaceY);
            }
            //���̃L���[�u�𐶐�����Ԋu�����߂�
            this.span = this.offsetX + this.spaceX * n;
        }

    }
}