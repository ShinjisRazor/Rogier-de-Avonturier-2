using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class TotumScript : MonoBehaviour
{
    public GameObject totum1;
    public float rotateamount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
           
        
    }
    public void Totumrot() 
    {
        totum1.transform.Rotate(Vector3.up * rotateamount);
        if (Mathf.Approximately(totum1.transform.eulerAngles.y, 90f))
        {
            Debug.Log("Rotation is at 90 degrees!");
        }
    }
}
