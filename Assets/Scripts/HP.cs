using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour {

    public int Count;
    int num = 0;
    public void Hit(int it)
      
    {
        Count = Count - it;
       
    }
    // Use this for initialization
    void Start () {
        
       
    }
	
	// Update is called once per frame
	void Update () {
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
            GameObject arrObj = GameObject.Find("GameObjectChild").gameObject;
            
            foreach (Transform childObj in arrObj.transform)
            {


                // ライフポイントの数だけ、GameObjectをアクティブにして表示
                if (Count >= num)
                {
                    
                    childObj.gameObject.SetActive(true);
                     Debug.Log("tyugjgjrr");
                }
                else
                {

                    childObj.gameObject.SetActive(false);
                    Debug.Log("tyurr");
                }
                
            }
        }


    }

