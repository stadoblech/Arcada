using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndGameSceneScript : MonoBehaviour {

    public KeyCode continueToMenu = KeyCode.Space;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(continueToMenu))
        {
            SceneManager.LoadScene("Menu");
        }
	}
}
