using UnityEngine;
using System.Collections;

public class EnemyBitsBehaviour : MonoBehaviour {

    public float timeToLive;

    public float speed;
    float rotationSpeed;

    private Vector3 direction;

	void Start () {
        direction = new Vector3(Random.Range(-1f,1f),Random.Range(-1f,1f));
        rotationSpeed = Random.Range(-360f,360f);
    }
	
	// Update is called once per frame
	void Update () {

        transform.position += speed * direction * Time.deltaTime;
        transform.Rotate(0,0,rotationSpeed * Time.deltaTime);

        timeToLive -= Time.deltaTime;
        if(timeToLive <= 0)
        {
            Destroy(gameObject);
        }

	}
}
