using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOption : MonoBehaviour
{

    void Start()
    {
        
    }

   
    void Update()
    {

    }

    public void Play(){
        SceneManager.LoadScene("GameLoop");
    }

    public void Quit(){
        Application.Quit();
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }
}