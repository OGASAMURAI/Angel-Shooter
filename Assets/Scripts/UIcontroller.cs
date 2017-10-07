using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIcontroller : MonoBehaviour
{   
    // スコアを表示するGUIText
    public Text scoreText;

    // ハイスコアを表示するGUIText
    public Text scorehigh;

    public int highscore ;

    int score;
    //GameObject scoreText;
    // GameObject scorehigh;

    // PlayerPrefsで保存するためのキー
    private string highScoreKey = "highScore";

    public void AddPoint(int point)
    {
        score =score+point;
    }

    void Start()
    {
        OnServerInitialized();
    }

    void Update()
    {
        Debug.Log("dfg");
        scoreText.GetComponent<Text>().text = "" + score.ToString("D4");
        // スコアがハイスコアより大きければ
        if (highscore < score)
        {
            Debug.Log("through");
           
            highscore = score;
            scorehigh.GetComponent<Text>().text = "" + highscore.ToString("D4");
        }
    }
    private void OnServerInitialized()
    {
        //Score is return to 09
        score = 0;
        //get highsxore. if not resereve score or  get score 0
        highscore = PlayerPrefs.GetInt(highScoreKey,0);
       
    }
    //reserce highscore
    public void Save()
    {
        PlayerPrefs.SetInt(highScoreKey, highscore);
        PlayerPrefs.Save();
        //return to Gamebegiinning
        OnServerInitialized();
    }
}