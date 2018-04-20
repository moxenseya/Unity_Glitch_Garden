using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StarDisplay : MonoBehaviour {

int stars =100;
Text score;
public enum Status {SUCCESS,FAILURE};
void Start ()
	{
	score= GetComponent<Text>();
	score.text= stars.ToString();
	}

	public void Addstars (int amount)
	{
	stars= stars + amount;
	score.text=stars.ToString();
	}

	public Status spendstars (int amount)
	{
		if (stars >= amount) {
			stars = stars - amount;
			score.text = stars.ToString ();
			return Status.SUCCESS;
		}
		return Status.FAILURE;
	}
}
