using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Playables;
using Unity.VisualScripting;

public class MainMeu : MonoBehaviour
{
    public Canvas maincanvas;
    public Canvas settings;
    public TMP_Text text;
    public bool showing;
    
    // Start is called before the first frame update
    void Start()
    {
       settings.enabled = false;
       text.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Onbuttonclick()
    {
        SceneManager.LoadScene("tempel");
    }
    public void onopensetting()
    {
        maincanvas.enabled = false;
        settings.enabled = true;
    }
    public void onquit()
    {
        Application.Quit();
    }
    public void credits()
    {
        if (showing == false)
        {
            text.enabled = true;
            showing = true;
        }
        else
        {
            text.enabled = false;
            showing = false;
        }
    }
}
