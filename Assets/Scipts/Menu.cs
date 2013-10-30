using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	
	void OnMouseDown() {
		transform.localScale += new Vector3(.5f,0,.5f);
		
	}
	
	void OnMouseUp() {
		transform.localScale -= new Vector3(.5f,0,.5f);	
		
		if (this.tag.Equals("PlayButton"))
			Application.LoadLevel("gameScene");
			
		if (this.tag.Equals("ExitButton"))
			Application.Quit();
	}
}
