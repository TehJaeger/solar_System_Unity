using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlls : MonoBehaviour
{
    public CharacterController controls;
    public float speed = 1000000000000000f;
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;

        controls.Move(move * speed * Time.deltaTime); //time.deltaTime para manter o movimento consistente independente dos frames
    }

}

