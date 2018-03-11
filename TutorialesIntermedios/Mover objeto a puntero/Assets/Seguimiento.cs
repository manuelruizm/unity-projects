using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguimiento : MonoBehaviour {

	public float speed;

	Vector3 target;

	// Use this for initialization
	void Start () {
		target = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetMouseButtonDown(0)){
			target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			target.z = 0f;
		}

		transform.position = Vector3.MoveTowards(transform.position, target, speed*Time.deltaTime);

		Debug.DrawLine(transform.position, target, Color.green);
	}
}
