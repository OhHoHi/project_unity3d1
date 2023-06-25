using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Dropdown resolutionsDropdown;


    Resolution[] resolutions; // ?? ch?a c�c ?? ph�n gi?i c?a m�y t�nh , t�y thu?c v�o m�y t�nh s? c� nh?ng ?? ph�n gi?i kh�c nhau

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
