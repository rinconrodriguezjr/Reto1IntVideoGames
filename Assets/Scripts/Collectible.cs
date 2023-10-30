using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

    public class Collectible : MonoBehaviour
    {
        public int dotCount = 0;
        public int dotTarget = 1;
        public GameObject cherryObject;
        public TMP_Text winText;
        public int scoreValue = 1;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player")) 
            {
                GameManager.instance.AddScore(scoreValue); 
                Destroy(gameObject); 
            }
        }
        
    

    }

