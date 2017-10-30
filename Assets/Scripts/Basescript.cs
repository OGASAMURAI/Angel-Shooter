using UnityEngine;

// Rigidbody2Dコンポーネントを必須にする
[RequireComponent(typeof(Rigidbody2D))]
public class Basescript: MonoBehaviour
{
    // 移動スピード
    public float speed;

    public float lifetime = 3f;
    // 弾を撃つ間隔
    public float shotDelay;

    // 弾のPrefab
    public GameObject bullet;


    // 弾を撃つかどうか
    public bool canShot;

    // 爆発のPrefab
    public GameObject explosion;
    public GameObject explosionenemy;


    // 爆発の作成
    public void Explosion()
    {
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject, lifetime);
    //    Debug.Log("かっか");
    }
    public void Explosionenemy()
    {
        Instantiate(explosionenemy, transform.position, transform.rotation);
        Destroy(gameObject, lifetime);
       //  Debug.Log("かっhか");
    }


    // 弾の作成
    public void Shot(Transform origin)
    {
        Instantiate(bullet, origin.position, origin.rotation);
      
    }

    // 機体の移動
    public void Move(Vector2 direction)
        
    {
        GetComponent<Rigidbody2D>().velocity = direction * speed;
        //Debug.Log("通った");
    }
}