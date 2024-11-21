using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
public class SaveSystem : MonoBehaviour
{
    public bool saveGame = false;
    public string savedCoins;
    public int sacedChoseHeads;
    public GameObject savedGamePopUp;
    public GameObject savedGamePopUp2;
    public GoldenFlipsButton goldenFlipsScript;

    public void Start()
    {
        saveGame = false;
        StartCoroutine(GameLoadedIn());
    }

    public void Update()
    {
        if (saveGame == false)
        {
            saveGame = true;
            StartCoroutine(SaveTheGame30Seconds());
        }
    }

    public bool isGameLoaded;
    IEnumerator GameLoadedIn()
    {
        yield return new WaitForSeconds(3);
        isGameLoaded = true;
    }

    IEnumerator SaveTheGame30Seconds()
    {
        yield return new WaitForSeconds(1);
        SaveEverything();
        StartCoroutine(SaveGame());
        savedGamePopUp.SetActive(true);

        yield return new WaitForSeconds(2);

        savedGamePopUp.SetActive(false);
        if(LoadSaves.isMobileBuild == false) { yield return new WaitForSeconds(27); }
        if (LoadSaves.isMobileBuild == true) { yield return new WaitForSeconds(7); }
        saveGame = false;
    }

    public void ChooseToNotReset()
    {
        choose.SetActive(false);
    }

    #region Variables
    public GameObject choose;
    public GameObject menu;
    public GameObject HeadsOrTails;
    public GameObject flipper1;
    public GameObject chooseHOTtext;
    public GameObject coin1Avhievement;
    public GameObject coin10Avhievement;
    public GameObject coin100Avhievement;
    public GameObject coin1000Avhievement;
    public GameObject coin10000Avhievement;
    public GameObject coin100000Avhievement;
    public GameObject coin1000000Avhievement;
    public GameObject coin1000000000Avhievement;
    public GameObject coinTrillionAvhievement;
    public GameObject coinQuadrillionAvhievement;
    public GameObject coinQuintillionAvhievement;
    public GameObject coinTSextillionAvhievement;

    public TextMeshProUGUI ascendCoinsText;
    public TextMeshProUGUI ascendCoinsTextNot21Flippers;

    public TextMeshProUGUI resetRichStats;
    public TextMeshProUGUI resetCheaperUpgradeStats;
    public TextMeshProUGUI resetCheaperSpecialUpgradeStats;
    public TextMeshProUGUI resetStarWithCoinsStats;
    public TextMeshProUGUI resetActiveStats;
    public TextMeshProUGUI resetamountOfTimesClickedOnPile;
    public TextMeshProUGUI gambledTimes;
    public TextMeshProUGUI gambledTimesWon;
    public TextMeshProUGUI gambledTimesLost;
    public TextMeshProUGUI timesClikedOnPile;

    public TextMeshProUGUI strongerArmsText;
    public TextMeshProUGUI greaterCoinText;
    public TextMeshProUGUI knowlegdeText;
    public TextMeshProUGUI strongerFistText;
    public TextMeshProUGUI handInjectionText;
    public TextMeshProUGUI brainPowerText;
    public TextMeshProUGUI explosiveFlipsText;
    public TextMeshProUGUI hydrationText;
    public TextMeshProUGUI strangePotionText;
    public TextMeshProUGUI masterFlipperText;
    public TextMeshProUGUI handShakeCoinText;
    public TextMeshProUGUI highFiveCoinText;
    public TextMeshProUGUI magicStats;

    public TextMeshProUGUI strongerHandsCount;
    public TextMeshProUGUI greaterCoinsCount;
    public TextMeshProUGUI knowledgeCount;
    public TextMeshProUGUI strongerFistCount;
    public TextMeshProUGUI handInjectionCount;
    public TextMeshProUGUI brainPowerCount;
    public TextMeshProUGUI explosiveFlipsCount;
    public TextMeshProUGUI hydrationCount;
    public TextMeshProUGUI potionCount;
    public TextMeshProUGUI masterFlipperCount;
    public TextMeshProUGUI handShakeCount;
    public TextMeshProUGUI highFiveCount;
    public TextMeshProUGUI wizardCount;

    public Achievements ach1Script;
    public AchievementsUpdate ach2Script;
    public AutoUpgrade autoScript;
    public Challenges challScript;
    public MainButtonClick mainScript;
    public PileOfCoinsMechanics pileOfCoinsScript;
    public AscendScreen ascendScreenScript;
    public ManualClicking manualClickingScript;
    public Ascend ascendScript;

    public GameObject pileToolTip, pileToolTip2, pileToolTip3, pileToolTip4, pileToolTip5, pileClose, pileCollect, achClose, upgradeTooltipClose, need21FlipperTooltip, need21View, need21Close, acendScreen, achBlack, upgradeBlack, dark21Flipper, prestifeInfo, prestigeInfoClose, challInfo, challInfoClose, prestigeBtns,blackFrameChall;

    public GameObject autoUpgradeBlackFrame;
    public GameObject closeAutoBtn;

    public GameObject[] all24Tooltips;

    public AchTooltipOpen achTooltipScript;
    #endregion


