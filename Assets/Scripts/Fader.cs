using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Fader : MonoBehaviour {

public float fadeintime=3f;
private Image fadepanel;
private Color currentcolor= Color.black;
	// Use this for initialization
	void Start () {
		fadepanel= GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (Time.timeSinceLevelLoad < fadeintime) {
		float alphachange = Time.deltaTime/fadeintime;
		currentcolor.a-=alphachange;
		fadepanel.color=currentcolor;
		}
		else{
		gameObject.SetActive(false);
		}
	}
}
