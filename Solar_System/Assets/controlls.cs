using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlls : MonoBehaviour
{
   // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W)){
            GetComponent<Rigidbody>().AddForce(0,0,100,ForceMode.Force);
        }
        if(Input.GetKey(KeyCode.S)){
            GetComponent<Rigidbody>().AddForce(0,0,-100,ForceMode.Force);
        }
        if(Input.GetKey(KeyCode.D)){
            GetComponent<Rigidbody>().AddForce(100,0,0,ForceMode.Force);
        }
        if(Input.GetKey(KeyCode.A)){
            GetComponent<Rigidbody>().AddForce(-100,0,0,ForceMode.Force);
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            GetComponent<Rigidbody>().AddTorque(transform.up * 1f);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            GetComponent<Rigidbody>().AddTorque(transform.up * -1f);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            GetComponent<Rigidbody>().AddForce(-100,0,0,ForceMode.Force);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            GetComponent<Rigidbody>().AddForce(-100,0,0,ForceMode.Force);
        }
    }
}

