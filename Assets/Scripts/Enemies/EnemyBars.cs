using UnityEngine;
using System.Collections;

public class EnemyBars : MonoBehaviour {

    public enum BarType
    {
        Hp,Shield
    }

    public GameObject enemy;
    public BarType barType;

    EnemyLife enemyLife;

    float startLife;
    float startShield;

    Vector3 startScale;

    void Start () {
        enemyLife = enemy.GetComponent<EnemyLife>();
        startLife = enemyLife.lives;
        startShield = enemyLife.shield;
        startScale = transform.localScale;

	}
	
	// Update is called once per frame
	void Update () {

        

        switch(barType)
        {
            case BarType.Hp:
                {
                    if (startLife <= 0)
                    {
                        transform.localScale = Vector3.zero;
                        return;
                    }
                    transform.localScale = new Vector3(enemyLife.lives / startLife, 1, 1);
                    break;
                }
            case BarType.Shield:
                {
                    if (startShield <= 0)
                    {
                        transform.localScale = Vector3.zero;
                        return;
                    }
                    transform.localScale = new Vector3(enemyLife.shield / startShield, 1, 1);
                    break;
                }
        }
 	}
}
