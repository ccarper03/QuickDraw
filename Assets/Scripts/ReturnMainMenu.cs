using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class ReturnMainMenu : MonoBehaviour 
{
	public void MainMenu()
	{
		SceneManager.LoadScene ("MainMenu");
	}
}
