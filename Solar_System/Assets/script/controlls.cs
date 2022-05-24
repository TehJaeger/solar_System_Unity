using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlls : MonoBehaviour
{
    public CharacterController controls;
    public float speed = 10f;
    public int[] numbers;
    public Transform target0,target1,target2,target3,target4,target5,target6,target7,target8,target9;

    // Update is called once per frame
    void Start()
    {
        int i = 0;
        while(i < 10){
            numbers[i] = 0;
            i++;
        }    
    }

    void Update()
    {
        int i = 0;
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float y = Input.GetAxis("Jump");
        Vector3 move = transform.right * x + transform.forward * z + transform.up * y;
        if(Input.GetKeyDown(KeyCode.F1))
        {
            i = 0;
            while(i < 10){
                if(i != 0) numbers[i] = 0;
                i++;
            }
            numbers[0]++;
        }
        if(Input.GetKeyDown(KeyCode.F2))
        {
            i = 0;
            while(i < 10){
                if(i != 1) numbers[i] = 0;
                i++;
            }
            numbers[1]++;
        }
    if(Input.GetKeyDown(KeyCode.F3))
        {
            i = 0;
            while(i < 10){
                if(i != 2) numbers[i] = 0;
                i++;
            }
            numbers[2]++;
        }
        if(Input.GetKeyDown(KeyCode.F4))
        {
            i = 0;
            while(i < 10){
                if(i != 3) numbers[i] = 0;
                i++;
            }
            numbers[3]++;
        }
        if(Input.GetKeyDown(KeyCode.F5))
        {
            i = 0;
            while(i < 10){
                if(i != 4) numbers[i] = 0;
                i++;
            }
            numbers[4]++;
        }
        if(Input.GetKeyDown(KeyCode.F6))
        {
            i = 0;
            while(i < 10){
                if(i != 5) numbers[i] = 0;
                i++;
            }
            numbers[5]++;
        }
        if(Input.GetKeyDown(KeyCode.F7))
        {
            i = 0;
            while(i < 10){
                if(i != 6) numbers[i] = 0;
                i++;
            }
            numbers[6]++;
        }
        if(Input.GetKeyDown(KeyCode.F8))
        {
            i = 0;
            while(i < 10){
                if(i != 7) numbers[i] = 0;
                i++;
            }
            numbers[7]++;
        }
        if(Input.GetKeyDown(KeyCode.F9))
        {
            i = 0;
            while(i < 10){
                if(i != 8) numbers[i] = 0;
                i++;
            }
            numbers[8]++;
        }
        if(Input.GetKeyDown(KeyCode.F10))
        {
            i = 0;
            while(i < 10){
                if(i != 9) numbers[i] = 0;
                i++;
            }
            numbers[9]++;
        }
        if(Input.GetKeyDown(KeyCode.F11))
        {
            i = 0;
            while(i < 10){
                numbers[i] = 0;
                i++;
            }
            transform.position = new Vector3(0,0,1000f);
        }
        
        if(numbers[0] > 0) transform.LookAt(target0);
        if(numbers[1] > 0) transform.LookAt(target1);
        if(numbers[2] > 0) transform.LookAt(target2);
        if(numbers[3] > 0) transform.LookAt(target3);
        if(numbers[4] > 0) transform.LookAt(target4);
        if(numbers[5] > 0) transform.LookAt(target5);
        if(numbers[6] > 0) transform.LookAt(target6);
        if(numbers[7] > 0) transform.LookAt(target7);
        if(numbers[8] > 0) transform.LookAt(target8);
        if(numbers[9] > 0) transform.LookAt(target9);
        if(numbers[0] > 1) {
            transform.position = Vector3.Lerp(transform.position, target0.position, 10f * Time.deltaTime);
            transform.rotation = Quaternion.Slerp(transform.rotation, target0.rotation, 10f * Time.deltaTime);
        }
        if(numbers[1] > 1) {
            transform.position = Vector3.Lerp(transform.position, target1.position, 100f * Time.deltaTime);
            transform.rotation = Quaternion.Slerp(transform.rotation, target1.rotation, 100f * Time.deltaTime);
        }
        if(numbers[2] > 1) transform.LookAt(target2);
        if(numbers[3] > 1) transform.LookAt(target3);
        if(numbers[4] > 1) transform.LookAt(target4);
        if(numbers[5] > 1) transform.LookAt(target5);
        if(numbers[6] > 1) transform.LookAt(target6);
        if(numbers[7] > 1) transform.LookAt(target7);
        if(numbers[8] > 1) transform.LookAt(target8);
        if(numbers[9] > 1) transform.LookAt(target9);



     
        controls.Move(move * speed * Time.deltaTime); //time.deltaTime para manter o movimento consistente independente dos frames
    }

}

