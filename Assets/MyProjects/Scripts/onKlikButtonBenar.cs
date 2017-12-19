using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onKlikButtonBenar : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ButtonBenar()
    {
        player.transform.position += new Vector3(0f, 0f, -10f);
    }
}
