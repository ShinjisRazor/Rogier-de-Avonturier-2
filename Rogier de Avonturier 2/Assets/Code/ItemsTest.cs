using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsTest : MonoBehaviour
{
    public int item;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            item += 1;
        }
        print (item);
    }
}
