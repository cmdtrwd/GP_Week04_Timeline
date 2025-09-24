using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Light sceneLight;
    public GameObject objectToMove;
    public void SaveSettings()
    {
        Debug.Log("Settings have been saved.");
        int isOn = sceneLight.enabled ? 1 : 0;
        PlayerPrefs.SetInt("IsLightOn", isOn);
        PlayerPrefs.SetFloat("ObjectPosX", objectToMove.transform.position.x);
        PlayerPrefs.SetFloat("ObjectPosY", objectToMove.transform.position.y);
        PlayerPrefs.SetFloat("ObjectPosZ", objectToMove.transform.position.z);
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

        float x = PlayerPrefs.GetFloat("ObjectPosX");
        float y = PlayerPrefs.GetFloat("ObjectPosY");
        float z = PlayerPrefs.GetFloat("ObjectPosZ");
        objectToMove.transform.position = new Vector3(x, y, z);        
    }
}
