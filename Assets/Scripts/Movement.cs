using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {


    public int score = 0;
    public GameObject flarePlane;
    public GameObject bombPlane;
    public float vertSpeed;
    public float horizSpeed;

    private Rigidbody2D flarePlaneRB;
    private Rigidbody2D bombPlaneRB;

    void Start () {
        flarePlaneRB = flarePlane.GetComponent<Rigidbody2D>();
        bombPlaneRB = bombPlane.GetComponent<Rigidbody2D>();
    }
	
	void Update () {
        flarePlaneRB.velocity = new Vector2(horizSpeed, Input.GetAxis("Vertical") * vertSpeed);
        bombPlaneRB.velocity = new Vector2(horizSpeed, Input.GetAxis("Vertical") * vertSpeed);
    }
}
