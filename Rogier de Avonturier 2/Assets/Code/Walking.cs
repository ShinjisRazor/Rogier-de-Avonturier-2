using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{
    public float vert;
    public float hor;
    public Vector3 moveDir; // Changed "movedir" to "moveDir" for correct spelling
    public float walkSpeed; // Changed "walkspeed" to "walkSpeed" for correct spelling
    public float sprintSpeed; // Changed "sprintspeed" to "sprintSpeed" for correct spelling
    private Rigidbody rb;
    public float jumpForce = 5f; // Changed "jumpforce" to "jumpForce" for correct spelling
    public bool isSprinting;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        vert = Input.GetAxis("Vertical");
        hor = Input.GetAxis("Horizontal");
        moveDir.z = vert;
        moveDir.x = hor;
        {
            isSprinting = Input.GetKey(KeyCode.LeftShift);
            transform.Translate(moveDir * Time.deltaTime * (isSprinting ? sprintSpeed : walkSpeed));
        }

        if (Input.GetButtonDown("Jump"))
        {
            // Abs als een getal in de - is zet die hem naar +
            if (Mathf.Abs(rb.velocity.y) < 0.001f)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}





