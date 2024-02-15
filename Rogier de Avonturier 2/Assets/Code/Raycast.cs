using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public RaycastHit hit;
    public TotumScript Totumscript;
    public float raycastlenght;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, raycastlenght))
            {
                if (hit.transform.gameObject.CompareTag("Totem"))
                {
                    if (Totumscript != null)
                    {
                        Totumscript.Totumrot();
                    }
                }
            }                                    
        }
    }
}
