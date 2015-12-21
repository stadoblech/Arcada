using UnityEngine;
using System.Collections;

public class ObjectStartRescale : MonoBehaviour {

    public float resizeSpeed = 2;

    float startScale;
    bool rescaled;

	void Start () {
        rescaled = false;
        startScale = transform.localScale.x;
        transform.localScale = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.localScale.x < startScale && !rescaled)
        {
            transform.localScale += new Vector3(resizeSpeed, resizeSpeed, resizeSpeed) * Time.deltaTime;
        }
        else
        {
            rescaled = true;
        }
	}
}
