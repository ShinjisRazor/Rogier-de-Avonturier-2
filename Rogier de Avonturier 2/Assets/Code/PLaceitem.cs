using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLaceitem : MonoBehaviour
{
    public Raycast rayscript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            print(rayscript.currentItem);
        }
    }
}
