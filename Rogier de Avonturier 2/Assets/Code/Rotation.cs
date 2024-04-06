using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
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
    public float maxHeadRotation = 40f;
    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");

        bodyRot.y = mouseX;
        body.Rotate(bodyRot * rotSpeed * Time.deltaTime);

        headRot.x = -mouseY;
        float newHeadRotX = Mathf.Clamp(head.localEulerAngles.x + -mouseY * rotSpeed * Time.deltaTime, -maxHeadRotation, maxHeadRotation);
        head.localRotation = Quaternion.Euler(newHeadRotX, head.localEulerAngles.y, head.localEulerAngles.z);
    }
}
