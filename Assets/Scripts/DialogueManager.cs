using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueManager : MonoBehaviour
{
    public TMPro.TextMeshProUGUI nameText;
    public TMPro.TextMeshProUGUI mainText;
    // public Animator anim;
    private Queue<string> sentences;


    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogues _dialogue)
    {
        //Debug.Log("Starting conversation with " + _dialogue.name);

        // anim.SetBool("IsOpen", true);

        nameText.text = _dialogue.name;

        sentences.Clear();

        foreach(string sentence in _dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            // anim.SetBool("IsOpen", false);
            return;
        }

        string sentence = sentences.Dequeue();
        mainText.text = sentence;

        //Debug.Log(sentence);
    }

    void EndDialogue()
    {
        Debug.Log("End of Conversation");
    }
}
