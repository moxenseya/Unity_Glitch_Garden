using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour {
StarDisplay stardisp;

public int starCost = 100;


void Start()
{
stardisp = FindObjectOfType<StarDisplay>();
}

void AddStars (int amount)
	{
	stardisp.Addstars(amount);
	}
}
