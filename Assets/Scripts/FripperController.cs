using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    //HingeJointコンポーネントを入れる
    private HingeJoint myHingeJoint;

    //初期の傾き
    private float defaultAngle = 20;

    //弾いた時の傾き
    private float flickAngle = -20;
    // Start is called before the first frame update
    void Start()
    {
        //HingeJointコンポーネントを取得
        this.myHingeJoint = GetComponent<HingeJoint>();

        //フリッパーの傾きを設定
        SetAngle(this.defaultAngle);
    }

    // Update is called once per frame
    void Update()
    {
        //Aキーを押した時左フリッパーを動かす
        if(Input.GetKeyDown(KeyCode.A)&& tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        //Dキーを押した時右フリッパーを動かす
        if(Input.GetKeyDown(KeyCode.D)&& tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        //Sキーまたは下矢印キーを押した時は同時に左右のフリッパーを動かす
        if((Input.GetKeyDown(KeyCode.S)&& (tag == "RightFripperTag"||tag == "LeftFripperTag")) || (Input.GetKeyDown(KeyCode.DownArrow) && (tag == "RightFripperTag" || tag == "LeftFripperTag")))
        {
            SetAngle(this.flickAngle);
        }

        //各キーが離された時フリッパーを元に戻す
        if(Input.GetKeyUp(KeyCode.A)&& tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        if(Input.GetKeyUp(KeyCode.D)&& tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        if ((Input.GetKeyUp(KeyCode.S) && (tag == "RightFripperTag" || tag == "LeftFripperTag")) || (Input.GetKeyUp(KeyCode.DownArrow) && (tag == "RightFripperTag" || tag == "LeftFripperTag")))
        {
            SetAngle(this.defaultAngle);
        }
    }

    //フリッパーの傾きを設定
    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }
}
