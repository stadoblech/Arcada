using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerShooting : MonoBehaviour {

    [Tooltip("kolik strel kazdou sekundu pri full auto")]
    public float fireRate;

    public KeyCode shot = KeyCode.Space;
    public GameObject missile;


    List<GameObject> guns;

    float fireCadency;

    void Start () {
        fireCadency = 0;

        guns = new List<GameObject>();

        foreach (Transform child in transform)
        {
            guns.Add(child.gameObject);
        }
    }
	
	void Update () {
	    if(Input.GetKey(shot))
        {
            fireCadency -= Time.deltaTime;
            if (fireCadency <= 0)
            {
                foreach (GameObject o in guns)
                {
                    o.GetComponent<GunHandler>().shotMissile(missile);
                }
                fireCadency = (60 / fireRate) / 100;
            }
        }else if(Input.GetKeyUp(shot))
        {
            fireCadency = 0;
        }
	}
}
