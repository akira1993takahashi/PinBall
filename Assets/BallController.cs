using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    //ボールが見える可能性のあるZ軸の最小値
    private float visiblePosZ = -6.5f;

    private ScoreText scoreComp;
    //ゲームオーバーを表示するテキスト
    private GameObject gameoverText;
    // Start is called before the first frame update
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
        //シーン中のScoreObject内のScoreTextを取得。
        scoreComp = GameObject.Find("ScoreObject").GetComponent<ScoreText>();
    }
    void OnCollisionEnter(Collision collision)
    {
        scoreComp.HitTag(collision.gameObject.tag);//HitTagに当たったオブジェクトのタグを返す。
    }
        // Update is called once per frame
        void Update()
    {
        //ボールが画面外に出た場合
        if(this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバーを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }
}
