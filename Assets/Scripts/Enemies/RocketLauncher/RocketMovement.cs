using UnityEngine;
using System.Collections;

public class RocketMovement : MonoBehaviour {

    public float missileSpeed;

    public float turn = 2.5f;

    float lastTurn;

    Vector3 target;

    /// <summary>
    /// make it public and assign in editor or find it by name or tag
    /// </summary>
    GameObject player;

    Rigidbody2D rocketRigidbody;

    void Start()
    {
        ///
        player = GameObject.FindGameObjectWithTag("Player");
        rocketRigidbody = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        target = player.transform.position;

        Quaternion newRotation = Quaternion.LookRotation(transform.position - target, Vector3.forward);
        newRotation.x = 0.0f;
        newRotation.y = 0.0f;
        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime * turn);
        rocketRigidbody.velocity = transform.up * missileSpeed;
        if (turn < 40f)
        {
            lastTurn += Time.deltaTime * Time.deltaTime * 50f;
            turn += lastTurn;
        }

    }
}
