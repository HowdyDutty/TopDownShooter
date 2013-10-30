using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour { 
	
	//Initialization. 
	public int moveSpeed;	
	private int _totalHealth = 100;
	public int totalHealth {
		get { return _totalHealth; }
	}
	
	private int _enemiesKilled = 0;
	public int enemiesKilled {
		get { return _enemiesKilled; }
	}
	
	public Enemy enemy;
	
	void Start () {
	}
	
	void Update () {
		
		//Movement.
		if (this.transform.position.z <= 51f)
			if (Input.GetKey(KeyCode.W))														
				transform.position += new Vector3(0,0,moveSpeed*Time.deltaTime);
		
		if (this.transform.position.z >= -50f)
			if (Input.GetKey(KeyCode.S))														
				transform.position -= new Vector3(0,0,moveSpeed*Time.deltaTime);
		
		if (this.transform.position.x <= 67.8f)
			if (Input.GetKey(KeyCode.D))														
				transform.position += new Vector3(moveSpeed*Time.deltaTime,0,0);
		
		if (this.transform.position.x >= -68.5f)
			if (Input.GetKey(KeyCode.A))														
				transform.position -= new Vector3(moveSpeed*Time.deltaTime,0,0);	
		
		if (enemy.enemyDied())
			_enemiesKilled++;
		Debug.Log(_enemiesKilled);
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.tag.Equals("Enemy")) 
			_totalHealth -= enemy.getEnemyDamage(); //Subtracts player's total health by the enemy's damage output.
	}
	
	//Getter for use in the Spawn Class. Returns if the player is dead or not.
	public bool getPlayerDeath() {
		
		if (_totalHealth > 0)
			return false; 
		else 
			return true;
	}
}
