using UnityEngine;
using System.Collections;

public class EnemyDestructionHandler : MonoBehaviour {

    EnemyLife enemyLife;
	// Use this for initialization
	void Start () {
        enemyLife = GetComponent<EnemyLife>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	    if(!enemyLife.living)
        {
            print("dead");
        }
	}
}
