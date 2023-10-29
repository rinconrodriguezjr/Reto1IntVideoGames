using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CherryAppearance : MonoBehaviour
{
    public int dotCount = 0; 
    public int dotTarget = 15; 
    public GameObject cherryObject; 
    public TMP_Text scoreText;

    //bool cherryCollected = false;

   
    void UpdateScore(int score)
    {
        Debug.Log("dotTargetText" + score);
        scoreText.text = score == dotTarget ? "WIN" : score.ToString();
        //scoreText.text = cherryCollected ? "WIN" : score.ToString();
    }

    
    void CheckDotCount()
    {
        if (dotCount >= dotTarget)
                {
            cherryObject.SetActive(true); 
            UpdateScore(dotCount); 
        }
        // if (dotCount >= dotTarget && !cherryCollected)
        //{
        //  cherryObject.SetActive(true);
        // UpdateScore(dotCount);
        // }
    }

    /*void InteractWithCherry()
    {
        if (dotCount >= dotTarget && !cherryCollected)
        {
            cherryCollected = true; // Se marca el Cherry como recolectado
            cherryObject.SetActive(false); // Ocultar el objeto Cherry
            UpdateScore(dotCount); // Cambiar el texto del puntaje a "WIN"
        }
    }*/


    public void CollectDot()
    {
        dotCount++; 
        UpdateScore(dotCount); 

        CheckDotCount(); 
    }
    /*public void CollectDot()
    {
        if (!cherryCollected)
        {
            dotCount++; // Aumentar el contador de elementos DOT recolectados
            UpdateScore(dotCount); // Actualizar el texto del puntaje

            CheckDotCount(); // Verificar si se alcanzó la cantidad necesaria para mostrar el Cherry
        }
    }*/
}
