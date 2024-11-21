using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StrangePotion : MonoBehaviour
{
    public GameObject realPotion;
    public GameObject fakePotion;
    public TextMeshProUGUI potionCostText;
    public TextMeshProUGUI fakePotionCostText;
    public static float currentCoins;
    public static float potionCost = 165000;
    public static bool turnOffPotionButton = false;
    public static int potionUpgradeCount;
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

    //public TextMeshProUGUI injectionStats;

    public void Update()
    {
        currentCoins = GlobalCoins.CoinCount;
        if (HydrationButton.hydrationUpgradeCount == 0)
        {
            buttonIcon.SetActive(false);
            coverOver.SetActive(true);
            fakePotion.SetActive(true);
            realPotion.SetActive(false);
            fakePotionCostText.GetComponent<TextMeshProUGUI>().text = "???";
            fakePotionCostText.color = Color.white;
            buttonName.color = Color.white;
            buttonName.GetComponent<TextMeshProUGUI>().text = "????? ?????";
        }
        if (HydrationButton.hydrationUpgradeCount > 0)
        {
            buttonName.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.strangePotionName;
            buttonIcon.SetActive(true);
            coverOver.SetActive(false);
            potionCostText.color = Color.green;
            fakePotionCostText.color = Color.red;

            potionCostText.text = FormatCoins(potionCost);
            fakePotionCostText.text = FormatCoins(potionCost);

            if (currentCoins >= potionCost)
            {
                realPotion.SetActive(true);
                fakePotion.SetActive(false);
            }
            if (currentCoins < potionCost)
            {
                realPotion.SetActive(false);
                fakePotion.SetActive(true);
            }
            if (turnOffPotionButton == true)
            {
                realPotion.SetActive(true);
                fakePotion.SetActive(false);
                turnOffPotionButton = false;
            }
        }

        

    }
}
