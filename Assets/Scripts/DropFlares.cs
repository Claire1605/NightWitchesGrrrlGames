using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropFlares : MonoBehaviour {

    GameObject flare;
    Transform plane;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(flare, plane);
        }
    }
}
