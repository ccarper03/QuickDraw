using UnityEngine;
using System.Collections;

public class Gameplay : MonoBehaviour {

	//player character
	public GameObject player;
	//may not need to instantiate player

	//variables for prefabs of enemy characters
	public GameObject enemy1;
	public GameObject enemy2;
	public GameObject enemy3;
	public GameObject enemy4;

	//timer(s) to keep track of high noon
	float lengthOfTime;
	float timer;

	//keep track of levels
	public int level = 1;

	//HolsterBox mouseBoxCheck = GetComponent<HolsterBox>();
	public bool mouseBoxCheck;

	// Use this for initialization
	void Start () {
		//need to know what the period of time should be
		lengthOfTime = Random.Range (2f, 10f);
		timer = lengthOfTime;


		//instantiate the enemy

		mouseBoxCheck = GameObject.Find ("GunHolsteredHitBox").GetComponent<HolsterBox> ().mouseBoxCheck;
	}
	
	// Update is called once per frame
	void Update () {
		mouseBoxCheck = GameObject.Find ("GunHolsteredHitBox").GetComponent<HolsterBox> ().mouseBoxCheck;
		Debug.Log (mouseBoxCheck);
		//if statement to check if the cursor is NOT in the box
		//{
			//if timer >= 0
			//{
				//prompt player to put the cursor in the box
				//timer = lengthOfTime;		//timer is reset to the original set time
			//}
		//}
		//while cursor is in the box
		//{
			//timer -= Time.deltaTime;
			//if(timer <= 0)
			//{
				//prompt user to fire weapon
			//}
		//}
	}
}
