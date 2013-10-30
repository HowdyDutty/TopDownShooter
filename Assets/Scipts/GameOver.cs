using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	
	public Light dLight;
	public GameObject cover;
	public GameObject play;
	public GameObject exit;
	
	public Player player;
	public Enemy enemy;
	
	public GUIText gameTime;
	public GUIText killCount;
	private bool onlyOnce;
	
	void Start() {
		onlyOnce = true;	
	}
	
	// Update is called once per frame
	void Update () {
		if (player.getPlayerDeath() && onlyOnce) {
			
			string minutes = Mathf.Floor(Time.time/60).ToString("00");
			string seconds = Mathf.RoundToInt(Time.time%60).ToString("00");
			
			GameObject screenCover = (GameObject) Instantiate(cover, new Vector3(0,20,0), transform.rotation);
			GameObject playButton  = (GameObject) Instantiate(play, new Vector3(-20,25,-15), Quaternion.Euler(0,180,0));
			GameObject exitButton  = (GameObject) Instantiate(exit, new Vector3(20,25,-15), Quaternion.Euler(0,180,0));
		
			gameTime.guiText.transform.Translate(new Vector3(0, 0, 0));
			killCount.guiText.transform.Translate(new Vector3(0, 0, 0));			
			gameTime.text = "Survived for: " + minutes + " min " + seconds + " sec";			
			killCount.text = "Kill Count: " + player.enemiesKilled;
		
			Destroy(dLight);
			onlyOnce = false;
		}
	}
}
