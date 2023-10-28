using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class GameOver : MonoBehaviour
{

    public TMP_Text gameOverText;
    private bool isGameOver = false;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Enemy") && !isGameOver)
        {
            //Desactivar el jugador 
            gameObject.SetActive(false);

            // Mostrar "GAME OVER"
            gameOverText.text = "GAME OVER";
            gameOverText.gameObject.SetActive(true);

            isGameOver = true;
        }
                
        }

  
}
