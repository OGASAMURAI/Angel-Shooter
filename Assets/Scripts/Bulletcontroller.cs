using UnityEngine;
using System.Collections;

public class Bulletcontroller : MonoBehaviour
{
	public int power = 1;
	public int way = 1;

	void Update ()
	{
		/*transform.Translate(0.2f, 0, 0);

		if (transform.position.x > 10)
		{
			Destroy(gameObject);
		}*/

		addshot ();

		if (transform.position.x > 10) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D (Collider2D collision)
	{

		// 衝突したときにスコアを更新する

		string layerName = LayerMask.LayerToName (collision.gameObject.layer);
		// Debug.Log(layerName);
		// レイヤー名がBullet (Player)以外の時は何も行わない
        
		if (layerName == "Enemy") {
			//Debug.Log("とおって");
			//GameObject.Find("Canvas").GetComponent<UIcontroller>().AddScore();

		}
		if (layerName == "Player") {
			//aitewokesu
			Destroy (collision.gameObject);
			// Debug.Log("とおって");
			Destroy (gameObject);

		}
	}

	public void addshot (/*int shot*/)
	{
		// 子要素を全て取得する
		/*int i=0;
        if (i < transform.childCount)
        {
            i++;
        }

        {

            Transform shotPosition = transform.GetChild(i);

            // ShotPositionの位置/角度で弾を撃つ
            Shot(shotPosition);
            }*/

		if (transform.name == "BulletPrefab1") {
			transform.Translate (0.2f, 0, 0);
		}
		if (transform.name == "BulletPrefab2") {
			transform.Translate (0.2f, 0.05f, 0);
		}
		if (transform.name == "BulletPrefab3") {
			transform.Translate (0.2f, -0.05f, 0);
		}
	}



}

