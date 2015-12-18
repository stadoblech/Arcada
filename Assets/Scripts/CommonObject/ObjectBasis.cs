using UnityEngine;
using System.Collections;

public class ObjectBasis : MonoBehaviour {
    public static Vector3 getRandomPositionOnScreen()
    {
        Camera cam = Camera.main;
        float height = cam.orthographicSize;
        float width = height / cam.aspect;


        return new Vector3(Random.Range(-width, width) + cam.transform.position.x, Random.Range(-height, height) + cam.transform.position.y);
    }
}
