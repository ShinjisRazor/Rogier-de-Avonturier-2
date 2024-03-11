using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Playables;

public class MainMeu : MonoBehaviour
{
    public Button play;
    public Canvas maincanvas;
    public Canvas settings;
    
    // Start is called before the first frame update
    void Start()
    {
       settings.enabled = false;
     ;
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
}
