using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class HandShake : MonoBehaviour
{

    public GameObject realHandShake;
    public GameObject fakeHandShake;
    public TextMeshProUGUI handShakeCostText;
    public TextMeshProUGUI fakeHandShakeCostText;
    public static float currentCoins;
    public static float handshakeCost = 650000;
    public static bool turnOffHandsShakeButton = false;
    public static int handShakeUpgradeCount;
    public GameObject coverOver;
    public GameObject buttonIcon;
    public TextMeshProUGUI buttonName;

    public static string FormatCoins(float coins)
    {
        return coins switch
        {
            >= 1E+36f => ((float)coins / 1E+36).ToString("0.##") + LocalizationStrings.undecillion,
            >= 1E+33f => ((float)coins / 1E+33).ToString("0.##") + LocalizationStrings.decillion,
            >= 1E+30f => ((float)coins / 1E+30).ToString("0.##") + LocalizationStrings.nonillion,
            >= 1E+27f => ((float)coins / 1E+27).ToString("0.##") + LocalizationStrings.octillion,
            >= 1E+24f => ((float)coins / 1E+24).ToString("0.##") + LocalizationStrings.septillion,
            >= 1E+21f => ((float)coins / 1E+21).ToString("0.##") + LocalizationStrings.sextillion,
            >= 1E+18f => ((float)coins / 1E+18).ToString("0.##") + LocalizationStrings.quintillion,
            >= 1E+15f => ((float)coins / 1E+15).ToString("0.##") + LocalizationStrings.quadrillion,
            >= 1E+12f => ((float)coins / 1000000000000.0).ToString("0.##") + LocalizationStrings.trillion,
            >= 1E+09f => ((float)coins / 1000000000.0).ToString("0.##") + LocalizationStrings.billion,
            >= 1000000f => ((float)coins / 1000000.0).ToString("0.##") + LocalizationStrings.million,
            >= 1000f => ((float)coins / 1000.0).ToString("0.##") + LocalizationStrings.thousand,
            _ => ((float)coins / 1.0).ToString("##") ?? ""
        };
    }

    public void Update()
    {
        currentCoins = GlobalCoins.CoinCount;
        if (MasterFlipper.MasterFlipsUpgradeCount == 0)
        {
            buttonIcon.SetActive(false);
            coverOver.SetActive(true);
            realHandShake.SetActive(false);
            fakeHandShake.SetActive(true);
            fakeHandShakeCostText.color = Color.white;
            fakeHandShakeCostText.GetComponent<TextMeshProUGUI>().text = "???";
            buttonName.GetComponent<TextMeshProUGUI>().text = "????? ?????";
            buttonName.color = Color.white;
        }
        if (MasterFlipper.MasterFlipsUpgradeCount > 0)
        {
            buttonName.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.handShakeName;
            buttonIcon.SetActive(true);
            coverOver.SetActive(false);
            handShakeCostText.color = Color.green;
            fakeHandShakeCostText.color = Color.red;

            handShakeCostText.text = FormatCoins(handshakeCost);
            fakeHandShakeCostText.text = FormatCoins(handshakeCost);


            if (currentCoins >= handshakeCost)
            {
                realHandShake.SetActive(true);
                fakeHandShake.SetActive(false);
            }
            if (currentCoins < handshakeCost)
            {
                realHandShake.SetActive(false);
                fakeHandShake.SetActive(true);
            }
            if (turnOffHandsShakeButton == true)
            {
                realHandShake.SetActive(true);
                fakeHandShake.SetActive(false);
                turnOffHandsShakeButton = false;
            }
        }
            

    }
    
}
