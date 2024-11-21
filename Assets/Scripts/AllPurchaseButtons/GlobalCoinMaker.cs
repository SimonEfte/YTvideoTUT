using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalCoinMaker : MonoBehaviour
{

    public GameObject fakeButton;
    public GameObject realButton;
    public static float currentCoins;
    public static float coinValue = 350;
    public static bool turnOffButton = false;
    public static int coinsPerFlipUpgrades;
    public TextMeshProUGUI buttonName;
    public TextMeshProUGUI fakeButtonName;
    public TextMeshProUGUI buttonCost;
    public TextMeshProUGUI fakeButtonCost;

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
    void Update()
    {
        currentCoins = GlobalCoins.CoinCount;
        buttonCost.color = Color.green;
        fakeButtonCost.color = Color.red;

        buttonCost.text = FormatCoins(coinValue);
        fakeButtonCost.text = FormatCoins(coinValue);

        buttonName.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.autoUpgradeName;
        fakeButtonName.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.autoUpgradeName;
        
        if(coinsPerFlipUpgrades == 21)
        {
            fakeButton.SetActive(true);
            realButton.SetActive(false);
            buttonName.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.theyAllFlip;
            fakeButtonName.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.theyAllFlip;
            fakeButtonCost.color = Color.red;
            fakeButtonCost.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.spendNoMore;
        }

        if (currentCoins >= coinValue && coinsPerFlipUpgrades <= MainButtonClick.numberOfDuplicationUpgrades)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }

        if (currentCoins < coinValue)
        {
            fakeButton.SetActive(true);
            realButton.SetActive(false);
        }

        if (turnOffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }

    }


}
