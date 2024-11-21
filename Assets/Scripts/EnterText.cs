using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnterText : MonoBehaviour
{
    //public InputField displayName;
    //public Text enterName;
    public GameObject headsOrTails;
    public GameObject heads;
    public GameObject tails;
    public static int choseHeads;
    public static int choseTails;
    public AudioSource choseCoinSoundEffect;
    public AudioClip choseCoinSound;
    public GameObject blockScreen;
    public GameObject choseHeadsText;
    public GameObject choseTailsText;
    public GameObject chooseHeadsOrTailsText;
    public GameObject flipper1;
    public GameObject flipper2;
    public GameObject flipper3;
    public GameObject flipper4;
    public GameObject flipper5;
    public GameObject flipper6;
    public GameObject flipper7;
    public GameObject flipper8;
    public GameObject flipper9;
    public GameObject flipper10;
    public GameObject flipper11;
    public GameObject flipper12;
    public GameObject flipper13;
    public GameObject flipper14;
    public GameObject flipper15;
    public GameObject flipper16;
    public GameObject flipper17;
    public GameObject flipper18;
    public GameObject flipper19;
    public GameObject flipper20;
    public GameObject flipper21;
    public GameObject ascendScreen;
    public GameObject challengeDropDown;

    public TextMeshProUGUI gambleWinText;
    public TextMeshProUGUI gambleLooseText;

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
    public TextMeshProUGUI chestText;
    public TextMeshProUGUI ritualText;

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

    public AutoUpgrade autoScript;

    private void Start()
    {
        if (choseHeads == 1 || choseTails == 1)
        {
            blockScreen.SetActive(false);
            headsOrTails.SetActive(false);
        }
    }

    public GameObject choose;

    public void DoYouWantToReset()
    {
        choose.SetActive(true);
    }

    public TextMeshProUGUI headsStats;
    public TextMeshProUGUI tailsStats;
    public TextMeshProUGUI luckyStats;

    public TextMeshProUGUI pileStatsText;
    public TextMeshProUGUI pileCountText;
    public TextMeshProUGUI pileWaitTimeText;
    public TextMeshProUGUI magicStats;

    public TextMeshProUGUI pileText1;
    public TextMeshProUGUI pileText2;
    public TextMeshProUGUI pileText3;
    public TextMeshProUGUI pileText4;
    public TextMeshProUGUI pileText5;

    public TextMeshProUGUI GABPILEText;

    public GameObject buttonCorotine;
    public void ChooseHeads()
    {
        //buttonCorotine.GetComponent<Button>().onClick.Invoke();

        TreasureChest.treasureCost = 970000000000000000000000f * (1 - AscendScreen.cheaperPrice);
        RitualUpgrade.ritualCost = 425000000000000000000000000f * (1 - AscendScreen.cheaperPrice);
        TreasureChest.treasureCount = 0;
        RitualUpgrade.treasureCount = 0;

        challengeDropDown.SetActive(false);
        ascendScreen.SetActive(false);
        flipper1.SetActive(true);
        flipper2.SetActive(true);
        flipper3.SetActive(true);
        flipper4.SetActive(true);
        flipper5.SetActive(true);
        flipper6.SetActive(true);
        flipper7.SetActive(true);
        flipper8.SetActive(true);
        flipper9.SetActive(true);
        flipper10.SetActive(true);
        flipper11.SetActive(true);
        flipper12.SetActive(true);
        flipper13.SetActive(true);
        flipper14.SetActive(true);
        flipper15.SetActive(true);
        flipper16.SetActive(true);
        flipper17.SetActive(true);
        flipper18.SetActive(true);
        flipper19.SetActive(true);
        flipper20.SetActive(true);
        flipper21.SetActive(true);
        choseHeads = 1;
        choseCoinSoundEffect.PlayOneShot(choseCoinSound);
        blockScreen.SetActive(true);
        tails.SetActive(false);
        choseHeadsText.SetActive(true);
        chooseHeadsOrTailsText.SetActive(false);
        StartCoroutine(WaitForAim());

        if (Challenges.isChallenge3Active == 1) { GlobalCoins.CoinCount = 0; }
        if (Challenges.isChallenge3Active == 0)
        {
            GlobalCoins.CoinCount = 0 + AscendScreen.startWithCoins + PileOfCoinsMechanics.PileBagAmount;
        }
        MainButtonClick.coinsPerClick = 1;
        pileBagAmount.text = LocalizationStrings.inflatePileOfBagsStats + PileOfCoinsMechanics.PileBagAmount + LocalizationStrings.moreCoinsAfterInflating;
        PileOfCoinsMechanics.PileBagAmount = 0;

        MoreCoinsButton.moreCoinsUpgrades = 0;
        MoreCoinsButton.moreCoinClickValue = 5 * (1 - AscendScreen.cheaperPrice);
        MoreCoinsButton.greaterCoinsCount = 0;
        MoreCoinsButton.greaterCoinsCost = 125 * (1 - AscendScreen.cheaperPrice);
        KnowledgeUpgrade.knowledgeUpgradeCount = 0;
        KnowledgeUpgrade.knowledgeClickValue = 2150 * (1 - AscendScreen.cheaperPrice);
        StrongerFist.fistUpgradeCount = 0;
        StrongerFist.fistCost = 60000 * (1 - AscendScreen.cheaperPrice);
        HandInecjtion.injectionUpgradeCount = 0;
        HandInecjtion.injectionCost = 875000 * (1 - AscendScreen.cheaperPrice);
        BrainPower.brainPowerUpgradeCount = 0;
        BrainPower.brainPowerCost = 85000000 * (1 - AscendScreen.cheaperPrice);
        ExplosiveFlips.explosiveUpgradeCount = 0;
        ExplosiveFlips.explosiveCost = 1200000000 * (1 - AscendScreen.cheaperPrice);
        HydrationButton.hydrationUpgradeCount = 0;
        HydrationButton.hydrationVost = 625000000000 * (1 - AscendScreen.cheaperPrice);
        StrangePotion.potionUpgradeCount = 0;
        StrangePotion.potionCost = 41000000000000 * (1 - AscendScreen.cheaperPrice);
        MasterFlipper.MasterFlipsUpgradeCount = 0;
        MasterFlipper.MasterFlipsCost = 2100000000000000 * (1 - AscendScreen.cheaperPrice);
        HandShake.handShakeUpgradeCount = 0;
        HandShake.handshakeCost = 30000000000000000 * (1 - AscendScreen.cheaperPrice);
        Upgrade12.upgrade12Count = 0;
        Upgrade12.upgrade12Cost = 930000000000000000 * (1 - AscendScreen.cheaperPrice);
        MagicFlipsUpgrade.magicUpgradeCount = 0;
        MagicFlipsUpgrade.magicUpgradeCost = 7500000000000000000000f * (1 - AscendScreen.cheaperPrice);

        GetLuckyHoverOver.luckyChance = 0.5f;

       
        if (Challenges.isChallenge2Active == 1)
        {
            higherChanceHoverover.headsPercent = 73.75f;
            higherChanceHoverover.tailsPercent = 25.75f;
            MainButtonClick.lowerCoinChance = 150;
            MainButtonClick.higherCoinChance = 149;
            MainButtonClick.lowSpecialChance = 1;
            headsStats.GetComponent<TextMeshProUGUI>().text = higherChanceHoverover.headsPercent + LocalizationStrings.higherChanceHeads;
            tailsStats.GetComponent<TextMeshProUGUI>().text = higherChanceHoverover.tailsPercent + LocalizationStrings.higherChanceTails;
            luckyStats.GetComponent<TextMeshProUGUI>().text = GetLuckyHoverOver.luckyChance + LocalizationStrings.luckyCoinChance;
        }

        if (Challenges.isChallenge4Active == 1)
        {
            headsStats.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.higherChanceHeads;
            tailsStats.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.higherChanceTails;
            luckyStats.GetComponent<TextMeshProUGUI>().text = "100" + LocalizationStrings.luckyCoinChance;
            MainButtonClick.lowSpecialChance = 202;
            MainButtonClick.higherCoinChance = 203;
            MainButtonClick.lowerCoinChance = 204;
        }

        if (Challenges.isChallenge4Active == 0 && Challenges.isChallenge2Active == 0)
        {
            higherChanceHoverover.tailsPercent = 49.75f;
            higherChanceHoverover.headsPercent = 49.75f;
            MainButtonClick.lowSpecialChance = 1;
            MainButtonClick.higherCoinChance = 100;
            MainButtonClick.lowerCoinChance = 101;
            headsStats.GetComponent<TextMeshProUGUI>().text = higherChanceHoverover.headsPercent + LocalizationStrings.higherChanceHeads;
            tailsStats.GetComponent<TextMeshProUGUI>().text = higherChanceHoverover.tailsPercent + LocalizationStrings.higherChanceTails;
            luckyStats.GetComponent<TextMeshProUGUI>().text = GetLuckyHoverOver.luckyChance + LocalizationStrings.luckyCoinChance;
        }


        GlobalCoinMaker.coinsPerFlipUpgrades = 0;
        GlobalCoinMaker.coinValue = 500 * (1 -AscendScreen.specialUpgradeCheaperPrice);
        PurchaseLog.higherChanceUpgradeCount = 0;
        HigherChance.higherChanceValue = 150000 * (1 - AscendScreen.specialUpgradeCheaperPrice);
        PurchaseLog.luckyCoinHigherChanceCount = 0;
        LuckyCoinChance.luckyCoinValue = 175000000 * (1 - AscendScreen.specialUpgradeCheaperPrice);
        GoldenFlipsButton.goldenCoinsUpgradeCount = 0;
        GOLDENFLIPS.specialCoinsButtonCost = 12000000000000000 * (1 - AscendScreen.specialUpgradeCheaperPrice);
        MainButtonClick.numberOfDuplicationUpgrades = 0;
        DuplicateCoin.duplicatePrice = 75;
        PileOfCoins.pileOfCoinsCost = 20000 * (1 - AscendScreen.specialUpgradeCheaperPrice);
        PileOfCoinsMechanics.totalAmountOfPileGenerated = 0;
        PurchaseLog.gambleChances = 5 + AscendScreen.moreGambleChances;

        PileOfCoinsMechanics.PileOfCoinsAmount1 = 0;
        PileOfCoinsMechanics.PileOfCoinsAmount2 = 0;
        PileOfCoinsMechanics.PileOfCoinsAmount3 = 0;
        PileOfCoinsMechanics.PileOfCoinsAmount4 = 0;
        PileOfCoinsMechanics.PileOfCounsBoughtFirstTime = 0;

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
        PurchaseLog.treasureInfo = 0;
        PurchaseLog.ritualInfo = 0;

        AscendCoins.gained1Mill = 1;
        AscendCoins.gained250Mill = 1;
        AscendCoins.gained500Mill = 1;
        AscendCoins.gained750Mill = 1;

        AscendCoins.gained1Billion = 1;
        AscendCoins.gained250Billion = 1;
        AscendCoins.gained500Billion = 1;
        AscendCoins.gained750Billion = 1;

        AscendCoins.gained1Trillion = 1;
        AscendCoins.gained250Trillion = 1;
        AscendCoins.gained500Trillion = 1;
        AscendCoins.gained750Trillion = 1;

        AscendCoins.gained1Quadrillion = 1;
        AscendCoins.gained250Quadrillion = 1;
        AscendCoins.gained500Quadrillion = 1;
        AscendCoins.gained750Quadrillion = 1;

        AscendCoins.gained1Quintillion = 1;
        AscendCoins.gained250Quintillion = 1;
        AscendCoins.gained500Quintillion = 1;
        AscendCoins.gained750Quintillion = 1;

        AscendCoins.gained1Sextillion = 1;
        AscendCoins.gained250Sextillion = 1;
        AscendCoins.gained500Sextillion = 1;
        AscendCoins.gained750Sextillion = 1;

        AscendCoins.gained1Septillion = 1;
        AscendCoins.gained250Septillion = 1;
        AscendCoins.gained500Septillion = 1;
        AscendCoins.gained750Septillion = 1;

        AscendCoins.gained1octillion = 1;
        AscendCoins.gained250octillion = 1;
        AscendCoins.gained500octillion = 1;
        AscendCoins.gained750octillion = 1;

        AscendCoins.gained1nonillion = 1;
        AscendCoins.gained250nonillion = 1;
        AscendCoins.gained500nonillion = 1;
        AscendCoins.gained750nonillion = 1;

        AscendCoins.gained1Decillion = 1;
        AscendCoins.gained250Decillion = 1;
        AscendCoins.gained500Decillion = 1;
        AscendCoins.gained750Decillion = 1;

        AscendCoins.gained1Undecillion = 1;
        AscendCoins.gained250Undecillion = 1;
        AscendCoins.gained500Undecillion = 1;
        AscendCoins.gained750Undecillion = 1;

        if(AscendScreen.boughtGreaterAscension1 == 0)
        {
            AscendCoins.millionGet = 1;
            AscendCoins.billionGet = 1;
            AscendCoins.trillionGet = 1;
            AscendCoins.quadrillionGet = 1;
            AscendCoins.quintillionGet = 1;
            AscendCoins.sextillionGet = 1;
            AscendCoins.septillionGet = 1;
            AscendCoins.octillionGet = 1;
            AscendCoins.nonillionGet = 1;
            AscendCoins.decillionGet = 1;
            AscendCoins.undecillionGet = 1;
        }

        PileOfCoinsMechanics.waitTime = 65;
        PurchaseLog.pileOfCoinsCount = 0;

        if (AscendScreen.boughtSpecial2 == 0)
        {
            PurchaseLog.gambleChanceEachTimeWIN = 50;
            PurchaseLog.gambleChanceEachTimeLOOSE = 50;
            gambleWinText.GetComponent<TextMeshProUGUI>().text = PurchaseLog.gambleChanceEachTimeWIN + LocalizationStrings.gambleWinChance;
            gambleLooseText.GetComponent<TextMeshProUGUI>().text = PurchaseLog.gambleChanceEachTimeLOOSE + LocalizationStrings.gambleLoseChance;
        }
        if (AscendScreen.boughtSpecial2 == 1)
        {
            PurchaseLog.gambleChanceEachTimeWIN = 51;
            PurchaseLog.gambleChanceEachTimeLOOSE = 49;
            gambleWinText.GetComponent<TextMeshProUGUI>().text = PurchaseLog.gambleChanceEachTimeWIN + LocalizationStrings.gambleWinChance;
            gambleLooseText.GetComponent<TextMeshProUGUI>().text = PurchaseLog.gambleChanceEachTimeLOOSE + LocalizationStrings.gambleLoseChance;
        }
        if (AscendScreen.boughtSpecial2 == 1 && AscendScreen.boughtSpecialGAMBLEr == 1)
        {
            PurchaseLog.gambleChanceEachTimeWIN = 51;
            PurchaseLog.gambleChanceEachTimeLOOSE = 49;
            gambleWinText.GetComponent<TextMeshProUGUI>().text = PurchaseLog.gambleChanceEachTimeWIN + LocalizationStrings.gambleWinChance;
            gambleLooseText.GetComponent<TextMeshProUGUI>().text = PurchaseLog.gambleChanceEachTimeLOOSE + LocalizationStrings.gambleLoseChance;
        }

        pileText1.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.coins;
        pileText2.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.coins;
        pileText3.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.coins;
        pileText4.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.coins;
        pileText5.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.coins;

        pileCountText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + PurchaseLog.pileOfCoinsCount;
        pileWaitTimeText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.pileGeneratesEveyXSecond + PileOfCoinsMechanics.waitTime + LocalizationStrings.seconds;
        pileStatsText.GetComponent<TextMeshProUGUI>().text =  LocalizationStrings.pileTotalGenerated + "0" + LocalizationStrings.coins;
        strongerArmsText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.your + "0" + LocalizationStrings.statsStrongerArm + "0" + LocalizationStrings.coins;
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
        chestText.text = LocalizationStrings.buyUpgrade;
        ritualText.text = LocalizationStrings.buyUpgrade;

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

        GABPILEText.text = LocalizationStrings.inflatePileOfBagsStats+ "0" + LocalizationStrings.moreCoinsAfterInflating;

        autoScript.CheckBlockUpgrades();
        SetInflationCoinsSave();
    }


    public TextMeshProUGUI pileBagAmount;
    public void ChooseTails()
    {
        //buttonCorotine.GetComponent<Button>().onClick.Invoke();
        TreasureChest.treasureCost = 970000000000000000000000f * (1 - AscendScreen.cheaperPrice);
        RitualUpgrade.ritualCost = 425000000000000000000000000f * (1 - AscendScreen.cheaperPrice);
        TreasureChest.treasureCount = 0;
        RitualUpgrade.treasureCount = 0;

        challengeDropDown.SetActive(false);
        flipper1.SetActive(true);
        flipper2.SetActive(true);
        flipper3.SetActive(true);
        flipper4.SetActive(true);
        flipper5.SetActive(true);
        flipper6.SetActive(true);
        flipper7.SetActive(true);
        flipper8.SetActive(true);
        flipper9.SetActive(true);
        flipper10.SetActive(true);
        flipper11.SetActive(true);
        flipper12.SetActive(true);
        flipper13.SetActive(true);
        flipper14.SetActive(true);
        flipper15.SetActive(true);
        flipper16.SetActive(true);
        flipper17.SetActive(true);
        flipper18.SetActive(true);
        flipper19.SetActive(true);
        flipper20.SetActive(true);
        flipper21.SetActive(true);
        choseTails = 1;
        chooseHeadsOrTailsText.SetActive(false);
        choseCoinSoundEffect.PlayOneShot(choseCoinSound);
        blockScreen.SetActive(true);
        heads.SetActive(false);
        choseTailsText.SetActive(true);
        StartCoroutine(WaitForAim());
        if (Challenges.isChallenge3Active == 1) { GlobalCoins.CoinCount = 0; }
        if (Challenges.isChallenge3Active == 0)
        {
            GlobalCoins.CoinCount = 0 + AscendScreen.startWithCoins + PileOfCoinsMechanics.PileBagAmount;
        }
        MainButtonClick.coinsPerClick = 1;
        pileBagAmount.text = LocalizationStrings.inflatePileOfBagsStats + PileOfCoinsMechanics.PileBagAmount + LocalizationStrings.moreCoinsAfterInflating;
        PileOfCoinsMechanics.PileBagAmount = 0;

        MoreCoinsButton.moreCoinsUpgrades = 0;
        MoreCoinsButton.moreCoinClickValue = 5 * (1 - AscendScreen.cheaperPrice);
        MoreCoinsButton.greaterCoinsCount = 0;
        MoreCoinsButton.greaterCoinsCost = 125 * (1 - AscendScreen.cheaperPrice);
        KnowledgeUpgrade.knowledgeUpgradeCount = 0;
        KnowledgeUpgrade.knowledgeClickValue = 2150 * (1 - AscendScreen.cheaperPrice);
        StrongerFist.fistUpgradeCount = 0;
        StrongerFist.fistCost = 60000 * (1 - AscendScreen.cheaperPrice);
        HandInecjtion.injectionUpgradeCount = 0;
        HandInecjtion.injectionCost = 875000 * (1 - AscendScreen.cheaperPrice);
        BrainPower.brainPowerUpgradeCount = 0;
        BrainPower.brainPowerCost = 85000000 * (1 - AscendScreen.cheaperPrice);
        ExplosiveFlips.explosiveUpgradeCount = 0;
        ExplosiveFlips.explosiveCost = 1200000000 * (1 - AscendScreen.cheaperPrice);
        HydrationButton.hydrationUpgradeCount = 0;
        HydrationButton.hydrationVost = 625000000000 * (1 - AscendScreen.cheaperPrice);
        StrangePotion.potionUpgradeCount = 0;
        StrangePotion.potionCost = 41000000000000 * (1 - AscendScreen.cheaperPrice);
        MasterFlipper.MasterFlipsUpgradeCount = 0;
        MasterFlipper.MasterFlipsCost = 2100000000000000 * (1 - AscendScreen.cheaperPrice);
        HandShake.handShakeUpgradeCount = 0;
        HandShake.handshakeCost = 30000000000000000 * (1 - AscendScreen.cheaperPrice);
        Upgrade12.upgrade12Count = 0;
        Upgrade12.upgrade12Cost = 930000000000000000 * (1 - AscendScreen.cheaperPrice);
        MagicFlipsUpgrade.magicUpgradeCount = 0;
        MagicFlipsUpgrade.magicUpgradeCost = 7500000000000000000000f * (1 - AscendScreen.cheaperPrice);

        GetLuckyHoverOver.luckyChance = 0.5f;


        if (Challenges.isChallenge2Active == 1)
        {
            higherChanceHoverover.headsPercent = 73.75f;
            higherChanceHoverover.tailsPercent = 25.75f;
            MainButtonClick.lowerCoinChance = 150;
            MainButtonClick.higherCoinChance = 149;
            MainButtonClick.lowSpecialChance = 1;
            headsStats.GetComponent<TextMeshProUGUI>().text = higherChanceHoverover.headsPercent + LocalizationStrings.higherChanceHeads;
            tailsStats.GetComponent<TextMeshProUGUI>().text = higherChanceHoverover.tailsPercent + LocalizationStrings.higherChanceTails;
            luckyStats.GetComponent<TextMeshProUGUI>().text = GetLuckyHoverOver.luckyChance + LocalizationStrings.luckyCoinChance;
        }

        if (Challenges.isChallenge4Active == 1)
        {
            headsStats.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.higherChanceHeads;
            tailsStats.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.higherChanceTails;
            luckyStats.GetComponent<TextMeshProUGUI>().text = "100" + LocalizationStrings.luckyCoinChance;
            MainButtonClick.lowSpecialChance = 202;
            MainButtonClick.higherCoinChance = 203;
            MainButtonClick.lowerCoinChance = 204;
        }

        if (Challenges.isChallenge4Active == 0 && Challenges.isChallenge2Active == 0)
        {
            higherChanceHoverover.tailsPercent = 49.75f;
            higherChanceHoverover.headsPercent = 49.75f;
            MainButtonClick.lowSpecialChance = 1;
            MainButtonClick.higherCoinChance = 100;
            MainButtonClick.lowerCoinChance = 101;
            headsStats.GetComponent<TextMeshProUGUI>().text = higherChanceHoverover.headsPercent + LocalizationStrings.higherChanceHeads;
            tailsStats.GetComponent<TextMeshProUGUI>().text = higherChanceHoverover.tailsPercent + LocalizationStrings.higherChanceTails;
            luckyStats.GetComponent<TextMeshProUGUI>().text = GetLuckyHoverOver.luckyChance + LocalizationStrings.luckyCoinChance;
        }


        GlobalCoinMaker.coinsPerFlipUpgrades = 0;
        GlobalCoinMaker.coinValue = 500 * (1 - AscendScreen.specialUpgradeCheaperPrice);
        PurchaseLog.higherChanceUpgradeCount = 0;
        HigherChance.higherChanceValue = 150000 * (1 - AscendScreen.specialUpgradeCheaperPrice);
        PurchaseLog.luckyCoinHigherChanceCount = 0;
        LuckyCoinChance.luckyCoinValue = 175000000 * (1 - AscendScreen.specialUpgradeCheaperPrice);
        GoldenFlipsButton.goldenCoinsUpgradeCount = 0;
        GOLDENFLIPS.specialCoinsButtonCost = 12000000000000000 * (1 - AscendScreen.specialUpgradeCheaperPrice);
        MainButtonClick.numberOfDuplicationUpgrades = 0;
        DuplicateCoin.duplicatePrice = 75;
        PileOfCoins.pileOfCoinsCost = 20000 * (1 - AscendScreen.specialUpgradeCheaperPrice);
        PileOfCoinsMechanics.totalAmountOfPileGenerated = 0;
        PurchaseLog.gambleChances = 5 + AscendScreen.moreGambleChances;

        PileOfCoinsMechanics.PileOfCoinsAmount1 = 0;
        PileOfCoinsMechanics.PileOfCoinsAmount2 = 0;
        PileOfCoinsMechanics.PileOfCoinsAmount3 = 0;
        PileOfCoinsMechanics.PileOfCoinsAmount4 = 0;
        PileOfCoinsMechanics.PileOfCounsBoughtFirstTime = 0;

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
        PurchaseLog.treasureInfo = 0;
        PurchaseLog.ritualInfo = 0;

        AscendCoins.gained1Mill = 1;
        AscendCoins.gained250Mill = 1;
        AscendCoins.gained500Mill = 1;
        AscendCoins.gained750Mill = 1;

        AscendCoins.gained1Billion = 1;
        AscendCoins.gained250Billion = 1;
        AscendCoins.gained500Billion = 1;
        AscendCoins.gained750Billion = 1;

        AscendCoins.gained1Trillion = 1;
        AscendCoins.gained250Trillion = 1;
        AscendCoins.gained500Trillion = 1;
        AscendCoins.gained750Trillion = 1;

        AscendCoins.gained1Quadrillion = 1;
        AscendCoins.gained250Quadrillion = 1;
        AscendCoins.gained500Quadrillion = 1;
        AscendCoins.gained750Quadrillion = 1;

        AscendCoins.gained1Quintillion = 1;
        AscendCoins.gained250Quintillion = 1;
        AscendCoins.gained500Quintillion = 1;
        AscendCoins.gained750Quintillion = 1;

        AscendCoins.gained1Sextillion = 1;
        AscendCoins.gained250Sextillion = 1;
        AscendCoins.gained500Sextillion = 1;
        AscendCoins.gained750Sextillion = 1;

        AscendCoins.gained1Septillion = 1;
        AscendCoins.gained250Septillion = 1;
        AscendCoins.gained500Septillion = 1;
        AscendCoins.gained750Septillion = 1;

        AscendCoins.gained1octillion = 1;
        AscendCoins.gained250octillion = 1;
        AscendCoins.gained500octillion = 1;
        AscendCoins.gained750octillion = 1;

        AscendCoins.gained1nonillion = 1;
        AscendCoins.gained250nonillion = 1;
        AscendCoins.gained500nonillion = 1;
        AscendCoins.gained750nonillion = 1;

        AscendCoins.gained1Decillion = 1;
        AscendCoins.gained250Decillion = 1;
        AscendCoins.gained500Decillion = 1;
        AscendCoins.gained750Decillion = 1;

        AscendCoins.gained1Undecillion = 1;
        AscendCoins.gained250Undecillion = 1;
        AscendCoins.gained500Undecillion = 1;
        AscendCoins.gained750Undecillion = 1;

        if (AscendScreen.boughtGreaterAscension1 == 0)
        {
            AscendCoins.millionGet = 1;
            AscendCoins.billionGet = 1;
            AscendCoins.trillionGet = 1;
            AscendCoins.quadrillionGet = 1;
            AscendCoins.quintillionGet = 1;
            AscendCoins.sextillionGet = 1;
            AscendCoins.septillionGet = 1;
            AscendCoins.octillionGet = 1;
            AscendCoins.nonillionGet = 1;
            AscendCoins.decillionGet = 1;
            AscendCoins.undecillionGet = 1;
        }

        PileOfCoinsMechanics.waitTime = 65;
        PurchaseLog.pileOfCoinsCount = 0;

        if (AscendScreen.boughtSpecial2 == 0)
        {
            PurchaseLog.gambleChanceEachTimeWIN = 50;
            PurchaseLog.gambleChanceEachTimeLOOSE = 50;
            gambleWinText.GetComponent<TextMeshProUGUI>().text = PurchaseLog.gambleChanceEachTimeWIN + LocalizationStrings.gambleWinChance;
            gambleLooseText.GetComponent<TextMeshProUGUI>().text = PurchaseLog.gambleChanceEachTimeLOOSE + LocalizationStrings.gambleLoseChance;
        }
        if (AscendScreen.boughtSpecial2 == 1)
        {
            PurchaseLog.gambleChanceEachTimeWIN = 51;
            PurchaseLog.gambleChanceEachTimeLOOSE = 49;
            gambleWinText.GetComponent<TextMeshProUGUI>().text = PurchaseLog.gambleChanceEachTimeWIN + LocalizationStrings.gambleWinChance;
            gambleLooseText.GetComponent<TextMeshProUGUI>().text = PurchaseLog.gambleChanceEachTimeLOOSE + LocalizationStrings.gambleLoseChance;
        }
        if (AscendScreen.boughtSpecial2 == 1 && AscendScreen.boughtSpecialGAMBLEr == 1)
        {
            PurchaseLog.gambleChanceEachTimeWIN = 51;
            PurchaseLog.gambleChanceEachTimeLOOSE = 49;
            gambleWinText.GetComponent<TextMeshProUGUI>().text = PurchaseLog.gambleChanceEachTimeWIN + LocalizationStrings.gambleWinChance;
            gambleLooseText.GetComponent<TextMeshProUGUI>().text = PurchaseLog.gambleChanceEachTimeLOOSE + LocalizationStrings.gambleLoseChance;
        }

        pileText1.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.coins;
        pileText2.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.coins;
        pileText3.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.coins;
        pileText4.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.coins;
        pileText5.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.coins;

        pileCountText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + PurchaseLog.pileOfCoinsCount;
        pileWaitTimeText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.pileGeneratesEveyXSecond + PileOfCoinsMechanics.waitTime + LocalizationStrings.seconds;
        pileStatsText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.pileTotalGenerated + "0" + LocalizationStrings.coins;
        strongerArmsText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.your + "0" + LocalizationStrings.statsStrongerArm + "0" + LocalizationStrings.coins;
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
        chestText.text = LocalizationStrings.buyUpgrade;
        ritualText.text = LocalizationStrings.buyUpgrade;

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

        GABPILEText.text = LocalizationStrings.inflatePileOfBagsStats + "0" + LocalizationStrings.moreCoinsAfterInflating;

        autoScript.CheckBlockUpgrades();
        SetInflationCoinsSave();
    }

    IEnumerator WaitForAim()
    {
        yield return new WaitForSeconds(2.3f);
        
        blockScreen.SetActive(false);
        headsOrTails.SetActive(false);
        heads.SetActive(true);
        tails.SetActive(true);
        choseTailsText.SetActive(false);
        choseHeadsText.SetActive(false);
    }

    public void SetInflationCoinsSave()
    {
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
    }
}
