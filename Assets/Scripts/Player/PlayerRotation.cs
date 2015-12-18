using UnityEngine;
using System.Collections;

public class PlayerRotation : MonoBehaviour {

    public float rotationSpeed = 25;
    public KeyCode leftRotation = KeyCode.LeftArrow;
    public KeyCode rightRotation= KeyCode.RightArrow;


	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKey(leftRotation))
        {
            transform.Rotate(0,0,rotationSpeed*Time.deltaTime);
        }
        else if(Input.GetKey(rightRotation))
        {
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
        }
	}
}
