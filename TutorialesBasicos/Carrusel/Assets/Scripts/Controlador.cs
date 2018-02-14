using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diapositiva{

	public string titulo;
	public string descripcion;
	public Sprite fotografia;

	// Constructor
	public Diapositiva(string _titulo, string _descripcion, string _fotografia){

		titulo = _titulo;
		descripcion = _descripcion;
		fotografia = Resources.Load<Sprite>(_fotografia);
	}
}

public class Controlador : MonoBehaviour {

	public Text titulo;
	public Text descripcion;
	public Image fotografia;

	public List<Diapositiva> diapositivas = new List<Diapositiva>();

	public int actual = 0;

	// Use this for initialization
	void Start () {

		diapositivas.Add(new Diapositiva("Monte Everest", "1º con 8.848 metros", "Imagenes/Everest"));
		diapositivas.Add(new Diapositiva("K2", "2º con 8.611 metros", "Imagenes/K2"));
		diapositivas.Add(new Diapositiva("Kangchenjunga", "3º con 8.586 metros", "Imagenes/Kangchenjunga"));
		diapositivas.Add(new Diapositiva("Lhotse", "4º con 8.516 metros", "Imagenes/Lhotse"));

		Actualizar();
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.LeftArrow)){
			// Mostrar la anterior
			if(actual <= 0){
				actual = diapositivas.Count-1;
			}
			else {
				actual--;
			}

			Actualizar();
		}
		else if(Input.GetKeyDown(KeyCode.RightArrow)){
			// Mostrar la siguiente
			if(actual >= diapositivas.Count-1){
				actual = 0;
			}
			else{
				actual++;
			}
				
			Actualizar();
		}	
	}

	void Actualizar(){
		titulo.text = diapositivas[actual].titulo;
		descripcion.text = diapositivas[actual].descripcion;
		fotografia.sprite = diapositivas[actual].fotografia;
	}
}
