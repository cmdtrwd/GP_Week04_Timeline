using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZomBearInteraction : MonoBehaviour
{
    private DialogueTrigger _dialogueTrigger;
    // Start is called before the first frame update
    void Start()
    {
        _dialogueTrigger = GetComponent<DialogueTrigger>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        _dialogueTrigger.TriggerDialogue();
    }
}
