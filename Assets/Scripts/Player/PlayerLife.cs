using UnityEngine;
using System.Collections;

[System.Serializable]
public class PlayerLife : MonoBehaviour {

    public float lives;
    public float maxShield;
    public float shieldRegentBySec;

    public float actualshield;

	void Start () {
        actualshield = maxShield;
	}
	
	// Update is called once per frame
	void Update () {
        if(lives <= 0)
        {
            //GameLogic.restartLevel();
            GameLogic.playerDied = true;
        }

        if(actualshield < maxShield)
        {
            actualshield += shieldRegentBySec * Time.deltaTime;
        }
	}

    public void getHit(float damage)
    {
        if (actualshield < 0)
        {
            lives -= damage;
        }else
        {
            float difference;
            actualshield -= damage;

            difference = Mathf.Abs(actualshield);

            if (actualshield < 0)
            {
                actualshield = 0;
                lives -= difference;
            }

        }
    }
}
