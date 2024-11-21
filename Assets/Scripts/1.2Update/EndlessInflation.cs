using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndlessInflation : MonoBehaviour
{
    public GameObject realInflation;
    public GameObject fakeInflation;
    public TextMeshProUGUI inflationCostText;
    public TextMeshProUGUI fakeInflationCostText;
    public static int inflationUpgadeCount;
    public static int endlessInflationPrice;
    public static float endlessInflationBonus;
    public static int englessInflationBonusText;
    public TextMeshProUGUI hoverEndlessPricE;
    public TextMeshProUGUI endlessInflationInfoText;
    public static float endlessInflationCostEqualsBonus;
    public TextMeshProUGUI endlessCountText;
    public TextMeshProUGUI percentBonusText;

    public TextMeshProUGUI ascendScreenText;
    public TextMeshProUGUI not21FlipperText;
    public TextMeshProUGUI a21FlipperText;
    public TextMeshProUGUI clickedAscendText;

    public void Start()
    {
        StartCoroutine(setText());
    }

    public AudioSource UpgradeSound1;
    public AudioSource UpgradeSound2;

    public void BuyEndlessInflation()
    {

        int generateRandomUpgradeSound = Random.Range(1, 3);
        if (generateRandomUpgradeSound == 1)
        {
            UpgradeSound1.Play();
        }
        else if (generateRandomUpgradeSound == 2)
        {
            UpgradeSound2.Play();
        }

        inflationUpgadeCount += 1;
        endlessInflationCostEqualsBonus += 0.01f;
        englessInflationBonusText += endlessInflationPrice;
        AscendCoins.ascensionCoinAmount -= endlessInflationPrice;
        endlessInflationPrice += 1;
        endlessInflationBonus += endlessInflationCostEqualsBonus;

        inflationCostText.text = "" + endlessInflationPrice;
        fakeInflationCostText.text = "" + endlessInflationPrice;
        hoverEndlessPricE.text = endlessInflationPrice + LocalizationStrings.endlessInflationCost;

        endlessInflationInfoText.text = LocalizationStrings.inflateEndlessStats + englessInflationBonusText + LocalizationStrings.moreCoins;
        
        endlessCountText.text = "" + inflationUpgadeCount;
        percentBonusText.text = "+" + endlessInflationPrice + LocalizationStrings.endlessInflationPercentString;

        
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;

    }

    IEnumerator setText()
    {
        yield return new WaitForSeconds(0.1f);
        inflationCostText.text = "" + endlessInflationPrice;
        fakeInflationCostText.text = "" + endlessInflationPrice;
        hoverEndlessPricE.text = endlessInflationPrice + LocalizationStrings.endlessInflationCost;
        endlessInflationInfoText.text = LocalizationStrings.inflateEndlessStats + englessInflationBonusText + LocalizationStrings.moreCoins;
        endlessCountText.text = "" + inflationUpgadeCount;
        percentBonusText.text = "+" + endlessInflationPrice + LocalizationStrings.endlessInflationPercentString;

        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
    }

    public void Update()
    {
        if(AscendCoins.ascensionCoinAmount >= endlessInflationPrice)
        {
            realInflation.SetActive(true);
            fakeInflation.SetActive(false);
            inflationCostText.color = Color.green;
            hoverEndlessPricE.color = Color.green;
        }
        else if (AscendCoins.ascensionCoinAmount < endlessInflationPrice)
        {
            realInflation.SetActive(false);
            fakeInflation.SetActive(true);
            fakeInflationCostText.color = Color.red;
            hoverEndlessPricE.color = Color.red;
        }
    }
}
