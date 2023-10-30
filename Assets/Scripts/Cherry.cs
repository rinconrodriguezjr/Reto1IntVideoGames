using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Cherry : MonoBehaviour
{
    public TMP_Text scoreText;
    //public TMP_Text winText;
    private int dotsCollected = 0;
    public int dotsTarget = 15;
    public GameObject cherryObject; 

    void Start()
    {
        UpdateScoreText();
        cherryObject.SetActive(false);
      
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Capsule"))
        {
            Destroy(other.gameObject);
            dotsCollected++;
            UpdateScoreText();

            if (dotsCollected == dotsTarget)
            {
                cherryObject.SetActive(true);

                //if (other.gameObject.CompareTag("Capsule")) 

                //if (winText != null)
                //{
                  //  cherryObject.SetActive(true);


                    //if (other.gameObject.CompareTag("Capsule") && dotsCollected == dotsTarget); 

                   // if (winText != null)
                    //{scoreText.text = "¡Ganaste!";}

               // }
                
            }
        }
    }

    /*void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && cherryObject.activeSelf)
           // if (collision.gameObject.CompareTag("Cherry"))
        {
            if (winText != null)
            {
                winText.text = "¡Ganaste!";
            }
        }
    }
    */

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + dotsCollected.ToString();
        }
    }
}

