using UnityEngine;
using System.Collections;

public class BossMovement : MonoBehaviour {

    public float movementOffset;
    public float speed;

    public float stayCooldown;
    float stayTimer;

    Vector3 initialPosition;

    Vector3 newPosition;

	void Start () {
        initialPosition = transform.position;
        stayTimer = stayCooldown;
        newPosition = initialPosition;
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position == newPosition)
        {
            stayTimer -= Time.deltaTime;
            if (stayTimer < 0)
            {

                newPosition = getNewPosition();
                stayTimer = stayCooldown;
            }

        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, newPosition, speed * Time.deltaTime);
        }

    }

    Vector3 getNewPosition()
    {
        return initialPosition + new Vector3(Random.Range(-movementOffset,movementOffset), Random.Range(-movementOffset, movementOffset));
    }
}
