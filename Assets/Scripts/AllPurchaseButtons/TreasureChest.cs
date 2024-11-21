using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TreasureChest : MonoBehaviour
{

    public GameObject realTreasure;
    public GameObject fakeTresure;
    public TextMeshProUGUI treausreCostText;
    public TextMeshProUGUI fakeTreausreCostText;
    public static float currentCoins;
    public static float treasureCost = 1500;
    public static bool turnOffTreasure = false;
    public static int treasureCount;
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
        if (MagicFlipsUpgrade.magicUpgradeCount == 0)
        {
            buttonIcon.SetActive(false);
            coverOver.SetActive(true);
            fakeTresure.SetActive(true);
            realTreasure.SetActive(false);
            fakeTreausreCostText.color = Color.white;
            buttonName.color = Color.white;
            fakeTreausreCostText.GetComponent<TextMeshProUGUI>().text = "???";
            buttonName.GetComponent<TextMeshProUGUI>().text = "????? ?????";
        }
        if (MagicFlipsUpgrade.magicUpgradeCount > 0)
        {
            buttonName.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.TreasueChestName;
            buttonIcon.SetActive(true);
            coverOver.SetActive(false);
            treausreCostText.color = Color.green;
            fakeTreausreCostText.color = Color.red;

            treausreCostText.text = FormatCoins(treasureCost);
            fakeTreausreCostText.text = FormatCoins(treasureCost);


            if (currentCoins >= treasureCost)
            {
                realTreasure.SetActive(true);
                fakeTresure.SetActive(false);
            }
            if (currentCoins < treasureCost)
            {
                realTreasure.SetActive(false);
                fakeTresure.SetActive(true);
            }
            if (turnOffTreasure == true)
            {
                realTreasure.SetActive(true);
                fakeTresure.SetActive(false);
                turnOffTreasure = false;
            }
        }
    }

}
