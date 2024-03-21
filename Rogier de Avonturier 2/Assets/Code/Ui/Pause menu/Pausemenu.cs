using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Pausemenu : MonoBehaviour
{
    public Canvas pause;
    public Canvas settings;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            pause.enabled = true;

        }
    }
     public void exitpressed()
    {
        
    }
}
