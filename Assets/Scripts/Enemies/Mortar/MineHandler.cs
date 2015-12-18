using UnityEngine;
using System.Collections;

public class MineHandler : MonoBehaviour {

    public float speed;
    public float damage;

    GameObject player;
    Vector3 targetPoint;

    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        targetPoint = player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position,targetPoint,speed * Time.deltaTime);

        if(transform.position == targetPoint)
        {
            GetComponent<ObjectRotate>().rotating = false;
        }
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag == "Player")
        {
            Destroy(gameObject);
            coll.gameObject.GetComponent<PlayerLife>().getHit(damage);
        }

        if(coll.tag == "PlayerShot")
        {
            Destroy(coll.gameObject);
            Destroy(gameObject);
        }

    }
}
