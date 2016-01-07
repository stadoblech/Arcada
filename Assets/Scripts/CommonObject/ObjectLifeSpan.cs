using UnityEngine;
using System.Collections;

public class ObjectLifeSpan : MonoBehaviour {

    public float lifeSpan;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        lifeSpan -= Time.deltaTime;

        if(lifeSpan <= 0)
        {
            Destroy(gameObject);
        }
	}
}
