using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class HolsterBox : MonoBehaviour
{
	public bool mouseBoxCheck = false;

	public void OnMouseEnter()
	{
		Debug.Log ("cool bro");
	}


	public void OnMouseOver()
	{
		//Debug.Log ("still cool bro");
		mouseBoxCheck = true;
	}


	public void OnMouseDown()
	{
		Debug.Log ("click");
	}

    public void OnMouseExit()
    {
        Debug.Log("Reset your mouse");
		mouseBoxCheck = false;
        //SceneManager.LoadScene("InGame");
        //GameManager.Instance.ImmediateLoseRestart();    
    }
   
}
