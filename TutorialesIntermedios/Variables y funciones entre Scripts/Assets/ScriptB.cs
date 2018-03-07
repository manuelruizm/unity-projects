using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptB : MonoBehaviour {

	// public ScriptA scriptA;

	public GameObject objetoA;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		// Usando el objeto Script directamente

		// if(Input.GetKeyDown("space")){
		// 	scriptA.numero *= 2;
		// 	scriptA.MostrarNumero();
		// }

		// Usando un tipo de objeto genérico

		// if(Input.GetKeyDown("space")){
		// 	objetoA.SendMessage("MostrarNumero");
		// 	objetoA.SendMessage("EstablecerNumero", 5);
		// }

		// Usando la componente de un objeto genérico

		if(Input.GetKeyDown("space")){
			objetoA.GetComponent<ScriptA>().MostrarNumero();
		}
	}
}
