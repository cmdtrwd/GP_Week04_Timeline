using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSaveManager : MonoBehaviour
{   
    public Toggle toggleA;    
    public GameObject player;
    public void SaveGameWithPlayerPrefs()
    {
        PlayerPrefs.SetInt("lightA", toggleA.isOn ? 1 : 0);
        

        PlayerPrefs.SetFloat("xPos", player.transform.position.x);
        PlayerPrefs.SetFloat("yPos", player.transform.position.y);
        PlayerPrefs.SetFloat("zPos", player.transform.position.z);
    }

    public void LoadGameWithPlayerPrefs()
    {
        Debug.Log("Load");
        if (PlayerPrefs.HasKey("lightA"))
        {
            Debug.Log("Has Key");
            if(PlayerPrefs.GetInt("lightA") == 1)
            {
                toggleA.isOn = true;
                Debug.Log("On");
            }
            else
            {
                toggleA.isOn = false;
            }
        }
             

        if (PlayerPrefs.HasKey("xPos") && PlayerPrefs.HasKey("yPos") && PlayerPrefs.HasKey("zPos"))
        {
            float xPos = PlayerPrefs.GetFloat("xPos");
            float yPos = PlayerPrefs.GetFloat("yPos");
            float zPos = PlayerPrefs.GetFloat("zPos");

            player.transform.position = new Vector3(xPos, yPos, zPos);
        }
    }


    public void SaveGameWithBinary()
    {
        GameSaveBinary.SaveData(this);
    }

    public void LoadGameWithBinary()
    {
        GameData data = GameSaveBinary.LoadData();

        toggleA.isOn = data.isLightA_On;


        float xPos = data.playerPosition[0];
        float yPos = data.playerPosition[1];
        float zPos = data.playerPosition[2];

        player.transform.position = new Vector3(xPos, yPos, zPos);

    }
}
