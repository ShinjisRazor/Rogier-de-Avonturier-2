using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insert : MonoBehaviour
{
    public Raycast ray;
    public bool place1;
    public bool place2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void insert()
    {
        if (ray.currentitem == ("Banaan") && ray.spawnloc == ("Loc1"))
        {
            if (place1 == false)
            {
                Instantiate(GameObject.Find(ray.currentitem), GameObject.Find(ray.spawnloc).transform.position, transform.rotation);
                place1 = true;
            }
        }
        if (ray.currentitem == ("LegoMan") && ray.spawnloc == ("Loc2"))
        {
            if (place2 == false)
            {
                Instantiate(GameObject.Find(ray.currentitem), GameObject.Find(ray.spawnloc).transform.position, transform.rotation);
                place2 = true;
            }
        }
    }
}
