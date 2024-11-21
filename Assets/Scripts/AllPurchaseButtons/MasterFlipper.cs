using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MasterFlipper : MonoBehaviour
{
   

    public GameObject realMasterFlips;
    public GameObject fakeMasterFlips;
    public TextMeshProUGUI realMasterFlipsCostText;
    public TextMeshProUGUI fakeMasterFlipsCostText;
    public static float currentCoins;
    public static float MasterFlipsCost = 375000;
    public static bool turnOffMasterFlipsButton = false;
    public static int MasterFlipsUpgradeCount;
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
        if (StrangePotion.potionUpgradeCount == 0)
        {
            buttonIcon.SetActive(false);
            coverOver.SetActive(true);
            fakeMasterFlips.SetActive(true);
            realMasterFlips.SetActive(false);
            fakeMasterFlipsCostText.color = Color.white;
            fakeMasterFlipsCostText.GetComponent<TextMeshProUGUI>().text = "???";
            buttonName.GetComponent<TextMeshProUGUI>().text = "????? ?????";
            buttonName.color = Color.white;
        }
        if (StrangePotion.potionUpgradeCount > 0)
        {
            buttonName.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.masterFlipperName;
            buttonIcon.SetActive(true);
            coverOver.SetActive(false);
            realMasterFlipsCostText.color = Color.green;
            fakeMasterFlipsCostText.color = Color.red;

            realMasterFlipsCostText.text = FormatCoins(MasterFlipsCost);
            fakeMasterFlipsCostText.text = FormatCoins(MasterFlipsCost);

            


            if (currentCoins >= MasterFlipsCost)
            {
                realMasterFlips.SetActive(true);
                fakeMasterFlips.SetActive(false);
            }
            if (currentCoins < MasterFlipsCost)
            {
                realMasterFlips.SetActive(false);
                fakeMasterFlips.SetActive(true);
            }
            if (turnOffMasterFlipsButton == true)
            {
                realMasterFlips.SetActive(true);
                fakeMasterFlips.SetActive(false);
                turnOffMasterFlipsButton = false;
            }
        }
          

    }
}
