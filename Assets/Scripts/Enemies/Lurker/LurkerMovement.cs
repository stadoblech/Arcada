using UnityEngine;
using System.Collections;

public class LurkerMovement : MonoBehaviour {

    public float steadyCooldown;
    public float startingSteadyCooldown;

    public float speed;

    public bool aggresiveMode;
    public float agresiveMovePercentage = 33f;
    public float lurkerAgresionDistance = 1f;

    Transform player;

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

        player = GameObject.FindGameObjectWithTag("Player").transform;

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
                SoundEffectsManager.Instance.lurkerMove();

                if (aggresiveMode && agresiveMovePercentage < Random.Range(0f,100f))
                {
                    print("aggro");
                    destination = new Vector3(player.position.x + Random.Range(-lurkerAgresionDistance, lurkerAgresionDistance), player.position.y + Random.Range(-lurkerAgresionDistance, lurkerAgresionDistance));                    
                }
                else
                {
                    destination = ObjectBasis.getRandomPositionOnScreen();
                }

                steadyTimer = steadyCooldown;
            }

        }else
        {
            transform.position = Vector3.MoveTowards(transform.position,destination,speed * Time.deltaTime);
        }
	}
}
