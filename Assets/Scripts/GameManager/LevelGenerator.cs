using UnityEngine;
using System.Collections;

public class LevelGenerator : MonoBehaviour {

    public int numberOfNodes;

    GameObject route;
    GameObject node;

	void Awake() {

        route = GameObject.FindGameObjectWithTag("Route");

        foreach(Transform t in route.transform)
        {
            if(t.name == "0")
            {
                node = t.gameObject;
            }
            Destroy(t.gameObject);
        }

        for(int i = 0;i< numberOfNodes;i++)
        {
            GameObject o = Instantiate(node) as GameObject;
            o.transform.position = new Vector3(Random.Range(-3,3), Random.Range(-3, 3));
            o.GetComponent<LineCreator>().enabled = true;
            o.GetComponent<ObjectStartRescale>().enabled = true;
            o.name = i.ToString();
            o.transform.parent = route.transform;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
