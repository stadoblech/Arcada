using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed;

    int actualPoint;
    int numberOfPoints;
    int currentLap;

    Vector3 destination;

	void Start () {
        currentLap = 0;
        actualPoint = 0;


        foreach (Transform t in GameObject.FindGameObjectWithTag("Route").transform)
        {
            if (t.name == "0")
            {
                transform.position = t.position;
            }
            numberOfPoints++;
        }

        destination = changeDestination(); 
	}
	
	void Update () {

        transform.position = Vector3.MoveTowards(transform.position,destination,speed*Time.deltaTime);

        if(transform.position == destination)
        {
            destination = changeDestination();
        }

        if (BoardSettings.loopedRoute)
        {
            if(currentLap == BoardSettings.numOfLaps+1)
            {
                GameLogic.LoadNextLevel();
            }else if(BoardSettings.numOfLaps < 0)
            {
                /// infinite number of laps. Only if number of laps is set to 0 or less 
            }
        }
    }

    Vector3 changeDestination()
    {
        Vector3 startPoint = new Vector3();

        foreach (Transform t in GameObject.FindGameObjectWithTag("Route").transform)
        {
            if (t.name == "0")
            {
                startPoint = t.position;
            }

            if (t.name == (actualPoint + 1).ToString())
            {
                actualPoint++;
                return t.transform.position;
            }
        }

        if(BoardSettings.loopedRoute)
        {
            actualPoint = 0;
            currentLap++;
            return startPoint;
        }

        /// here is level over if not looped. Place game lofic here
        print("here is level over if not looped. Place game lofic here");

        return transform.position;
    }
}
