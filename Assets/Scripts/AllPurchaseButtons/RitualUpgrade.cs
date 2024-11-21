using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RitualUpgrade : MonoBehaviour
{

    public GameObject realRitual;
    public GameObject fakeRitual;
    public TextMeshProUGUI ritualCostText;
    public TextMeshProUGUI fakeRitualCostText;
    public static float currentCoins;
    public static float ritualCost = 1500;
    public static bool turnOffritual = false;
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
        if (TreasureChest.treasureCount == 0)
        {
            buttonIcon.SetActive(false);
            coverOver.SetActive(true);
            fakeRitual.SetActive(true);
            realRitual.SetActive(false);
            fakeRitualCostText.color = Color.white;
            buttonName.color = Color.white;
            fakeRitualCostText.GetComponent<TextMeshProUGUI>().text = "???";
            buttonName.GetComponent<TextMeshProUGUI>().text = "????? ?????";
        }
        if (TreasureChest.treasureCount > 0)
        {
            buttonName.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.coinFlippingRitualName;
            buttonIcon.SetActive(true);
            coverOver.SetActive(false);
            ritualCostText.color = Color.green;
            fakeRitualCostText.color = Color.red;

            ritualCostText.text = FormatCoins(ritualCost);
            fakeRitualCostText.text = FormatCoins(ritualCost);

           

            if (currentCoins >= ritualCost)
            {
                realRitual.SetActive(true);
                fakeRitual.SetActive(false);
            }
            if (currentCoins < ritualCost)
            {
                realRitual.SetActive(false);
                fakeRitual.SetActive(true);
            }
            if (turnOffritual == true)
            {
                realRitual.SetActive(true);
                fakeRitual.SetActive(false);
                turnOffritual = false;
            }
        }


    }
}
