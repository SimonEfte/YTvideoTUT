using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Upgrade12 : MonoBehaviour
{
    public GameObject realUpgrade12;
    public GameObject fakeUpgrade12;
    public TextMeshProUGUI upgrade12CostText;
    public TextMeshProUGUI fakeUpgrade12CostText;
    public static float currentCoins;
    public static float upgrade12Cost = 10000;
    public static bool turnOffUpgrade12 = false;
    public static int upgrade12Count;
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
        if (HandShake.handShakeUpgradeCount == 0)
        {
            buttonIcon.SetActive(false);
            coverOver.SetActive(true);
            fakeUpgrade12.SetActive(true);
            realUpgrade12.SetActive(false);
            fakeUpgrade12CostText.GetComponent<TextMeshProUGUI>().text = "???";
            fakeUpgrade12CostText.color = Color.white;
            buttonName.GetComponent<TextMeshProUGUI>().text = "????? ?????";
            buttonName.color = Color.white;
        }
        if (HandShake.handShakeUpgradeCount > 0)
        {
            buttonName.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.highFiveName;
            buttonIcon.SetActive(true);
            coverOver.SetActive(false);
            upgrade12CostText.color = Color.green;
            fakeUpgrade12CostText.color = Color.red;

            upgrade12CostText.text = FormatCoins(upgrade12Cost);
            fakeUpgrade12CostText.text = FormatCoins(upgrade12Cost);

            if (currentCoins >= upgrade12Cost)
            {
                realUpgrade12.SetActive(true);
                fakeUpgrade12.SetActive(false);
            }
            if (currentCoins < upgrade12Cost)
            {
                realUpgrade12.SetActive(false);
                fakeUpgrade12.SetActive(true);
            }
            if (turnOffUpgrade12 == true)
            {
                realUpgrade12.SetActive(true);
                fakeUpgrade12.SetActive(false);
                turnOffUpgrade12 = false;
            }
        }

    }

}
