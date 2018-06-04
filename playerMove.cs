using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {
    Transform tr;
    Rigidbody rb;
    float v0, h0, v1, h1, v2, h2, v3, h3;
    Vector3 objPos;
	int relativity = 0, cMv = 175, jumpPower = 2000;
    bool j, stay;
    void Start () {
        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
	}
	
	void Update () {
        /*Стандартая раскладка 0*/
        v0 = Input.GetAxis("Vertical");
        Vector3 a0 = new Vector3(0, 0, v0);

        h0 = Input.GetAxis("Horizontal");
        Vector3 b0 = new Vector3(h0, 0, 0);
        
        
        if (stay && relativity == 0)
        {
            rb.AddForce(a0 * cMv);
            rb.AddForce(b0 * cMv);
        }
        /**/
        /*Прыжок*/
        j = Input.GetKeyDown(KeyCode.Space);
        if (j&&stay)
        {
            Vector3 c = new Vector3(0, 1, 0);
            rb.AddForce(c * jumpPower);
            stay = false;
        }
        /**/
        /*Относительность движения*/
        if (Input.GetKeyDown(KeyCode.Q))
        {
            relativity--;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            relativity++;
        }
        if (relativity >= 4 )
        {
            relativity = 0;
        }
        if(relativity < 0)
        {
            relativity = 3;
        }
        /**/
        /*Раскладка 1*/
        v1 = Input.GetAxis("Vertical");
        Vector3 a1 = new Vector3(-v1, 0, 0);

        h1 = Input.GetAxis("Horizontal");
        Vector3 b1 = new Vector3(0, 0, h1);

        if (stay && relativity == 1)
        {
            rb.AddForce(a1 * cMv);
            rb.AddForce(b1 * cMv);
        }
        /**/
        /*Раскладка 2*/
        v2 = Input.GetAxis("Vertical");
        Vector3 a2 = new Vector3(0, 0, -v2);

        h2 = Input.GetAxis("Horizontal");
        Vector3 b2 = new Vector3(-h2, 0, 0);

        if (stay && relativity == 2)
        {
            rb.AddForce(a2 * cMv);
            rb.AddForce(b2 * cMv);
        }
        /**/
        /*Раскладка 3*/
        v3 = Input.GetAxis("Vertical");
        Vector3 a3 = new Vector3(v3, 0, 0);

        h3 = Input.GetAxis("Horizontal");
        Vector3 b3 = new Vector3(0, 0, -h3);

        if (stay && relativity == 3)
        {
            rb.AddForce(a3 * cMv);
            rb.AddForce(b3 * cMv);
        }
        /**/

    }
    private void OnCollisionEnter(Collision arg)
     {
		if(arg.gameObject.tag=="Floor"|| arg.gameObject.tag=="Respawn"||arg.gameObject.tag=="Elevator")
         {
            objPos = arg.gameObject.transform.position;
            if (objPos.y < tr.position.y)
            {
                stay = true;
            }
         }
     }
}
