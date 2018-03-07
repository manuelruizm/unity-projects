using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptA : MonoBehaviour {

	public int numero = 1;

	public void MostrarNumero(){
		print(numero);
	}

	public void EstablecerNumero(int valor){
		numero = valor;
	}
}
