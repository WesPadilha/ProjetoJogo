using UnityEngine;

public class Dialogos : MonoBehaviour
{
    /*private bool isDialogActive = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isDialogActive = true;
            // Desabilita o movimento do jogador e da câmera
            other.GetComponent<Player>().SetMovementEnabled(false);
            Camera.main.GetComponent<CameraController>().SetMouseLock(false);
        }
    }

    void Update()
    {
        if (isDialogActive && Input.GetKeyDown(KeyCode.Escape))
        {
            // Habilita o movimento do jogador e da câmera ao pressionar ESC
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.GetComponent<Player>().SetMovementEnabled(true);
            Camera.main.GetComponent<CameraController>().SetMouseLock(true);
            isDialogActive = false;
        }
    }*/
}
