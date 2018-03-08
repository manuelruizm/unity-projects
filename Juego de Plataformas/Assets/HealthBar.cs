using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

	float hp, maxHp = 100f;

	public Image health;

	// Use this for initialization
	void Start () {
		hp = maxHp;
	}
	
	public void TakeDamage(float amount){
		hp = Mathf.Clamp(hp-amount, 0, maxHp);
		health.transform.localScale = new Vector2(hp/maxHp, 1);
	}
}
