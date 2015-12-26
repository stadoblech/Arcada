using UnityEngine;
using System.Collections;

public class ObjectDeathBehaviour : MonoBehaviour {

    public float resizeSpeed = 2;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (GameLogic.gameEnded)
        {
            transform.localScale -= new Vector3(resizeSpeed, resizeSpeed, resizeSpeed) * Time.deltaTime;

            if(transform.localScale.x < 0)
            {
                GameLogic.loadNextLevel = true;
            }
        }

        if (GameLogic.playerDied)
        {
            transform.localScale -= new Vector3(resizeSpeed, resizeSpeed, resizeSpeed) * Time.deltaTime;

            if (transform.localScale.x < 0)
            {
                GameLogic.restartLevel();
            }
        }
    }
}
