using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CherryAppearance : MonoBehaviour
{
    public int dotCount = 0; 
    public int dotTarget = 1; 
    public GameObject cherryObject; 
    //public TMP_Text winText;
    public TMP_Text scoreText;
    public TMP_Text winText;

    //private bool isWin = false;

    void Start()
    {
        //UpdateScore(dotCount);

    }
    void UpdateScore(int score)
    {   
      
        winText.text = score == dotTarget ? "WIN" : score.ToString();
        
    }

    
    void CheckDotCount()
    {
        if (dotCount == dotTarget)
                {
            cherryObject.SetActive(true);
           }
         
    }


    public void CollectDot()
    {
        dotCount++;
        CheckDotCount(); // Verificar si se ha alcanzado la cantidad objetivo antes de actualizar el puntaje.
        UpdateScore(dotCount);
    }
   
}
