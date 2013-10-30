using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawn : MonoBehaviour {
	
	public Player player;
	public GameObject enemy;
	private List<GameObject> storedEnemies = new List<GameObject>();
	public int maxNumEnemies;
	
	private int counter = 0;
	
	public GameObject topSpawn;
	public GameObject bottemSpawn;
	public GameObject leftSpawn;
	public GameObject rightSpawn;
	
	// Use this for initialization
	void Start () {
		
	}
	
	void Update() {
		if (player.getPlayerDeath()) {
			storedEnemies.ForEach(Destroy);	//After game ends, the enemies are destroyed.
		}
	}
	
	void OnTriggerEnter () {
		
		gameObject.collider.enabled = false;	//Stops collider in this empty gameObject from making new enemies if the player moves around.
		
		//Keeps looping until the player is dead.
		for (int i = 0; i < maxNumEnemies; i++) {
			StartCoroutine(waiting(counter));
			counter++;
		}
		
		/*while(!player.getPlayerDeath()) {
			StartCoroutine(waiting(counter));
			counter++;
		}*/
	}
	
	//Function responsible for the actual spawing of enemies.
	IEnumerator waiting(int counter) {	
		
		yield return new WaitForSeconds(Random.Range(1,2));	//Holds the following code up by a timeDelay.
		
			switch(Random.Range(1,4)) { //Needs to be a random number between 1 & 4. Allows for spawning in a random location.
				
				//Top Spawn.
				case 1: GameObject t = (GameObject) Instantiate(enemy, new Vector3(topSpawn.transform.position.x + Random.Range(-85,85), 3, 
													   topSpawn.transform.position.z - 20), transform.rotation);		//Instantiates enemy in correct location.
						storedEnemies.Add(t);	//Adds the newly instantiated enemy into an List.	
						break;
				
				//Bottem Spawn.
				case 2: GameObject b = (GameObject) Instantiate(enemy, new Vector3(bottemSpawn.transform.position.x + Random.Range(-85,85), 3, 
													   bottemSpawn.transform.position.z + 20), transform.rotation);		//Instantiates enemy in correct location.
						storedEnemies.Add(b);	//Adds the newly instantiated enemy into an List.
						break;
				
				//Left Spawn.
				case 3: GameObject l = (GameObject) Instantiate(enemy, new Vector3(leftSpawn.transform.position.x + 20, 3, //Instantiates enemy in correct location.
													   leftSpawn.transform.position.z + Random.Range(-85,85)), transform.rotation);
						storedEnemies.Add(l);	//Adds the newly instantiated enemy into an List.
						break;
				
				//Right Spawn.
				case 4: GameObject r = (GameObject) Instantiate(enemy, new Vector3(rightSpawn.transform.position.x - 20, 3, //Instantiates enemy in correct location.
													   rightSpawn.transform.position.z + Random.Range(-85,85)), transform.rotation);
						storedEnemies.Add(r);	//Adds the newly instantiated enemy into an List.
						break;
			
		}
		
		//int timeDelay = (int) Mathf.Abs((30-Time.time)/5); //Function for spawn timing, starts off slow and progressively gets faster.
		//Debug.Log(timeDelay);
		
		
	}
}


