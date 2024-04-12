using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Playables;
using TMPro;
using System.Xml.Serialization;
using System.Security.Cryptography.X509Certificates;

public class SettingScript : MonoBehaviour
{
    public TMP_Text volumeText;
    public Slider volumeSlider;
    public Canvas maincanvas;
    public Canvas settings;
    public Toggle fullScreenToggle;
    Resolution[] resolutions;
    public TMP_Dropdown resolutionDropdownList;

    // Start is called before the first frame update
    void Start()
    {
        resolutions = Screen.resolutions;
        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);

        UpdateVolumeText(volumeSlider.value);
        resolutionDropdownList.ClearOptions();
        List<string> options = new List<string>();
         
        int currentresolutionsindex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        { 
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                currentresolutionsindex = i;
            }
        }      
        resolutionDropdownList.AddOptions(options);
        resolutionDropdownList.value = currentresolutionsindex;
        resolutionDropdownList.RefreshShownValue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnVolumeChanged(float value)
    {
        UpdateVolumeText(value);

        AudioListener.volume = value;
    }

    private void UpdateVolumeText(float value)
    {
        volumeText.text = $"Volume: {Mathf.RoundToInt(value * 100)}%";
    }
    public void onback()
    {
        maincanvas.enabled = true;
        settings.enabled = false;
    }
    public void change()
    {
        Screen.fullScreen = !Screen.fullScreen;
        print("screen changed");
    }
    public void setresolution(int resolutionindex)

    {
        Resolution resolution = resolutions[resolutionindex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}
