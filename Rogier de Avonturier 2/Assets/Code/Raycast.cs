using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;

public class Raycast : MonoBehaviour
{
    public RaycastHit hit;
    public float raycastLength;
    public string currentTotem;
    public TotemScript totemScript;
    public string currentItem;
    public string spawnLoc;
    public Insert insert;
    private InventoryManager inventoryManager;
    [SerializeField]
    private string itemName;

    [SerializeField]
    private int quantity;

    [SerializeField]
    private Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        inventoryManager = GameObject.Find("Inventory Canvas").GetComponent<InventoryManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact"))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, raycastLength))
            {
                if (hit.transform.gameObject.CompareTag("Totem"))
                {
                    if (totemScript != null)
                    {
                        currentTotem = hit.transform.gameObject.name;
                        totemScript.TotemRot();
                    }
                }
                if (hit.transform.gameObject.CompareTag("items"))
                {
                    currentItem = hit.transform.gameObject.name;
                    inventoryManager.AddItem(itemName, quantity, sprite);
                    Destroy(gameObject);
                }
                if (hit.transform.gameObject.CompareTag("Placeloc"))
                {
                    spawnLoc = hit.transform.gameObject.name;
                    insert.insert();
                }
            }
        }
    }
}
