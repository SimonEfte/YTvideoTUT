using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AscendCoins : MonoBehaviour
{
    public TextMeshProUGUI ascendCoinsText;
    public TextMeshProUGUI ascendCoinsTextNot21Flippers;
    public TextMeshProUGUI ascendCoinsTextClickedAscendButton;
    public TextMeshProUGUI ascendCoinsTextAscendScreen;

    public static int ascensionCoinAmount;
    public static int luckyAscendCoin;

    public static int millionGet = 1;
    public static int billionGet = 1;
    public static int trillionGet = 1;
    public static int quadrillionGet = 1;
    public static int quintillionGet = 1;
    public static int sextillionGet = 1;
    public static int septillionGet = 1;
    public static int octillionGet = 1;
    public static int nonillionGet = 1;
    public static int decillionGet = 1;
    public static int undecillionGet = 1;
    public static int extraAscendCoinsChance = 0;

    public static int gained1Mill = 1;
    public static int gained250Mill = 1;
    public static int gained500Mill = 1;
    public static int gained750Mill = 1;

    public static int gained1Billion = 1;
    public static int gained250Billion = 1;
    public static int gained500Billion = 1;
    public static int gained750Billion = 1;

    public static int gained1Trillion = 1;
    public static int gained250Trillion = 1;
    public static int gained500Trillion = 1;
    public static int gained750Trillion = 1;

    public static int gained1Quadrillion = 1;
    public static int gained250Quadrillion = 1;
    public static int gained500Quadrillion = 1;
    public static int gained750Quadrillion = 1;

    public static int gained1Quintillion = 1;
    public static int gained250Quintillion = 1;
    public static int gained500Quintillion = 1;
    public static int gained750Quintillion = 1;

    public static int gained1Sextillion = 1;
    public static int gained250Sextillion = 1;
    public static int gained500Sextillion = 1;
    public static int gained750Sextillion = 1;

    public static int gained1Septillion = 1;
    public static int gained250Septillion = 1;
    public static int gained500Septillion = 1;
    public static int gained750Septillion = 1;

    public static int gained1octillion = 1;
    public static int gained250octillion = 1;
    public static int gained500octillion = 1;
    public static int gained750octillion = 1;

    public static int gained1nonillion = 1;
    public static int gained250nonillion = 1;
    public static int gained500nonillion = 1;
    public static int gained750nonillion = 1;

    public static int gained1Decillion = 1;
    public static int gained250Decillion = 1;
    public static int gained500Decillion = 1;
    public static int gained750Decillion = 1;

    public static int gained1Undecillion = 1;
    public static int gained250Undecillion = 1;
    public static int gained500Undecillion = 1;
    public static int gained750Undecillion = 1;

    public float maxFloatNumber = 340282300000000000000000000000000000000f;

    public void Start()
    {
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        yield return new WaitForSeconds(0.1f);
    }


    public void Update()
    {
        //Million
        if (GlobalCoins.CoinCount >= 1000000f && gained1Mill == 1) { gained1Mill = 0; MillionTier(); }
        else if (GlobalCoins.CoinCount >= 250000000f && gained250Mill == 1) { gained250Mill = 0; MillionTier(); }
        else if (GlobalCoins.CoinCount >= 500000000f && gained500Mill == 1) { gained500Mill = 0; MillionTier(); }
        else if (GlobalCoins.CoinCount >= 750000000f && gained750Mill == 1) { gained750Mill = 0; MillionTier(); }

        //Billion
        else if (GlobalCoins.CoinCount >= 1000000000f && gained1Billion == 1) { gained1Billion = 0; BillionTier(); }
        else if (GlobalCoins.CoinCount >= 250000000000f && gained250Billion == 1) { gained250Billion = 0; BillionTier(); }
        else if (GlobalCoins.CoinCount >= 500000000000f && gained500Billion == 1) { gained500Billion = 0; BillionTier(); }
        else if (GlobalCoins.CoinCount >= 750000000000f && gained750Billion == 1) { gained750Billion = 0; BillionTier(); }

        //Trillion
        else if (GlobalCoins.CoinCount >= 1000000000000f && gained1Trillion == 1) { gained1Trillion = 0; TrillionTier(); }
        else if (GlobalCoins.CoinCount >= 250000000000000f && gained250Trillion == 1) { gained250Trillion = 0; TrillionTier(); }
        else if (GlobalCoins.CoinCount >= 500000000000000f && gained500Trillion == 1) { gained500Trillion = 0; TrillionTier(); }
        else if (GlobalCoins.CoinCount >= 750000000000000f && gained750Trillion == 1) { gained750Trillion = 0; TrillionTier(); }

        //Quadrillion
        else if (GlobalCoins.CoinCount >= 1000000000000000f && gained1Quadrillion == 1) { gained1Quadrillion = 0; QuadrillionTIER(); }
        else if (GlobalCoins.CoinCount >= 250000000000000000f && gained250Quadrillion == 1) { gained250Quadrillion = 0; QuadrillionTIER(); }
        else if (GlobalCoins.CoinCount >= 500000000000000000f && gained500Quadrillion == 1) { gained500Quadrillion = 0; QuadrillionTIER(); }
        else if (GlobalCoins.CoinCount >= 750000000000000000f && gained750Quadrillion == 1) { gained750Quadrillion = 0; QuadrillionTIER(); }

        //Quintillion
        else if (GlobalCoins.CoinCount >= 1000000000000000000f && gained1Quintillion == 1) { gained1Quintillion = 0; QuintillionGetTIER(); }
        else if (GlobalCoins.CoinCount >= 250000000000000000000f && gained250Quintillion == 1) { gained250Quintillion = 0; QuintillionGetTIER(); }
        else if (GlobalCoins.CoinCount >= 500000000000000000000f && gained500Quintillion == 1) { gained500Quintillion = 0; QuintillionGetTIER(); }
        else if (GlobalCoins.CoinCount >= 750000000000000000000f && gained750Quintillion == 1) { gained750Quintillion = 0; QuintillionGetTIER(); }

        //Sextillion
        else if (GlobalCoins.CoinCount >= 1000000000000000000000f && gained1Sextillion == 1) { gained1Sextillion = 0; SextillionTIER(); }
        else if (GlobalCoins.CoinCount >= 250000000000000000000000f && gained250Sextillion == 1) { gained250Sextillion = 0; SextillionTIER(); }
        else if (GlobalCoins.CoinCount >= 500000000000000000000000f && gained500Sextillion == 1) { gained500Sextillion = 0; SextillionTIER(); }
        else if (GlobalCoins.CoinCount >= 750000000000000000000000f && gained750Sextillion == 1) { gained750Sextillion = 0; SextillionTIER(); }

        //Septillion
        else if (GlobalCoins.CoinCount >= 1000000000000000000000000f && gained1Septillion == 1) { gained1Septillion = 0; SeptillionTIER(); }
        else if (GlobalCoins.CoinCount >= 250000000000000000000000000f && gained250Septillion == 1) { gained250Septillion = 0; SeptillionTIER(); }
        else if (GlobalCoins.CoinCount >= 500000000000000000000000000f && gained500Septillion == 1) { gained500Septillion = 0; SeptillionTIER(); }
        else if (GlobalCoins.CoinCount >= 750000000000000000000000000f && gained750Septillion == 1) { gained750Septillion = 0; SeptillionTIER(); }

        //Octillion
        else if (GlobalCoins.CoinCount >= 1000000000000000000000000000f && gained1octillion == 1) { gained1octillion = 0; OctillionTIER(); }
        else if (GlobalCoins.CoinCount >= 250000000000000000000000000000f && gained250octillion == 1) { gained250octillion = 0; OctillionTIER(); }
        else if (GlobalCoins.CoinCount >= 500000000000000000000000000000f && gained500octillion == 1) { gained500octillion = 0; OctillionTIER(); }
        else if (GlobalCoins.CoinCount >= 750000000000000000000000000000f && gained750octillion == 1) { gained750octillion = 0; OctillionTIER(); }

        //Nonillion
        else if (GlobalCoins.CoinCount >= 1000000000000000000000000000000f && gained1nonillion == 1) { gained1nonillion = 0; NonillionTIER(); }
        else if (GlobalCoins.CoinCount >= 250000000000000000000000000000000f && gained250nonillion == 1) { gained250nonillion = 0; NonillionTIER(); }
        else if (GlobalCoins.CoinCount >= 500000000000000000000000000000000f && gained500nonillion == 1) { gained500nonillion = 0; NonillionTIER(); }
        else if (GlobalCoins.CoinCount >= 750000000000000000000000000000000f && gained750nonillion == 1) { gained750nonillion = 0; NonillionTIER(); }

        //Decillion
        else if (GlobalCoins.CoinCount >= 1000000000000000000000000000000000f && gained1Decillion == 1) { gained1Decillion = 0; DecillionTIER(); }
        else if (GlobalCoins.CoinCount >= 250000000000000000000000000000000000f && gained250Decillion == 1) { gained250Decillion = 0; DecillionTIER(); }
        else if (GlobalCoins.CoinCount >= 500000000000000000000000000000000000f && gained500Decillion == 1) { gained500Decillion = 0; DecillionTIER(); }
        else if (GlobalCoins.CoinCount >= 750000000000000000000000000000000000f && gained750Decillion == 1) { gained750Decillion = 0; DecillionTIER(); }

        //Undecillion
        else if (GlobalCoins.CoinCount >= 1000000000000000000000000000000000000f && gained1Undecillion == 1) { gained1Undecillion = 0; UndecillionTIER(); }
        else if (GlobalCoins.CoinCount >= 250000000000000000000000000000000000000f && gained250Undecillion == 1) { gained250Undecillion = 0; UndecillionTIER(); }

        DisplayInflationCoins();

        if(ascensionCoinAmount < 0) { ascensionCoinAmount = 0; }
    }
    public AscendScreen ascendScreenScript;

    public void MillionTier()
    {
        int random = Random.Range(1, 101);
        if(random <= extraAscendCoinsChance)
        {
            if (Challenges.isChallenge4Active == 1) { return; }

            ascensionCoinAmount += millionGet;
            ascensionCoinAmount += 1;
            luckyAscendCoin += 1;
        }
        if(random > extraAscendCoinsChance)
        {
            if (Challenges.isChallenge4Active == 1) { return; }

            ascensionCoinAmount += millionGet;
        }
        ascendScreenScript.CheckInflationUpgradePriceColor();

        PlayerPrefs.SetInt("SavedGained1Mill", AscendCoins.gained1Mill);
        PlayerPrefs.SetInt("SavedGained250Mill", AscendCoins.gained250Mill);
        PlayerPrefs.SetInt("SavedGained500Mill", AscendCoins.gained500Mill);
        PlayerPrefs.SetInt("SavedGained750Mill", AscendCoins.gained750Mill);
    }

    public void BillionTier()
    {
        int random = Random.Range(1, 101);
        if (random <= extraAscendCoinsChance)
        {
            if (Challenges.isChallenge4Active == 1) { return; }

            ascensionCoinAmount += billionGet;
            ascensionCoinAmount += 1;
            luckyAscendCoin += 1;
        }
        if (random > extraAscendCoinsChance)
        {
            if (Challenges.isChallenge4Active == 1) { return; }

            ascensionCoinAmount += billionGet;
        }
        ascendScreenScript.CheckInflationUpgradePriceColor();

        PlayerPrefs.SetInt("SavedGained1Billion", AscendCoins.gained1Billion);
        PlayerPrefs.SetInt("SavedGained250Billion", AscendCoins.gained250Billion);
        PlayerPrefs.SetInt("SavedGained500Billion", AscendCoins.gained500Billion);
        PlayerPrefs.SetInt("SavedGained750Billion", AscendCoins.gained750Billion);
    }

    public void TrillionTier()
    {
        int random = Random.Range(1, 101);
        if (random <= extraAscendCoinsChance)
        {
            if (Challenges.isChallenge4Active == 1) { return; }

            ascensionCoinAmount += trillionGet;
            ascensionCoinAmount += 1;
            luckyAscendCoin += 1;
        }
        if (random > extraAscendCoinsChance)
        {
            if (Challenges.isChallenge4Active == 1) { return; }
            ascensionCoinAmount += trillionGet;
        }
        ascendScreenScript.CheckInflationUpgradePriceColor();

        PlayerPrefs.SetInt("SavedGained1Tillion", AscendCoins.gained1Trillion);
        PlayerPrefs.SetInt("SavedGained250Tillion", AscendCoins.gained250Trillion);
        PlayerPrefs.SetInt("SavedGained500Tillion", AscendCoins.gained500Trillion);
        PlayerPrefs.SetInt("SavedGained750Tillion", AscendCoins.gained750Trillion);
    }

    public void QuadrillionTIER()
    {
        int random = Random.Range(1, 101);
        if (random <= extraAscendCoinsChance)
        {
            if (Challenges.isChallenge4Active == 1) { return; }
            ascensionCoinAmount += quadrillionGet;
            ascensionCoinAmount += 1;
            luckyAscendCoin += 1;
        }
        if (random > extraAscendCoinsChance)
        {
            if (Challenges.isChallenge4Active == 1) { return; }
            ascensionCoinAmount += quadrillionGet;
        }
        ascendScreenScript.CheckInflationUpgradePriceColor();

        PlayerPrefs.SetInt("SavedGained1Quadrillion", AscendCoins.gained1Quadrillion);
        PlayerPrefs.SetInt("SavedGained250Quadrillion", AscendCoins.gained250Quadrillion);
        PlayerPrefs.SetInt("SavedGained500Quadrillion", AscendCoins.gained500Quadrillion);
        PlayerPrefs.SetInt("SavedGained750Quadrillion", AscendCoins.gained750Quadrillion);
    }

    public void QuintillionGetTIER()
    {
        int random = Random.Range(1, 101);
        if (random <= extraAscendCoinsChance)
        {
            if (Challenges.isChallenge4Active == 1) { return; }
            ascensionCoinAmount += quintillionGet;
            ascensionCoinAmount += 1;
            luckyAscendCoin += 1;
        }
        if (random > extraAscendCoinsChance)
        {
            if (Challenges.isChallenge4Active == 1) { return; }
            ascensionCoinAmount += quintillionGet;
        }
        ascendScreenScript.CheckInflationUpgradePriceColor();

        PlayerPrefs.SetInt("SavedGained1Quintillion", AscendCoins.gained1Quintillion);
        PlayerPrefs.SetInt("SavedGained250Quintillion", AscendCoins.gained250Quintillion);
        PlayerPrefs.SetInt("SavedGained500Quintillion", AscendCoins.gained500Quintillion);
        PlayerPrefs.SetInt("SavedGained750Quintillion", AscendCoins.gained750Quintillion);
    }

    public void SextillionTIER()
    {
        int random = Random.Range(1, 101);
        if (random <= extraAscendCoinsChance)
        {
            if (Challenges.isChallenge4Active == 1) { return; }
            ascensionCoinAmount += sextillionGet;
            ascensionCoinAmount += 1;
            luckyAscendCoin += 1;
        }
        if (random > extraAscendCoinsChance)
        {
            if (Challenges.isChallenge4Active == 1) { return; }
            ascensionCoinAmount += sextillionGet;
        }
        ascendScreenScript.CheckInflationUpgradePriceColor();

        PlayerPrefs.SetInt("SavedGained1Sextillion", AscendCoins.gained1Sextillion);
        PlayerPrefs.SetInt("SavedGained250Sextillion", AscendCoins.gained250Sextillion);
        PlayerPrefs.SetInt("SavedGained500Sextillion", AscendCoins.gained500Sextillion);
        PlayerPrefs.SetInt("SavedGained750Sextillion", AscendCoins.gained750Sextillion);
    }

    public void SeptillionTIER()
    {
        int random = Random.Range(1, 101);
        if (random <= extraAscendCoinsChance)
        {
            if (Challenges.isChallenge4Active == 1) { return; }
            ascensionCoinAmount += septillionGet;
            ascensionCoinAmount += 1;
            luckyAscendCoin += 1;
        }
        if (random > extraAscendCoinsChance)
        {
            if (Challenges.isChallenge4Active == 1) { return; }
            ascensionCoinAmount += septillionGet;
        }
        ascendScreenScript.CheckInflationUpgradePriceColor();

        PlayerPrefs.SetInt("SavedGained1Septillion", AscendCoins.gained1Septillion);
        PlayerPrefs.SetInt("SavedGained250Septillion", AscendCoins.gained250Septillion);
        PlayerPrefs.SetInt("SavedGained500Septillion", AscendCoins.gained500Septillion);
        PlayerPrefs.SetInt("SavedGained750Septillion", AscendCoins.gained750Septillion);
    }

    public void OctillionTIER()
    {
        int random = Random.Range(1, 101);
        if (random <= extraAscendCoinsChance)
        {
            if (Challenges.isChallenge4Active == 1) { return; }
            ascensionCoinAmount += octillionGet;
            ascensionCoinAmount += 1;
            luckyAscendCoin += 1;
        }
        if (random > extraAscendCoinsChance)
        {
            if (Challenges.isChallenge4Active == 1) { return; }
            ascensionCoinAmount += octillionGet;
        }
        ascendScreenScript.CheckInflationUpgradePriceColor();

        PlayerPrefs.SetInt("SavedGained1Octillion", AscendCoins.gained1octillion);
        PlayerPrefs.SetInt("SavedGained250Octillion", AscendCoins.gained250octillion);
        PlayerPrefs.SetInt("SavedGained500Octillion", AscendCoins.gained500octillion);
        PlayerPrefs.SetInt("SavedGained750Octillion", AscendCoins.gained750octillion);
    }

    public void NonillionTIER()
    {
        int random = Random.Range(1, 101);
        if (random <= extraAscendCoinsChance)
        {
            if (Challenges.isChallenge4Active == 1) { return; }
            ascensionCoinAmount += nonillionGet;
            ascensionCoinAmount += 1;
            luckyAscendCoin += 1;
        }
        if (random > extraAscendCoinsChance)
        {
            if (Challenges.isChallenge4Active == 1) { return; }
            ascensionCoinAmount += nonillionGet;
        }
        ascendScreenScript.CheckInflationUpgradePriceColor();

        PlayerPrefs.SetInt("SavedGained1nonillion", AscendCoins.gained1nonillion);
        PlayerPrefs.SetInt("SavedGained250nonillion", AscendCoins.gained250nonillion);
        PlayerPrefs.SetInt("SavedGained500nonillion", AscendCoins.gained500nonillion);
        PlayerPrefs.SetInt("SavedGained750nonillion", AscendCoins.gained750nonillion);
    }

    public void DecillionTIER()
    {
        int random = Random.Range(1, 101);
        if (random <= extraAscendCoinsChance)
        {
            if (Challenges.isChallenge4Active == 1) { return; }
            ascensionCoinAmount += decillionGet;
            ascensionCoinAmount += 1;
            luckyAscendCoin += 1;
        }
        if (random > extraAscendCoinsChance)
        {
            if (Challenges.isChallenge4Active == 1) { return; }
            ascensionCoinAmount += decillionGet;
        }
        ascendScreenScript.CheckInflationUpgradePriceColor();

        PlayerPrefs.SetInt("SavedGained1Decillion", AscendCoins.gained1Decillion);
        PlayerPrefs.SetInt("SavedGained250Decillion", AscendCoins.gained250Decillion);
        PlayerPrefs.SetInt("SavedGained500Decillion", AscendCoins.gained500Decillion);
        PlayerPrefs.SetInt("SavedGained750Decillion", AscendCoins.gained750Decillion);
    }

    public void UndecillionTIER()
    {
        int random = Random.Range(1, 101);
        if (random <= extraAscendCoinsChance)
        {
            if (Challenges.isChallenge4Active == 1) { return; }
            ascensionCoinAmount += undecillionGet;
            ascensionCoinAmount += 1;
            luckyAscendCoin += 1;
        }
        if (random > extraAscendCoinsChance)
        {
            if (Challenges.isChallenge4Active == 1) { return; }
            ascensionCoinAmount += undecillionGet;
        }
        ascendScreenScript.CheckInflationUpgradePriceColor();

        PlayerPrefs.SetInt("SavedGained1Undecillion", AscendCoins.gained1Undecillion);
        PlayerPrefs.SetInt("SavedGained250Undecillion", AscendCoins.gained250Undecillion);
        PlayerPrefs.SetInt("SavedGained500Undecillion", AscendCoins.gained500Undecillion);
        PlayerPrefs.SetInt("SavedGained750Undecillion", AscendCoins.gained750Undecillion);
    }

    public void DisplayInflationCoins()
    {
        ascendCoinsText.GetComponent<TextMeshProUGUI>().text = "" + ascensionCoinAmount;
        ascendCoinsTextAscendScreen.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + ascensionCoinAmount;
        ascendCoinsTextClickedAscendButton.GetComponent<TextMeshProUGUI>().text = "" + ascensionCoinAmount;
        ascendCoinsTextNot21Flippers.GetComponent<TextMeshProUGUI>().text = "" + ascensionCoinAmount;
    }
}
