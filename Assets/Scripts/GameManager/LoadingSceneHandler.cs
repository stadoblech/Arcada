using UnityEngine;
using System.Collections;

public class LoadingSceneHandler : MonoBehaviour {

    Transform loadingBar;
	void Start () {
        loadingBar = transform;
	}
	
	// Update is called once per frame
	void Update () {

        loadingBar.localScale = new Vector3(Application.GetStreamProgressForLevel("Level1"),1,1);
        if (Application.GetStreamProgressForLevel("Level1") == 1)
        {
            GameLogic.LoadNextLevel();
        }
    }
}
