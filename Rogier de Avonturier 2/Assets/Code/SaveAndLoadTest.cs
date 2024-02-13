using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SaveAndLoadTest : MonoBehaviour
{
    public TMP_InputField inputField;



    public void saveData()
    {
        PlayerPrefs.SetString("input", inputField.text);
    }


    public void loadData() 
    {
        inputField.text = PlayerPrefs.GetString("input");
    }

    public void DeleteData()
    {
        PlayerPrefs.DeleteKey("input");
    }
}
