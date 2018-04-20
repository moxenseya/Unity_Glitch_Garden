using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour {

static string volumename ="MASTER_VOLUME";
static string difficultyname = "MASTER_DIFFICULTY";


static float VOLUME;
 static int DIFFICULTY;

public static void setVolume (float vol)
	{
	PlayerPrefs.SetFloat(volumename,vol);

	}


public static void setDifficulty (int difficultylevel)
	{
	PlayerPrefs.SetFloat(difficultyname,difficultylevel);

	}

	public static float getVolume()
	{
	return PlayerPrefs.GetFloat(volumename);
	}

	public static int getDifficulty()
	{
	return PlayerPrefs.GetInt(difficultyname);
	}
}
