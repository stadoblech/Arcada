using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameControlls : MonoBehaviour {

    public KeyCode restartGame = KeyCode.R;
    public KeyCode quitGame = KeyCode.Q;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(restartGame))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKeyDown(quitGame))
        {
            Application.Quit();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
