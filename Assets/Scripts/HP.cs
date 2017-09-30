using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour {
    public int lifeCount;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject arrObj = transform.Find("GameObject/GameObjectHoge").gameObject;
        int num = 0;
        foreach (Transform childObj in arrObj.transform)
        {

            // ライフポイントの数だけ、GameObjectをアクティブにして表示、指定ポイントより低かったら非アクティブ
            if (lifeCount > num)
            {
                childObj.gameObject.SetActive(true);
            }
            else
            {
                childObj.gameObject.SetActive(false);
            }
            num += 1;
        }


    }
}
