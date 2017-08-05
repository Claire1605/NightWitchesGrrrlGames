using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public Camera cam;
    public GameObject plane;
	
	// Update is called once per frame
	void LateUpdate () {
        cam.transform.position = new Vector3(plane.transform.position.x + 5, 0, -10);
    }
}
