using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
public class PlayerTalk : MonoBehaviour
{
    public static bool isDialogueActive = false; 
    public delegate void OnDialogueExit();
    public static event OnDialogueExit DialogueExitEvent; // Evento para notificar a saída do diálogo

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            Vector3 direction = transform.TransformDirection(Vector3.forward);
            if (Physics.Raycast(transform.position, direction, out hit, 3))
            {
                if (hit.transform.CompareTag("NPC"))
                {
                    npcTalk npcScript = hit.transform.GetComponent<npcTalk>();
                    if (npcScript != null)
                    {
                        npcScript.StartDialogue(npcScript.dialogueList);
                        isDialogueActive = true; // Ativar o sinalizador de diálogo
                    }
                }
            }
        }

        // Verificar se o jogador pressionou a tecla Esc para sair do diálogo
        if (isDialogueActive && Input.GetKeyDown(KeyCode.Escape))
        {
            isDialogueActive = false;
            DialogueExitEvent?.Invoke(); // Chamar o evento de saída do diálogo
        }
    }
}
