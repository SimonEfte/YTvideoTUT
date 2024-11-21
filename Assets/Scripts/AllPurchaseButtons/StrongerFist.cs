using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StrongerFist : MonoBehaviour
{
    public GameObject realFist;
    public GameObject fakeFist;
    public TextMeshProUGUI fistCostText;
    public TextMeshProUGUI fakeFistCostText;
    public static float currentCoins;
    public static float fistCost = 1500;
    public static bool turnOffFistButton = false;
    public static int fistUpgradeCount;
    public GameObject coverOver;
    public GameObject buttonIcon;
    public TextMeshProUGUI buttonName;

    //public TextMeshProUGUI fistStats;

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
        if (KnowledgeUpgrade.knowledgeUpgradeCount == 0)
        {
            buttonIcon.SetActive(false);
            coverOver.SetActive(true);
            fakeFist.SetActive(true);
            realFist.SetActive(false);
            fakeFistCostText.color = Color.white;
            fakeFistCostText.GetComponent<TextMeshProUGUI>().text = "???";
            buttonName.GetComponent<TextMeshProUGUI>().text = "????? ?????";
            buttonName.color = Color.white;
        }
        if (KnowledgeUpgrade.knowledgeUpgradeCount > 0)
        {
            buttonName.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.strongerFistName;
            buttonIcon.SetActive(true);
            coverOver.SetActive(false);
            fistCostText.color = Color.green;
            fakeFistCostText.color = Color.red;

            fistCostText.text = FormatCoins(fistCost);
            fakeFistCostText.text = FormatCoins(fistCost);

            if (currentCoins >= fistCost)
            {
                realFist.SetActive(true);
                fakeFist.SetActive(false);
            }
            if (currentCoins < fistCost)
            {
                realFist.SetActive(false);
                fakeFist.SetActive(true);
            }
            if (turnOffFistButton == true)
            {
                realFist.SetActive(true);
                fakeFist.SetActive(false);
                turnOffFistButton = false;
            }
        }
        

    }
}
