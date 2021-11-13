using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitychanController : MonoBehaviour
{
    //�A�j���[�V�������邽�߂̃R���|�[�l���g������
    Animator animator;
    //unitychan���ړ�������R���|�[�l���g������
    Rigidbody2D rigid2D;
    //�n�ʂ̈ʒu
    private float groundlevel = -3.0f;
    //�W�����v�̑��x
    float jumpVelocity = 20;
    //�W�����v�̑��x������
    private float dump = 0.8f;

    // Start is called before the first frame update
    void Start()
    {
        //�A�j���[�^�[�̃R���|�[�l���g���擾����
        this.animator = GetComponent<Animator>();
        //Rigidbody�QD�̃R���|�[�l���g���擾
        this.rigid2D = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // ����A�j���[�V�������Đ����邽�߂ɁAAnimator�̃p�����[�^�𒲐߂���
        this.animator.SetFloat("Horizontal", 1);
        // ���n���Ă��邩�ǂ����𒲂ׂ�
        bool isGround = (transform.position.y > this.groundlevel) ? false : true;
        this.animator.SetBool("isGround", isGround);

        //���n��ԂŃN���b�N���ꂽ�ꍇ
        if (Input.GetMouseButtonDown(0) && isGround) ;
        {
            // ������̗͂�������
            this.rigid2D.velocity = new Vector2(0, this.jumpVelocity);
        }
        // �N���b�N����߂��������ւ̑��x����������i�ǉ��j
        if (Input.GetMouseButtonDown(0) == false) 
        {
            if(this.rigid2D.velocity.y > 0)
            {
                this.rigid2D.velocity *= this.dump;
            }
        }
    }
}
