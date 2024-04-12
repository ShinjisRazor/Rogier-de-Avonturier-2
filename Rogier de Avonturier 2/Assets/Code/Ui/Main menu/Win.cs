using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("CollideR")) // Assuming CollideR is the tag of the object you want to collide with
        {
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.Confined;
            canvas.SetActive(true); // Show the canvas
        }
    }
}
