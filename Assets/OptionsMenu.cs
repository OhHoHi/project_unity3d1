using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Dropdown resolutionsDropdown;


    Resolution[] resolutions; // ?? ch?a các ?? phân gi?i c?a máy tính , tùy thu?c vào máy tính s? có nh?ng ?? phân gi?i khác nhau

    private void Start()
    {
        resolutions = Screen.resolutions;


        resolutionsDropdown.ClearOptions();

        List<string> optionsList = new List<string>();

        int dophangiaihientai = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            optionsList.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                dophangiaihientai = i;
            }
        }

        resolutionsDropdown.AddOptions(optionsList);
        resolutionsDropdown.value = dophangiaihientai;
        resolutionsDropdown.RefreshShownValue();
    }
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
    public void SetResolution(int reslutionIndex)
    {
        Resolution resolution = resolutions[reslutionIndex];


        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}