    #region Reset everything
    public void ResetEverything()
    {
        autoUpgradeBlackFrame.SetActive(false);
        closeAutoBtn.SetActive(false);
        blackFrameChall.SetActive(false);
        prestigeBtns.SetActive(false);
        prestifeInfo.SetActive(false); prestigeInfoClose.SetActive(false); challInfo.SetActive(false); challInfoClose.SetActive(false);
        ascendScreenScript.ResetPrestigeTooltips();
        achTooltipScript.ResetAchTooltip();
        pileToolTip.SetActive(false);
        pileToolTip2.SetActive(false);
        pileToolTip3.SetActive(false);
        pileToolTip4.SetActive(false);
        pileToolTip5.SetActive(false);
        pileClose.SetActive(false);
        pileCollect.SetActive(false);
        achClose.SetActive(false);
        upgradeTooltipClose.SetActive(false);
        need21FlipperTooltip.SetActive(false);
        need21View.SetActive(false);
        need21Close.SetActive(false);
        acendScreen.SetActive(false);
        achBlack.SetActive(false);
        upgradeBlack.SetActive(false);
        dark21Flipper.SetActive(false);

        for (int i = 0; i < 24; i++)
        {
            all24Tooltips[i].SetActive(false);
        }

        EndlessInflation.endlessInflationCostEqualsBonus = 0;
        EndlessInflation.englessInflationBonusText = 0;
        EndlessInflation.inflationUpgadeCount = 0;
        EndlessInflation.endlessInflationPrice = 1;
        EndlessInflation.endlessInflationBonus = 0;
        MainButtonClick.activeFlipsAmount = 0;
        MainButtonClick.chall3CompletedBonus = 0;
        Challenges.chall3Bonus = 0;
        timesClikedOnPile.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.clickedPile + "0" + LocalizationStrings.times;
        gambledTimes.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.youGambled + "0" + LocalizationStrings.times;
        gambledTimesWon.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.wonGambling + "0" + LocalizationStrings.times;
        gambledTimesLost.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.lostGambling + "0" + LocalizationStrings.times;
        resetamountOfTimesClickedOnPile.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.clickedPile + "0" + LocalizationStrings.times;
        resetRichStats.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflateUpgradesStats + "0" + LocalizationStrings.moreCoins;
        resetCheaperUpgradeStats.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflateCheaperStats + "0" + LocalizationStrings.cheaper;
        resetCheaperSpecialUpgradeStats.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflateSpecialCheaperStats + "0" + LocalizationStrings.less;
        resetStarWithCoinsStats.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflateStartWithCoinsStats + "0" + LocalizationStrings.coinsAfterInflating;
        resetActiveStats.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.inflateActiveStats + "0" + LocalizationStrings.moreCoins;

        strongerArmsText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.buyUpgrade;
        greaterCoinText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.buyUpgrade;
        knowlegdeText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.buyUpgrade;
        strongerFistText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.buyUpgrade;
        handInjectionText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.buyUpgrade;
        brainPowerText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.buyUpgrade;
        explosiveFlipsText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.buyUpgrade;
        hydrationText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.buyUpgrade;
        strangePotionText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.buyUpgrade;
        masterFlipperText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.buyUpgrade;
        handShakeCoinText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.buyUpgrade;
        highFiveCoinText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.buyUpgrade;
        magicStats.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.buyUpgrade;

        ascendCoinsText.GetComponent<TextMeshProUGUI>().text = "0";
        ascendCoinsTextNot21Flippers.GetComponent<TextMeshProUGUI>().text = "0";
        coin1Avhievement.SetActive(false);
        coin10Avhievement.SetActive(false);
        coin100Avhievement.SetActive(false);
        coin1000Avhievement.SetActive(false);
        coin10000Avhievement.SetActive(false);
        coin100000Avhievement.SetActive(false);
        coin1000000Avhievement.SetActive(false);
        coin1000000000Avhievement.SetActive(false);
        coinTrillionAvhievement.SetActive(false);
        coinQuadrillionAvhievement.SetActive(false);
        coinQuintillionAvhievement.SetActive(false);
        coinTSextillionAvhievement.SetActive(false);
        chooseHOTtext.SetActive(true);
        flipper1.SetActive(true);
        HeadsOrTails.SetActive(true);
        menu.SetActive(false);
        choose.SetActive(false);
        GlobalCoins.CoinCount = 0;
        EnterText.choseHeads = 0;
        EnterText.choseTails = 0;

        MainButtonClick.coinsPerClick = 0;

        MoreCoinsButton.moreCoinsUpgrades = 0;
        MoreCoinsButton.moreCoinClickValue = 5;
        MoreCoinsButton.greaterCoinsCount = 0;
        MoreCoinsButton.greaterCoinsCost = 125;
        KnowledgeUpgrade.knowledgeUpgradeCount = 0;
        KnowledgeUpgrade.knowledgeClickValue = 2150;
        StrongerFist.fistUpgradeCount = 0;
        StrongerFist.fistCost = 60000;
        HandInecjtion.injectionUpgradeCount = 0;
        HandInecjtion.injectionCost = 875000;
        BrainPower.brainPowerUpgradeCount = 0;
        BrainPower.brainPowerCost = 85000000;
        ExplosiveFlips.explosiveUpgradeCount = 0;
        ExplosiveFlips.explosiveCost = 1200000000;
        HydrationButton.hydrationUpgradeCount = 0;
        HydrationButton.hydrationVost = 625000000000;
        StrangePotion.potionUpgradeCount = 0;
        StrangePotion.potionCost = 41000000000000;
        MasterFlipper.MasterFlipsUpgradeCount = 0;
        MasterFlipper.MasterFlipsCost = 2100000000000000;
        HandShake.handShakeUpgradeCount = 0;
        HandShake.handshakeCost = 30000000000000000;
        Upgrade12.upgrade12Count = 0;
        Upgrade12.upgrade12Cost = 930000000000000000;

        higherChanceHoverover.tailsPercent = 49.75f;
        higherChanceHoverover.headsPercent = 49.75f;
        MainButtonClick.higherCoinChance = 100;
        MainButtonClick.lowerCoinChance = 101;
        MainButtonClick.lowSpecialChance = 1;
        PileOfCoinsMechanics.waitTime = 75;

        GlobalCoinMaker.coinsPerFlipUpgrades = 0;
        GlobalCoinMaker.coinValue = 350;
        PurchaseLog.higherChanceUpgradeCount = 0;
        HigherChance.higherChanceValue = 150000;
        PurchaseLog.luckyCoinHigherChanceCount = 0;
        LuckyCoinChance.luckyCoinValue = 175000000;
        GoldenFlipsButton.goldenCoinsUpgradeCount = 0;
        GOLDENFLIPS.specialCoinsButtonCost = 35000000;
        MainButtonClick.numberOfDuplicationUpgrades = 0;
        DuplicateCoin.duplicatePrice = 75;
        GetLuckyHoverOver.luckyChance = 0.5f;
        PileOfCoins.pileOfCoinsCost = 10000;
        PurchaseLog.gambleChances = 5;
        PurchaseLog.gambleChanceEachTimeWIN = 50;
        PurchaseLog.gambleChanceEachTimeLOOSE = 50;
        AscendScreen.moreGambleChances = 0;

        StatsAll.flippedAmount = 0;
        StatsAll.headsFlippedAmount = 0;
        StatsAll.tailsFlippedAmount = 0;
        StatsAll.luckyCoinsAmount = 0;

        PurchaseLog.strongerHandsTextInfo = 0;
        PurchaseLog.greaterTextInfo = 0;
        PurchaseLog.knowledgeInfo = 0;
        PurchaseLog.fistInfo = 0;
        PurchaseLog.injectionInfo = 0;
        PurchaseLog.brainPowerInfo = 0;
        PurchaseLog.explosiveInfo = 0;
        PurchaseLog.hydrationInfo = 0;
        PurchaseLog.potionInfo = 0;
        PurchaseLog.masterFlipperInfo = 0;
        PurchaseLog.handShakeInfo = 0;
        PurchaseLog.upgrade12Info = 0;
        PurchaseLog.magicFlipsInfo = 0;
        PurchaseLog.amountOfTimesGambled = 0;
        PurchaseLog.amountOfTimesGambledWON = 0;
        PurchaseLog.amountOfTimesGambledLOST = 0;

        SpecialAuto1.flipAuto = 0;
        SpecialAuto2.flipAuto = 0;
        SpecialAuto3.flipAuto = 0;
        SpecialAuto4.flipAuto = 0;
        SpecialAuto5.flipAuto = 0;
        SpecialAuto6.flipAuto = 0;
        SpecialAuto7.flipAuto = 0;
        SpecialAuto8.flipAuto = 0;
        SpecialAuto9.flipAuto = 0;
        SpecialAuto10.flipAuto = 0;
        SpecialAuto11.flipAuto = 0;
        SpecialAuto12.flipAuto = 0;
        SpecialAuto13.flipAuto = 0;
        SpecialAuto14.flipAuto = 0;
        SpecialAuto15.flipAuto = 0;
        SpecialAuto16.flipAuto = 0;
        SpecialAuto17.flipAuto = 0;
        SpecialAuto18.flipAuto = 0;
        SpecialAuto19.flipAuto = 0;
        SpecialAuto20.flipAuto = 0;
        SpecialAuto21.flipAuto = 0;

        AutoCoin.ascendedAuto1 = 0;
        AutoCoin2.ascendedAuto2 = 0;
        AutoCoin3.ascendedAuto3 = 0;
        AutoCoin4.ascendedAuto4 = 0;
        AutoCoin5.ascendedAuto5 = 0;
        AutoCoin6.ascendedAuto6 = 0;
        AutoCoin7.ascendedAuto7 = 0;
        AutoCoin8.ascendedAuto8 = 0;
        AutoCoin9.ascendedAuto9 = 0;
        AutoCoin10.ascendedAuto10 = 0;
        AutoCoin11.ascendedAuto11 = 0;
        AutoCoin12.ascendedAuto12 = 0;
        AutoCoin13.ascendedAuto13 = 0;
        AutoCoin14.ascendedAuto14 = 0;
        AutoCoin15.ascendedAuto15 = 0;
        AutoCoin16.ascendedAuto17 = 0;
        AutoCoin17.ascendedAuto16 = 0;
        AutoCoin18.ascendedAuto19 = 0;
        AutoCoin19.ascendedAuto18 = 0;
        AutoCoin20.ascendedAuto20 = 0;
        AutoCoin21.ascendedAuto21 = 0;

        AscendCoins.ascensionCoinAmount = 0;
        AscendCoins.luckyAscendCoin = 0;
        AscendCoins.extraAscendCoinsChance = 0;

        AscendScreen.startWithCoins = 0;
        AscendScreen.cheaperPrice = 0;
        AscendScreen.coinMulitplier = 0  ;
        AscendScreen.specialUpgradeCheaperPrice = 0;
        AscendScreen.luckyCoinMiltiplier = 0;
        AscendScreen.activeFlipperMiltiplier = 0;
        AscendScreen.morePileOfCoinsGain = 0;
        AscendScreen.isGamblerPurchased = 0;
        AscendScreen.isSpecialUpgrade3Baugh = 0;
        AscendScreen.specialFlipperCoinMultiplier = 0;
        AscendScreen.specialFlipperCoinLuckyMultiplier = 0;
        AscendScreen.ascendUpgradeAmount = 0;

        PileOfCoinsMechanics.isPile1Unlocked = 0;
        PileOfCoinsMechanics.isPile2Unlocked = 0;
        PileOfCoinsMechanics.isPile3Unlocked = 0;
        PileOfCoinsMechanics.isPile4Unlocked = 0;
        PileOfCoinsMechanics.isPile5Unlocked = 0;
        PileOfCoinsMechanics.PileOfCoinsAmount1 = 0;
        PileOfCoinsMechanics.PileOfCoinsAmount2 = 0;
        PileOfCoinsMechanics.PileOfCoinsAmount3 = 0;
        PileOfCoinsMechanics.PileOfCoinsAmount4 = 0;
        PileOfCoinsMechanics.PileOfCoinsAmount5 = 0;
        PileOfCoinsMechanics.PileOfCounsBoughtFirstTime = 0;

        AscendScreen.boughtRich1 = 0;
        AscendScreen.boughtRich2 = 0;
        AscendScreen.boughtRich3 = 0;
        AscendScreen.boughtRich4 = 0;
        AscendScreen.boughtRich5 = 0;
        AscendScreen.boughtRich6 = 0;
        AscendScreen.boughtRichSUPER = 0;
        AscendScreen.boughtSale1 = 0;
        AscendScreen.boughtSale2 = 0;
        AscendScreen.boughtSale3 = 0;
        AscendScreen.boughtSale4 = 0;
        AscendScreen.boughtSTEAMSALE = 0;
        AscendScreen.boughtActiveFlipper1 = 0;
        AscendScreen.boughtActiveFlipper2 = 0;
        AscendScreen.boughtActiveFlipper3 = 0;
        AscendScreen.boughtActiveFlipper4 = 0;
        AscendScreen.boughtActiveFlipperSUPER = 0;
        AscendScreen.boughtActiveFlipperPILOFCOINS = 0 ;
        AscendScreen.boughtBagOfCoins1 = 0;
        AscendScreen.boughtBagOfCoins2 = 0;
        AscendScreen.boughtBagOfCoins3 = 0;
        AscendScreen.boughtBagOfCoins4 = 0;
        AscendScreen.boughtBagOfCoinsSUPER = 0;
        AscendScreen.boughtSpecial1 = 0;
        AscendScreen.boughtSpecial2 = 0;
        AscendScreen.boughtSpecial3 = 0;
        AscendScreen.boughtSpecial4 = 0;
        AscendScreen.boughtSpecialSUPER = 0;
        AscendScreen.boughtSpecialGAMBLEr = 0;
        AscendScreen.boughtSpecialBIGGERPILE = 0;
        AscendScreen.boughtSpecialBIGGERPILE2 = 0;
        AscendScreen.boughtSpecialLUCKER = 0;
        AscendScreen.boughtGreaterAscension1 = 0;
        AscendScreen.boughtGreaterAscension2 = 0;
        AscendScreen.boughtGreaterAscension3 = 0;
        AscendScreen.boughtGreaterAscension4 = 0;
        AscendScreen.boughtGreaterAscension5 = 0;
        AscendScreen.boughtGreaterAscensionSUPER = 0;
        AscendScreen.boughtGreaterAscensionGamble1 = 0;
        AscendScreen.boughtGreaterAscensionGamble2 = 0;
        AscendScreen.boughtGreaterAscensionGamble3 = 0;
        AscendScreen.boughtGreaterAscensionGamble4 = 0;
        AscendScreen.totalSpecialReduction = 0;
        PileOfCoinsMechanics.totalAmountOfPileGenerated = 0;
        AscendScreen.isActivePilePurchased = 0;
        AscendScreen.hitEvenLuckerCoin = 0;
        PileOfCoinsMechanics.incrementPileOfCoinsAmount = 0;
        Ascend.AscendTimesAmount = 0;
        hiddenCoins.foundBronce = 0;
        hiddenCoins.foundSilver = 0;

        Achievements.ACH1IsUnlocked = 0;
        Achievements.ACH2IsUnlocked = 0;
        Achievements.ACH3IsUnlocked = 0;
        Achievements.ACH4IsUnlocked = 0;
        Achievements.ACH5IsUnlocked = 0;
        Achievements.ACH6IsUnlocked = 0;
        Achievements.ACH7IsUnlocked = 0;
        Achievements.ACH8IsUnlocked = 0;
        Achievements.ACH9IsUnlocked = 0;
        Achievements.ACH10IsUnlocked = 0;
        Achievements.ACH11IsUnlocked = 0;
        Achievements.ACH12IsUnlocked = 0;
        Achievements.ACH13IsUnlocked = 0;
        Achievements.ACH14IsUnlocked = 0;
        Achievements.ACH15IsUnlocked = 0;
        Achievements.ACH16IsUnlocked = 0;
        Achievements.ACH17IsUnlocked = 0;
        Achievements.ACH18IsUnlocked = 0;
        Achievements.ACH19IsUnlocked = 0;
        Achievements.ACH20IsUnlocked = 0;
        Achievements.ACH21IsUnlocked = 0;
        Achievements.ACH22IsUnlocked = 0;
        Achievements.ACH23IsUnlocked = 0;
        Achievements.ACH24IsUnlocked = 0;
        Achievements.ACH25IsUnlocked = 0;
        Achievements.ACH26IsUnlocked = 0;
        Achievements.ACH27IsUnlocked = 0;
        Achievements.ACH28IsUnlocked = 0;
        Achievements.ACH29IsUnlocked = 0;
        Achievements.ACH30IsUnlocked = 0;
        Achievements.ACH31IsUnlocked = 0;
        Achievements.ACH32IsUnlocked = 0;
        Achievements.ACH33IsUnlocked = 0;
        Achievements.ACH34IsUnlocked = 0;
        Achievements.ACH35IsUnlocked = 0;
        Achievements.ACH36IsUnlocked = 0;
        Achievements.ACH37IsUnlocked = 0;
        Achievements.ACH38IsUnlocked = 0;
        Achievements.ACH39IsUnlocked = 0;
        Achievements.ACH40IsUnlocked = 0;
        Achievements.ACH41IsUnlocked = 0;
        Achievements.ACH42IsUnlocked = 0;
        Achievements.ACH43IsUnlocked = 0;
        Achievements.ACH44IsUnlocked = 0;
        Achievements.ACH45IsUnlocked = 0;
        Achievements.ACH46IsUnlocked = 0;
        Achievements.ACH47IsUnlocked = 0;
        Achievements.ACH48IsUnlocked = 0;
        Achievements.ACH49IsUnlocked = 0;
        Achievements.ACH50IsUnlocked = 0;
        Achievements.ACH51IsUnlocked = 0;
        Achievements.ACH52IsUnlocked = 0;
        Achievements.ACH53IsUnlocked = 0;
        Achievements.ACH54IsUnlocked = 0;
        Achievements.ACH55IsUnlocked = 0;
        Achievements.ACH56IsUnlocked = 0;
        Achievements.ACH57IsUnlocked = 0;
        Achievements.ACH58IsUnlocked = 0;
        Achievements.ACH59IsUnlocked = 0;
        Achievements.ACH60IsUnlocked = 0;
        Achievements.ACH61IsUnlocked = 0;
        Achievements.ACH62IsUnlocked = 0;

        AchievementsUpdate.ACH1IsUnlocked = 0;
        AchievementsUpdate.ACH2IsUnlocked = 0;
        AchievementsUpdate.ACH3IsUnlocked = 0;
        AchievementsUpdate.ACH4IsUnlocked = 0;
        AchievementsUpdate.ACH5IsUnlocked = 0;
        AchievementsUpdate.ACH6IsUnlocked = 0;
        AchievementsUpdate.ACH7IsUnlocked = 0;
        AchievementsUpdate.ACH8IsUnlocked = 0;
        AchievementsUpdate.ACH9IsUnlocked = 0;
        AchievementsUpdate.ACH10IsUnlocked = 0;
        AchievementsUpdate.ACH11IsUnlocked = 0;
        AchievementsUpdate.ACH12IsUnlocked = 0;
        AchievementsUpdate.ACH13IsUnlocked = 0;
        AchievementsUpdate.ACH14IsUnlocked = 0;
        AchievementsUpdate.ACH15IsUnlocked = 0;
        AchievementsUpdate.ACH16IsUnlocked = 0;
        AchievementsUpdate.ACH17IsUnlocked = 0;
        AchievementsUpdate.ACH18IsUnlocked = 0;
        AchievementsUpdate.ACH19IsUnlocked = 0;
        AchievementsUpdate.ACH20IsUnlocked = 0;

        ach1Script.ResetAch();
        ach2Script.ResetAch();
        autoScript.CheckBlockUpgrades();

        strongerHandsCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + MoreCoinsButton.moreCoinsUpgrades;
        greaterCoinsCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + MoreCoinsButton.greaterCoinsCount;
        knowledgeCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + KnowledgeUpgrade.knowledgeUpgradeCount;
        strongerFistCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + StrongerFist.fistUpgradeCount;
        handInjectionCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + HandInecjtion.injectionUpgradeCount;
        brainPowerCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + BrainPower.brainPowerUpgradeCount;
        explosiveFlipsCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + ExplosiveFlips.explosiveUpgradeCount;
        hydrationCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + HydrationButton.hydrationUpgradeCount;
        potionCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + StrangePotion.potionUpgradeCount;
        masterFlipperCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + MasterFlipper.MasterFlipsUpgradeCount;
        handShakeCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + HandShake.handShakeUpgradeCount;
        highFiveCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + Upgrade12.upgrade12Count;
        wizardCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + MagicFlipsUpgrade.magicUpgradeCount;

        //1.2Update

        Challenges.isChallenge1Active = 0;
        Challenges.isChallenge2Active = 0;
        Challenges.isChallenge3Active = 0;
        Challenges.isChallenge4Active = 0;
        Challenges.completedChallenge1 = 0;
        Challenges.completedChallenge2 = 0;
        Challenges.completedChallenge3 = 0;
        Challenges.completedChallenge4 = 0;

        AscendScreen.boughtAuto = 0;
        AscendScreen.boughtRich1250 = 0;
        AscendScreen.boughtPileBag = 0;
        AscendScreen.boughtSpecialBIGGERPILE2 = 0;

        TreasureChest.treasureCost = 0;

        StartCoroutine(SaveGame());
        StartCoroutine(Waiting());
        challScript.SetCompleteIcon();
        challScript.ResetChall();
        mainScript.SetMuteFlipper();
        pileOfCoinsScript.SetPileOfCoins();
        goldenFlipsScript.SetPosAndScale();
        ascendScreenScript.CheckSetText();
        manualClickingScript.SetTurnOffBack();
        ascendScript.quitChallengesYes();
        ResetSave();
        SaveEverything();
    }
    #endregion

    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(2f);

