using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public RaycastHit hit;
    public float raycastlenght;
    public string currenttotum;
    public TotumScript totumscrit;
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
                    if (totumscrit != null)
                    {
                        currenttotum = hit.transform.gameObject.name;
                        totumscrit.Totumrot();
                    }
                    
                }
            }
        }
    }
}
