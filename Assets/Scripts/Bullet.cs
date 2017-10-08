using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
	// Spaceshipコンポーネント
	Basescript basescript;
	public int it = 1;

	// 攻撃力
	public int power = 3;

	public GameObject explosionenemy;

	void Explosion ()
	{
		Instantiate (explosionenemy, transform.position, transform.rotation);
		Destroy (gameObject, 3);
		//  Debug.Log("かっか");
	}

	public int speed = 10;

	void Start ()
	{
		basescript = GetComponent<Basescript> ();
		GetComponent<Rigidbody2D> ().velocity = transform.right.normalized * speed;
        
	}

	void OnTriggerEnter2D (Collider2D c)
	{
		// Debug.Log("wara");

		//レイヤー名を取得
		string layerName = LayerMask.LayerToName (c.gameObject.layer);
		// Debug.Log(layerName);
		//Debug.Log("wau");
		//レイヤー名がPlayer以外の時は何も行わない
		if (layerName == "Bullet (Player)") {
			Destroy (gameObject);
			Destroy (c.gameObject);
		}
    
		if (layerName == "Player") {
			// 弾の削除
			Destroy (gameObject);
			// Debug.Log("わう");




			// 爆発の作成
			Explosion ();
			//Debug.Log("ぎえsdええ");
			FindObjectOfType<HP> ().Hit (it);
			//プレイヤーーの削除
			Destroy (c.gameObject);
			// Managerコンポーネントをシーン内から探して取得し、GameOverメソッドを呼び出す

			// /FindObjectOfType<Manager>().GameOver();
			// Debug.Log("ここは敵の判定");
		}
        
      
	}

}
