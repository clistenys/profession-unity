using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Tarefa4 : MonoBehaviour
{
    Resolution[] resolutions;

    void Start()
    {
        resolutions = Screen.resolutions;
        Screen.SetResolution(resolutions[0].width, resolutions[0].height, false);
    }

    public void OnClickButton()
    {
        Application.Quit();
    }

    public void OnToggleMark()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }

    public void SelectDropDownValue()
    {
        var value = gameObject.GetComponent<Dropdown>().value;

        Screen.SetResolution(resolutions[value].width, resolutions[value].height, Screen.fullScreen);
    }
}
