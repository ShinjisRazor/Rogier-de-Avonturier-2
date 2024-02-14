using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{
    public float vert;
    public float hor;
    public Vector3 movedir;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        vert = Input.GetAxis("Vertical");
        hor = Input.GetAxis("Horizontal");
        movedir.z = vert;
        movedir.x = hor;
        transform.Translate(movedir * Time.deltaTime * speed);
    }
}

