using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
   public Transform head;
    public Transform body;

    public float mouseX;
    public float mouseY;

    public Vector3 bodyRot;
    public Vector3 headRot;

    public float rotSpeed;
    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");

        bodyRot.y = mouseX;
        body.Rotate(bodyRot * rotSpeed * Time.deltaTime);

        headRot.x = -mouseY;
        head.Rotate(headRot * rotSpeed * Time.deltaTime);
    }
}
