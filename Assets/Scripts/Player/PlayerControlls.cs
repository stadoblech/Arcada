using UnityEngine;
using System.Collections;

public class PlayerControlls : MonoBehaviour {

    public float rotationSpeed = 25;
    public KeyCode leftRotation = KeyCode.LeftArrow;
    public KeyCode rightRotation= KeyCode.RightArrow;

    public KeyCode acceleratePlayer = KeyCode.KeypadPlus;
    public KeyCode deceleratePlayer = KeyCode.KeypadMinus;
    public float maxPlayerSpeed;
    public float minPlayerSpeed;
    public float changeSpeedRate;

    public bool changeSpeedAllowed = true;

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

        if (changeSpeedAllowed)
        {
            if (Input.GetKeyDown(acceleratePlayer))
            {
                transform.parent.GetComponent<PlayerMovement>().speed += changeSpeedRate;
                if (transform.parent.GetComponent<PlayerMovement>().speed >= maxPlayerSpeed)
                {
                    transform.parent.GetComponent<PlayerMovement>().speed = maxPlayerSpeed;
                }
            }

            if (Input.GetKeyDown(deceleratePlayer))
            {
                transform.parent.GetComponent<PlayerMovement>().speed -= changeSpeedRate;
                if (transform.parent.GetComponent<PlayerMovement>().speed <= minPlayerSpeed)
                {
                    transform.parent.GetComponent<PlayerMovement>().speed = minPlayerSpeed;
                }
            }
        }
    }
}
