using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Light sceneLight;
    public void SaveSettings()
    {
        Debug.Log("Settings have been saved.");
        int isOn = sceneLight.enabled ? 1 : 0;
        PlayerPrefs.SetInt("IsLightOn", isOn);
    }

    public void LoadSettings()
    {
        Debug.Log("Settings have been loaded.");
        if (PlayerPrefs.GetInt("IsLightOn") == 1)
        {
            Debug.Log("Light is ON");
            sceneLight.enabled = true;
        }
        else
        {
            Debug.Log("Light is OFF");
            sceneLight.enabled = false;
        }
    }
}
