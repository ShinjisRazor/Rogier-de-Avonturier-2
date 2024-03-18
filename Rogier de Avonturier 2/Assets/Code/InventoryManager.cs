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
        if(Input.GetButtonDown("Inventory") && menuActivated)
        {
            inventoryMenu.SetActive(false);
        }

        else if (Input.GetButtonDown("Inventory") && !menuActivated)
        {
            inventoryMenu.SetActive(true);
        }
    }
}
