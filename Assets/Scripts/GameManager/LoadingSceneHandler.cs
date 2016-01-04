using UnityEngine;
using System.Collections;

public class LoadingSceneHandler : MonoBehaviour {

	void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        if (Application.GetStreamProgressForLevel("Level1") == 1)
        {
            GameLogic.LoadNextLevel();
        }
    }
}
