using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SaveAndLoadTest : MonoBehaviour
{
    public TMP_InputField inputField;
    



    public void SaveData()
    {
        PlayerPrefs.SetString("input", inputField.text);
    }


    public void LoadData() 
    {
        if(PlayerPrefs.HasKey("input"))
        {
            inputField.text = PlayerPrefs.GetString("input");
       
        }
        else
        {
            print("Not accesible save data");
        }
    }

    public void DeleteData()
    {
        PlayerPrefs.DeleteKey("input");
    }
    public void Start()
    {
        
    }
}
