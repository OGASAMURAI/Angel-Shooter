using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemscript : MonoBehaviour {
    
    public int shot = 1;
    public Player playerScript; 


     void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag =="character 2")
        {//shotaddメソッドを呼び出す　引数はshotpoint
        
            playerScript.addshot(shot);
            Destroy(gameObject);
        }
    }
    // Use this for initialization
    void Start () {
        
        {

        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
