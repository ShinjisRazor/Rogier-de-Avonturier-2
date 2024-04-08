using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{
    public float vert;
    public float hor;
    public Vector3 movedir;
    public float walkspeed;
    public float sprintspeed;
    private Rigidbody rb;
    public float jumpforce = 5f;
    public bool isSprinting;
    public Transform camerarot;
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
        movedir.z = vert;
        movedir.x = hor;
        {         
            isSprinting = Input.GetKey(KeyCode.LeftShift);
            transform.Translate(movedir * Time.deltaTime * (isSprinting ? sprintspeed : walkspeed));
        }

        if (Input.GetButtonDown("Jump"))
        {
            if (Mathf.Abs(rb.velocity.y) < 0.001f)
            {
                rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            }
        }
    }
}
    



