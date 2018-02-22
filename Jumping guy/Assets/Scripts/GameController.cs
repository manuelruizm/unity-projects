﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum GameState {Idle, Playing, Ended, Ready};

public class GameController : MonoBehaviour {

	[Range (0f, 0.20f)]
	public float parallaxSpeed = 0.02f;
	public RawImage background;
	public RawImage platform;

	public GameObject uiIdle;
	public GameObject uiScore;

	public GameState gameState = GameState.Idle;

	public GameObject player;

	public GameObject enemyGenerator;

	private AudioSource musicPlayer;

	public float scaleTime = 6f;
	public float scaleInc = 0.25f;

	private int points = 0;
	public Text pointsText;
	public Text recordText;

	// Use this for initialization
	void Start () {
		musicPlayer = GetComponent<AudioSource>();
		recordText.text = "BEST: " + GetMaxScore().ToString();
	}
	
	// Update is called once per frame
	void Update () {

		bool userAction = Input.GetKeyDown("up") || Input.GetMouseButtonDown(0);

		// Empieza el juego
		if(gameState == GameState.Idle && userAction){
			gameState = GameState.Playing;
			uiIdle.SetActive(false);
			uiScore.SetActive(true);
			player.SendMessage("UpdateState", "PlayerRun");
			player.SendMessage("DustPlay");
			enemyGenerator.SendMessage("StartGenerator");
			musicPlayer.Play();
			InvokeRepeating("GameTimeScale", scaleTime, scaleTime);
		}

		// Juego en marcha
		else if(gameState == GameState.Playing){
			Parallax();
		}

		// Juego preparado para reiniciarse
		else if(gameState == GameState.Ready){
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
		ResetTimeScale();
		SceneManager.LoadScene("Escena1");
	}

	void GameTimeScale(){
		Time.timeScale += scaleInc;
	}

	public void ResetTimeScale(float newTimeScale = 1f){
		CancelInvoke("GameTimeScale");
		Time.timeScale = newTimeScale;
	}

	public void IncreasePoints(){
		pointsText.text = (++points).ToString();
		if(points >= GetMaxScore()){
			recordText.text = "BEST: " + points.ToString();
			SaveScore(points);
		}
	}

	public int GetMaxScore(){
		return PlayerPrefs.GetInt("Max Points", 0);
	}

	public void SaveScore(int currentPoints){
		PlayerPrefs.SetInt("Max Points", currentPoints);
	}
}
