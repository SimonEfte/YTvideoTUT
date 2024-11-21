using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteAudio : MonoBehaviour
{
    public AudioSource coinFlipped1;
    public AudioSource coinFlipped2;
    public AudioSource upgradeSound1;
    public AudioSource upgradeSound2;
    public AudioSource luckyFlipSound;
    public AudioSource click;
    public AudioSource ascendPoof;
    public AudioSource pileClick;
    public GameObject MuteButton;
    public GameObject UnMuteButton;


    [SerializeField] Slider audioVolumeSlider;

    void Start()
    {

        if (!PlayerPrefs.HasKey("audioVolumeSlider"))
        {
            PlayerPrefs.SetFloat("audioVolumeSlider", 0.7f);
            LoadAudio();
        }
        else
        {
            LoadAudio();
        }
        if (muteAudio == 0)
        {
            coinFlipped1.volume = audioVolumeSlider.value;
            coinFlipped2.volume = audioVolumeSlider.value;
            upgradeSound1.volume = audioVolumeSlider.value;
            upgradeSound2.volume = audioVolumeSlider.value;
            luckyFlipSound.volume = audioVolumeSlider.value;
            ascendPoof.volume = audioVolumeSlider.value;
            pileClick.volume = audioVolumeSlider.value;
            click.volume = audioVolumeSlider.value;
            UnMuteButton.SetActive(false);
            MuteButton.SetActive(true);
        }
        if (muteAudio == 1)
        {
            coinFlipped1.volume = 0;
            coinFlipped2.volume = 0;
            upgradeSound1.volume = 0;
            upgradeSound2.volume = 0;
            luckyFlipSound.volume = 0;
            ascendPoof.volume = 0;
            pileClick.volume = 0;
            click.volume = 0;
            UnMuteButton.SetActive(true);
            MuteButton.SetActive(false);
        }
    }

    public void ChangeAudioVolume()
    {
        if (UnMuteButton.activeInHierarchy)
        {
            coinFlipped1.volume = 0;
            coinFlipped2.volume = 0;
            upgradeSound1.volume = 0;
            upgradeSound2.volume = 0;
            luckyFlipSound.volume = 0;
            ascendPoof.volume = 0;
            pileClick.volume = 0;
            click.volume = 0;
        }
        if (MuteButton.activeInHierarchy)
        {
            ascendPoof.volume = audioVolumeSlider.value;
            pileClick.volume = audioVolumeSlider.value;
            coinFlipped1.volume = audioVolumeSlider.value;
            coinFlipped2.volume = audioVolumeSlider.value;
            upgradeSound1.volume = audioVolumeSlider.value;
            upgradeSound2.volume = audioVolumeSlider.value;
            luckyFlipSound.volume = audioVolumeSlider.value;
            click.volume = audioVolumeSlider.value;
            SaveAudio();
        }
    }

    

    public void LoadAudio()
    {
        audioVolumeSlider.value = PlayerPrefs.GetFloat("audioVolumeSlider");
    }

    public void SaveAudio()
    {
        PlayerPrefs.SetFloat("audioVolumeSlider", audioVolumeSlider.value);
    }

  


    public void MuteAduio()
    {
        coinFlipped1.volume = 0;
        coinFlipped2.volume = 0;
        upgradeSound1.volume = 0;
        upgradeSound2.volume = 0;
        luckyFlipSound.volume = 0;
        click.volume = 0;
        ascendPoof.volume = 0;
        pileClick.volume = 0;
        UnMuteButton.SetActive(true);
        MuteButton.SetActive(false);
        muteAudio = 1;
        PlayerPrefs.SetInt("MutedAudio", MuteAudio.muteAudio);

    }

    public static int muteAudio = 0;
    
    public void UnMuteAudio()

    {
        muteAudio = 0;
        coinFlipped1.volume = audioVolumeSlider.value;
        coinFlipped2.volume = audioVolumeSlider.value;
        upgradeSound1.volume = audioVolumeSlider.value;
        upgradeSound2.volume = audioVolumeSlider.value;
        luckyFlipSound.volume = audioVolumeSlider.value;
        ascendPoof.volume = audioVolumeSlider.value;
        pileClick.volume = audioVolumeSlider.value;
        click.volume = audioVolumeSlider.value;
        UnMuteButton.SetActive(false);
        MuteButton.SetActive(true);
        PlayerPrefs.SetInt("MutedAudio", MuteAudio.muteAudio);

    }

}


