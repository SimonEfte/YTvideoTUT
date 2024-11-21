using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoreCoinsButton : MonoBehaviour
{
    //Stronger Hands Upgrade
    public GameObject realStrongerHands;
    public GameObject fakeStrongerHandsButton;
    public TextMeshProUGUI strongerHandsCostText;
    public TextMeshProUGUI fakeStrongerHandsCostText;
    public static float currentCoins2;
    public static float moreCoinClickValue = 5;
    public static bool turnOffMoreCoinClickValueButton = false;

    public GameObject coinButtonStats1;
    public static int moreCoinsUpgrades =0;

    //Greater Coins Upgrade
    public GameObject greaterCoins;
    public GameObject fakeGreaterCoins;
    public TextMeshProUGUI fakeStrongerArmsName;
    public TextMeshProUGUI greaterCoinsCostText;
    public TextMeshProUGUI fakeGreaterCoinCostText;
    public TextMeshProUGUI fakeGreaterCoinCostName;
    //public TextMeshProUGUI greaterCoinsPluss;
    //public TextMeshProUGUI fakeGreaterCoinsPluss;
    public static float greaterCoinsCost = 115;
    public static bool turnOffGraterCoinsUpgrade = false;
    public static int greaterCoinsCount;
    public GameObject questionMark;
    public GameObject buttonIcon;

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

    public static string FormatCoinsOnHeads(float coins)
    {
        return coins switch
        {
            >= 1E+36f => ((float)coins / 1E+36).ToString("0.##") + LocalizationStrings.undecillion + LocalizationStrings.coinsOnHeads,
            >= 1E+33f => ((float)coins / 1E+33).ToString("0.##") + LocalizationStrings.decillion + LocalizationStrings.coinsOnHeads,
            >= 1E+30f => ((float)coins / 1E+30).ToString("0.##") + LocalizationStrings.nonillion + LocalizationStrings.coinsOnHeads,
            >= 1E+27f => ((float)coins / 1E+27).ToString("0.##") + LocalizationStrings.octillion + LocalizationStrings.coinsOnHeads,
            >= 1E+24f => ((float)coins / 1E+24).ToString("0.##") + LocalizationStrings.septillion + LocalizationStrings.coinsOnHeads,
            >= 1E+21f => ((float)coins / 1E+21).ToString("0.##") + LocalizationStrings.sextillion + LocalizationStrings.coinsOnHeads,
            >= 1E+18f => ((float)coins / 1E+18).ToString("0.##") + LocalizationStrings.quintillion + LocalizationStrings.coinsOnHeads,
            >= 1E+15f => ((float)coins / 1E+15).ToString("0.##") + LocalizationStrings.quadrillion + LocalizationStrings.coinsOnHeads,
            >= 1E+12f => ((float)coins / 1000000000000.0).ToString("0.##") + LocalizationStrings.trillion + LocalizationStrings.coinsOnHeads,
            >= 1E+09f => ((float)coins / 1000000000.0).ToString("0.##") + LocalizationStrings.billion + LocalizationStrings.coinsOnHeads,
            >= 1000000f => ((float)coins / 1000000.0).ToString("0.##") + LocalizationStrings.million + LocalizationStrings.coinsOnHeads,
            >= 1000f => ((float)coins / 1000.0).ToString("0.##") + LocalizationStrings.thousand + LocalizationStrings.coinsOnHeads,
            _ => ((float)coins / 1.0).ToString("##") + LocalizationStrings.coinsOnHeads
        };
    }

    public static string FormatCoinsOnTails(float coins)
    {
        return coins switch
        {
            >= 1E+36f => ((float)coins / 1E+36).ToString("0.##") + LocalizationStrings.undecillion + LocalizationStrings.coinsOnTails,
            >= 1E+33f => ((float)coins / 1E+33).ToString("0.##") + LocalizationStrings.decillion + LocalizationStrings.coinsOnTails,
            >= 1E+30f => ((float)coins / 1E+30).ToString("0.##") + LocalizationStrings.nonillion + LocalizationStrings.coinsOnTails,
            >= 1E+27f => ((float)coins / 1E+27).ToString("0.##") + LocalizationStrings.octillion + LocalizationStrings.coinsOnTails,
            >= 1E+24f => ((float)coins / 1E+24).ToString("0.##") + LocalizationStrings.septillion + LocalizationStrings.coinsOnTails,
            >= 1E+21f => ((float)coins / 1E+21).ToString("0.##") + LocalizationStrings.sextillion + LocalizationStrings.coinsOnTails,
            >= 1E+18f => ((float)coins / 1E+18).ToString("0.##") + LocalizationStrings.quintillion + LocalizationStrings.coinsOnTails,
            >= 1E+15f => ((float)coins / 1E+15).ToString("0.##") + LocalizationStrings.quadrillion + LocalizationStrings.coinsOnTails,
            >= 1E+12f => ((float)coins / 1000000000000.0).ToString("0.##") + LocalizationStrings.trillion + LocalizationStrings.coinsOnTails,
            >= 1E+09f => ((float)coins / 1000000000.0).ToString("0.##") + LocalizationStrings.billion + LocalizationStrings.coinsOnTails,
            >= 1000000f => ((float)coins / 1000000.0).ToString("0.##") + LocalizationStrings.million + LocalizationStrings.coinsOnTails,
            >= 1000f => ((float)coins / 1000.0).ToString("0.##") + LocalizationStrings.thousand + LocalizationStrings.coinsOnTails,
            _ => ((float)coins / 1.0).ToString("##") + LocalizationStrings.coinsOnTails
        };
    }

    void Update()
    {
        fakeStrongerArmsName.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.strongerArmName;
        currentCoins2 = GlobalCoins.CoinCount;
        //All text info for Stronger Hands Upgrade
        if (EnterText.choseHeads == 1)
        {
            if (LocalizationStrings.ChooseText == 1 || LocalizationStrings.ChooseText == 2 || LocalizationStrings.ChooseText == 3 || LocalizationStrings.ChooseText == 4)
            {
                coinButtonStats1.GetComponent<Text>().text = FormatCoinsOnHeads(MainButtonClick.coinsPerClick);
            }
                
            if(LocalizationStrings.ChooseText == 5)
            {
                coinButtonStats1.GetComponent<Text>().text = FormatCoinsOnHeads(MainButtonClick.coinsPerClick);
            }
          
           

        }
        if(EnterText.choseTails == 1)
        {
            coinButtonStats1.GetComponent<Text>().text = FormatCoinsOnTails(MainButtonClick.coinsPerClick);
          
        }
        

        //All text info for StringerHands
        //greaterCoinsPluss.GetComponent<TextMeshProUGUI>().text = " +15 Coins";
        //fakeGreaterCoinsPluss.GetComponent<TextMeshProUGUI>().text = " +15 Coins";
        fakeGreaterCoinCostText.GetComponent<TextMeshProUGUI>().text = "" + greaterCoinsCost + "";

        if (currentCoins2 >= moreCoinClickValue)
        {
            fakeStrongerHandsButton.SetActive(false);
            realStrongerHands.SetActive(true);
            strongerHandsCostText.color = Color.green;

            strongerHandsCostText.text = FormatCoins(moreCoinClickValue);

        }

       

        if (currentCoins2 < moreCoinClickValue)
        {
            fakeStrongerHandsButton.SetActive(true);
            realStrongerHands.SetActive(false);
            fakeStrongerHandsCostText.color = Color.red;

            

            fakeStrongerHandsCostText.text = FormatCoins(moreCoinClickValue);
        }

        if (turnOffMoreCoinClickValueButton == true)
        {
            fakeStrongerHandsButton.SetActive(true);
            realStrongerHands.SetActive(false);
            turnOffMoreCoinClickValueButton = false;
        }


        //Grater Coins
        if (moreCoinsUpgrades == 0)
        {
            questionMark.SetActive(true);
            buttonIcon.SetActive(false);
            fakeGreaterCoins.SetActive(true);
            greaterCoins.SetActive(false);
            fakeGreaterCoinCostText.color = Color.white;
            fakeGreaterCoinCostName.color = Color.white;
            fakeGreaterCoinCostText.GetComponent<TextMeshProUGUI>().text = "???";
            fakeGreaterCoinCostName.GetComponent<TextMeshProUGUI>().text = "????? ?????";

        }
        if(moreCoinsUpgrades > 0)
        {
            buttonIcon.SetActive(true);
            questionMark.SetActive(false);
            greaterCoinsCostText.color = Color.green;
            fakeGreaterCoinCostText.color = Color.red;
            fakeGreaterCoinCostName.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.greaterCoinName;

            greaterCoinsCostText.text = FormatCoins(greaterCoinsCost);
            fakeGreaterCoinCostText.text = FormatCoins(greaterCoinsCost);

            
            if (currentCoins2 >= greaterCoinsCost)
            {
                greaterCoins.SetActive(true);
                fakeGreaterCoins.SetActive(false);
            }

            if (currentCoins2 < greaterCoinsCost)
            {
                greaterCoins.SetActive(false);
                fakeGreaterCoins.SetActive(true);

            }

            if (turnOffGraterCoinsUpgrade == true)
            {
                greaterCoins.SetActive(false);
                fakeGreaterCoins.SetActive(true);
                turnOffGraterCoinsUpgrade = false;
            }


        }
        
    }

}
