using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour {

public float speed, damage;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	transform.Translate(Vector2.right*speed*Time.deltaTime);
	}
void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.GetComponent<Attacker> ()) {
		Health enemyhealth = other.gameObject.GetComponent<Health>();
		enemyhealth.DealDamage(damage);
		Destroy(gameObject);
		}
	}

}
