using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCondition : MonoBehaviour {

LevelManager lvlmgr;

void Start()
{
lvlmgr= GameObject.FindObjectOfType<LevelManager>();
}

void OnTriggerEnter2D(Collider2D other)
{
lvlmgr.LoadLevel("LoseScreen");
}

	}
