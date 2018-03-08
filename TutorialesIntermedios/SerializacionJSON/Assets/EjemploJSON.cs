using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class EjemploJSON : MonoBehaviour {

	string filePath;
	string jsonString;

	void Awake()
	{
		// Un solo personaje

		// filePath = Application.dataPath + "/Personaje.json";
		// jsonString = File.ReadAllText(filePath);
		// Personaje personaje = JsonUtility.FromJson<Personaje>(jsonString);
		// print(personaje);

		// personaje.nivel = 50;
		// jsonString = JsonUtility.ToJson(personaje);
		// File.WriteAllText(filePath, jsonString);

		// Varios personajes

		filePath = Application.dataPath + "/Personajes.json";
		jsonString = File.ReadAllText(filePath);
		ListaPersonajes listaPersonajes = JsonUtility.FromJson<ListaPersonajes>(jsonString);
		listaPersonajes.Listar();

		try{
			listaPersonajes.personajes.Find(p => p.nombre == "Arturo").profesion = "Rey de Bretaña";
			jsonString = JsonUtility.ToJson(listaPersonajes);
			File.WriteAllText(filePath, jsonString);
		} catch (System.NullReferenceException e){
			print("Personaje no encontrado\n" + e);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

[System.Serializable]
public class Personaje {
	public string nombre;
	public string profesion;
	public int nivel;

	public override string ToString(){
		return string.Format("{0}: {1} nivel {2}", nombre, profesion, nivel);
	}
}

[System.Serializable]
public class ListaPersonajes {
	public List<Personaje> personajes;

	public void Listar(){
		foreach(Personaje personaje in personajes){
			Debug.Log(personaje);
		}
	}
}
