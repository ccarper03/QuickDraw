using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class HolsterBox : MonoBehaviour
{
    public void OnMouseExit()
    {
        Debug.Log("Bang your dead");
        SceneManager.LoadScene("InGame");
        //GameManager.Instance.ImmediateLoseRestart();    
    }
   
}
