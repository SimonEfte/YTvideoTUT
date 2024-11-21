using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PileOfCoins : MonoBehaviour
{
    public GameObject realPile;
    public GameObject fakePile;
    public static float currentCoins;
    public static float pileOfCoinsCost = 750;
    public static bool turnOfPileOfCoins = false;
    public TextMeshProUGUI pileName;
    public TextMeshProUGUI fakePileName;
    public TextMeshProUGUI pileCost;
    public TextMeshProUGUI fakePileCost;

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
        if (PurchaseLog.pileOfCoinsCount == 55)
        {
            realPile.SetActive(false);
            fakePile.SetActive(true);
            fakePileName.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.maxedOut;
            fakePileCost.color = Color.red;
            fakePileCost.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.spendNoMore;
        }
        else
        {
            pileName.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.pileOfCoinsName;
            fakePileName.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.pileOfCoinsName;

            pileCost.color = Color.green;
            fakePileCost.color = Color.red;

            pileCost.text = FormatCoins(pileOfCoinsCost);
            fakePileCost.text = FormatCoins(pileOfCoinsCost);



            if (currentCoins >= pileOfCoinsCost)
            {
                realPile.SetActive(true);
                fakePile.SetActive(false);
            }
            if (currentCoins < pileOfCoinsCost)
            {
                realPile.SetActive(false);
                fakePile.SetActive(true);
            }
            if (turnOfPileOfCoins == true)
            {
                realPile.SetActive(true);
                fakePile.SetActive(false);
                turnOfPileOfCoins = false;
            }
        }


    }
}
