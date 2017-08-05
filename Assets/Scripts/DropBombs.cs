using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBombs : MonoBehaviour {

    public GameObject bomb;
    public Transform plane;

	void Update () {
		if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(bomb, plane);
        }
	}
}
