using UnityEngine;
using System.Collections;

public class FadeTest : MonoBehaviour {

	float opacity = 1f;
	float timer = 2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		timer -= Time.deltaTime;
		if (timer <= 0f) {
			opacity -= Time.deltaTime;
			if (opacity > 0f)
				this.GetComponent<MeshRenderer> ().material.color = new Color (0f, 0f, 0f, opacity);
		}
	}
}
