using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
     public static Score singleton;
     int shipsCollected = 0;

    void Awake(){
        if(singleton != null){
            Destroy(this.gameObject);
        }
        singleton = this;
    }
    void Start(){

    }

    public void RegisterCoin()
    {
        shipsCollected += 1;
        scoreText.text = "Score: " + shipsCollected.ToString();
    }

}
