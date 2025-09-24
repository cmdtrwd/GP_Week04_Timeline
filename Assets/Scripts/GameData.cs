using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public bool isLightA_On, isLightB_On, isLightC_On;
    public float[] playerPosition;

    public GameData(GameSaveManager gameManager)
    {
        isLightA_On = gameManager.toggleA.isOn;
        isLightB_On = gameManager.toggleB.isOn;
        isLightC_On = gameManager.toggleC.isOn;

        playerPosition = new float[3];
        playerPosition[0] = gameManager.player.transform.position.x;
        playerPosition[1] = gameManager.player.transform.position.y;
        playerPosition[2] = gameManager.player.transform.position.z;
    }
}
