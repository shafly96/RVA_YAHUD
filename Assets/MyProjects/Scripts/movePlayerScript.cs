using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayerScript : MonoBehaviour {

    Vector3 roomnow;
    int zoomed;
	// Use this for initialization
	void Start () {
        zoomed = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W))
            transform.position = transform.position + Camera.main.transform.forward * 2f * Time.deltaTime;
        if (Input.GetKey(KeyCode.S))
            //transform.Translate(-Vector3.forward * 2f * Time.deltaTime);
            transform.position = transform.position + Camera.main.transform.forward * -2f * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, -35f * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, 35f * Time.deltaTime);
    }

    public void MoveToCanvas (GameObject MoveTo)
    {
        Vector3 movePadding;
        if (zoomed == 1)
        {
            Transform temp = MoveTo.transform;
            Debug.Log(MoveTo.transform.localEulerAngles.y);
            roomnow = transform.position;

            if (MoveTo.transform.localEulerAngles.y == 90)
            {
                movePadding = new Vector3(temp.position.x, temp.position.y, Convert.ToSingle(temp.position.z - 2.5));
            }
            else if (MoveTo.transform.localEulerAngles.y == 180)
            {
                movePadding = new Vector3(Convert.ToSingle(temp.position.x + 2.5), temp.position.y, temp.position.z);

            }
            else if (MoveTo.transform.localEulerAngles.y == 270)
            {
                movePadding = new Vector3(temp.position.x, temp.position.y, Convert.ToSingle(temp.position.z + 2.5));

            }
            else if (MoveTo.transform.localEulerAngles.y == 0)
            {
                movePadding = new Vector3(Convert.ToSingle(temp.position.x - 2.5), temp.position.y, temp.position.z);

            }
            else
            {

                movePadding = new Vector3(temp.position.x, temp.position.y, temp.position.z);

            }

            zoomed = 2;
            transform.position = movePadding;
        }
        else if (zoomed ==2)
        {
            Transform temp = MoveTo.transform;
        

            if (MoveTo.transform.localEulerAngles.y == 90)
            {
                movePadding = new Vector3(temp.position.x, temp.position.y, Convert.ToSingle(temp.position.z - 1));
            }
            else if (MoveTo.transform.localEulerAngles.y == 180)
            {
                movePadding = new Vector3(Convert.ToSingle(temp.position.x + 1), temp.position.y, temp.position.z);

            }
            else if (MoveTo.transform.localEulerAngles.y == 270)
            {
                movePadding = new Vector3(temp.position.x, temp.position.y, Convert.ToSingle(temp.position.z + 1));

            }
            else if (MoveTo.transform.localEulerAngles.y == 0)
            {
                movePadding = new Vector3(Convert.ToSingle(temp.position.x - 1), temp.position.y, temp.position.z);

            }
            else
            {

                movePadding = new Vector3(temp.position.x, temp.position.y, temp.position.z);

            }
            transform.position = movePadding;
            zoomed = 3;
        }
        else
        {
            transform.position = roomnow;
            zoomed = 1;
        }
    }
}
