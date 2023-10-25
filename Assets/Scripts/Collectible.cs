using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Collectible : MonoBehaviour
    {
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

