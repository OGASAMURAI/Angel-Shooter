using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemscript : MonoBehaviour
{
    
	public int shot = 1;




  
	void OnCollisionEnter2D (Collision2D collision)
	{
		if (gameObject.name == "shotaddTxc") {
			if (collision.gameObject.tag == "a") {//shotaddメソッドを呼び出す　引数はshotpoint
				
				FindObjectOfType<Player> ().wayadd ();
				Destroy (gameObject);
			}
		}
	}

	private void addshotcall ()
	{
		//FindObjectOfType<Bulletcontroller> ().addshot ();

	}





	// Use this for initialization
	void Start ()
	{
        
		{

		}
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
