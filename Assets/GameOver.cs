using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
     private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            EndGame();
        }
    }

    void EndGame()
    {

        Debug.Log("Game Over!");
        SceneManager.LoadScene("mainmenu"); 
     
    }
}
