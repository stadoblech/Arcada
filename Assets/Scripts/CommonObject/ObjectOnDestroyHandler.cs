using UnityEngine;
using System.Collections;

public class ObjectOnDestroyHandler : MonoBehaviour {

    public int numberOfBitsOnDestroy;
    public GameObject bits;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnDestroy()
    {
        createBits();
    }

    void createBits()
    {
        for (int i = 0; i < numberOfBitsOnDestroy; i++)
        {
            Instantiate(bits, transform.position, Quaternion.identity);
        }
    }
}
