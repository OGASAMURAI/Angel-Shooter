using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
	public int Count;
	int num = 0;
	bool ld;
	public GameObject heart;

	public void Hit (int it)
	{
		if (Count <= 3) {
			Count = Count - it;
			ld = true;
		}
	}

	public void HPheal ()
	{
		if (Count < 3) {
			Hit (-1);
		}
	}

	void HeartPaint ()
	{
		GameObject[] heartclone = GameObject.FindGameObjectsWithTag ("Heart");
		foreach (GameObject heartclones in heartclone) {
			Destroy (heartclones);
		}

		if (Count >= 1) {
			Instantiate (heart, new Vector2 (-5, 4.25f), Quaternion.identity);
		}
		if (Count >= 2) {
			Instantiate (heart, new Vector2 (-4, 4.25f), Quaternion.identity);
		}
		if (Count >= 3) {
			Instantiate (heart, new Vector2 (-3, 4.25f), Quaternion.identity);
		}
	}

	void LD ()
	{

		if (Count <= num) {
			//childObj.gameObject.SetActive (true);

			playerDestroy (); 
			FindObjectOfType<Basescript> ().Explosion ();
			FindObjectOfType<Manager> ().GameOver ();

		} else {
			//childObj.gameObject.SetActive (false);

		}
	}

	public void playerDestroy ()
	{
		GameObject[] players = GameObject.FindGameObjectsWithTag ("a");
		foreach (GameObject player in players) {
			Destroy (player);
		}
	}

	// Use this for initialization
	void Start ()
	{
		HeartPaint ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (ld == true) {
			HeartPaint ();
			LD ();
			ld = false;
		}

		//if (Count <= 0)
		//{
		//    var clones = GameObject.FindGameObjectsWithTag("a");
		//    foreach (var clone in clones)
		//    {
		//        Destroy(clone);

		//    }

		//}
		//else
		//{
		/*GameObject arrObj = GameObject.Find ("GameObjectChild").gameObject;
            
		foreach (Transform childObj in arrObj.transform) {


			// ライフポイントの数だけ、GameObjectをアクティブにして表示
			if (Count <= num) {
				//childObj.gameObject.SetActive (true);
				FindObjectOfType<Manager> ().GameOver ();

				//Debug.Log ("tyugjgjrr");
			} else {
				//childObj.gameObject.SetActive (false);
				//Debug.Log ("tyurr");


				FindObjectOfType<Manager> ().titleScene ();


			}
               
		}*/
	}


}

