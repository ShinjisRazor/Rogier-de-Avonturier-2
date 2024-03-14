using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;


public class LocationSaver : MonoBehaviour
{
    private string PlayerLocationKey = "Playerlocation";

    public void Start()
    {
        LoadPlayerLocation();
    }
    public void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            SavePlayerLocation();
        }
    }
    public void SavePlayerLocation()
    {
        PlayerPrefs.SetFloat(PlayerLocationKey + "_X", transform.position.x);
        PlayerPrefs.SetFloat(PlayerLocationKey + "_Y", transform.position.y);
        PlayerPrefs.SetFloat(PlayerLocationKey + "_Z", transform.position.z);
        PlayerPrefs.Save();
    }
    public void LoadPlayerLocation()
    {
        float x = PlayerPrefs.GetFloat(PlayerLocationKey + "_X", 0);
        float y = PlayerPrefs.GetFloat(PlayerLocationKey + "_Y", 0);
        float z = PlayerPrefs.GetFloat(PlayerLocationKey + "_Z", 0);
        transform.position = new Vector3(x, y, z);
    }

 }