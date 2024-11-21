using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HandInecjtion : MonoBehaviour
{
    public GameObject realInjection;
    public GameObject fakeInjection;
    public TextMeshProUGUI injectionButtonCost;
    public TextMeshProUGUI fakeInjectionButtonCost;
    public static float currentCoins;
    public static float injectionCost = 5350;
    public static bool turnOffInjectionButton = false;
    public static int injectionUpgradeCount;
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
        if (StrongerFist.fistUpgradeCount == 0)
        {
            buttonIcon.SetActive(false);
            coverOver.SetActive(true);
            fakeInjection.SetActive(true);
            realInjection.SetActive(false);
            fakeInjectionButtonCost.color = Color.white;
            buttonName.color = Color.white;
            fakeInjectionButtonCost.GetComponent<TextMeshProUGUI>().text = "???";
            buttonName.GetComponent<TextMeshProUGUI>().text = "????? ?????";
        }
        if (StrongerFist.fistUpgradeCount > 0)
        {
            buttonName.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.handInjectionName;
            buttonIcon.SetActive(true);
            coverOver.SetActive(false);
            injectionButtonCost.color = Color.green;
            fakeInjectionButtonCost.color = Color.red;

            injectionButtonCost.text = FormatCoins(injectionCost);
            fakeInjectionButtonCost.text = FormatCoins(injectionCost);


            if (currentCoins >= injectionCost)
            {
                realInjection.SetActive(true);
                fakeInjection.SetActive(false);
            }
            if (currentCoins < injectionCost)
            {
                realInjection.SetActive(false);
                fakeInjection.SetActive(true);
            }
            if (turnOffInjectionButton == true)
            {
                realInjection.SetActive(true);
                fakeInjection.SetActive(false);
                turnOffInjectionButton = false;
            }

        }


    }
}
