using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UICon : MonoBehaviour
{
    private GameObject gameOverText;
    private GameObject runLengthText;
    //����������
    private float len = 0;
    //����X�s�[�h
    private float speed = 5f;
    //�Q�[���I�[�o�[�̔��f
    private bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        //�V�[���r���[����I�u�W�F�N�g�̎��Ԃ�T��
        this.gameOverText = GameObject.Find("GameOver");
        this.gameOverText = GameObject.Find("RunLength");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.isGameOver == false)
        {
            //�������������X�V����
            this.len += this.speed * Time.deltaTime;

            //������������\������
            this.runLengthText.GetComponent<Text>().text = "Distance:" + len.ToString("F2") + "m";
        }
        
    }

    public void GameOver()
    {
        //�Q�[���I�[�o�[�ɂȂ����Ƃ��ɃQ�[���I�[�o�[�ƕ\������
        this.gameOverText.GetComponent<Text>().text = "GameOver";
        this.isGameOver = true;
    }
}
