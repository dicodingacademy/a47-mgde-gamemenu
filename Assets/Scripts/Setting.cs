using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour {

    // teks representasi untuk persen
    Text persenTeks;

    // dropdown untuk ukuran resolusi
    public Dropdown resolusiDropdown;

    Resolution[] resolutions;

    // Use this for initialization
    void Start() {
        persenTeks = GetComponent<Text>();

        resolutions = Screen.resolutions;

        resolusiDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++) {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height) {
                    currentResolutionIndex = i;
                }
        }
        resolusiDropdown.AddOptions(options);
        resolusiDropdown.value = currentResolutionIndex;
        resolusiDropdown.RefreshShownValue();
    }

    // toggle untuk fullscreen
    public void TampilanPenuh (bool isFullscreen) {
        Screen.fullScreen = isFullscreen;
    }
    
    // dropdown untuk ukuran resolusi
    public void SetResolution (int resolutionIndex) {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    // teks untuk persen
    public void Volume (float value) {
        persenTeks.text = Mathf.RoundToInt(value * 100) + "%";
    }
}
