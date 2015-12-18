using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour {

    public static bool gameEnded;

    public static bool loadNextLevel;

	void Start () {
        gameEnded = false;
        loadNextLevel = false;
	}
	
	// Update is called once per frame
	void Update () {
        if(loadNextLevel)
        {
            loadInterlevel();
        }
    }

    public static void LoadNextLevel()
    {

    }

    public static void loadInterlevel()
    {
        SceneManager.LoadScene(0);
    }
}
