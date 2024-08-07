using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderMusic : MonoBehaviour
{
    [SerializeField] private Slider sliderSound;

    void Start()
    {
        if(!PlayerPrefs.HasKey("volume"))
        {
            PlayerPrefs.SetFloat("volume", 1);  
            Play();
        }
        else
        {
            Play();
        }
    }

    public void MoveSlider()
    {
        AudioListener.volume = sliderSound.value;
        Save();
    }

    private void Play()
    {
        sliderSound.value = PlayerPrefs.GetFloat("volume", 1);
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("volume", sliderSound.value);
    }
}
