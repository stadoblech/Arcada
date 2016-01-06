using UnityEngine;
using System.Collections;

public class MainMenuKeyboardHandler : MonoBehaviour {

    public KeyCode up = KeyCode.UpArrow;
    public KeyCode down = KeyCode.DownArrow;
    public KeyCode confirm = KeyCode.Return;

    public Transform newGame;
    public Transform continueGame;

    void Start () {
        transform.position = newGame.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(up) && transform.position == newGame.position)
        {
            transform.position = continueGame.position;
        }
        else if (Input.GetKeyDown(up) && transform.position == continueGame.position)
        {
            transform.position = newGame.position;
        }

        if (Input.GetKeyDown(down) && transform.position == newGame.position)
        {
            transform.position = continueGame.position;
        }
        else if (Input.GetKeyDown(down) && transform.position == continueGame.position)
        {
            transform.position = newGame.position;
        }

        
        if (Input.GetKeyDown(confirm))
        {
            if (transform.position == continueGame.position)
            {
                GameLogic.loadSavedLevel();
            }
            else if (transform.position == newGame.position)
            {
                GameLogic.LoadNextLevel();
            }
        }
        

    }
}
