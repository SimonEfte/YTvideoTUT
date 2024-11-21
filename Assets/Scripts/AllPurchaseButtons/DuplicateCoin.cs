using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DuplicateCoin : MonoBehaviour
{
    public GameObject realDuplicateButton;
    public GameObject fakeDuplicateButton;
    public TextMeshProUGUI realDuplicateButtonText;
    public TextMeshProUGUI fakeDuplicateButtonText;
    public TextMeshProUGUI duplicateName;
    public TextMeshProUGUI fakeDuplicateName;
    public static float currentCoins;
    public static float duplicatePrice = 75;
    public static bool turnOffDuplicateButton = false;

    public static string FormatCoins(float coins)
    {
        return coins switch
        {
            >= 1E+36f => ((float)coins / 1E+36).ToString("0.##") + LocalizationStrings.undecillion + LocalizationStrings.coins,
            >= 1E+33f => ((float)coins / 1E+33).ToString("0.##") + LocalizationStrings.decillion + LocalizationStrings.coins,
            >= 1E+30f => ((float)coins / 1E+30).ToString("0.##") + LocalizationStrings.nonillion + LocalizationStrings.coins,
            >= 1E+27f => ((float)coins / 1E+27).ToString("0.##") + LocalizationStrings.octillion + LocalizationStrings.coins,
            >= 1E+24f => ((float)coins / 1E+24).ToString("0.##") + LocalizationStrings.septillion + LocalizationStrings.coins,
            >= 1E+21f => ((float)coins / 1E+21).ToString("0.##") + LocalizationStrings.sextillion + LocalizationStrings.coins,
            >= 1E+18f => ((float)coins / 1E+18).ToString("0.##") + LocalizationStrings.quintillion + LocalizationStrings.coins,
            >= 1E+15f => ((float)coins / 1E+15).ToString("0.##") + LocalizationStrings.quadrillion + LocalizationStrings.coins,
            >= 1E+12f => ((float)coins / 1000000000000.0).ToString("0.##") + LocalizationStrings.trillion + LocalizationStrings.coins,
            >= 1E+09f => ((float)coins / 1000000000.0).ToString("0.##") + LocalizationStrings.billion + LocalizationStrings.coins,
            >= 1000000f => ((float)coins / 1000000.0).ToString("0.##") + LocalizationStrings.million + LocalizationStrings.coins,
            >= 1000f => ((float)coins / 1000.0).ToString("0.##") + LocalizationStrings.thousand + LocalizationStrings.coins,
            _=> ((float)coins / 1.0).ToString("##") + LocalizationStrings.coins
        };
    }

    private void Update()
    {
        currentCoins = GlobalCoins.CoinCount;

        fakeDuplicateButtonText.color = Color.red;
        realDuplicateButtonText.color = Color.green;

        realDuplicateButtonText.text = FormatCoins(duplicatePrice);
        fakeDuplicateButtonText.text = FormatCoins(duplicatePrice);

        duplicateName.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.flipMoreCoinsName;
        fakeDuplicateName.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.flipMoreCoinsName;

        if (MainButtonClick.numberOfDuplicationUpgrades == 20)
        {
            duplicateName.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.maxedOut;
            fakeDuplicateName.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.maxedOut;
            realDuplicateButtonText.color = Color.red;
            realDuplicateButtonText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.spendNoMore;
            fakeDuplicateButtonText.color = Color.red;
            fakeDuplicateButtonText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.spendNoMore;
            realDuplicateButton.SetActive(false);
            fakeDuplicateButton.SetActive(true);
        }
        else
        {
            if (currentCoins >= duplicatePrice)
            {
                fakeDuplicateButton.SetActive(false);
                realDuplicateButton.SetActive(true);
            }

            if (currentCoins < duplicatePrice)
            {
                fakeDuplicateButton.SetActive(true);
                realDuplicateButton.SetActive(false);
            }

            if (turnOffDuplicateButton == true)
            {
                realDuplicateButton.SetActive(false);
                fakeDuplicateButton.SetActive(true);
                turnOffDuplicateButton = false;
            }
        }
       
    }

}
