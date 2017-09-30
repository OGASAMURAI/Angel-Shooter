using UnityEngine;

public class Background : MonoBehaviour
{
    // スクロールするスピード
    public float speed = 0.1f;

    void Update()
    {
        // 時間によってYの値が0から1に変化していく。1になったら0に戻り、繰り返す。
        float x = Mathf.Repeat(Time.time * speed, 1);

        // Yの値がずれていくオフセットを作成
        Vector2 offset = new Vector2(0, x);
        //Debug.Log("wa");
        // マテリアルにオフセットを設定する
        GetComponent<SpriteRenderer>().sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}