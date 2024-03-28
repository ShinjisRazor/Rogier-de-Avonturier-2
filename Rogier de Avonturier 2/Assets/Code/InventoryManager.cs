using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{

    public GameObject inventoryMenu;
    private bool menuActivated;
    public ItemSlot[] itemSlot;
    
    void Start()
    {
       
    }

    void Update()
    {
        if(Input.GetButtonDown("Inventory")) 
        {
            if(menuActivated)
            {
                Time.timeScale = 1; 
                inventoryMenu.SetActive(false);
                menuActivated = false;
            }
            else
            {
                Time.timeScale = 0;
                inventoryMenu.SetActive(true);
                menuActivated = true;

            }
        }      
    }
    public void AddItem(string itemName, int quantity, Sprite itemSprite)
    {
        for (int i = 0; i < itemSlot.Length; i++)
        {
            if (itemSlot[i].filled == false)
            {
                itemSlot[i].AddItem(itemName, quantity, itemSprite);
                return;
            }
        }
    }

    public void DeselectAllSlots()
    {
        for(int i = 0; i < itemSlot.Length; i++)
        {
            itemSlot[i].selectedShader.SetActive(false);
            itemSlot[i].thisItemSelected = false;
        }
    }
}
