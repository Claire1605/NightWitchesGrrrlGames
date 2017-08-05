using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public  Rigidbody2D flarePlane;
    public Rigidbody2D bombPlane;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      //  flarePlane.position.y += Input.GetAxis("Vertical");
       // flarePlane.Translate(0, Input.GetAxis("Vertical"), 0);
       // bombPlane.Translate(0, Input.GetAxis("Vertical"), 0);
        flarePlane.velocity += new Vector2(0, Input.GetAxis("Vertical")/2);
        bombPlane.velocity += new Vector2(0, Input.GetAxis("Vertical")/2);
    }
}
