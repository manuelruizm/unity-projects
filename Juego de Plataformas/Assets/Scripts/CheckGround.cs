using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour {

	private PlayerController player;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		player = GetComponentInParent<PlayerController>();
		rb2d = GetComponentInParent<Rigidbody2D>();
	}

	void OnCollisionEnter2D(Collision2D collisionInfo)
	{
		if(collisionInfo.gameObject.tag == "Platform"){
			rb2d.velocity = new Vector3(0f, 0f, 0f);
			player.transform.parent = collisionInfo.transform;
			player.grounded = true;
		}
	}
	
	void OnCollisionStay2D(Collision2D collisionInfo)
	{
		if(collisionInfo.gameObject.tag == "Ground"){
			player.grounded = true;
		}

		if(collisionInfo.gameObject.tag == "Platform"){
			player.transform.parent = collisionInfo.transform;
			player.grounded = true;
		}
	}

	void OnCollisionExit2D(Collision2D collisionInfo)
	{
		if(collisionInfo.gameObject.tag == "Ground"){
			player.grounded = false;
		}

		if(collisionInfo.gameObject.tag == "Platform"){
			player.transform.parent = null;
			player.grounded = false;
		}
	}
}
