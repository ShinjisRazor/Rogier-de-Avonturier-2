using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{
    public float vert;
    public float hor;
    public Vector3 movedir;
    public float speed;
    private Rigidbody rb;
    public float jumpforce = 5f;
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
        transform.Translate(movedir * Time.deltaTime * speed);
        if (Input.GetButtonDown("Jump"))
        {
            Jump();       
        }
    }
    void Jump()
    {
        if (Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            // Apply an impulse force in the upward direction
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
        }
    }
}
    



