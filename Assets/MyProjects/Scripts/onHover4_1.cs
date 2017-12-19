using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onHover4_1 : MonoBehaviour {
	TextMesh myText;

	// Use this for initialization
	void Start () {
		myText = GameObject.Find ("caption4_1").GetComponent<TextMesh> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnMouseOver()
	{
		myText.text = "From the Lake adalah  salah satu lukisan  yang dibuat oleh Georgia O'Keeffe pada tahun 1924";
	}

	public void OnMouseExit()
	{
		myText.text = "";
	}
}
