using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropFlares : MonoBehaviour {

    public GameObject flare;
    public Transform plane;
    public CameraMovement cameraMovement;

    void Update()
    {
        if (cameraMovement.activePlaneString == "flare" && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(flare, plane);
        }
    }
}
