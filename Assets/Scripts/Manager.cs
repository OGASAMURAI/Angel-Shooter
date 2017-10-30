using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
	// Playerプレハブ
	public GameObject player;

	// タイトル
	private GameObject title;
	private GameObject gameover;

	void Start ()
	{
		// Titleゲームオブジェクトを検索し取得する
		title = GameObject.Find ("Title");
		gameover = GameObject.Find ("GameOver");
		gameover.SetActive (false);


	}



	void Update ()
	{
        //MをおしたときにY軸対象線上に移動する
        { 
        if(IsPlaying()==true  && Input.GetKeyDown(KeyCode.M)){
 
            FindObjectOfType<Player>().MoveS();
 
        }

		// ゲーム中ではなく、Xキーが押されたらtrueを返す。
		if (IsPlaying () == false && Input.GetKeyDown (KeyCode.X)) {
			GameStart ();
		}
        {
            // ゲームおーばーで、Yーが押されたらtrueを返す。
		if (Gameend()== true && Input.GetKeyDown (KeyCode.Y)) {
                SceneManager.LoadScene("main"); GameStart ();
		}
        }
        {
            if (Gameend() == true && Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("shoot"); GameStart();
            }
        }

	}


	public void titleScene ()
	{
		title.SetActive (true);

	}

	public void GameStart ()
	{
		// ゲームスタート時に、タイトルを非表示にしてプレイヤーを作成する
		title.SetActive (false);
		// /gameover.SetActive (false);
		Instantiate (player, player.transform.position, player.transform.rotation);
	}

	public void GameOver ()
	{
		// ハイスコアの保存
		FindObjectOfType<UIcontroller> ().Save ();
		// ゲームオーバー時に、ゲームオーバーを表示する
		gameover.SetActive (true);

       // Debug.Log("through");
	}

	public bool IsPlaying ()
	{
		// ゲーム中かどうかはタイトルの表示/非表示で判断する
		return title.activeSelf == false;
	}

    public bool Gameend()
    {
        //Debug.Log("wau");
        //ゲームオーバー化どうかはゲームオーバー表示で判断
        return gameover.activeSelf == true;
        
    }
}