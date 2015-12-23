using UnityEngine;
using System.Collections;

public class BoardSettings : MonoBehaviour {

    public bool looped;

    [Tooltip("if you want infinite number of laps put 0 here")]
    public int numberOfLaps;

    public static bool loopedRoute;
    public static int numOfLaps;

	void Awake () {
        loopedRoute = looped;
        numOfLaps = numberOfLaps;
	}


	void Update () {
	
	}
}
