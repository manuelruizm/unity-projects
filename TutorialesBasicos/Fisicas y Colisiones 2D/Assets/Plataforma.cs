using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D collision)
	{
		print("Ha ocurrido un evento Collision!");
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		print("Ha ocurrido un evento Trigger!");
	}
}
