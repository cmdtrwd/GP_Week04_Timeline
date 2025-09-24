using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchControl : MonoBehaviour
{
    private bool isOn = false;

    public void ToggleLight()
    {
        if (isOn)
        {
            LightOff();
        }
        else
        {
            LightOn();
        }
    }

    public void LightOn()
    {
        foreach (Transform child in transform)
        {
            child.GetComponent<Light>().enabled = true;
        }
        isOn = true;
    }

    public void LightOff()
    {
        foreach (Transform child in transform)
        {
            child.GetComponent<Light>().enabled = false;
        }
        isOn = false;
    }
}
