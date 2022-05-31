using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlls : MonoBehaviour
{
    public CharacterController controls;
    GameObject[] celestials;
    public float speed = 10f;
    public int[] numbers;


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
        int update = 0,i = 0;
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float y = Input.GetAxis("Jump");
        Vector3 move = transform.right * x + transform.forward * z + transform.up * y;
        if(update == 0){
            update++;
            celestials = GameObject.FindGameObjectsWithTag("Celestial");
        }
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

        }
        
        if(numbers[0] == 1) transform.LookAt(celestials[0].transform);
        if(numbers[1] > 0) transform.LookAt(celestials[1].transform);
        if(numbers[2] > 0) transform.LookAt(celestials[2].transform);
        if(numbers[3] > 0) transform.LookAt(celestials[3].transform);
        if(numbers[4] > 0) transform.LookAt(celestials[4].transform);
        if(numbers[5] > 0) transform.LookAt(celestials[5].transform);
        if(numbers[6] > 0) transform.LookAt(celestials[6].transform);
        if(numbers[7] > 0) transform.LookAt(celestials[7].transform);
        if(numbers[8] > 0) transform.LookAt(celestials[8].transform);
        if(numbers[9] > 0) transform.LookAt(celestials[9].transform);

        if(numbers[0] > 1){
            transform.position = celestials[0].transform.position + new Vector3(0,900,0);

        }
        if(numbers[1] > 1) transform.LookAt(celestials[1].transform);
        if(numbers[2] > 1) transform.LookAt(celestials[2].transform);
        if(numbers[3] > 1) transform.LookAt(celestials[3].transform);
        if(numbers[4] > 1) transform.LookAt(celestials[4].transform);
        if(numbers[5] > 1) transform.LookAt(celestials[5].transform);
        if(numbers[6] > 1) transform.LookAt(celestials[6].transform);
        if(numbers[7] > 1) transform.LookAt(celestials[7].transform);
        if(numbers[8] > 1) transform.LookAt(celestials[8].transform);
        if(numbers[9] > 1) transform.LookAt(celestials[9].transform);





     
        controls.Move(move * speed * Time.deltaTime); //time.deltaTime para manter o movimento consistente independente dos frames
    }

}
