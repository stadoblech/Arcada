using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelNameCreator : MonoBehaviour {

    Text levelName;

    // Use this for initialization
    void Start() {
        levelName = GetComponent<Text>();
        string lName = GameLogic.getActualLevelName();

        if(lName.Contains("Level"))
        {
            string levelNum = lName.Substring(5);
            levelName.text = "Level " + levelNum;
        }else
        {
            levelName.text = "";
        }
    }
}
