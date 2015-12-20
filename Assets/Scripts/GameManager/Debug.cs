﻿using UnityEngine;
using System.Collections;

public class Debug : MonoBehaviour {

    public GameObject player;
    public GameObject mortar;
    public GameObject packager;
    public GameObject rocketLauncher;
    public GameObject lurker;
    public AudioSource music;    

    public KeyCode immortal = KeyCode.I;
    public KeyCode respawnMortar = KeyCode.Alpha1;
    public KeyCode respawnPackager = KeyCode.Alpha2;
    public KeyCode respawnRocketLauncher = KeyCode.Alpha3;
    public KeyCode respawnLurker = KeyCode.Alpha4;
    public KeyCode cameraFollowPlayer = KeyCode.F;
    public KeyCode acceleratePlayer = KeyCode.KeypadPlus;
    public KeyCode deceleratePlayer = KeyCode.KeypadMinus;
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        GameObject g;

        if (Input.GetKeyDown(respawnMortar))
        {
            g = (GameObject)Instantiate(mortar);
            g.transform.position = ObjectBasis.getRandomPositionOnScreen();
        }

        if (Input.GetKeyDown(respawnPackager))
        {
            g = (GameObject)Instantiate(packager);
            g.transform.position = ObjectBasis.getRandomPositionOnScreen();
        }

        if (Input.GetKeyDown(respawnRocketLauncher))
        {
            g = (GameObject)Instantiate(rocketLauncher);
            g.transform.position = ObjectBasis.getRandomPositionOnScreen();
        }

        if (Input.GetKeyDown(respawnLurker))
        {
            g = (GameObject)Instantiate(lurker);
            g.transform.position = ObjectBasis.getRandomPositionOnScreen();
        }

        if (Input.GetKeyDown(cameraFollowPlayer))
        {
            Camera.main.GetComponent<CameraHandler>().followingPlayer = true;
        }

        if (Input.GetKeyDown(acceleratePlayer))
        {
            player.GetComponent<PlayerMovement>().speed += 0.2f;
        }

        if (Input.GetKeyDown(deceleratePlayer))
        {
            player.GetComponent<PlayerMovement>().speed -= 0.2f;
            if(player.GetComponent<PlayerMovement>().speed <= 0.1f)
            {
                player.GetComponent<PlayerMovement>().speed = 0.1f;
            }
        }

    }
}
