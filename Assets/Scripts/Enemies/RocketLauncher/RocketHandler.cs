﻿using UnityEngine;
using System.Collections;

public class RocketHandler : MonoBehaviour {

    public float damage;

    public GameObject markerOnDeath;

    GameObject player;


	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag == player.tag)
        {
            player.GetComponent<PlayerLife>().getHit(damage);

            SoundEffectsManager.Instance.missileExplode();

            Destroy(gameObject);
        }

        if(coll.tag == "PlayerShot")
        {
            SoundEffectsManager.Instance.missileExplode();
            if(markerOnDeath != null)
            {
                Instantiate(markerOnDeath,transform.position,Quaternion.identity);
            }

            Destroy(gameObject);
        }
    }
}
