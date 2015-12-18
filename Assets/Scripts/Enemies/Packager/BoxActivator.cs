using UnityEngine;
using System.Collections;

public class BoxActivator : MonoBehaviour {

    public GameObject objectToActivate;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag == "Player")
        {
            objectToActivate.GetComponent<BoxBehaviour>().activated = true;
            GetComponent<CircleCollider2D>().enabled = false;
        }

        
    }
}
