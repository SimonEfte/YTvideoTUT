using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LuckyCoinChance : MonoBehaviour
{
    public GameObject luckyCoinButton;
    public GameObject fakeLuckyCoinButton;
    public static float currentCoins;
    public static float luckyCoinValue = 1950;
    public static bool turnOffButton = false;
    public TextMeshProUGUI luckyPrice;
    public TextMeshProUGUI fakeLuckyPrice;
    public TextMeshProUGUI buyMaxText;
    public TextMeshProUGUI hoverPriceText;
    public TextMeshProUGUI luckyCoinCount;
    public TextMeshProUGUI luckyChanceInfo;

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

        luckyCoinCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + PurchaseLog.luckyCoinHigherChanceCount;
        luckyChanceInfo.GetComponent<TextMeshProUGUI>().text = GetLuckyHoverOver.luckyChance + LocalizationStrings.luckyCoinChance;

        currentCoins = GlobalCoins.CoinCount;

        luckyPrice.color = Color.green;
        fakeLuckyPrice.color = Color.red;

        luckyPrice.text = FormatCoins(luckyCoinValue);
        fakeLuckyPrice.text = FormatCoins(luckyCoinValue);

        
            buyMaxText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.getLuckyName;
            if (currentCoins >= luckyCoinValue)
            {
                luckyCoinButton.SetActive(true);
                fakeLuckyCoinButton.SetActive(false);
            }
            if (currentCoins < luckyCoinValue)
            {
                luckyCoinButton.SetActive(false);
                fakeLuckyCoinButton.SetActive(true);
            }
            if (turnOffButton == true)
            {
                luckyCoinButton.SetActive(true);
                fakeLuckyCoinButton.SetActive(false);
                turnOffButton = false;
            }


        if (Challenges.completedChallenge4 == 0)
        {
            if (PurchaseLog.luckyCoinHigherChanceCount == 9)
            {
                hoverPriceText.color = Color.red;
                hoverPriceText.text = LocalizationStrings.spendNoMore;
                buyMaxText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.maxedOut;
                fakeLuckyCoinButton.SetActive(true);
                luckyCoinButton.SetActive(false);
                fakeLuckyPrice.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.spendNoMore;
            }
        }

        if (Challenges.completedChallenge4 == 1)
        {
            if (PurchaseLog.luckyCoinHigherChanceCount == 29)
            {
                hoverPriceText.color = Color.red;
                hoverPriceText.text = LocalizationStrings.maxedOut;
                buyMaxText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.maxedOut;
                fakeLuckyCoinButton.SetActive(true);
                luckyCoinButton.SetActive(false);
                fakeLuckyPrice.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.spendNoMore;
            }
        }
    }
}
