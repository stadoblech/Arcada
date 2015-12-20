using UnityEngine;
using System.Collections;

public class PowerupRapidFire : MonoBehaviour {

    public float powerupFireRate;
    public float powerupDuration;

    GameObject player;
    float playersDefaultFireRate;

    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        playersDefaultFireRate = player.GetComponent<PlayerShooting>().fireRate;
        player.GetComponent<PlayerShooting>().fireRate = powerupFireRate;


    }
	
	// Update is called once per frame
	void Update () {
        powerupDuration -= Time.deltaTime;
        if(powerupDuration <= 0)
        {
            player.GetComponent<PlayerShooting>().fireRate = playersDefaultFireRate;
            Destroy(gameObject);
        }    
	}
}
