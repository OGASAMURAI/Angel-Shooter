using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorecontoroller : MonoBehaviour {
  public  int score ;
     public GameObject scoreText;
    


    // Use this for initialization
    public void AddPoint(int point)
    {
        score = score + point;
    }

    void Start()
    {
        this.scoreText = GameObject.Find("Canvas/Text");
    }
    // Update is called once per frame
    void Update () {
        scoreText.GetComponent<Text>().text = "Score:" + score.ToString("D4");
       // Debug.Log(scoreText);
	}
}
