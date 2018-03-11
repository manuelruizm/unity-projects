using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;

	void Awake()
	{
		if(instance == null) instance = this;
		else if(instance != this) Destroy(gameObject);
		DontDestroyOnLoad(this);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown("1")){
			print("Cambiando a escena Principal");
			SceneManager.LoadScene("Principal");
		}
		else if(Input.GetKeyDown("2")){
			print("Cambiando a escena Juego");
			SceneManager.LoadScene("Juego");
		}
		else if(Input.GetKeyDown("3")){
			print("Cambiando a escena Créditos");
			SceneManager.LoadScene("Creditos");
		}
	}
}
