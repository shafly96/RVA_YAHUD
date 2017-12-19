using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {

    public delegate void ClickAction();
    public static event ClickAction OnClicked;

    void OnEnable()
    {
        OnClicked += Teleport;
    }


    void OnDisable()
    {
        OnClicked -= Teleport;
    }


    void Teleport()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(1.0f, 3.0f);
        transform.position = pos;
    }

}
