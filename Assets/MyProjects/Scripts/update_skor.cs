using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class update_skor : MonoBehaviour {

	TextMesh myScore;

	// Use this for initialization
	void Start () {
		myScore = GameObject.Find ("hasil").GetComponent<TextMesh> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void update_score(){
		int angka = int.Parse(myScore.text);
		angka = angka + 10;
		myScore.text = angka.ToString();
	}
}
