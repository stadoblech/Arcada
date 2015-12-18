using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LineCreator : MonoBehaviour {

    public GameObject line;
    Vector3 lineDestination;

    GameObject nLine;
    void Start () {

        List<GameObject> points = new List<GameObject>();

        int currentPoint = int.Parse(name);

        if (!BoardSettings.loopedRoute)
        {
            foreach (Transform t in GameObject.FindGameObjectWithTag("Route").transform)
            {
                if ((currentPoint + 1).ToString() == t.name)
                {
                    lineDestination = t.position;
                    break;
                }
                lineDestination = transform.position;
            }
        }else
        {
            Vector3 startPoint = new Vector3();
            foreach (Transform t in GameObject.FindGameObjectWithTag("Route").transform)
            {
                if ( "0" == t.name)
                {
                    startPoint = t.position;
                }

                if ((currentPoint + 1).ToString() == t.name)
                {
                    lineDestination = t.position;
                    break;
                }
                lineDestination = startPoint;
            }
        }

        nLine = (GameObject)Instantiate(line);
        nLine.GetComponent<LineRenderer>().SetPosition(0,transform.position);

        nLine.GetComponent<LineRenderer>().SetPosition(1, lineDestination);
        
    }
	
	// Update is called once per frame
	void Update () {

	}
}
