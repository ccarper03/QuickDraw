using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour {

	public void RstrtLvl()
	{
		SceneManager.LoadScene ("InGame");
	}
}
