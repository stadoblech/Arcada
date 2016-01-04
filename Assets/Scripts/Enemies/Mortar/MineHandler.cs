using UnityEngine;
using System.Collections;

public class MineHandler : MonoBehaviour {

    public float speed;
    public float damage;

    GameObject player;
    Vector3 targetPoint;

    bool onTarget;
    void Start () {
        onTarget = false;

        player = GameObject.FindGameObjectWithTag("Player");
        targetPoint = player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position,targetPoint,speed * Time.deltaTime);

        if(transform.position == targetPoint && !onTarget)
        {
            SoundEffectsManager.Instance.mineArmed();
            GetComponent<ObjectRotate>().rotating = false;
            onTarget = true;
        }
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag == "Player")
        {
            SoundEffectsManager.Instance.missileExplode();
            Destroy(gameObject);
            coll.gameObject.GetComponent<PlayerLife>().getHit(damage);
        }

        if(coll.tag == "PlayerShot")
        {
            SoundEffectsManager.Instance.missileExplode();
            Destroy(coll.gameObject);
            Destroy(gameObject);
        }

    }
}
