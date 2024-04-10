using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InHand : MonoBehaviour
{
    public Raycast rayscrit;
    public GameObject inhanditem;
    public GameObject hand;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        print(rayscrit.currentItem); 
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            if (rayscrit != null)
            {
              inhanditem = GameObject.Find(rayscrit.currentItem);
                Instantiate(inhanditem, hand.transform);
            }
        }
        print (inhanditem);
    }
}
