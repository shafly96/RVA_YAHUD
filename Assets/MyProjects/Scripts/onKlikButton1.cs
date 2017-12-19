using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onKlikButton1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void maju()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(1.0f, 3.0f);
        pos.z = Random.Range(1.0f, 3.0f);
        transform.position = pos;
    }
}
