using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back2Game : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void Game()
    {
        SceneManager.LoadScene("GameLoop");
    }
}
