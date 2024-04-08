using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotX : MonoBehaviour
{

    public Transform head;
    public float mouseY;
    public Vector3 headRot;
    public float rotSpeed;
    public float maxRotationX = 60f;

    void Update()
    {
        mouseY = Input.GetAxis("Mouse Y");
        headRot.x = -mouseY * rotSpeed * Time.deltaTime;

        Vector3 currentRotation = head.localRotation.eulerAngles;

        head.Rotate(headRot);

        float newRotationX = ClampRotation(head.localRotation.eulerAngles.x);

        head.localRotation = Quaternion.Euler(newRotationX, currentRotation.y, currentRotation.z);
    }

   
    float ClampRotation(float rotation)
    {
        rotation = rotation > 180 ? rotation - 360 : rotation; 
        return Mathf.Clamp(rotation, -maxRotationX, maxRotationX);
    }
}
