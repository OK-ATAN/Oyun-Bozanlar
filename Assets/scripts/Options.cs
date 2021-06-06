using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Options : MonoBehaviour
{
    public float hassasiyetDeger;
    public AudioMixer audioMixer;
    public UnityEngine.UI.Slider sensBar;

    private void Start()
    {
        if (PlayerPrefs.HasKey("mouseHassasiyet"))
        {
            hassasiyetDeger = PlayerPrefs.GetFloat("mouseHassasiyet");
            sensBar.value = PlayerPrefs.GetFloat("sensSlider");
        }
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume",volume);
    }

    public void HassasiyetSave()
    {
        hassasiyetDeger = sensBar.value;
        PlayerPrefs.SetFloat("mouseHassasiyet", hassasiyetDeger); //hassasiyet ayari
        PlayerPrefs.SetFloat("sensSlider", sensBar.value);
    }

    public void option()
    {
        sensBar.gameObject.SetActive(true);
    }
    
}
