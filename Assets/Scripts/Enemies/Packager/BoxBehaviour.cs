using UnityEngine;
using System.Collections;

public class BoxBehaviour : MonoBehaviour {

    public float rescaleSpeed;
    public float startScale;
    public float speed;

    public bool activated;

    Vector3 originalScale;
    bool rescaling;
    bool followingPlayer;

    bool soundPlayed;

	void Start () {
        soundPlayed = false;
        rescaling = false;
        followingPlayer = true;
        originalScale = transform.localScale;
        transform.localScale = new Vector3(startScale,startScale,startScale);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (activated)
        {
            transform.parent.position = Vector3.MoveTowards(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position, speed * Time.deltaTime);
            if (rescaling)
            {
                transform.localScale += new Vector3(rescaleSpeed, rescaleSpeed, rescaleSpeed) * Time.deltaTime;
                if (transform.localScale.x >= originalScale.x)
                {
                    rescaling = false;
                }
            }
        }

        if(transform.parent.position == GameObject.FindGameObjectWithTag("Player").transform.position && !soundPlayed)
        {
            SoundEffectsManager.Instance.packagerAction();
            soundPlayed = true;
            return;
        }
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        rescaling = true;
        GetComponent<BoxCollider2D>().enabled = false;
    }
}
