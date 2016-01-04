using UnityEngine;
using System.Collections;

public class DifficultyKeyboardHandler : MonoBehaviour {

    public KeyCode up = KeyCode.UpArrow;
    public KeyCode down = KeyCode.DownArrow;
    public KeyCode confirm = KeyCode.Return;

    public Transform easy;
    public Transform medium;
    public Transform hard;

	void Start () {
        transform.position = easy.position;
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(up) && transform.position == easy.position)
        {
            transform.position = hard.position;
        }else if(Input.GetKeyDown(up) && transform.position == hard.position)
        {
            transform.position = medium.position;
        }
        else if (Input.GetKeyDown(up) && transform.position == medium.position)
        {
            transform.position = easy.position;
        }

        if (Input.GetKeyDown(down) && transform.position == easy.position)
        {
            transform.position = medium.position;
        }
        else if (Input.GetKeyDown(down) && transform.position == hard.position)
        {
            transform.position = easy.position;
        }
        else if (Input.GetKeyDown(down) && transform.position == medium.position)
        {
            transform.position = hard.position;
        }

        if(Input.GetKeyDown(confirm))
        {
            if(transform.position == easy.position)
            {
                Difficulty.difficultyModifier = GameDifficulty.Easy;
                GameLogic.LoadNextLevel();
            }
            else if (transform.position == medium.position)
            {
                Difficulty.difficultyModifier = GameDifficulty.Medium;
                GameLogic.LoadNextLevel();
            }
            else if (transform.position == hard.position)
            {
                Difficulty.difficultyModifier = GameDifficulty.Hard;
                GameLogic.LoadNextLevel();
            }
        }
    }
}
