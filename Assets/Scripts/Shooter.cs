using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {
public GameObject projectile;
private GameObject parentobj;
public Animator anim;
private GameObject mylanespawner;
private SpawnerScript[] spawnerArray;

void Start()
{
spawnerArray = FindObjectsOfType<SpawnerScript>();

anim = gameObject.GetComponent<Animator>();

if(!GameObject.Find("Projectiles"))
parentobj= new GameObject("Projectiles");
else
parentobj = GameObject.Find("Projectiles");

SetMyLaneSpawner();
}


private void Fire()
{
//Instantiate your projectiles here. This method will be called by animation events thingy.
Instantiate(projectile,new Vector3(transform.position.x+.5f,transform.position.y, transform.position.z),Quaternion.identity,parentobj.transform);

}


void Update ()
	{
		if (EnemyFoundInLane ()==true) {
		anim.SetBool("IsAttacking",true);
		}
		else if(EnemyFoundInLane() ==false)
		anim.SetBool("IsAttacking",false);
	}

	bool EnemyFoundInLane ()
	{
		if (mylanespawner.transform.childCount <= 0)
			return false;
		foreach (Transform child in mylanespawner.transform) {
		if(child.transform.position.x > transform.position.x)
		return true;
		}
		return false;
	}


	void SetMyLaneSpawner ()
	{
		foreach (SpawnerScript spawner in spawnerArray) {
			if (spawner.gameObject.transform.position.y == transform.position.y) {
				mylanespawner = spawner.gameObject;
				Debug.Log("MY lane Spawner is: " + mylanespawner.name);
				break;
			}
				
		}
		if(mylanespawner == null)
		Debug.Log("Cant find a spawner in current lane");

	}


}
