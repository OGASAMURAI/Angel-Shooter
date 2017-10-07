using UnityEngine;
using System.Collections;

public class Bulletcontroller : MonoBehaviour
{
    public int power = 1;
    void Update()
    {
        transform.Translate(0.2f, 0, 0);

        if (transform.position.x > 10)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
       

        // 衝突したときにスコアを更新する
        

        string layerName = LayerMask.LayerToName(collision.gameObject.layer);
        // Debug.Log(layerName);
        // レイヤー名がBullet (Player)以外の時は何も行わない
        
            if (layerName == "Enemy") {
         //   Debug.Log("とおって");

            //  GameObject.Find("Canvas").GetComponent<UIcontroller>().AddScore();
        }
            if (layerName == "Player")
        {

            
            //aitewokesu
            Destroy(collision.gameObject);
           // Debug.Log("とおって");
            Destroy(gameObject);
        }
    }


}
