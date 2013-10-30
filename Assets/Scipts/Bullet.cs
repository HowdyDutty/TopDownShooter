using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	
	public float bulletSpeed;
	public int bulletDamage;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Translate(Vector3.up * Time.deltaTime * bulletSpeed);

		if ((this.transform.position.z >= 52f) || (this.transform.position.z <= -51f) ||
		    (this.transform.position.x >= 68f) || (this.transform.position.x <= -69f))
			Destroy(this.gameObject);
			
	}
	
	void OnTriggerEnter() {
		Destroy(this.gameObject);	 //If it collides with something.
	}
	
	public int getBulletDamage() {
		//Debug.Log(bulletDamage);
		return bulletDamage;
	}

}
