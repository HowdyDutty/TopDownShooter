using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {
	
	public Rigidbody bullet;
	public float fireRate;
	private float lastShot;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Mouse0) && (Time.time > fireRate + lastShot)) {	
            Instantiate(bullet, new Vector3(transform.position.x , 3, transform.position.z + 3.5f), transform.rotation);
			lastShot = Time.time;
		}
	}
}
