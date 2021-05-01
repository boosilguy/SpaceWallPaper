using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingManager : MonoBehaviour
{
    public GameObject settingsContainer;
    public GameObject cosmicObject;
    public GameObject equalizer;
    public GameObject mainText;
    public GameObject subText;
    public GameObject myPCStatus;
    
    public void GetSettingButtonDown()
    {
        if (settingsContainer.activeInHierarchy)
        {
            settingsContainer.SetActive(false);
        }
        else
        {
            settingsContainer.SetActive(true);
        }
    }

    public void GetCosmicButtonDown()
    {
        if (cosmicObject.activeInHierarchy)
        {
            cosmicObject.SetActive(false);
        }
        else
        {
            cosmicObject.SetActive(true);
        }
    }

    public void GetVisualizationButtonDown()
    {
        if (equalizer.activeInHierarchy)
        {
            equalizer.SetActive(false);
        }
        else
        {
            equalizer.SetActive(true);
        }
    }

    public void GetMainTxtButtonDown()
    {
        if (mainText.activeInHierarchy)
        {
            mainText.SetActive(false);
        }
        else
        {
            mainText.SetActive(true);
        }
    }

    public void GetSubTxtButtonDown()
    {
        if (subText.activeInHierarchy)
        {
            subText.SetActive(false);
        }
        else
        {
            subText.SetActive(true);
        }
    }

    public void GetPCStatusButtonDown()
    {
        if (myPCStatus.activeInHierarchy)
        {
            myPCStatus.SetActive(false);
        }
        else
        {
            myPCStatus.SetActive(true);
        }
    }
}
