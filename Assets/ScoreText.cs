using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreText : MonoBehaviour
{
    private GameObject tokutenText;//�X�R�A��\������e�L�X�g
    private int Score = 0;//�����X�R�A
    // Start is called before the first frame update

    
    void Start()
    {
        
    }

    public void HitTag(string tag)
    {
        if (tag == "SmallStarTag")//�X���[���X�^�[�ɓ���������10�_�ǉ�
        {
            this.Score += 10;
        }
        else if(tag == "LargeStarTag")//���[�W�X�^�[�ɓ���������20�_�ǉ�
        {
            this.Score += 20;
        }
        else if (tag == "SmallCloudTag")//�X���[���N���E�h�ɓ���������30�_�ǉ�
        {
            this.Score += 30;
        }
        else if (tag == "LargeCloudTag")//���[�W�N���E�h�ɓ���������50�_�ǉ�
        {
            this.Score += 50;
        }

    }    
        // Update is called once per frame
    void Update()
    {
        this.tokutenText = GameObject.Find("Score");
        this.tokutenText.GetComponent<Text>().text = "Score : " + Score;//�X�R�A��\��
    }
}
