using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreText : MonoBehaviour
{
    private GameObject tokutenText;//スコアを表示するテキスト
    private int Score = 0;//初期スコア
    // Start is called before the first frame update

    
    void Start()
    {
        
    }

    public void HitTag(string tag)
    {
        if (tag == "SmallStarTag")//スモールスターに当たったら10点追加
        {
            this.Score += 10;
        }
        else if(tag == "LargeStarTag")//ラージスターに当たったら20点追加
        {
            this.Score += 20;
        }
        else if (tag == "SmallCloudTag")//スモールクラウドに当たったら30点追加
        {
            this.Score += 30;
        }
        else if (tag == "LargeCloudTag")//ラージクラウドに当たったら50点追加
        {
            this.Score += 50;
        }

    }    
        // Update is called once per frame
    void Update()
    {
        this.tokutenText = GameObject.Find("Score");
        this.tokutenText.GetComponent<Text>().text = "Score : " + Score;//スコアを表示
    }
}
