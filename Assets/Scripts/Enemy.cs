using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour

{
 
    public int power = 3;
    // ヒットポイント
    public int hp = 3;
    //score point 
    public int point = 10;
    public int it = 1;
    // Spaceshipコンポーネント
    Basescript basescript;
    GameObject dropobj;
    private Itemscript addshot;


    IEnumerator Start()
    {
        // Spaceshipコンポーネントを取得
        basescript = GetComponent<Basescript>();

        // ローカル座標のY軸のマイナス方向に移動する
        basescript.Move(transform.right * -1);
        //getting item procession (addshot)
        //addshot = GameObject.FindGameObjectWithTag("shot").GetComponent<Itemscript>();
        // canShotがfalseの場合、ここでコルーチンを終了させる
        if (basescript.canShot == false)
           
        {
            yield break;
        }
            while (true)
        {
            //Debug.Log("thogh");

            // 子要素を全て取得する
            for (int i = 0; i < transform.childCount; i++)
            {
                //Debug.Log("throgh");
                Transform shotPosition = transform.GetChild(i);

                // ShotPositionの位置/角度で弾を撃つ
                basescript.Shot(shotPosition);
            }

            // shotDelay秒待つ
            yield return new WaitForSeconds(basescript.shotDelay);
        }
    }
    void OnTriggerEnter2D(Collider2D c)
    {
        // レイヤー名を取得
        string layerName = LayerMask.LayerToName(c.gameObject.layer);
        // Debug.Log(layerName);
        // レイヤー名がBullet (Player)以外の時は何も行わない
        if (layerName == "Bullet (Player)")
        {

            // PlayerBulletのTransformを取得
            Transform playerBulletTransform = c.transform.parent;
            //Debug.Log("わsdう");
            // Bulletcontrollerコンポーネントを取得
            
            
            // ヒットポイントを減らす
            hp = hp - power;
            //弾の削除
            Destroy(c.gameObject);
            //   Debug.Log("わwddう");

            // ヒットポイントが0以下であれば
            if (hp <= 0)
            {// スコアコンポーネントを取得してポイントを追加
                FindObjectOfType<UIcontroller>().AddPoint(point);

                // 爆発
                basescript.Explosionenemy();
                //  Debug.Log("わhuhuhああ");
                // エネミーの削除
                Destroy(gameObject);

                if (Random.Range(0, 49) == 0)
                {
                    Instantiate(dropobj, transform.position, transform.rotation);
                }


            }
            }
        if (layerName == "Player")
        {
            // エネミーの削除
            //Destroy(c.gameObject);
            //  Debug.Log("わう");
            // 爆発
            basescript.Explosion();
            FindObjectOfType<HP>().Hit(it);
           
                       // Debug.Log("ここは弾道");
            //プレイヤーーの削除
            Destroy(c.gameObject);
            // Managerコンポーネントをシーン内から探して取得し、GameOverメソッドを呼び出す
            FindObjectOfType<Manager>().GameOver();
        }
    }
}

