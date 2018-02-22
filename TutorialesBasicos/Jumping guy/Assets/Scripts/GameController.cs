using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum GameState {Idle, Playing, Ended};

public class GameController : MonoBehaviour {

	[Range (0f, 0.20f)]
	public float parallaxSpeed = 0.02f;
	public RawImage background;
	public RawImage platform;

	public GameObject uiIdle;

	public GameState gameState = GameState.Idle;

	public GameObject player;

	public GameObject enemyGenerator;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		bool userAction = Input.GetKeyDown("up") || Input.GetMouseButtonDown(0);

		// Empieza el juego
		if(gameState == GameState.Idle && userAction){
			gameState = GameState.Playing;
			uiIdle.SetActive(false);
			player.SendMessage("UpdateState", "PlayerRun");
			enemyGenerator.SendMessage("StartGenerator");
		}

		// Juego en marcha
		else if(gameState == GameState.Playing){
			Parallax();
		}

		else if(gameState == GameState.Ended){
			if(userAction){
				RestartGame();
			}
		}

	}

	void Parallax(){
		float finalSpeed = parallaxSpeed * Time.deltaTime;
		background.uvRect = new Rect(background.uvRect.x + finalSpeed, 0f, 1f, 1f);
		platform.uvRect = new Rect(platform.uvRect.x + finalSpeed * 4, 0f, 1f, 1f);
	}

	public void RestartGame(){
		SceneManager.LoadScene("Escena1");
	}
}
