using UnityEngine;
using System.Collections;

public class GunHandler : MonoBehaviour {

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void shotMissile(GameObject missile)
    {
        //GameObject shot = (GameObject)Instantiate(missile, transform.position, transform.rotation);
        Instantiate(missile, transform.position, transform.rotation);
    }
}
