using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klikRuang1Back : MonoBehaviour {

    public GameObject player;

    public void mundur()
    {
        //transform.position += new Vector3(-1f, 0f, 0f);
        player.transform.position += new Vector3(-20f, 0f, 0f);
    }
}
