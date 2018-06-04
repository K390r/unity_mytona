using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_button : MonoBehaviour {
    public Transform button, player;
    public Transform[] boxs;
    public bool isPressed=false;
    int i;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        for (i = 0; i < boxs.Length; i++)
        {
			if(Vector3.Distance(button.position, boxs[i].position) <= 1.6|| Vector3.Distance(button.position,player.position)<=1.6)
            {
                isPressed = true;
            }
        }
	}
}
