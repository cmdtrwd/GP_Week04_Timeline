using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void SaveSettings()
    {
        Debug.Log("Settings have been saved.");

        PlayerPrefs.SetInt("IsLightOn", 1);
    }

    public void LoadSettings()
    {
        Debug.Log("Settings have been loaded.");
        if (PlayerPrefs.GetInt("IsLightOn") == 1)
        {
            Debug.Log("Light is ON");
        }
        else
        {
            Debug.Log("Light is OFF");
        }
    }
}
