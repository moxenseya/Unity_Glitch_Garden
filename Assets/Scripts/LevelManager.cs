using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour {





public void LoadLevel (string name)
	{
	print("Now Loading : "+ name);
	SceneManager.LoadScene(name);
	}

public void QuitLevel (string name)
	{
	print("Request for quit");
	Debug.Log("Log Request for quit");
	SceneManager.UnloadSceneAsync(name);

		}
		public void LoadNextLevel()
		{
		Scene x= SceneManager.GetActiveScene();
		int scenenum=x.buildIndex;
		scenenum++;
		SceneManager.LoadScene(scenenum);
		}

	}