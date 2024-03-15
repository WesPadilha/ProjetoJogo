using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class npcTalk : MonoBehaviour
{
    public bool isDialogueActive = false;
    public Text dialogueText; // Atribua o componente Text no Inspector
    private List<string> dialogues = new List<string>();
    private int currentDialogueIndex = 0;
    public List<string> dialogueList;

    void Start()
    {
        dialogueText.gameObject.SetActive(false);
    }

    void Update()
    {
        if (isDialogueActive)
        {
            dialogueText.gameObject.SetActive(true);
            dialogueText.text = dialogues[currentDialogueIndex];

            if (Input.GetKeyDown(KeyCode.E))
            {
                currentDialogueIndex++;
                if (currentDialogueIndex >= dialogues.Count)
                {
                    isDialogueActive = false;
                    currentDialogueIndex = 0; // Reset index para a próxima interação
                }
            }
        }
        else
        {
            dialogueText.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isDialogueActive = false;
            currentDialogueIndex = 0; // Reset index para a próxima interação
        }
    }

    public void StartDialogue(List<string> dialogueList)
    {
        dialogues = dialogueList;
        isDialogueActive = true;
        currentDialogueIndex = 0;
    }
}
