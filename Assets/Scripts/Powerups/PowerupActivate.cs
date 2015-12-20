using UnityEngine;
using System.Collections;

public class PowerupActivate : MonoBehaviour {

    public GameObject powerupEffect;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag == "PlayerShot")
        {
            GameObject g = (GameObject)Instantiate(powerupEffect);
            g.SetActive(true);
            Destroy(transform.parent.gameObject);
        }
    }
}
