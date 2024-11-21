using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BrainPower : MonoBehaviour
{
    public GameObject realBrainPower;
    public GameObject fakeBrainPower;
    public TextMeshProUGUI brainPowerButtonCost;
    public TextMeshProUGUI fakeBrainPowerButtonCost;
    public static float currentCoins;
    public static float brainPowerCost = 10000;
    public static bool turnOffBrainPowerButton = false;
    public static int brainPowerUpgradeCount;
    public GameObject coverOver;
    public GameObject buttonIcon;
    public TextMeshProUGUI buttonName;
    public float calc;

    //public TextMeshProUGUI injectionStats;

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
        if (HandInecjtion.injectionUpgradeCount == 0)
        {
            buttonIcon.SetActive(false);
            coverOver.SetActive(true);
            fakeBrainPower.SetActive(true);
            realBrainPower.SetActive(false);
            fakeBrainPowerButtonCost.color = Color.white;
            buttonName.color = Color.white;
            fakeBrainPowerButtonCost.GetComponent<TextMeshProUGUI>().text = "???";
            buttonName.GetComponent<TextMeshProUGUI>().text = "????? ?????";
        }
        if (HandInecjtion.injectionUpgradeCount > 0)
        {
            buttonName.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.brainPowerName;
            buttonIcon.SetActive(true);
            coverOver.SetActive(false);
            brainPowerButtonCost.color = Color.green;
            fakeBrainPowerButtonCost.color = Color.red;

            brainPowerButtonCost.text = FormatCoins(brainPowerCost);
            fakeBrainPowerButtonCost.text = FormatCoins(brainPowerCost);

            if (currentCoins >= brainPowerCost)
            {
                realBrainPower.SetActive(true);
                fakeBrainPower.SetActive(false);
            }
            if (currentCoins < brainPowerCost)
            {
                realBrainPower.SetActive(false);
                fakeBrainPower.SetActive(true);
            }
            if (turnOffBrainPowerButton == true)
            {
                realBrainPower.SetActive(true);
                fakeBrainPower.SetActive(false);
                turnOffBrainPowerButton = false;
            }
        }
    }
}
