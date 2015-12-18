using UnityEngine;
using System.Collections;

public class ShotMovement : MonoBehaviour {

    public float speed;
    public Vector3 direction;
    
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = transform.up * speed;

        if(!GetComponent<SpriteRenderer>().isVisible)
        {
            Destroy(gameObject);
        }
	}
}
