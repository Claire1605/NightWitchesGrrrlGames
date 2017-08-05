using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public  Rigidbody2D flarePlane;
    public Rigidbody2D bombPlane;
    public float vertSpeed;
    public float horizSpeed;

	void Start () {
		
	}
	
	void Update () {
        flarePlane.velocity = new Vector2(horizSpeed, Input.GetAxis("Vertical") * vertSpeed);
        bombPlane.velocity = new Vector2(horizSpeed, Input.GetAxis("Vertical") * vertSpeed);
    }
}
