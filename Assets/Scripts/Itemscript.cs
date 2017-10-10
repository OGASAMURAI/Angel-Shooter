using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemscript : MonoBehaviour
{
    
  
	void OnCollisionEnter2D (Collision2D collision)
	{
		if (gameObject.name == "shotaddTxc") {
			if (collision.gameObject.tag == "a") {
				
				FindObjectOfType<Player> ().wayadd ();
				Destroy (gameObject);
			}
		}

		if (gameObject.name == "HPitem") {
			if (collision.gameObject.tag == "a") {
				FindObjectOfType<HP> ().HPheal ();
				Destroy (gameObject);
			}
		}
	}

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
