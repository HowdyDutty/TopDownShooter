using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	
	private GameObject player;
	public Bullet bullet;
	private float maxDistance = 1f;
	
	public float rotationSpeed;
	public float moveSpeed;
	public int totalHealth;
	
	public int enemyDamage;
	
	CharacterController character;
	
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player"); //Assigns 'player' to the gameObject with tag 'Player'.
		character = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector3 direction = player.transform.position - transform.position;
		direction.y = 0;
			
		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), rotationSpeed * Time.deltaTime);		
		
		if (direction.magnitude > maxDistance) 
			character.Move(transform.forward * moveSpeed * Time.deltaTime);
		
		enemyDied();
	}
	
	public bool enemyDied() {
		if (totalHealth <= 0) {
			Destroy(this.gameObject); 
			return true;
		}
		
		else 
			return false;
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.tag.Equals("Bullet")) 
			totalHealth -= bullet.getBulletDamage();
	}
	
	public int getEnemyDamage() {
		return enemyDamage;	
	}
}
