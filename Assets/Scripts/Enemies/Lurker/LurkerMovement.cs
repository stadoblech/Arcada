using UnityEngine;
using System.Collections;

public class LurkerMovement : MonoBehaviour {

    public float steadyCooldown;
    public float startingSteadyCooldown;

    public float speed;

    float steadyTimer;
    Vector3 destination;

    public bool steadyMode
    {
        get
        {
            if(destination == transform.position)
            {
                return true;
            }
            return false;
        }
    }

	void Start () {

        destination = transform.position;

        if (startingSteadyCooldown == 0)
        {
            steadyTimer = steadyCooldown;
        }
        else
            steadyTimer = startingSteadyCooldown;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (transform.position == destination)
        {
            steadyTimer -= Time.deltaTime;
            if(steadyTimer < 0)
            {
                destination = ObjectBasis.getRandomPositionOnScreen();
                steadyTimer = steadyCooldown;
            }

        }else
        {
            transform.position = Vector3.MoveTowards(transform.position,destination,speed * Time.deltaTime);
        }
	}
}
