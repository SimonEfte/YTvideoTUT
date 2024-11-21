using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadUpdateSaves : MonoBehaviour
{
    void Start()
    {
        //Ascension upgrades load

        AscendScreen.totalSpecialReduction = PlayerPrefs.GetInt("SavedspecialUpgradeReduction");
        AscendScreen.boughtRich1 = PlayerPrefs.GetInt("SavedBoughtRich1");
        AscendScreen.boughtRich2 = PlayerPrefs.GetInt("SavedBoughtRich2");
        AscendScreen.boughtRich3 = PlayerPrefs.GetInt("SavedBoughtRich3");
        AscendScreen.boughtRich4 = PlayerPrefs.GetInt("SavedBoughtRich4");
        AscendScreen.boughtRich5 = PlayerPrefs.GetInt("SavedBoughtRich5");
        AscendScreen.boughtRich6 = PlayerPrefs.GetInt("SavedBoughtRich6");
        AscendScreen.boughtRichSUPER = PlayerPrefs.GetInt("SavedBoughtRich7");

        AscendScreen.boughtSale1 = PlayerPrefs.GetInt("SavedBoughtSale1");
        AscendScreen.boughtSale2 = PlayerPrefs.GetInt("SavedBoughtSale2");
        AscendScreen.boughtSale3 = PlayerPrefs.GetInt("SavedBoughtSale3");
        AscendScreen.boughtSale4 = PlayerPrefs.GetInt("SavedBoughtSale4");
        AscendScreen.boughtSTEAMSALE = PlayerPrefs.GetInt("SavedBoughtSTEAMSALE");

        AscendScreen.boughtActiveFlipper1 = PlayerPrefs.GetInt("SavedBoughtActiveFlipper1");
        AscendScreen.boughtActiveFlipper2 = PlayerPrefs.GetInt("SavedBoughtActiveFlipper2");
        AscendScreen.boughtActiveFlipper3 = PlayerPrefs.GetInt("SavedBoughtActiveFlipper3");
        AscendScreen.boughtActiveFlipper4 = PlayerPrefs.GetInt("SavedBoughtActiveFlipper4");
        AscendScreen.boughtActiveFlipperSUPER = PlayerPrefs.GetInt("SavedBoughtActiveFlipperSUPER");
        AscendScreen.boughtActiveFlipperPILOFCOINS = PlayerPrefs.GetInt("SavedBoughtActiveFlipperPILEOFCOINS");

        AscendScreen.boughtBagOfCoins1 = PlayerPrefs.GetInt("SavedBoughtBag1");
        AscendScreen.boughtBagOfCoins2 = PlayerPrefs.GetInt("SavedBoughtBag2");
        AscendScreen.boughtBagOfCoins3 = PlayerPrefs.GetInt("SavedBoughtBag3");
        AscendScreen.boughtBagOfCoins4 = PlayerPrefs.GetInt("SavedBoughtBag4");
        AscendScreen.boughtBagOfCoinsSUPER = PlayerPrefs.GetInt("SavedBoughtBagSUPER");

        AscendScreen.boughtSpecial1 = PlayerPrefs.GetInt("SavedboughtSpecial1");
        AscendScreen.boughtSpecial2 = PlayerPrefs.GetInt("SavedboughtSpecial2");
        AscendScreen.boughtSpecial3 = PlayerPrefs.GetInt("SavedboughtSpecial3");
        AscendScreen.boughtSpecial4 = PlayerPrefs.GetInt("SavedboughtSpecial4");
        AscendScreen.boughtSpecialSUPER = PlayerPrefs.GetInt("SavedboughtSpecialSUPER");
        AscendScreen.boughtSpecialGAMBLEr = PlayerPrefs.GetInt("SavedboughtSpecialGAMBLER");
        AscendScreen.boughtSpecialBIGGERPILE = PlayerPrefs.GetInt("SavedboughtSpecialPILE");
        AscendScreen.boughtSpecialBIGGERPILE2 = PlayerPrefs.GetInt("SavedboughtSpecialPILE2");
        AscendScreen.boughtSpecialLUCKER = PlayerPrefs.GetInt("SavedboughtSpecialLUCKIER");

        AscendScreen.boughtGreaterAscension1 = PlayerPrefs.GetInt("SavedGreaterAscension1");
        AscendScreen.boughtGreaterAscension2 = PlayerPrefs.GetInt("SavedGreaterAscension2");
        AscendScreen.boughtGreaterAscension3 = PlayerPrefs.GetInt("SavedGreaterAscension3");
        AscendScreen.boughtGreaterAscension4 = PlayerPrefs.GetInt("SavedGreaterAscension4");
        AscendScreen.boughtGreaterAscension5 = PlayerPrefs.GetInt("SavedGreaterAscension5");
        AscendScreen.boughtGreaterAscensionSUPER = PlayerPrefs.GetInt("SavedGreaterAscensionSUPER");
        AscendScreen.boughtGreaterAscensionGamble1 = PlayerPrefs.GetInt("SavedGreaterAscensionGAMLE1");
        AscendScreen.boughtGreaterAscensionGamble2 = PlayerPrefs.GetInt("SavedGreaterAscensionGAMLE2");
        AscendScreen.boughtGreaterAscensionGamble3 = PlayerPrefs.GetInt("SavedGreaterAscensionGAMLE3");
        AscendScreen.boughtGreaterAscensionGamble4 = PlayerPrefs.GetInt("SavedGreaterAscensionGAMLE4");
        PileOfCoinsMechanics.totalAmountOfPileGenerated = PlayerPrefs.GetFloat("SavedTotalPileAmount");

        AscendCoins.gained1Mill = PlayerPrefs.GetInt("SavedGained1Mill");
        AscendCoins.gained250Mill = PlayerPrefs.GetInt("SavedGained250Mill");
        AscendCoins.gained500Mill = PlayerPrefs.GetInt("SavedGained500Mill");
        AscendCoins.gained750Mill = PlayerPrefs.GetInt("SavedGained750Mill");

        AscendCoins.gained1Billion = PlayerPrefs.GetInt("SavedGained1Billion");
        AscendCoins.gained250Billion = PlayerPrefs.GetInt("SavedGained250Billion");
        AscendCoins.gained500Billion = PlayerPrefs.GetInt("SavedGained500Billion");
        AscendCoins.gained750Billion = PlayerPrefs.GetInt("SavedGained750Billion");

        AscendCoins.gained1Trillion = PlayerPrefs.GetInt("SavedGained1Tillion");
        AscendCoins.gained250Trillion = PlayerPrefs.GetInt("SavedGained250Tillion");
        AscendCoins.gained500Trillion = PlayerPrefs.GetInt("SavedGained500Tillion");
        AscendCoins.gained750Trillion = PlayerPrefs.GetInt("SavedGained750Tillion");

        AscendCoins.gained1Quadrillion = PlayerPrefs.GetInt("SavedGained1Quadrillion");
        AscendCoins.gained250Quadrillion = PlayerPrefs.GetInt("SavedGained250Quadrillion");
        AscendCoins.gained500Quadrillion = PlayerPrefs.GetInt("SavedGained500Quadrillion");
        AscendCoins.gained750Quadrillion = PlayerPrefs.GetInt("SavedGained750Quadrillion");

        AscendCoins.gained1Quintillion = PlayerPrefs.GetInt("SavedGained1Quintillion");
        AscendCoins.gained250Quintillion = PlayerPrefs.GetInt("SavedGained250Quintillion");
        AscendCoins.gained500Quintillion = PlayerPrefs.GetInt("SavedGained500Quintillion");
        AscendCoins.gained750Quintillion = PlayerPrefs.GetInt("SavedGained750Quintillion");

        AscendCoins.gained1Sextillion = PlayerPrefs.GetInt("SavedGained1Sextillion");
        AscendCoins.gained250Sextillion = PlayerPrefs.GetInt("SavedGained250Sextillion");
        AscendCoins.gained500Sextillion = PlayerPrefs.GetInt("SavedGained500Sextillion");
        AscendCoins.gained750Sextillion = PlayerPrefs.GetInt("SavedGained750Sextillion");

        AscendCoins.gained1Septillion = PlayerPrefs.GetInt("SavedGained1Septillion");
        AscendCoins.gained250Septillion = PlayerPrefs.GetInt("SavedGained250Septillion");
        AscendCoins.gained500Septillion = PlayerPrefs.GetInt("SavedGained500Septillion");
        AscendCoins.gained750Septillion = PlayerPrefs.GetInt("SavedGained750Septillion");

        AscendCoins.gained1octillion = PlayerPrefs.GetInt("SavedGained1Octillion");
        AscendCoins.gained250octillion = PlayerPrefs.GetInt("SavedGained250Octillion");
        AscendCoins.gained500octillion = PlayerPrefs.GetInt("SavedGained500Octillion");
        AscendCoins.gained750octillion = PlayerPrefs.GetInt("SavedGained750Octillion");

        AscendCoins.gained1nonillion = PlayerPrefs.GetInt("SavedGained1nonillion");
        AscendCoins.gained250nonillion = PlayerPrefs.GetInt("SavedGained250nonillion");
        AscendCoins.gained500nonillion = PlayerPrefs.GetInt("SavedGained500nonillion");
        AscendCoins.gained750nonillion = PlayerPrefs.GetInt("SavedGained750nonillion");

        AscendCoins.gained1Decillion = PlayerPrefs.GetInt("SavedGained1Decillion");
        AscendCoins.gained250Decillion = PlayerPrefs.GetInt("SavedGained250Decillion");
        AscendCoins.gained500Decillion = PlayerPrefs.GetInt("SavedGained500Decillion");
        AscendCoins.gained750Decillion = PlayerPrefs.GetInt("SavedGained750Decillion");

        AscendCoins.gained1Undecillion = PlayerPrefs.GetInt("SavedGained1Undecillion");
        AscendCoins.gained250Undecillion = PlayerPrefs.GetInt("SavedGained250Undecillion");
        AscendCoins.gained500Undecillion = PlayerPrefs.GetInt("SavedGained500Undecillion");
        AscendCoins.gained750Undecillion = PlayerPrefs.GetInt("SavedGained750Undecillion");


        AscendCoins.ascensionCoinAmount = PlayerPrefs.GetInt("SavedAscensionCoinAmount");
        AscendCoins.luckyAscendCoin = PlayerPrefs.GetInt("SavedLuckyAscendCoin");
        AscendScreen.startWithCoins = PlayerPrefs.GetFloat("SavedStartWithCoins");
        AscendScreen.coinMulitplier = PlayerPrefs.GetFloat("SavedCoinMultiplierRICHUPGRADES");
        AscendScreen.cheaperPrice = PlayerPrefs.GetFloat("SavedCheaperPrice");
        AscendScreen.specialUpgradeCheaperPrice = PlayerPrefs.GetFloat("SavedSpecialUpgradeCheaperPrice");
        AscendScreen.luckyCoinMiltiplier = PlayerPrefs.GetInt("SavedLuckyCoinMultiplier");
        AscendScreen.activeFlipperMiltiplier = PlayerPrefs.GetFloat("SavedActiveFlipperMultiplier");
        AscendScreen.morePileOfCoinsGain = PlayerPrefs.GetInt("SavedMorePileOfCoinsGain");
        AscendScreen.isGamblerPurchased = PlayerPrefs.GetInt("SavedIsGamblerPurchased");
        AscendScreen.isSpecialUpgrade3Baugh = PlayerPrefs.GetInt("SavedIsSpecialUpgrade3Bought");
        AscendScreen.specialFlipperCoinMultiplier = PlayerPrefs.GetInt("SavedSpecialFlipperCoinMultiplier");
        AscendScreen.specialFlipperCoinLuckyMultiplier = PlayerPrefs.GetInt("SavedSpecialFlipperCoinLuckyMultiplier");
        PurchaseLog.pileOfCoinsCount = PlayerPrefs.GetInt("SavedPileCouns");
        AscendScreen.moreGambleChances = PlayerPrefs.GetInt("SaveMoreGambleChances");


        PurchaseLog.gambleChances = PlayerPrefs.GetInt("SavedGambleChancesCount");
        PurchaseLog.gambleChanceEachTimeWIN = PlayerPrefs.GetInt("SavedGambleChancesEachTimeWIN");
        PurchaseLog.gambleChanceEachTimeLOOSE = PlayerPrefs.GetInt("SavedGambleChancesEachTimeLOOSE");
        PurchaseLog.isGambleBoughtOnce = PlayerPrefs.GetInt("SavedIsGambleBoughtOnce");
        PurchaseLog.amountOfTimesGambled = PlayerPrefs.GetInt("SavedTotalGambledAmount");
        PurchaseLog.amountOfTimesGambledWON = PlayerPrefs.GetInt("SavedTotalGambledAmountWON");
        PurchaseLog.amountOfTimesGambledLOST = PlayerPrefs.GetInt("SavedTotalGambledAmountLOST");

        PileOfCoins.pileOfCoinsCost = PlayerPrefs.GetFloat("SavedPileCost");
        PileOfCoinsMechanics.isPile1Unlocked = PlayerPrefs.GetInt("SavedIsPile1Unlocked");
        PileOfCoinsMechanics.isPile2Unlocked = PlayerPrefs.GetInt("SavedIsPile2Unlocked");
        PileOfCoinsMechanics.isPile3Unlocked = PlayerPrefs.GetInt("SavedIsPile3Unlocked");
        PileOfCoinsMechanics.isPile4Unlocked = PlayerPrefs.GetInt("SavedIsPile4Unlocked");
        PileOfCoinsMechanics.isPile5Unlocked = PlayerPrefs.GetInt("SavedIsPile5Unlocked");
        PileOfCoinsMechanics.PileOfCoinsAmount1 = PlayerPrefs.GetFloat("SavedPileOfCoinsAmount1");
        PileOfCoinsMechanics.PileOfCoinsAmount2 = PlayerPrefs.GetFloat("SavedPileOfCoinsAmount2");
        PileOfCoinsMechanics.PileOfCoinsAmount3 = PlayerPrefs.GetFloat("SavedPileOfCoinsAmount3");
        PileOfCoinsMechanics.PileOfCoinsAmount4 = PlayerPrefs.GetFloat("SavedPileOfCoinsAmount4");
        PileOfCoinsMechanics.PileOfCoinsAmount5 = PlayerPrefs.GetFloat("SavedPileOfCoinsAmount5");
        PileOfCoinsMechanics.PileOfCounsBoughtFirstTime = PlayerPrefs.GetInt("SavedIsPileBoughtFirstTime");

        AscendCoins.millionGet = PlayerPrefs.GetInt("SavedMillionGet");
        AscendCoins.billionGet = PlayerPrefs.GetInt("SavedBillionGet");
        AscendCoins.trillionGet = PlayerPrefs.GetInt("SavedTrillionGet");
        AscendCoins.quadrillionGet = PlayerPrefs.GetInt("SavedQuadrillionGet");
        AscendCoins.quintillionGet = PlayerPrefs.GetInt("SavedQuintillionGet");
        AscendCoins.sextillionGet = PlayerPrefs.GetInt("SavedSextillionGet");
        AscendCoins.septillionGet = PlayerPrefs.GetInt("SavedSeptillionGet");
        AscendCoins.octillionGet = PlayerPrefs.GetInt("SavedOctillionGet");
        AscendCoins.nonillionGet = PlayerPrefs.GetInt("SavedNonillionGet");
        AscendCoins.decillionGet = PlayerPrefs.GetInt("SavedDecillionGet");
        AscendCoins.undecillionGet = PlayerPrefs.GetInt("SavedUndecillion");

        PileOfCoinsMechanics.waitTime = PlayerPrefs.GetInt("SavedPileWaitTime");
        AscendScreen.isActivePilePurchased = PlayerPrefs.GetInt("IsActivePileBought");
        AscendScreen.ascendUpgradeAmount = PlayerPrefs.GetInt("SavedAscendUpgradeCount");
        Ascend.AscendTimesAmount = PlayerPrefs.GetInt("SavedAscendTimesAmount");
        PileOfCoinsMechanics.incrementPileOfCoinsAmount = PlayerPrefs.GetInt("SavedClickedOnPileAmount");
        AscendScreen.hitEvenLuckerCoin = PlayerPrefs.GetInt("SavedEvenLuckierCoin");
        MainButtonClick.activeFlipsAmount = PlayerPrefs.GetInt("ActiveFlipps");


        Achievements.ACH1IsUnlocked = PlayerPrefs.GetInt("ACH1");
        Achievements.ACH2IsUnlocked = PlayerPrefs.GetInt("ACH2");
        Achievements.ACH3IsUnlocked = PlayerPrefs.GetInt("ACH3");
        Achievements.ACH4IsUnlocked = PlayerPrefs.GetInt("ACH4");
        Achievements.ACH5IsUnlocked = PlayerPrefs.GetInt("ACH5");
        Achievements.ACH6IsUnlocked = PlayerPrefs.GetInt("ACH6");
        Achievements.ACH7IsUnlocked = PlayerPrefs.GetInt("ACH7");
        Achievements.ACH8IsUnlocked = PlayerPrefs.GetInt("ACH8");
        Achievements.ACH9IsUnlocked = PlayerPrefs.GetInt("ACH9");
        Achievements.ACH10IsUnlocked = PlayerPrefs.GetInt("ACH10");
        Achievements.ACH11IsUnlocked = PlayerPrefs.GetInt("ACH11");
        Achievements.ACH12IsUnlocked = PlayerPrefs.GetInt("ACH12");
        Achievements.ACH13IsUnlocked = PlayerPrefs.GetInt("ACH13");
        Achievements.ACH14IsUnlocked = PlayerPrefs.GetInt("ACH14");
        Achievements.ACH15IsUnlocked = PlayerPrefs.GetInt("ACH15");
        Achievements.ACH16IsUnlocked = PlayerPrefs.GetInt("ACH16");
        Achievements.ACH17IsUnlocked = PlayerPrefs.GetInt("ACH17");
        Achievements.ACH18IsUnlocked = PlayerPrefs.GetInt("ACH18");
        Achievements.ACH19IsUnlocked = PlayerPrefs.GetInt("ACH19");
        Achievements.ACH20IsUnlocked = PlayerPrefs.GetInt("ACH20");
        Achievements.ACH21IsUnlocked = PlayerPrefs.GetInt("ACH21");
        Achievements.ACH22IsUnlocked = PlayerPrefs.GetInt("ACH22");
        Achievements.ACH23IsUnlocked = PlayerPrefs.GetInt("ACH23");
        Achievements.ACH24IsUnlocked = PlayerPrefs.GetInt("ACH24");
        Achievements.ACH25IsUnlocked = PlayerPrefs.GetInt("ACH25");
        Achievements.ACH26IsUnlocked = PlayerPrefs.GetInt("ACH26");
        Achievements.ACH27IsUnlocked = PlayerPrefs.GetInt("ACH27");
        Achievements.ACH28IsUnlocked = PlayerPrefs.GetInt("ACH28");
        Achievements.ACH29IsUnlocked = PlayerPrefs.GetInt("ACH29");
        Achievements.ACH30IsUnlocked = PlayerPrefs.GetInt("ACH30");
        Achievements.ACH31IsUnlocked = PlayerPrefs.GetInt("ACH31");
        Achievements.ACH32IsUnlocked = PlayerPrefs.GetInt("ACH32");
        Achievements.ACH33IsUnlocked = PlayerPrefs.GetInt("ACH33");
        Achievements.ACH34IsUnlocked = PlayerPrefs.GetInt("ACH34");
        Achievements.ACH35IsUnlocked = PlayerPrefs.GetInt("ACH35");
        Achievements.ACH36IsUnlocked = PlayerPrefs.GetInt("ACH36");
        Achievements.ACH37IsUnlocked = PlayerPrefs.GetInt("ACH37");
        Achievements.ACH38IsUnlocked = PlayerPrefs.GetInt("ACH38");
        Achievements.ACH39IsUnlocked = PlayerPrefs.GetInt("ACH39");
        Achievements.ACH40IsUnlocked = PlayerPrefs.GetInt("ACH40");
        Achievements.ACH41IsUnlocked = PlayerPrefs.GetInt("ACH41");
        Achievements.ACH42IsUnlocked = PlayerPrefs.GetInt("ACH42");
        Achievements.ACH43IsUnlocked = PlayerPrefs.GetInt("ACH43");
        Achievements.ACH44IsUnlocked = PlayerPrefs.GetInt("ACH44");
        Achievements.ACH45IsUnlocked = PlayerPrefs.GetInt("ACH45");
        Achievements.ACH46IsUnlocked = PlayerPrefs.GetInt("ACH46");
        Achievements.ACH47IsUnlocked = PlayerPrefs.GetInt("ACH47");
        Achievements.ACH48IsUnlocked = PlayerPrefs.GetInt("ACH48");
        Achievements.ACH49IsUnlocked = PlayerPrefs.GetInt("ACH49");
        Achievements.ACH50IsUnlocked = PlayerPrefs.GetInt("ACH50");
        Achievements.ACH51IsUnlocked = PlayerPrefs.GetInt("ACH51");
        Achievements.ACH52IsUnlocked = PlayerPrefs.GetInt("ACH52");
        Achievements.ACH53IsUnlocked = PlayerPrefs.GetInt("ACH53");
        Achievements.ACH54IsUnlocked = PlayerPrefs.GetInt("ACH54");
        Achievements.ACH55IsUnlocked = PlayerPrefs.GetInt("ACH55");
        Achievements.ACH56IsUnlocked = PlayerPrefs.GetInt("ACH56");
        Achievements.ACH57IsUnlocked = PlayerPrefs.GetInt("ACH57");
        Achievements.ACH58IsUnlocked = PlayerPrefs.GetInt("ACH58");
        Achievements.ACH59IsUnlocked = PlayerPrefs.GetInt("ACH59");
        Achievements.ACH60IsUnlocked = PlayerPrefs.GetInt("ACH60");
        Achievements.ACH61IsUnlocked = PlayerPrefs.GetInt("ACH61");
        Achievements.ACH62IsUnlocked = PlayerPrefs.GetInt("ACH62");

        AchievementsUpdate.ACH1IsUnlocked = PlayerPrefs.GetInt("ACH63");
        AchievementsUpdate.ACH2IsUnlocked = PlayerPrefs.GetInt("ACH64");
        AchievementsUpdate.ACH3IsUnlocked = PlayerPrefs.GetInt("ACH65");
        AchievementsUpdate.ACH4IsUnlocked = PlayerPrefs.GetInt("ACH66");
        AchievementsUpdate.ACH5IsUnlocked = PlayerPrefs.GetInt("ACH67");
        AchievementsUpdate.ACH6IsUnlocked = PlayerPrefs.GetInt("ACH68");
        AchievementsUpdate.ACH7IsUnlocked = PlayerPrefs.GetInt("ACH69");
        AchievementsUpdate.ACH8IsUnlocked = PlayerPrefs.GetInt("ACH70");
        AchievementsUpdate.ACH9IsUnlocked = PlayerPrefs.GetInt("ACH71");
        AchievementsUpdate.ACH10IsUnlocked = PlayerPrefs.GetInt("ACH72");
        AchievementsUpdate.ACH11IsUnlocked = PlayerPrefs.GetInt("ACH73");
        AchievementsUpdate.ACH12IsUnlocked = PlayerPrefs.GetInt("ACH74");
        AchievementsUpdate.ACH13IsUnlocked = PlayerPrefs.GetInt("ACH75");
        AchievementsUpdate.ACH14IsUnlocked = PlayerPrefs.GetInt("ACH76");
        AchievementsUpdate.ACH15IsUnlocked = PlayerPrefs.GetInt("ACH77");
        AchievementsUpdate.ACH16IsUnlocked = PlayerPrefs.GetInt("ACH78");
        AchievementsUpdate.ACH17IsUnlocked = PlayerPrefs.GetInt("ACH79");
        AchievementsUpdate.ACH18IsUnlocked = PlayerPrefs.GetInt("ACH80");
        AchievementsUpdate.ACH19IsUnlocked = PlayerPrefs.GetInt("ACH81");
        AchievementsUpdate.ACH20IsUnlocked = PlayerPrefs.GetInt("ACH82");

        //1.2Update Load
        TreasureChest.treasureCost = PlayerPrefs.GetFloat("SavedChestCost");
        TreasureChest.treasureCount = PlayerPrefs.GetInt("SavedChestCount");
        RitualUpgrade.ritualCost = PlayerPrefs.GetFloat("SavedRitualCost");
        RitualUpgrade.treasureCount = PlayerPrefs.GetInt("SavedRitualCount");

        PurchaseLog.treasureInfo = PlayerPrefs.GetFloat("SavedChestInfo");
        PurchaseLog.ritualInfo = PlayerPrefs.GetFloat("SavedRitualInfo");

        EndlessInflation.inflationUpgadeCount = PlayerPrefs.GetInt("SavedEndellInflationCount");
        EndlessInflation.endlessInflationPrice = PlayerPrefs.GetInt("SavedEndellInflationPrice");
        if (!PlayerPrefs.HasKey("SavedEndellInflationPrice"))
        {
            EndlessInflation.endlessInflationPrice = 1;
        }
        EndlessInflation.endlessInflationBonus = PlayerPrefs.GetFloat("SavedEndellInflationBonus");
        EndlessInflation.englessInflationBonusText = PlayerPrefs.GetInt("SavedEndellBonusText");

    }

 
}
