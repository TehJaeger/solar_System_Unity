using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlls : MonoBehaviour
{
    public CharacterController controls;
    public float speed = 100f;
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float y = Input.GetAxis("Jump");
        Vector3 move = transform.right * x + transform.forward * z + transform.up * y;

        controls.Move(move * speed * Time.deltaTime); //time.deltaTime para manter o movimento consistente independente dos frames
    }

}

