using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorNinja : MonoBehaviour {

	private Animator animator;
	public GameObject kunaiPrefab;
	public float offsetX;
	public float offsetY;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space")){
			// Aquí llamaríamos al trigger de ataque
			animator.SetTrigger("Atacar");
		}

		if(Input.GetKeyDown("z")){
			// Aquí llamaríamos al trigger de ataque
			animator.SetTrigger("Lanzar");
		}
	}

	void ThrowKunai(){
		GameObject kunai = Instantiate(kunaiPrefab, transform.position, Quaternion.identity);
		kunai.transform.position += new Vector3(offsetX, offsetY, 0);
	}
}
