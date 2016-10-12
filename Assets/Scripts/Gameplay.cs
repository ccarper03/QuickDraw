using UnityEngine;
using System.Collections;

public class Gameplay : MonoBehaviour {

	//the following are variables to store the multiple accessories for the enemy character to be randomly generated
	public GameObject[] body;
	public GameObject[] head;
	public GameObject[] shirt;
	public GameObject[] pants; //shirt and pants may be one variable or part of the body
	public GameObject[] accessory1;
	//miscellaneous accessories for the enemy may be optional

	//timer(s) to keep track of high noon
	float lengthOfTime;
	float timer;

	//keep track of levels
	public int level = 1;

	//boolean(s) to check and keep track of events
	bool cursorInBox;

	// Use this for initialization
	void Start () {
		//need to know what the period of time should be
		lengthOfTime = Random.Range (3f, 12f);
		timer = lengthOfTime;

		//instantiate the enemy
		//?check to instantiate either randomly generated character or specific character i.e. first and boss enemies??
	}
	
	// Update is called once per frame
	void Update () {
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
