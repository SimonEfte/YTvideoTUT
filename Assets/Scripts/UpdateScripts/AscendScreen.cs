using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AscendScreen : MonoBehaviour
{
    public static float startWithCoins;
    public static float coinMulitplier = 0;
    public static float cheaperPrice = 1;
    public static float specialUpgradeCheaperPrice = 1;
    public static int luckyCoinMiltiplier = 0;
    public static float activeFlipperMiltiplier =1;
    public static int ascendUpgradeAmount;

    public GameObject lockedUpgrade1;
    public GameObject lockedUpgrade2;
    public GameObject lockedUpgrade3;
    public GameObject lockedUpgrade4;
    public GameObject lockedUpgrade5;
    public GameObject lockedUpgrade6;
    public GameObject lockedUpgrade7;
    public GameObject lockedUpgrade8;
    public GameObject lockedUpgrade9;
    public GameObject lockedUpgrade10SUPER;
    public GameObject lockedUpgrade11;
    public GameObject lockedUpgrade12;
    public GameObject lockedUpgrade13;
    public GameObject lockedUpgrade14SUPER;
    public GameObject lockedUpgrade15;
    public GameObject lockedUpgrade16;
    public GameObject lockedUpgrade17;
    public GameObject lockedUpgrade18SUPER;
    public GameObject lockedUpgrade19;
    public GameObject lockedUpgrade20;
    public GameObject lockedUpgrade21;
    public GameObject lockedUpgrade22;
    public GameObject lockedUpgrade23;
    public GameObject lockedUpgrade24;
    public GameObject lockedUpgrade25;
    public GameObject lockedUpgrade26;
    public GameObject lockedUpgrade27SUPER;
    public GameObject lockedUpgrade27;
    public GameObject lockedUpgrade28;
    public GameObject lockedUpgrade29;
    public GameObject lockedUpgrade30;
    public GameObject lockedUpgrade31;
    public GameObject lockedUpgrade32;
  
    public GameObject lockedUpgradeSpecialSUPER;
    public GameObject lockedUpgrade34;
    public GameObject lockedUpgrade35;
    public GameObject lockedUpgrade36;
    public GameObject lockedUpgrade37;
    public GameObject lockedUpgrade38SUPER;

    public GameObject lockedAutoUpgrade;
    public GameObject lockedRich8Omega;
    public GameObject lockedPile2;
    public GameObject lockedBagPile;

    //RICH
    public GameObject unlockedOnePercent;
    public GameObject unlockedFivePercent;
    public GameObject unlockedTenPercent;
    public GameObject unlockIVUpgrade;
    public GameObject unlockVUpgrade;
    public GameObject unlockVIUpgrade;
    public GameObject unlockOmegaRich;
    public GameObject unlockOmegaRich1250;

    public GameObject RICHIunlocked;
    public GameObject RICHIIunlocked;
    public GameObject RICHIIIunlocked;
    public GameObject RICHIVunlocked;
    public GameObject RICHVunlocked;
    public GameObject RICHVIunlocked;
    public GameObject OMEGARichUnlocked;
    public GameObject OMEGAR1250ichUnlocked;
    //SALE

    public GameObject unlockedSaleI;
    public GameObject unlockedSaleII;
    public GameObject unlockedSaleIII;
    public GameObject unlockedSaleIV;
    public GameObject unlockedSaleV;

    public GameObject SALE1Unlocked;
    public GameObject SALE2Unlocked;
    public GameObject SALE3Unlocked;
    public GameObject SALE4Unlocked;
    public GameObject SALE5Unlocked;

    //Start

    public GameObject unlockedBagOfCoinsI;
    public GameObject unlockedBagOfCoinsII;
    public GameObject unlockedBagOfCoinsIII;
    public GameObject unlockedBagOfCoinsIV;
    public GameObject unlockedBagOfCoinsV;
    public GameObject unlockedPileBag;

    public GameObject BagUnlockedI;
    public GameObject BagUnlockedII;
    public GameObject BagUnlockedIII;
    public GameObject BagUnlockedIV;
    public GameObject BagUnlockedV;
    public GameObject PileBagUnlocked;

    //Ascend

    public GameObject unlockedAscendI;
    public GameObject unlockedAscendII;
    public GameObject unlockedAscendIII;
    public GameObject unlockedAscendIV;
    public GameObject unlockedAscendV;
    public GameObject unlockedAscendSUPER;

    public GameObject unlockedAscendPercent1;
    public GameObject unlockedAscendPercent2;
    public GameObject unlockedAscendPercent3;
    public GameObject unlockedAscendPercent4;

    public GameObject ascendUnlocked1;
    public GameObject ascendUnlocked2;
    public GameObject ascendUnlocked3;
    public GameObject ascendUnlocked4;
    public GameObject ascendUnlocked5;
    public GameObject ascendUnlocked6;
    public GameObject ascendUnlocked7;
    public GameObject ascendUnlocked8;
    public GameObject ascendUnlocked9;
    public GameObject ascendUnlocked10;

    //Special

    public GameObject unlockedSpecial1;
    public GameObject unlockedSpecial2;
    public GameObject unlockedSpecial3;
    public GameObject unlockedSpecial4;
    public GameObject unlockedSpecial5;
    public GameObject unlockedSpecial6;
    public GameObject unlockedSpecial7;
    public GameObject unlockedSpecial8;
    public GameObject unlockedSpecialPile2;
    public GameObject unlockedAuto;

    public GameObject specialUnlocked1;
    public GameObject specialUnlocked2;
    public GameObject specialUnlocked3;
    public GameObject specialUnlocked4;
    public GameObject specialUnlocked5;
    public GameObject specialUnlocked6;
    public GameObject specialUnlocked7;
    public GameObject specialUnlocked8;
    public GameObject specialPile2Unlocked;
    public GameObject autoUnlocked;

    //Active Flipper

    public GameObject unlockedActiveFlipper1;
    public GameObject unlockedActiveFlipper2;
    public GameObject unlockedActiveFlipper3;
    public GameObject unlockedActiveFlipper4;
    public GameObject unlockedActiveFlipper5;
    public GameObject unlockedflipperPileOfCoins;

    public GameObject activeUnlocked1;
    public GameObject activeUnlocked2;
    public GameObject activeUnlocked3;
    public GameObject activeUnlocked4;
    public GameObject activeUnlocked5;
    public GameObject activePileOfCoinsUnlocked;

    //PriceOfUpgrades

    public TextMeshProUGUI rich1Price;
    public TextMeshProUGUI rich2Price;
    public TextMeshProUGUI rich3Price;
    public TextMeshProUGUI rich4Price;
    public TextMeshProUGUI rich5Price;
    public TextMeshProUGUI rich6Price;
    public TextMeshProUGUI richSUPERPrice;
    public TextMeshProUGUI rich1250Price;

    public TextMeshProUGUI sale1Price;
    public TextMeshProUGUI sale2Price;
    public TextMeshProUGUI sale3Price;
    public TextMeshProUGUI sale4Price;
    public TextMeshProUGUI steamSale1Price;

    public TextMeshProUGUI active1Price;
    public TextMeshProUGUI active2Price;
    public TextMeshProUGUI active3Price;
    public TextMeshProUGUI active4Price;
    public TextMeshProUGUI activeSUPERPrice;
    public TextMeshProUGUI activePilePrice;

    public TextMeshProUGUI bagOfCoins1Price;
    public TextMeshProUGUI bagOfCoins2Price;
    public TextMeshProUGUI bagOfCoins3Price;
    public TextMeshProUGUI bagOfCoins4Price;
    public TextMeshProUGUI bagOfCoinsSUPERPrice;
    public TextMeshProUGUI pileBagCost;

    public TextMeshProUGUI special1Cost;
    public TextMeshProUGUI special2Cost;
    public TextMeshProUGUI special3Cost;
    public TextMeshProUGUI special4Cost;
    public TextMeshProUGUI specialSUPERCost;
    public TextMeshProUGUI biggerPileOfCoinsCost;
    public TextMeshProUGUI biggerPil2eOfCoinsCost;
    public TextMeshProUGUI gamblerCost;
    public TextMeshProUGUI getLuckerCost;
    public TextMeshProUGUI autoCost;


    public TextMeshProUGUI greaterAscension1Cost;
    public TextMeshProUGUI greaterAscension2Cost;
    public TextMeshProUGUI greaterAscension3Cost;
    public TextMeshProUGUI greaterAscension4Cost;
    public TextMeshProUGUI greaterAscension5Cost;
    public TextMeshProUGUI greaterAscensionSPECIALCost;
    public TextMeshProUGUI ascensionGamble1Cost;
    public TextMeshProUGUI ascensionGamble2Cost;
    public TextMeshProUGUI ascensionGamble3Cost;
    public TextMeshProUGUI ascensionGamble4Cost;

    public GameObject blockRich1;
    public GameObject blockRich2;
    public GameObject blockRich3;
    public GameObject blockRich4;
    public GameObject blockRich5;
    public GameObject blockRich6;
    public GameObject blockRichSuper;
    public GameObject blockRich1250;

    public GameObject blockSale1;
    public GameObject blockSale2;
    public GameObject blockSale3;
    public GameObject blockSale4;
    public GameObject blockSteamSale;

    public GameObject blockActive1;
    public GameObject blockActive2;
    public GameObject blockActive3;
    public GameObject blockActive4;
    public GameObject blockActiveSuper;
    public GameObject blockActivePile;

    public GameObject blockBag1;
    public GameObject blockBag2;
    public GameObject blockBag3;
    public GameObject blockBag4;
    public GameObject blockBagSuper;
    public GameObject blockPileBag;

    public GameObject blockSpecial1;
    public GameObject blockSpecial2;
    public GameObject blockSpecial3;
    public GameObject blockSpecialSuper;
    public GameObject blockSpecialGamle;
    public GameObject blockSpecialPile;
    public GameObject blockSpecialPile2;
    public GameObject blockSpecialLuckier;
    public GameObject blockAuto;

    public GameObject blockAscend1;
    public GameObject blockAscend2;
    public GameObject blockAscend3;
    public GameObject blockAscend4;
    public GameObject blockAscend5;
    public GameObject blockAscendSuper;
    public GameObject blockAscendGamble1;
    public GameObject blockAscendGamble2;
    public GameObject blockAscendGamble3;
    public GameObject blockAscendGamble4;

    public static int boughtRich1 = 0;
    public static int boughtRich2 = 0;
    public static int boughtRich3 = 0;
    public static int boughtRich4 = 0;
    public static int boughtRich5 = 0;
    public static int boughtRich6 = 0;
    public static int boughtRichSUPER = 0; //7
    public static int boughtRich1250 = 0;

    public static int boughtSale1 = 0;
    public static int boughtSale2 = 0;
    public static int boughtSale3 = 0;
    public static int boughtSale4 = 0;
    public static int boughtSTEAMSALE = 0; //5

    public static int boughtActiveFlipper1 = 0;
    public static int boughtActiveFlipper2 = 0;
    public static int boughtActiveFlipper3 = 0;
    public static int boughtActiveFlipper4 = 0;
    public static int boughtActiveFlipperSUPER = 0;
    public static int boughtActiveFlipperPILOFCOINS = 0; //6

    public static int boughtBagOfCoins1 = 0;
    public static int boughtBagOfCoins2 = 0;
    public static int boughtBagOfCoins3 = 0;
    public static int boughtBagOfCoins4 = 0;
    public static int boughtBagOfCoinsSUPER = 0; //5
    public static int boughtPileBag = 0;

    public static int boughtSpecial1 = 0;
    public static int boughtSpecial2 = 0;
    public static int boughtSpecial3 = 0;
    public static int boughtSpecial4 = 0;
    public static int boughtSpecialSUPER = 0;
    public static int boughtSpecialGAMBLEr = 0;
    public static int boughtSpecialBIGGERPILE = 0;
    public static int boughtSpecialBIGGERPILE2 = 0;
    public static int boughtSpecialLUCKER = 0; //8
    public static int boughtAuto = 0; //8

    public static int boughtGreaterAscension1 = 0;
    public static int boughtGreaterAscension2 = 0;
    public static int boughtGreaterAscension3 = 0;
    public static int boughtGreaterAscension4 = 0;
    public static int boughtGreaterAscension5 = 0;
    public static int boughtGreaterAscensionSUPER = 0;
    public static int boughtGreaterAscensionGamble1 = 0;
    public static int boughtGreaterAscensionGamble2 = 0;
    public static int boughtGreaterAscensionGamble3 = 0;
    public static int boughtGreaterAscensionGamble4 = 0; //10
    //

    public int rich1Cost = 1;
    public int rich2Cost = 3;
    public int rich3Cost = 8;
    public int rich4Cost = 11;
    public int rich5Cost = 13;
    public int rich6Cost = 15;
    public int richSuperCost = 24;
    public int rich1250Cost = 45;

    public int sale1Cost = 5;
    public int sale2Cost = 8;
    public int sale3Cost = 9;
    public int sale4Cost = 14;
    public int SteamSaleCost = 26;

    public int active1Cost = 3;
    public int active2Cost = 9;
    public int active3Cost = 11;
    public int active4Cost = 12;
    public int activeSUPERCost = 25;
    public int activePileCost = 8;

    public int bag1Cost = 2;
    public int bag2Cost = 5;
    public int bag3Cost = 10;
    public int bag4Cost = 11;
    public int bagSUPERCost = 23;
    public int bagPileCost = 8;

    public int special1Price = 5;
    public int special2Price = 7;
    public int special3Price = 10;
    public int specialSuperPrice = 22;
    public int specialGamblePrice = 10;
    public int specialPilePrice = 10;
    public int specialPile2Price = 11;
    public int specialLuckierPrice = 12;
    public int autoUpgradeCost;

    public int ascend1Cost = 3;
    public int ascend2Cost = 8;
    public int ascend3Cost = 9;
    public int ascend4Cost = 14;
    public int ascend5Cost = 15;
    public int ascendSuperCost = 40;
    public int ascendGamble1Cost = 4;
    public int ascendGamble2Cost = 5;
    public int ascendGamble3Cost = 7;
    public int ascendGamble4Cost = 8;

    public TextMeshProUGUI ascendScreenText;
    public TextMeshProUGUI not21FlipperText;
    public TextMeshProUGUI a21FlipperText;
    public TextMeshProUGUI clickedAscendText;

    public AudioClip upgradeSound;
    public AudioSource upgradeSource;

    public AudioClip upgradeSound2;
    public AudioSource upgradeSource2;
    public GameObject blockedAuto;

    public void PlayAudio()
    {
        int random = Random.Range(1, 3);
        if(random == 1)
        {
        upgradeSource.PlayOneShot(upgradeSound);
        }
        if(random == 2)
        {
            upgradeSource2.PlayOneShot(upgradeSound2);
        }
    }


    private void Start()
    {
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = "Inflation Coins: " + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;

        rich1Cost = 1;
        rich2Cost = 3;
        rich3Cost = 9;
        rich4Cost = 10;
        rich5Cost = 12;
        rich6Cost = 13;
        richSuperCost = 23;
        rich1250Cost = 99;
        bagPileCost = 8;
        autoUpgradeCost = 20;

        sale1Cost = 5;
        sale2Cost = 8;
        sale3Cost = 9;
        sale4Cost = 11;
        SteamSaleCost = 21;

        active1Cost = 3;
        active2Cost = 6;
        active3Cost = 9;
        active4Cost = 10;
        activeSUPERCost = 23;
        activePileCost = 7;
        activePileCost = 7;

        bag1Cost = 2;
        bag2Cost = 4;
        bag3Cost = 7;
        bag4Cost = 10;
        bagSUPERCost = 15;

        special1Price = 5;
        special2Price = 7;
        special3Price = 10;
        specialSuperPrice = 31;
        specialGamblePrice = 10;
        specialPilePrice = 10;
        specialPile2Price = 12;
        specialLuckierPrice = 10;

        ascend1Cost = 3;
        ascend2Cost = 8;
        ascend3Cost = 9;
        ascend4Cost = 11;
        ascend5Cost = 15;
        ascendSuperCost = 33;
        ascendGamble1Cost = 5;
        ascendGamble2Cost = 6;
        ascendGamble3Cost = 7;
        ascendGamble4Cost = 9;

        StartCoroutine(SetText());
    }

    public void CheckSetText()
    {
        StartCoroutine(SetText());

        unlockedAuto.SetActive(false);
        autoUnlocked.SetActive(false);
        blockedAuto.SetActive(true);
    }

    IEnumerator SetText()
    {
        yield return new WaitForSeconds(0.1f);

        #region Set text
        if (boughtRich1 == 0) { richStats.text = LocalizationStrings.inflateUpgradesStats + "0" + LocalizationStrings.moreCoins; }
        if (boughtRich1 == 1) { moreCoinsUpgradePercent = 1; richStats.text = LocalizationStrings.inflateUpgradesStats + moreCoinsUpgradePercent + LocalizationStrings.moreCoins; }
        if (boughtRich2 == 1) { moreCoinsUpgradePercent = 20;  richStats.text = LocalizationStrings.inflateUpgradesStats + moreCoinsUpgradePercent + LocalizationStrings.moreCoins; }
        if (boughtRich3 == 1) { moreCoinsUpgradePercent = 50;  richStats.text = LocalizationStrings.inflateUpgradesStats + moreCoinsUpgradePercent + LocalizationStrings.moreCoins; }
        if (boughtRich4 == 1) { moreCoinsUpgradePercent = 100;  richStats.text = LocalizationStrings.inflateUpgradesStats + moreCoinsUpgradePercent + LocalizationStrings.moreCoins; }
        if (boughtRich5 == 1) { moreCoinsUpgradePercent = 175; richStats.text = LocalizationStrings.inflateUpgradesStats + moreCoinsUpgradePercent + LocalizationStrings.moreCoins; }
        if (boughtRich6 == 1) { moreCoinsUpgradePercent = 300;  richStats.text = LocalizationStrings.inflateUpgradesStats + moreCoinsUpgradePercent + LocalizationStrings.moreCoins; }
        if (boughtRichSUPER == 1) { moreCoinsUpgradePercent = 750; richStats.text = LocalizationStrings.inflateUpgradesStats + moreCoinsUpgradePercent + LocalizationStrings.moreCoins; }
        if(boughtRich1250 == 1) { moreCoinsUpgradePercent = 1250;  richStats.text = LocalizationStrings.inflateUpgradesStats + moreCoinsUpgradePercent + LocalizationStrings.moreCoins; }

        if (boughtSale1 == 0) { cheaperPriceText.text = LocalizationStrings.inflateCheaperStats + "0" + LocalizationStrings.cheaper; }
        if (boughtSale1 == 1) { cheaperUpgradesPercent = 2; cheaperPriceText.text = LocalizationStrings.inflateCheaperStats + cheaperUpgradesPercent + LocalizationStrings.cheaper; }
        if (boughtSale2 == 1) { cheaperUpgradesPercent = 7; cheaperPriceText.text = LocalizationStrings.inflateCheaperStats + cheaperUpgradesPercent + LocalizationStrings.cheaper; }
        if (boughtSale3 == 1) { cheaperUpgradesPercent = 14; cheaperPriceText.text = LocalizationStrings.inflateCheaperStats + cheaperUpgradesPercent + LocalizationStrings.cheaper; }
        if (boughtSale4 == 1) { cheaperUpgradesPercent = 22; cheaperPriceText.text = LocalizationStrings.inflateCheaperStats + cheaperUpgradesPercent + LocalizationStrings.cheaper; }
        if (boughtSTEAMSALE == 1) cheaperUpgradesPercent = 50; { cheaperPriceText.text = LocalizationStrings.inflateCheaperStats + cheaperUpgradesPercent + LocalizationStrings.cheaper; }

        if (boughtBagOfCoins1 == 0) { starWithCoinsText.text = LocalizationStrings.inflateStartWithCoinsStats + "0" + LocalizationStrings.coinsAfterInflating; }
        if (boughtBagOfCoins1 == 1) { starWithCoinsAmount = 75; starWithCoinsText.text = LocalizationStrings.inflateStartWithCoinsStats + starWithCoinsAmount + LocalizationStrings.coinsAfterInflating; }
        if (boughtBagOfCoins2 == 1) { starWithCoinsAmount = 500; starWithCoinsText.text = LocalizationStrings.inflateStartWithCoinsStats + starWithCoinsAmount + LocalizationStrings.coinsAfterInflating; }
        if (boughtBagOfCoins3 == 1) { starWithCoinsAmount = 3000; starWithCoinsText.text = LocalizationStrings.inflateStartWithCoinsStats + starWithCoinsAmount + LocalizationStrings.coinsAfterInflating; }
        if (boughtBagOfCoins4 == 1) { starWithCoinsAmount = 20000; starWithCoinsText.text = LocalizationStrings.inflateStartWithCoinsStats + starWithCoinsAmount + LocalizationStrings.coinsAfterInflating; }
        if (boughtBagOfCoinsSUPER == 1) { starWithCoinsAmount = 100000; starWithCoinsText.text = LocalizationStrings.inflateStartWithCoinsStats + starWithCoinsAmount + LocalizationStrings.coinsAfterInflating; }

        if (boughtActiveFlipper1 == 0) { activeFlipperBonusText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflateActiveStats + "0" + LocalizationStrings.moreCoins; }
        if (boughtActiveFlipper1 == 1) { activeFlipperPercent = 8; activeFlipperBonusText.text = LocalizationStrings.inflateActiveStats + activeFlipperPercent + LocalizationStrings.moreCoins; }
        if (boughtActiveFlipper2 == 1) { activeFlipperPercent = 23; activeFlipperBonusText.text = LocalizationStrings.inflateActiveStats + activeFlipperPercent + LocalizationStrings.moreCoins; }
        if (boughtActiveFlipper3 == 1) { activeFlipperPercent = 40; activeFlipperBonusText.text = LocalizationStrings.inflateActiveStats + activeFlipperPercent + LocalizationStrings.moreCoins; }
        if (boughtActiveFlipper4 == 1) { activeFlipperPercent = 69; activeFlipperBonusText.text = LocalizationStrings.inflateActiveStats + activeFlipperPercent + LocalizationStrings.moreCoins; }
        if (boughtActiveFlipperSUPER == 1) { activeFlipperPercent = 300; activeFlipperBonusText.text = LocalizationStrings.inflateActiveStats + activeFlipperPercent + LocalizationStrings.moreCoins; }

        if(boughtSpecial1 == 0) { totalSpecialReduction = 0; }
        cheaperSpecialUpgradesCost.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflateSpecialCheaperStats + totalSpecialReduction + LocalizationStrings.less;


        gambleWinText.GetComponent<TextMeshProUGUI>().text = PurchaseLog.gambleChanceEachTimeWIN + LocalizationStrings.gambleWinChance;
        gambleLooseText.GetComponent<TextMeshProUGUI>().text = PurchaseLog.gambleChanceEachTimeLOOSE + LocalizationStrings.gambleLoseChance;
        rich1Price.GetComponent<TextMeshProUGUI>().text = "" + rich1Cost;
        rich2Price.GetComponent<TextMeshProUGUI>().text = "" + rich2Cost;
        rich3Price.GetComponent<TextMeshProUGUI>().text = "" + rich3Cost;
        rich4Price.GetComponent<TextMeshProUGUI>().text = "" + rich4Cost;
        rich5Price.GetComponent<TextMeshProUGUI>().text = "" + rich5Cost;
        rich6Price.GetComponent<TextMeshProUGUI>().text = "" + rich6Cost;
        richSUPERPrice.GetComponent<TextMeshProUGUI>().text = "" + richSuperCost;
        rich1250Price.GetComponent<TextMeshProUGUI>().text = "" + rich1250Cost;

        sale1Price.GetComponent<TextMeshProUGUI>().text = "" + sale1Cost;
        sale2Price.GetComponent<TextMeshProUGUI>().text = "" + sale2Cost;
        sale3Price.GetComponent<TextMeshProUGUI>().text = "" + sale3Cost;
        sale4Price.GetComponent<TextMeshProUGUI>().text = "" + sale4Cost;
        steamSale1Price.GetComponent<TextMeshProUGUI>().text = "" + SteamSaleCost;

        active1Price.GetComponent<TextMeshProUGUI>().text = "" + active1Cost;
        active2Price.GetComponent<TextMeshProUGUI>().text = "" + active2Cost;
        active3Price.GetComponent<TextMeshProUGUI>().text = "" + active3Cost;
        active4Price.GetComponent<TextMeshProUGUI>().text = "" + active4Cost;
        activeSUPERPrice.GetComponent<TextMeshProUGUI>().text = "" + activeSUPERCost;
        activePilePrice.GetComponent<TextMeshProUGUI>().text = "" + activePileCost;

        bagOfCoins1Price.GetComponent<TextMeshProUGUI>().text = "" + bag1Cost;
        bagOfCoins2Price.GetComponent<TextMeshProUGUI>().text = "" + bag2Cost;
        bagOfCoins3Price.GetComponent<TextMeshProUGUI>().text = "" + bag3Cost;
        bagOfCoins4Price.GetComponent<TextMeshProUGUI>().text = "" + bag4Cost;
        bagOfCoinsSUPERPrice.GetComponent<TextMeshProUGUI>().text = "" + bagSUPERCost;
        pileBagCost.GetComponent<TextMeshProUGUI>().text = "" + bagPileCost;
       

        special1Cost.GetComponent<TextMeshProUGUI>().text = "" + special1Price;
        special2Cost.GetComponent<TextMeshProUGUI>().text = "" + special2Price;
        special3Cost.GetComponent<TextMeshProUGUI>().text = "" + special3Price;
        specialSUPERCost.GetComponent<TextMeshProUGUI>().text = "" + specialSuperPrice;
        gamblerCost.GetComponent<TextMeshProUGUI>().text = "" + specialGamblePrice;
        getLuckerCost.GetComponent<TextMeshProUGUI>().text = "" + specialLuckierPrice;
        biggerPileOfCoinsCost.GetComponent<TextMeshProUGUI>().text = "" + specialPilePrice;
        biggerPil2eOfCoinsCost.GetComponent<TextMeshProUGUI>().text = "" + specialPile2Price;
        autoCost.GetComponent<TextMeshProUGUI>().text = "" + autoUpgradeCost;

        greaterAscension1Cost.GetComponent<TextMeshProUGUI>().text = "" + ascend1Cost;
        greaterAscension2Cost.GetComponent<TextMeshProUGUI>().text = "" + ascend2Cost;
        greaterAscension3Cost.GetComponent<TextMeshProUGUI>().text = "" + ascend3Cost;
        greaterAscension4Cost.GetComponent<TextMeshProUGUI>().text = "" + ascend4Cost;
        greaterAscension5Cost.GetComponent<TextMeshProUGUI>().text = "" + ascend5Cost;
        greaterAscensionSPECIALCost.GetComponent<TextMeshProUGUI>().text = "" + ascendSuperCost;
        ascensionGamble1Cost.GetComponent<TextMeshProUGUI>().text = "" + ascendGamble1Cost;
        ascensionGamble2Cost.GetComponent<TextMeshProUGUI>().text = "" + ascendGamble2Cost;
        ascensionGamble3Cost.GetComponent<TextMeshProUGUI>().text = "" + ascendGamble3Cost;
        ascensionGamble4Cost.GetComponent<TextMeshProUGUI>().text = "" + ascendGamble4Cost;
        #endregion

        #region Check bought inflation upgrade
        if (boughtRich1 == 1)
        {
            lockedUpgrade1.SetActive(false);
            lockedUpgrade2.SetActive(false);
            lockedUpgrade3.SetActive(false);
            lockedUpgrade4.SetActive(false);
            unlockedOnePercent.SetActive(true);
            RICHIunlocked.SetActive(true);
        }
        if (boughtRich1 == 0)
        {
            lockedUpgrade1.SetActive(true);
            lockedUpgrade2.SetActive(true);
            lockedUpgrade3.SetActive(true);
            lockedUpgrade4.SetActive(true);
            unlockedOnePercent.SetActive(false);
            RICHIunlocked.SetActive(false);
        }

        if (boughtRich2 == 1)
        {
            lockedUpgrade5.SetActive(false);
            RICHIIunlocked.SetActive(true);
            unlockedFivePercent.SetActive(true);
        }
        if (boughtRich2 == 0)
        {
            lockedUpgrade5.SetActive(true);
            RICHIIunlocked.SetActive(false);
            unlockedFivePercent.SetActive(false);
        }
        if (boughtRich3 == 1)
        {
            lockedUpgrade6.SetActive(false);
            lockedUpgrade7.SetActive(false);
            unlockedTenPercent.SetActive(true);
            RICHIIIunlocked.SetActive(true);
        }
        if (boughtRich3 == 0)
        {
            lockedUpgrade6.SetActive(true);
            lockedUpgrade7.SetActive(true);
            unlockedTenPercent.SetActive(false);
            RICHIIIunlocked.SetActive(false);
        }
        if (boughtRich4 == 1)
        {
            lockedUpgrade8.SetActive(false);
            RICHIVunlocked.SetActive(true);
            unlockIVUpgrade.SetActive(true);
        }
        if (boughtRich4 == 0)
        {
            lockedUpgrade8.SetActive(true);
            RICHIVunlocked.SetActive(false);
            unlockIVUpgrade.SetActive(false);
        }
        if (boughtRich5 == 1)
        {
            lockedUpgrade9.SetActive(false);
            unlockVUpgrade.SetActive(true);
            RICHVunlocked.SetActive(true);
        }
        if (boughtRich5 == 0)
        {
            lockedUpgrade9.SetActive(true);
            unlockVUpgrade.SetActive(false);
            RICHVunlocked.SetActive(false);
        }
        if (boughtRich6 == 1)
        {
            lockedUpgrade10SUPER.SetActive(false);
            unlockVIUpgrade.SetActive(true);
            RICHVIunlocked.SetActive(true);
        }
        if (boughtRich6 == 0)
        {
            lockedUpgrade10SUPER.SetActive(true);
            unlockVIUpgrade.SetActive(false);
            RICHVIunlocked.SetActive(false);
        }
        if (boughtRichSUPER == 1)
        {
            lockedRich8Omega.SetActive(false);
            OMEGARichUnlocked.SetActive(true);
            unlockOmegaRich.SetActive(true);
        }
        if (boughtRichSUPER == 0)
        {
            lockedRich8Omega.SetActive(true);
            OMEGARichUnlocked.SetActive(false);
            unlockOmegaRich.SetActive(false);
        }
        //
        if (boughtRich1250 == 1)
        {
            OMEGAR1250ichUnlocked.SetActive(true);
            unlockOmegaRich1250.SetActive(true);
        }
        if (boughtRich1250 == 0)
        {
            OMEGAR1250ichUnlocked.SetActive(false);
            unlockOmegaRich1250.SetActive(false);
        }

        if (boughtSale1 == 1)
        {
            lockedUpgrade11.SetActive(false);
            unlockedSaleI.SetActive(true);
            SALE1Unlocked.SetActive(true);
        }
        if (boughtSale1 == 0)
        {
            lockedUpgrade11.SetActive(true);
            unlockedSaleI.SetActive(false);
            SALE1Unlocked.SetActive(false);
        }
        if (boughtSale2 == 1)
        {
            lockedUpgrade12.SetActive(false);
            unlockedSaleII.SetActive(true);
            SALE2Unlocked.SetActive(true);
        }
        if (boughtSale2 == 0)
        {
            lockedUpgrade12.SetActive(true);
            unlockedSaleII.SetActive(false);
            SALE2Unlocked.SetActive(false);
        }
        if (boughtSale3 == 1)
        {
            lockedUpgrade13.SetActive(false);
            unlockedSaleIII.SetActive(true);
            SALE3Unlocked.SetActive(true);
        }
        if (boughtSale3 == 0)
        {
            lockedUpgrade13.SetActive(true);
            unlockedSaleIII.SetActive(false);
            SALE3Unlocked.SetActive(false);
        }
        if (boughtSale4 == 1)
        {
            lockedUpgrade14SUPER.SetActive(false);
            unlockedSaleIV.SetActive(true);
            SALE4Unlocked.SetActive(true);
        }
        if (boughtSale4 == 0)
        {
            lockedUpgrade14SUPER.SetActive(true);
            unlockedSaleIV.SetActive(false);
            SALE4Unlocked.SetActive(false);
        }
        if (boughtSTEAMSALE == 1)
        {
            SALE5Unlocked.SetActive(true);
            unlockedSaleV.SetActive(true);
        }
        if (boughtSTEAMSALE == 0)
        {
            SALE5Unlocked.SetActive(false);
            unlockedSaleV.SetActive(false);
        }

        if (boughtBagOfCoins1 == 1)
        {
            lockedUpgrade15.SetActive(false);
            lockedUpgrade27.SetActive(false);
            unlockedBagOfCoinsI.SetActive(true);
            BagUnlockedI.SetActive(true);
        }
        if (boughtBagOfCoins1 == 0)
        {
            lockedUpgrade15.SetActive(true);
            lockedUpgrade27.SetActive(true);
            unlockedBagOfCoinsI.SetActive(false);
            BagUnlockedI.SetActive(false);
        }
        if (boughtBagOfCoins2 == 1)
        {
            lockedUpgrade16.SetActive(false);
            unlockedBagOfCoinsII.SetActive(true);
            BagUnlockedII.SetActive(true);
        }
        if (boughtBagOfCoins2 == 0)
        {
            lockedUpgrade16.SetActive(true);
            unlockedBagOfCoinsII.SetActive(false);
            BagUnlockedII.SetActive(false);
        }
        if (boughtBagOfCoins3 == 1)
        {
            lockedUpgrade17.SetActive(false);
            unlockedBagOfCoinsIII.SetActive(true);
            BagUnlockedIII.SetActive(true);
        }
        if (boughtBagOfCoins3 == 0)
        {
            lockedUpgrade17.SetActive(true);
            unlockedBagOfCoinsIII.SetActive(false);
            BagUnlockedIII.SetActive(false);
        }
        //lolol
        if (boughtBagOfCoins4 == 1)
        {
            lockedBagPile.SetActive(false);
            lockedUpgrade18SUPER.SetActive(false);
            unlockedBagOfCoinsIV.SetActive(true);
            BagUnlockedIV.SetActive(true);
        }
        if (boughtBagOfCoins4 == 0)
        {
            lockedBagPile.SetActive(true);
            lockedUpgrade18SUPER.SetActive(true);
            unlockedBagOfCoinsIV.SetActive(false);
            BagUnlockedIV.SetActive(false);
        }
        if (boughtBagOfCoinsSUPER == 1)
        {
            unlockedBagOfCoinsV.SetActive(true);
            BagUnlockedV.SetActive(true);
        }
        if (boughtBagOfCoinsSUPER == 0)
        {
            unlockedBagOfCoinsV.SetActive(false);
            BagUnlockedV.SetActive(false);
        }

        //
        if (boughtPileBag == 1)
        {
            unlockedPileBag.SetActive(true);
            PileBagUnlocked.SetActive(true);
        }
        if (boughtPileBag == 0)
        {
            unlockedPileBag.SetActive(false);
            PileBagUnlocked.SetActive(false);
        }

        if (boughtActiveFlipper1 == 1)
        {
            lockedUpgrade34.SetActive(false);
            unlockedActiveFlipper1.SetActive(true);
            activeUnlocked1.SetActive(true);
        }
        if (boughtActiveFlipper1 == 0)
        {
            lockedUpgrade34.SetActive(true);
            unlockedActiveFlipper1.SetActive(false);
            activeUnlocked1.SetActive(false);
        }
        if (boughtActiveFlipper2 == 1)
        {
            lockedUpgrade35.SetActive(false);
            lockedUpgrade36.SetActive(false);
            unlockedActiveFlipper2.SetActive(true);
            activeUnlocked2.SetActive(true);
        }
        if (boughtActiveFlipper2 == 0)
        {
            lockedUpgrade35.SetActive(true);
            lockedUpgrade36.SetActive(true);
            unlockedActiveFlipper2.SetActive(false);
            activeUnlocked2.SetActive(false);
        }
        if (boughtActiveFlipper3 == 1)
        {
            lockedUpgrade37.SetActive(false);
            unlockedActiveFlipper3.SetActive(true);
            activeUnlocked3.SetActive(true);
        }
        if (boughtActiveFlipper3 == 0)
        {
            lockedUpgrade37.SetActive(true);
            unlockedActiveFlipper3.SetActive(false);
            activeUnlocked3.SetActive(false);
        }
        if (boughtActiveFlipper4 == 1)
        {
            lockedUpgrade38SUPER.SetActive(false);
            unlockedActiveFlipper4.SetActive(true);
            activeUnlocked4.SetActive(true);
        }
        if (boughtActiveFlipper4 == 0)
        {
            lockedUpgrade38SUPER.SetActive(true);
            unlockedActiveFlipper4.SetActive(false);
            activeUnlocked4.SetActive(false);
        }
        if (boughtActiveFlipperSUPER == 1)
        {
            unlockedActiveFlipper5.SetActive(true);
            activeUnlocked5.SetActive(true);
        }
        if (boughtActiveFlipperSUPER == 0)
        {
            unlockedActiveFlipper5.SetActive(false);
            activeUnlocked5.SetActive(false);
        }
        if (boughtActiveFlipperPILOFCOINS == 1)
        {
            unlockedflipperPileOfCoins.SetActive(true);
            activePileOfCoinsUnlocked.SetActive(true);
        }
        if (boughtActiveFlipperPILOFCOINS == 0)
        {
            unlockedflipperPileOfCoins.SetActive(false);
            activePileOfCoinsUnlocked.SetActive(false);
        }


        //
        if (boughtAuto == 1)
        {
            blockedAuto.SetActive(false);
            unlockedAuto.SetActive(true);
            autoUnlocked.SetActive(true);
        }
        if (boughtAuto == 0)
        {
            blockedAuto.SetActive(true);
            unlockedAuto.SetActive(false);
            autoUnlocked.SetActive(false);
        }

        if (boughtSpecial1 == 1)
        {
            lockedUpgrade28.SetActive(false);
            unlockedSpecial1.SetActive(true);
            specialUnlocked1.SetActive(true);
        }
        if (boughtSpecial1 == 0)
        {
            lockedUpgrade28.SetActive(true);
            unlockedSpecial1.SetActive(false);
            specialUnlocked1.SetActive(false);
        }
        if (boughtSpecial2 == 1)
        {
            lockedUpgrade29.SetActive(false);
            lockedUpgrade30.SetActive(false);
            lockedUpgrade31.SetActive(false);
            unlockedSpecial2.SetActive(true);
            specialUnlocked2.SetActive(true);
        }
        if (boughtSpecial2 == 0)
        {
            lockedUpgrade29.SetActive(true);
            lockedUpgrade30.SetActive(true);
            lockedUpgrade31.SetActive(true);
            unlockedSpecial2.SetActive(false);
            specialUnlocked2.SetActive(false);
        }
        if (boughtSpecial3 == 1)
        {
            lockedAutoUpgrade.SetActive(false);

            lockedUpgrade32.SetActive(false);
            unlockedSpecial3.SetActive(true);
            specialUnlocked3.SetActive(true);
            lockedUpgradeSpecialSUPER.SetActive(false);

        }
        if (boughtSpecial3 == 0)
        {
            lockedAutoUpgrade.SetActive(true);

            lockedUpgrade32.SetActive(true);
            unlockedSpecial3.SetActive(false);
            specialUnlocked3.SetActive(false);
            lockedUpgradeSpecialSUPER.SetActive(true);

        }

        if (boughtSpecialSUPER == 1)
        {
            unlockedSpecial5.SetActive(true);
            specialUnlocked5.SetActive(true);
        }
        if (boughtSpecialSUPER == 0)
        {
            unlockedSpecial5.SetActive(false);
            specialUnlocked5.SetActive(false);
        }
        if (boughtSpecialGAMBLEr == 1)
        {
            unlockedSpecial7.SetActive(true);
            specialUnlocked7.SetActive(true);
        }
        if (boughtSpecialGAMBLEr == 0)
        {
            unlockedSpecial7.SetActive(false);
            specialUnlocked7.SetActive(false);
        }
        if (boughtSpecialBIGGERPILE == 1)
        {
            unlockedSpecial6.SetActive(true);
            specialUnlocked6.SetActive(true);
            lockedPile2.SetActive(false);
        }
        if (boughtSpecialBIGGERPILE == 0)
        {
            lockedPile2.SetActive(true);
            unlockedSpecial6.SetActive(false);
            specialUnlocked6.SetActive(false);
        }
        //lol
        if (boughtSpecialBIGGERPILE2 == 1)
        {
            unlockedSpecialPile2.SetActive(true);
            specialPile2Unlocked.SetActive(true);
        }
        if (boughtSpecialBIGGERPILE2 == 0)
        {
            unlockedSpecialPile2.SetActive(false);
            specialPile2Unlocked.SetActive(false);
        }
        if (boughtSpecialLUCKER == 1)
        {
            unlockedSpecial8.SetActive(true);
            specialUnlocked8.SetActive(true);
        }
        if (boughtSpecialLUCKER == 0)
        {
            unlockedSpecial8.SetActive(false);
            specialUnlocked8.SetActive(false);
        }

        if (boughtGreaterAscension1 == 1)
        {
            lockedUpgrade19.SetActive(false);
            unlockedAscendI.SetActive(true);
            ascendUnlocked1.SetActive(true);
        }
        if (boughtGreaterAscension1 == 0)
        {
            lockedUpgrade19.SetActive(true);
            unlockedAscendI.SetActive(false);
            ascendUnlocked1.SetActive(false);
        }
        if (boughtGreaterAscension2 == 1)
        {
            lockedUpgrade20.SetActive(false);
            unlockedAscendII.SetActive(true);
            ascendUnlocked2.SetActive(true);
        }
        if (boughtGreaterAscension2 == 0)
        {
            lockedUpgrade20.SetActive(true);
            unlockedAscendII.SetActive(false);
            ascendUnlocked2.SetActive(false);
        }
        if (boughtGreaterAscension3 == 1)
        {
            lockedUpgrade21.SetActive(false);
            lockedUpgrade22.SetActive(false);
            lockedUpgrade23.SetActive(false);
            unlockedAscendIII.SetActive(true);
            ascendUnlocked3.SetActive(true);
        }
        if (boughtGreaterAscension3 == 0)
        {
            lockedUpgrade21.SetActive(true);
            lockedUpgrade22.SetActive(true);
            lockedUpgrade23.SetActive(true);
            unlockedAscendIII.SetActive(false);
            ascendUnlocked3.SetActive(false);
        }
        if (boughtGreaterAscension4 == 1)
        {
            ascendUnlocked4.SetActive(true);
            lockedUpgrade24.SetActive(false);
            lockedUpgrade25.SetActive(false);
            lockedUpgrade26.SetActive(false);
            unlockedAscendIV.SetActive(true);
        }
        if (boughtGreaterAscension4 == 0)
        {
            ascendUnlocked4.SetActive(false);
            lockedUpgrade24.SetActive(true);
            lockedUpgrade25.SetActive(true);
            lockedUpgrade26.SetActive(true);
            unlockedAscendIV.SetActive(false);
        }
        if (boughtGreaterAscension5 == 1)
        {
            ascendUnlocked5.SetActive(true);
            lockedUpgrade27SUPER.SetActive(false);
            unlockedAscendV.SetActive(true);
        }
        if (boughtGreaterAscension5 == 0)
        {
            ascendUnlocked5.SetActive(false);
            lockedUpgrade27SUPER.SetActive(true);
            unlockedAscendV.SetActive(false);
        }
        if (boughtGreaterAscensionSUPER == 1)
        {
            ascendUnlocked6.SetActive(true);
            unlockedAscendSUPER.SetActive(true);
        }
        if (boughtGreaterAscensionSUPER == 0)
        {
            ascendUnlocked6.SetActive(false);
            unlockedAscendSUPER.SetActive(false);
        }
        if (boughtGreaterAscensionGamble1 == 1)
        {
            ascendUnlocked7.SetActive(true);
            unlockedAscendPercent1.SetActive(true);
        }
        if (boughtGreaterAscensionGamble1 == 0)
        {
            ascendUnlocked7.SetActive(false);
            unlockedAscendPercent1.SetActive(false);
        }
        if (boughtGreaterAscensionGamble2 == 1)
        {
            ascendUnlocked8.SetActive(true);
            unlockedAscendPercent2.SetActive(true);
        }
        if (boughtGreaterAscensionGamble2 == 0)
        {
            ascendUnlocked8.SetActive(false);
            unlockedAscendPercent2.SetActive(false);
        }
        if (boughtGreaterAscensionGamble3 == 1)
        {
            ascendUnlocked9.SetActive(true);
            unlockedAscendPercent3.SetActive(true);
        }
        if (boughtGreaterAscensionGamble3 == 0)
        {
            ascendUnlocked9.SetActive(false);
            unlockedAscendPercent3.SetActive(false);
        }
        if (boughtGreaterAscensionGamble4 == 1)
        {
            ascendUnlocked10.SetActive(true);
            unlockedAscendPercent4.SetActive(true);
        }
        if (boughtGreaterAscensionGamble4 == 0)
        {
            ascendUnlocked10.SetActive(false);
            unlockedAscendPercent4.SetActive(false);
        }
        #endregion
    }

    #region Check price
    public void CheckInflationUpgradePriceColor()
    {
        //RICH
        if (AscendCoins.ascensionCoinAmount < rich1Cost) { rich1Price.color = Color.red; blockRich1.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= rich1Cost) { rich1Price.color = Color.green; blockRich1.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < rich2Cost) { rich2Price.color = Color.red; blockRich2.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= rich2Cost) { rich2Price.color = Color.green; blockRich2.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < rich3Cost) { rich3Price.color = Color.red; blockRich3.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= rich3Cost) { rich3Price.color = Color.green; blockRich3.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < rich4Cost) { rich4Price.color = Color.red; blockRich4.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= rich4Cost) { rich4Price.color = Color.green; blockRich4.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < rich5Cost) { rich5Price.color = Color.red; blockRich5.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= rich5Cost) { rich5Price.color = Color.green; blockRich5.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < rich6Cost) { rich6Price.color = Color.red; blockRich6.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= rich6Cost) { rich6Price.color = Color.green; blockRich6.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < richSuperCost) { richSUPERPrice.color = Color.red; blockRichSuper.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= richSuperCost) { richSUPERPrice.color = Color.green; blockRichSuper.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < rich1250Cost) { rich1250Price.color = Color.red; blockRich1250.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= rich1250Cost) { rich1250Price.color = Color.green; blockRich1250.SetActive(false); }
        //SALE
        if (AscendCoins.ascensionCoinAmount < sale1Cost) { sale1Price.color = Color.red; blockSale1.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= sale1Cost) { sale1Price.color = Color.green; blockSale1.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < sale2Cost) { sale2Price.color = Color.red; blockSale2.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= sale2Cost) { sale2Price.color = Color.green; blockSale2.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < sale3Cost) { sale3Price.color = Color.red; blockSale3.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= sale3Cost) { sale3Price.color = Color.green; blockSale3.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < sale4Cost) { sale4Price.color = Color.red; blockSale4.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= sale4Cost) { sale4Price.color = Color.green; blockSale4.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < SteamSaleCost) { steamSale1Price.color = Color.red; blockSteamSale.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= SteamSaleCost) { steamSale1Price.color = Color.green; blockSteamSale.SetActive(false); }
        //ACTIVE
        if (AscendCoins.ascensionCoinAmount < active1Cost) { active1Price.color = Color.red; blockActive1.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= active1Cost) { active1Price.color = Color.green; blockActive1.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < active2Cost) { active2Price.color = Color.red; blockActive2.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= active2Cost) { active2Price.color = Color.green; blockActive2.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < active3Cost) { active3Price.color = Color.red; blockActive3.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= active3Cost) { active3Price.color = Color.green; blockActive3.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < active4Cost) { active4Price.color = Color.red; blockActive4.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= active4Cost) { active4Price.color = Color.green; blockActive4.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < activeSUPERCost) { activeSUPERPrice.color = Color.red; blockActiveSuper.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= activeSUPERCost) { activeSUPERPrice.color = Color.green; blockActiveSuper.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < activePileCost) { activePilePrice.color = Color.red; blockActivePile.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= activePileCost) { activePilePrice.color = Color.green; blockActivePile.SetActive(false); }


        //BAGOFCOINS
        if (AscendCoins.ascensionCoinAmount < bag1Cost) { bagOfCoins1Price.color = Color.red; blockBag1.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= bag1Cost) { bagOfCoins1Price.color = Color.green; blockBag1.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < bag2Cost) { bagOfCoins2Price.color = Color.red; blockBag2.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= bag2Cost) { bagOfCoins2Price.color = Color.green; blockBag2.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < bag3Cost) { bagOfCoins3Price.color = Color.red; blockBag3.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= bag3Cost) { bagOfCoins3Price.color = Color.green; blockBag3.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < bag4Cost) { bagOfCoins4Price.color = Color.red; blockBag4.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= bag4Cost) { bagOfCoins4Price.color = Color.green; blockBag4.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < bagSUPERCost) { bagOfCoinsSUPERPrice.color = Color.red; blockBagSuper.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= bagSUPERCost) { bagOfCoinsSUPERPrice.color = Color.green; blockBagSuper.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < bagPileCost) { pileBagCost.color = Color.red; blockPileBag.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= bagPileCost) { pileBagCost.color = Color.green; blockPileBag.SetActive(false); }

        //SPECIAL
        if (AscendCoins.ascensionCoinAmount < special1Price) { special1Cost.color = Color.red; blockSpecial1.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= special1Price) { special1Cost.color = Color.green; blockSpecial1.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < special2Price) { special2Cost.color = Color.red; blockSpecial2.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= special2Price) { special2Cost.color = Color.green; blockSpecial2.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < special3Price) { special3Cost.color = Color.red; blockSpecial3.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= special3Price) { special3Cost.color = Color.green; blockSpecial3.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < specialSuperPrice) { specialSUPERCost.color = Color.red; blockSpecialSuper.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= specialSuperPrice) { specialSUPERCost.color = Color.green; blockSpecialSuper.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < specialGamblePrice) { gamblerCost.color = Color.red; blockSpecialGamle.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= specialGamblePrice) { gamblerCost.color = Color.green; blockSpecialGamle.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < specialLuckierPrice) { getLuckerCost.color = Color.red; blockSpecialLuckier.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= specialLuckierPrice) { getLuckerCost.color = Color.green; blockSpecialLuckier.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < specialPilePrice) { biggerPileOfCoinsCost.color = Color.red; blockSpecialPile.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= specialPilePrice) { biggerPileOfCoinsCost.color = Color.green; blockSpecialPile.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < specialPile2Price) { biggerPil2eOfCoinsCost.color = Color.red; blockSpecialPile2.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= specialPile2Price) { biggerPil2eOfCoinsCost.color = Color.green; blockSpecialPile2.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < autoUpgradeCost) { autoCost.color = Color.red; blockAuto.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= autoUpgradeCost) { autoCost.color = Color.green; blockAuto.SetActive(false); }

        //ASCENSION
        if (AscendCoins.ascensionCoinAmount < ascend1Cost) { greaterAscension1Cost.color = Color.red; blockAscend1.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= ascend1Cost) { greaterAscension1Cost.color = Color.green; blockAscend1.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < ascend2Cost) { greaterAscension2Cost.color = Color.red; blockAscend2.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= ascend2Cost) { greaterAscension2Cost.color = Color.green; blockAscend2.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < ascend3Cost) { greaterAscension3Cost.color = Color.red; blockAscend3.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= ascend3Cost) { greaterAscension3Cost.color = Color.green; blockAscend3.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < ascend4Cost) { greaterAscension4Cost.color = Color.red; blockAscend4.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= ascend4Cost) { greaterAscension4Cost.color = Color.green; blockAscend4.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < ascend5Cost) { greaterAscension5Cost.color = Color.red; blockAscend5.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= ascend5Cost) { greaterAscension5Cost.color = Color.green; blockAscend5.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < ascendSuperCost) { greaterAscensionSPECIALCost.color = Color.red; blockAscendSuper.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= ascendSuperCost) { greaterAscensionSPECIALCost.color = Color.green; blockAscendSuper.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < ascendGamble1Cost) { ascensionGamble1Cost.color = Color.red; blockAscendGamble1.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= ascendGamble1Cost) { ascensionGamble1Cost.color = Color.green; blockAscendGamble1.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < ascendGamble2Cost) { ascensionGamble2Cost.color = Color.red; blockAscendGamble2.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= ascendGamble2Cost) { ascensionGamble2Cost.color = Color.green; blockAscendGamble2.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < ascendGamble3Cost) { ascensionGamble3Cost.color = Color.red; blockAscendGamble3.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= ascendGamble3Cost) { ascensionGamble3Cost.color = Color.green; blockAscendGamble3.SetActive(false); }
        if (AscendCoins.ascensionCoinAmount < ascendGamble4Cost) { ascensionGamble4Cost.color = Color.red; blockAscendGamble4.SetActive(true); }
        if (AscendCoins.ascensionCoinAmount >= ascendGamble4Cost) { ascensionGamble4Cost.color = Color.green; blockAscendGamble4.SetActive(false); }

        if(LoadSaves.isMobileBuild == true)
        {
            blockRich1.SetActive(false); 
            blockRich2.SetActive(false); 
            blockRich3.SetActive(false); 
            blockRich4.SetActive(false); 
            blockRich5.SetActive(false); 
            blockRich6.SetActive(false); 
            blockRichSuper.SetActive(false); 
            blockRich1250.SetActive(false); 
            blockSale1.SetActive(false); 
            blockSale2.SetActive(false); 
            blockSale3.SetActive(false); 
            blockSale4.SetActive(false); 
            blockSteamSale.SetActive(false); 
            blockActive1.SetActive(false); 
            blockActive2.SetActive(false); 
            blockActive3.SetActive(false); 
            blockActive4.SetActive(false); 
            blockActiveSuper.SetActive(false); 
            blockActivePile.SetActive(false); 
            blockBag1.SetActive(false); 
            blockBag2.SetActive(false); 
            blockBag3.SetActive(false); 
            blockBag4.SetActive(false); 
            blockBagSuper.SetActive(false); 
            blockPileBag.SetActive(false); 
            blockSpecial1.SetActive(false); 
            blockSpecial2.SetActive(false); 
            blockSpecial3.SetActive(false); 
            blockSpecialSuper.SetActive(false); 
            blockSpecialGamle.SetActive(false); 
            blockSpecialLuckier.SetActive(false); 
            blockSpecialPile.SetActive(false); 
            blockSpecialPile2.SetActive(false); 
            blockAuto.SetActive(false); 
            blockAscend1.SetActive(false); 
            blockAscend2.SetActive(false); 
            blockAscend3.SetActive(false); 
            blockAscend4.SetActive(false); 
            blockAscend5.SetActive(false); 
            blockAscendSuper.SetActive(false); 
            blockAscendGamble1.SetActive(false); 
            blockAscendGamble2.SetActive(false); 
            blockAscendGamble3.SetActive(false); 
            blockAscendGamble4.SetActive(false); 
        }
    }
    #endregion

    //----------------------------------------------------------------------
    //RichUpgrades
    //----------------------------------------------------------------------

    public void ResetPrestigeTooltips()
    {
        for (int i = 0; i < frames.Length; i++)
        {
            frames[i].SetActive(false);
        }
    }

    public bool isFrameOpened;
    public GameObject mobileButtons;
    public int upgradeNumber;
    public Button purchaseButton;
    public GameObject closeBtn;

    public GameObject[] frames;

    public void AOpenUpgradeFrame(int upgrade)
    {
        if(LoadSaves.isMobileBuild == true)
        {
            isFrameOpened = true;
            if(Ascend.onlyViewing == false)
            { 
                purchaseButton.gameObject.SetActive(true);
                closeBtn.transform.localPosition = new Vector2(376, 0f);
            }
            else
            {
                purchaseButton.gameObject.SetActive(false);
                closeBtn.transform.localPosition = new Vector2(0, 0f);
            }
          
            closeBtn.SetActive(true);
            mobileButtons.SetActive(true);

            upgradeNumber = upgrade;

            frames[upgrade].SetActive(true);

            #region Rich upgrades
            if (upgrade == 1)
            {
                if (AscendCoins.ascensionCoinAmount < rich1Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= rich1Cost) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 2)
            {
                if (AscendCoins.ascensionCoinAmount < rich2Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= rich2Cost) { purchaseButton.interactable = true; }
            }
            else if(upgrade == 3)
            {
                if (AscendCoins.ascensionCoinAmount < rich3Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= rich3Cost) { purchaseButton.interactable = true; }
            }
            else if(upgrade == 4)
            {
                if (AscendCoins.ascensionCoinAmount < rich4Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= rich4Cost) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 5)
            {
                if (AscendCoins.ascensionCoinAmount < rich5Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= rich5Cost) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 6)
            {
                if (AscendCoins.ascensionCoinAmount < rich6Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= rich6Cost) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 7)
            {
                if (AscendCoins.ascensionCoinAmount < richSuperCost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= richSuperCost) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 8)
            {
                if (AscendCoins.ascensionCoinAmount < rich1250Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= rich1250Cost) { purchaseButton.interactable = true; }
            }
            #endregion

            #region Sale upgrades
            if (upgrade == 9)
            {
                if (AscendCoins.ascensionCoinAmount < sale1Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= sale1Cost) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 10)
            {
                if (AscendCoins.ascensionCoinAmount < sale2Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= sale2Cost) { purchaseButton.interactable = true; }
            }
            else if(upgrade == 11)
            {
                if (AscendCoins.ascensionCoinAmount < sale3Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= sale3Cost) { purchaseButton.interactable = true; }
            }
            else if(upgrade == 12)
            {
                if (AscendCoins.ascensionCoinAmount < sale4Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= sale4Cost) { purchaseButton.interactable = true; }
            }
            else if(upgrade == 13)
            {
                if (AscendCoins.ascensionCoinAmount < SteamSaleCost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= SteamSaleCost) { purchaseButton.interactable = true; }
            }
            #endregion

            #region Bag of coins
            else if (upgrade == 14)
            {
                if (AscendCoins.ascensionCoinAmount < bag1Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= bag1Cost) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 15)
            {
                if (AscendCoins.ascensionCoinAmount < bag2Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= bag2Cost) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 16)
            {
                if (AscendCoins.ascensionCoinAmount < bag3Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= bag3Cost) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 17)
            {
                if (AscendCoins.ascensionCoinAmount < bag4Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= bag4Cost) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 18)
            {
                if (AscendCoins.ascensionCoinAmount < bagSUPERCost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= bagSUPERCost) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 19)
            {
                if (AscendCoins.ascensionCoinAmount < bagPileCost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= bagPileCost) { purchaseButton.interactable = true; }
            }
            #endregion

            #region Inflation upgrades
            else if (upgrade == 20)
            {
                if (AscendCoins.ascensionCoinAmount < ascend1Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= ascend1Cost) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 21)
            {
                if (AscendCoins.ascensionCoinAmount < ascend2Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= ascend2Cost) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 22)
            {
                if (AscendCoins.ascensionCoinAmount < ascend3Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= ascend3Cost) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 23)
            {
                if (AscendCoins.ascensionCoinAmount < ascend4Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= ascend4Cost) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 24)
            {
                if (AscendCoins.ascensionCoinAmount < ascend5Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= ascend5Cost) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 25)
            {
                if (AscendCoins.ascensionCoinAmount < ascendSuperCost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= ascendSuperCost) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 26)
            {
                if (AscendCoins.ascensionCoinAmount < ascendGamble1Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= ascendGamble1Cost) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 27)
            {
                if (AscendCoins.ascensionCoinAmount < ascendGamble2Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= ascendGamble2Cost) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 28)
            {
                if (AscendCoins.ascensionCoinAmount < ascendGamble3Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= ascendGamble3Cost) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 29)
            {
                if (AscendCoins.ascensionCoinAmount < ascendGamble4Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= ascendGamble4Cost) { purchaseButton.interactable = true; }
            }
            #endregion

            #region Extra special upgrades
            else if (upgrade == 30)
            {
                if (AscendCoins.ascensionCoinAmount < special1Price) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= special1Price) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 31)
            {
                if (AscendCoins.ascensionCoinAmount < special2Price) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= special2Price) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 32)
            {
                if (AscendCoins.ascensionCoinAmount < special3Price) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= special3Price) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 33)
            {
                if (AscendCoins.ascensionCoinAmount < specialSuperPrice) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= specialSuperPrice) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 34)
            {
                if (AscendCoins.ascensionCoinAmount < specialGamblePrice) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= specialGamblePrice) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 35)
            {
                if (AscendCoins.ascensionCoinAmount < specialPilePrice) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= specialPilePrice) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 36)
            {
                if (AscendCoins.ascensionCoinAmount < specialPile2Price) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= specialPile2Price) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 37)
            {
                if (AscendCoins.ascensionCoinAmount < specialLuckierPrice) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= specialLuckierPrice) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 38)
            {
                if (AscendCoins.ascensionCoinAmount < autoUpgradeCost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= autoUpgradeCost) { purchaseButton.interactable = true; }
            }
            #endregion

            #region Active flipper upgrades
            else if (upgrade == 39)
            {
                if (AscendCoins.ascensionCoinAmount < active1Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= active1Cost) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 40)
            {
                if (AscendCoins.ascensionCoinAmount < active2Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= active2Cost) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 41)
            {
                if (AscendCoins.ascensionCoinAmount < active3Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= active3Cost) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 42)
            {
                if (AscendCoins.ascensionCoinAmount < active4Cost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= active4Cost) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 43)
            {
                if (AscendCoins.ascensionCoinAmount < activeSUPERCost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= activeSUPERCost) { purchaseButton.interactable = true; }
            }
            else if (upgrade == 44)
            {
                if (AscendCoins.ascensionCoinAmount < activePileCost) { purchaseButton.interactable = false; }
                if (AscendCoins.ascensionCoinAmount >= activePileCost) { purchaseButton.interactable = true; }
            }
            #endregion
        }
    }

    public void OpenPurchasedFrame(int upgrade)
    {
        if(LoadSaves.isMobileBuild == true)
        {
            frames[upgrade].SetActive(true);
            purchaseButton.gameObject.SetActive(false);
            closeBtn.transform.localPosition = new Vector2(0, 0f);
            mobileButtons.SetActive(true);
            upgradeNumber = upgrade;
        }
    }

    public void CloseFrame()
    {
        isFrameOpened = false;
        mobileButtons.SetActive(false);
        frames[upgradeNumber].SetActive(false);
    }
    public void PurchaseCurrentUpgrade()
    {
        //Rich
        if(upgradeNumber == 1) { BuyOnePercent(); }
        if (upgradeNumber == 2) { BuyFivePercent(); }
        if (upgradeNumber == 3) { BuyTenPercent(); }
        if (upgradeNumber == 4) { RichIV(); }
        if (upgradeNumber == 5) { RichV(); }
        if (upgradeNumber == 6) { RichVI(); }
        if (upgradeNumber == 7) { OmegaRich(); }
        if (upgradeNumber == 8) { Rich1250(); }

        if (upgradeNumber == 9) { SaleI(); }
        if (upgradeNumber == 10) { SaleII(); }
        if (upgradeNumber == 11) { SaleIII(); }
        if (upgradeNumber == 12) { SaleIV(); }
        if (upgradeNumber == 13) { SaleV(); }

        if (upgradeNumber == 14) { MoneyBagI(); }
        if (upgradeNumber == 15) { MoneyBagII(); }
        if (upgradeNumber == 16) { MoneyBagIII(); }
        if (upgradeNumber == 17) { MoneyBagIV(); }
        if (upgradeNumber == 18) { MoneyBagV(); }
        if (upgradeNumber == 19) { PileBag(); }

        if (upgradeNumber == 20) { AscendUpgradeI(); }
        if (upgradeNumber == 21) { AscendUpgradeII(); }
        if (upgradeNumber == 22) { AscendUpgradeIII(); }
        if (upgradeNumber == 23) { AscendUpgradeIV(); }
        if (upgradeNumber == 24) { AscendUpgradeV(); }
        if (upgradeNumber == 25) { AscendUpgradeSUPER(); }
        if (upgradeNumber == 26) { ascendPercentI(); }
        if (upgradeNumber == 27) { ascendPercentII(); }
        if (upgradeNumber == 28) { ascendPercentIII(); }
        if (upgradeNumber == 29) { ascendPercentVI(); }

        if (upgradeNumber == 30) { specialUpgradeAscendI(); }
        if (upgradeNumber == 31) { specialUpgradeAscendII(); }
        if (upgradeNumber == 32) { specialUpgradeAscendIII(); }
        if (upgradeNumber == 33) { specialUpgradeAscendVSUPER(); }
        if (upgradeNumber == 34) { specialUpgradeAscendUnieuqII(); }
        if (upgradeNumber == 35) { specialUpgradeAscendUnieuqI(); }
        if (upgradeNumber == 36) { specialUpgradeAscendUnieuqPile2(); }
        if (upgradeNumber == 37) { specialUpgradeAscendUnieuqIII(); }
        if (upgradeNumber == 38) { AutoUpgrade(); }

        if (upgradeNumber == 39) { ActiveFlipperUpgradeI(); }
        if (upgradeNumber == 40) { ActiveFlipperUpgradeII(); }
        if (upgradeNumber == 41) { ActiveFlipperUpgradeIII(); }
        if (upgradeNumber == 42) { ActiveFlipperUpgradeIV(); }
        if (upgradeNumber == 43) { ActiveFlipperUpgradeSUPER(); }
        if (upgradeNumber == 44) { ActiveFlipperPileOfCoinsUpgrade(); }
    }

    public TextMeshProUGUI richStats;
    public static int moreCoinsUpgradePercent;

    public void BuyOnePercent()
    {
        if(LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        moreCoinsUpgradePercent = 1;

        richStats.text = LocalizationStrings.inflateUpgradesStats + moreCoinsUpgradePercent + LocalizationStrings.moreCoins;

        lockedUpgrade1.SetActive(false);
        lockedUpgrade2.SetActive(false);
        lockedUpgrade3.SetActive(false);
        lockedUpgrade4.SetActive(false);
        unlockedOnePercent.SetActive(true);
        RICHIunlocked.SetActive(true);
        coinMulitplier = 0.01f;
        boughtRich1 = 1;
        PlayerPrefs.SetInt("SavedBoughtRich1", AscendScreen.boughtRich1);
        AscendCoins.ascensionCoinAmount -= rich1Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        ascendUpgradeAmount += 1;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }
    public void BuyFivePercent()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();

        moreCoinsUpgradePercent = 20;
        richStats.text = LocalizationStrings.inflateUpgradesStats + moreCoinsUpgradePercent + LocalizationStrings.moreCoins;

        lockedUpgrade5.SetActive(false);
        RICHIIunlocked.SetActive(true);
        unlockedFivePercent.SetActive(true);
        coinMulitplier = 0.20f;
        boughtRich2 = 1;
        PlayerPrefs.SetInt("SavedBoughtRich2", AscendScreen.boughtRich2);
        AscendCoins.ascensionCoinAmount -= rich2Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        ascendUpgradeAmount += 1;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }
    public void BuyTenPercent()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        moreCoinsUpgradePercent = 50;
        richStats.text = LocalizationStrings.inflateUpgradesStats + moreCoinsUpgradePercent + LocalizationStrings.moreCoins;
        lockedUpgrade6.SetActive(false);
        lockedUpgrade7.SetActive(false);
        unlockedTenPercent.SetActive(true);
        RICHIIIunlocked.SetActive(true);
        coinMulitplier = 0.50f;
        boughtRich3 = 1;
        PlayerPrefs.SetInt("SavedBoughtRich3", AscendScreen.boughtRich3);
        AscendCoins.ascensionCoinAmount -= rich3Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        ascendUpgradeAmount += 1;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }
    public void RichIV()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        moreCoinsUpgradePercent = 100;
        richStats.text = LocalizationStrings.inflateUpgradesStats + moreCoinsUpgradePercent + LocalizationStrings.moreCoins;
        lockedUpgrade8.SetActive(false);
        RICHIVunlocked.SetActive(true);
        unlockIVUpgrade.SetActive(true);
        coinMulitplier = 1.00f;
        boughtRich4 = 1;
        PlayerPrefs.SetInt("SavedBoughtRich4", AscendScreen.boughtRich4);
        AscendCoins.ascensionCoinAmount -= rich4Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }
    public void RichV()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        moreCoinsUpgradePercent = 175;
        richStats.text = LocalizationStrings.inflateUpgradesStats + moreCoinsUpgradePercent + LocalizationStrings.moreCoins;
        lockedUpgrade9.SetActive(false);

        unlockVUpgrade.SetActive(true);
        RICHVunlocked.SetActive(true);
        coinMulitplier = 1.75f;
        boughtRich5 = 1;
        PlayerPrefs.SetInt("SavedBoughtRich5", AscendScreen.boughtRich5);
        AscendCoins.ascensionCoinAmount -= rich5Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }
    public void RichVI()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        moreCoinsUpgradePercent = 300;
        richStats.text = LocalizationStrings.inflateUpgradesStats + moreCoinsUpgradePercent + LocalizationStrings.moreCoins;
        lockedUpgrade10SUPER.SetActive(false);
        unlockVIUpgrade.SetActive(true);
        RICHVIunlocked.SetActive(true);
        coinMulitplier = 3f;
        boughtRich6 = 1;
        PlayerPrefs.SetInt("SavedBoughtRich6", AscendScreen.boughtRich6);
        AscendCoins.ascensionCoinAmount -= rich6Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }

    public void OmegaRich()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        moreCoinsUpgradePercent = 750;
        richStats.text = LocalizationStrings.inflateUpgradesStats + moreCoinsUpgradePercent + LocalizationStrings.moreCoins;
        OMEGARichUnlocked.SetActive(true);
        unlockOmegaRich.SetActive(true);
        coinMulitplier = 7.5f;
        boughtRichSUPER = 1;
        PlayerPrefs.SetInt("SavedBoughtRich7", AscendScreen.boughtRichSUPER);
        AscendCoins.ascensionCoinAmount -= richSuperCost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        lockedRich8Omega.SetActive(false);
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }

    public void Rich1250()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        moreCoinsUpgradePercent = 1250;
        richStats.text = LocalizationStrings.inflateUpgradesStats + moreCoinsUpgradePercent + LocalizationStrings.moreCoins;
        OMEGAR1250ichUnlocked.SetActive(true);
        unlockOmegaRich1250.SetActive(true);
        coinMulitplier = 12.5f;
        boughtRich1250 = 1;
        PlayerPrefs.SetInt("BoughtRich1250", AscendScreen.boughtRich1250);
        AscendCoins.ascensionCoinAmount -= rich1250Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }

    //----------------------------------------------------------------------
    //SaleUpgrades
    //----------------------------------------------------------------------

    public TextMeshProUGUI cheaperPriceText;
    public static int cheaperUpgradesPercent;

    public void SaleI()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        cheaperUpgradesPercent = 2;
        cheaperPriceText.text = LocalizationStrings.inflateCheaperStats + cheaperUpgradesPercent + LocalizationStrings.cheaper;
       
        lockedUpgrade11.SetActive(false);
        unlockedSaleI.SetActive(true);
        SALE1Unlocked.SetActive(true);
        cheaperPrice = 0.02f;
        boughtSale1 = 1;
        PlayerPrefs.SetInt("SavedBoughtSale1", AscendScreen.boughtSale1);
        AscendCoins.ascensionCoinAmount -= sale1Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }

    public void SaleII()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        cheaperUpgradesPercent = 7;
        cheaperPriceText.text = LocalizationStrings.inflateCheaperStats + cheaperUpgradesPercent + LocalizationStrings.cheaper;
        lockedUpgrade12.SetActive(false);
        unlockedSaleII.SetActive(true);
        SALE2Unlocked.SetActive(true);
        cheaperPrice = 0.07f;
        boughtSale2 = 1;
        PlayerPrefs.SetInt("SavedBoughtSale2", AscendScreen.boughtSale2);
        AscendCoins.ascensionCoinAmount -= sale2Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }
    public void SaleIII()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        cheaperUpgradesPercent = 14;
        cheaperPriceText.text = LocalizationStrings.inflateCheaperStats + cheaperUpgradesPercent + LocalizationStrings.cheaper;
        lockedUpgrade13.SetActive(false);
        unlockedSaleIII.SetActive(true);
        SALE3Unlocked.SetActive(true);
        cheaperPrice = 0.14f;
        boughtSale3 = 1;
        PlayerPrefs.SetInt("SavedBoughtSale3", AscendScreen.boughtSale3);
        AscendCoins.ascensionCoinAmount -= sale3Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }

    public void SaleIV()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        cheaperUpgradesPercent = 22;
        cheaperPriceText.text = LocalizationStrings.inflateCheaperStats + cheaperUpgradesPercent + LocalizationStrings.cheaper;
        lockedUpgrade14SUPER.SetActive(false);
        unlockedSaleIV.SetActive(true);
        SALE4Unlocked.SetActive(true);
        cheaperPrice = 0.22f;
        boughtSale4 = 1;
        PlayerPrefs.SetInt("SavedBoughtSale4", AscendScreen.boughtSale4);
        AscendCoins.ascensionCoinAmount -= sale4Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }
    public void SaleV()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        cheaperUpgradesPercent = 50;
        cheaperPriceText.text = LocalizationStrings.inflateCheaperStats + cheaperUpgradesPercent + LocalizationStrings.cheaper;
        SALE5Unlocked.SetActive(true);
        unlockedSaleV.SetActive(true);
        cheaperPrice = 0.50f;
        boughtSTEAMSALE = 1;
        PlayerPrefs.SetInt("SavedBoughtSTEAMSALE", AscendScreen.boughtSTEAMSALE);
        AscendCoins.ascensionCoinAmount -= SteamSaleCost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }

    //----------------------------------------------------------------------
    //StartUpgrades
    //----------------------------------------------------------------------

    public TextMeshProUGUI starWithCoinsText;
    public static int starWithCoinsAmount;
    public void MoneyBagI()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        starWithCoinsAmount = 75;
        starWithCoinsText.text = LocalizationStrings.inflateStartWithCoinsStats + starWithCoinsAmount + LocalizationStrings.coinsAfterInflating;
       
        lockedUpgrade15.SetActive(false);
        lockedUpgrade27.SetActive(false);
        unlockedBagOfCoinsI.SetActive(true);
        BagUnlockedI.SetActive(true);
        startWithCoins = 75;
        boughtBagOfCoins1 = 1;
        PlayerPrefs.SetInt("SavedBoughtBag1", AscendScreen.boughtBagOfCoins1);
        AscendCoins.ascensionCoinAmount -= bag1Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }
    public void MoneyBagII()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        starWithCoinsAmount = 500;
        starWithCoinsText.text = LocalizationStrings.inflateStartWithCoinsStats + starWithCoinsAmount + LocalizationStrings.coinsAfterInflating;
        lockedUpgrade16.SetActive(false);
        unlockedBagOfCoinsII.SetActive(true);
        BagUnlockedII.SetActive(true);
        startWithCoins = 500;
        boughtBagOfCoins2 = 1;
        PlayerPrefs.SetInt("SavedBoughtBag2", AscendScreen.boughtBagOfCoins2);
        AscendCoins.ascensionCoinAmount -= bag2Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }
    public void MoneyBagIII()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        starWithCoinsAmount = 3000;
        starWithCoinsText.text = LocalizationStrings.inflateStartWithCoinsStats + starWithCoinsAmount + LocalizationStrings.coinsAfterInflating;
        lockedUpgrade17.SetActive(false);
        unlockedBagOfCoinsIII.SetActive(true);
        BagUnlockedIII.SetActive(true);
        startWithCoins = 3000;
        boughtBagOfCoins3 = 1;
        PlayerPrefs.SetInt("SavedBoughtBag3", AscendScreen.boughtBagOfCoins3);
        AscendCoins.ascensionCoinAmount -= bag3Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }
    public void MoneyBagIV()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        starWithCoinsAmount = 20000;
        starWithCoinsText.text = LocalizationStrings.inflateStartWithCoinsStats + starWithCoinsAmount + LocalizationStrings.coinsAfterInflating;
        lockedUpgrade18SUPER.SetActive(false);
        unlockedBagOfCoinsIV.SetActive(true);
        BagUnlockedIV.SetActive(true);
        startWithCoins = 20000;
        boughtBagOfCoins4 = 1;
        PlayerPrefs.SetInt("SavedBoughtBag4", AscendScreen.boughtBagOfCoins4);
        AscendCoins.ascensionCoinAmount -= bag4Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        lockedBagPile.SetActive(false);
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }
    public void MoneyBagV()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        starWithCoinsAmount = 100000;
        starWithCoinsText.text = LocalizationStrings.inflateStartWithCoinsStats + starWithCoinsAmount + LocalizationStrings.coinsAfterInflating;
        unlockedBagOfCoinsV.SetActive(true);
        BagUnlockedV.SetActive(true);
        startWithCoins = 100000;
        boughtBagOfCoinsSUPER = 1;
        PlayerPrefs.SetInt("SavedBoughtBagSUPER", AscendScreen.boughtBagOfCoinsSUPER);
        AscendCoins.ascensionCoinAmount -= bagSUPERCost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }


    public void PileBag()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        unlockedPileBag.SetActive(true);
        PileBagUnlocked.SetActive(true);
        boughtPileBag = 1;
        PlayerPrefs.SetInt("BoughtPileBag", AscendScreen.boughtPileBag);
        AscendCoins.ascensionCoinAmount -= bagPileCost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }

    //----------------------------------------------------------------------
    //AscendUpgrades
    //----------------------------------------------------------------------

    public void AscendUpgradeI()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        lockedUpgrade19.SetActive(false);
        unlockedAscendI.SetActive(true);
        ascendUnlocked1.SetActive(true);
        AscendCoins.quadrillionGet = 2;
        AscendCoins.quintillionGet = 2;
        AscendCoins.sextillionGet = 2;
        AscendCoins.septillionGet = 2;
        AscendCoins.octillionGet = 2;
        AscendCoins.nonillionGet = 2;
        AscendCoins.decillionGet = 2;
        AscendCoins.undecillionGet = 2;
        boughtGreaterAscension1 = 1;
        PlayerPrefs.SetInt("SavedGreaterAscension1", AscendScreen.boughtGreaterAscension1);
        AscendCoins.ascensionCoinAmount -= ascend1Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }

    public void AscendUpgradeII()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        lockedUpgrade20.SetActive(false);
        unlockedAscendII.SetActive(true);
        ascendUnlocked2.SetActive(true);
        AscendCoins.quadrillionGet = 3;
        AscendCoins.quintillionGet = 3;
        AscendCoins.sextillionGet = 3;
        AscendCoins.septillionGet = 3;
        AscendCoins.octillionGet = 3;
        AscendCoins.nonillionGet = 3;
        AscendCoins.decillionGet = 3;
        AscendCoins.undecillionGet = 3;
        boughtGreaterAscension2 = 1;
        PlayerPrefs.SetInt("SavedGreaterAscension2", AscendScreen.boughtGreaterAscension2);
        AscendCoins.ascensionCoinAmount -= ascend2Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }
    public void AscendUpgradeIII()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        lockedUpgrade21.SetActive(false);
        lockedUpgrade22.SetActive(false);
        lockedUpgrade23.SetActive(false);
        unlockedAscendIII.SetActive(true);
        ascendUnlocked3.SetActive(true);
        AscendCoins.billionGet = 2;
        AscendCoins.trillionGet = 2;
        AscendCoins.quadrillionGet = 3;
        AscendCoins.quintillionGet = 3;
        AscendCoins.sextillionGet = 3;
        AscendCoins.septillionGet = 3;
        AscendCoins.octillionGet = 3;
        AscendCoins.nonillionGet = 3;
        AscendCoins.decillionGet = 3;
        AscendCoins.undecillionGet = 3;
        boughtGreaterAscension3 = 1;
        PlayerPrefs.SetInt("SavedGreaterAscension3", AscendScreen.boughtGreaterAscension3);
        AscendCoins.ascensionCoinAmount -= ascend3Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }
    public void AscendUpgradeIV()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        ascendUnlocked4.SetActive(true);
        lockedUpgrade24.SetActive(false);
        lockedUpgrade25.SetActive(false);
        lockedUpgrade26.SetActive(false);
        unlockedAscendIV.SetActive(true);
        AscendCoins.trillionGet = 3;
        AscendCoins.quadrillionGet = 3;
        AscendCoins.quintillionGet = 4;
        AscendCoins.sextillionGet = 4;
        AscendCoins.septillionGet = 4;
        AscendCoins.octillionGet = 4;
        AscendCoins.nonillionGet = 4;
        AscendCoins.decillionGet = 4;
        AscendCoins.undecillionGet = 4;
        boughtGreaterAscension4 = 1;
        PlayerPrefs.SetInt("SavedGreaterAscension4", AscendScreen.boughtGreaterAscension4);
        AscendCoins.ascensionCoinAmount -= ascend4Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }
    public void AscendUpgradeV()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        ascendUnlocked5.SetActive(true);
        lockedUpgrade27SUPER.SetActive(false);
        unlockedAscendV.SetActive(true);
        AscendCoins.trillionGet = 4;
        AscendCoins.quadrillionGet = 4;
        AscendCoins.quintillionGet = 4;
        AscendCoins.sextillionGet = 5;
        AscendCoins.septillionGet = 5;
        AscendCoins.octillionGet = 5;
        AscendCoins.nonillionGet = 5;
        AscendCoins.decillionGet = 5;
        AscendCoins.undecillionGet = 5;
        boughtGreaterAscension5 = 1;
        PlayerPrefs.SetInt("SavedGreaterAscension5", AscendScreen.boughtGreaterAscension5);
        AscendCoins.ascensionCoinAmount -= ascend5Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }
    public void AscendUpgradeSUPER()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        ascendUnlocked6.SetActive(true);
        unlockedAscendSUPER.SetActive(true);
        AscendCoins.millionGet = 6;
        AscendCoins.billionGet = 6;
        AscendCoins.trillionGet = 6;
        AscendCoins.quadrillionGet = 6;
        AscendCoins.quintillionGet = 6;
        AscendCoins.sextillionGet = 6;
        AscendCoins.septillionGet = 6;
        AscendCoins.octillionGet = 6;
        AscendCoins.nonillionGet = 6;
        AscendCoins.decillionGet = 6;
        AscendCoins.undecillionGet = 6;
        boughtGreaterAscensionSUPER = 1;
        PlayerPrefs.SetInt("SavedGreaterAscensionSUPER", AscendScreen.boughtGreaterAscensionSUPER);
        AscendCoins.ascensionCoinAmount -= ascendSuperCost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }

    public void ascendPercentI()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        ascendUnlocked7.SetActive(true);
        unlockedAscendPercent1.SetActive(true);
        AscendCoins.extraAscendCoinsChance += 3;
        boughtGreaterAscensionGamble1 = 1;
        PlayerPrefs.SetInt("SavedGreaterAscensionGAMLE1", AscendScreen.boughtGreaterAscensionGamble1);
        AscendCoins.ascensionCoinAmount -= ascendGamble1Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }
    public void ascendPercentII()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        ascendUnlocked8.SetActive(true);
        unlockedAscendPercent2.SetActive(true);
        AscendCoins.extraAscendCoinsChance += 4;
        boughtGreaterAscensionGamble2 = 1;
        PlayerPrefs.SetInt("SavedGreaterAscensionGAMLE2", AscendScreen.boughtGreaterAscensionGamble2);
        AscendCoins.ascensionCoinAmount -= ascendGamble2Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }

    public void ascendPercentIII()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        ascendUnlocked9.SetActive(true);
        unlockedAscendPercent3.SetActive(true);
        AscendCoins.extraAscendCoinsChance += 5;
        boughtGreaterAscensionGamble3 = 1;
        PlayerPrefs.SetInt("SavedGreaterAscensionGAMLE3", AscendScreen.boughtGreaterAscensionGamble3);
        AscendCoins.ascensionCoinAmount -= ascendGamble3Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }

    public void ascendPercentVI()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        ascendUnlocked10.SetActive(true);
        unlockedAscendPercent4.SetActive(true);
        AscendCoins.extraAscendCoinsChance += 6;
        boughtGreaterAscensionGamble4 = 1;
        PlayerPrefs.SetInt("SavedGreaterAscensionGAMLE4", AscendScreen.boughtGreaterAscensionGamble4);
        AscendCoins.ascensionCoinAmount -= ascendGamble4Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }

    //----------------------------------------------------------------------
    //SpecialUpgrades
    //----------------------------------------------------------------------

    public static int morePileOfCoinsGain;
    public static int isGamblerPurchased = 0;
    public static int isSpecialUpgrade3Baugh = 0;

    public TextMeshProUGUI cheaperSpecialUpgradesCost;
    public static int totalSpecialReduction;
    public static int moreGambleChances;

    public static int specialUpgradesCheaperPercent;
    public void specialUpgradeAscendI()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        cheaperSpecialUpgradesCost.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflateSpecialCheaperStats + (totalSpecialReduction += 1) + LocalizationStrings.less;
        lockedUpgrade28.SetActive(false);
        unlockedSpecial1.SetActive(true);
        specialUnlocked1.SetActive(true);
        specialUpgradeCheaperPrice += 0.01f;
        moreGambleChances += 2;
        boughtSpecial1 = 1;
        PlayerPrefs.SetInt("SavedboughtSpecial1", AscendScreen.boughtSpecial1);
        AscendCoins.ascensionCoinAmount -= special1Price;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }

    public TextMeshProUGUI gambleWinText;
    public TextMeshProUGUI gambleLooseText;

    public void specialUpgradeAscendII()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        cheaperSpecialUpgradesCost.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflateSpecialCheaperStats + (totalSpecialReduction += 1) + LocalizationStrings.less;
        lockedUpgrade29.SetActive(false);
        lockedUpgrade30.SetActive(false);
        lockedUpgrade31.SetActive(false);
        unlockedSpecial2.SetActive(true);
        specialUnlocked2.SetActive(true);
        specialUpgradeCheaperPrice += 0.01f;
        PurchaseLog.gambleChanceEachTimeWIN += 1;
        PurchaseLog.gambleChanceEachTimeLOOSE -= 1;
        morePileOfCoinsGain += 2;
        gambleWinText.GetComponent<TextMeshProUGUI>().text = PurchaseLog.gambleChanceEachTimeWIN + LocalizationStrings.gambleWinChance;
        gambleLooseText.GetComponent<TextMeshProUGUI>().text = PurchaseLog.gambleChanceEachTimeLOOSE + LocalizationStrings.gambleLoseChance;
        boughtSpecial2 = 1;
        PlayerPrefs.SetInt("SavedboughtSpecial2", AscendScreen.boughtSpecial2);
        AscendCoins.ascensionCoinAmount -= special2Price;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }

    public void specialUpgradeAscendIII()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        cheaperSpecialUpgradesCost.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflateSpecialCheaperStats + (totalSpecialReduction += 1) + LocalizationStrings.less;
        lockedUpgrade32.SetActive(false);
        unlockedSpecial3.SetActive(true);
        specialUnlocked3.SetActive(true);
        lockedUpgradeSpecialSUPER.SetActive(false);
        specialUpgradeCheaperPrice += 0.01f;
        isSpecialUpgrade3Baugh = 1;
        boughtSpecial3 = 1;
        PlayerPrefs.SetInt("SavedboughtSpecial3", AscendScreen.boughtSpecial3);
        AscendCoins.ascensionCoinAmount -= special3Price;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        lockedAutoUpgrade.SetActive(false);
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }
   

    public static int specialFlipperCoinMultiplier;
    public static int specialFlipperCoinLuckyMultiplier;

    public void specialUpgradeAscendVSUPER()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        cheaperSpecialUpgradesCost.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflateSpecialCheaperStats + (totalSpecialReduction += 13) + LocalizationStrings.less;
       
        unlockedSpecial5.SetActive(true);
        specialUnlocked5.SetActive(true);
        specialUpgradeCheaperPrice += 0.13f;
        PileOfCoinsMechanics.isPile3Unlocked = 1;
        PileOfCoinsMechanics.isPile4Unlocked = 1;
        morePileOfCoinsGain += 7;
        moreGambleChances += 1;
        specialFlipperCoinMultiplier = 1;
        specialFlipperCoinLuckyMultiplier = 5;
        boughtSpecialSUPER = 1;
        PlayerPrefs.SetInt("SavedboughtSpecialSUPER", AscendScreen.boughtSpecialSUPER);
        AscendCoins.ascensionCoinAmount -= specialSuperPrice;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }
    public void specialUpgradeAscendUnieuqI()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        cheaperSpecialUpgradesCost.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflateSpecialCheaperStats + (totalSpecialReduction += 1) + LocalizationStrings.less;
        unlockedSpecial6.SetActive(true);
        specialUnlocked6.SetActive(true);
        PileOfCoinsMechanics.isPile2Unlocked = 1;
        morePileOfCoinsGain += 4;
        specialUpgradeCheaperPrice += 0.01f;
        boughtSpecialBIGGERPILE = 1;
        PlayerPrefs.SetInt("SavedboughtSpecialPILE", AscendScreen.boughtSpecialBIGGERPILE);
        AscendCoins.ascensionCoinAmount -= specialPilePrice;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;

        unlockedSpecial6.SetActive(true);
        specialUnlocked6.SetActive(true);
        lockedPile2.SetActive(false);
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }

    }

    public void specialUpgradeAscendUnieuqPile2()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        cheaperSpecialUpgradesCost.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflateSpecialCheaperStats + (totalSpecialReduction += 1) + LocalizationStrings.less;
        unlockedSpecialPile2.SetActive(true);
        specialPile2Unlocked.SetActive(true);
        PileOfCoinsMechanics.isPile5Unlocked = 1;
        morePileOfCoinsGain += 4;
        specialUpgradeCheaperPrice += 0.01f;
        boughtSpecialBIGGERPILE2 = 1;
        PlayerPrefs.SetInt("SavedboughtSpecialPILE2", AscendScreen.boughtSpecialBIGGERPILE2);
        AscendCoins.ascensionCoinAmount -= specialPile2Price;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }

    public void specialUpgradeAscendUnieuqII()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        cheaperSpecialUpgradesCost.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflateSpecialCheaperStats + (totalSpecialReduction += 1) + LocalizationStrings.less;
        unlockedSpecial7.SetActive(true);
        specialUnlocked7.SetActive(true);
        moreGambleChances += 1;
        isGamblerPurchased = 1;
        specialUpgradeCheaperPrice += 0.01f;
        boughtSpecialGAMBLEr = 1;
        PlayerPrefs.SetInt("SavedboughtSpecialGAMBLER", AscendScreen.boughtSpecialGAMBLEr);
        AscendCoins.ascensionCoinAmount -= specialGamblePrice;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }

    public static int hitEvenLuckerCoin;

    public void specialUpgradeAscendUnieuqIII()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        cheaperSpecialUpgradesCost.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflateSpecialCheaperStats + (totalSpecialReduction += 1) + LocalizationStrings.less;
        unlockedSpecial8.SetActive(true);
        specialUnlocked8.SetActive(true);
        specialUpgradeCheaperPrice += 0.01f;
        boughtSpecialLUCKER = 1;
        PlayerPrefs.SetInt("SavedboughtSpecialLUCKIER", AscendScreen.boughtSpecialLUCKER);
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }

    //----------------------------------------------------------------------
    //ActiveFlipper
    //----------------------------------------------------------------------

    public TextMeshProUGUI activeFlipperBonusText;
    public static int activeFlipperPercent;

    public void ActiveFlipperUpgradeI()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        activeFlipperPercent = 8;
        activeFlipperBonusText.text = LocalizationStrings.inflateActiveStats + activeFlipperPercent + LocalizationStrings.moreCoins;
        
        lockedUpgrade34.SetActive(false);
        unlockedActiveFlipper1.SetActive(true);
        activeUnlocked1.SetActive(true);
        activeFlipperMiltiplier = 0.08f;
        boughtActiveFlipper1 = 1;
        PlayerPrefs.SetInt("SavedBoughtActiveFlipper1", AscendScreen.boughtActiveFlipper1);
        AscendCoins.ascensionCoinAmount -= active1Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }
    public void ActiveFlipperUpgradeII()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        activeFlipperPercent = 23;
        activeFlipperBonusText.text = LocalizationStrings.inflateActiveStats + activeFlipperPercent + LocalizationStrings.moreCoins;
        lockedUpgrade35.SetActive(false);
        lockedUpgrade36.SetActive(false);
        unlockedActiveFlipper2.SetActive(true);
        activeUnlocked2.SetActive(true);
        activeFlipperMiltiplier = 0.23f;
        boughtActiveFlipper2 = 1;
        PlayerPrefs.SetInt("SavedBoughtActiveFlipper2", AscendScreen.boughtActiveFlipper2);
        AscendCoins.ascensionCoinAmount -= active2Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }
    public void ActiveFlipperUpgradeIII()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        activeFlipperPercent = 40;
        activeFlipperBonusText.text = LocalizationStrings.inflateActiveStats + activeFlipperPercent + LocalizationStrings.moreCoins;
        lockedUpgrade37.SetActive(false);
        unlockedActiveFlipper3.SetActive(true);
        activeUnlocked3.SetActive(true);
        activeFlipperMiltiplier = 0.40f;
        boughtActiveFlipper3 = 1;
        PlayerPrefs.SetInt("SavedBoughtActiveFlipper3", AscendScreen.boughtActiveFlipper3);
        AscendCoins.ascensionCoinAmount -= active3Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }
    public void ActiveFlipperUpgradeIV()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        activeFlipperPercent = 69;
        activeFlipperBonusText.text = LocalizationStrings.inflateActiveStats + activeFlipperPercent + LocalizationStrings.moreCoins;
        lockedUpgrade38SUPER.SetActive(false);
        unlockedActiveFlipper4.SetActive(true);
        activeUnlocked4.SetActive(true);
        activeFlipperMiltiplier = 0.69f;
        boughtActiveFlipper4 = 1;
        PlayerPrefs.SetInt("SavedBoughtActiveFlipper4", AscendScreen.boughtActiveFlipper4);
        AscendCoins.ascensionCoinAmount -= active4Cost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }
    public void ActiveFlipperUpgradeSUPER()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        luckyCoinMiltiplier = 5;
        ascendUpgradeAmount += 1;
        activeFlipperPercent = 300;
        activeFlipperBonusText.text = LocalizationStrings.inflateActiveStats + activeFlipperPercent + LocalizationStrings.moreCoins;
        unlockedActiveFlipper5.SetActive(true);
        activeUnlocked5.SetActive(true);
        activeFlipperMiltiplier = 3f;
        boughtActiveFlipperSUPER = 1;
        PlayerPrefs.SetInt("SavedBoughtActiveFlipperSUPER", AscendScreen.boughtActiveFlipperSUPER);
        AscendCoins.ascensionCoinAmount -= activeSUPERCost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }
    public static int isActivePilePurchased = 0;

    public void ActiveFlipperPileOfCoinsUpgrade()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        unlockedflipperPileOfCoins.SetActive(true);
        activePileOfCoinsUnlocked.SetActive(true);
        isActivePilePurchased = 1;
        boughtActiveFlipperPILOFCOINS = 1;
        PlayerPrefs.SetInt("SavedBoughtActiveFlipperPILEOFCOINS", AscendScreen.boughtActiveFlipperPILOFCOINS);
        AscendCoins.ascensionCoinAmount -= activePileCost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }

    public void AutoUpgrade()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (isFrameOpened == false) { return; }
        }

        PlayAudio();
        ascendUpgradeAmount += 1;
        unlockedAuto.SetActive(true);
        autoUnlocked.SetActive(true);
        blockedAuto.SetActive(false);
        boughtAuto = 1;
        PlayerPrefs.SetInt("BoughtAuto", AscendScreen.boughtAuto);
        AscendCoins.ascensionCoinAmount -= autoUpgradeCost;
        ascendScreenText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflationCoinsText + AscendCoins.ascensionCoinAmount;
        not21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        a21FlipperText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        clickedAscendText.GetComponent<TextMeshProUGUI>().text = "" + AscendCoins.ascensionCoinAmount;
        CheckInflationUpgradePriceColor();

        if (LoadSaves.isMobileBuild == true)
        {
            CloseFrame();
        }
    }
}
