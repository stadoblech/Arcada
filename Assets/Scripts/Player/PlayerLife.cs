using UnityEngine;
using System.Collections;

public class PlayerLife : MonoBehaviour {

    public float maxLives;
    public float maxShield;

    public float actualLives;
    public float shieldRegentBySec;

    public float actualshield;

	void Awake () {
        actualshield = maxShield;
        actualLives = maxLives;
	}
	
	// Update is called once per frame
	void Update () {
        if(actualLives <= 0)
        {
            //GameLogic.restartLevel();
            GameLogic.playerDied = true;
        }


        if (actualshield < maxShield)
        {
            actualshield += shieldRegentBySec * Time.deltaTime;
        }
        else
            actualshield = maxShield;
    }

    public void getHit(float damage)
    {
        if (actualshield < 0)
        {
            actualLives -= damage;
        }else
        {
            float difference;
            actualshield -= damage;

            difference = Mathf.Abs(actualshield);

            if (actualshield < 0)
            {
                actualshield = 0;
                actualLives -= difference;
            }

        }
    }
}
