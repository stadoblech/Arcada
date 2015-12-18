using UnityEngine;
using System.Collections;

public class CameraHandler : MonoBehaviour {

    public bool followingPlayer;
    GameObject player;

    Camera thisCamera;

    void Start () {

        thisCamera = Camera.main;
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void LateUpdate () {
	    if(followingPlayer)
        {
            transform.position = new Vector3(player.transform.position.x,player.transform.position.y,thisCamera.transform.position.z);
            //GetComponent<Rigidbody2D>().position = new Vector3(player.transform.position.x, player.transform.position.y, thisCamera.transform.position.z);
        }

        
	}
}
