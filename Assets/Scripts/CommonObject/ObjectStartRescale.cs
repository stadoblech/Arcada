using UnityEngine;
using System.Collections;

public class ObjectStartRescale : MonoBehaviour {

    public float resizeSpeed = 2;

    float startScale;

	void Start () {
        startScale = transform.localScale.x;
        transform.localScale = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.localScale.x < startScale)
        {
            transform.localScale += new Vector3(resizeSpeed,resizeSpeed,resizeSpeed) * Time.deltaTime;
        }
	}
}
