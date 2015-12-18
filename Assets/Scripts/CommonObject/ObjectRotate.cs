using UnityEngine;
using System.Collections;

public class ObjectRotate : MonoBehaviour {

    public bool rotating;
    public float rotateSpeed;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(rotating)
        {
            transform.Rotate(0,0,rotateSpeed*Time.deltaTime);
        }
	}
}
