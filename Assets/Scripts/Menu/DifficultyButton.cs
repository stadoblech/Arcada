using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DifficultyButton : MonoBehaviour {

    public GameDifficulty difficultyButton;

	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnMouseDown()
    {
        Difficulty.difficultyModifier = difficultyButton;
        GameLogic.LoadNextLevel();
    }
}
