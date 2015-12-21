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
        startLife = enemyLife.lives;
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
                    transform.localScale = new Vector3(enemyLife.lives / startLife, 1, 1);

                    if (enemyLife.lives <= 0)
                    {
                        transform.localScale = new Vector3(0, 1, 1);
                    }

                    break;
                }
            case BarType.Shield:
                {
                    if (startShield <= 0)
                    {
                        transform.localScale = Vector3.zero;
                        return;
                    }
                    transform.localScale = new Vector3(enemyLife.actualshield / startShield, 1, 1);
                    break;
                }
        }
    }
        
    
}
