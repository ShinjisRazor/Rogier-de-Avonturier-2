using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;

public class Raycast : MonoBehaviour
{
    public RaycastHit hit;
    public float raycastlenght;
    public string currenttotum;
    public TotumScript totumscrit;
    public string currentitem;
    public string spawnloc;
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
        print(currentitem);
        print(spawnloc);
        if (Input.GetButtonDown("Interact"))
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
                if (hit.transform.gameObject.CompareTag("Items"))
                {
                    currentitem = hit.transform.gameObject.name;
                    inventoryManager.AddItem(itemName, quantity, sprite);
                    Destroy(gameObject);
                }
                if (hit.transform.gameObject.CompareTag("Placeloc"))
                {
                    spawnloc = hit.transform.gameObject.name;
                    if (currentitem == ("Banaan") && spawnloc == ("Loc1") )
                    {
                        Instantiate(GameObject.Find(currentitem), GameObject.Find(spawnloc).transform);
                    }
                    if (currentitem == ("LegoMan") && spawnloc == ("Loc2"))
                    {
                        Instantiate(GameObject.Find(currentitem), GameObject.Find(spawnloc).transform);
                    }
                }
            }
        }
    }
}
