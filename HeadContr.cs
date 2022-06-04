using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadContr : MonoBehaviour
{
     //повороты головой и телом по мышке
    public Transform playerBody;
    float mouseX;
    float mouseY;
    void Start()
    {
        
    }


    void Update()
    {
        mouseX=Input.GetAxis("Mouse X");
        mouseY=Input.GetAxis("Mouse Y");
        playerBody.Rotate(0,mouseX,0);
    }
}
