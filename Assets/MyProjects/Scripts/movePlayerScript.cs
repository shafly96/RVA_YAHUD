using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
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
}
