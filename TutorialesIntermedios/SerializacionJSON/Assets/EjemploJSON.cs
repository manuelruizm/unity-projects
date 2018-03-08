using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class EjemploJSON : MonoBehaviour {

	string filePath;
	string jsonString;

	void Awake()
	{
		filePath = Application.dataPath + "/Personaje.json";
		jsonString = File.ReadAllText(filePath);
		Personaje personaje = JsonUtility.FromJson<Personaje>(jsonString);
		print(personaje);

		personaje.nivel = 50;
		jsonString = JsonUtility.ToJson(personaje);
		File.WriteAllText(filePath, jsonString);
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
