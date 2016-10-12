using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


// Game Manager Class - Singleton Object
public class GameManager : MonoBehaviour
{
    //C# Property to get access to singleton incstance
    // Read only - only has get accessor
    public static GameManager Instance
    {
        // Return reference to private instance
        get
        {
            return Instance;
        }

    }

    //-----------------------------------------------
    private static GameManager instance = null;
    //-----------------------------------------------
    //HighScore
    public int highScore = 0;
    // Is game paused
    public bool isPaused = false;
    //Is player input allowed
    public bool inputAllowed = true;
    // First level Rules Button
    public Button rulesBtn;
    //first level
    public bool isFirstLevel = false;
    //Use this for initialization before Start()
    void Awake()
    {
        //Check if there is an existing instance of the class in the scene
        // if so, destroy this instance
        if (instance)
        {
            DestroyImmediate(gameObject);
            return;
        }
        // Make this active and only instance
        instance = this;

        // Make game manager persistent
        DontDestroyOnLoad(gameObject);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            SceneManager.LoadScene("MainMenu");
            Debug.Log("num one is pressed");
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            SceneManager.LoadScene("InGame");
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            SceneManager.LoadScene("Lose");
        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            SceneManager.LoadScene("Win");
        }
        /*if (Input.GetKeyDown("keypad"))
        {
            SceneManager.LoadScene("MainMenu");
        }*/
    }
    public void RemoveCanvas()
    {
        rulesBtn.enabled = false; 
    }
    

}


 