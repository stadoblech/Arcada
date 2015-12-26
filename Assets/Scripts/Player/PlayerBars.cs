using UnityEngine;
using System.Collections;

public class PlayerBars : MonoBehaviour {

    public enum BarType
    {
        Hp, Shield
    }

    GameObject player;
    public BarType barType;

    PlayerLife enemyLife;

    float startLife;
    float startShield;

    Vector3 startScale;

    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");

        enemyLife = player.GetComponent<PlayerLife>();
        startLife = enemyLife.maxLives;
        startShield = enemyLife.maxShield;
        startScale = transform.localScale;
    }
	
	// Update is called once per frame
	void Update () {
        switch (barType)
        {
            case BarType.Hp:
                {
                    if (startLife <= 0)
                    {
                        transform.localScale = Vector3.zero;
                        return;
                    }
                    transform.localScale = new Vector3(enemyLife.actualLives / startLife, 1, 1);

                    if (enemyLife.actualLives <= 0)
                    {
                        transform.localScale = new Vector3(0, 1, 1);
                    }

                    break;
                }
            case BarType.Shield:
                {
                    if (enemyLife.maxShield <= 0)
                    {
                        transform.localScale = Vector3.zero;
                        return;
                    }
                    transform.localScale = new Vector3(enemyLife.actualshield / enemyLife.maxShield, 1, 1);
                    break;
                }
        }
    }
        
    
}
