using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Ganaste : MonoBehaviour
{
    public string winText = "Ganaste!";
    private bool gameEnded = false;
    public TMP_Text gameOverText;
    private bool isWin = false;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !gameEnded && gameObject.CompareTag("Cherry"))
        {
            EndGame();
        }
    }


    void EndGame()
    {
        gameEnded = true;
        Debug.Log(winText);

        Invoke("LoadWinScene", 0.5f);
    }

    void LoadWinScene()
    {
        // Carga la escena "Ganaste"
        SceneManager.LoadScene("Ganaste");
    }




    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Cherry") && !isWin)
        {
            //Desactivar el jugador 
            gameObject.SetActive(false);

            // Mostrar "GAME OVER"
            gameOverText.text = "WIN";
            gameOverText.gameObject.SetActive(true);

            isWin = true;
        }

    }


}
