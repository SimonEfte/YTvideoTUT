using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GOLDENFLIPS : MonoBehaviour
{
    public GameObject specialCoinFlipsButton;
    public GameObject fakeSpecialCoinFlipsButton;
    public TextMeshProUGUI buttonText;
    public TextMeshProUGUI fakeButtonText;
    public static float specialCoinsButtonCost = 2000;
    public static float currentCoins;
    public static bool turnOffButton = false;
    public TextMeshProUGUI specialCostText;
    public TextMeshProUGUI fakeSpecialCostText;
    public GameObject popUpInfoText;

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
        if (GlobalCoinMaker.coinsPerFlipUpgrades >= GoldenFlipsButton.goldenCoinsUpgradeCount) { popUpInfoText.SetActive(false); }
        currentCoins = GlobalCoins.CoinCount;
        fakeSpecialCostText.color = Color.red;
        specialCostText.color = Color.green;

        if(GlobalCoins.CoinCount > specialCoinsButtonCost)
        {
            fakeSpecialCostText.color = Color.green;
        }
        if (GlobalCoins.CoinCount < specialCoinsButtonCost)
        {
            fakeSpecialCostText.color = Color.red;
        }

        specialCostText.text = FormatCoins(specialCoinsButtonCost);
        fakeSpecialCostText.text = FormatCoins(specialCoinsButtonCost);

        if (MainButtonClick.numberOfDuplicationUpgrades < 20)
        {
            specialCoinFlipsButton.SetActive(false);
            fakeSpecialCoinFlipsButton.SetActive(true);
            buttonText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.upgradedFlipsName;
            fakeButtonText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.upgradedFlipsName;
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 20)
        {
            
            buttonText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.upgradedFlipsName;
            fakeButtonText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.upgradedFlipsName;
            if (currentCoins >= specialCoinsButtonCost)
            {
                specialCoinFlipsButton.SetActive(true);
                fakeSpecialCoinFlipsButton.SetActive(false);
            }
            if (currentCoins < specialCoinsButtonCost)
            {
                specialCoinFlipsButton.SetActive(false);
                fakeSpecialCoinFlipsButton.SetActive(true);
            }
            if (turnOffButton == true)
            {
                specialCoinFlipsButton.SetActive(true);
                fakeSpecialCoinFlipsButton.SetActive(false);
                turnOffButton = false;
            }

            if (GlobalCoinMaker.coinsPerFlipUpgrades == GoldenFlipsButton.goldenCoinsUpgradeCount)
            {
                popUpInfoText.SetActive(true);
                specialCoinFlipsButton.SetActive(false);
                fakeSpecialCoinFlipsButton.SetActive(true);
            }
            if(GlobalCoinMaker.coinsPerFlipUpgrades > GoldenFlipsButton.goldenCoinsUpgradeCount) { popUpInfoText.SetActive(false); }
        }

        if (GoldenFlipsButton.goldenCoinsUpgradeCount == 21)
        {
            specialCoinFlipsButton.SetActive(false);
            fakeSpecialCoinFlipsButton.SetActive(true);
            fakeSpecialCostText.color = Color.red;
            fakeSpecialCostText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.spendNoMore;


            buttonText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.maxedOut;
            fakeButtonText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.maxedOut;
            popUpInfoText.SetActive(false);
        }



    }



}