        StatsAll.flippedAmount = 0;
        StatsAll.headsFlippedAmount = 0;
        StatsAll.tailsFlippedAmount = 0;
        StatsAll.luckyCoinsAmount = 0;
    }

    public void SaveTheGame()
    {
        StartCoroutine(SaveGame());
        SaveEverything();
        savedGamePopUp2.SetActive(true);
    }

    public void SaveEverything()
    {
        PlayerPrefs.SetString("LoginOffline", DateTime.Now.ToString());
        
        PlayerPrefs.SetFloat("SaveGlobalCoins", GlobalCoins.CoinCount);
        PlayerPrefs.SetFloat("SavedCoinsPerFlipAmount", MainButtonClick.coinsPerClick); //2

        PlayerPrefs.SetInt("SavedNumberOfAutoFlips", GlobalCoinMaker.coinsPerFlipUpgrades);
        PlayerPrefs.SetFloat("AutoCost", GlobalCoinMaker.coinValue);
        PlayerPrefs.SetInt("StrongerArmsCount", MoreCoinsButton.moreCoinsUpgrades);
        PlayerPrefs.SetFloat("StrongerArmsCost", MoreCoinsButton.moreCoinClickValue);
        PlayerPrefs.SetInt("GreaterCoinsCount", MoreCoinsButton.greaterCoinsCount);
        PlayerPrefs.SetFloat("GreaterCoinsCost", MoreCoinsButton.greaterCoinsCost);
        PlayerPrefs.SetInt("KnowledgeCount", KnowledgeUpgrade.knowledgeUpgradeCount);
        PlayerPrefs.SetFloat("KnowledgeCost", KnowledgeUpgrade.knowledgeClickValue);
        PlayerPrefs.SetInt("StrongerFistCount", StrongerFist.fistUpgradeCount);
        PlayerPrefs.SetFloat("StrongerFistCost", StrongerFist.fistCost);
        PlayerPrefs.SetInt("HandInjectionCount", HandInecjtion.injectionUpgradeCount);
        PlayerPrefs.SetFloat("HandInjectionCost", HandInecjtion.injectionCost);
        PlayerPrefs.SetInt("BrainPowerCount", BrainPower.brainPowerUpgradeCount);
        PlayerPrefs.SetFloat("BrainPowerCost", BrainPower.brainPowerCost);
        PlayerPrefs.SetInt("ExplosiveCount", ExplosiveFlips.explosiveUpgradeCount);
        PlayerPrefs.SetFloat("ExplosiveCost", ExplosiveFlips.explosiveCost);
        PlayerPrefs.SetInt("HydrationCount", HydrationButton.hydrationUpgradeCount);
        PlayerPrefs.SetFloat("HydrationCost", HydrationButton.hydrationVost);
        PlayerPrefs.SetInt("PotionCount", StrangePotion.potionUpgradeCount);
        PlayerPrefs.SetFloat("PotionCost", StrangePotion.potionCost);
        PlayerPrefs.SetInt("MasterFlipperCount", MasterFlipper.MasterFlipsUpgradeCount);
        PlayerPrefs.SetFloat("MasterFlipperCost", MasterFlipper.MasterFlipsCost);
        PlayerPrefs.SetInt("HandShakeCount", HandShake.handShakeUpgradeCount);
        PlayerPrefs.SetFloat("HandShakeCost", HandShake.handshakeCost); //22
        PlayerPrefs.SetInt("Upgrade12Count", Upgrade12.upgrade12Count);
        PlayerPrefs.SetFloat("Upgrade12Cost", Upgrade12.upgrade12Cost);
        PlayerPrefs.SetInt("MagicCount", MagicFlipsUpgrade.magicUpgradeCount); //Magic
        PlayerPrefs.SetFloat("MagicCost", MagicFlipsUpgrade.magicUpgradeCost); //Magic

        PlayerPrefs.SetInt("SavedChoseHeads", EnterText.choseHeads);
        PlayerPrefs.SetInt("SavedChoseTails", EnterText.choseTails);

        PlayerPrefs.SetInt("HigherChanceCount", PurchaseLog.higherChanceUpgradeCount);
        PlayerPrefs.SetFloat("HigherChanceCost", HigherChance.higherChanceValue);
        PlayerPrefs.SetInt("LuckyCoinCount", PurchaseLog.luckyCoinHigherChanceCount);
        PlayerPrefs.SetFloat("LuckyCoinCost", LuckyCoinChance.luckyCoinValue);
        PlayerPrefs.SetInt("GoldenFlipsCount", GoldenFlipsButton.goldenCoinsUpgradeCount);
        PlayerPrefs.SetFloat("GoldenFlipsCost", GOLDENFLIPS.specialCoinsButtonCost); //8

        PlayerPrefs.SetFloat("SavetailsPercent", higherChanceHoverover.tailsPercent);
        PlayerPrefs.SetFloat("SaveHeadsPercent", higherChanceHoverover.headsPercent);
        PlayerPrefs.SetFloat("SaveLuckyPercent", GetLuckyHoverOver.luckyChance);
        PlayerPrefs.SetInt("SavehigherCoinsChance", MainButtonClick.higherCoinChance);
        PlayerPrefs.SetInt("SavelowerCoinsChance", MainButtonClick.lowerCoinChance);
        PlayerPrefs.SetInt("SaveLuckyChance", MainButtonClick.lowSpecialChance); //6

        PlayerPrefs.SetInt("SavedChoseHeads", EnterText.choseHeads);
        PlayerPrefs.SetInt("SavedChoseTails", EnterText.choseTails); //2

        PlayerPrefs.SetInt("SavedNumberOfCoinFlips", MainButtonClick.numberOfDuplicationUpgrades);
        PlayerPrefs.SetFloat("SavedDuplicateCost", DuplicateCoin.duplicatePrice); //2

        PlayerPrefs.SetFloat("SavedNumberOfflips", StatsAll.flippedAmount);
        PlayerPrefs.SetFloat("SavedHeadsFlips", StatsAll.headsFlippedAmount);
        PlayerPrefs.SetFloat("SavedTailsFlips", StatsAll.tailsFlippedAmount);
        PlayerPrefs.SetFloat("SavedLuckyFlips", StatsAll.luckyCoinsAmount);
        PlayerPrefs.SetFloat("SavedStrongerHandInfo", PurchaseLog.strongerHandsTextInfo);
        PlayerPrefs.SetFloat("SavedGreaterCoinInfo", PurchaseLog.greaterTextInfo);
        PlayerPrefs.SetFloat("SavedKnowledgefo", PurchaseLog.knowledgeInfo);
        PlayerPrefs.SetFloat("SavedFistInfo", PurchaseLog.fistInfo);
        PlayerPrefs.SetFloat("SavedInjectionInfo", PurchaseLog.injectionInfo);
        PlayerPrefs.SetFloat("SavedBrainPowerInfo", PurchaseLog.brainPowerInfo);
        PlayerPrefs.SetFloat("SavedExplosionInfo", PurchaseLog.explosiveInfo);
        PlayerPrefs.SetFloat("SavedHydration", PurchaseLog.hydrationInfo);
        PlayerPrefs.SetFloat("SavedPotionInfo", PurchaseLog.potionInfo);
        PlayerPrefs.SetFloat("SavedMasterFlipperInfo", PurchaseLog.masterFlipperInfo);
        PlayerPrefs.SetFloat("SavedHandShake", PurchaseLog.handShakeInfo); //15
        PlayerPrefs.SetFloat("SavedUpgrade12", PurchaseLog.upgrade12Info);
        PlayerPrefs.SetFloat("SavedMagicFlips", PurchaseLog.magicFlipsInfo); //Magic


        //All saves in the update
        ////
        ///
        PlayerPrefs.SetInt("SavedAscensionCoinAmount", AscendCoins.ascensionCoinAmount);
        PlayerPrefs.SetInt("SavedLuckyAscendCoin", AscendCoins.luckyAscendCoin);
        PlayerPrefs.SetFloat("SavedStartWithCoins", AscendScreen.startWithCoins);
        PlayerPrefs.SetFloat("SavedCoinMultiplierRICHUPGRADES", AscendScreen.coinMulitplier);
        PlayerPrefs.SetFloat("SavedCheaperPrice", AscendScreen.cheaperPrice);
        PlayerPrefs.SetFloat("SavedSpecialUpgradeCheaperPrice", AscendScreen.specialUpgradeCheaperPrice);
        PlayerPrefs.SetInt("SavedLuckyCoinMultiplier", AscendScreen.luckyCoinMiltiplier);
        PlayerPrefs.SetFloat("SavedActiveFlipperMultiplier", AscendScreen.activeFlipperMiltiplier);
        PlayerPrefs.SetInt("SavedMorePileOfCoinsGain", AscendScreen.morePileOfCoinsGain);
        PlayerPrefs.SetInt("SavedIsGamblerPurchased", AscendScreen.isGamblerPurchased);
        PlayerPrefs.SetInt("SavedIsSpecialUpgrade3Bought", AscendScreen.isSpecialUpgrade3Baugh);
        PlayerPrefs.SetInt("SavedSpecialFlipperCoinMultiplier", AscendScreen.specialFlipperCoinMultiplier);
        PlayerPrefs.SetInt("SavedSpecialFlipperCoinLuckyMultiplier", AscendScreen.specialFlipperCoinLuckyMultiplier);
        PlayerPrefs.SetInt("SavedTotalGambledAmount", PurchaseLog.amountOfTimesGambled);
        PlayerPrefs.SetInt("SavedTotalGambledAmountWON", PurchaseLog.amountOfTimesGambledWON);
        PlayerPrefs.SetInt("SavedTotalGambledAmountLOST", PurchaseLog.amountOfTimesGambledLOST);
        PlayerPrefs.SetInt("SavedspecialUpgradeReduction", AscendScreen.totalSpecialReduction);
        PlayerPrefs.SetFloat("SavedTotalPileAmount", PileOfCoinsMechanics.totalAmountOfPileGenerated);
        PlayerPrefs.SetInt("SaveMoreGambleChances", AscendScreen.moreGambleChances);

        //Gamble
        PlayerPrefs.SetInt("SavedGambleChancesCount", PurchaseLog.gambleChances);
        PlayerPrefs.SetInt("SavedGambleChancesEachTimeWIN", PurchaseLog.gambleChanceEachTimeWIN);
        PlayerPrefs.SetInt("SavedGambleChancesEachTimeLOOSE", PurchaseLog.gambleChanceEachTimeLOOSE);
        PlayerPrefs.SetInt("SavedIsGambleBoughtOnce", PurchaseLog.isGambleBoughtOnce);

        //PIleOfCoins
        PlayerPrefs.SetInt("SavedIsPile1Unlocked", PileOfCoinsMechanics.isPile1Unlocked);
        PlayerPrefs.SetInt("SavedIsPile2Unlocked", PileOfCoinsMechanics.isPile2Unlocked);
        PlayerPrefs.SetInt("SavedIsPile3Unlocked", PileOfCoinsMechanics.isPile3Unlocked);
        PlayerPrefs.SetInt("SavedIsPile4Unlocked", PileOfCoinsMechanics.isPile4Unlocked);
        PlayerPrefs.SetInt("SavedIsPile5Unlocked", PileOfCoinsMechanics.isPile5Unlocked);
        PlayerPrefs.SetFloat("SavedPileCost", PileOfCoins.pileOfCoinsCost);
        PlayerPrefs.SetFloat("SavedPileOfCoinsAmount1", PileOfCoinsMechanics.PileOfCoinsAmount1);
        PlayerPrefs.SetFloat("SavedPileOfCoinsAmount2", PileOfCoinsMechanics.PileOfCoinsAmount2);
        PlayerPrefs.SetFloat("SavedPileOfCoinsAmount3", PileOfCoinsMechanics.PileOfCoinsAmount3);
        PlayerPrefs.SetFloat("SavedPileOfCoinsAmount4", PileOfCoinsMechanics.PileOfCoinsAmount4);
        PlayerPrefs.SetFloat("SavedPileOfCoinsAmount5", PileOfCoinsMechanics.PileOfCoinsAmount5);
        PlayerPrefs.SetInt("SavedIsPileBoughtFirstTime", PileOfCoinsMechanics.PileOfCounsBoughtFirstTime);
        PlayerPrefs.SetInt("SavedPileWaitTime", PileOfCoinsMechanics.waitTime);
        PlayerPrefs.SetInt("SavedPileCouns", PurchaseLog.pileOfCoinsCount);

        //All ascend upgrade unlocks
        PlayerPrefs.SetInt("SavedMillionGet", AscendCoins.millionGet);
        PlayerPrefs.SetInt("SavedBillionGet", AscendCoins.billionGet);
        PlayerPrefs.SetInt("SavedTrillionGet", AscendCoins.trillionGet);
        PlayerPrefs.SetInt("SavedQuadrillionGet", AscendCoins.quadrillionGet);
        PlayerPrefs.SetInt("SavedQuintillionGet", AscendCoins.quintillionGet);
        PlayerPrefs.SetInt("SavedSextillionGet", AscendCoins.sextillionGet);
        PlayerPrefs.SetInt("SavedSeptillionGet", AscendCoins.septillionGet);
        PlayerPrefs.SetInt("SavedOctillionGet", AscendCoins.octillionGet);
        PlayerPrefs.SetInt("SavedNonillionGet", AscendCoins.nonillionGet);
        PlayerPrefs.SetInt("SavedDecillionGet", AscendCoins.decillionGet);
        PlayerPrefs.SetInt("SavedUndecillion", AscendCoins.undecillionGet);

        PlayerPrefs.SetInt("IsActivePileBought", AscendScreen.isActivePilePurchased);
        PlayerPrefs.SetInt("SavedAscendUpgradeCount", AscendScreen.ascendUpgradeAmount);
        PlayerPrefs.SetInt("SavedAscendTimesAmount", Ascend.AscendTimesAmount);
        PlayerPrefs.SetInt("SavedClickedOnPileAmount", PileOfCoinsMechanics.incrementPileOfCoinsAmount);
        PlayerPrefs.SetInt("SavedEvenLuckierCoin", AscendScreen.hitEvenLuckerCoin);

        //1.2UpdateSaves
        PlayerPrefs.SetFloat("SavedChestCost", TreasureChest.treasureCost);
        PlayerPrefs.SetInt("SavedChestCount", TreasureChest.treasureCount);
        PlayerPrefs.SetFloat("SavedRitualCost", RitualUpgrade.ritualCost);
        PlayerPrefs.SetInt("SavedRitualCount", RitualUpgrade.treasureCount);

        PlayerPrefs.SetFloat("SavedChestInfo", PurchaseLog.treasureInfo);
        PlayerPrefs.SetFloat("SavedRitualInfo", PurchaseLog.ritualInfo);
    
        PlayerPrefs.SetInt("ActiveFlipps", MainButtonClick.activeFlipsAmount);

        PlayerPrefs.SetInt("SavedEndellInflationCount", EndlessInflation.inflationUpgadeCount);
        PlayerPrefs.SetInt("SavedEndellInflationPrice", EndlessInflation.endlessInflationPrice);
        PlayerPrefs.SetFloat("SavedEndellInflationBonus", EndlessInflation.endlessInflationBonus);
        PlayerPrefs.SetInt("SavedEndellBonusText", EndlessInflation.englessInflationBonusText);
        PlayerPrefs.SetFloat("SavedEndlessBonusEquals", EndlessInflation.endlessInflationCostEqualsBonus);

        if(LoadSaves.isMobileBuild == true) { PlayerPrefs.Save(); }
    }

    public void ResetSave()
    {
        //AscendCoinsScrips
        PlayerPrefs.SetInt("SavedGained1Mill", AscendCoins.gained1Mill);
        PlayerPrefs.SetInt("SavedGained250Mill", AscendCoins.gained250Mill);
        PlayerPrefs.SetInt("SavedGained500Mill", AscendCoins.gained500Mill);
        PlayerPrefs.SetInt("SavedGained750Mill", AscendCoins.gained750Mill);

        PlayerPrefs.SetInt("SavedGained1Billion", AscendCoins.gained1Billion);
        PlayerPrefs.SetInt("SavedGained250Billion", AscendCoins.gained250Billion);
        PlayerPrefs.SetInt("SavedGained500Billion", AscendCoins.gained500Billion);
        PlayerPrefs.SetInt("SavedGained750Billion", AscendCoins.gained750Billion);

        PlayerPrefs.SetInt("SavedGained1Tillion", AscendCoins.gained1Trillion);
        PlayerPrefs.SetInt("SavedGained250Tillion", AscendCoins.gained250Trillion);
        PlayerPrefs.SetInt("SavedGained500Tillion", AscendCoins.gained500Trillion);
        PlayerPrefs.SetInt("SavedGained750Tillion", AscendCoins.gained750Trillion);

        PlayerPrefs.SetInt("SavedGained1Quadrillion", AscendCoins.gained1Quadrillion);
        PlayerPrefs.SetInt("SavedGained250Quadrillion", AscendCoins.gained250Quadrillion);
        PlayerPrefs.SetInt("SavedGained500Quadrillion", AscendCoins.gained500Quadrillion);
        PlayerPrefs.SetInt("SavedGained750Quadrillion", AscendCoins.gained750Quadrillion);

        PlayerPrefs.SetInt("SavedGained1Quintillion", AscendCoins.gained1Quintillion);
        PlayerPrefs.SetInt("SavedGained250Quintillion", AscendCoins.gained250Quintillion);
        PlayerPrefs.SetInt("SavedGained500Quintillion", AscendCoins.gained500Quintillion);
        PlayerPrefs.SetInt("SavedGained750Quintillion", AscendCoins.gained750Quintillion);

        PlayerPrefs.SetInt("SavedGained1Sextillion", AscendCoins.gained1Sextillion);
        PlayerPrefs.SetInt("SavedGained250Sextillion", AscendCoins.gained250Sextillion);
        PlayerPrefs.SetInt("SavedGained500Sextillion", AscendCoins.gained500Sextillion);
        PlayerPrefs.SetInt("SavedGained750Sextillion", AscendCoins.gained750Sextillion);

        PlayerPrefs.SetInt("SavedGained1Septillion", AscendCoins.gained1Septillion);
        PlayerPrefs.SetInt("SavedGained250Septillion", AscendCoins.gained250Septillion);
        PlayerPrefs.SetInt("SavedGained500Septillion", AscendCoins.gained500Septillion);
        PlayerPrefs.SetInt("SavedGained750Septillion", AscendCoins.gained750Septillion);

        PlayerPrefs.SetInt("SavedGained1Octillion", AscendCoins.gained1octillion);
        PlayerPrefs.SetInt("SavedGained250Octillion", AscendCoins.gained250octillion);
        PlayerPrefs.SetInt("SavedGained500Octillion", AscendCoins.gained500octillion);
        PlayerPrefs.SetInt("SavedGained750Octillion", AscendCoins.gained750octillion);

        PlayerPrefs.SetInt("SavedGained1nonillion", AscendCoins.gained1nonillion);
        PlayerPrefs.SetInt("SavedGained250nonillion", AscendCoins.gained250nonillion);
        PlayerPrefs.SetInt("SavedGained500nonillion", AscendCoins.gained500nonillion);
        PlayerPrefs.SetInt("SavedGained750nonillion", AscendCoins.gained750nonillion);

        PlayerPrefs.SetInt("SavedGained1Decillion", AscendCoins.gained1Decillion);
        PlayerPrefs.SetInt("SavedGained250Decillion", AscendCoins.gained250Decillion);
        PlayerPrefs.SetInt("SavedGained500Decillion", AscendCoins.gained500Decillion);
        PlayerPrefs.SetInt("SavedGained750Decillion", AscendCoins.gained750Decillion);

        PlayerPrefs.SetInt("SavedGained1Undecillion", AscendCoins.gained1Undecillion);
        PlayerPrefs.SetInt("SavedGained250Undecillion", AscendCoins.gained250Undecillion);
        PlayerPrefs.SetInt("SavedGained500Undecillion", AscendCoins.gained500Undecillion);
        PlayerPrefs.SetInt("SavedGained750Undecillion", AscendCoins.gained750Undecillion);

        PlayerPrefs.SetInt("BoughtAuto", AscendScreen.boughtAuto);

        PlayerPrefs.SetInt("SavedBoughtRich1", AscendScreen.boughtRich1);
        PlayerPrefs.SetInt("SavedBoughtRich2", AscendScreen.boughtRich2);
        PlayerPrefs.SetInt("SavedBoughtRich3", AscendScreen.boughtRich3);
        PlayerPrefs.SetInt("SavedBoughtRich4", AscendScreen.boughtRich4);
        PlayerPrefs.SetInt("SavedBoughtRich5", AscendScreen.boughtRich5);
        PlayerPrefs.SetInt("SavedBoughtRich6", AscendScreen.boughtRich6);
        PlayerPrefs.SetInt("SavedBoughtRich7", AscendScreen.boughtRichSUPER);
        PlayerPrefs.SetInt("BoughtRich1250", AscendScreen.boughtRich1250);

        PlayerPrefs.SetInt("SavedBoughtSale1", AscendScreen.boughtSale1);
        PlayerPrefs.SetInt("SavedBoughtSale2", AscendScreen.boughtSale2);
        PlayerPrefs.SetInt("SavedBoughtSale3", AscendScreen.boughtSale3);
        PlayerPrefs.SetInt("SavedBoughtSale4", AscendScreen.boughtSale4);
        PlayerPrefs.SetInt("SavedBoughtSTEAMSALE", AscendScreen.boughtSTEAMSALE);

        PlayerPrefs.SetInt("SavedBoughtActiveFlipper1", AscendScreen.boughtActiveFlipper1);
        PlayerPrefs.SetInt("SavedBoughtActiveFlipper2", AscendScreen.boughtActiveFlipper2);
        PlayerPrefs.SetInt("SavedBoughtActiveFlipper3", AscendScreen.boughtActiveFlipper3);
        PlayerPrefs.SetInt("SavedBoughtActiveFlipper4", AscendScreen.boughtActiveFlipper4);
        PlayerPrefs.SetInt("SavedBoughtActiveFlipperSUPER", AscendScreen.boughtActiveFlipperSUPER);
        PlayerPrefs.SetInt("SavedBoughtActiveFlipperPILEOFCOINS", AscendScreen.boughtActiveFlipperPILOFCOINS);

        PlayerPrefs.SetInt("SavedBoughtBag1", AscendScreen.boughtBagOfCoins1);
        PlayerPrefs.SetInt("SavedBoughtBag2", AscendScreen.boughtBagOfCoins2);
        PlayerPrefs.SetInt("SavedBoughtBag3", AscendScreen.boughtBagOfCoins3);
        PlayerPrefs.SetInt("SavedBoughtBag4", AscendScreen.boughtBagOfCoins4);
        PlayerPrefs.SetInt("SavedBoughtBagSUPER", AscendScreen.boughtBagOfCoinsSUPER);
        PlayerPrefs.SetInt("BoughtPileBag", AscendScreen.boughtPileBag);

        PlayerPrefs.SetInt("SavedboughtSpecial1", AscendScreen.boughtSpecial1);
        PlayerPrefs.SetInt("SavedboughtSpecial2", AscendScreen.boughtSpecial2);
        PlayerPrefs.SetInt("SavedboughtSpecial3", AscendScreen.boughtSpecial3);
        PlayerPrefs.SetInt("SavedboughtSpecial4", AscendScreen.boughtSpecial4);
        PlayerPrefs.SetInt("SavedboughtSpecialSUPER", AscendScreen.boughtSpecialSUPER);
        PlayerPrefs.SetInt("SavedboughtSpecialGAMBLER", AscendScreen.boughtSpecialGAMBLEr);
        PlayerPrefs.SetInt("SavedboughtSpecialPILE", AscendScreen.boughtSpecialBIGGERPILE);
        PlayerPrefs.SetInt("SavedboughtSpecialPILE2", AscendScreen.boughtSpecialBIGGERPILE2);
        PlayerPrefs.SetInt("SavedboughtSpecialLUCKIER", AscendScreen.boughtSpecialLUCKER);

        PlayerPrefs.SetInt("SavedGreaterAscension1", AscendScreen.boughtGreaterAscension1);
        PlayerPrefs.SetInt("SavedGreaterAscension2", AscendScreen.boughtGreaterAscension2);
        PlayerPrefs.SetInt("SavedGreaterAscension3", AscendScreen.boughtGreaterAscension3);
        PlayerPrefs.SetInt("SavedGreaterAscension4", AscendScreen.boughtGreaterAscension4);
        PlayerPrefs.SetInt("SavedGreaterAscension5", AscendScreen.boughtGreaterAscension5);
        PlayerPrefs.SetInt("SavedGreaterAscensionSUPER", AscendScreen.boughtGreaterAscensionSUPER);
        PlayerPrefs.SetInt("SavedGreaterAscensionGAMLE1", AscendScreen.boughtGreaterAscensionGamble1);
        PlayerPrefs.SetInt("SavedGreaterAscensionGAMLE2", AscendScreen.boughtGreaterAscensionGamble2);
        PlayerPrefs.SetInt("SavedGreaterAscensionGAMLE3", AscendScreen.boughtGreaterAscensionGamble3);
        PlayerPrefs.SetInt("SavedGreaterAscensionGAMLE4", AscendScreen.boughtGreaterAscensionGamble4);

        PlayerPrefs.SetInt("SavedChallenge1", Challenges.isChallenge1Active);
        PlayerPrefs.SetInt("SavedChallenge2", Challenges.isChallenge2Active);
        PlayerPrefs.SetInt("SavedChallenge3", Challenges.isChallenge3Active);
        PlayerPrefs.SetInt("SavedChallenge4", Challenges.isChallenge4Active);

        PlayerPrefs.SetInt("CompledetChal1", Challenges.completedChallenge1);
        PlayerPrefs.SetInt("CompledetChal2", Challenges.completedChallenge2);
        PlayerPrefs.SetInt("CompledetChal3", Challenges.completedChallenge3);
        PlayerPrefs.SetInt("CompledetChal4", Challenges.completedChallenge4);

        PlayerPrefs.SetInt("FoundBronce", hiddenCoins.foundBronce);
        PlayerPrefs.SetInt("FoundSilver", hiddenCoins.foundSilver);

        PlayerPrefs.SetInt("ACH1", Achievements.ACH1IsUnlocked);
        PlayerPrefs.SetInt("ACH2", Achievements.ACH2IsUnlocked);
        PlayerPrefs.SetInt("ACH3", Achievements.ACH3IsUnlocked);
        PlayerPrefs.SetInt("ACH4", Achievements.ACH4IsUnlocked);
        PlayerPrefs.SetInt("ACH5", Achievements.ACH5IsUnlocked);
        PlayerPrefs.SetInt("ACH6", Achievements.ACH6IsUnlocked);
        PlayerPrefs.SetInt("ACH7", Achievements.ACH7IsUnlocked);
        PlayerPrefs.SetInt("ACH8", Achievements.ACH8IsUnlocked);
        PlayerPrefs.SetInt("ACH9", Achievements.ACH9IsUnlocked);
        PlayerPrefs.SetInt("ACH10", Achievements.ACH10IsUnlocked);
        PlayerPrefs.SetInt("ACH11", Achievements.ACH11IsUnlocked);
        PlayerPrefs.SetInt("ACH12", Achievements.ACH12IsUnlocked);
        PlayerPrefs.SetInt("ACH13", Achievements.ACH13IsUnlocked);
        PlayerPrefs.SetInt("ACH14", Achievements.ACH14IsUnlocked);
        PlayerPrefs.SetInt("ACH15", Achievements.ACH15IsUnlocked);
        PlayerPrefs.SetInt("ACH16", Achievements.ACH16IsUnlocked);
        PlayerPrefs.SetInt("ACH17", Achievements.ACH17IsUnlocked);
        PlayerPrefs.SetInt("ACH18", Achievements.ACH18IsUnlocked);
        PlayerPrefs.SetInt("ACH19", Achievements.ACH19IsUnlocked);
        PlayerPrefs.SetInt("ACH20", Achievements.ACH20IsUnlocked);
        PlayerPrefs.SetInt("ACH21", Achievements.ACH21IsUnlocked);
        PlayerPrefs.SetInt("ACH22", Achievements.ACH22IsUnlocked);
        PlayerPrefs.SetInt("ACH23", Achievements.ACH23IsUnlocked);
        PlayerPrefs.SetInt("ACH24", Achievements.ACH24IsUnlocked);
        PlayerPrefs.SetInt("ACH25", Achievements.ACH25IsUnlocked);
        PlayerPrefs.SetInt("ACH26", Achievements.ACH26IsUnlocked);
        PlayerPrefs.SetInt("ACH27", Achievements.ACH27IsUnlocked);
        PlayerPrefs.SetInt("ACH28", Achievements.ACH28IsUnlocked);
        PlayerPrefs.SetInt("ACH29", Achievements.ACH29IsUnlocked);
        PlayerPrefs.SetInt("ACH30", Achievements.ACH30IsUnlocked);
        PlayerPrefs.SetInt("ACH31", Achievements.ACH31IsUnlocked);
        PlayerPrefs.SetInt("ACH32", Achievements.ACH32IsUnlocked);
        PlayerPrefs.SetInt("ACH33", Achievements.ACH33IsUnlocked);
        PlayerPrefs.SetInt("ACH34", Achievements.ACH34IsUnlocked);
        PlayerPrefs.SetInt("ACH35", Achievements.ACH35IsUnlocked);
        PlayerPrefs.SetInt("ACH36", Achievements.ACH36IsUnlocked);
        PlayerPrefs.SetInt("ACH37", Achievements.ACH37IsUnlocked);
        PlayerPrefs.SetInt("ACH38", Achievements.ACH38IsUnlocked);
        PlayerPrefs.SetInt("ACH39", Achievements.ACH39IsUnlocked);
        PlayerPrefs.SetInt("ACH40", Achievements.ACH40IsUnlocked);
        PlayerPrefs.SetInt("ACH41", Achievements.ACH41IsUnlocked);
        PlayerPrefs.SetInt("ACH42", Achievements.ACH42IsUnlocked);
        PlayerPrefs.SetInt("ACH43", Achievements.ACH43IsUnlocked);
        PlayerPrefs.SetInt("ACH44", Achievements.ACH44IsUnlocked);
        PlayerPrefs.SetInt("ACH45", Achievements.ACH45IsUnlocked);
        PlayerPrefs.SetInt("ACH46", Achievements.ACH46IsUnlocked);
        PlayerPrefs.SetInt("ACH47", Achievements.ACH47IsUnlocked);
        PlayerPrefs.SetInt("ACH48", Achievements.ACH48IsUnlocked);
        PlayerPrefs.SetInt("ACH49", Achievements.ACH49IsUnlocked);
        PlayerPrefs.SetInt("ACH50", Achievements.ACH50IsUnlocked);
        PlayerPrefs.SetInt("ACH51", Achievements.ACH51IsUnlocked);
        PlayerPrefs.SetInt("ACH52", Achievements.ACH52IsUnlocked);
        PlayerPrefs.SetInt("ACH53", Achievements.ACH53IsUnlocked);
        PlayerPrefs.SetInt("ACH54", Achievements.ACH54IsUnlocked);
        PlayerPrefs.SetInt("ACH55", Achievements.ACH55IsUnlocked);
        PlayerPrefs.SetInt("ACH56", Achievements.ACH56IsUnlocked);
        PlayerPrefs.SetInt("ACH57", Achievements.ACH57IsUnlocked);
        PlayerPrefs.SetInt("ACH58", Achievements.ACH58IsUnlocked);
        PlayerPrefs.SetInt("ACH59", Achievements.ACH59IsUnlocked);
        PlayerPrefs.SetInt("ACH60", Achievements.ACH60IsUnlocked);
        PlayerPrefs.SetInt("ACH61", Achievements.ACH61IsUnlocked);
        PlayerPrefs.SetInt("ACH62", Achievements.ACH62IsUnlocked);

        PlayerPrefs.SetInt("ACH63", AchievementsUpdate.ACH1IsUnlocked);
        PlayerPrefs.SetInt("ACH64", AchievementsUpdate.ACH2IsUnlocked);
        PlayerPrefs.SetInt("ACH65", AchievementsUpdate.ACH3IsUnlocked);
        PlayerPrefs.SetInt("ACH66", AchievementsUpdate.ACH4IsUnlocked);
        PlayerPrefs.SetInt("ACH67", AchievementsUpdate.ACH5IsUnlocked);
        PlayerPrefs.SetInt("ACH68", AchievementsUpdate.ACH6IsUnlocked);
        PlayerPrefs.SetInt("ACH69", AchievementsUpdate.ACH7IsUnlocked);
        PlayerPrefs.SetInt("ACH70", AchievementsUpdate.ACH8IsUnlocked);
        PlayerPrefs.SetInt("ACH71", AchievementsUpdate.ACH9IsUnlocked);
        PlayerPrefs.SetInt("ACH72", AchievementsUpdate.ACH10IsUnlocked);
        PlayerPrefs.SetInt("ACH73", AchievementsUpdate.ACH11IsUnlocked);
        PlayerPrefs.SetInt("ACH74", AchievementsUpdate.ACH12IsUnlocked);
        PlayerPrefs.SetInt("ACH75", AchievementsUpdate.ACH13IsUnlocked);
        PlayerPrefs.SetInt("ACH76", AchievementsUpdate.ACH14IsUnlocked);
        PlayerPrefs.SetInt("ACH77", AchievementsUpdate.ACH15IsUnlocked);
        PlayerPrefs.SetInt("ACH78", AchievementsUpdate.ACH16IsUnlocked);
        PlayerPrefs.SetInt("ACH79", AchievementsUpdate.ACH17IsUnlocked);
        PlayerPrefs.SetInt("ACH80", AchievementsUpdate.ACH18IsUnlocked);
        PlayerPrefs.SetInt("ACH81", AchievementsUpdate.ACH19IsUnlocked);
        PlayerPrefs.SetInt("ACH82", AchievementsUpdate.ACH20IsUnlocked);
        PlayerPrefs.SetInt("ACH83", AchievementsUpdate.ACH21IsUnlocked);
        PlayerPrefs.SetInt("ACH84", AchievementsUpdate.ACH22IsUnlocked);
        PlayerPrefs.SetInt("ACH85", AchievementsUpdate.ACH23IsUnlocked);
        PlayerPrefs.SetInt("ACH86", AchievementsUpdate.ACH24IsUnlocked);
        PlayerPrefs.SetInt("ACH87", AchievementsUpdate.ACH25IsUnlocked);
        PlayerPrefs.SetInt("ACH88", AchievementsUpdate.ACH26IsUnlocked);
        PlayerPrefs.SetInt("ACH89", AchievementsUpdate.ACH27IsUnlocked);
        PlayerPrefs.SetInt("ACH90", AchievementsUpdate.ACH28IsUnlocked);
        PlayerPrefs.SetInt("ACH91", AchievementsUpdate.ACH29IsUnlocked);
        PlayerPrefs.SetInt("ACH92", AchievementsUpdate.ACH30IsUnlocked);
        PlayerPrefs.SetInt("ACH93", AchievementsUpdate.ACH31IsUnlocked);
        PlayerPrefs.SetInt("ACH94", AchievementsUpdate.ACH32IsUnlocked);
        PlayerPrefs.SetInt("ACH95", AchievementsUpdate.ACH33IsUnlocked);
    }

    IEnumerator SaveGame()
    {
        yield return new WaitForSeconds(2);

        strongerHandsCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + MoreCoinsButton.moreCoinsUpgrades;
        greaterCoinsCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + MoreCoinsButton.greaterCoinsCount;
        knowledgeCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + KnowledgeUpgrade.knowledgeUpgradeCount;
        strongerFistCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + StrongerFist.fistUpgradeCount;
        handInjectionCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + HandInecjtion.injectionUpgradeCount;
        brainPowerCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + BrainPower.brainPowerUpgradeCount;
        explosiveFlipsCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + ExplosiveFlips.explosiveUpgradeCount;
        hydrationCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + HydrationButton.hydrationUpgradeCount;
        potionCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + StrangePotion.potionUpgradeCount;
        masterFlipperCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + MasterFlipper.MasterFlipsUpgradeCount;
        handShakeCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + HandShake.handShakeUpgradeCount;
        highFiveCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + Upgrade12.upgrade12Count;
        wizardCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + MagicFlipsUpgrade.magicUpgradeCount;

        savedGamePopUp2.SetActive(false);
    }

    
    void OnApplicationPause(bool isPaused)
    {
        if(isGameLoaded == true)
        {
            if (LoadSaves.isMobileBuild == true)
            {
                if (isPaused)
                {
                    SaveEverything();
                }
            }
        }
    }

    void OnApplicationFocus(bool hasFocus)
    {
        if (isGameLoaded == true)
        {
            if (LoadSaves.isMobileBuild == true)
            {
                if (!hasFocus)
                {
                    SaveEverything();
                }
            }
        }
    }
}
