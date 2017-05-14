
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowsCameraMovement : MonoBehaviour {

    private Transform tf;
    private float xrot, yrot = 0;
	// Use this for initialization
	void Start () {
        tf = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {

        try
        {
            GvrHead gvrhead = GetComponent<GvrHead>();
            Destroy(gvrhead);
            GvrViewer gvrviewer = GameObject.Find("GvrViewerMain").GetComponent<GvrViewer>();
            gvrviewer.VRModeEnabled = false;
        }
        catch (System.Exception ex)
        {

        }
        float x, y;
        x = Input.GetAxis("Vertical") * -2;
        y = Input.GetAxis("Horizontal") * 2;
        if (x == 0 && y == 0)
        {
            x = Input.GetAxis("Mouse Y") * -2;
            y = Input.GetAxis("Mouse X") * 2;
            if(x != 0 && y != 0)
            {
                Cursor.visible = false;
            }
        }
        else
        {
            Cursor.visible = true;
        }
        xrot += x;
        yrot += y;
        tf.rotation = Quaternion.Euler(xrot, yrot, 0);
        Debug.Log(x + " " + y + " " + yrot + " " + xrot);


	}
}
