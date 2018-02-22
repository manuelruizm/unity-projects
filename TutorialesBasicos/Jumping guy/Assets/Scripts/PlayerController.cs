using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Animator animator;
	public GameObject game;
	public GameObject enemyGenerator;

	private AudioSource audioPlayer;
	public AudioClip jumpClip;
	public AudioClip dieClip;
	public AudioClip pointClip;

	private float startY;

	public ParticleSystem dust;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		audioPlayer = GetComponent<AudioSource>();
		startY = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		bool gamePlaying = game.GetComponent<GameController>().gameState == GameState.Playing;
		bool isGrounded = transform.position.y == startY;
		bool userAction = Input.GetKeyDown("up") || Input.GetMouseButtonDown(0);

		if(gamePlaying && userAction && isGrounded){
			UpdateState("PlayerJump");

			audioPlayer.clip = jumpClip;
			audioPlayer.Play();
		}
	}

	public void UpdateState(string state = null){
		if(state != null){
			animator.Play(state);
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "Enemy"){
			UpdateState("PlayerDie");
			game.GetComponent<GameController>().gameState = GameState.Ended;
			enemyGenerator.SendMessage("StopGenerator", true);
			game.SendMessage("ResetTimeScale", 0.5f);
			DustStop();

			game.GetComponent<AudioSource>().Stop();
			audioPlayer.clip = dieClip;
			audioPlayer.Play();
		}
		else if(other.gameObject.tag == "Point"){
			game.SendMessage("IncreasePoints");
			audioPlayer.clip = pointClip;
			audioPlayer.Play();
		}
	}

	void GameReady(){
		game.GetComponent<GameController>().gameState = GameState.Ready;
	}

	void DustPlay(){
		dust.Play();
	}

	void DustStop(){
		dust.Stop();
	}
}
