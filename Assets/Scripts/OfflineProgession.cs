using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class OfflineProgession : MonoBehaviour
{
    public TextMeshProUGUI timePassedText;
    public TextMeshProUGUI coinsAmountText;
    public GameObject offlineBar;
    public float coinsAmount;

    void Start()
    {
        StartCoroutine(SetOfflineEarnings());
    }

    public static string FormatCoins(float coins)
    {
        return coins switch
        {
            >= 1E+36f => ((float)coins / 1E+36).ToString("0.##") + LocalizationStrings.undecillionc,
            >= 1E+33f => ((float)coins / 1E+33).ToString("0.##") + LocalizationStrings.decillionc,
            >= 1E+30f => ((float)coins / 1E+30).ToString("0.##") + LocalizationStrings.nonillionc,
            >= 1E+27f => ((float)coins / 1E+27).ToString("0.##") + LocalizationStrings.octillionc,
            >= 1E+24f => ((float)coins / 1E+24).ToString("0.##") + LocalizationStrings.septillionc,
            >= 1E+21f => ((float)coins / 1E+21).ToString("0.##") + LocalizationStrings.sextillionc,
            >= 1E+18f => ((float)coins / 1E+18).ToString("0.##") + LocalizationStrings.quintillionc,
            >= 1E+15f => ((float)coins / 1E+15).ToString("0.##") + LocalizationStrings.quadrillionc,
            >= 1E+12f => ((float)coins / 1000000000000.0).ToString("0.##") + LocalizationStrings.trillionc,
            >= 1E+09f => ((float)coins / 1000000000.0).ToString("0.##") + LocalizationStrings.billionc,
            >= 1000000f => ((float)coins / 1000000.0).ToString("0.##") + LocalizationStrings.millionc,
            >= 1000f => ((float)coins / 1000.0).ToString("0.##") + LocalizationStrings.thousandC,
            _ => ((float)coins / 1.0).ToString("##") + LocalizationStrings.coins
        };
    }

    IEnumerator SetOfflineEarnings()
    {
        yield return new WaitForSeconds(0.25f);

        if (PlayerPrefs.HasKey("LoginOffline"))
        {
            offlineBar.SetActive(true);
            DateTime lastLogIn = DateTime.Parse(PlayerPrefs.GetString("LoginOffline"));

            TimeSpan timeSpan = DateTime.Now - lastLogIn;

            coinsAmount = ((int)timeSpan.TotalMinutes * (MainButtonClick.coinsPerClick * GlobalCoinMaker.coinsPerFlipUpgrades));

            timePassedText.text = (timeSpan.Days + LocalizationStrings.days + timeSpan.Hours + LocalizationStrings.hours +  timeSpan.Minutes + LocalizationStrings.minuts + timeSpan.Seconds + LocalizationStrings.seconds);

            if(coinsAmount == 0) { coinsAmountText.text = "+0" + FormatCoins(coinsAmount); }
            else
            {
                coinsAmountText.text = "+" + FormatCoins(coinsAmount);
            }
         

            GlobalCoins.CoinCount += ((int)timeSpan.TotalMinutes * (MainButtonClick.coinsPerClick * GlobalCoinMaker.coinsPerFlipUpgrades));
        }
        else
        {
            offlineBar.SetActive(false);
        }
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetString("LoginOffline", DateTime.Now.ToString());
    }


    public void ClickOkOnOfflineBar()
    {
        offlineBar.SetActive(false);
    }

}
