using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameTimer : MonoBehaviour {

Slider slider;

public float levelSeconds=100;
bool EndOfLvl= false;
LevelManager lvlmgr;
AudioSource audiosrc;
	// Use this for initialization
	void Start () {
		slider = GetComponent<Slider>();
		lvlmgr = FindObjectOfType<LevelManager>();
		audiosrc = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		slider.value = Time.timeSinceLevelLoad / levelSeconds;
		if (Time.timeSinceLevelLoad >= levelSeconds && !EndOfLvl){
				audiosrc.Play();
		Invoke("LoadLevel",audiosrc.clip.length);
		EndOfLvl = true;
		}


	}
void LoadLevel()
{
lvlmgr.LoadNextLevel();
}

}
