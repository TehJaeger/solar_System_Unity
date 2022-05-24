using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looking : MonoBehaviour
{
    // Start is called before the first frame update
    float Sens = 350f, xRotation = 5f;
    public Transform player;
    public Transform target;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mousex = Input.GetAxis("Mouse X") * Sens * Time.deltaTime; //podia multiplicar por Time.deltaTime mas... Never mind fixed update sucks
        float mousey = Input.GetAxis("Mouse Y") * Sens * Time.deltaTime;

        xRotation -= mousey;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); //para de fazer 360º no Y, fazia sentido mas é estrenho e desoriento-me


        player.Rotate(Vector3.up * mousex);
        transform.localRotation = Quaternion.Euler(xRotation,0f,0f);

        //transform.LookAt(target);

    }
}
