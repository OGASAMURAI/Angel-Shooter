using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public GameObject BulletPrefab;

	/*private void Shot (Transform origin)
	{
		Instantiate (BulletPrefab, origin.position, origin.rotation);
	}*/
   
	// Spaceshipコンポーネント
	Basescript basescript;
	public int way = 1;

	IEnumerator Start ()
	{
		// basescriptコンポーネントを取得
		basescript = GetComponent<Basescript> ();

		while (true) {

			/*// 弾をプレイヤーと同じ位置/角度で作成
			if (way <= 1) {
				Instantiate(bullet, origin.position, origin.rotation);
			}
			if (way == 2) {
				Instantiate(bullet, origin.position, origin.rotation);
				Instantiate(bullet, origin.position, origin.rotation);

			} else {
				Instantiate(bullet, origin.position, origin.rotation);
				Instantiate(bullet, origin.position, origin.rotation);
				Instantiate(bullet, origin.position, origin.rotation);

			}

			basescript.Shot (transform);*/

			// shotDelay秒待つ
			yield return new WaitForSeconds (basescript.shotDelay);
		}

	}


	void Update ()
	{
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (0, -0.1f, 0);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (0, 0.1f, 0);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (-0.1f, 0, 0);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (0.1f, 0, 0);
		}
		if (Input.GetKeyDown (KeyCode.Space)) {


			shotadd ();

		}
        
	}

	public void wayadd ()
	{
		if (way <= 3) {
			way++;
		}
	}

	void shotadd ()
	{

		if (way >= 1) {
			GameObject BulletPrefab1 = Instantiate (BulletPrefab, transform.position, Quaternion.identity) as GameObject;
			BulletPrefab1.name = "BulletPrefab1";

		}
		if (way >= 2) {
			GameObject BulletPrefab2 = Instantiate (BulletPrefab, transform.position, Quaternion.identity) as GameObject;
			BulletPrefab2.name = "BulletPrefab2";

		}
		if (way >= 3) {
			GameObject BulletPrefab3 = Instantiate (BulletPrefab, transform.position, Quaternion.identity) as GameObject;
			BulletPrefab3.name = "BulletPrefab3";

		}
	}

	void OnTriggerEnter2D (Collider2D c)
	{
		//  Debug.Log("garbage");
		// レイヤー名を取得
		//string layerName = LayerMask.LayerToName(c.gameObject.layer);

		//// レイヤー名がBullet (Player)以外の時は何も行わない
		//if (layerName == "Bullet (Player)")
		//{
		//    // 弾の削除
		//    Destroy(c.gameObject);
		//    //Debug.Log("わう");
		//    // 爆発
		//    basescript.Explosion();
		//    //Debug.Log("わhuhuhああ");
		//    // エネミーの削除
		//    Destroy(gameObject);
		//}
	}

	// ぶつかった瞬間に呼び出される
	//void OnTriggerEnter2D(Collider2D c)
	//{
	//    Debug.Log("わう");
	//    //if(c.gameObject.name == "enemy")
	//    {
	//        Destroy(c.gameObject);
	//        Destroy(this.gameObject);
	//    }

	//    {
	//        //
	//    }

	// }
	// レイヤー名を取得
	//string layerName = LayerMask.LayerToName(c.gameObject.layer);

	// レイヤー名がBullet (Enemy)の時は弾を削除
	//if (layerName == "Bullet (Enemy)")
	//{
	//  Debug.Log("わsdう");
	// 弾の削除

	//Destroy(c.gameObject);
	//}

	// レイヤー名がBullet (Enemy)またはEnemyの場合は爆発
	//if (layerName == "Bullet (Enemy)" || layerName == "Enemy")
	//{

	// 爆発する
	//  basescript.Explosion();

	// プレイヤーを削除
	//Destroy(gameObject);

}
    
