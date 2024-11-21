using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteMusic : MonoBehaviour
{
    [SerializeField] Slider musicVolumeSlider;
    public GameObject MuteButton;
    public GameObject UnMuteButton;
    public AudioSource music;

    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 0.5f);
            Load();
        }
        else
        {
            Load();
        }

       

    }
    private void Update()
    {
        if (MuteAudio.muteAudio == 1)
        {
            music.volume = 0;
            UnMuteButton.SetActive(true);
            MuteButton.SetActive(false);
        }
        if (MuteAudio.muteAudio == 0)
        {
            music.volume = musicVolumeSlider.value;
            UnMuteButton.SetActive(false);
            MuteButton.SetActive(true);
        }
    }

    public void ChangeMusicVolume()
    {
        if (UnMuteButton.activeInHierarchy)
        {
            music.volume = 0;
        }
        if (MuteButton.activeInHierarchy)
        {
            music.volume = musicVolumeSlider.value;
            Save();
        }
        
    }

    public void Load()
    {
        musicVolumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }
    public void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", musicVolumeSlider.value);
    }

}
