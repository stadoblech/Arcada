using UnityEngine;
using System.Collections;

public class BoardSettings : MonoBehaviour {

    public bool looped;
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
