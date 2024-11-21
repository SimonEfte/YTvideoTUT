using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HigherChance : MonoBehaviour
{
    public GameObject higherChanceButton;
    public GameObject fakeHigherChanceButton;
    public static float currentCoins;
    public static float higherChanceValue = 750;
    public static bool turnOffButton = false;
    public TextMeshProUGUI higherChangeName;
    public TextMeshProUGUI fakeHigherChangeName;
    public TextMeshProUGUI higherChanceCost;
    public TextMeshProUGUI fakeHigherChanceCost;
    public TextMeshProUGUI higherChangeCount;
    public TextMeshProUGUI chanceInfoHeads;
    public TextMeshProUGUI chanceInfoTails;
    public TextMeshProUGUI textPrice;

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

    //34 Max

    public void Update()
    {

        higherChangeCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + PurchaseLog.higherChanceUpgradeCount;

        if (EnterText.choseHeads == 1)
        {
            chanceInfoHeads.GetComponent<TextMeshProUGUI>().text = higherChanceHoverover.headsPercent + LocalizationStrings.higherChanceHeads;
            chanceInfoTails.GetComponent<TextMeshProUGUI>().text = higherChanceHoverover.tailsPercent + LocalizationStrings.higherChanceTails;
        }
        if (EnterText.choseTails == 1)
        {
            chanceInfoTails.GetComponent<TextMeshProUGUI>().text = higherChanceHoverover.tailsPercent + LocalizationStrings.higherChanceTails;
            chanceInfoHeads.GetComponent<TextMeshProUGUI>().text = higherChanceHoverover.headsPercent + LocalizationStrings.higherChanceHeads;
        }


        currentCoins = GlobalCoins.CoinCount;

        higherChangeName.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.higherChanceName;
        fakeHigherChangeName.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.higherChanceName;

        higherChanceCost.color = Color.green;
        fakeHigherChanceCost.color = Color.red;

        higherChanceCost.text = FormatCoins(higherChanceValue);
        fakeHigherChanceCost.text = FormatCoins(higherChanceValue);

       


        if (currentCoins >= higherChanceValue)
        {
            higherChanceButton.SetActive(true);
            fakeHigherChanceButton.SetActive(false);
        }
        if (currentCoins < higherChanceValue)
        {
            higherChanceButton.SetActive(false);
            fakeHigherChanceButton.SetActive(true);
        }
        if (turnOffButton == true)
        {
            higherChanceButton.SetActive(true);
            fakeHigherChanceButton.SetActive(false);
            turnOffButton = false;
        }

        if (PurchaseLog.higherChanceUpgradeCount == 44 && Challenges.completedChallenge4 == 0)
        {
            textPrice.color = Color.red;
            textPrice.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.spendNoMore;
            higherChanceButton.SetActive(false);
            fakeHigherChanceButton.SetActive(true);
            fakeHigherChangeName.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.maxedOut;
            fakeHigherChanceCost.color = Color.red;
            fakeHigherChanceCost.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.spendNoMore;
        }
        if (PurchaseLog.higherChanceUpgradeCount == 34 && Challenges.completedChallenge4 == 1)
        {
            textPrice.color = Color.red;
            textPrice.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.spendNoMore;
            higherChanceButton.SetActive(false);
            fakeHigherChanceButton.SetActive(true);
            fakeHigherChangeName.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.maxedOut;
            fakeHigherChanceCost.color = Color.red;
            fakeHigherChanceCost.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.spendNoMore;
        }
        
        
    }


}
