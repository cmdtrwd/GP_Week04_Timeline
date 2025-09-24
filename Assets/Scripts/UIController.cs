using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text playerXPos, playerYPos, playerZPos;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        playerXPos.text = "X Pos: " + player.transform.position.x;
        playerYPos.text = "Y Pos: " + player.transform.position.y;
        playerZPos.text = "Z Pos: " + player.transform.position.z;
    }
}
