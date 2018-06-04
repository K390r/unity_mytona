using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour {
	public Box_button button;
	Transform tr;
	public Transform player;
	Vector3 a=new Vector3(0,0.1f,0);
	// Use this for initialization
	void Start () {
		tr = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (tr.position, player.position) <= 1.6 && tr.position.y<=12.8f && button.isPressed) {
			tr.position += a;
			player.position += a;
		}
		if (tr.position.y >= 12f) {
			Application.LoadLevel ("scene2");
		}
			
	}
}
