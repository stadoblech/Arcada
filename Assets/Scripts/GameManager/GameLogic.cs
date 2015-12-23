using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour {

    public static bool gameEnded;
    public static bool playerDied;

    public static bool loadNextLevel;

	void Start () {
        playerDied = false;
        gameEnded = false;
        loadNextLevel = false;
	}
	
	// Update is called once per frame
	void Update () {
        if(loadNextLevel)
        {
            loadInterlevel();
        }

        if(GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        {
            LoadNextLevel();
        }
    }

    public static void LoadNextLevel()
    {
        
        int numberOfScenes = SceneManager.sceneCountInBuildSettings;
        int nextLevelIndes = SceneManager.GetActiveScene().buildIndex;
        nextLevelIndes++;
        
        if (nextLevelIndes < numberOfScenes)
        {
            SceneManager.LoadScene(nextLevelIndes);
            return;
        }
        
    }

    public static void loadInterlevel()
    {
        SceneManager.LoadScene(0);
    }

    public static void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
