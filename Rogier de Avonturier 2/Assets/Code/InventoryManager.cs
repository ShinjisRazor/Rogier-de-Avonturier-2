using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{

    public GameObject inventoryMenu;
    private bool menuActivated;
    
    void Start()
    {
       
    }

    void Update()
    {
        if(Input.GetButtonDown("Inventory")) 
        {
            if(menuActivated)
            {
                inventoryMenu.SetActive(false);
                menuActivated = false;
            }
            else
            {
                inventoryMenu.SetActive(true);
                menuActivated = true;

            }
        }
    }
}
