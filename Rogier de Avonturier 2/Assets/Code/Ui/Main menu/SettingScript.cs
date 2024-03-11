using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Playables;
using TMPro;

public class SettingScript : MonoBehaviour
{
    public TMP_Text volumeText;
    public Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);

        UpdateVolumeText(volumeSlider.value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnVolumeChanged(float value)
    {
        UpdateVolumeText(value);

        AudioListener.volume = value;
    }

    private void UpdateVolumeText(float value)
    {
        volumeText.text = $"Volume: {Mathf.RoundToInt(value * 100)}%";
    }
}
