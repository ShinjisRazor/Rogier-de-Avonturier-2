using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
    public Canvas pause;
    public Canvas settings;

    // Start is called before the first frame update
    void Start()
    {
        pause.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            pause.enabled = true;
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.Confined;

        }
    }
    public void exitpressed()
    {
        SceneManager.LoadScene("Main menu");
    }
    public void Pressedplay()
    {
        pause.enabled=false;
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
    }
}

