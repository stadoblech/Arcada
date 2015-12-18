using UnityEngine;
using System.Collections;

public class CameraEndGameEffect : MonoBehaviour {


    public float cameraZoomSpeed;
    public float maxCameraZoomout;

    Camera thisCamera;
    float cameraSize;

    // Use this for initialization
    void Start () {
        thisCamera = Camera.main;
        cameraSize = thisCamera.orthographicSize;
    }
	
	// Update is called once per frame
	void Update () {
        if (GameLogic.gameEnded)
        {
            thisCamera.orthographicSize += cameraZoomSpeed * Time.deltaTime;

            if (thisCamera.orthographicSize >= maxCameraZoomout)
            {
                GameLogic.loadInterlevel();
            }
        }
    }
}
