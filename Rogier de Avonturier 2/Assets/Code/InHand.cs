using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InHand : MonoBehaviour
{
    public GameObject banana;
    public Raycast rayscrit;
    // Start is called before the first frame update
    void Start()
    {
        banana.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            if (rayscrit != null)
            {
                if (rayscrit.hasban == true)
                {
                    banana.SetActive (true);
                }
            }
        }
    }
}
