using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SaveAndLoadTest : MonoBehaviour
{
    public TMP_InputField inputField;
    public ItemsTest itemtest;



    public void saveData()
    {
        PlayerPrefs.SetString("input", inputField.text);
        print("gay");
        PlayerPrefs.SetInt("item", itemtest.item);
        print("luk");
    }


    public void loadData() 
    {
        inputField.text = PlayerPrefs.GetString("input");
        itemtest.item = PlayerPrefs.GetInt("item");
    }

    public void DeleteData()
    {
        PlayerPrefs.DeleteKey("input");
    }
    public void Start()
    {
        
    }
    public void startgame()
    {
        itemtest.item = PlayerPrefs.GetInt("items");
    }
}
