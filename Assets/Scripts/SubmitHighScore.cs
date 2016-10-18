using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SubmitHighScore : MonoBehaviour 
{

	public void ViewHighScore()
	{
		SceneManager.LoadScene ("MainMenu");
	}
}
