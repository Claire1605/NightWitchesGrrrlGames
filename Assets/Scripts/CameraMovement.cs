using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public string activePlaneString = "flare";
    public Camera cam;
    public GameObject activePlane;
    public GameObject inactivePlane;
    public GameObject flarePlane;
    public GameObject bombPlane;
    public float xOffsetFlare = 4;
    public float xOffsetBomb = 2;

    private float xOffset;

    private void Start()
    {
        //active plane colours
        activePlane.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        inactivePlane.GetComponent<SpriteRenderer>().color = new Color(0.25f, 0.25f, 0.25f, 1);

        xOffset = xOffsetFlare;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PlaneSwitch();
        }
    }

    void LateUpdate () {
        cam.transform.position = new Vector3(activePlane.transform.position.x + xOffset, 0, -10);
    }

    void PlaneSwitch()
    {
        if (activePlaneString == "flare")
        {
            activePlaneString = "bomb";
            StartCoroutine(cameraSlidePlaneSwitch(xOffsetFlare, xOffsetBomb));
        }
        else if (activePlaneString == "bomb")
        {
            activePlaneString = "flare";
            StartCoroutine(cameraSlidePlaneSwitch(xOffsetBomb, xOffsetFlare));
        }
    }

    public IEnumerator cameraSlidePlaneSwitch(float start, float end)
    {
        if (activePlaneString == "flare")
        {
            flarePlane.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            bombPlane.GetComponent<SpriteRenderer>().color = new Color(0.25f, 0.25f, 0.25f, 1);
        }
        else if (activePlaneString == "bomb")
        {
            flarePlane.GetComponent<SpriteRenderer>().color = new Color(0.25f, 0.25f, 0.25f, 1);
            bombPlane.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        }

        float i = 0;
        while (i < 1)
        {
            i += Time.deltaTime;
            xOffset = Mathf.Lerp(start, end, i);
            yield return new WaitForEndOfFrame();
        }      
    }
}
