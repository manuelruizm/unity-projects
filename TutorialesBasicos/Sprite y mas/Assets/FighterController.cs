using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterController : MonoBehaviour {

	public float speed;
	public float padding;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// if(Input.GetKey(KeyCode.LeftArrow)){
		// 	// movimiento a la izquierda
		// 	this.transform.position += new Vector3(-speed*Time.deltaTime,0,0);
		// }
		// else if(Input.GetKey(KeyCode.RightArrow)){
		// 	// movimiento a la derecha
		// 	this.transform.position += new Vector3(speed*Time.deltaTime,0,0);
		// }
		
		// Movimiento horizontal
		float hInput = Input.GetAxis("Horizontal");
		transform.position += new Vector3(hInput * speed * Time.deltaTime, 0, 0);

		// Movimiento vertical
		float vInput = Input.GetAxis("Vertical");
		transform.position += new Vector3(0, vInput * speed * Time.deltaTime, 0);

		// Clamping, rectificación
		float newX = Mathf.Clamp(transform.position.x, -10 + padding, 10 - padding);
		float newY = Mathf.Clamp(transform.position.y, -10 + padding, 10 - padding);
		transform.position = new Vector3(newX, newY, transform.position.z);
	}
}
