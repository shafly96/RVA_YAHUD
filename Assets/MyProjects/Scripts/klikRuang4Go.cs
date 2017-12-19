using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klikRuang4Go : MonoBehaviour {

    public GameObject player;

    public void mundur()
    {
        //transform.position += new Vector3(-1f, 0f, 0f);
        player.transform.position += new Vector3(0f, 0f, -20f);
    }
}
