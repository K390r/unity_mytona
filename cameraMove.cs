using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour {

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + 90f, transform.rotation.eulerAngles.z);
        if (Input.GetKeyDown(KeyCode.E))      
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y - 90f, transform.rotation.eulerAngles.z);
    }
}
