using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    //�{�[����������\���̂���Z���̍ŏ��l
    private float visiblePosZ = -6.5f;

    private ScoreText scoreComp;
    //�Q�[���I�[�o�[��\������e�L�X�g
    private GameObject gameoverText;
    // Start is called before the first frame update
    void Start()
    {
        //�V�[������GameOverText�I�u�W�F�N�g���擾
        this.gameoverText = GameObject.Find("GameOverText");
        //�V�[������ScoreObject����ScoreText���擾�B
        scoreComp = GameObject.Find("ScoreObject").GetComponent<ScoreText>();
    }
    void OnCollisionEnter(Collision collision)
    {
        scoreComp.HitTag(collision.gameObject.tag);//HitTag�ɓ��������I�u�W�F�N�g�̃^�O��Ԃ��B
    }
        // Update is called once per frame
        void Update()
    {
        //�{�[������ʊO�ɏo���ꍇ
        if(this.transform.position.z < this.visiblePosZ)
        {
            //GameoverText�ɃQ�[���I�[�o�[��\��
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }
}
