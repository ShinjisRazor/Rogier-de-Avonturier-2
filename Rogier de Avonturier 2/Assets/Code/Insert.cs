using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insert : MonoBehaviour
{
    public Raycast ray;
    public bool place1;
    public bool place2;
    public GameObject door;
    public GameObject door2;
    public int placed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (placed == 2)
        {
            Destroy(door);
        }
    }

    public void insert()
    {
        if (ray.currentItem == "Banaan" && ray.spawnLoc == "Loc1")
        {
            if (!place1)
            {
                Instantiate(GameObject.Find(ray.currentItem), GameObject.Find(ray.spawnLoc).transform.position, transform.rotation);
                place1 = true;
                placed++;
                Destroy(door);
            }
        }
        if (ray.currentItem == "LegoMan" && ray.spawnLoc == "Loc2")
        {
            if (!place2)
            {
                Instantiate(GameObject.Find(ray.currentItem), GameObject.Find(ray.spawnLoc).transform.position, transform.rotation);
                place2 = true;
                placed++;
            }
        }
    }
}
