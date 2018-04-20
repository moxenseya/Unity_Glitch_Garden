using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {
public Camera mycam;
	// Use this for initialization
	private GameObject parentobj;
	private StarDisplay stardisp;
	



	void Start () {
	stardisp = GameObject.FindObjectOfType<StarDisplay>();
		if(!GameObject.Find("Defenders"))
parentobj= new GameObject("Defenders");
else
parentobj = GameObject.Find("Defenders");
}


	void OnMouseDown ()
	{
	GameObject defender = ButtonScript.selectedDefender;
	int defendercost = defender.GetComponent<Defender>().starCost;
		if (stardisp.spendstars (defendercost) == StarDisplay.Status.SUCCESS) {
			Vector3 Pos = new Vector3 (RoundEmUp (CalculateMousePosition ()).x, RoundEmUp (CalculateMousePosition ()).y, 0);
			Instantiate (ButtonScript.selectedDefender, Pos, Quaternion.identity, parentobj.transform);
		} else {
		Debug.Log("Not Enough Stars");
		}

	}

	Vector2 CalculateMousePosition ()
	{
	float mouseX= Input.mousePosition.x;
	float mouseY= Input.mousePosition.y;
	float distance =10f;
	Vector3 wierdtriplet= new Vector3(mouseX,mouseY,distance);
	Vector2 pos = mycam.ScreenToWorldPoint(wierdtriplet);
	return pos;
	}

	Vector2 RoundEmUp (Vector2 rawvals)
	{
	Vector2 sol = new Vector2(Mathf.RoundToInt(rawvals.x),Mathf.RoundToInt(rawvals.y));
	return sol;
	}
}
