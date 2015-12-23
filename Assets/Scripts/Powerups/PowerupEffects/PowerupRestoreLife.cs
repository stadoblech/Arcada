using UnityEngine;
using System.Collections;

public class PowerupRestoreLife : MonoBehaviour {

    GameObject player;

    public float percentageRestore;
    float playerMaxLives;

    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        playerMaxLives = player.GetComponent<PlayerLife>().maxLives;

        player.GetComponent<PlayerLife>().actualLives += (playerMaxLives / 100) * percentageRestore;
        if(player.GetComponent<PlayerLife>().actualLives > playerMaxLives)
        {
            player.GetComponent<PlayerLife>().actualLives = playerMaxLives;
        }

        Invoke("destroyObject",2);
        
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void destroyObject()
    {
        Destroy(gameObject);
    }
}
