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
        Debug.Log(winText); // Muestra "¡Ganaste!" en la consola (puedes cambiar esto a mostrar un mensaje en pantalla si lo prefieres)
        // Aquí puedes agregar lógica adicional para el final del juego

        // Ejemplo: Reiniciar el nivel después de un breve retraso
        Invoke("RestartLevel", 2f);
    }

    void RestartLevel()
    {
        // Carga el nivel actual de nuevo
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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
