using UnityEngine;
using System.Collections;

public class BoxWallsCollisions : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.tag == "PlayerShot")
        {
            if(transform.parent.GetComponent<EnemyLife>().shield >= 0)
            {
                transform.parent.GetComponent<EnemyLife>().shield -= coll.GetComponent<ShotDamage>().damage;
            }else
            {
                transform.parent.GetComponent<EnemyLife>().lives -= coll.GetComponent<ShotDamage>().damage;
            }
            Destroy(coll.gameObject);
        }
    }
}
