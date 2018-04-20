using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ButtonScript : MonoBehaviour {
ButtonScript[] buttonarray;
public static GameObject selectedDefender;
SpriteRenderer spriteRenderer;
public GameObject defenderprefab;

	// Use this for initialization
	void Start () {
		
		buttonarray= GameObject.FindObjectsOfType<ButtonScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
void OnMouseDown ()
	{
		foreach(ButtonScript thisbutton in buttonarray)
	{
	thisbutton.GetComponent<SpriteRenderer>().color=Color.black;
	}

	GetComponent<SpriteRenderer>().color=Color.white;
	selectedDefender= defenderprefab;
 	}
}
