using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LocalizationStrings : MonoBehaviour
{
    public TextMeshProUGUI HeadsOrTails;
    public TextMeshProUGUI youChoseHeads, youChoseTails;
    public TextMeshProUGUI challenge1Name, challenge2Name, challenge3Name, challenge4Name;
    public TextMeshProUGUI challenge1Text, challenge2Text, challenge3Text, challenge4Text;
    public TextMeshProUGUI challengesText;
    public TextMeshProUGUI challengeNegative1, challengeNegative2, challengeNegative3, challengeNegative4;
    public TextMeshProUGUI Goal1text, Goal2text, Goal3text, Goal4text;
    public TextMeshProUGUI Goal1textInfo, Goal2textInfo, Goal3textInfo, Goal4textInfo;
    public TextMeshProUGUI Reward1Text, Reward2Text, Reward3Text, Reward4Text;
    public TextMeshProUGUI Reward1TextInfo, Reward2TextInfo, Reward3TextInfo, Reward4TextInfo;
    public TextMeshProUGUI challengePositive1, challengepositive2;
    public TextMeshProUGUI questionInfo;
    public TextMeshProUGUI upgrade1, upgrade2, upgrade3, upgrade4, upgrade5, upgrade6, upgrade7, upgrade8, upgrade9, upgrade10, upgrade11, upgrade12, upgrade13, upgrade14, upgrade15;
    public TextMeshProUGUI upgrade1n, upgrade2n, upgrade3n, upgrade4n, upgrade5n, upgrade6n, upgrade7n, upgrade8n, upgrade9n, upgrade10n, upgrade11n, upgrade12n, upgrade13n, upgrade14n, upgrade15n;
    public TextMeshProUGUI price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12, price13, price14, price15, price16, price17, price18, price19, price20;
    public TextMeshProUGUI price1c, price2c, price3c, price4c, price5c, price6c, price7c, price8c, price9c, price10c, price11c, price12c, price13c, price14c, price15c, price16c, price17c, price18c, price19c, price20c;
    public static string strongerArmName, greaterCoinName, knowledgeName, strongerFistName, handInjectionName, brainPowerName, explosiveFlipsName, hydrationName, strangePotionName;
    public static string masterFlipperName, handShakeName, highFiveName, magicFlipsName, TreasueChestName, coinFlippingRitualName;
    public static string thousand, million, billion, trillion, quadrillion, quintillion, sextillion, septillion, octillion, nonillion, decillion, undecillion;
    public static string thousandC, millionc, billionc, trillionc, quadrillionc, quintillionc, sextillionc, septillionc, octillionc, nonillionc, decillionc, undecillionc;
    public static string coins;
    public static string coin;
    public static string coinsOnHeads, coinsOnTails;
    public TextMeshProUGUI flipAll, on, off, autoFlipsQeuals, autoUpgrade, current, gamble, autoFlips, pileOfCoins, higherChance, getLucky, endlessInflation, upgradedFlips;
    public TextMeshProUGUI  on2, off2, autoFlipsc, pileOfCoinsc, higherChancec, getLuckyc, upgradedFlipsc, gamblec, diplicateFlips, diplicateFlipsc;
    public TextMeshProUGUI chooseAutoUpgrade;
    public TextMeshProUGUI unlockedViaChal1;
    public TextMeshProUGUI unlcokedViaInf;
    public static string autoUpgradeName, pileOfCoinsName, higherChanceName, getLuckyName, upgradedFlipsName, flipMoreCoinsName;
    public static string maxedOut, spendNoMore, theyAllFlip;
    public TextMeshProUGUI hover1Name, hover2Name, hover3Name, hover4Name, hover5Name, hover6Name, hover7Name, hover8Name, hover9Name, hover10Name, hover11Name, hover12Name, hover13Name, hover14Name, hover15Name;
    public TextMeshProUGUI hoverFlipAll, hoverAutoUpgrade, hovergamble, hoverAutoFlip, hoverPile, hoverhigherChance, hoverLucky, hoverEndless, hoverUpgradedFlips, hoverOff, hoverOn;
    public TextMeshProUGUI purchased1, purchased2, purchased3, purchased4, purchased5, purchased6, purchased7, purchased8, purchased9, purchased10, purchased11, purchased12, purchased13, purchased14, purchased15, purchased16, purchased17, purchased18, purchased19, purchased20, purchased21;
    public static string purchased;
    public TextMeshProUGUI description1, description2, description3, description4, description5, description6, description7, description8, description9, description10, description11, description12, description13, description14, description15, description16, description17, description18, description19, description20, description21, description22, description23;
    public TextMeshProUGUI descEndless1, descEndless2;
    public TextMeshProUGUI hoverCost1, hoverCost2, hoverCost3, hoverCost4, hoverCost5, hoverCost6, hoverCost7, hoverCost8, hoverCost9, hoverCost10, hoverCost11, hoverCost12, hoverCost13, hoverCost14, hoverCost15, hoverCost16, hoverCost17, hoverCost18, hoverCost19, hoverCost20, hoverCost21;
    public TextMeshProUGUI p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21;
    public static string plussCoins, plussthousandCoins, plussMillionCoins, plussBillionCoins, plussTrillionCoins, plussQuadrillionCoins, plussQuintillionCoins,plussSextillionCoins, plussSeptillionCoins;
    public TextMeshProUGUI pluss1, pluss2, pluss3, pluss4, pluss5, pluss6, pluss7, pluss8, pluss9, pluss10, pluss11, pluss12, pluss13, pluss14, pluss15;
    public TextMeshProUGUI gambleTries, gambleChanceToWin, gambleChanceToLoose, gambleReset, gamblePreventCheating;
    public TextMeshProUGUI pileGenerates, pileMinus1Second, chanceToHitHeads, chanceToHitTails, chanceToHitLuckyCoin, endlessInflationPercent, endlessInflationCoin, plussUpgradedCoinFlipper, needs21CoinFlippers;
    public static string times, gambleWinChance, gambleLoseChance, pileGeneratesEveyXSecond, higherChanceTails, higherChanceHeads,luckyCoinChance,endlessInflationCost,endlessInflationPercentString, needs21Flippers,gambleTriesString,
        seconds;
    public TextMeshProUGUI gambleTriesStringText;
    public static string your;
    public static string buyUpgrade;
    public static string statsStrongerArm, statsGreater, statsKnowledge, statsFist, statsInjection, statsBrain, statsExplosive, statsHydration, statsPorion, statsMaster, statsHandshake, statsHighFive, statsMagic, statsTreasure, statsRitual;
    public static string youHaveFlipped, youHaveActivelyFlipped, totalCoinsOnHeads, totalCoinsOnTails, totalLockyCoins;
    public TextMeshProUGUI youHaveFlippedText, youHaveActivelyFlippedText, totalCoinsOnHeadsText, totalCoinsOnTailsText, totalLockyCoinsText;
    public TextMeshProUGUI statsStrongerArmText, statsGreaterText, statsKnowledgeText, statsFistText, statsInjectionText, statsBrainText, statsExplosiveText, statsHydrationText, statsPorionText, statsMasterText, statsHandshakeText, statsHighFiveText, statsMagicText, statsTreasureText, statsRitualText;
    public TextMeshProUGUI stats, general, upgrades, specialUpgrades, completedChallenges, inflation;
    public TextMeshProUGUI inflateOnceToSeeStats;
    public static string youHitExtraLucky, youGambled, lostGambling, wonGambling, clickedPile, pileTotalGenerated;
    public static string completeChal1, completeChal2, completeChal3, completeChal4;
    public static string chal1Completed, chal2completed, chal3completed, chal4completed;
    public TextMeshProUGUI statsHeadsChanceText, statsTailsChanceText, statsLuckyChanceText, youHitExtraLuckyText, youGambledText, lostGamblingText, wonGamblingText, clickedPileText, pileTotalGeneratedText;
    public TextMeshProUGUI completeChal1Text, completeChal2Text, completeChal3Text, completeChal4Text;
    public static string inflateUpgradesStats, inflateEndlessStats, inflateCheaperStats, inflateSpecialCheaperStats, inflateActiveStats, inflateStartWithCoinsStats, inflatePileOfBagsStats;
    public static string moreCoins, cheaper, less, coinsAfterInflating, moreCoinsAfterInflating;
    public TextMeshProUGUI inflateUpgradesStatsTEXT, inflateEndlessStatsTEXT, inflateCheaperStatsTEXT, inflateSpecialCheaperStatsTEXT, inflateActiveStatsTEXT, inflateStartWithCoinsStatsTEXT, inflatePileOfBagsStatsTEXT;

    public TextMeshProUGUI ach1, ach2, ach3, ach4, ach5, ach6, ach7, ach8, ach9, ach10, ach11, ach12, ach13, ach14, ach15, ach16, ach17, ach18, ach19, ach20, ach21, ach22, ach23, ach24, ach25, ach26, ach27, ach28, ach29, ach30, ach31, ach32, ach33, ach34, ach35, ach36, ach37, ach38, ach39, ach40, ach41, ach42, ach43, ach44, ach45, ach46, ach47, ach48, ach49, ach50, ach51, ach52, ach53, ach54, ach55, ach56, ach57, ach58, ach59, ach60, ach61, ach62, ach63, ach64, ach65, ach66, ach67, ach68, ach69, ach70, ach71, ach72, ach73, ach74, ach75, ach76, ach77, ach78, ach79, ach80, ach81, ach82, ach83, ach84, ach85, ach86, ach87, ach88, ach89, ach90, ach91, ach92, ach93, ach94;
    public TextMeshProUGUI achievements;


    //Inflation
    public TextMeshProUGUI inflate, youHave21Flippers, youNeed21Flippers, youCanViewTreeAtAnyTime, smallInflationDescription, bigInflationDescription;
    public TextMeshProUGUI youHave, inflationCoins, dontInflateJustLook, doYouWishToInflate, YES, NO, currentlyOnlyViewingTree, backToFlipping, backToFlipping2, InflationCoins;
    public TextMeshProUGUI rich1, rich1Desc, rich2, rich2Desc, rich3, rich3Desc, rich4, rich4Desc, rich5, rich5Desc, rich6, rich6Desc, rich7, rich7Desc, omegaRich, omegaRichDes;
    public TextMeshProUGUI sale1, sale1Desc, sale2, sale2Desc, sale3, sale3Desc, sale4, sale4Desc, steamSale, steamSaleDesc;
    public TextMeshProUGUI active1, active1Desc, active2, active2Desc, active3, active3Desc, active4, active4Desc, superActiveFlipper, superActiveFlipperDesc, activeEqualsBiggerPile, activeEqualsBiggerPileDesc;
    public TextMeshProUGUI bag1, bag1Desc, bag2, bag2Desc, bag3, bag3Desc, bag4, bag4Desc, hugeBag, hugeBasDesc, pileOfBags, pileOfBagsDesc;
    public TextMeshProUGUI greaterInflation1, greaterInflation1Desc, greaterInflation2, greaterInflation2Desc, greaterInflation3, greaterInflation3Desc, greaterInflation4, greaterInflation4Desc, greaterInflation5, greaterInflation5Desc, crazyInflation, crazyInflationDesc, inflationGamble1, inflationGamble1Desc, inflationGamble2, inflationGamble2Desc, inflationGamble3, inflationGamble3Desc, inflationGamble4, inflationGamble4Desc, thisIsHowInflationWorks;
    public TextMeshProUGUI extraSpecialUpgrade1, extraSpecialUpgrade1Desc, extraSpecialUpgrade2, extraSpecialUpgrade2Desc, extraSpecialUpgrade3, extraSpecialUpgrade3Desc, extraExtraSpecialUpgrade1, extraExtraSpecialUpgrade1Desc, biggerPile1, biggerPile1Desc, biggerPile2, biggerPile2Desc,theGambler, theGamblerDesc, getLuckier, getLuckierDesc, autoUpgradeInflate, autoUpgradeDesc;
    public TextMeshProUGUI autoUpgradeNameText;

    public static string inflationCoinsText;
    public TextMeshProUGUI backToFlippingIflated, yes, no;
    public TextMeshProUGUI music, audiotext, fullscreen, saveGame, exitGame, resetEverything, gameIsSaved30Seconds, foundHiddenBronze, foundHiddenSilver, settings, info, socials, generalGameInfo, mechanicsExplanations, inflationSystem, pileOfCoinsText, offlineProgression, developerBy, musicBy, texturesProvidedBy, inflationSystemDesc, pileOfCoinsDesc, offlineProgressionDesc, followMyTwitch, follotMyTwitter, joinTheDiscord;
    public TextMeshProUGUI quitPlayingChallenge, quitChallengeDesc, quitChalYes, quitChalNo, whishToResetGame, wishToResetDesc, resetYes, resetNo, quitChall1, quitChall2, quitChall3, quitChall4, gameSaved, gameSaved2;
    public TextMeshProUGUI welcomeBack, youWereGoneFor, timeGoneText, offlineEarnings, offlineEarningTotalText, offlineOK;
    public static string days, hours, minuts, secondsTime;

    public TextMeshProUGUI congrats1, congrats2, congrats3, congrats4, youUnlocked1, youUnlocked2, youUnlocked3, youUnlocked4, youCompletedChal1, youCompletedChal2, youCompletedChal3, youCompletedChal4, completedChalFlipAll, completedChallAutoFlipsEquals, onText, onText2, offText;
    public TextMeshProUGUI chal2CompletedRewardInfo, chal3CompletedRewardInfo, chal4CompletedRewardInfo;
    public TextMeshProUGUI coinsMainText;
    public TextMeshProUGUI lockedAuto, lockedSpecialUpgrade, lockedLucky, lockedHigherChance, lockedDuplicate;
    public static string hitTails, hitHeads, hitLucky;
    public GameObject tailsPrefab, headsPrefab, luckyPrefab;
    public TextMeshProUGUI moreCoinsIn1, moreCoinsIn2, moreCoinsIn3, moreCoinsIn4, moreCoinsIn5, plussPile1, plussPile2, plussPile3, plussPile4, plussPile5, thisPileContains1, thisPileContains2, thisPileContains3, thisPileContains4, thisPileContains5;
    public static string moreCoinsIn, Xseconds;
    public static string totalCoins;
    public TextMeshProUGUI totalCoinsPile1, totalCoinsPile2, totalCoinsPile3, totalCoinsPile4, totalCoinsPile5;
    public TextMeshProUGUI gambleResultText;
    public TextMeshProUGUI flipMorePrice1, flipMorePrice2;
    public TextMeshProUGUI upgradesHover, specialUpgradesHover, achievementsHover, statsHover;

    public TextMeshProUGUI specialIpgradeWarning;

    public TextMeshProUGUI[] locked;
    public TextMeshProUGUI[] unLocked;

    public TextMeshProUGUI googlePlayText;

    public static string heads, tails, luckyCoin;

    public TMP_FontAsset JostHeavyEngAndRuss;
    public TMP_FontAsset JostHeavyEngAndRuss2;
    public TMP_FontAsset LiberationEnglish;
    public TMP_FontAsset ARIEL;
    public TMP_FontAsset priceTextEng;
    public TMP_FontAsset notoSans;
    public TMP_FontAsset notoSansJapaneseBold;

    public TMP_FontAsset notoSansChinese;
    public TMP_FontAsset notoSansChineseBold;

    public TMP_FontAsset notoSansKorean;
    public TMP_FontAsset nonoSansKoreanBold;


    public static int ChooseText;

    public static int changeFont;


    public void Start()
    {
        if (!PlayerPrefs.HasKey("ChosenText"))
        {
            English();
        }
        else
        {
            ChooseText = PlayerPrefs.GetInt("ChosenText");
            if (ChooseText == 1) { English(); }
            if (ChooseText == 2) { Russian(); }
            if (ChooseText == 3) { Chinese(); }
            if (ChooseText == 4) { Korean(); }
            if (ChooseText == 5) { Japanese(); }
        }
    }

    #region EnglishRegion
    //ENGLISH
    public void English()
    {
        changeFont = 1;
        ChooseText = 1;

        PlayerPrefs.SetInt("ChosenText", ChooseText);

        #region ChooseScene
        HeadsOrTails.text = "Heads or Tails?"; HeadsOrTails.font = JostHeavyEngAndRuss;
        youChoseHeads.text = "You chose Heads!"; youChoseHeads.font = JostHeavyEngAndRuss;
        youChoseTails.text = "You chose Tails!"; youChoseTails.font = JostHeavyEngAndRuss;
        challengesText.text = "Challenges"; challengesText.font = JostHeavyEngAndRuss;
        challenge1Name.text = "No Auto Flips"; challenge1Name.font = JostHeavyEngAndRuss; challenge1Name.fontSize = 29;
        challenge2Name.text = "25% Flip Chance"; challenge2Name.font = JostHeavyEngAndRuss; challenge2Name.fontSize = 29;
        challenge3Name.text = "1 Coin Flipper"; challenge3Name.font = JostHeavyEngAndRuss; challenge3Name.fontSize = 29;
        challenge4Name.text = "Always Lucky"; challenge4Name.font = JostHeavyEngAndRuss; challenge4Name.fontSize = 29;
        challenge1Text.text = "Challenge #1"; challenge1Text.font = LiberationEnglish;
        challenge2Text.text = "Challenge #2"; challenge2Text.font = LiberationEnglish;
        challenge3Text.text = "Challenge #3"; challenge3Text.font = LiberationEnglish;
        challenge4Text.text = "Challenge #4"; challenge4Text.font = LiberationEnglish;
        challengeNegative1.text = "* Automatic Coin Flips is locked\n* Upgraded Coin Flips is locked"; challengeNegative1.font = JostHeavyEngAndRuss; challengeNegative1.fontSize = 14.8f;
        challengeNegative2.text = "* Permanent 25% chance for successful flips  \n * Higher Chance for success is locked"; challengeNegative2.font = JostHeavyEngAndRuss; challengeNegative2.fontSize = 14f;
        challengeNegative3.text = "* You only have 1 coin flipper\n* Flip More Coins is locked"; challengeNegative3.font = JostHeavyEngAndRuss; challengeNegative3.fontSize = 14f;
        challengeNegative4.text = "* You cannot gain inflation coins during this challenge"; challengeNegative4.font = JostHeavyEngAndRuss; challengeNegative4.fontSize = 14f;
        challengePositive1.text = "* Your flips gain 500% more coins"; challengePositive1.font = JostHeavyEngAndRuss;
        challengepositive2.text = "* Every coin flip is a lucky coin"; challengepositive2.font = JostHeavyEngAndRuss;  challengepositive2.fontSize = 14;
        Goal1text.text = "Goal:"; Goal1text.font = JostHeavyEngAndRuss;
        Goal2text.text = "Goal:"; Goal2text.font = JostHeavyEngAndRuss;
        Goal3text.text = "Goal:"; Goal3text.font = JostHeavyEngAndRuss;
        Goal4text.text = "Goal:"; Goal4text.font = JostHeavyEngAndRuss;
        Goal1textInfo.text = "Reach 15 coin flippers"; Goal1textInfo.font = JostHeavyEngAndRuss; 
        Goal2textInfo.text = "Upgrade 7 coin flippers"; Goal2textInfo.font = JostHeavyEngAndRuss; 
        Goal3textInfo.text = "Reach a total of 70 Quadrillion coins"; Goal3textInfo.font = JostHeavyEngAndRuss; 
        Goal4textInfo.text = "Upgrade all 21 coin flippers"; Goal4textInfo.font = JostHeavyEngAndRuss; Goal4textInfo.fontSize = 27;
        Reward1Text.text = "Reward:"; Reward1Text.font = JostHeavyEngAndRuss;
        Reward2Text.text = "Reward:"; Reward2Text.font = JostHeavyEngAndRuss;
        Reward3Text.text = "Reward:"; Reward3Text.font = JostHeavyEngAndRuss;
        Reward4Text.text = "Reward:"; Reward4Text.font = JostHeavyEngAndRuss;
        Reward1TextInfo.text = "Unlocks the locked special upgrade"; Reward1TextInfo.font = JostHeavyEngAndRuss; Reward1TextInfo.fontSize = 20;
        Reward2TextInfo.text = "The first 5 coin flippers will always have a 100% successful flip chance"; Reward2TextInfo.font = JostHeavyEngAndRuss; Reward2TextInfo.fontSize = 20;
        Reward3TextInfo.text = "The first coin flipper is always successful and give you +500% more coins"; Reward3TextInfo.font = JostHeavyEngAndRuss; Reward3TextInfo.fontSize = 20;
        Reward4TextInfo.text = "Lucky coins can have up to 15% max chance"; Reward4TextInfo.font = JostHeavyEngAndRuss; Reward4TextInfo.fontSize = 20;
        questionInfo.text = "-It is not recommended that you attempt a challenge before Inflating at least once.\n \n" +
            "-Read the first Inflation upgrade of each tree branch to see which upgrade will work during each challenge. \n \n" +
            "-You can choose 1 challenge at the time.\n \n" +
            "-Each challenge will give you a permanent reward."; questionInfo.fontSize = 22.2f; questionInfo.font = JostHeavyEngAndRuss;
        #endregion

        #region upgrades

        strongerArmName = "Stronger Arms";
        greaterCoinName = "Greater Coin";
        knowledgeName = "Knowledge";
        strongerFistName = "Stronger Fist";
        handInjectionName = "Hand Injection";
        brainPowerName = "Brain Power";
        explosiveFlipsName = "Explosive Flips";
        hydrationName = "Hydration";
        strangePotionName = "Strange Potion";
        masterFlipperName = "Master Flipper";
        handShakeName = "Handshake";
        highFiveName = "High Five";
        magicFlipsName = "Magic Flips";
        TreasueChestName = "Treasure Chest";
        coinFlippingRitualName = "Coin Flipping Ritual";
        

        upgrade1.text = strongerArmName; upgrade1.font = JostHeavyEngAndRuss;
        upgrade2.text = greaterCoinName; upgrade2.font = JostHeavyEngAndRuss;
        upgrade3.text = knowledgeName; upgrade3.font = JostHeavyEngAndRuss;
        upgrade4.text = strongerFistName; upgrade4.font = JostHeavyEngAndRuss;
        upgrade5.text = handInjectionName; upgrade5.font = JostHeavyEngAndRuss;
        upgrade6.text = brainPowerName; upgrade6.font = JostHeavyEngAndRuss;
        upgrade7.text = explosiveFlipsName; upgrade7.font = JostHeavyEngAndRuss; upgrade7.fontSize = 30;
        upgrade8.text = hydrationName; upgrade8.font = JostHeavyEngAndRuss;
        upgrade9.text = strangePotionName; upgrade9.font = JostHeavyEngAndRuss;
        upgrade10.text = masterFlipperName; upgrade10.font = JostHeavyEngAndRuss;
        upgrade11.text = handShakeName; upgrade11.font = JostHeavyEngAndRuss;
        upgrade12.text = highFiveName; upgrade12.font = JostHeavyEngAndRuss;
        upgrade13.text = magicFlipsName; upgrade13.font = JostHeavyEngAndRuss; upgrade13.fontSize = 30;
        upgrade14.text = TreasueChestName; upgrade14.font = JostHeavyEngAndRuss;
        upgrade15.text = coinFlippingRitualName; upgrade15.font = JostHeavyEngAndRuss; upgrade15.fontSize = 30;

        upgrade1n.font = JostHeavyEngAndRuss;
        upgrade2n.font = JostHeavyEngAndRuss;
        upgrade3n.font = JostHeavyEngAndRuss;
        upgrade4n.font = JostHeavyEngAndRuss;
        upgrade5n.font = JostHeavyEngAndRuss;
        upgrade6n.font = JostHeavyEngAndRuss;
        upgrade7n.font = JostHeavyEngAndRuss; upgrade7n.fontSize = 30;
        upgrade8n.font = JostHeavyEngAndRuss;
        upgrade9n.font = JostHeavyEngAndRuss;
        upgrade10n.font = JostHeavyEngAndRuss;
        upgrade11n.font = JostHeavyEngAndRuss;
        upgrade12n.font = JostHeavyEngAndRuss;
        upgrade13n.font = JostHeavyEngAndRuss; upgrade13n.fontSize = 30;
        upgrade14n.font = JostHeavyEngAndRuss;
        upgrade15n.font = JostHeavyEngAndRuss; upgrade15n.fontSize = 30;

        flipMorePrice1.font = JostHeavyEngAndRuss;
        flipMorePrice2.font = JostHeavyEngAndRuss;

        thousand = " Thousand"; 
        million = " Million";
        billion = " Billion";
        trillion = " Trillion";
        quadrillion = " Quadrillion";
        quintillion = " Quintillion";
        sextillion = " Sextillion";
        septillion = " Septillion";
        octillion = " Octillion";
        nonillion = " Nonillion";
        decillion = " Decillion";
        undecillion = " Undecillion";
        coins = " Coins";
        coinsOnHeads = " Coins on Heads";
        coinsOnTails = " Coins on Tails";

        price1.font = priceTextEng;
        price2.font = priceTextEng;
        price3.font = priceTextEng;
        price4.font = priceTextEng;
        price5.font = priceTextEng;
        price6.font = priceTextEng;
        price7.font = priceTextEng;
        price8.font = priceTextEng;
        price9.font = priceTextEng;
        price10.font = priceTextEng;
        price11.font = priceTextEng;
        price12.font = priceTextEng;
        price13.font = priceTextEng;
        price14.font = priceTextEng;
        price15.font = priceTextEng;
        price16.font = priceTextEng;
        price17.font = priceTextEng;
        price18.font = priceTextEng;
        price19.font = priceTextEng;
        price20.font = priceTextEng;

        price1c.font = priceTextEng;
        price2c.font = priceTextEng;
        price3c.font = priceTextEng;
        price4c.font = priceTextEng;
        price5c.font = priceTextEng;
        price6c.font = priceTextEng;
        price7c.font = priceTextEng;
        price8c.font = priceTextEng;
        price9c.font = priceTextEng;
        price10c.font = priceTextEng;
        price11c.font = priceTextEng;
        price12c.font = priceTextEng;
        price13c.font = priceTextEng;
        price14c.font = priceTextEng;
        price15c.font = priceTextEng;
        price16c.font = priceTextEng;
        price17c.font = priceTextEng;
        price18c.font = priceTextEng;
        price19c.font = priceTextEng;
        price20c.font = priceTextEng;

        flipAll.text = "Flip All"; flipAll.font = JostHeavyEngAndRuss;
        autoFlipsQeuals.text = "Auto Flips ="; autoFlipsQeuals.font = JostHeavyEngAndRuss; autoFlipsQeuals.fontSize = 25;
        on.text = "ON"; on.font = JostHeavyEngAndRuss;
        on2.text = "ON"; on2.font = JostHeavyEngAndRuss;
        off.text = "OFF"; off.font = JostHeavyEngAndRuss;
        off2.text = "OFF"; off2.font = JostHeavyEngAndRuss;
        gamble.text = "Gamble"; gamble.font = JostHeavyEngAndRuss;
        gamblec.text = "Gamble"; gamblec.font = JostHeavyEngAndRuss;
        current.text = "Current:"; current.font = JostHeavyEngAndRuss; current.fontSize = 25;
        autoFlips.text = "Automatic Coin Flips"; autoFlips.font = JostHeavyEngAndRuss; autoFlips.fontSize = 30;
        autoFlipsc.text = "Automatic Coin Flips"; autoFlipsc.font = JostHeavyEngAndRuss; autoFlipsc.fontSize = 30;
        pileOfCoins.text = "Pile Of Coins"; pileOfCoins.font = JostHeavyEngAndRuss;
        pileOfCoinsc.text = "Pile Of Coins"; pileOfCoinsc.font = JostHeavyEngAndRuss;
        higherChance.text = "Higher Chance for Success";
        higherChancec.text = "Higher Chance for Success";
        higherChance.font = JostHeavyEngAndRuss;
        higherChancec.font = JostHeavyEngAndRuss;

        if (LoadSaves.isMobileBuild == false)
        {
           higherChance.fontSize = 29;
            higherChancec.fontSize = 29;
        }
        if (LoadSaves.isMobileBuild == true)
        {
            higherChance.fontSize = 24;
            higherChancec.fontSize = 24;
        }

        getLucky.text = "Get Lucky"; getLucky.font = JostHeavyEngAndRuss;
        getLuckyc.text = "Get Lucky"; getLuckyc.font = JostHeavyEngAndRuss;
        endlessInflation.text = "Endless Inflation"; endlessInflation.font = JostHeavyEngAndRuss;
        upgradedFlips.text = "Upgraded Coin Flips!"; upgradedFlips.font = JostHeavyEngAndRuss; upgradedFlips.fontSize = 36;
        upgradedFlipsc.text = "Upgraded Coin Flips!"; upgradedFlipsc.font = JostHeavyEngAndRuss; upgradedFlipsc.fontSize = 36;
        unlockedViaChal1.text = "Unlocked via completing challenge #1"; unlockedViaChal1.font = JostHeavyEngAndRuss; unlockedViaChal1.fontSize = 16;
        unlcokedViaInf.text = "Unlocked via Inflation"; unlcokedViaInf.font = JostHeavyEngAndRuss;
        chooseAutoUpgrade.text = "Choose which upgrade to be automatically upgraded:"; chooseAutoUpgrade.font = JostHeavyEngAndRuss;
        diplicateFlips.font = JostHeavyEngAndRuss; diplicateFlips.fontSize = 36;
        diplicateFlipsc.font = JostHeavyEngAndRuss; diplicateFlipsc.fontSize = 36;
        autoUpgradeNameText.text = "Auto Upgrade"; autoUpgradeNameText.font = JostHeavyEngAndRuss;

        autoUpgradeName = "Automatic Coin Flips"; 
        pileOfCoinsName = "Pile Of Coins";
        higherChanceName = "Higher Chance For Success";
        getLuckyName = "Get Lucky";
        upgradedFlipsName = "Upgraded Coin Flips";
        flipMoreCoinsName = "Flip More Coins";
        spendNoMore = "Spend no more";
        maxedOut = "MAXED OUT";
        theyAllFlip = "THEY ALL FLIP";
        #endregion

        #region hoverOverUpgrades
        hover1Name.text = strongerArmName; hover1Name.font = JostHeavyEngAndRuss;
        hover2Name.text = greaterCoinName; hover2Name.font = JostHeavyEngAndRuss;
        hover3Name.text = knowledgeName; hover3Name.font = JostHeavyEngAndRuss;
        hover4Name.text = strongerFistName; hover4Name.font = JostHeavyEngAndRuss;
        hover5Name.text = handInjectionName; hover5Name.font = JostHeavyEngAndRuss;
        hover6Name.text = brainPowerName; hover6Name.font = JostHeavyEngAndRuss;
        hover7Name.text = explosiveFlipsName; hover7Name.font = JostHeavyEngAndRuss; hover7Name.fontSize = 36;
        hover8Name.text = hydrationName; hover8Name.font = JostHeavyEngAndRuss;
        hover9Name.text = strangePotionName; hover9Name.font = JostHeavyEngAndRuss;
        hover10Name.text = masterFlipperName; hover10Name.font = JostHeavyEngAndRuss;
        hover11Name.text = handShakeName; hover11Name.font = JostHeavyEngAndRuss;
        hover12Name.text = highFiveName; hover12Name.font = JostHeavyEngAndRuss;
        hover13Name.text = magicFlipsName; hover13Name.font = JostHeavyEngAndRuss; hover13Name.fontSize = 36;
        hover14Name.text = TreasueChestName; hover14Name.font = JostHeavyEngAndRuss;
        hover15Name.text = coinFlippingRitualName; hover15Name.font = JostHeavyEngAndRuss; hover15Name.fontSize = 36;
        hoverFlipAll.text = "Flip All"; hoverFlipAll.font = JostHeavyEngAndRuss;
        hoverAutoUpgrade.text = "Auto Upgrade"; hoverAutoUpgrade.font = JostHeavyEngAndRuss; 
        hovergamble.text = "Gamble"; hovergamble.font = JostHeavyEngAndRuss; hovergamble.fontSize = 35;
        hoverAutoFlip.text = "Automatic Coin Flips"; hoverAutoFlip.font = JostHeavyEngAndRuss; hoverAutoFlip.fontSize = 36;
        hoverPile.text = "Pile Of Coins"; hoverPile.font = JostHeavyEngAndRuss;
        hoverhigherChance.text = "Higher Chance For Success"; hoverhigherChance.font = JostHeavyEngAndRuss;
        hoverLucky.text = "Get Lucky"; hoverLucky.font = JostHeavyEngAndRuss;
        hoverEndless.text = "Endless Inflation"; hoverEndless.font = JostHeavyEngAndRuss;
        hoverUpgradedFlips.text = "Upgraded Coin Flips"; hoverUpgradedFlips.font = JostHeavyEngAndRuss; hoverUpgradedFlips.fontSize = 35;
        hoverOn.text = "Turn On Auto Flips"; hoverOn.font = JostHeavyEngAndRuss;
        hoverOff.text = "Turn Off Auto Flips"; hoverOff.font = JostHeavyEngAndRuss;

        purchased = "Purchased: ";

        purchased1.text = "Purchased: " + MoreCoinsButton.moreCoinsUpgrades; purchased2.text = "Purchased: " + MoreCoinsButton.greaterCoinsCount;
        purchased3.text = "Purchased: " + KnowledgeUpgrade.knowledgeUpgradeCount; purchased4.text = "Purchased: " + StrongerFist.fistUpgradeCount;
        purchased5.text = "Purchased: " + HandInecjtion.injectionUpgradeCount; purchased6.text = "Purchased: " + BrainPower.brainPowerUpgradeCount ;
        purchased7.text = "Purchased: " + ExplosiveFlips.explosiveUpgradeCount; purchased8.text = "Purchased: " + HydrationButton.hydrationUpgradeCount;
        purchased9.text = "Purchased: " + StrangePotion.potionUpgradeCount; purchased10.text = "Purchased: " + MasterFlipper.MasterFlipsUpgradeCount;
        purchased11.text = "Purchased: " + HandShake.handShakeUpgradeCount; purchased12.text = "Purchased: " + Upgrade12.upgrade12Count; 
        purchased13.text = "Purchased: " + MagicFlipsUpgrade.magicUpgradeCount; purchased14.text = "Purchased: " + TreasureChest.treasureCount;
        purchased15.text = "Purchased: " + RitualUpgrade.treasureCount;
        purchased16.text = "Purchased: " +GlobalCoinMaker.coinsPerFlipUpgrades; purchased17.text = "Purchased: " + PurchaseLog.higherChanceUpgradeCount;
        purchased18.text = "Purchased: " + PurchaseLog.luckyCoinHigherChanceCount; purchased19.text = "Purchased: " + GoldenFlipsButton.goldenCoinsUpgradeCount;
        purchased20.text = "Purchased: " + PurchaseLog.pileOfCoinsCount;  purchased21.text = "Purchased: ";
       

        purchased1.font = JostHeavyEngAndRuss; purchased2.font = JostHeavyEngAndRuss; purchased3.font = JostHeavyEngAndRuss; purchased4.font = JostHeavyEngAndRuss;
        purchased5.font = JostHeavyEngAndRuss; purchased6.font = JostHeavyEngAndRuss; purchased7.font = JostHeavyEngAndRuss; purchased8.font = JostHeavyEngAndRuss;
        purchased9.font = JostHeavyEngAndRuss; purchased10.font = JostHeavyEngAndRuss; purchased11.font = JostHeavyEngAndRuss; purchased12.font = JostHeavyEngAndRuss;
        purchased13.font = JostHeavyEngAndRuss; purchased14.font = JostHeavyEngAndRuss; purchased15.font = JostHeavyEngAndRuss;
        purchased16.font = JostHeavyEngAndRuss;
        purchased17.font = JostHeavyEngAndRuss; purchased18.font = JostHeavyEngAndRuss; purchased19.font = JostHeavyEngAndRuss;
        purchased20.font = JostHeavyEngAndRuss; purchased21.font = JostHeavyEngAndRuss;

        thousandC = " Thousand Coins"; millionc = " Million Coins"; billionc = " Billion Coins"; trillionc = " Trillion Coins"; quadrillionc = " Quadrillion Coins"; quintillionc = " Quintillion Coins";
        sextillionc = " Sextillion Coins"; septillionc = " Septillion Coins"; octillionc = " Octillion Coins"; nonillionc = " Nonillion Coins"; decillionc = " Decillion Coins";
        undecillionc = " Undecillion Coins";

        description1.text = "\"You've been training your biceps, triceps and forearms for years. And with this increased strength you can now flip your coins with increased power!\"";
        description2.text = "\"One day you decide to pick up a coin that is just laying there on the sidewalk. It turns out whenever you flip this coin, you gain more coins!\"";
        description3.text = "\"You know what's better than stronger arms and a greater coin? Knowledge.\"";
        description4.text = "\"Whilst everyone else at the gym is training their entire body. Your focus is entirely on your fist. You train each finger individually which gives your whole fist a giant pump.\"";
        description5.text = "\"Some random guy on the street sold you a needle with some weird looking liquid inside it. You inject it into your hands and for some reason you feel better than ever before.\"";
        description6.text = "\"During all of your years of flipping coins, your brain can now exceed over 100% of its capacity.\"";
        description7.text = "\"Flipping coins is now getting pretty dangerous. Every coin you flip creates a small explosion on your thumb. Even though it's an explosion, it does nothing more than tickle a little bit.\"";
        description8.text = "\"Flipping coins all day is hard work and sometimes all that it takes to keep going is some cold fresh water. So, remember to keep hydrated!\"";
        description9.text = "\"You've been keeping a strange potion under your bed for a very long time.  Today is the day you drink it and just like the needle, you have never felt better in your entire life\"";
        description10.text = "\"Your years of dedication to coin flipping have awarded you with The Master Flipper Medal.\"";
        description11.text = "\"You shake hands with a professional coin flipping business man. You and this man are going to turn coin flipping into the world's most successful business, somehow...\"";
        description12.text = "\"You high five someone who is very important to you. This gives you more flipping power that you could ever dream of\"";
        description13.text = "\"You travel to a certain school for wizards to learn the arts of magical coin flipping. Your coins now have a magical glow everytime you flip them. This makes people suspicious\"";
        description14.text = "\"On your countless travels around the world, you discover long lost old treasure chests. So naturally, you start flipping the coins inside the chest\"";
        description15.text = "\"This coin flipping thing is taking a dark turn. You become obsessed with finding new ways to flip coins. You start to perform dark rituals in the hopes of taking coin flipping to the highest form possible\"";
        description16.text = "\"Sometimes it's better to have someone else flip coins for you. Each upgrade will automatically flip 1 coin for you\"";
        description17.text = "\"Your flips will now have a 1% more chance to be successful. Hopefully with some luck this will actually give you more coins!\"";
        description18.text = "\"Sometimes your coin flips can be a little different. And when these different flips happen, you gain 5X the coins. Each upgrade will give you +0.5%\"";
        description19.text = "\"Every purchase will upgrade 1 coin flipper to an upgraded version. These coin flips will give you 2X the amount of coins and Lucky Coins will give you 10X\"";
        description20.text = "\"Are you a gambler? If so, do you dare to try and double all of your coins? There's no skill involved here, only luck. Also remember, you do not need to do this if you don't want to\"";
        description21.text = "-Choose an upgrade to be automatically upgraded. \n\n -The auto upgrade will purchase the upgrade of your choosing every 5 seconds if you can afford it. \n\n -Auto upgrade does not work when the game is closed.";
        description22.text = "-You can turn auto flips on and off.\n-When you flip all coins, you must wait 3 seconds until you can flip again.\n-You cannot flip any coins actively when you have auto flips turned off.\n-Auto flips and upgraded coin flips are locked while auto flips are turned off. ";
        description23.text = "\"A pile of coins will appear in the bottom left. Over time this pile will generate more and more coins. Once clicked, you get all the coins\"";
        descEndless1.text = "\"It is not recommended that the players start buying this upgrade before unlocking most Inflation Upgrades.\"";
        descEndless2.text = "This upgrade works the same way as the \"RICH\" inflation upgrades. The coin bonus each purchase is equal to the upgrade price.";
        description1.font = LiberationEnglish; description2.font = LiberationEnglish; description3.font = LiberationEnglish; description4.font = LiberationEnglish; description5.font = LiberationEnglish;
        description6.font = LiberationEnglish; description7.font = LiberationEnglish; description8.font = LiberationEnglish; description9.font = LiberationEnglish; description10.font = LiberationEnglish;
        description11.font = LiberationEnglish; description12.font = LiberationEnglish; description13.font = LiberationEnglish; description14.font = LiberationEnglish; description15.font = LiberationEnglish;
        description16.font = LiberationEnglish; description17.font = LiberationEnglish; description18.font = LiberationEnglish; description19.font = LiberationEnglish; description20.font = LiberationEnglish;
        description21.font = LiberationEnglish; description22.font = LiberationEnglish; description23.font = LiberationEnglish; descEndless1.font = LiberationEnglish; descEndless2.font = LiberationEnglish;

        description2.fontSize = 15; description4.fontSize = 15; description5.fontSize = 15; description7.fontSize = 15; description8.fontSize = 15; 
        description11.fontSize = 15; description13.fontSize = 15; description14.fontSize = 15; description15.fontSize = 14.7f; description16.fontSize = 15; description18.fontSize = 15; description19.fontSize = 14.8f;
        description20.fontSize = 15; description22.fontSize = 15; description23.fontSize = 15; descEndless1.fontSize = 14.5f; descEndless2.fontSize = 14.7f;

        hoverCost1.font = JostHeavyEngAndRuss; hoverCost2.font = JostHeavyEngAndRuss; hoverCost3.font = JostHeavyEngAndRuss; hoverCost4.font = JostHeavyEngAndRuss; hoverCost5.font = JostHeavyEngAndRuss;
        hoverCost6.font = JostHeavyEngAndRuss; hoverCost7.font = JostHeavyEngAndRuss; hoverCost8.font = JostHeavyEngAndRuss; hoverCost9.font = JostHeavyEngAndRuss; hoverCost10.font = JostHeavyEngAndRuss;
        hoverCost11.font = JostHeavyEngAndRuss; hoverCost12.font = JostHeavyEngAndRuss; hoverCost13.font = JostHeavyEngAndRuss; hoverCost14.font = JostHeavyEngAndRuss; hoverCost15.font = JostHeavyEngAndRuss;
        hoverCost16.font = JostHeavyEngAndRuss; hoverCost17.font = JostHeavyEngAndRuss; hoverCost18.font = JostHeavyEngAndRuss; hoverCost19.font = JostHeavyEngAndRuss; hoverCost20.font = JostHeavyEngAndRuss;
        hoverCost21.font = JostHeavyEngAndRuss;

        p1.text = "Price:"; p2.text = "Price:"; p3.text = "Price:"; p4.text = "Price:"; p5.text = "Price:"; p6.text = "Price:"; p7.text = "Price:"; p8.text = "Price:"; p9.text = "Price:"; p10.text = "Price:";
        p11.text = "Price:";
        p12.text = "Price:"; p13.text = "Price:"; p14.text = "Price:"; p15.text = "Price:"; p16.text = "Price:"; p17.text = "Price:"; p18.text = "Price:"; p19.text = "Price:"; p20.text = "Price:";
        p21.text = "Price:";

        p1.font = JostHeavyEngAndRuss; p2.font = JostHeavyEngAndRuss; p3.font = JostHeavyEngAndRuss; p4.font = JostHeavyEngAndRuss; p5.font = JostHeavyEngAndRuss; p6.font = JostHeavyEngAndRuss;
        p7.font = JostHeavyEngAndRuss; p8.font = JostHeavyEngAndRuss; p9.font = JostHeavyEngAndRuss; p10.font = JostHeavyEngAndRuss; p11.font = JostHeavyEngAndRuss; p12.font = JostHeavyEngAndRuss;
        p13.font = JostHeavyEngAndRuss; p14.font = JostHeavyEngAndRuss; p15.font = JostHeavyEngAndRuss; p16.font = JostHeavyEngAndRuss; p17.font = JostHeavyEngAndRuss; p18.font = JostHeavyEngAndRuss;
        p19.font = JostHeavyEngAndRuss; p20.font = JostHeavyEngAndRuss; p21.font = JostHeavyEngAndRuss;

        plussCoins = " Coins on every successful flip!";
        plussthousandCoins = " Thousand Coins on every successful flip!";
        plussMillionCoins = " Million Coins on every successful flip!";
        plussBillionCoins = " Billion Coins on every successful flip!";
        plussTrillionCoins = " Trillion Coins on every successful flip!";
        plussQuadrillionCoins = " Quadrillion Coins on every successful flip!";
        plussQuintillionCoins = " Quintillion Coins on every successful flip!";
        plussSextillionCoins = " Sextillion Coins on every successful flip!";
        plussSeptillionCoins = " Septillion Coins on every successful flip!";

        pluss1.font = JostHeavyEngAndRuss; pluss2.font = JostHeavyEngAndRuss; pluss3.font = JostHeavyEngAndRuss; pluss4.font = JostHeavyEngAndRuss; pluss5.font = JostHeavyEngAndRuss; pluss6.font = JostHeavyEngAndRuss;
        pluss7.font = JostHeavyEngAndRuss; pluss8.font = JostHeavyEngAndRuss; pluss9.font = JostHeavyEngAndRuss; pluss10.font = JostHeavyEngAndRuss; pluss11.font = JostHeavyEngAndRuss; pluss12.font = JostHeavyEngAndRuss;
        pluss13.font = JostHeavyEngAndRuss; pluss14.font = JostHeavyEngAndRuss; pluss15.font = JostHeavyEngAndRuss;

        pluss1.fontSize = 15; pluss2.fontSize = 15; pluss3.fontSize = 15; pluss4.fontSize = 15; pluss5.fontSize = 15; pluss6.fontSize = 15; pluss7.fontSize = 15; pluss8.fontSize = 15; pluss9.fontSize = 15;
        pluss10.fontSize = 15; pluss11.fontSize = 15; pluss12.fontSize = 15; pluss13.fontSize = 15; pluss14.fontSize = 15; pluss15.fontSize = 15;

        gamblePreventCheating.text = ""; gamblePreventCheating.font = JostHeavyEngAndRuss;
        gambleReset.text = "Tries will be reset during inflation"; gambleReset.font = JostHeavyEngAndRuss;
        gambleTries.font = priceTextEng; gambleChanceToWin.font = JostHeavyEngAndRuss; gambleChanceToLoose.font = JostHeavyEngAndRuss; pileGenerates.font = JostHeavyEngAndRuss;
        pileMinus1Second.text = "-1 Second on every purchase"; pileMinus1Second.font = JostHeavyEngAndRuss; chanceToHitHeads.font = JostHeavyEngAndRuss; chanceToHitTails.font = JostHeavyEngAndRuss;
        chanceToHitLuckyCoin.font = JostHeavyEngAndRuss; endlessInflationPercent.font = JostHeavyEngAndRuss; endlessInflationCoin.font = JostHeavyEngAndRuss; plussUpgradedCoinFlipper.font = JostHeavyEngAndRuss;
        plussUpgradedCoinFlipper.text = "+1 Upgraded Coin Flipper"; plussUpgradedCoinFlipper.fontSize = 20;

        gambleChanceToWin.text = PurchaseLog.gambleChanceEachTimeWIN + "% Chance to double all your coins"; gambleChanceToLoose.text = PurchaseLog.gambleChanceEachTimeLOOSE + "% Chance to lose all your coins";
        chanceToHitHeads.text = higherChanceHoverover.headsPercent + "% Chance to hit heads"; chanceToHitTails.text = higherChanceHoverover.tailsPercent + "% Chance to hit tails";
        chanceToHitLuckyCoin.text = GetLuckyHoverOver.luckyChance + "% Chance to hit a lucky coin";
        endlessInflationPercent.text = EndlessInflation.endlessInflationPrice + "% More Coins!"; endlessInflationCoin.text = EndlessInflation.endlessInflationPrice + " Inflation Coins";
        chanceToHitLuckyCoin.fontSize = 13.5f; chanceToHitHeads.fontSize = 15f; chanceToHitTails.fontSize = 15f;
        pileGenerates.text = "Generates coins every " + PileOfCoinsMechanics.waitTime + " seconds"; pileGenerates.fontSize = 11;

        gambleWinChance = "% Chance to double all your coins"; gambleLoseChance = "% Chance to lose all your coins"; gambleTriesString = "Tries: ";
        pileGeneratesEveyXSecond = "Generates coins every "; seconds = " seconds!";
        higherChanceTails = "% Chance to hit tails"; higherChanceHeads = "% Chance to hit heads"; luckyCoinChance = "% Chance to hit a lucky coin";
        endlessInflationCost = " Inflation Coins"; endlessInflationPercentString = "% More Coins!"; needs21Flippers = "Needs 21 coin flippers!";

        gambleTriesStringText.text = "Tries: " + PurchaseLog.gambleChances; gambleTriesStringText.font = priceTextEng;
        gambleResultText.font = JostHeavyEngAndRuss;
        #endregion

        #region STATS

        inflateOnceToSeeStats.text = "Inflate once to see stats"; inflateOnceToSeeStats.font = JostHeavyEngAndRuss; inflateOnceToSeeStats.fontSize = 20;

         //GeneralStats
         coin = "coin"; 
        youHaveFlipped = "You have flipped "; youHaveFlippedText.font = LiberationEnglish;
        youHaveActivelyFlipped = "You have actively flipped "; youHaveActivelyFlippedText.font = LiberationEnglish;
        totalCoinsOnHeads = " Coins landed on HEADS"; totalCoinsOnHeadsText.font = LiberationEnglish;
        totalCoinsOnTails = " Coins landed on TAILS"; totalCoinsOnTailsText.font = LiberationEnglish;
        totalLockyCoins = " Coins landed on a LUCKY coin "; totalLockyCoinsText.font = LiberationEnglish;

        stats.text = "STATS"; general.text = "General"; upgrades.text = "Upgrades"; completedChallenges.text = "Completed Challenges Rewards"; inflation.text = "Inflation"; specialUpgrades.text = "Special Upgrades";
        stats.font = JostHeavyEngAndRuss2; general.font = LiberationEnglish; upgrades.font = LiberationEnglish; completedChallenges.font = LiberationEnglish; inflation.font = LiberationEnglish;

        //UpgradesText
        buyUpgrade = "Buy upgrade to see stats";
        your = "Your ";
        statsStrongerArm = " Stronger Arms upgrades gives you ";
        statsGreater = " Greater Coin upgrades gives you ";
        statsKnowledge = " Knowledge upgrades gives you ";
        statsFist = " Stronger Fist upgrades gives you ";
        statsInjection = " Hand Injection upgrades gives you ";
        statsBrain = " Brain Power upgrades gives you ";
        statsExplosive = " Explosive Flips upgrades gives you ";
        statsHydration = " Hydration upgrades gives you ";
        statsPorion = " Strange Potion upgrades gives you ";
        statsMaster = " Master Flipper upgrades gives you ";
        statsHandshake = " Handshake upgrades gives you ";
        statsHighFive = " High Five upgrades gives you ";
        statsMagic = " Magic Flips upgrades gives you ";
        statsTreasure = " Treasure Chest upgrades gives you ";
        statsRitual = " Coin Flipping Ritual upgrades gives you ";

        statsStrongerArmText.text = LocalizationStrings.your + MoreCoinsButton.moreCoinsUpgrades + LocalizationStrings.statsStrongerArm + FormatCoins(PurchaseLog.strongerHandsTextInfo) + LocalizationStrings.coins ;  statsStrongerArmText.font = LiberationEnglish;

        statsGreaterText.font = ARIEL; statsKnowledgeText.font = ARIEL; statsFistText.font = ARIEL; statsInjectionText.font = ARIEL; statsBrainText.font = ARIEL; statsExplosiveText.font = ARIEL;
        statsHydrationText.font = ARIEL; statsPorionText.font = ARIEL; statsMasterText.font = ARIEL; statsHandshakeText.font = ARIEL; statsHighFiveText.font = ARIEL;
        statsMagicText.font = ARIEL; statsTreasureText.font = ARIEL; statsRitualText.font = ARIEL;

        if (MoreCoinsButton.greaterCoinsCount == 0) { statsGreaterText.text = buyUpgrade; }
            if (MoreCoinsButton.greaterCoinsCount > 0)
        {
            statsGreaterText.text = LocalizationStrings.your + MoreCoinsButton.greaterCoinsCount + LocalizationStrings.statsGreater + FormatCoins(PurchaseLog.greaterTextInfo) +LocalizationStrings.coins;
        }
        if (KnowledgeUpgrade.knowledgeUpgradeCount == 0) { statsKnowledgeText.text = buyUpgrade; }
        if (KnowledgeUpgrade.knowledgeUpgradeCount > 0)
        {
            statsKnowledgeText.text = LocalizationStrings.your + KnowledgeUpgrade.knowledgeUpgradeCount + LocalizationStrings.statsKnowledge + FormatCoins(PurchaseLog.knowledgeInfo) + LocalizationStrings.coins;
        }
        if (StrongerFist.fistUpgradeCount == 0) { statsFistText.text = buyUpgrade; }
        if (StrongerFist.fistUpgradeCount > 0)
        {
            statsFistText.text = LocalizationStrings.your + StrongerFist.fistUpgradeCount + LocalizationStrings.statsFist + FormatCoins(PurchaseLog.fistInfo) + LocalizationStrings.coins; 
        }
        if (HandInecjtion.injectionUpgradeCount == 0) { statsInjectionText.text = buyUpgrade; }
        if (HandInecjtion.injectionUpgradeCount > 0)
        {
            statsInjectionText.text = LocalizationStrings.your + HandInecjtion.injectionUpgradeCount + LocalizationStrings.statsInjection + FormatCoins(PurchaseLog.injectionInfo) + LocalizationStrings.coins; 
        }
        if (BrainPower.brainPowerUpgradeCount == 0) { statsBrainText.text = buyUpgrade; }
        if (BrainPower.brainPowerUpgradeCount > 0)
        {
            statsBrainText.text = LocalizationStrings.your + BrainPower.brainPowerUpgradeCount + LocalizationStrings.statsBrain + FormatCoins(PurchaseLog.brainPowerInfo) + LocalizationStrings.coins; 
        }
        if (ExplosiveFlips.explosiveUpgradeCount == 0) { statsExplosiveText.text = buyUpgrade; }
        if (ExplosiveFlips.explosiveUpgradeCount > 0)
        {
            statsExplosiveText.text = LocalizationStrings.your + ExplosiveFlips.explosiveUpgradeCount + LocalizationStrings.statsExplosive + FormatCoins(PurchaseLog.explosiveInfo) + LocalizationStrings.coins; 
        }
        if (HydrationButton.hydrationUpgradeCount == 0) { statsHydrationText.text = buyUpgrade; }
        if (HydrationButton.hydrationUpgradeCount > 0)
        {
            statsHydrationText.text = LocalizationStrings.your + HydrationButton.hydrationUpgradeCount + LocalizationStrings.statsHydration + FormatCoins(PurchaseLog.hydrationInfo) + LocalizationStrings.coins; 
        }
        if (StrangePotion.potionUpgradeCount == 0) { statsPorionText.text = buyUpgrade; }
        if (StrangePotion.potionUpgradeCount > 0)
        {
            statsPorionText.text = LocalizationStrings.your + StrangePotion.potionUpgradeCount + LocalizationStrings.statsPorion + FormatCoins(PurchaseLog.potionInfo) + LocalizationStrings.coins; 
        }
        if (MasterFlipper.MasterFlipsUpgradeCount == 0) { statsMasterText.text = buyUpgrade; }
        if (MasterFlipper.MasterFlipsUpgradeCount > 0)
        {
            statsMasterText.text = LocalizationStrings.your + MasterFlipper.MasterFlipsUpgradeCount + LocalizationStrings.statsMaster + FormatCoins(PurchaseLog.masterFlipperInfo) + LocalizationStrings.coins; 
        }
        if (HandShake.handShakeUpgradeCount == 0) { statsHandshakeText.text = buyUpgrade; }
        if (HandShake.handShakeUpgradeCount > 0)
        {
            statsHandshakeText.text = LocalizationStrings.your + HandShake.handShakeUpgradeCount + LocalizationStrings.statsHandshake + FormatCoins(PurchaseLog.handShakeInfo) + LocalizationStrings.coins; 
        }
        if (Upgrade12.upgrade12Count == 0) { statsHighFiveText.text = buyUpgrade; }
        if (Upgrade12.upgrade12Count > 0)
        {
            statsHighFiveText.text = LocalizationStrings.your + Upgrade12.upgrade12Count + LocalizationStrings.statsHighFive + FormatCoins(PurchaseLog.upgrade12Info) + LocalizationStrings.coins; 
        }
        if (MagicFlipsUpgrade.magicUpgradeCount == 0) { statsMagicText.text = buyUpgrade; }
        if (MagicFlipsUpgrade.magicUpgradeCount >= 1)
        {
            statsMagicText.text = LocalizationStrings.your + MagicFlipsUpgrade.magicUpgradeCount + LocalizationStrings.statsMagic + FormatCoins(PurchaseLog.magicFlipsInfo) + LocalizationStrings.coins; 
        }
        if (TreasureChest.treasureCount == 0) { statsTreasureText.text = buyUpgrade; }
        if (TreasureChest.treasureCount >= 1)
        {
            statsTreasureText.text = LocalizationStrings.your + TreasureChest.treasureCount + LocalizationStrings.statsTreasure + FormatCoins(PurchaseLog.treasureInfo) + LocalizationStrings.coins; 
        }
        if (RitualUpgrade.treasureCount == 0) { statsRitualText.text = buyUpgrade; }
        if (RitualUpgrade.treasureCount >= 1)
        {
            statsRitualText.text = LocalizationStrings.your + RitualUpgrade.treasureCount + LocalizationStrings.statsRitual + FormatCoins(PurchaseLog.ritualInfo) + LocalizationStrings.coins; 
        }
            
        statsStrongerArmText.fontSize = 15; statsGreaterText.fontSize = 15; statsKnowledgeText.fontSize = 15; statsFistText.fontSize = 15; statsInjectionText.fontSize = 15;
        statsBrainText.fontSize = 15; statsExplosiveText.fontSize = 15; statsHydrationText.fontSize = 15; statsPorionText.fontSize = 15; statsMasterText.fontSize = 15;
        statsHandshakeText.fontSize = 15; statsHighFiveText.fontSize = 15; statsMagicText.fontSize = 15; statsTreasureText.fontSize = 15; statsRitualText.fontSize = 15;

        //SpecialUpgradesText
        times = " times"; youHitExtraLucky = "You hit an EXTRA LUCKY Coin "; youGambled = "You have GAMBLED "; lostGambling = "You have lost all your coins GAMBLING ";
        wonGambling = "You have doubled all your coins GAMBLING "; clickedPile = "You have clicked on a PILE OF COINS "; pileTotalGenerated = "PILE OF COINS have generated a total of ";
        completeChal1 = "Complete challenge 1 to see reward"; completeChal2 = "Complete challenge 2 to see reward";
        completeChal3 = "Complete challenge 3 to see reward"; completeChal4 = "Complete challenge 4 to see reward";
        chal1Completed = "Challenge 1 reward: Unlocked the FLIP ALL button"; chal2completed = "Challenge 2 reward: First 5 coin flippers are always successful";
        chal3completed = "Challenge 3 reward: First coin flipper gives 500% more coins"; chal4completed = "Challenge 4 reward: Max 15% Lucky coin chance"; ;
        statsHeadsChanceText.text = higherChanceHoverover.headsPercent + LocalizationStrings.higherChanceHeads; statsHeadsChanceText.font = ARIEL;
        statsTailsChanceText.text = higherChanceHoverover.tailsPercent + LocalizationStrings.higherChanceTails; statsTailsChanceText.font = ARIEL;
        statsLuckyChanceText.text = GetLuckyHoverOver.luckyChance + LocalizationStrings.luckyCoinChance; statsLuckyChanceText.font = ARIEL;
        youHitExtraLuckyText.font = LiberationEnglish;
        clickedPileText.text = LocalizationStrings.clickedPile + PileOfCoinsMechanics.incrementPileOfCoinsAmount + LocalizationStrings.times;
        youGambledText.text = LocalizationStrings.youGambled + (0 + PurchaseLog.amountOfTimesGambled) + LocalizationStrings.times;

        youGambledText.font = LiberationEnglish;

        lostGamblingText.font = LiberationEnglish; lostGamblingText.text = LocalizationStrings.lostGambling + (0 + PurchaseLog.amountOfTimesGambledLOST) + LocalizationStrings.times;
        wonGamblingText.font = LiberationEnglish; wonGamblingText.text = LocalizationStrings.wonGambling + (0 + PurchaseLog.amountOfTimesGambledWON) + LocalizationStrings.times;
        clickedPileText.font = LiberationEnglish;
        pileTotalGeneratedText.font = LiberationEnglish; ;

        completeChal1Text.font = LiberationEnglish; completeChal2Text.font = LiberationEnglish; completeChal3Text.font = LiberationEnglish; completeChal4Text.font = LiberationEnglish;

        completeChal1Text.fontSize = 16.6f; completeChal2Text.fontSize = 16.6f; completeChal3Text.fontSize = 16.6f; completeChal4Text.fontSize = 16.6f;

        if (Challenges.completedChallenge1 == 0) { completeChal1Text.text = completeChal1;  } if(Challenges.completedChallenge1 == 1) { completeChal1Text.text = chal1Completed;  }
        if(Challenges.completedChallenge2 == 0) { completeChal2Text.text = completeChal2;  } if(Challenges.completedChallenge2 == 1) { completeChal2Text.text = chal2completed;  }
        if(Challenges.completedChallenge3 == 0) { completeChal3Text.text = completeChal3;  } if(Challenges.completedChallenge3 == 1) { completeChal3Text.text = chal3completed;  }
        if(Challenges.completedChallenge4 == 0) { completeChal4Text.text = completeChal4;  } if(Challenges.completedChallenge4 == 1) { completeChal4Text.text = chal4completed;  }

        moreCoins = "% more coins"; cheaper = "% cheaper"; less = "% less"; coinsAfterInflating = " coins after inflating"; moreCoinsAfterInflating = " more coins after inflating";

        inflateUpgradesStats = "Upgrades give you "; inflateEndlessStats = "Endless Inflation gives you "; inflateCheaperStats = "Upgrades are "; inflateSpecialCheaperStats = "Special Upgrades cost ";
        inflateActiveStats = "Actively flipping coins give you "; inflateStartWithCoinsStats = "You start with "; inflatePileOfBagsStats = "PILE OF BAGS give you ";

        inflateEndlessStatsTEXT.text = LocalizationStrings.inflateEndlessStats + EndlessInflation.englessInflationBonusText + LocalizationStrings.moreCoins;
        inflateSpecialCheaperStatsTEXT.text = LocalizationStrings.inflateSpecialCheaperStats + (AscendScreen.totalSpecialReduction) + LocalizationStrings.less;
        inflateStartWithCoinsStatsTEXT.text = LocalizationStrings.inflateStartWithCoinsStats + AscendScreen.starWithCoinsAmount + LocalizationStrings.coinsAfterInflating;
        inflateUpgradesStatsTEXT.text = LocalizationStrings.inflateUpgradesStats + AscendScreen.moreCoinsUpgradePercent + LocalizationStrings.moreCoins;
        inflateCheaperStatsTEXT.text = LocalizationStrings.inflateCheaperStats + AscendScreen.cheaperUpgradesPercent + LocalizationStrings.cheaper;
        inflateActiveStatsTEXT.text = LocalizationStrings.inflateActiveStats + AscendScreen.activeFlipperPercent + LocalizationStrings.moreCoins;
        inflatePileOfBagsStatsTEXT.text = LocalizationStrings.inflatePileOfBagsStats + PileOfCoinsMechanics.PileBagAmount + LocalizationStrings.moreCoinsAfterInflating;

        inflateEndlessStatsTEXT.font = LiberationEnglish; inflateSpecialCheaperStatsTEXT.font = LiberationEnglish; inflateStartWithCoinsStatsTEXT.font = LiberationEnglish; inflateUpgradesStatsTEXT.font = LiberationEnglish;
        inflateCheaperStatsTEXT.font = LiberationEnglish; inflateActiveStatsTEXT.font = LiberationEnglish; inflatePileOfBagsStatsTEXT.font = LiberationEnglish;

        inflateEndlessStatsTEXT.fontSize = 18; inflateSpecialCheaperStatsTEXT.fontSize = 18; inflateStartWithCoinsStatsTEXT.fontSize = 18; inflateUpgradesStatsTEXT.fontSize = 18;
        inflateCheaperStatsTEXT.fontSize = 18; inflateActiveStatsTEXT.fontSize = 18; inflatePileOfBagsStatsTEXT.fontSize = 18;

        if (AscendScreen.boughtRich1 == 0) { inflateUpgradesStatsTEXT.text = LocalizationStrings.inflateUpgradesStats + "0"  + LocalizationStrings.moreCoins; }
        if (AscendScreen.boughtSale1 == 0) { inflateCheaperStatsTEXT.text = LocalizationStrings.inflateCheaperStats + "0" + cheaper; }
        if (AscendScreen.boughtBagOfCoins1 == 0) { inflateStartWithCoinsStatsTEXT.text = LocalizationStrings.inflateStartWithCoinsStats + "0" + LocalizationStrings.coinsAfterInflating; }
        if (AscendScreen.boughtActiveFlipper1 == 0) { inflateActiveStatsTEXT.text = LocalizationStrings.inflateActiveStats + "0" + LocalizationStrings.moreCoins; }
        #endregion

        #region achievements

        achievements.text = "Achievements"; achievements.font = JostHeavyEngAndRuss2;
        ach1.text = "Gain 1 coin"; ach1.font = JostHeavyEngAndRuss2;
        ach2.text = "Gain 10 coins"; ach2.font = JostHeavyEngAndRuss2;
        ach3.text = "Gain 100 coins"; ach3.font = JostHeavyEngAndRuss2;
        ach4.text = "Gain 1000 coins"; ach4.font = JostHeavyEngAndRuss2;
        ach5.text = "Gain 10000 coins"; ach5.font = JostHeavyEngAndRuss2;
        ach6.text = "Gain 100000 coins"; ach6.font = JostHeavyEngAndRuss2;
        ach7.text = "Gain 1 Million coins!"; ach7.font = JostHeavyEngAndRuss2;
        ach8.text = "Gain 1 Billion coins!"; ach8.font = JostHeavyEngAndRuss2;
        ach9.text = "Gain 1 Trillion coins!"; ach9.font = JostHeavyEngAndRuss2;
        ach10.text = "Gain 1 Quadrillion coins!"; ach10.font = JostHeavyEngAndRuss2;
        ach11.text = "Gain 1 Quintillion coins!"; ach11.font = JostHeavyEngAndRuss2;
        ach12.text = "Gain 1 Sextillion coins!"; ach12.font = JostHeavyEngAndRuss2;
        ach13.text = "Gain 1 Septillion coins!"; ach13.font = JostHeavyEngAndRuss2;
        ach14.text = "Gain 1 Octillion coins!"; ach14.font = JostHeavyEngAndRuss2;
        ach15.text = "Upgrade Stronger Arms Once"; ach15.font = JostHeavyEngAndRuss2;
        ach16.text = "Upgrade Stronger Arms 10 times"; ach16.font = JostHeavyEngAndRuss2;
        ach17.text = "Upgrade Greater Coin Once"; ach17.font = JostHeavyEngAndRuss2;
        ach18.text = "Upgrade Greater Coin 10 times"; ach18.font = JostHeavyEngAndRuss2;
        ach19.text = "Upgrade Knowledge Once"; ach19.font = JostHeavyEngAndRuss2;
        ach20.text = "Upgrade Knowledge 10 times"; ach20.font = JostHeavyEngAndRuss2;
        ach21.text = "Upgrade Stronger Fist Once"; ach21.font = JostHeavyEngAndRuss2;
        ach22.text = "Upgrade Stronger Fist 10 times"; ach22.font = JostHeavyEngAndRuss2;
        ach23.text = "Upgrade Hand Injection Once"; ach23.font = JostHeavyEngAndRuss2;
        ach24.text = "Upgrade Hand Injection 10 times"; ach24.font = JostHeavyEngAndRuss2;
        ach25.text = "Upgrade Brain Power Once"; ach25.font = JostHeavyEngAndRuss2;
        ach26.text = "Upgrade Brain Power 10 times"; ach26.font = JostHeavyEngAndRuss2;
        ach27.text = "Upgrade Explosive Flips Once"; ach27.font = JostHeavyEngAndRuss2;
        ach28.text = "Upgrade Explosive Flips 10 times"; ach28.font = JostHeavyEngAndRuss2;
        ach29.text = "Upgrade Hydration Once"; ach29.font = JostHeavyEngAndRuss2;
        ach30.text = "Upgrade Hydration 10 times"; ach30.font = JostHeavyEngAndRuss2;
        ach31.text = "Upgrade Strange Potion Once"; ach31.font = JostHeavyEngAndRuss2;
        ach32.text = "Upgrade Strange Potion 10 times"; ach32.font = JostHeavyEngAndRuss2;
        ach33.text = "Upgrade Master Flipper Once"; ach33.font = JostHeavyEngAndRuss2;
        ach34.text = "Upgrade Master Flipper 10 times"; ach34.font = JostHeavyEngAndRuss2;
        ach35.text = "Upgrade Handshake Once"; ach35.font = JostHeavyEngAndRuss2;
        ach36.text = "Upgrade Handshake 10 times"; ach36.font = JostHeavyEngAndRuss2;
        ach37.text = "Upgrade Magic Flips Once"; ach37.font = JostHeavyEngAndRuss2; ach37.fontSize = 8.4f;
        ach38.text = "Upgrade Magic Flips 10 times"; ach38.font = JostHeavyEngAndRuss2; ach38.fontSize = 8.4f;
        ach39.text = "Have 2.5% Chance to get a lucky coin"; ach39.font = JostHeavyEngAndRuss2;
        ach40.text = "Have 5% Chance to get a lucky coin"; ach40.font = JostHeavyEngAndRuss2;
        ach41.text = "Hit 1 Lucky Coin"; ach41.font = JostHeavyEngAndRuss2;
        ach42.text = "Hit 10 Lucky Coins"; ach42.font = JostHeavyEngAndRuss2;
        ach43.text = "Hit 100 Lucky Coins"; ach43.font = JostHeavyEngAndRuss2;
        ach44.text = "Flip 100 Coins"; ach44.font = JostHeavyEngAndRuss2;
        ach45.text = "Flip 1000 Coins"; ach45.font = JostHeavyEngAndRuss2;
        ach46.text = "Flip 10000 Coins"; ach46.font = JostHeavyEngAndRuss2;
        ach47.text = "Flip 100000 Coins"; ach47.font = JostHeavyEngAndRuss2;
        ach49.text = "Flip 2 Coins at the same time"; ach49.font = JostHeavyEngAndRuss2;
        ach50.text = "Flip 5 Coins at the same time"; ach50.font = JostHeavyEngAndRuss2;
        ach51.text = "Flip 10 Coins at the same time"; ach51.font = JostHeavyEngAndRuss2;
        ach94.text = "Flip 21 Coins at the same time"; ach94.font = JostHeavyEngAndRuss2;
        ach52.text = "Upgrade 1 Coin Flipper"; ach52.font = JostHeavyEngAndRuss2;
        ach53.text = "Upgrade 5 Coin Flippers"; ach53.font = JostHeavyEngAndRuss2;
        ach54.text = "Upgrade 10 Coin Flippers"; ach54.font = JostHeavyEngAndRuss2;
        ach55.text = "Upgrade 21 Coin Flippers"; ach55.font = JostHeavyEngAndRuss2;
        ach56.text = "Have 75% Chance for a successful flip"; ach56.font = JostHeavyEngAndRuss2;
        ach57.text = "Have 93.75% Chance for a successful flip"; ach57.font = JostHeavyEngAndRuss2;
        ach58.text = "Flip all coins!"; ach58.font = JostHeavyEngAndRuss2;
        ach59.text = "Flip 1 Million coins!"; ach59.font = JostHeavyEngAndRuss2;
        ach60.text = "Hit a lucky coin 1000 times!"; ach60.font = JostHeavyEngAndRuss2;
        ach61.text = "Hit TAILS 100000 times!"; ach61.font = JostHeavyEngAndRuss2;
        ach62.text = "Hit HEADS 100000 times!"; ach62.font = JostHeavyEngAndRuss2;
        ach63.text = "Complete challenge #1"; ach63.font = JostHeavyEngAndRuss2;
        ach64.text = "Complete challenge #2"; ach64.font = JostHeavyEngAndRuss2;
        ach65.text = "Complete challenge #3"; ach65.font = JostHeavyEngAndRuss2;
        ach66.text = "Complete challenge #4"; ach66.font = JostHeavyEngAndRuss2;
        ach67.text = "Unlock the Auto Upgrade"; ach67.font = JostHeavyEngAndRuss2;
        ach68.text = "Actively flip a coin 100 times!"; ach68.font = JostHeavyEngAndRuss2;
        ach69.text = "Actively flip a coin 1000 times!"; ach69.font = JostHeavyEngAndRuss2;
        ach70.text = "Actively flip a coin 5000 times!"; ach70.font = JostHeavyEngAndRuss2;
        ach71.text = "Buy Treasure Chest once"; ach71.font = JostHeavyEngAndRuss2;
        ach72.text = "Buy Treasure Chest 10 times"; ach72.font = JostHeavyEngAndRuss2;
        ach73.text = "Buy Coin Flipping Ritual once"; ach73.font = JostHeavyEngAndRuss2;
        ach74.text = "Buy Coin Flipping Ritual 10 times"; ach74.font = JostHeavyEngAndRuss2;
        ach75.text = "Upgrade High Five once"; ach75.font = JostHeavyEngAndRuss2;
        ach76.text = "Upgrade High Five 10 times"; ach76.font = JostHeavyEngAndRuss2;
        ach77.text = "Have a total of 25 Inflation Coins"; ach77.font = JostHeavyEngAndRuss2;
        ach78.text = "Have a total of 50 Inflation Coins"; ach78.font = JostHeavyEngAndRuss2;
        ach79.text = "Have a total of 75 Inflation Coins"; ach79.font = JostHeavyEngAndRuss2;
        ach80.text = "Unlock 5 Inflation upgrades"; ach80.font = JostHeavyEngAndRuss2;
        ach81.text = "Unlock 10 Inflation upgrades"; ach81.font = JostHeavyEngAndRuss2;
        ach82.text = "Unlock 20 Inflation upgrades"; ach82.font = JostHeavyEngAndRuss2;
        ach83.text = "Unlock 30 Inflation upgrades"; ach83.font = JostHeavyEngAndRuss2;
        ach84.text = "Unlock ALL Inflation upgrades"; ach84.font = JostHeavyEngAndRuss2;
        ach85.text = "Click on a pile of coins 10 times"; ach85.font = JostHeavyEngAndRuss2;
        ach86.text = "Click on a pile of coins 100 times"; ach86.font = JostHeavyEngAndRuss2;
        ach87.text = "Inflate!"; ach87.font = JostHeavyEngAndRuss2;
        ach88.text = "Inflate 5 times!"; ach88.font = JostHeavyEngAndRuss2;
        ach89.text = "Gamble 10 times"; ach89.font = JostHeavyEngAndRuss2;
        ach90.text = "Lose all coins gambling 5 times"; ach90.font = JostHeavyEngAndRuss2;
        ach91.text = "Double all coins gambling 5 times"; ach91.font = JostHeavyEngAndRuss2;
        ach92.text = "Find the hidden bronze coin!"; ach92.font = JostHeavyEngAndRuss2;
        ach93.text = "Find the hidden silver coin!"; ach93.font = JostHeavyEngAndRuss2;


        #endregion

        #region InflationTree

        inflate.text = "Inflate"; inflate.font = JostHeavyEngAndRuss; inflate.fontSize = 20;
        youHave21Flippers.text = "You have 21 coin flippers!"; youHave21Flippers.font = JostHeavyEngAndRuss;
        youNeed21Flippers.text = "You need 21 coin flippers!"; youNeed21Flippers.font = JostHeavyEngAndRuss; youNeed21Flippers.fontSize = 17.7f;
        youCanViewTreeAtAnyTime.text = "(You can look at the inflation tree at any time)"; youCanViewTreeAtAnyTime.font = JostHeavyEngAndRuss;
        youCanViewTreeAtAnyTime.fontSize = 14;
        smallInflationDescription.text = "Inflating will reset all your stats (with a few exceptions) and take you to a screen with unique permanent upgrades. Once you are done purchasing inflation upgrades, the game will start from the beginning"; smallInflationDescription.font = LiberationEnglish;
        smallInflationDescription.fontSize = 15;
        thisIsHowInflationWorks.text = "This is how the Inflation system works:"; thisIsHowInflationWorks.font = JostHeavyEngAndRuss;
        bigInflationDescription.text = "-You gain Inflation coins everytime you get one quarter of the way to the next TIER of coins.\n-A TIER of coins is: Million, billion, trillion, quadrillion and so on.\n-Example: You will start gaining Inflation coins once you reach 1 Million. And then you are awarded Inflation coins when you reach - 1 Million, 250 Million, 500 Million, 750 Million, 1 Billion, 250 Billion, 500 Billion, 750 Billion and so on.\n-The base Inflation coin amount you gain everytime you gain Inflation coins is 1. Buy the GREATER INFLATION upgrades to gain more Inflation coins when you play."; bigInflationDescription.font = JostHeavyEngAndRuss; bigInflationDescription.fontSize = 7.6f;
        youHave.text = "You have"; youHave.font = JostHeavyEngAndRuss;
        inflationCoins.text = "Inflation Coins"; inflationCoins.font = JostHeavyEngAndRuss;
        dontInflateJustLook.text = "Dont Inflate, only look at the Tree"; dontInflateJustLook.font = JostHeavyEngAndRuss; dontInflateJustLook.fontSize = 23;
        doYouWishToInflate.text = "Do you wish to INFLATE?"; doYouWishToInflate.font = JostHeavyEngAndRuss; doYouWishToInflate.fontSize = 20;
        YES.text = "YES"; YES.font = LiberationEnglish;
        NO.text = "NO"; NO.font = LiberationEnglish;
        currentlyOnlyViewingTree.text = "! You are currently only viewing the Inflation Tree and cannot purchase any upgrades.";
        currentlyOnlyViewingTree.font = LiberationEnglish;
        backToFlipping.text = "Back to flipping"; backToFlipping.font = LiberationEnglish; backToFlipping.fontSize = 28;
        backToFlipping2.text = "Back to flipping"; backToFlipping2.font = JostHeavyEngAndRuss; backToFlipping2.fontSize = 22;
        inflationCoinsText = "Inflation Coins: ";
        InflationCoins.text = inflationCoinsText + AscendCoins.ascensionCoinAmount; InflationCoins.fontSize = 23; InflationCoins.font = JostHeavyEngAndRuss;

        rich1.text = "RICH I"; rich1.font = JostHeavyEngAndRuss;
        rich2.text = "RICH II"; rich2.font = JostHeavyEngAndRuss;
        rich3.text = "RICH III"; rich3.font = JostHeavyEngAndRuss;
        rich4.text = "RICH IV"; rich4.font = JostHeavyEngAndRuss;
        rich5.text = "RICH V"; rich5.font = JostHeavyEngAndRuss;
        rich6.text = "RICH VI"; rich6.font = JostHeavyEngAndRuss;
        rich7.text = "RICH VII"; rich7.font = JostHeavyEngAndRuss;
        omegaRich.text = "OMEGA RICH"; omegaRich.font = JostHeavyEngAndRuss;

        rich1Desc.text = "All upgrades give you 1% more coins.\nRICH upgrades works for every CHALLENGE"; rich1Desc.font = JostHeavyEngAndRuss;
        rich1Desc.fontSize = 15;
        rich2Desc.text = "All upgrades give you 20% more coins"; rich2Desc.font = JostHeavyEngAndRuss;
        rich3Desc.text = "All upgrades give you 50% more coins"; rich3Desc.font = JostHeavyEngAndRuss;
        rich4Desc.text = "All upgrades give you 100% more coins"; rich4Desc.font = JostHeavyEngAndRuss;
        rich5Desc.text = "All upgrades give you 175% more coins"; rich5Desc.font = JostHeavyEngAndRuss;
        rich6Desc.text = "All upgrades give you 300% more coins"; rich6Desc.font = JostHeavyEngAndRuss;
        rich7Desc.text = "All upgrades give you 750% more coins"; rich7Desc.font = JostHeavyEngAndRuss;
        omegaRichDes.text = "All upgrades give you 1250% more coins"; omegaRichDes.font = JostHeavyEngAndRuss;

        sale1.text = "SALE I"; sale1.font = JostHeavyEngAndRuss;
        sale2.text = "SALE II"; sale2.font = JostHeavyEngAndRuss;
        sale3.text = "SALE III"; sale3.font = JostHeavyEngAndRuss;
        sale4.text = "SALE IV"; sale4.font = JostHeavyEngAndRuss;
        steamSale.text = "STEAM SALE"; steamSaleDesc.font = JostHeavyEngAndRuss; steamSale.fontSize = 22;
        sale1Desc.text = "All upgrades cost 2% less. This upgrade branch does not affect special upgrades\nSALE Upgrades works for all CHALLENGES"; sale1Desc.font = JostHeavyEngAndRuss; sale1Desc.fontSize = 14;
        sale2Desc.text = "All upgrades cost 7% less"; sale2Desc.font = JostHeavyEngAndRuss;
        sale3Desc.text = "All upgrades cost 14% less"; sale3Desc.font = JostHeavyEngAndRuss;
        sale4Desc.text = "All upgrades cost 22% less"; sale4Desc.font = JostHeavyEngAndRuss;
        steamSaleDesc.text = "All upgrades cost 50% less"; steamSaleDesc.font = JostHeavyEngAndRuss;

        bag1.text = "BAG OF COINS I"; bag1.font = JostHeavyEngAndRuss;
        bag2.text = "BAG OF COINS II"; bag2.font = JostHeavyEngAndRuss;
        bag3.text = "BAG OF COINS III"; bag3.font = JostHeavyEngAndRuss;
        bag4.text = "BAG OF COINS IV"; bag4.font = JostHeavyEngAndRuss;
        hugeBag.text = "HUGE BAG OF COINS"; hugeBag.font = JostHeavyEngAndRuss;
        pileOfBags.text = "PILE OF BAGS"; pileOfBags.font = JostHeavyEngAndRuss;

        bag1Desc.text = "You start the game with a total of 75 coins after inflating\nBAG OF COINS upgrades will only work for the \"No auto flips\" challenge."; bag1Desc.font = JostHeavyEngAndRuss;
        bag2Desc.text = "You start the game with a total of 500 coins after inflating"; bag2Desc.font = JostHeavyEngAndRuss;
        bag3Desc.text = "You start the game with a total of 3000 coins after inflating"; bag3Desc.font = JostHeavyEngAndRuss;
        bag4Desc.text = "You start the game with a total of 20000 coins after inflating"; bag4Desc.font = JostHeavyEngAndRuss;
        hugeBasDesc.text = "You start the game with a total of 100 Thousand coins after inflating"; hugeBasDesc.font = JostHeavyEngAndRuss;
        pileOfBagsDesc.text = "Everytime you click on a pile of coins, +250 Coins will be added to the amount of coins you start with after inflating."; pileOfBagsDesc.font = JostHeavyEngAndRuss;

        greaterInflation1.text = "GREATER INFLATION I"; greaterInflation1.font = JostHeavyEngAndRuss;
        greaterInflation2.text = "GREATER INFLATION II"; greaterInflation2.font = JostHeavyEngAndRuss;
        greaterInflation3.text = "GREATER INFLATION III"; greaterInflation3.font = JostHeavyEngAndRuss;
        greaterInflation4.text = "GREATER INFLATION IV"; greaterInflation4.font = JostHeavyEngAndRuss;
        greaterInflation5.text = "GREATER INFLATION V"; greaterInflation5.font = JostHeavyEngAndRuss;
        crazyInflation.text = "CRAZY INFLATION!!"; crazyInflation.font = JostHeavyEngAndRuss; crazyInflation.fontSize = 17;
        inflationGamble1.text = "INFLATION GAMBLE I"; inflationGamble1.font = JostHeavyEngAndRuss; inflationGamble1.fontSize = 17;
        inflationGamble2.text = "INFLATION GAMBLE II"; inflationGamble2.font = JostHeavyEngAndRuss; inflationGamble2.fontSize = 17;
        inflationGamble3.text = "INFLATION GAMBLE III"; inflationGamble3.font = JostHeavyEngAndRuss; inflationGamble3.fontSize = 17;
        inflationGamble4.text = "INFLATION GAMBLE IV"; inflationGamble4.font = JostHeavyEngAndRuss; inflationGamble4.fontSize = 17;

        greaterInflation1Desc.text = "+2 Inflation coins when you hit Quadrillion TIER+\nAll INFLATION upgrades work for every challenge except the \"ALWAYS LUCKY\" challenge"; greaterInflation1Desc.font = JostHeavyEngAndRuss;
        greaterInflation2Desc.text = "+3 Inflation coins when you hit Quadrillion TIER+"; greaterInflation2Desc.font = JostHeavyEngAndRuss;
        greaterInflation3Desc.text = "+2 Inflation coins when you hit Billion TIER+\n+3 Inflation coins when you hit Quadrillion TIER+"; greaterInflation3Desc.font = JostHeavyEngAndRuss;
        greaterInflation4Desc.text = "+3 Inflation coins when you hit Trillion TIER+\n+4 Inflation coins when you hit Quintillion TIER+"; greaterInflation4Desc.font = JostHeavyEngAndRuss;
        greaterInflation5Desc.text = "+4 Inflation coins when you hit Trillion TIER+\n+5 Inflation coins when you hit Sextillion TIER+"; greaterInflation5Desc.font = JostHeavyEngAndRuss;
        crazyInflationDesc.text = "+6 Inflation coins when you hit Million TIER+"; crazyInflationDesc.font = JostHeavyEngAndRuss;
        inflationGamble1Desc.text = "Everytime you gain Inflation coins there is a +3% chance to gain 1 extra Inflation coin"; inflationGamble1Desc.font = JostHeavyEngAndRuss;
        inflationGamble2Desc.text = "Everytime you gain Inflation coins there is a +4% chance to gain 1 extra Inflation coin"; inflationGamble2Desc.font = JostHeavyEngAndRuss;
        inflationGamble3Desc.text = "Everytime you gain Inflation coins there is a +5% chance to gain 1 extra Inflation coin"; inflationGamble3Desc.font = JostHeavyEngAndRuss;
        inflationGamble4Desc.text = "Everytime you gain Inflation coins there is a +6% chance to gain 1 extra Inflation coin"; inflationGamble4Desc.font = JostHeavyEngAndRuss;

        extraSpecialUpgrade1.text = "EXTRA SPECIAL UPGRADES I"; extraSpecialUpgrade1.font = JostHeavyEngAndRuss; extraSpecialUpgrade1.fontSize = 15;
        extraSpecialUpgrade2.text = "EXTRA SPECIAL UPGRADES II"; extraSpecialUpgrade2.font = JostHeavyEngAndRuss; extraSpecialUpgrade2.fontSize = 15;
        extraSpecialUpgrade3.text = "EXTRA SPECIAL UPGRADES III"; extraSpecialUpgrade3.font = JostHeavyEngAndRuss; extraSpecialUpgrade3.fontSize = 15;
        extraExtraSpecialUpgrade1.text = "EXTRA EXTRA SPECIAL UPGRADES"; extraExtraSpecialUpgrade1.font = JostHeavyEngAndRuss; extraExtraSpecialUpgrade1.fontSize = 13;
        biggerPile1.text = "BIGGER PILE OF COINS I"; biggerPile1.font = JostHeavyEngAndRuss;
        biggerPile2.text = "BIGGER PILE OF COINS II"; biggerPile2.font = JostHeavyEngAndRuss;
        theGambler.text = "THE GAMBLER"; theGambler.font = JostHeavyEngAndRuss;
        getLuckier.text = "GET LUCKIER"; getLuckier.font = JostHeavyEngAndRuss;
        autoUpgradeInflate.text = "AUTO UPGRADE"; autoUpgradeInflate.font = JostHeavyEngAndRuss;

        extraSpecialUpgrade1Desc.text = "GAMBLE has 2 more tries\nEvery upgrade in this branch will reduce the price of all Special Upgrades by 1% and works for every challenge"; extraSpecialUpgrade1Desc.font = JostHeavyEngAndRuss; extraSpecialUpgrade1Desc.fontSize = 12.6f;
        extraSpecialUpgrade2Desc.text = "GAMBLE now has a 51% chance to double your coins.\nPILE OF COINS generates more coins"; extraSpecialUpgrade2Desc.font = JostHeavyEngAndRuss;
        extraSpecialUpgrade3Desc.text = "When you take your coins out of a PILE OF COINS, there is a 5% the coins stay in the pile."; extraSpecialUpgrade3Desc.font = JostHeavyEngAndRuss;
        extraExtraSpecialUpgrade1Desc.text = "Special upgrades cost 13% less\nGAMBLE has 1 more try\n2 More PILE OF COINS that generates coins\nUPGRADED COIN FLIPS now give you 3X the coins and lucky coins give you 15X"; extraExtraSpecialUpgrade1Desc.font = JostHeavyEngAndRuss;
        extraExtraSpecialUpgrade1Desc.fontSize = 11.6f;
        biggerPile1Desc.text = "PILE OF COINS gives you +1 pile that generates coins\nPILE OF COINS gives you more coins"; biggerPile1Desc.font = JostHeavyEngAndRuss;
        biggerPile2Desc.text = "PILE OF COINS gives you +1 pile that generates coins\nPILE OF COINS gives you even more coins"; biggerPile2Desc.font = JostHeavyEngAndRuss;
        theGamblerDesc.text = "GAMBLE has 1 more try\nEverytime you GAMBLE, the chances for doubling your coins are increased by 1%"; theGamblerDesc.font = JostHeavyEngAndRuss;
        getLuckierDesc.text = "Whenever you hit a lucky coin. There is a 5% chance that the lucky coin will be an even luckier coin that gives you 50X the coins"; getLuckierDesc.font = JostHeavyEngAndRuss; getLuckierDesc.fontSize = 12;
        autoUpgradeDesc.text = "Unlocks the auto upgrade inside the special upgrades tab"; autoUpgradeDesc.font = JostHeavyEngAndRuss;

        active1.text = "ACTIVE FLIPPER I"; active1.font = JostHeavyEngAndRuss; active1.fontSize = 17;
        active2.text = "ACTIVE FLIPPER II"; active2.font = JostHeavyEngAndRuss; active2.fontSize = 17;
        active3.text = "ACTIVE FLIPPER III"; active3.font = JostHeavyEngAndRuss; active3.fontSize = 17;
        active4.text = "ACTIVE FLIPPER IV"; active4.font = JostHeavyEngAndRuss; active4.fontSize = 17;
        superActiveFlipper.text = "SUPER ACTIVE FLIPPER"; superActiveFlipper.font = JostHeavyEngAndRuss; superActiveFlipper.fontSize = 17;
        activeEqualsBiggerPile.text = "ACTIVE = BIGGER PILE OF COINS"; activeEqualsBiggerPile.font = JostHeavyEngAndRuss; activeEqualsBiggerPile.fontSize = 13;

        active1Desc.text = "Every coin you actively flip will give you 8% more coins\nActive flipper upgrades works for every CHALLENGE"; active1Desc.font = JostHeavyEngAndRuss; active1Desc.fontSize = 12;
        active2Desc.text = "Every coin you actively flip will give you 23% more coins"; active2Desc.font = JostHeavyEngAndRuss;
        active3Desc.text = "Every coin you actively flip will give you 40% more coins"; active3Desc.font = JostHeavyEngAndRuss;
        active4Desc.text = "Every coin you actively flip will give you 69% more coins"; active4Desc.font = JostHeavyEngAndRuss;
        superActiveFlipperDesc.text = "Every coin you actively flip will give you 300% more coins.\nLucky coins give you 10X"; superActiveFlipperDesc.font = JostHeavyEngAndRuss;
        activeEqualsBiggerPileDesc.text = "Everytime you actively flip a coin, there is a 5% chance that the amount of coins you have on HEADS/TAILS will get added into the PILE OF COINS"; activeEqualsBiggerPileDesc.font = JostHeavyEngAndRuss;
        backToFlippingIflated.text = "Do you wish to go back to flipping coins?"; backToFlippingIflated.font = JostHeavyEngAndRuss;
        yes.text = "YES"; yes.font = JostHeavyEngAndRuss; no.text = "NO"; no.font = JostHeavyEngAndRuss;

        for (int i = 0; i < unLocked.Length; i++)
        {
            unLocked[i].text = "LOCKED";
            unLocked[i].font = LiberationEnglish;
            unLocked[i].fontSize = 14;
        }

        for (int i = 0; i < locked.Length; i++)
        {
            locked[i].text = "UNLOCKED";
            locked[i].font = LiberationEnglish;
            locked[i].fontSize = 12;
        }


        #endregion

        #region settings

        if (LoadSaves.isMobileBuild == false)
        {
            exitGame.text = "EXIT GAME"; exitGame.font = JostHeavyEngAndRuss;
            fullscreen.text = "FULLSCREEN"; fullscreen.font = LiberationEnglish;
        }

        music.text = "Music"; music.font = JostHeavyEngAndRuss; audiotext.text = "Audio"; audiotext.font = JostHeavyEngAndRuss;
        saveGame.text = "SAVE GAME"; saveGame.font = JostHeavyEngAndRuss;
        resetEverything.text = "RESET EVERYTHING"; resetEverything.font = JostHeavyEngAndRuss;
        if(LoadSaves.isMobileBuild == false) { gameIsSaved30Seconds.text = "(Game is saved every 30 seconds)"; }
        else { gameIsSaved30Seconds.text = "(Game is saved every 10 seconds)"; }
        gameIsSaved30Seconds.font = JostHeavyEngAndRuss;
        foundHiddenBronze.text = "You found a hidden bronze coin!"; foundHiddenBronze.font = JostHeavyEngAndRuss;
        foundHiddenSilver.text = "You found a hidden silver coin!"; foundHiddenSilver.font = JostHeavyEngAndRuss;
        settings.text = "Settings"; settings.font = LiberationEnglish; settings.fontSize = 27;
        info.text = "Info"; info.font = LiberationEnglish; info.fontSize = 27;
        socials.text = "Socials"; socials.font = LiberationEnglish; socials.fontSize = 27;
        generalGameInfo.text = "General game info"; generalGameInfo.font = LiberationEnglish;
        mechanicsExplanations.text = "Mechanics explanations:"; mechanicsExplanations.font = LiberationEnglish;

        inflationSystem.text = "Inflation System"; inflationSystem.font = LiberationEnglish;
        inflationSystemDesc.text = "-You gain Inflation coins every time you get one quarter of the way to the next TIER of coins.\n-A TIER of coins is: Million, billion, trillion, quadrillion and so on.\n-Example: You will start gaining Inflation coins once you reach 1 Million. And then you are awarded Inflation coins when you reach: 1 Million, 250 Million, 500 Million, 750 Million, 1 Billion, 250 Billion, 500 Billion, 750 Billion and so on.\n-The base Inflation coin amount you gain everytime you gain Inflation coins is 1. Buy the \"GREATER INFLATION\"  upgrades to gain more Inflation coins when you play."; inflationSystemDesc.font = LiberationEnglish;
        inflationSystemDesc.fontSize = 13;

        pileOfCoinsText.text = "Pile of Coins:"; pileOfCoinsText.font = LiberationEnglish;
        pileOfCoinsDesc.text = "The amount of coins the pile will generate is based on how many coins you have on every successful flip and how many coin flippers you have + 4. So if you have 150 coins on heads/tails and 4 coin flippers, the amount it generates would be 150 * (4+4) which equals 1200. The amount will be larger if the player has bought some \"Extra Special Upgrades\" inflation upgrades."; pileOfCoinsDesc.font = LiberationEnglish;
        pileOfCoinsDesc.fontSize = 13;

        offlineProgression.text = "Offline Progression:"; offlineProgression.font = LiberationEnglish;
        offlineProgressionDesc.text = "You will earn coins every minute that you are offline. The amount is based on how many auto flippers and coins on heads/tails you have. So if you have 500 Thousand coins on Head/Tails and 4 auto flippers. You will gain 2 million coins every minute."; offlineProgressionDesc.font = LiberationEnglish; offlineProgressionDesc.fontSize = 13;

        developerBy.text = "Coin Flipper is developed by: <b>Simon Eftestøl</b>"; developerBy.font = LiberationEnglish;
        musicBy.text = "Music by: <b>HSB Loops</b>"; musicBy.font = LiberationEnglish;
        texturesProvidedBy.text = "Textures provided by: <b>Free SVG</b>"; texturesProvidedBy.font = LiberationEnglish;
        followMyTwitch.text = "Follow my twitch!"; followMyTwitch.font = LiberationEnglish;
        follotMyTwitter.text = "Follow my X/Twitter!"; follotMyTwitter.font = LiberationEnglish;
        joinTheDiscord.text = "Join the discord!"; joinTheDiscord.font = LiberationEnglish;
        quitPlayingChallenge.text = "Do you wish to quit playing this challenge?"; quitPlayingChallenge.font = LiberationEnglish;
        quitChallengeDesc.text = "The game will be reset and put back to the \"Choose heads or tails\" screen. All permanent inflation upgrades will of course not be reset."; quitChallengeDesc.font = LiberationEnglish;
        quitChalYes.text = "YES"; quitChalYes.font = JostHeavyEngAndRuss;
        quitChalNo.text = "NO"; quitChalNo.font = JostHeavyEngAndRuss;
        whishToResetGame.text = "Do you wish to start completely over?"; whishToResetGame.font = LiberationEnglish;
        wishToResetDesc.text = "Everything will get reset and the game will start from the beginning."; wishToResetDesc.font = LiberationEnglish;
        resetYes.text = "YES"; resetYes.font = JostHeavyEngAndRuss;
        resetNo.text = "NO"; resetNo.font = JostHeavyEngAndRuss;
        quitChall1.text = "QUIT CHALLENGE #1"; quitChall1.font = JostHeavyEngAndRuss; quitChall1.fontSize = 36;
        quitChall2.text = "QUIT CHALLENGE #2"; quitChall2.font = JostHeavyEngAndRuss; quitChall2.fontSize = 36;
        quitChall3.text = "QUIT CHALLENGE #3"; quitChall3.font = JostHeavyEngAndRuss; quitChall3.fontSize = 36;
        quitChall4.text = "QUIT CHALLENGE #4"; quitChall4.font = JostHeavyEngAndRuss; quitChall4.fontSize = 36;
        gameSaved.text = "Game Saved"; gameSaved.font = LiberationEnglish;
        gameSaved2.text = "Game Saved"; gameSaved2.font = LiberationEnglish;

        #endregion

        #region offlineEarnings

        days = " Days "; hours = " Hours "; minuts = " Minutes "; secondsTime = " Seconds";

        offlineEarningTotalText.font = JostHeavyEngAndRuss;
        timeGoneText.font = JostHeavyEngAndRuss;

        welcomeBack.text = "Welcome Back!"; welcomeBack.font = JostHeavyEngAndRuss;
        youWereGoneFor.text = "You were gone for:"; youWereGoneFor.font = LiberationEnglish;
        offlineEarnings.text = "Offline Earnings: "; offlineEarnings.font = LiberationEnglish;
        offlineOK.text = "OK"; offlineOK.font = JostHeavyEngAndRuss;

        #endregion

        #region FINAL missed
        upgradesHover.text = "Upgrades"; upgradesHover.font = JostHeavyEngAndRuss; upgradesHover.fontSize = 36;
        specialUpgradesHover.text = "Special Upgrades"; specialUpgradesHover.font = JostHeavyEngAndRuss; specialUpgradesHover.fontSize = 35;
        achievementsHover.text = "Achievements"; achievementsHover.font = JostHeavyEngAndRuss; achievementsHover.fontSize = 29;
        statsHover.text = "Stats"; statsHover.font = JostHeavyEngAndRuss; statsHover.fontSize = 36;

        specialIpgradeWarning.text = "Upgraded Coin Flips will be automatically flipping by default. You have to buy another \"Automatic Coin Flips\" upgrade before buying this upgrade.";
        specialIpgradeWarning.font = JostHeavyEngAndRuss; specialIpgradeWarning.fontSize = 8;

        congrats1.text = "Congrats!"; congrats1.font = JostHeavyEngAndRuss;
        congrats2.text = "Congrats!"; congrats2.font = JostHeavyEngAndRuss;
        congrats3.text = "Congrats!"; congrats3.font = JostHeavyEngAndRuss;
        congrats4.text = "Congrats!"; congrats4.font = JostHeavyEngAndRuss;
        youUnlocked1.text = "You unlocked:"; youUnlocked1.font = JostHeavyEngAndRuss; youUnlocked1.fontSize = 15;
        youUnlocked2.text = "You unlocked:"; youUnlocked2.font = JostHeavyEngAndRuss; youUnlocked2.fontSize = 15;
        youUnlocked3.text = "You unlocked:"; youUnlocked3.font = JostHeavyEngAndRuss; youUnlocked3.fontSize = 15;
        youUnlocked4.text = "You unlocked:"; youUnlocked4.font = JostHeavyEngAndRuss; youUnlocked4.fontSize = 15;
        youCompletedChal1.text = "You completed challenge #1 - \"No auto flips\""; youCompletedChal1.font = JostHeavyEngAndRuss;
        youCompletedChal2.text = "You completed challenge #2 - \"Unlucky\""; youCompletedChal2.font = JostHeavyEngAndRuss;
        youCompletedChal3.text = "You completed challenge #3 - \"1 Coin Flipper\""; youCompletedChal3.font = JostHeavyEngAndRuss;
        youCompletedChal4.text = "You completed challenge #4 - \"Lucky\" "; youCompletedChal4.font = JostHeavyEngAndRuss;
        completedChalFlipAll.text = "Flip All"; completedChalFlipAll.font = JostHeavyEngAndRuss;
        completedChallAutoFlipsEquals.text = "Auto Flips ="; completedChallAutoFlipsEquals.font = JostHeavyEngAndRuss; completedChallAutoFlipsEquals.fontSize = 25;
        onText.text = "ON"; onText.font = JostHeavyEngAndRuss;
        onText2.text = "ON"; onText2.font = JostHeavyEngAndRuss;
        offText.text = "OFF"; offText.font = JostHeavyEngAndRuss;
        chal2CompletedRewardInfo.text = "First 5 coin flippers will always be successful"; chal2CompletedRewardInfo.font = JostHeavyEngAndRuss;
        chal3CompletedRewardInfo.text = "The first coin flipper will always be successful and gains a +500% coin bonus!";
        chal3CompletedRewardInfo.font = JostHeavyEngAndRuss;
        chal4CompletedRewardInfo.text = "Coin flips now have up to 15% chance to hit a lucky coin"; chal4CompletedRewardInfo.font = JostHeavyEngAndRuss;
        chal4CompletedRewardInfo.fontSize = 10;

        totalCoins = "Coins: ";
        coinsMainText.text = "Coins: " + FormatCoins(GlobalCoins.CoinCount) ; coinsMainText.font = JostHeavyEngAndRuss;

        lockedAuto.text = "LOCKED"; lockedAuto.font = JostHeavyEngAndRuss;
        lockedDuplicate.text = "LOCKED"; lockedDuplicate.font = JostHeavyEngAndRuss;
        lockedLucky.text = "LOCKED"; lockedLucky.font = JostHeavyEngAndRuss;
        lockedHigherChance.text = "LOCKED"; lockedHigherChance.font = JostHeavyEngAndRuss;
        lockedSpecialUpgrade.text = "LOCKED"; lockedSpecialUpgrade.font = JostHeavyEngAndRuss;

        moreCoinsIn = "More coins in: "; Xseconds = " Seconds";
        moreCoinsIn1.font = JostHeavyEngAndRuss;
        moreCoinsIn2.font = JostHeavyEngAndRuss;
        moreCoinsIn3.font = JostHeavyEngAndRuss;
        moreCoinsIn4.font = JostHeavyEngAndRuss;
        moreCoinsIn5.font = JostHeavyEngAndRuss;
        plussPile1.text = "+PILE OF COINS"; plussPile1.font = JostHeavyEngAndRuss;
        plussPile2.text = "+PILE OF COINS"; plussPile2.font = JostHeavyEngAndRuss;
        plussPile3.text = "+PILE OF COINS"; plussPile3.font = JostHeavyEngAndRuss;
        plussPile4.text = "+PILE OF COINS"; plussPile4.font = JostHeavyEngAndRuss;
        plussPile5.text = "+PILE OF COINS"; plussPile5.font = JostHeavyEngAndRuss;
        thisPileContains1.text = "This pile contains: "; thisPileContains1.font = JostHeavyEngAndRuss;
        thisPileContains2.text = "This pile contains: "; thisPileContains2.font = JostHeavyEngAndRuss;
        thisPileContains3.text = "This pile contains: "; thisPileContains3.font = JostHeavyEngAndRuss;
        thisPileContains4.text = "This pile contains: "; thisPileContains4.font = JostHeavyEngAndRuss;
        thisPileContains5.text = "This pile contains: "; thisPileContains5.font = JostHeavyEngAndRuss;

        totalCoinsPile1.text = FormatCoins2(PileOfCoinsMechanics.PileOfCoinsAmount1);
        totalCoinsPile2.text = FormatCoins2(PileOfCoinsMechanics.PileOfCoinsAmount2);
        totalCoinsPile3.text = FormatCoins2(PileOfCoinsMechanics.PileOfCoinsAmount3);
        totalCoinsPile4.text = FormatCoins2(PileOfCoinsMechanics.PileOfCoinsAmount4);
        totalCoinsPile5.text = FormatCoins2(PileOfCoinsMechanics.PileOfCoinsAmount5);

        totalCoinsPile1.font = JostHeavyEngAndRuss;
        totalCoinsPile2.font = JostHeavyEngAndRuss;
        totalCoinsPile3.font = JostHeavyEngAndRuss;
        totalCoinsPile4.font = JostHeavyEngAndRuss;
        totalCoinsPile5.font = JostHeavyEngAndRuss;

        heads = "HEADS! ";
        tails = "TAILS! ";
        luckyCoin = "LUCKY COIN! ";

        #endregion

        googlePlayText.text = "Also available on Mobile!";
        googlePlayText.font = JostHeavyEngAndRuss;

        if (LoadSaves.isMobileBuild == true) { SetMobileTexts(); }
    }
    #endregion


    #region RUSSIANREGION
    //RUSSIAN
    public void Russian()
    {
        changeFont = 1;
        ChooseText = 2;

        PlayerPrefs.SetInt("ChosenText", ChooseText);
        #region ChooseScene
        HeadsOrTails.text = "Орел или решка?"; HeadsOrTails.font = JostHeavyEngAndRuss;
        youChoseHeads.text = "Вы выбрали Орел!"; youChoseHeads.font = JostHeavyEngAndRuss;
        youChoseTails.text = "Вы выбрали Решка!"; youChoseTails.font = JostHeavyEngAndRuss;
        challengesText.text = "Задания"; challengesText.font = JostHeavyEngAndRuss;
        challenge1Name.text = "Без Авто Подбрасываний"; challenge1Name.font = JostHeavyEngAndRuss; challenge1Name.fontSize = 19;
        challenge2Name.text = "25% шанс Подбрасывания"; challenge2Name.font = JostHeavyEngAndRuss; challenge2Name.fontSize = 18;
        challenge3Name.text = "1 Подбрасыватель Монет"; challenge3Name.font = JostHeavyEngAndRuss; challenge3Name.fontSize = 20;
        challenge4Name.text = "Постоянная Удача"; challenge4Name.font = JostHeavyEngAndRuss; challenge4Name.fontSize = 27;
        challenge1Text.text = "задание №1"; challenge1Text.font = ARIEL;
        challenge2Text.text = "задание №2"; challenge2Text.font = ARIEL;
        challenge3Text.text = "задание №3"; challenge3Text.font = ARIEL;
        challenge4Text.text = "задание №4"; challenge4Text.font = ARIEL;
        challengeNegative1.text = "* Автоматические Подбрасывания Монет заблокированы\n*  Обновленные Подбрасывания Монет заблокированы"; challengeNegative1.font = JostHeavyEngAndRuss; challengeNegative1.fontSize = 12f;
        challengeNegative2.text = "* Постоянные 25% для успешных подбрасываний\n* Повышенный Шанс на успех заблокирован"; challengeNegative2.font = JostHeavyEngAndRuss; challengeNegative2.fontSize = 13f;
        challengeNegative3.text = "* У вас есть только 1 подбрасыватель монет\n* Обновление Подбрасывать Больше Монет заблокировано"; challengeNegative3.font = JostHeavyEngAndRuss; challengeNegative3.fontSize = 11f;
        challengeNegative4.text = "* Вы не можете получить инфляционные монеты во время этого задания"; challengeNegative4.font = JostHeavyEngAndRuss; challengeNegative4.fontSize = 13f;
        challengePositive1.text = "* Ваши подбрасывания приносят на 500% больше монет"; challengePositive1.font = JostHeavyEngAndRuss;
        challengepositive2.text = "* Каждый бросок монеты приносит удачу"; challengepositive2.font = JostHeavyEngAndRuss; challengepositive2.fontSize = 12;
        Goal1text.text = "Цель:"; Goal1text.font = JostHeavyEngAndRuss;
        Goal2text.text = "Цель:"; Goal2text.font = JostHeavyEngAndRuss;
        Goal3text.text = "Цель:"; Goal3text.font = JostHeavyEngAndRuss;
        Goal4text.text = "Цель:"; Goal4text.font = JostHeavyEngAndRuss;
        Goal1textInfo.text = "Достичь 15 подбрасываний монет"; Goal1textInfo.font = JostHeavyEngAndRuss;
        Goal2textInfo.text = "Обновить 7 подбрасывателей монет"; Goal2textInfo.font = JostHeavyEngAndRuss;
        Goal3textInfo.text = "Достичь общей суммы в 70 Квадриллионов монет"; Goal3textInfo.font = JostHeavyEngAndRuss;
        Goal4textInfo.text = "Обновить все 21 подбрасывателей монет"; Goal4textInfo.font = JostHeavyEngAndRuss; Goal4textInfo.fontSize = 24;
        Reward1Text.text = "Награда:"; Reward1Text.font = JostHeavyEngAndRuss;
        Reward2Text.text = "Награда:"; Reward2Text.font = JostHeavyEngAndRuss;
        Reward3Text.text = "Награда:"; Reward3Text.font = JostHeavyEngAndRuss;
        Reward4Text.text = "Награда:"; Reward4Text.font = JostHeavyEngAndRuss;
        Reward1TextInfo.text = "Разблокирует заблокированное специальное обновление"; Reward1TextInfo.font = JostHeavyEngAndRuss; Reward1TextInfo.fontSize = 18;
        Reward2TextInfo.text = "Первые 5 подбрасывателей монет всегда будут иметь 100% шанс успешного подбрасывания"; Reward2TextInfo.font = JostHeavyEngAndRuss; Reward2TextInfo.fontSize = 17;
        Reward3TextInfo.text = "Первый бросок монеты всегда будет успешен и даст вам на +500% больше монет"; Reward3TextInfo.font = JostHeavyEngAndRuss; Reward3TextInfo.fontSize = 18.1f;
        Reward4TextInfo.text = "Шанс выпадения счастливых монет может достигать 15%"; Reward4TextInfo.font = JostHeavyEngAndRuss; Reward4TextInfo.fontSize = 20;
        questionInfo.text = "-Не рекомендуется выполнять задание до того, как вы хотя бы один раз используете инфляцию.\n \n" + 
            "-Прочитайте первое обновление Инфляции на каждой ветке дерева, чтобы понять, какое обновление будет работать во время каждого задания. \n \n" +
            "-Вы можете выбрать 1 задание за раз.\n \n" +
            "-За каждое задание вы получите постоянную награду."; questionInfo.fontSize = 19;
        questionInfo.font = JostHeavyEngAndRuss;
        #endregion

        #region upgrades
        upgrade1.text = "Сильные Руки"; upgrade1.font = JostHeavyEngAndRuss;
        upgrade2.text = "Больше Монет"; upgrade2.font = JostHeavyEngAndRuss;
        upgrade3.text = "Знания"; upgrade3.font = JostHeavyEngAndRuss;
        upgrade4.text = "Сильный кулак"; upgrade4.font = JostHeavyEngAndRuss;
        upgrade5.text = "Инъекция Руки"; upgrade5.font = JostHeavyEngAndRuss;
        upgrade6.text = "Сила Мышления"; upgrade6.font = JostHeavyEngAndRuss;
        upgrade7.text = "Взрывные Подбрасывания"; upgrade7.font = JostHeavyEngAndRuss; upgrade7.fontSize = 28;
        upgrade8.text = "Обезвоживание"; upgrade8.font = JostHeavyEngAndRuss;
        upgrade9.text = "Странное Зелье"; upgrade9.font = JostHeavyEngAndRuss;
        upgrade10.text = "Мастер Подбрасываний"; upgrade10.font = JostHeavyEngAndRuss;
        upgrade11.text = "Рукопожатие"; upgrade11.font = JostHeavyEngAndRuss;
        upgrade12.text = "Дай Пять"; upgrade12.font = JostHeavyEngAndRuss;
        upgrade13.text = "Волшебные Подбрасывания"; upgrade13.font = JostHeavyEngAndRuss; upgrade13.fontSize = 28;
        upgrade14.text = "Сундук с Сокровищами"; upgrade14.font = JostHeavyEngAndRuss;
        upgrade15.text = "Ритуал Подбрасывания Монет"; upgrade15.font = JostHeavyEngAndRuss; upgrade15.fontSize = 25;

        upgrade1n.font = JostHeavyEngAndRuss;
        upgrade2n.font = JostHeavyEngAndRuss;
        upgrade3n.font = JostHeavyEngAndRuss;
        upgrade4n.font = JostHeavyEngAndRuss;
        upgrade5n.font = JostHeavyEngAndRuss;
        upgrade6n.font = JostHeavyEngAndRuss;
        upgrade7n.font = JostHeavyEngAndRuss; upgrade7n.fontSize = 28;
        upgrade8n.font = JostHeavyEngAndRuss;
        upgrade9n.font = JostHeavyEngAndRuss;
        upgrade10n.font = JostHeavyEngAndRuss;
        upgrade11n.font = JostHeavyEngAndRuss;
        upgrade12n.font = JostHeavyEngAndRuss;
        upgrade13n.font = JostHeavyEngAndRuss; upgrade13n.fontSize = 28;
        upgrade14n.font = JostHeavyEngAndRuss;
        upgrade15n.font = JostHeavyEngAndRuss; upgrade15n.fontSize = 25;

        strongerArmName = "Сильные Руки";
        greaterCoinName = "Больше Монет";
        knowledgeName = "Знания";
        strongerFistName = "Сильный кулак";
        handInjectionName = "Инъекция Руки";
        brainPowerName = "Сила Мышления";
        explosiveFlipsName = "Взрывные Подбрасывания";
        hydrationName = "Обезвоживание";
        strangePotionName = "Мастер Подбрасываний";
        masterFlipperName = "Мастер Подбрасываний";
        handShakeName = "Рукопожатие";
        highFiveName = "Дай Пять";
        magicFlipsName = "Волшебные Подбрасывания";
        TreasueChestName = "Сундук с Сокровищами";
        coinFlippingRitualName = "итуал Подбрасывания Монет";

        thousand = " Тысяча";
        million = " Миллион";
        billion = " Миллиард";
        trillion = " Триллион";
        quadrillion = " Квадриллион";
        quintillion = " Квинтиллион";
        sextillion = " Секстиллион";
        septillion = " Септиллион";
        octillion = " Октиллион";
        nonillion = " Октиллион";
        decillion = " Дециллион";
        undecillion = " Ундециллион";
        coins = " Монет";
        coinsOnHeads = " орлов у монет";
        coinsOnTails = " орлов у решках";

        flipMorePrice1.font = ARIEL;
        flipMorePrice2.font = ARIEL;

        price1.font = ARIEL;
        price2.font = ARIEL;
        price3.font = ARIEL;
        price4.font = ARIEL;
        price5.font = ARIEL;
        price6.font = ARIEL;
        price7.font = ARIEL;
        price8.font = ARIEL;
        price9.font = ARIEL;
        price10.font = ARIEL;
        price11.font = ARIEL;
        price12.font = ARIEL;
        price13.font = ARIEL;
        price14.font = ARIEL;
        price15.font = ARIEL;
        price16.font = ARIEL;
        price17.font = ARIEL;
        price18.font = ARIEL;
        price19.font = ARIEL;
        price20.font = ARIEL;

        price1c.font = ARIEL;
        price2c.font = ARIEL;
        price3c.font = ARIEL;
        price4c.font = ARIEL;
        price5c.font = ARIEL;
        price6c.font = ARIEL;
        price7c.font = ARIEL;
        price8c.font = ARIEL;
        price9c.font = ARIEL;
        price10c.font = ARIEL;
        price11c.font = ARIEL;
        price12c.font = ARIEL;
        price13c.font = ARIEL;
        price14c.font = ARIEL;
        price15c.font = ARIEL;
        price16c.font = ARIEL;
        price17c.font = ARIEL;
        price18c.font = ARIEL;
        price19c.font = ARIEL;
        price20c.font = ARIEL;

        flipAll.text = "Подбрасывать Все"; flipAll.font = JostHeavyEngAndRuss;
        autoFlipsQeuals.text = "Авто Подбрасывание ="; autoFlipsQeuals.font = JostHeavyEngAndRuss; autoFlipsQeuals.fontSize = 13;
        on.text = "ВКЛ"; on.font = JostHeavyEngAndRuss;
        on2.text = "ВКЛ"; on2.font = JostHeavyEngAndRuss;
        off.text = "ВЫКЛ"; off.font = JostHeavyEngAndRuss;
        off2.text = "ВЫКЛ"; off2.font = JostHeavyEngAndRuss;
        gamble.text = "Азартная Игра"; gamble.font = JostHeavyEngAndRuss;
        gamblec.text = "Азартная Игра"; gamblec.font = JostHeavyEngAndRuss;
        current.text = "Текущий:"; current.font = JostHeavyEngAndRuss; current.fontSize = 22;
        autoFlips.text = "Автоматическое Подбрасывание Монет"; autoFlips.font = JostHeavyEngAndRuss; autoFlips.fontSize = 22;
        autoFlipsc.text = "Автоматическое Подбрасывание Монет"; autoFlipsc.font = JostHeavyEngAndRuss; autoFlipsc.fontSize = 22;
        pileOfCoins.text = "Стопка Монет"; pileOfCoins.font = JostHeavyEngAndRuss;
        pileOfCoinsc.text = "Стопка Монет"; pileOfCoinsc.font = JostHeavyEngAndRuss;
        higherChance.text = "Выше Шансы на Успех"; higherChance.font = JostHeavyEngAndRuss;
        higherChancec.text = "Выше Шансы на Успех"; higherChancec.font = JostHeavyEngAndRuss;
        getLucky.text = "Везунчик"; getLucky.font = JostHeavyEngAndRuss;
        getLuckyc.text = "Везунчик"; getLuckyc.font = JostHeavyEngAndRuss;
        endlessInflation.text = "Бесконечная Инфляция"; endlessInflation.font = JostHeavyEngAndRuss;
        upgradedFlips.text = "Обновленное Подбрасывание Монет!"; upgradedFlips.font = JostHeavyEngAndRuss; upgradedFlips.fontSize = 26;
        upgradedFlipsc.text = "Обновленное Подбрасывание Монет!"; upgradedFlipsc.font = JostHeavyEngAndRuss; upgradedFlipsc.fontSize = 26;
        unlockedViaChal1.text = "Разблокировано с помощью выполнения задания #1"; unlockedViaChal1.font = JostHeavyEngAndRuss; unlockedViaChal1.fontSize = 11;
        unlcokedViaInf.text = "Разблокировано с помощью Инфляции"; unlcokedViaInf.font = JostHeavyEngAndRuss;
        chooseAutoUpgrade.text = "Выберите, какое упграде будет автоматически покупаться:"; chooseAutoUpgrade.font = JostHeavyEngAndRuss;
        diplicateFlips.font = JostHeavyEngAndRuss; diplicateFlips.fontSize = 27;
        diplicateFlipsc.font = JostHeavyEngAndRuss; diplicateFlipsc.fontSize = 27;
        autoUpgradeNameText.text = "Автообновление"; autoUpgradeNameText.font = JostHeavyEngAndRuss;

        autoUpgradeName = "Автоматическое Подбрасывание Монет";
        pileOfCoinsName = "Стопка Монет";
        higherChanceName = "Выше Шансы на Успех";
        getLuckyName = "Везунчик";
        upgradedFlipsName = "Обновленное Подбрасывание Монет!";
        spendNoMore = "Не тратьте больше";
        flipMoreCoinsName = "Подбрасывать Больше Монет!";
        maxedOut = "МАКС";
        theyAllFlip = "МАКС";
        /*
        maxedFlipMoreCoins.font = JostHeavyEngAndRuss;
        maxedAutoFlips.font = JostHeavyEngAndRuss;
        maxedPileOfCoins.font = JostHeavyEngAndRuss;
        maxedHigherChance.font = JostHeavyEngAndRuss;
        maxedLucky.font = JostHeavyEngAndRuss;
        maxedUpgradedFlips.font = JostHeavyEngAndRuss;*/

        #endregion

        #region hoverOverUpgrades
        hover1Name.text = "Сильные Руки"; hover1Name.font = JostHeavyEngAndRuss;
        hover2Name.text = "Больше Монет"; hover2Name.font = JostHeavyEngAndRuss;
        hover3Name.text = "Знания"; hover3Name.font = JostHeavyEngAndRuss;
        hover4Name.text = "Сильный кулак"; hover4Name.font = JostHeavyEngAndRuss;
        hover5Name.text = "Инъекция Руки"; hover5Name.font = JostHeavyEngAndRuss;
        hover6Name.text = "Сила Мышления"; hover6Name.font = JostHeavyEngAndRuss;
        hover7Name.text = "Взрывные Подбрасывания"; hover7Name.font = JostHeavyEngAndRuss; hover7Name.fontSize = 32;
        hover8Name.text = "Обезвоживание"; hover8Name.font = JostHeavyEngAndRuss;
        hover9Name.text = "Мастер Подбрасываний"; hover9Name.font = JostHeavyEngAndRuss;
        hover10Name.text = "Мастер Подбрасываний"; hover10Name.font = JostHeavyEngAndRuss;
        hover11Name.text = "Рукопожатие"; hover11Name.font = JostHeavyEngAndRuss;
        hover12Name.text = "Дай Пять"; hover12Name.font = JostHeavyEngAndRuss;
        hover13Name.text = "Волшебные Подбрасывания"; hover13Name.font = JostHeavyEngAndRuss; hover13Name.fontSize = 27;
        hover14Name.text = "Сундук с Сокровищами"; hover14Name.font = JostHeavyEngAndRuss;
        hover15Name.text = "итуал Подбрасывания Монет"; hover15Name.font = JostHeavyEngAndRuss; hover15Name.fontSize = 31;
        hoverFlipAll.text = "Подбрасывать Все"; hoverFlipAll.font = JostHeavyEngAndRuss;
        hoverAutoUpgrade.text = "Автообновление"; hoverAutoUpgrade.font = JostHeavyEngAndRuss; 
        hovergamble.text = "Азартная Игра"; hovergamble.font = JostHeavyEngAndRuss; hovergamble.fontSize = 24;
        hoverAutoFlip.text = "Автоматическое Подбрасывание Монет"; hoverAutoFlip.font = JostHeavyEngAndRuss; hoverAutoFlip.fontSize = 23;
        hoverPile.text = "Стопка Монет"; hoverPile.font = JostHeavyEngAndRuss;
        hoverhigherChance.text = "Выше Шансы на Успех"; hoverhigherChance.font = JostHeavyEngAndRuss;
        hoverLucky.text = "Везунчик"; hoverLucky.font = JostHeavyEngAndRuss;
        hoverEndless.text = "Бесконечная Инфляция"; hoverEndless.font = JostHeavyEngAndRuss;
        hoverUpgradedFlips.text = "Обновленное Подбрасывание Монет"; hoverUpgradedFlips.font = JostHeavyEngAndRuss; hoverUpgradedFlips.fontSize = 25;
        hoverOn.text = "Включить Авто Подбрасываний"; hoverOn.font = JostHeavyEngAndRuss; hoverOn.fontSize = 22;
        hoverOff.text = "Выключить Авто Подбрасываний"; hoverOff.font = JostHeavyEngAndRuss; hoverOff.fontSize = 22;

        purchased = "Куплено: ";

        purchased1.text = "Куплено: " + MoreCoinsButton.moreCoinsUpgrades; purchased2.text = "Куплено: " + MoreCoinsButton.greaterCoinsCount;
        purchased3.text = "Куплено: " + KnowledgeUpgrade.knowledgeUpgradeCount; purchased4.text = "Куплено: " + StrongerFist.fistUpgradeCount;
        purchased5.text = "Куплено: " + HandInecjtion.injectionUpgradeCount;
        purchased6.text = "Куплено: " + BrainPower.brainPowerUpgradeCount; purchased7.text = "Куплено: " + ExplosiveFlips.explosiveUpgradeCount;
        purchased8.text = "Куплено: " + HydrationButton.hydrationUpgradeCount; purchased9.text = "Куплено: " + StrangePotion.potionUpgradeCount;
        purchased10.text = "Куплено: " + MasterFlipper.MasterFlipsUpgradeCount;
        purchased11.text = "Куплено: " + HandShake.handShakeUpgradeCount; purchased12.text = "Куплено: " + Upgrade12.upgrade12Count;
        purchased13.text = "Куплено: " + MagicFlipsUpgrade.magicUpgradeCount; purchased14.text = "Куплено: " + TreasureChest.treasureCount;
        purchased15.text = "Куплено: " + RitualUpgrade.treasureCount; ;
        purchased16.text = "Куплено: " + GlobalCoinMaker.coinsPerFlipUpgrades; purchased17.text = "Куплено: " + PurchaseLog.higherChanceUpgradeCount;
        purchased18.text = "Куплено: " + PurchaseLog.luckyCoinHigherChanceCount; purchased19.text = "Куплено: " + GoldenFlipsButton.goldenCoinsUpgradeCount;
        purchased20.text = "Куплено: " + PurchaseLog.pileOfCoinsCount; purchased21.text = "Куплено: ";


        purchased1.font = JostHeavyEngAndRuss; purchased2.font = JostHeavyEngAndRuss; purchased3.font = JostHeavyEngAndRuss; purchased4.font = JostHeavyEngAndRuss;
        purchased5.font = JostHeavyEngAndRuss; purchased6.font = JostHeavyEngAndRuss; purchased7.font = JostHeavyEngAndRuss; purchased8.font = JostHeavyEngAndRuss;
        purchased9.font = JostHeavyEngAndRuss; purchased10.font = JostHeavyEngAndRuss; purchased11.font = JostHeavyEngAndRuss; purchased12.font = JostHeavyEngAndRuss;
        purchased13.font = JostHeavyEngAndRuss; purchased14.font = JostHeavyEngAndRuss; purchased15.font = JostHeavyEngAndRuss;
        purchased16.font = JostHeavyEngAndRuss;
        purchased17.font = JostHeavyEngAndRuss; purchased18.font = JostHeavyEngAndRuss; purchased19.font = JostHeavyEngAndRuss;
        purchased20.font = JostHeavyEngAndRuss; purchased21.font = JostHeavyEngAndRuss;

        thousandC = " Тысяча монет"; millionc = " Миллион Монет"; billionc = " Миллиард Монет"; trillionc = " Триллион Монет"; quadrillionc = " Квадриллион Монет"; quintillionc = " Квинтиллион Монет";
        sextillionc = " Секстиллион Монет"; septillionc = " Септиллион Монет"; octillionc = " Октиллион Монет"; nonillionc = " Нониллион Монет"; decillionc = " Дециллион Монет";
        undecillionc = " Ундециллион Монет.";

        description1.text = "\"Вы годами тренировали свои бицепсы, трицепсы и предплечья. И с этой неимоверной силой вы можете бросать монеты намного сильнее!\"";
        description2.text = "\"Однажды вы решили поднять монету, которая просто лежала на тротуаре. Оказалось, что каждый раз, когда вы подбрасываете эту монету, вы получаете больше монет!\"";
        description3.text = "\"Знаете, что лучше, чем сильные руки и большая монета? Знания.\"";
        description4.text = "\"В то время как все остальные в спортзале тренируют все свое тело. Ваше внимание полностью сконцентрировано на кулаке. Вы тренируете каждый палец в отдельности, что дает вашему кулаку гигантскую прокачку\"";
        description5.text = "\"Какой-то случайный парень на улице продал вам шприц с какой-то странной жидкостью внутри. Вы делаете инъекции себе в руки и по какой-то причине чувствуете себя намного лучше, чем когда-либо до этого\"";
        description6.text = "\"За все годы бросания монет ваш мозг теперь может работать более чем на 100% своей мощности\"";
        description7.text = "\"Подбрасывание монет становится довольно опасным занятием. Каждая брошенная монета создает небольшой надрыв мышц в вашем большом пальце. Несмотря на то, что это легкий надрыв, он не делает ничего, кроме легкой щекотки\"";
        description8.text = "\"Бросать монеты целый день - тяжелая работа, и иногда все, что нужно, чтобы продолжать - это немного холодной свежей воды. Так что не забывайте о восполнении жидкости в организме!\"";
        description9.text = "\"Вы очень долго хранили под кроватью странное зелье.  Сегодня настал день, когда вы его выпьете, и почувствуете прилив сил, какой вы никогда в жизни не чувствовали\"";
        description10.text = "\"Ваша многолетняя преданность подбрасыванию монет наградила вас Медалью Мастер Подбрасывания.\"";
        description11.text = "\"Вы договариваетесь с профессиональным бизнесменом, занимающимся подбрасыванием монет. Вы и этот человек собираетесь превратить подбрасывание монет в самый успешный бизнес в мире, но по какой-то причине...\"";
        description12.text = "\"Вы приветствуете кого-то, кто очень важен для вас. Это дает вам больше возможностей для подбрасывания монет, чем когда-либо прежде\"";
        description13.text = "\"Вы отправляетесь в известную школу для волшебников, чтобы научиться искусству магического подбрасывания монет. Теперь ваши монеты магически светятся каждый раз, когда вы их подбрасываете. Это вызывает у людей подозрение\"";
        description14.text = "\"Во время своих бесчисленных путешествий по миру вы обнаруживаете давно потерянные старинные сундуки с сокровищами. Вы тут же начинаете подбрасывать монеты внутри сундука\"";
        description15.text = "\"Эта история с подбрасыванием монет принимает мрачный оборот. Вы становитесь одержимы поиском новых способов подбрасывания монет. Вы начинаете совершать ритуалы с использованием черной магии в надежде довести подбрасывание монет до наивысшей формы\"";
        description16.text = "\"Иногда лучше, чтобы кто-то другой подбрасывал монеты за вас. При каждом обновлении будет происходить автоматическое подбрасывание 1 монеты\"";
        description17.text = "\"Теперь ваши подбрасывания будут иметь на 1% больше шансов на успех. Надеюсь, если повезет, это принесет вам больше монет!\"";
        description18.text = "\"Иногда ваши броски монет могут быть немного разными. И когда эти разные подбрасывания случаются, вы получаете в 5 раз больше монет. Каждое обновление даст вам +0,5%\"";
        description19.text = "\"Каждая покупка улучшает 1 подбрасыватель монет до обновленной версии. Эти подбрасыватели монет дадут вам в 2 раза больше монет, а Счастливые Монеты - в 10 раз\"";
        description20.text = "\"Вы азартный игрок? Если да, то хватит ли вам смелости попытаться удвоить все свои монеты? Здесь нет никакого мастерства, только удача. Также помните, что вам не нужно этого делать, если вы не хотите\"";
        description21.text = "-Выберите обновление, которое будет автоматически обновляться.\n\n-Автообновление будет покупать выбранное обновление каждые 5 секунд, если у вас хватит средств.\n\n-Автообновление не работает, когда игра закрыта.";
        description22.text = "-Вы можете включить или выключить авто подбрасывание.\n-Когда вы подбросите все монеты, вы должны подождать 3 секунды, прежде чем сможете подбросить их снова.\n -Вы не можете все время подбрасывать монеты, если авто подбрасывание выключено.\n-Авто подбрасывания и обновленные режимы подбрасывания монет блокируются при выключенном авто подбрасывании.";
        description23.text = "\"В левом нижнем углу появится стопка монет. Со временем эта стопка будет генерировать все больше и больше монет. После нажатия вы получите все монеты\"";
        descEndless1.text = "\"Не рекомендуется, чтобы игроки начинали покупать это обновление до разблокировки большинства Обновлений Инфляции.\"";
        descEndless2.text = "\"Это обновление работает так же, как и обновления инфляции \"БОГАТСТВО\". Бонус монет при каждой покупке равен стоимости обновления\"";
        description1.font = ARIEL; description2.font = ARIEL; description3.font = ARIEL; description4.font = ARIEL; description5.font = ARIEL;
        description6.font = ARIEL; description7.font = ARIEL; description8.font = ARIEL; description9.font = ARIEL; description10.font = ARIEL;
        description11.font = ARIEL; description12.font = ARIEL; description13.font = ARIEL; description14.font = ARIEL; description15.font = ARIEL;
        description16.font = ARIEL; description17.font = ARIEL; description18.font = ARIEL; description19.font = ARIEL; description20.font = ARIEL;
        description21.font = ARIEL; description22.font = ARIEL; description23.font = ARIEL; descEndless1.font = ARIEL; descEndless2.font = ARIEL;

        description2.fontSize = 13; description4.fontSize = 12.8f; description5.fontSize = 13; description7.fontSize = 12.5f; description8.fontSize = 12.6f; 
        description11.fontSize = 12.6f; description13.fontSize = 13; description14.fontSize = 12.6f; description15.fontSize = 11.8f; description16.fontSize = 12; description18.fontSize = 12.5f; description19.fontSize = 12.5f;
        description20.fontSize = 13.4f; description22.fontSize = 11.2f; description23.fontSize = 13; descEndless1.fontSize = 12.7f; descEndless2.fontSize = 13f;

        hoverCost1.font = JostHeavyEngAndRuss; hoverCost2.font = JostHeavyEngAndRuss; hoverCost3.font = JostHeavyEngAndRuss; hoverCost4.font = JostHeavyEngAndRuss; hoverCost5.font = JostHeavyEngAndRuss;
        hoverCost6.font = JostHeavyEngAndRuss; hoverCost7.font = JostHeavyEngAndRuss; hoverCost8.font = JostHeavyEngAndRuss; hoverCost9.font = JostHeavyEngAndRuss; hoverCost10.font = JostHeavyEngAndRuss;
        hoverCost11.font = JostHeavyEngAndRuss; hoverCost12.font = JostHeavyEngAndRuss; hoverCost13.font = JostHeavyEngAndRuss; hoverCost14.font = JostHeavyEngAndRuss; hoverCost15.font = JostHeavyEngAndRuss;
        hoverCost16.font = JostHeavyEngAndRuss; hoverCost17.font = JostHeavyEngAndRuss; hoverCost18.font = JostHeavyEngAndRuss; hoverCost19.font = JostHeavyEngAndRuss; hoverCost20.font = JostHeavyEngAndRuss;
        hoverCost21.font = JostHeavyEngAndRuss;

        p1.text = "Цена:"; p2.text = "Цена:"; p3.text = "Цена:"; p4.text = "Цена:"; p5.text = "Цена:"; p6.text = "Цена:"; p7.text = "Цена:"; p8.text = "Цена:"; p9.text = "Цена:"; p10.text = "Цена:";
        p11.text = "Цена:";
        p12.text = "Цена:"; p13.text = "Цена:"; p14.text = "Цена:"; p15.text = "Цена:"; p16.text = "Цена:"; p17.text = "Цена:"; p18.text = "Цена:"; p19.text = "Цена:"; p20.text = "Цена:";
        p21.text = "Цена:";

        p1.font = JostHeavyEngAndRuss; p2.font = JostHeavyEngAndRuss; p3.font = JostHeavyEngAndRuss; p4.font = JostHeavyEngAndRuss; p5.font = JostHeavyEngAndRuss; p6.font = JostHeavyEngAndRuss;
        p7.font = JostHeavyEngAndRuss; p8.font = JostHeavyEngAndRuss; p9.font = JostHeavyEngAndRuss; p10.font = JostHeavyEngAndRuss; p11.font = JostHeavyEngAndRuss; p12.font = JostHeavyEngAndRuss;
        p13.font = JostHeavyEngAndRuss; p14.font = JostHeavyEngAndRuss; p15.font = JostHeavyEngAndRuss; p16.font = JostHeavyEngAndRuss; p17.font = JostHeavyEngAndRuss; p18.font = JostHeavyEngAndRuss;
        p19.font = JostHeavyEngAndRuss; p20.font = JostHeavyEngAndRuss; p21.font = JostHeavyEngAndRuss;

        plussCoins = " Монеты при каждом успешном подбрасывании!";
        plussthousandCoins = " Тысяча Монеты при каждом успешном подбрасывании!";
        plussMillionCoins = " Миллион Монеты при каждом успешном подбрасывании!";
        plussBillionCoins = " Миллиард Монеты при каждом успешном подбрасывании!";
        plussTrillionCoins = " Триллион при каждом успешном подбрасывании!";
        plussQuadrillionCoins = " Квадриллион при каждом успешном подбрасывании!";
        plussQuintillionCoins = " Квинтиллион при каждом успешном подбрасывании!";
        plussSextillionCoins = " Секстиллион при каждом успешном подбрасывании!";
        plussSeptillionCoins = " Септиллион при каждом успешном подбрасывании!";

        pluss1.font = JostHeavyEngAndRuss; pluss2.font = JostHeavyEngAndRuss; pluss3.font = JostHeavyEngAndRuss; pluss4.font = JostHeavyEngAndRuss; pluss5.font = JostHeavyEngAndRuss; pluss6.font = JostHeavyEngAndRuss;
        pluss7.font = JostHeavyEngAndRuss; pluss8.font = JostHeavyEngAndRuss; pluss9.font = JostHeavyEngAndRuss; pluss10.font = JostHeavyEngAndRuss; pluss11.font = JostHeavyEngAndRuss; pluss12.font = JostHeavyEngAndRuss;
        pluss13.font = JostHeavyEngAndRuss; pluss14.font = JostHeavyEngAndRuss; pluss15.font = JostHeavyEngAndRuss;

        pluss1.fontSize = 12.5f; pluss2.fontSize = 12.5f; pluss3.fontSize = 12.5f; pluss4.fontSize = 12.5f; pluss5.fontSize = 12.5f; pluss6.fontSize = 11.5f;
        pluss7.fontSize = 11.5f; pluss8.fontSize = 11.5f; pluss9.fontSize = 11.5f;
        pluss10.fontSize = 11.5f; pluss11.fontSize = 12.5f; pluss12.fontSize = 12.5f; pluss13.fontSize = 12.5f; pluss14.fontSize = 12.5f; pluss15.fontSize = 12.5f;

        gamblePreventCheating.text = "(Игра будет сохраняться каждый раз, когда вы играете, чтобы предотвратить мошенничество)"; gamblePreventCheating.font = JostHeavyEngAndRuss;
        gambleReset.text = "Попытки будут обнуляться во время инфляции"; gambleReset.font = JostHeavyEngAndRuss;
        gambleTries.font = ARIEL; gambleChanceToWin.font = JostHeavyEngAndRuss; gambleChanceToLoose.font = JostHeavyEngAndRuss; pileGenerates.font = JostHeavyEngAndRuss;
        pileMinus1Second.text = "-1 Секунда на каждую покупку"; pileMinus1Second.font = JostHeavyEngAndRuss; chanceToHitHeads.font = JostHeavyEngAndRuss; chanceToHitTails.font = JostHeavyEngAndRuss;
        chanceToHitLuckyCoin.font = JostHeavyEngAndRuss; endlessInflationPercent.font = JostHeavyEngAndRuss; endlessInflationCoin.font = JostHeavyEngAndRuss; plussUpgradedCoinFlipper.font = JostHeavyEngAndRuss;
        plussUpgradedCoinFlipper.text = "+1 Обновленный Подбрасыватель Монет"; plussUpgradedCoinFlipper.fontSize = 13.3f;
        chanceToHitLuckyCoin.fontSize = 10f; chanceToHitHeads.fontSize = 12.5f; chanceToHitTails.fontSize = 12.5f;

        gambleChanceToWin.text = PurchaseLog.gambleChanceEachTimeWIN + "% Шанс удвоить все ваши монеты"; gambleChanceToLoose.text = PurchaseLog.gambleChanceEachTimeLOOSE + "% Шанс потерять все свои монеты";
        chanceToHitHeads.text = higherChanceHoverover.headsPercent + "% Шанс выпадения Орла"; chanceToHitTails.text = higherChanceHoverover.tailsPercent + "% Шанс выпадения Решки";
        chanceToHitLuckyCoin.text = GetLuckyHoverOver.luckyChance + "% Шанс выпадения счастливой монеты";
        endlessInflationPercent.text = EndlessInflation.endlessInflationPrice + "% Больше монет!"; endlessInflationCoin.text = EndlessInflation.endlessInflationPrice + " Инфляционные Монеты";
        pileGenerates.text = "Генерирует монеты каждые " + PileOfCoinsMechanics.waitTime + " секунд!"; pileGenerates.fontSize = 10;


        gambleWinChance = "% Шанс удвоить все ваши монеты"; gambleLoseChance = "% Шанс потерять все свои монеты"; gambleTriesString = "попытки: ";
        pileGeneratesEveyXSecond = "Генерирует монеты каждые "; seconds = " секунд!";
        higherChanceTails = "% Шанс выпадения Решки"; higherChanceHeads = "% Шанс выпадения Орла"; luckyCoinChance = "% Шанс выпадения счастливой монеты";
        endlessInflationCost = " Инфляционные Монеты"; endlessInflationPercentString = "% Больше монет!"; needs21Flippers = "обновление 21 монету!";

        gambleTriesStringText.text = "попытки: " + PurchaseLog.gambleChances; gambleTriesStringText.font = ARIEL;
        gambleResultText.font = JostHeavyEngAndRuss;
        #endregion

        #region STATS

        inflateOnceToSeeStats.text = "Используйте Инфляцию один раз, чтобы увидеть статистику"; inflateOnceToSeeStats.font = JostHeavyEngAndRuss; inflateOnceToSeeStats.fontSize = 13;

        coin = "монета";
        youHaveFlipped = "Вы подбросили "; youHaveFlippedText.font = ARIEL;
        youHaveActivelyFlipped = "Вы активно подбросили "; youHaveActivelyFlippedText.font = ARIEL;
        totalCoinsOnHeads = " монет - ОРЛЫ"; totalCoinsOnHeadsText.font = ARIEL;
        totalCoinsOnTails = " монет - РЕШКИ"; totalCoinsOnTailsText.font = ARIEL;
        totalLockyCoins = " монет оказались Счастливыми монетами"; totalLockyCoinsText.font = ARIEL;

        stats.text = "СТАТИСТИКА"; general.text = "Общая"; upgrades.text = "Обновления"; specialUpgrades.text = "Специальные Обновления"; specialUpgrades.font = ARIEL; completedChallenges.text = "Выполненные задачи ревардс"; inflation.text = "Инфляция";
        stats.font = JostHeavyEngAndRuss2; general.font = ARIEL; upgrades.font = ARIEL; completedChallenges.font = ARIEL; inflation.font = ARIEL;


        buyUpgrade = "Купите обновление, чтобы посмотреть статистику";
        your = "Ваши ";
        statsStrongerArm = " обновлений Сильные Руки дают вам ";
        statsGreater = " обновления Больше Монет дают вам ";
        statsKnowledge = " обновления Знания дают вам ";
        statsFist = " обновлений Сильный Кулак дают ";
        statsInjection = " обновлений Сила Мышления дают вам ";
        statsBrain = " обновлений Сила Мышления дают вам ";
        statsExplosive = " обновления Взрывные Подбрасывания дают вам ";
        statsHydration = " обновления Обезвоживание дает ";
        statsPorion = " обновления Странного Зелья дают ";
        statsMaster = " обновления Мастер Подбрасываний дают ";
        statsHandshake = " обновления Рукопожатие дает вам ";
        statsHighFive = " обновлений Дай Пять дают вам ";
        statsMagic = " обновления Волшебные Подбрасывания дают вам ";
        statsTreasure = " обновления Сундук с Сокровищами дает ";
        statsRitual = " обновления Ритуал Подбрасывания Монет дает вам ";

        statsStrongerArmText.text = LocalizationStrings.your + MoreCoinsButton.moreCoinsUpgrades + LocalizationStrings.statsStrongerArm + FormatCoins(PurchaseLog.strongerHandsTextInfo) + LocalizationStrings.coins; statsStrongerArmText.font = ARIEL;
        statsGreaterText.font = ARIEL; statsKnowledgeText.font = ARIEL; statsFistText.font = ARIEL; statsInjectionText.font = ARIEL; statsBrainText.font = ARIEL; statsExplosiveText.font = ARIEL;
        statsHydrationText.font = ARIEL; statsPorionText.font = ARIEL; statsMasterText.font = ARIEL; statsHandshakeText.font = ARIEL; statsHighFiveText.font = ARIEL;
        statsMagicText.font = ARIEL; statsTreasureText.font = ARIEL; statsRitualText.font = ARIEL;

        if (MoreCoinsButton.greaterCoinsCount == 0) { statsGreaterText.text = buyUpgrade; }
        if (MoreCoinsButton.greaterCoinsCount > 0)
        {
            statsGreaterText.text = LocalizationStrings.your + MoreCoinsButton.greaterCoinsCount + LocalizationStrings.statsGreater + FormatCoins(PurchaseLog.greaterTextInfo) + LocalizationStrings.coins; 
        }
        if (KnowledgeUpgrade.knowledgeUpgradeCount == 0) { statsKnowledgeText.text = buyUpgrade; }
        if (KnowledgeUpgrade.knowledgeUpgradeCount > 0)
        {
            statsKnowledgeText.text = LocalizationStrings.your + KnowledgeUpgrade.knowledgeUpgradeCount + LocalizationStrings.statsKnowledge + FormatCoins(PurchaseLog.knowledgeInfo) + LocalizationStrings.coins; 
        }
        if (StrongerFist.fistUpgradeCount == 0) { statsFistText.text = buyUpgrade; }
        if (StrongerFist.fistUpgradeCount > 0)
        {
            statsFistText.text = LocalizationStrings.your + StrongerFist.fistUpgradeCount + LocalizationStrings.statsFist + FormatCoins(PurchaseLog.fistInfo) + LocalizationStrings.coins; 
        }
        if (HandInecjtion.injectionUpgradeCount == 0) { statsInjectionText.text = buyUpgrade; }
        if (HandInecjtion.injectionUpgradeCount > 0)
        {
            statsInjectionText.text = LocalizationStrings.your + HandInecjtion.injectionUpgradeCount + LocalizationStrings.statsInjection + FormatCoins(PurchaseLog.injectionInfo) + LocalizationStrings.coins; 
        }
        if (BrainPower.brainPowerUpgradeCount == 0) { statsBrainText.text = buyUpgrade; }
        if (BrainPower.brainPowerUpgradeCount > 0)
        {
            statsBrainText.text = LocalizationStrings.your + BrainPower.brainPowerUpgradeCount + LocalizationStrings.statsBrain + FormatCoins(PurchaseLog.brainPowerInfo) + LocalizationStrings.coins; 
        }
        if (ExplosiveFlips.explosiveUpgradeCount == 0) { statsExplosiveText.text = buyUpgrade; }
        if (ExplosiveFlips.explosiveUpgradeCount > 0)
        {
            statsExplosiveText.text = LocalizationStrings.your + ExplosiveFlips.explosiveUpgradeCount + LocalizationStrings.statsExplosive + FormatCoins(PurchaseLog.explosiveInfo) + LocalizationStrings.coins; 
        }
        if (HydrationButton.hydrationUpgradeCount == 0) { statsHydrationText.text = buyUpgrade; }
        if (HydrationButton.hydrationUpgradeCount > 0)
        {
            statsHydrationText.text = LocalizationStrings.your + HydrationButton.hydrationUpgradeCount + LocalizationStrings.statsHydration + FormatCoins(PurchaseLog.hydrationInfo) + LocalizationStrings.coins; 
        }
        if (StrangePotion.potionUpgradeCount == 0) { statsPorionText.text = buyUpgrade; }
        if (StrangePotion.potionUpgradeCount > 0)
        {
            statsPorionText.text = LocalizationStrings.your + StrangePotion.potionUpgradeCount + LocalizationStrings.statsPorion + FormatCoins(PurchaseLog.potionInfo) + LocalizationStrings.coins; 
        }
        if (MasterFlipper.MasterFlipsUpgradeCount == 0) { statsMasterText.text = buyUpgrade; }
        if (MasterFlipper.MasterFlipsUpgradeCount > 0)
        {
            statsMasterText.text = LocalizationStrings.your + MasterFlipper.MasterFlipsUpgradeCount + LocalizationStrings.statsMaster + FormatCoins(PurchaseLog.masterFlipperInfo) + LocalizationStrings.coins; 
        }
        if (HandShake.handShakeUpgradeCount == 0) { statsHandshakeText.text = buyUpgrade; }
        if (HandShake.handShakeUpgradeCount > 0)
        {
            statsHandshakeText.text = LocalizationStrings.your + HandShake.handShakeUpgradeCount + LocalizationStrings.statsHandshake + FormatCoins(PurchaseLog.handShakeInfo) + LocalizationStrings.coins; 
        }
        if (Upgrade12.upgrade12Count == 0) { statsHighFiveText.text = buyUpgrade; }
        if (Upgrade12.upgrade12Count > 0)
        {
            statsHighFiveText.text = LocalizationStrings.your + Upgrade12.upgrade12Count + LocalizationStrings.statsHighFive + FormatCoins(PurchaseLog.upgrade12Info) + LocalizationStrings.coins; 
        }
        if (MagicFlipsUpgrade.magicUpgradeCount == 0) { statsMagicText.text = buyUpgrade; }
        if (MagicFlipsUpgrade.magicUpgradeCount >= 1)
        {
            statsMagicText.text = LocalizationStrings.your + MagicFlipsUpgrade.magicUpgradeCount + LocalizationStrings.statsMagic + FormatCoins(PurchaseLog.magicFlipsInfo) + LocalizationStrings.coins; 
        }
        if (TreasureChest.treasureCount == 0) { statsTreasureText.text = buyUpgrade; }
        if (TreasureChest.treasureCount >= 1)
        {
            statsTreasureText.text = LocalizationStrings.your + TreasureChest.treasureCount + LocalizationStrings.statsTreasure + FormatCoins(PurchaseLog.treasureInfo) + LocalizationStrings.coins; 
        }
        if (RitualUpgrade.treasureCount == 0) { statsRitualText.text = buyUpgrade; }
        if (RitualUpgrade.treasureCount >= 1)
        {
            statsRitualText.text = LocalizationStrings.your + RitualUpgrade.treasureCount + LocalizationStrings.statsRitual + FormatCoins(PurchaseLog.ritualInfo) + LocalizationStrings.coins; 
        }

        statsStrongerArmText.fontSize = 12.3f; statsGreaterText.fontSize = 12.3f; statsKnowledgeText.fontSize = 12.3f; statsFistText.fontSize = 12.3f; statsInjectionText.fontSize = 12.3f;
        statsBrainText.fontSize = 12.3f; statsExplosiveText.fontSize = 12.3f; statsHydrationText.fontSize = 12.3f; statsPorionText.fontSize = 12.3f; statsMasterText.fontSize = 12.3f;
        statsHandshakeText.fontSize = 12.3f; statsHighFiveText.fontSize = 12.3f; statsMagicText.fontSize = 12.3f; statsTreasureText.fontSize = 12.3f; statsRitualText.fontSize = 12.3f;

        //SpecialUpgradesText
        times = " раза"; youHitExtraLucky = "У вас выпала Счастливая Монета "; youGambled = "Вы сыграли в Азартные Игры "; lostGambling = "Вы потеряли все свои монеты в Азартной Игре ";
        wonGambling = "Вы удвоили все свои монеты в Азартной Игре "; clickedPile = "Вы нажали на СТОПКУ МОНЕТ "; pileTotalGenerated = "В общей сложности СТОПКА МОНЕТ принесла ";
        completeChal1 = "Выполните задание 1, чтобы получить награду"; completeChal2 = "Выполните задание 2, чтобы получить награду";
        completeChal3 = "Выполните задание 4, чтобы получить награду"; completeChal4 = "Выполните задание 4, чтобы получить награду";
        chal1Completed = "Награда за выполнение задания 1: Разблокирована кнопка ПОДБРАСЫВАТЬ ВСЕ";
        chal2completed = "Награда за задание 2: Первые 5 подбрасываний монет всегда будут успешны";
        chal3completed = "Награда за задание 3: Первое подбрасывание монет даст на 500% больше монет"; chal4completed = "Награда за задание 4: Максимум 15% шансов на счастливую монету"; ;
        statsHeadsChanceText.text = higherChanceHoverover.headsPercent + LocalizationStrings.higherChanceHeads; statsHeadsChanceText.font = ARIEL;
        statsTailsChanceText.text = higherChanceHoverover.tailsPercent + LocalizationStrings.higherChanceTails; statsTailsChanceText.font = ARIEL;
        statsLuckyChanceText.text = GetLuckyHoverOver.luckyChance + LocalizationStrings.luckyCoinChance; statsLuckyChanceText.font = ARIEL;
        youHitExtraLuckyText.font = ARIEL;
        clickedPileText.text = LocalizationStrings.clickedPile + PileOfCoinsMechanics.incrementPileOfCoinsAmount + LocalizationStrings.times;
        youGambledText.text = LocalizationStrings.youGambled + (0 + PurchaseLog.amountOfTimesGambled) + LocalizationStrings.times; youGambledText.font = ARIEL; 
        lostGamblingText.font = ARIEL; lostGamblingText.text = LocalizationStrings.lostGambling + (0 + PurchaseLog.amountOfTimesGambledLOST) + LocalizationStrings.times;
        wonGamblingText.font = ARIEL; wonGamblingText.text = LocalizationStrings.wonGambling + (0 + PurchaseLog.amountOfTimesGambledWON) + LocalizationStrings.times;
        clickedPileText.font = ARIEL;
        pileTotalGeneratedText.font = ARIEL; ;

        completeChal1Text.font = ARIEL; completeChal2Text.font = ARIEL; completeChal3Text.font = ARIEL; completeChal4Text.font = ARIEL;
        completeChal1Text.fontSize = 11.9f; completeChal2Text.fontSize = 11.9f; completeChal3Text.fontSize = 11.9f; completeChal4Text.fontSize = 11.9f;

        if (Challenges.completedChallenge1 == 0) { completeChal1Text.text = completeChal1; }
        if (Challenges.completedChallenge1 == 1) { completeChal1Text.text = chal1Completed; }
        if (Challenges.completedChallenge2 == 0) { completeChal2Text.text = completeChal2; }
        if (Challenges.completedChallenge2 == 1) { completeChal2Text.text = chal2completed; }
        if (Challenges.completedChallenge3 == 0) { completeChal3Text.text = completeChal3; }
        if (Challenges.completedChallenge3 == 1) { completeChal3Text.text = chal3completed; }
        if (Challenges.completedChallenge4 == 0) { completeChal4Text.text = completeChal4; }
        if (Challenges.completedChallenge4 == 1) { completeChal4Text.text = chal4completed; }

        moreCoins = "% больше монет"; cheaper = "% дешевле"; less = "% меньше"; coinsAfterInflating = " монет"; moreCoinsAfterInflating = " дополнительных монет после инфляции";

        inflateUpgradesStats = "Обновление дает на "; inflateEndlessStats = "Бесконечная Инфляция дает на "; inflateCheaperStats = "Обновление на "; inflateSpecialCheaperStats = "Специальные обновления стоят на ";
        inflateActiveStats = "Активное подбрасывание монет дает вам на "; inflateStartWithCoinsStats = "После инфляции вы начинаете со "; inflatePileOfBagsStats = "ГРУДА МЕШКОВ дает вам ";

        inflateEndlessStatsTEXT.text = LocalizationStrings.inflateEndlessStats + EndlessInflation.englessInflationBonusText + LocalizationStrings.moreCoins;
        inflateSpecialCheaperStatsTEXT.text = LocalizationStrings.inflateSpecialCheaperStats + (AscendScreen.totalSpecialReduction) + LocalizationStrings.less;
        inflateStartWithCoinsStatsTEXT.text = LocalizationStrings.inflateStartWithCoinsStats + AscendScreen.starWithCoinsAmount + LocalizationStrings.coinsAfterInflating;
        inflateUpgradesStatsTEXT.text = LocalizationStrings.inflateUpgradesStats + AscendScreen.moreCoinsUpgradePercent + LocalizationStrings.moreCoins;
        inflateCheaperStatsTEXT.text = LocalizationStrings.inflateCheaperStats + AscendScreen.totalSpecialReduction + LocalizationStrings.cheaper;
        inflateActiveStatsTEXT.text = LocalizationStrings.inflateActiveStats + AscendScreen.activeFlipperPercent + LocalizationStrings.moreCoins;
        inflatePileOfBagsStatsTEXT.text = LocalizationStrings.inflatePileOfBagsStats + PileOfCoinsMechanics.PileBagAmount + LocalizationStrings.moreCoinsAfterInflating;

        inflateEndlessStatsTEXT.font = ARIEL; inflateSpecialCheaperStatsTEXT.font = ARIEL; inflateStartWithCoinsStatsTEXT.font = ARIEL; inflateUpgradesStatsTEXT.font = ARIEL;
        inflateCheaperStatsTEXT.font = ARIEL; inflateActiveStatsTEXT.font = ARIEL; inflatePileOfBagsStatsTEXT.font = ARIEL;

        inflateEndlessStatsTEXT.fontSize = 14.4f; inflateSpecialCheaperStatsTEXT.fontSize = 14.4f; inflateStartWithCoinsStatsTEXT.fontSize = 14.4f; inflateUpgradesStatsTEXT.fontSize = 14.4f;
        inflateCheaperStatsTEXT.fontSize = 14.4f; inflateActiveStatsTEXT.fontSize = 14.4f; inflatePileOfBagsStatsTEXT.fontSize = 14.4f;

        if (AscendScreen.boughtRich1 == 0) { inflateUpgradesStatsTEXT.text = LocalizationStrings.inflateUpgradesStats + "0" + LocalizationStrings.moreCoins; }
        if (AscendScreen.boughtSale1 == 0) { inflateCheaperStatsTEXT.text = LocalizationStrings.inflateCheaperStats + "0" + cheaper; }
        if (AscendScreen.boughtBagOfCoins1 == 0) { inflateStartWithCoinsStatsTEXT.text = LocalizationStrings.inflateStartWithCoinsStats + "0" + LocalizationStrings.coinsAfterInflating; }
        if (AscendScreen.boughtActiveFlipper1 == 0) { inflateActiveStatsTEXT.text = LocalizationStrings.inflateActiveStats + "0" + LocalizationStrings.moreCoins; }

        #endregion

        #region achievements

        achievements.text = "Достижения"; achievements.font = JostHeavyEngAndRuss2;
        ach1.text = "Получить 1 монету"; ach1.font = JostHeavyEngAndRuss2;
        ach2.text = "Получить 10 монет"; ach2.font = JostHeavyEngAndRuss2;
        ach3.text = "Получить 100 монет"; ach3.font = JostHeavyEngAndRuss2;
        ach4.text = "Получить 1000 монет"; ach4.font = JostHeavyEngAndRuss2;
        ach5.text = "Получить 10000 монет"; ach5.font = JostHeavyEngAndRuss2;
        ach6.text = "Получить 100000 монет"; ach6.font = JostHeavyEngAndRuss2;
        ach7.text = "Получить 1 Миллион монет!"; ach7.font = JostHeavyEngAndRuss2;
        ach8.text = "Получить 1 Миллиард монет!"; ach8.font = JostHeavyEngAndRuss2;
        ach9.text = "Получить 1 Триллион монет!"; ach9.font = JostHeavyEngAndRuss2;
        ach10.text = "Получить 1 Квадриллион монет!"; ach10.font = JostHeavyEngAndRuss2;
        ach11.text = "Получить 1 Квинтиллион монет!"; ach11.font = JostHeavyEngAndRuss2;
        ach12.text = "Получить 1 Секстиллион монет!"; ach12.font = JostHeavyEngAndRuss2;
        ach13.text = "Получить 1 Септиллион монет!"; ach13.font = JostHeavyEngAndRuss2;
        ach14.text = "Получить 1 Октиллион монет!"; ach14.font = JostHeavyEngAndRuss2;
        ach15.text = "Обновить Сильные Руки Один Раз"; ach15.font = JostHeavyEngAndRuss2;
        ach16.text = "Обновить Сильные Руки 10 Раз"; ach16.font = JostHeavyEngAndRuss2;
        ach17.text = "Обновить Большую монету один раз"; ach17.font = JostHeavyEngAndRuss2;
        ach18.text = "Обновить Больше Монет 10 раз"; ach18.font = JostHeavyEngAndRuss2;
        ach19.text = "Обновить Знания Один Раз"; ach19.font = JostHeavyEngAndRuss2;
        ach20.text = "Обновить Знания 10 Раз"; ach20.font = JostHeavyEngAndRuss2;
        ach21.text = "Обновить Сильный Кулак один раз"; ach21.font = JostHeavyEngAndRuss2;
        ach22.text = "Обновить Сильный Кулак 10 Раз"; ach22.font = JostHeavyEngAndRuss2;
        ach23.text = "Обновить Инъекция Руки Один Раз"; ach23.font = JostHeavyEngAndRuss2;
        ach24.text = "Обновить Инъекция Руки 10 Раз"; ach24.font = JostHeavyEngAndRuss2;
        ach25.text = "Обновить Сила Мышления Один Раз"; ach25.font = JostHeavyEngAndRuss2;
        ach26.text = "Обновить Сила Мышления 10 Раз"; ach26.font = JostHeavyEngAndRuss2;
        ach27.text = "Обновить Взрывные Подбрасывания Один Раз"; ach27.font = JostHeavyEngAndRuss2;
        ach28.text = "Обновить Взрывные Подбрасывания 10 Раз"; ach28.font = JostHeavyEngAndRuss2;
        ach29.text = "Обновить Обезвоживание Один Раз"; ach29.font = JostHeavyEngAndRuss2;
        ach30.text = "Обновить Обезвоживание 10 Раз"; ach30.font = JostHeavyEngAndRuss2;
        ach31.text = "Обновить Странное Зелье Один Раз"; ach31.font = JostHeavyEngAndRuss2;
        ach32.text = "Обновить Странное Зелье 10 Раз"; ach32.font = JostHeavyEngAndRuss2;
        ach33.text = "Обновить Мастер ласт один раз"; ach33.font = JostHeavyEngAndRuss2;
        ach34.text = "Обновить Мастер Подбрасывания 10 Раз"; ach34.font = JostHeavyEngAndRuss2;
        ach35.text = "Обновить Рукопожатие Один Раз"; ach35.font = JostHeavyEngAndRuss2;
        ach36.text = "Обновить Рукопожатие 10 раз"; ach36.font = JostHeavyEngAndRuss2;
        ach37.text = "Обновить Волшебные Подбрасывания Один Раз"; ach37.font = JostHeavyEngAndRuss2; ach37.fontSize = 7f;
        ach38.text = "Обновить Волшебные Подбрасывания 10 раз"; ach38.font = JostHeavyEngAndRuss2; ach38.fontSize = 7f;
        ach39.text = "Имеют 2,5% Шанс выпадения счастливой монеты"; ach39.font = JostHeavyEngAndRuss2;
        ach40.text = "Имеют 5% Шанс выпадения счастливой монеты"; ach40.font = JostHeavyEngAndRuss2;
        ach41.text = "Выпадение 1 счастливой монеты"; ach41.font = JostHeavyEngAndRuss2;
        ach42.text = "Выпадение 10 счастливых монет"; ach42.font = JostHeavyEngAndRuss2;
        ach43.text = "Выпадение 100 счастливых монет"; ach43.font = JostHeavyEngAndRuss2;
        ach44.text = "Подбросьте 100 Монет"; ach44.font = JostHeavyEngAndRuss2;
        ach45.text = "Подбросьте 1000 Монет"; ach45.font = JostHeavyEngAndRuss2;
        ach46.text = "Подбросьте 10000 Монет"; ach46.font = JostHeavyEngAndRuss2;
        ach47.text = "Подбросьте 100000 Монет"; ach47.font = JostHeavyEngAndRuss2;
        ach49.text = "Подбросьте 2 Монеты одновременно"; ach49.font = JostHeavyEngAndRuss2;
        ach50.text = "Подбросьте 5 Монеты одновременно"; ach50.font = JostHeavyEngAndRuss2;
        ach51.text = "Подбросьте 10 Монеты одновременно"; ach51.font = JostHeavyEngAndRuss2;
        ach94.text = "Подбросьте 21 Монеты одновременно"; ach94.font = JostHeavyEngAndRuss2;
        ach52.text = "Обновить 1 Подбрасыватель Монет"; ach52.font = JostHeavyEngAndRuss2;
        ach53.text = "Обновить 5 Подбрасыватель Монет"; ach53.font = JostHeavyEngAndRuss2;
        ach54.text = "Обновить 10 Подбрасыватель Монет"; ach54.font = JostHeavyEngAndRuss2;
        ach55.text = "Обновить 21 Подбрасыватель Монет"; ach55.font = JostHeavyEngAndRuss2;
        ach56.text = "75% шансов на успешное подбрасывание"; ach56.font = JostHeavyEngAndRuss2;
        ach57.text = "93.75% шансов на успешное подбрасывание"; ach57.font = JostHeavyEngAndRuss2;
        ach58.text = "Подбросьте все монеты!"; ach58.font = JostHeavyEngAndRuss2;
        ach59.text = "Подбросить 1 Миллион Монет!"; ach59.font = JostHeavyEngAndRuss2;
        ach60.text = "Выпадение счастливой монеты 1000 раз!"; ach60.font = JostHeavyEngAndRuss2;
        ach61.text = "Выпадение решках 100000 раз!"; ach61.font = JostHeavyEngAndRuss2;
        ach62.text = "Выпадение орла 100000 раз!"; ach62.font = JostHeavyEngAndRuss2;
        ach63.text = "Выполните задание 1"; ach63.font = JostHeavyEngAndRuss2;
        ach64.text = "Выполните задание 2"; ach64.font = JostHeavyEngAndRuss2;
        ach65.text = "Выполните задание 3"; ach65.font = JostHeavyEngAndRuss2;
        ach66.text = "Выполните задание 4"; ach66.font = JostHeavyEngAndRuss2;
        ach67.text = "Разблокируйте автообновление"; ach67.font = JostHeavyEngAndRuss2;
        ach68.text = "Активно подбросьте монету 100 раз"; ach68.font = JostHeavyEngAndRuss2;
        ach69.text = "Активно подбросьте монету 1000 раз"; ach69.font = JostHeavyEngAndRuss2;
        ach70.text = "Активно подбросьте монету 5000 раз"; ach70.font = JostHeavyEngAndRuss2;
        ach71.text = "Купить Сундук с Сокровищами Один Раз"; ach71.font = JostHeavyEngAndRuss2;
        ach72.text = "Купить Сундук с Сокровищами 10 Раз"; ach72.font = JostHeavyEngAndRuss2;
        ach73.text = "Купить Ритуал Подбрасывания Монет Один Раз"; ach73.font = JostHeavyEngAndRuss2;
        ach74.text = "Купить Ритуал Подбрасывания Монет 10 раз"; ach74.font = JostHeavyEngAndRuss2;
        ach75.text = "Обновить Дай Пять Один Раз"; ach75.font = JostHeavyEngAndRuss2;
        ach76.text = "Обновить Дай Пять 10 Раз"; ach76.font = JostHeavyEngAndRuss2;
        ach77.text = "Имеете в общей сложности 25 Инфляционных Монет"; ach77.font = JostHeavyEngAndRuss2;
        ach78.text = "Имеете в общей сложности 50 Инфляционных Монет"; ach78.font = JostHeavyEngAndRuss2;
        ach79.text = "Имеете в общей сложности 75 Инфляционных Монет"; ach79.font = JostHeavyEngAndRuss2;
        ach80.text = "Разблокировать 5 обновлений Инфляции"; ach80.font = JostHeavyEngAndRuss2;
        ach81.text = "Разблокировать 10 обновлений Инфляции"; ach81.font = JostHeavyEngAndRuss2;
        ach82.text = "Разблокировать 20 обновлений Инфляции"; ach82.font = JostHeavyEngAndRuss2;
        ach83.text = "Разблокировать 30 обновлений Инфляции"; ach83.font = JostHeavyEngAndRuss2;
        ach84.text = "Разблокируйте все обновления Инфляции"; ach84.font = JostHeavyEngAndRuss2;
        ach85.text = "Нажмите на стопку монет 10 раз"; ach85.font = JostHeavyEngAndRuss2;
        ach86.text = "Нажмите на стопку монет 100 раз"; ach86.font = JostHeavyEngAndRuss2;
        ach87.text = "ИНФЛЯЦИЯ!"; ach87.font = JostHeavyEngAndRuss2;
        ach88.text = "ИНФЛЯЦИЯ 5 РАЗ!"; ach88.font = JostHeavyEngAndRuss2;
        ach89.text = "Сыграйте в Азартные Игры 10 раз"; ach89.font = JostHeavyEngAndRuss2;
        ach90.text = "Вы проиграли все свои монеты 5 раз"; ach90.font = JostHeavyEngAndRuss2;
        ach91.text = "Вы удвоили все свои монеты 5 раз"; ach91.font = JostHeavyEngAndRuss2;
        ach92.text = "Найдите спрятанную бронзовую монету"; ach92.font = JostHeavyEngAndRuss2;
        ach93.text = "Найдите спрятанную серебряную монету"; ach93.font = JostHeavyEngAndRuss2;


        #endregion

        #region InflationTree

        inflate.text = "Инфляция"; inflate.font = JostHeavyEngAndRuss; inflate.fontSize = 15;
        youHave21Flippers.text = " У вас есть 21 монета!"; youHave21Flippers.font = JostHeavyEngAndRuss;
        youNeed21Flippers.text = "Чтобы произвести инфляцию, вам нужно бросить 21 монету!"; youNeed21Flippers.font = JostHeavyEngAndRuss; youNeed21Flippers.fontSize = 12f;
        youCanViewTreeAtAnyTime.text = "(Вы можете посмотреть на дерево инфляции в любое время)"; youCanViewTreeAtAnyTime.font = JostHeavyEngAndRuss;
        youCanViewTreeAtAnyTime.fontSize = 10;
        smallInflationDescription.text = "Инфляция сбросит все ваши статистические данные (за некоторыми исключениями) и вы попадете на экран с уникальными постоянными обновлениями. Как только вы закончите обновления, игра начнется с самого начала"; smallInflationDescription.font = ARIEL;
        smallInflationDescription.fontSize = 13.5f;
        thisIsHowInflationWorks.text = "Вот как работает система инфляции:"; thisIsHowInflationWorks.font = JostHeavyEngAndRuss;
        bigInflationDescription.text = "-Вы получаете Инфляционные монеты каждый раз, когда добираетесь на четверть пути до следующего уровня монет.\n-Тип монет - это: миллион, миллиард, триллион, квадриллион и так далее.\n-Пример: Вы начнете получать инфляционные монеты, как только достигнете 1 Миллиона. Затем вы будете получать Инфляционные монеты, когда достигнете: 1 Миллион, 250 Миллионов, 500 Миллионов, 750 Миллионов, 1 Миллиард, 250 Миллиардов, 500 Миллиардов, 750 Миллиардов и так далее.\n-Базовое количество инфляционных монет, которое вы получаете каждый раз, когда набираете инфляционные монеты, равно 1. Покупайте обновления “БОЛЬШЕ ИНФЛЯЦИИ”, чтобы получать больше инфляционных монет во время игры."; bigInflationDescription.font = JostHeavyEngAndRuss;
        bigInflationDescription.fontSize = 6.9f;
        youHave.text = "У вас есть"; youHave.font = JostHeavyEngAndRuss;
        inflationCoins.text = "Инфляционные Монеты"; inflationCoins.font = JostHeavyEngAndRuss; 
        dontInflateJustLook.text = "Не взвинчивайте ставки, а только смотрите на Дерево"; dontInflateJustLook.font = JostHeavyEngAndRuss;
        dontInflateJustLook.fontSize = 19;
        doYouWishToInflate.text = "Хотите использовать инфляцию?"; doYouWishToInflate.font = JostHeavyEngAndRuss; doYouWishToInflate.fontSize = 16;
        YES.text = "ДА"; YES.font = ARIEL;
        NO.text = "НЕТ"; NO.font = ARIEL;
        currentlyOnlyViewingTree.text = "! В настоящее время вы просматриваете только Дерево Инфляции и не можете приобрести какие-либо обновления.";
        currentlyOnlyViewingTree.font = ARIEL;
        backToFlipping.text = "Назад к подбрасыванию!"; backToFlipping.font = ARIEL; backToFlipping.fontSize = 18;
        backToFlipping2.text = "Назад к подбрасыванию!"; backToFlipping2.font = JostHeavyEngAndRuss; backToFlipping2.fontSize = 14;
        inflationCoinsText = "Инфляционные Монеты: " ;
        InflationCoins.text = inflationCoinsText + AscendCoins.ascensionCoinAmount; InflationCoins.font = JostHeavyEngAndRuss; InflationCoins.fontSize = 17.5f;

        rich1.text = "БОГАТСТВО 1"; rich1.font = JostHeavyEngAndRuss;
        rich2.text = "БОГАТСТВО 2"; rich2.font = JostHeavyEngAndRuss;
        rich3.text = "БОГАТСТВО 3"; rich3.font = JostHeavyEngAndRuss;
        rich4.text = "БОГАТСТВО 4"; rich4.font = JostHeavyEngAndRuss;
        rich5.text = "БОГАТСТВО 5"; rich5.font = JostHeavyEngAndRuss;
        rich6.text = "БОГАТСТВО 6"; rich6.font = JostHeavyEngAndRuss;
        rich7.text = "БОГАТСТВО 7"; rich7.font = JostHeavyEngAndRuss;
        omegaRich.text = "БОГАТСТВО ОМЕГА"; omegaRich.font = JostHeavyEngAndRuss;

        rich1Desc.text = "Все обновления дают вам на 1% больше монет.\nОбновления БОГАТСТВО работают для каждого задания."; rich1Desc.font = JostHeavyEngAndRuss;
        rich1Desc.fontSize = 14;
        rich2Desc.text = "Все обновления дают вам на 20% больше монет"; rich2Desc.font = JostHeavyEngAndRuss;
        rich3Desc.text = "Все обновления дают вам на 50% больше монет"; rich3Desc.font = JostHeavyEngAndRuss;
        rich4Desc.text = "Все обновления дают вам на 100% больше монет"; rich4Desc.font = JostHeavyEngAndRuss;
        rich5Desc.text = "Все обновления дают вам на 175% больше монет"; rich5Desc.font = JostHeavyEngAndRuss;
        rich6Desc.text = "Все обновления дают вам на 300% больше монет"; rich6Desc.font = JostHeavyEngAndRuss;
        rich7Desc.text = "Все обновления дают вам на 750% больше монет"; rich7Desc.font = JostHeavyEngAndRuss;
        omegaRichDes.text = "Все обновления дают вам на 1250% больше монет"; omegaRichDes.font = JostHeavyEngAndRuss;

        sale1.text = "ПРОДАЖА 1"; sale1.font = JostHeavyEngAndRuss;
        sale2.text = "ПРОДАЖА 2"; sale2.font = JostHeavyEngAndRuss;
        sale3.text = "ПРОДАЖА 3"; sale3.font = JostHeavyEngAndRuss;
        sale4.text = "ПРОДАЖА 4"; sale4.font = JostHeavyEngAndRuss;
        steamSale.text = "РАСПРОДАЖА STEAM"; steamSale.font = JostHeavyEngAndRuss;
        sale1Desc.text = "Все обновления стоят на 2% меньше. Эта ветка обновлений не влияет на специальные обновления\nПРОДАЖА Обновления работают для всех ВЫЗОВОВ"; sale1Desc.font = JostHeavyEngAndRuss;
        sale2Desc.text = "Все обновления стоят на 7% меньше"; sale2Desc.font = JostHeavyEngAndRuss; sale1Desc.fontSize = 11;
        sale3Desc.text = "Все обновления стоят на 14% меньше"; sale3Desc.font = JostHeavyEngAndRuss;
        sale4Desc.text = "Все обновления стоят на 22% меньше"; sale4Desc.font = JostHeavyEngAndRuss;
        steamSaleDesc.text = "Все обновления стоят на 50% меньше"; steamSaleDesc.font = JostHeavyEngAndRuss; steamSale.fontSize = 19;

        bag1.text = "МЕШОК МОНЕТ 1"; bag1.font = JostHeavyEngAndRuss;
        bag2.text = "МЕШОК МОНЕТ 2"; bag2.font = JostHeavyEngAndRuss;
        bag3.text = "МЕШОК МОНЕТ 3"; bag3.font = JostHeavyEngAndRuss;
        bag4.text = "МЕШОК МОНЕТ 4"; bag4.font = JostHeavyEngAndRuss;
        hugeBag.text = "МЕШОК МОНЕТ 5"; hugeBag.font = JostHeavyEngAndRuss;
        pileOfBags.text = "ГРУДА МЕШКОВ"; pileOfBags.font = JostHeavyEngAndRuss;

        bag1Desc.text = " Вы начинаете игру с 75 монетами после инфляции\nОбновление СУМКА МОНЕТ будет работать только в задании \"Без авто подбрасываний\""; bag1Desc.font = JostHeavyEngAndRuss;
        bag2Desc.text = "Вы начинаете игру с 500 монетами после инфляции"; bag2Desc.font = JostHeavyEngAndRuss;
        bag3Desc.text = "Вы начинаете игру с 3000 монетами после инфляции"; bag3Desc.font = JostHeavyEngAndRuss;
        bag4Desc.text = "Вы начинаете игру с 20000 монетами после инфляции."; bag4Desc.font = JostHeavyEngAndRuss;
        hugeBasDesc.text = "Вы начинаете игру с 100000 монетами после инфляции."; hugeBasDesc.font = JostHeavyEngAndRuss;
        pileOfBagsDesc.text = "Каждый раз, когда вы нажимаете на стопку монет, к количеству монет, с которыми вы начинаете игру после инфляции, добавляется +250 монет"; pileOfBagsDesc.font = JostHeavyEngAndRuss;

        greaterInflation1.text = "БОЛЬШЕ ИНФЛЯЦИИ 1"; greaterInflation1.font = JostHeavyEngAndRuss;
        greaterInflation2.text = "БОЛЬШЕ ИНФЛЯЦИИ 2"; greaterInflation2.font = JostHeavyEngAndRuss;
        greaterInflation3.text = "БОЛЬШЕ ИНФЛЯЦИИ 3"; greaterInflation3.font = JostHeavyEngAndRuss;
        greaterInflation4.text = "БОЛЬШЕ ИНФЛЯЦИИ 4"; greaterInflation4.font = JostHeavyEngAndRuss;
        greaterInflation5.text = "БОЛЬШЕ ИНФЛЯЦИИ 5"; greaterInflation5.font = JostHeavyEngAndRuss;
        crazyInflation.text = "СУМАСШЕДШАЯ ИНФЛЯЦИЯ!!!"; crazyInflation.font = JostHeavyEngAndRuss; crazyInflation.fontSize = 14;
        inflationGamble1.text = "ИНФЛЯЦИОННАЯ АЗАРТНАЯ ИГРА 1"; inflationGamble1.font = JostHeavyEngAndRuss; inflationGamble1.fontSize = 12;
        inflationGamble2.text = "ИНФЛЯЦИОННАЯ АЗАРТНАЯ ИГРА 2"; inflationGamble2.font = JostHeavyEngAndRuss; inflationGamble2.fontSize = 12;
        inflationGamble3.text = "ИНФЛЯЦИОННАЯ АЗАРТНАЯ ИГРА 3"; inflationGamble3.font = JostHeavyEngAndRuss; inflationGamble3.fontSize = 12;
        inflationGamble4.text = "ИНФЛЯЦИОННАЯ АЗАРТНАЯ ИГРА 4"; inflationGamble4.font = JostHeavyEngAndRuss; inflationGamble4.fontSize = 12;

        greaterInflation1Desc.text = "+2 инфляционные монеты, когда вы достигнете Уровня Квадриллиона+\nВсе обновления ИНФЛЯЦИИ работают для всех заданий, кроме задания \"Постоянная Удача\""; greaterInflation1Desc.font = JostHeavyEngAndRuss;
        greaterInflation2Desc.text = "+3 инфляционных монеты при достижении Уровня Квадриллиона+"; greaterInflation2Desc.font = JostHeavyEngAndRuss;
        greaterInflation3Desc.text = "+2 инфляционных монеты при достижении Уровня Миллиард+\n+3 инфляционных монеты при достижении Уровня Квадриллион+"; greaterInflation3Desc.font = JostHeavyEngAndRuss;
        greaterInflation4Desc.text = "+3 Инфляционные монеты при достижении Уровня Триллион+\n+4 Инфляционные монеты при достижении Уровня Квинтиллион+"; greaterInflation4Desc.font = JostHeavyEngAndRuss;
        greaterInflation5Desc.text = "+4 инфляционные монеты при достижении Уровня Триллион+\n+5 Инфляционные монеты при достижении Уровня Секстиллион+"; greaterInflation5Desc.font = JostHeavyEngAndRuss;
        crazyInflationDesc.text = "+6 Inflation coins when you hit Million TIER+"; crazyInflationDesc.font = JostHeavyEngAndRuss;
        inflationGamble1Desc.text = "Каждый раз, когда вы получаете инфляционные монеты, есть +3% шанс получить 1 дополнительную инфляционную монету"; inflationGamble1Desc.font = JostHeavyEngAndRuss;
        inflationGamble2Desc.text = "Каждый раз, когда вы получаете инфляционные монеты, есть +4% шанс получить 1 дополнительную инфляционную монету"; inflationGamble2Desc.font = JostHeavyEngAndRuss;
        inflationGamble3Desc.text = "Каждый раз, когда вы получаете инфляционные монеты, есть +5% шанс получить 1 дополнительную инфляционную монету"; inflationGamble3Desc.font = JostHeavyEngAndRuss;
        inflationGamble4Desc.text = "Каждый раз, когда вы получаете инфляционные монеты, есть +6% шанс получить 1 дополнительную инфляционную монету"; inflationGamble4Desc.font = JostHeavyEngAndRuss;

        extraSpecialUpgrade1.text = "ДОПОЛНИТЕЛЬНЫЕ СПЕЦИАЛЬНЫЕ ОБНОВЛЕНИЯ 1"; extraSpecialUpgrade1.font = JostHeavyEngAndRuss; extraSpecialUpgrade1.fontSize = 8;
        extraSpecialUpgrade2.text = "ДОПОЛНИТЕЛЬНЫЕ СПЕЦИАЛЬНЫЕ ОБНОВЛЕНИЯ 2"; extraSpecialUpgrade2.font = JostHeavyEngAndRuss; extraSpecialUpgrade2.fontSize = 8;
        extraSpecialUpgrade3.text = "ДОПОЛНИТЕЛЬНЫЕ СПЕЦИАЛЬНЫЕ ОБНОВЛЕНИЯ 3"; extraSpecialUpgrade3.font = JostHeavyEngAndRuss; extraSpecialUpgrade3.fontSize = 8;
        extraExtraSpecialUpgrade1.text = "ДОПОЛНИТЕЛЬНЫЕ СПЕЦИАЛЬНЫЕ ОБНОВЛЕНИЯ"; extraExtraSpecialUpgrade1.font = JostHeavyEngAndRuss;
        extraExtraSpecialUpgrade1.fontSize = 8.4f;
        biggerPile1.text = "БОЛЬШЕ СТОПОК МОНЕТ 1"; biggerPile1.font = JostHeavyEngAndRuss;
        biggerPile2.text = "БОЛЬШЕ СТОПОК МОНЕТ 2"; biggerPile2.font = JostHeavyEngAndRuss;
        theGambler.text = "АЗАРТНЫЙ ИГРОК"; theGambler.font = JostHeavyEngAndRuss;
        getLuckier.text = "ВЕЗУНЧИК"; getLuckier.font = JostHeavyEngAndRuss;

        autoUpgradeInflate.text = "АВТООБНОВЛЕНИЕ"; autoUpgradeInflate.font = JostHeavyEngAndRuss;
        extraSpecialUpgrade1Desc.text = "В АЗАРТНОЙ ИГРЕ есть еще 2 попытки\nКаждое обновление в этой ветке снижает цену всех специальных обновлений на 1% и работает для каждого задания"; extraSpecialUpgrade1Desc.font = JostHeavyEngAndRuss; extraSpecialUpgrade1Desc.fontSize = 12;
        extraSpecialUpgrade2Desc.text = "АЗАРТНАЯ ИГРА теперь имеет 51% шанс удвоить ваши монеты.\nСТОПКА МОНЕТ генерирует больше монет"; extraSpecialUpgrade2Desc.font = JostHeavyEngAndRuss;
        extraSpecialUpgrade3Desc.text = "Когда вы забираете монеты из стопки монет, есть 5% шанс, что монеты останутся в стопке монет."; extraSpecialUpgrade3Desc.font = JostHeavyEngAndRuss;
        extraExtraSpecialUpgrade1Desc.text = "Специальные обновления стоят на 13% меньше\nВ АЗАРТНОЙ ИГРЕ есть еще 1 попытка\nВ 2 раза Больше СТОПОК МОНЕТ, которые генерируют монеты\nОБНОВЛЕННЫЕ ПЕРЕВОРАЧИВАНИЯ МОНЕТ теперь дают вам в 3 раза больше монет, а счастливые монеты дают вам 15X"; extraExtraSpecialUpgrade1Desc.font = JostHeavyEngAndRuss;
        extraExtraSpecialUpgrade1Desc.fontSize = 9.8f;
        biggerPile1Desc.text = "СТОПКА МОНЕТ дает вам +1 стопку, которая генерирует монеты\nСТОПКА МОНЕТ дает вам больше монет"; biggerPile1Desc.font = JostHeavyEngAndRuss;
        biggerPile2Desc.text = "СТОПКА МОНЕТ дает вам +1 стопку, которая генерирует монеты\nСТОПКА МОНЕТ дает вам еще больше монет"; biggerPile2Desc.font = JostHeavyEngAndRuss;
        theGamblerDesc.text = "У АЗАРТНОГО ИГРОКА есть еще 1 попытка\nКаждый раз, когда вы играете в АЗАРТНУЮ ИГРУ, шансы удвоить ваши монеты увеличиваются на 1%"; theGamblerDesc.font = JostHeavyEngAndRuss;
        getLuckierDesc.text = "Каждый раз, когда вам выпадает счастливая монета. Существует 5% вероятность того, что счастливая монета станет еще более счастливой монетой, которая даст вам в 50 раз больше монет"; getLuckierDesc.font = JostHeavyEngAndRuss; getLuckierDesc.fontSize = 11;
        autoUpgradeDesc.text = "Разблокирует автообновление на вкладке специальных обновлений"; autoUpgradeDesc.font = JostHeavyEngAndRuss;

        active1.text = "АКТИВНЫЙ ПОДБРАСЫВАТЕЛЬ 1"; active1.font = JostHeavyEngAndRuss; active1.fontSize = 13;
        active2.text = "АКТИВНЫЙ ПОДБРАСЫВАТЕЛЬ 2"; active2.font = JostHeavyEngAndRuss; active2.fontSize = 13;
        active3.text = "АКТИВНЫЙ ПОДБРАСЫВАТЕЛЬ 3"; active3.font = JostHeavyEngAndRuss; active3.fontSize = 13;
        active4.text = "АКТИВНЫЙ ПОДБРАСЫВАТЕЛЬ 4"; active4.font = JostHeavyEngAndRuss; active4.fontSize = 13;
        superActiveFlipper.text = "СУПЕР АКТИВНЫЙ ПОДБРАСЫВАТЕЛЬ"; superActiveFlipper.font = JostHeavyEngAndRuss; superActiveFlipper.fontSize = 11;
        activeEqualsBiggerPile.text = "АКТИВНЫЙ = БОЛЬШАЯ СТОПКА МОНЕТ"; activeEqualsBiggerPile.font = JostHeavyEngAndRuss; activeEqualsBiggerPile.fontSize = 10.5f;

        active1Desc.text = "Каждая монета, которую вы активно подбрасываете, даст вам на 8% больше монет\nОбновление активного подбрасывания работает для каждой ЗАДАЧИ"; active1Desc.font = JostHeavyEngAndRuss; active1Desc.fontSize = 11;
        active2Desc.text = "Каждая монета, которую вы активно подбрасываете, даст вам на 23% больше монет"; active2Desc.font = JostHeavyEngAndRuss;
        active3Desc.text = "Каждая монета, которую вы активно подбрасываете, даст вам на 40% больше монет"; active3Desc.font = JostHeavyEngAndRuss;
        active4Desc.text = "Каждая монета, которую вы активно подбрасываете, даст вам на 69% больше монет"; active4Desc.font = JostHeavyEngAndRuss;
        superActiveFlipperDesc.text = "Каждая активно подбрасываемая монета даст вам на 300% больше монет.\nСчастливые монеты дают 10-кратный выигрыш"; superActiveFlipperDesc.font = JostHeavyEngAndRuss;
        activeEqualsBiggerPileDesc.text = "Каждый раз, когда вы активно подбрасываете монету, существует 5% шанс, что количество монет, выпавших на ОРЕЛ/РЕШКУ, будет добавлен в СТОПКУ МОНЕТ"; activeEqualsBiggerPileDesc.font = JostHeavyEngAndRuss;
        backToFlippingIflated.text = "Хотели бы вы вернуться назад к подбрасыванию монет?"; backToFlippingIflated.font = JostHeavyEngAndRuss;
        yes.text = "ДА"; yes.font = JostHeavyEngAndRuss; no.text = "НЕТ"; no.font = JostHeavyEngAndRuss;

        for (int i = 0; i < unLocked.Length; i++)
        {
            unLocked[i].text = "ЗАБЛОКИРОВАНО";
            unLocked[i].font = ARIEL;
            unLocked[i].fontSize = 8;
        }

        for (int i = 0; i < locked.Length; i++)
        {
            locked[i].text = "РАЗБЛОКИРОВАНО";
            locked[i].font = ARIEL;
            locked[i].fontSize = 7;
        }


        #endregion

        #region settings

        music.text = "Музыка"; music.font = JostHeavyEngAndRuss;
        audiotext.text = "Аудио"; audiotext.font = JostHeavyEngAndRuss;
        fullscreen.text = "Полноэкранный режим"; fullscreen.font = ARIEL;
        saveGame.text = "Сохранить игру"; saveGame.font = JostHeavyEngAndRuss;
        exitGame.text = "Выйти из игры"; exitGame.font = JostHeavyEngAndRuss;
        resetEverything.text = "Сбросить все"; resetEverything.font = JostHeavyEngAndRuss;
        gameIsSaved30Seconds.text = "(Игра сохраняется каждые 30 секунд)"; gameIsSaved30Seconds.font = JostHeavyEngAndRuss;
        foundHiddenBronze.text = "Вы нашли спрятанную бронзовую монету!"; foundHiddenBronze.font = JostHeavyEngAndRuss;
        foundHiddenSilver.text = "Вы нашли спрятанную серебряную монету!"; foundHiddenSilver.font = JostHeavyEngAndRuss;
        settings.text = "Настройки"; settings.font = ARIEL; settings.fontSize = 19;
        info.text = "Информация"; info.font = ARIEL; info.fontSize = 17;
        socials.text = "Социальные сети"; socials.font = ARIEL; socials.fontSize = 12;
        generalGameInfo.text = "Общая информация об игре"; generalGameInfo.font = ARIEL;
        mechanicsExplanations.text = "Объяснения Механики Работы:"; mechanicsExplanations.font = ARIEL;

        inflationSystem.text = "Система Инфляции:"; inflationSystem.font = ARIEL;
        inflationSystemDesc.text = "-Вы получаете Инфляционные монеты каждый раз, когда добираетесь на четверть пути до следующего уровня монет.\n-Тип монет - это: миллион, миллиард, триллион, квадриллион и так далее.\n-Пример: Вы начнете получать инфляционные монеты, как только достигнете 1 Миллиона. Затем вы будете получать Инфляционные монеты, когда достигнете: 1 Миллион, 250 Миллионов, 500 Миллионов, 750 Миллионов, 1 Миллиард, 250 Миллиардов, 500 Миллиардов, 750 Миллиардов и так далее.\n-Базовое количество инфляционных монет, которое вы получаете каждый раз, когда набираете инфляционные монеты, равно 1. Покупайте обновления “БОЛЬШЕ ИНФЛЯЦИИ”, чтобы получать больше инфляционных монет во время игры."; inflationSystemDesc.font = ARIEL;
        inflationSystemDesc.fontSize = 12;

        pileOfCoinsText.text = "Куча Монет:"; pileOfCoinsText.font = ARIEL;
        pileOfCoinsDesc.text = "Количество монет, которое сгенерирует стопка, зависит от того, сколько монет выпадет при каждом удачном броске и сколько у вас есть подбрасывателей монет + 4. Так что, если у вас 150 монет на орлах/решках и 4 подбрасывателя монет, то количество сгенерированных монет составит 150 * (4+4), что равно 1200. Сумма будет больше, если игрок купил несколько инфляционных обновлений \"Дополнительных Специальных Обновлений\"."; pileOfCoinsDesc.font = ARIEL; pileOfCoinsDesc.fontSize = 11.5f;
        offlineProgression.text = "Оффлайн-прогресс:"; offlineProgression.font = ARIEL;
        offlineProgressionDesc.text = "Вы будете зарабатывать монеты каждую минуту, когда находитесь в оффлайн. Количество монет зависит от того, сколько у вас автоподбрасывателей и монет на орлах/решках. Так что, если у вас есть 500 тысяч монет на Орел/Решка и 4 автоподбрасывателя. Вы будете получать 2 миллиона монет каждую минуту."; offlineProgressionDesc.font = ARIEL; offlineProgressionDesc.fontSize = 11.5f;

        developerBy.text = "Coin Flipper разработан: <b>Simon Eftestøl</b>"; developerBy.font = ARIEL;
        musicBy.text = "Музыка предоставлена: <b>HSB Loops</b>"; musicBy.font = ARIEL;
        texturesProvidedBy.text = "Текстуры предоставлены: <b>Free SVG</b>"; texturesProvidedBy.font = ARIEL;
        followMyTwitch.text = "Следите за моим twitch!"; followMyTwitch.font = ARIEL;
        follotMyTwitter.text = "Следите за моим X!"; follotMyTwitter.font = ARIEL;
        joinTheDiscord.text = "Присоединяйтесь к Discord!"; joinTheDiscord.font = ARIEL;
        quitPlayingChallenge.text = "Хотите прекратить игру в этом испытании?"; quitPlayingChallenge.font = ARIEL;
        quitChallengeDesc.text = "Игра будет сброшена и вернется к экрану \"Выберите орла или решку\". Все постоянные улучшения инфляции, конечно же, не будут сброшены."; quitChallengeDesc.font = ARIEL;
        quitChalYes.text = "ДА"; quitChalYes.font = JostHeavyEngAndRuss;
        quitChalNo.text = "НЕТ"; quitChalNo.font = JostHeavyEngAndRuss;
        whishToResetGame.text = "Вы хотите начать сначала?"; whishToResetGame.font = ARIEL;
        wishToResetDesc.text = "Все достижения будут сброшены, и игра начнется с самого начала."; wishToResetDesc.font = ARIEL;
        resetYes.text = "ДА"; resetYes.font = JostHeavyEngAndRuss;
        resetNo.text = "НЕТ"; resetNo.font = JostHeavyEngAndRuss;
        quitChall1.text = "ВЫЙТИ ИЗ ИСПЫТАНИЯ 1"; quitChall1.font = JostHeavyEngAndRuss; quitChall1.fontSize = 31;
        quitChall2.text = "ВЫЙТИ ИЗ ИСПЫТАНИЯ 2"; quitChall2.font = JostHeavyEngAndRuss; quitChall2.fontSize = 31;
        quitChall3.text = "ВЫЙТИ ИЗ ИСПЫТАНИЯ 3"; quitChall3.font = JostHeavyEngAndRuss; quitChall3.fontSize = 31;
        quitChall4.text = "ВЫЙТИ ИЗ ИСПЫТАНИЯ 4"; quitChall4.font = JostHeavyEngAndRuss; quitChall4.fontSize = 31;
        gameSaved.text = "Игра сохранена"; gameSaved.font = ARIEL;
        gameSaved2.text = "Игра сохранена"; gameSaved2.font = ARIEL;

        #endregion

        #region offlineEarnings

        days = " Дней "; hours = " Часов "; minuts = " минут "; secondsTime = " секунд";

        offlineEarningTotalText.font = JostHeavyEngAndRuss;
        timeGoneText.font = JostHeavyEngAndRuss;

        welcomeBack.text = "С возвращением!"; welcomeBack.font = JostHeavyEngAndRuss;
        youWereGoneFor.text = "Вас не было в течение:"; youWereGoneFor.font = ARIEL;
        offlineEarnings.text = "Заработок в оффлайне:"; offlineEarnings.font = ARIEL;
        offlineOK.text = "Ок"; offlineOK.font = JostHeavyEngAndRuss;

        #endregion

        #region FINAL missed

        upgradesHover.text = "Обновления"; upgradesHover.font = JostHeavyEngAndRuss; upgradesHover.fontSize = 33;
        specialUpgradesHover.text = "Специальные Обновления"; specialUpgradesHover.font = JostHeavyEngAndRuss; specialUpgradesHover.fontSize = 29;
        achievementsHover.text = "Достижения"; achievementsHover.font = JostHeavyEngAndRuss; achievementsHover.fontSize = 27;
        statsHover.text = "статистика"; statsHover.font = JostHeavyEngAndRuss; statsHover.fontSize = 32;

        specialIpgradeWarning.text = "Обновленный Подбрасыватель Монет по умолчанию будет подбрасывать монеты автоматически. Перед покупкой этого обновления необходимо приобрести еще одно обновление \"Автоматическое Подбрасывание Монет\"";
        specialIpgradeWarning.font = JostHeavyEngAndRuss; specialIpgradeWarning.fontSize = 8;

        congrats1.text = "Поздравляем!"; congrats1.font = JostHeavyEngAndRuss;
        congrats2.text = "Поздравляем!"; congrats2.font = JostHeavyEngAndRuss;
        congrats3.text = "Поздравляем!"; congrats3.font = JostHeavyEngAndRuss;
        congrats4.text = "Поздравляем!"; congrats4.font = JostHeavyEngAndRuss;
        youUnlocked1.text = "Вы разблокировали:"; youUnlocked1.font = JostHeavyEngAndRuss; youUnlocked1.fontSize = 10;
        youUnlocked2.text = "Вы разблокировали:"; youUnlocked2.font = JostHeavyEngAndRuss; youUnlocked2.fontSize = 10;
        youUnlocked3.text = "Вы разблокировали:"; youUnlocked3.font = JostHeavyEngAndRuss; youUnlocked3.fontSize = 10;
        youUnlocked4.text = "Вы разблокировали:"; youUnlocked4.font = JostHeavyEngAndRuss; youUnlocked4.fontSize = 10;
        youCompletedChal1.text = "Вы выполнили задание #1 - \"Без авто подбрасываний\""; youCompletedChal1.font = JostHeavyEngAndRuss;
        youCompletedChal2.text = "Вы прошли задание #2 - \"Невезучий\""; youCompletedChal2.font = JostHeavyEngAndRuss;
        youCompletedChal3.text = "Вы прошли задание #3 - \"1 Подбрасывание Монеты\""; youCompletedChal3.font = JostHeavyEngAndRuss;
        youCompletedChal4.text = "Вы выполнили задание #4 - \"Счастливчик\""; youCompletedChal4.font = JostHeavyEngAndRuss;
        completedChalFlipAll.text = "Подбрасывать Все"; completedChalFlipAll.font = JostHeavyEngAndRuss;
        completedChallAutoFlipsEquals.text = "Авто Подбрасывание ="; completedChallAutoFlipsEquals.font = JostHeavyEngAndRuss;
        completedChallAutoFlipsEquals.fontSize = 12.5f;
        onText.text = "Вкл"; onText.font = JostHeavyEngAndRuss;
        onText2.text = "Вкл"; onText2.font = JostHeavyEngAndRuss;
        offText.text = "Выкл"; offText.font = JostHeavyEngAndRuss;
        chal2CompletedRewardInfo.text = "Первые 5 подбрасываний монет всегда будут удачными"; chal2CompletedRewardInfo.font = JostHeavyEngAndRuss;
        chal3CompletedRewardInfo.text = "Первый бросок монеты всегда будет успешным и получит бонус +500% монет!";
        chal3CompletedRewardInfo.font = JostHeavyEngAndRuss;
        chal4CompletedRewardInfo.text = "Теперь при подбрасывании монет шанс выпадания счастливой монеты составляет до 15%"; chal4CompletedRewardInfo.font = JostHeavyEngAndRuss; chal4CompletedRewardInfo.fontSize = 8;

        totalCoins = "Монеты: ";
        coinsMainText.text = "Монеты: " + FormatCoins(GlobalCoins.CoinCount); coinsMainText.font = JostHeavyEngAndRuss;

        lockedAuto.text = "ЗАБЛОКИРОВАНО"; lockedAuto.font = JostHeavyEngAndRuss; lockedAuto.fontSize = 28;
        lockedDuplicate.text = "ЗАБЛОКИРОВАНО"; lockedDuplicate.font = JostHeavyEngAndRuss; lockedDuplicate.fontSize = 28;
        lockedLucky.text = "ЗАБЛОКИРОВАНО"; lockedLucky.font = JostHeavyEngAndRuss; lockedLucky.fontSize = 28;
        lockedHigherChance.text = "ЗАБЛОКИРОВАНО"; lockedHigherChance.font = JostHeavyEngAndRuss; lockedHigherChance.fontSize = 28;
        lockedSpecialUpgrade.text = "ЗАБЛОКИРОВАНО"; lockedSpecialUpgrade.font = JostHeavyEngAndRuss; lockedSpecialUpgrade.fontSize = 28;

        moreCoinsIn = "Больше монет за: "; Xseconds = " секунд"; 
        moreCoinsIn1.font = JostHeavyEngAndRuss;
        moreCoinsIn2.font = JostHeavyEngAndRuss;
        moreCoinsIn3.font = JostHeavyEngAndRuss;
        moreCoinsIn4.font = JostHeavyEngAndRuss;
        moreCoinsIn5.font = JostHeavyEngAndRuss;
        plussPile1.text = "+Кучи монет"; plussPile1.font = JostHeavyEngAndRuss;
        plussPile2.text = "+Кучи монет"; plussPile2.font = JostHeavyEngAndRuss;
        plussPile3.text = "+Кучи монет"; plussPile3.font = JostHeavyEngAndRuss;
        plussPile4.text = "+Кучи монет"; plussPile4.font = JostHeavyEngAndRuss;
        plussPile5.text = "+Кучи монет"; plussPile5.font = JostHeavyEngAndRuss;
        thisPileContains1.text = "Эта стопка содержит: "; thisPileContains1.font = JostHeavyEngAndRuss;
        thisPileContains2.text = "Эта стопка содержит: "; thisPileContains2.font = JostHeavyEngAndRuss;
        thisPileContains3.text = "Эта стопка содержит: "; thisPileContains3.font = JostHeavyEngAndRuss;
        thisPileContains4.text = "Эта стопка содержит: "; thisPileContains4.font = JostHeavyEngAndRuss;
        thisPileContains5.text = "Эта стопка содержит: "; thisPileContains5.font = JostHeavyEngAndRuss;
        totalCoinsPile1.font = JostHeavyEngAndRuss;
        totalCoinsPile2.font = JostHeavyEngAndRuss;
        totalCoinsPile3.font = JostHeavyEngAndRuss;
        totalCoinsPile4.font = JostHeavyEngAndRuss;
        totalCoinsPile5.font = JostHeavyEngAndRuss;


        totalCoinsPile1.text = FormatCoins2(PileOfCoinsMechanics.PileOfCoinsAmount1);
        totalCoinsPile2.text = FormatCoins2(PileOfCoinsMechanics.PileOfCoinsAmount2);
        totalCoinsPile3.text = FormatCoins2(PileOfCoinsMechanics.PileOfCoinsAmount3);
        totalCoinsPile4.text = FormatCoins2(PileOfCoinsMechanics.PileOfCoinsAmount4);
        totalCoinsPile5.text = FormatCoins2(PileOfCoinsMechanics.PileOfCoinsAmount5);



        heads = "ОРЛЫ! ";
        tails = "РЕШКИ! ";
        luckyCoin = "СЧАСТЛИВАЯ МОНЕТА! ";

        #endregion

        googlePlayText.text = "Также доступно на мобильном телефоне!";
        googlePlayText.font = JostHeavyEngAndRuss;

        if (LoadSaves.isMobileBuild == true) { SetMobileTexts(); }
    }
    #endregion


    #region CHINESEREGION
    //CHINESE

    //Change cons on heads/tails to proper chinese
    public void Chinese()
    {
        changeFont = 1;
        ChooseText = 3;
        PlayerPrefs.SetInt("ChosenText", ChooseText);
        #region ChooseScene
        HeadsOrTails.text = "正面或反面？"; HeadsOrTails.font = notoSansChineseBold;
        youChoseHeads.text = "您选择了正面！"; youChoseHeads.font = notoSansChineseBold;
        youChoseTails.text = "您选择了反面！"; youChoseTails.font = notoSansChineseBold;
        challengesText.text = "挑战"; challengesText.font = notoSansChineseBold;
        challenge1Name.text = "没有自动掷币器"; challenge1Name.font = notoSansChineseBold; challenge1Name.fontSize = 29;
        challenge2Name.text = "25%的掷币机会"; challenge2Name.font = notoSansChineseBold; challenge2Name.fontSize = 29;
        challenge3Name.text = "1个掷币器"; challenge3Name.font = notoSansChineseBold; challenge3Name.fontSize = 29;
        challenge4Name.text = "永远幸运"; challenge4Name.font = notoSansChineseBold; challenge4Name.fontSize = 29;
        challenge1Text.text = "挑战＃1"; challenge1Text.font = notoSansChinese;
        challenge2Text.text = "挑战＃2"; challenge2Text.font = notoSansChinese;
        challenge3Text.text = "挑战＃3"; challenge3Text.font = notoSansChinese;
        challenge4Text.text = "挑战＃4"; challenge4Text.font = notoSansChinese;
        challengeNegative1.text = "* 自动掷币器被封锁\n* 升级掷币器被封锁"; challengeNegative1.font = notoSansChineseBold; challengeNegative1.fontSize = 14.8f;
        challengeNegative2.text = "* 永久的25%的掷币成功率\n * 更高的成功率被封锁"; challengeNegative2.font = notoSansChineseBold; challengeNegative2.fontSize = 14f;
        challengeNegative3.text = "* 你只有1个掷币器\n* 掷更多硬币被封锁"; challengeNegative3.font = notoSansChineseBold; challengeNegative3.fontSize = 14f;
        challengeNegative4.text = "* 在这个挑战中，你不能获得膨胀硬币"; challengeNegative4.font = notoSansChineseBold; challengeNegative4.fontSize = 14f;
        challengePositive1.text = "* 你的掷币获得500%的硬币"; challengePositive1.font = notoSansChineseBold;
        challengepositive2.text = "* 每次掷币都是幸运硬币"; challengepositive2.font = notoSansChineseBold; challengepositive2.fontSize = 14;
        Goal1text.text = "目标："; Goal1text.font = notoSansChineseBold;
        Goal2text.text = "目标："; Goal2text.font = notoSansChineseBold;
        Goal3text.text = "目标："; Goal3text.font = notoSansChineseBold;
        Goal4text.text = "目标："; Goal4text.font = notoSansChineseBold;
        Goal1textInfo.text = "达到15个掷币器"; Goal1textInfo.font = notoSansChineseBold;
        Goal2textInfo.text = "升级7个掷币器"; Goal2textInfo.font = notoSansChineseBold;
        Goal3textInfo.text = "达到70 京硬币"; Goal3textInfo.font = notoSansChineseBold;
        Goal4textInfo.text = "升级所有21个掷币器"; Goal4textInfo.font = notoSansChineseBold; Goal4textInfo.fontSize = 27;
        Reward1Text.text = "奖励："; Reward1Text.font = notoSansChineseBold;
        Reward2Text.text = "奖励:"; Reward2Text.font = notoSansChineseBold;
        Reward3Text.text = "奖励:"; Reward3Text.font = notoSansChineseBold;
        Reward4Text.text = "奖励:"; Reward4Text.font = notoSansChineseBold;
        Reward1TextInfo.text = "解锁被锁定的特殊升级"; Reward1TextInfo.font = notoSansChineseBold; Reward1TextInfo.fontSize = 20;
        Reward2TextInfo.text = "前5个掷币器将永远有100%的成功掷币器机会"; Reward2TextInfo.font = notoSansChineseBold; Reward2TextInfo.fontSize = 20;
        Reward3TextInfo.text = "第一个掷币器肯定会成功，并使你的硬币增加500%"; Reward3TextInfo.font = notoSansChineseBold; Reward3TextInfo.fontSize = 20;
        Reward4TextInfo.text = "幸运硬币的最大几率可以达到15%"; Reward4TextInfo.font = notoSansChineseBold; Reward4TextInfo.fontSize = 20;
        questionInfo.text = "-建议您在至少膨胀一次后再尝试挑战\n \n" +
            "-阅读每个分支树的第一个膨胀升级，以了解在每个挑战期间哪个升级将起作用\n \n" +
            "-您一次只能选择1个挑战\n \n" +
            "-每个挑战都将给您永久奖励"; questionInfo.fontSize = 22.2f;
        questionInfo.font = notoSansChineseBold; 
        #endregion

        #region upgrades
        upgrade1.text = "强壮的臂膀"; upgrade1.font = notoSansChineseBold;
        upgrade2.text = "大币"; upgrade2.font = notoSansChineseBold;
        upgrade3.text = "知识"; upgrade3.font = notoSansChineseBold;
        upgrade4.text = "强壮拳头"; upgrade4.font = notoSansChineseBold;
        upgrade5.text = "手部注射"; upgrade5.font = notoSansChineseBold;
        upgrade6.text = "大脑力量"; upgrade6.font = notoSansChineseBold;
        upgrade7.text = "爆炸性的掷币"; upgrade7.font = notoSansChineseBold; upgrade7.fontSize = 30;
        upgrade8.text = "补水"; upgrade8.font = notoSansChineseBold;
        upgrade9.text = "奇怪的药水"; upgrade9.font = notoSansChineseBold;
        upgrade10.text = "掷币高手"; upgrade10.font = notoSansChineseBold;
        upgrade11.text = "握手"; upgrade11.font = notoSansChineseBold;
        upgrade12.text = "击掌"; upgrade12.font = notoSansChineseBold;
        upgrade13.text = "魔法掷币"; upgrade13.font = notoSansChineseBold; upgrade13.fontSize = 30;
        upgrade14.text = "宝箱"; upgrade14.font = notoSansChineseBold;
        upgrade15.text = "掷币仪式"; upgrade15.font = notoSansChineseBold; upgrade15.fontSize = 30;

        upgrade1n.font = notoSansChineseBold;
        upgrade2n.font = notoSansChineseBold;
        upgrade3n.font = notoSansChineseBold;
        upgrade4n.font = notoSansChineseBold;
        upgrade5n.font = notoSansChineseBold;
        upgrade6n.font = notoSansChineseBold;
        upgrade7n.font = notoSansChineseBold; upgrade7n.fontSize = 30;
        upgrade8n.font = notoSansChineseBold;
        upgrade9n.font = notoSansChineseBold;
        upgrade10n.font = notoSansChineseBold;
        upgrade11n.font = notoSansChineseBold;
        upgrade12n.font = notoSansChineseBold;
        upgrade13n.font = notoSansChineseBold; upgrade13n.fontSize = 30;
        upgrade14n.font = notoSansChineseBold;
        upgrade15n.font = notoSansChineseBold; upgrade15n.fontSize = 30;

        strongerArmName = "强壮的臂膀";
        greaterCoinName = "大币";
        knowledgeName = "知识";
        strongerFistName = "强壮拳头";
        handInjectionName = "手部注射";
        brainPowerName = "大脑力量";
        explosiveFlipsName = "爆炸性的掷币";
        hydrationName = "补水";
        strangePotionName = "奇怪的药水";
        masterFlipperName = "掷币高手";
        handShakeName = "握手";
        highFiveName = "击掌";
        magicFlipsName = "魔法掷币";
        TreasueChestName = "宝箱";
        coinFlippingRitualName = "掷币仪式";

        flipMorePrice1.font = notoSansChinese;
        flipMorePrice2.font = notoSansChinese;

        thousand = " 千个";
        million = " 百万个";
        billion = " 十亿个";
        trillion = " 兆个";
        quadrillion = " 京个";
        quintillion = " 垓个";
        sextillion = " 秭个";
        septillion = " 穰个";
        octillion = " 沟个";
        nonillion = " 澗个";
        decillion = " 正个";
        undecillion = " 载个";
        coins = " 硬币";
        coinsOnHeads = " 正面有";
        coinsOnTails = " 正面有";

        price1.font = notoSansChinese;
        price2.font = notoSansChinese;
        price3.font = notoSansChinese;
        price4.font = notoSansChinese;
        price5.font = notoSansChinese;
        price6.font = notoSansChinese;
        price7.font = notoSansChinese;
        price8.font = notoSansChinese;
        price9.font = notoSansChinese;
        price10.font = notoSansChinese;
        price11.font = notoSansChinese;
        price12.font = notoSansChinese;
        price13.font = notoSansChinese;
        price14.font = notoSansChinese;
        price15.font = notoSansChinese;
        price16.font = notoSansChinese;
        price17.font = notoSansChinese;
        price18.font = notoSansChinese;
        price19.font = notoSansChinese;
        price20.font = notoSansChinese;

        price1c.font = notoSansChinese;
        price2c.font = notoSansChinese;
        price3c.font = notoSansChinese;
        price4c.font = notoSansChinese;
        price5c.font = notoSansChinese;
        price6c.font = notoSansChinese;
        price7c.font = notoSansChinese;
        price8c.font = notoSansChinese;
        price9c.font = notoSansChinese;
        price10c.font = notoSansChinese;
        price11c.font = notoSansChinese;
        price12c.font = notoSansChinese;
        price13c.font = notoSansChinese;
        price14c.font = notoSansChinese;
        price15c.font = notoSansChinese;
        price16c.font = notoSansChinese;
        price17c.font = notoSansChinese;
        price18c.font = notoSansChinese;
        price19c.font = notoSansChinese;
        price20c.font = notoSansChinese;

        flipAll.text = "掷全部"; flipAll.font = notoSansChineseBold;
        autoFlipsQeuals.text = "自动翻转 ="; autoFlipsQeuals.font = notoSansChineseBold; autoFlipsQeuals.fontSize = 25;
        on.text = "开启"; on.font = notoSansChineseBold;
        on2.text = "开启"; on2.font = notoSansChineseBold;
        off.text = "关闭"; off.font = notoSansChineseBold;
        off2.text = "关闭"; off2.font = notoSansChineseBold;
        gamble.text = "赌博"; gamble.font = notoSansChineseBold;
        gamblec.text = "赌博"; gamblec.font = notoSansChineseBold;
        current.text = "当前的："; current.font = notoSansChineseBold; current.fontSize = 25;
        autoFlips.text = "自动掷币"; autoFlips.font = notoSansChineseBold; autoFlips.fontSize = 30;
        autoFlipsc.text = "自动掷币"; autoFlipsc.font = notoSansChineseBold; autoFlipsc.fontSize = 30;
        pileOfCoins.text = "一堆硬币"; pileOfCoins.font = notoSansChineseBold;
        pileOfCoinsc.text = "一堆硬币"; pileOfCoinsc.font = notoSansChineseBold;
        higherChance.text = "更高的成功几率"; higherChance.font = notoSansChineseBold;
        higherChancec.text = "更高的成功几率"; higherChancec.font = notoSansChineseBold;
        getLucky.text = "好运降临"; getLucky.font = notoSansChineseBold;
        getLuckyc.text = "好运降临"; getLuckyc.font = notoSansChineseBold;
        endlessInflation.text = "无限膨胀"; endlessInflation.font = notoSansChineseBold;
        upgradedFlips.text = "升级掷币!"; upgradedFlips.font = notoSansChineseBold; upgradedFlips.fontSize = 36;
        upgradedFlipsc.text = "升级掷币!"; upgradedFlipsc.font = notoSansChineseBold; upgradedFlipsc.fontSize = 36;
        unlockedViaChal1.text = "通过完成挑战#1解锁"; unlockedViaChal1.font = notoSansChineseBold; unlockedViaChal1.fontSize = 16;
        unlcokedViaInf.text = "通过膨胀解锁"; unlcokedViaInf.font = notoSansChineseBold;
        chooseAutoUpgrade.text = "选择要自动升级的升级:"; chooseAutoUpgrade.font = notoSansChineseBold;
        diplicateFlips.font = notoSansChineseBold; diplicateFlips.fontSize = 36;  
        diplicateFlipsc.font = notoSansChineseBold; diplicateFlipsc.fontSize = 36;
        autoUpgradeNameText.text = "自动升级"; autoUpgradeNameText.font = notoSansChineseBold;

        autoUpgradeName = "自动掷币";
        pileOfCoinsName = "一堆硬币";
        higherChanceName = "更高的成功几率";
        getLuckyName = "好运降临";
        upgradedFlipsName = "升级掷币";
        flipMoreCoinsName = "掷更多硬币";
        spendNoMore = "最大限度";
        maxedOut = "最大限度";
        theyAllFlip = "最大限度";

        #endregion

        #region hoverOverUpgrades
        hover1Name.text = strongerArmName; hover1Name.font = notoSansChineseBold;
        hover2Name.text = greaterCoinName; hover2Name.font = notoSansChineseBold;
        hover3Name.text = knowledgeName; hover3Name.font = notoSansChineseBold;
        hover4Name.text = strongerFistName; hover4Name.font = notoSansChineseBold;
        hover5Name.text = handInjectionName; hover5Name.font = notoSansChineseBold;
        hover6Name.text = brainPowerName; hover6Name.font = notoSansChineseBold;
        hover7Name.text = explosiveFlipsName; hover7Name.font = notoSansChineseBold; hover7Name.fontSize = 36;
        hover8Name.text = hydrationName; hover8Name.font = notoSansChineseBold;
        hover9Name.text = strangePotionName; hover9Name.font = notoSansChineseBold;
        hover10Name.text = masterFlipperName; hover10Name.font = notoSansChineseBold;
        hover11Name.text = handShakeName; hover11Name.font = notoSansChineseBold;
        hover12Name.text = highFiveName; hover12Name.font = notoSansChineseBold;
        hover13Name.text = magicFlipsName; hover13Name.font = notoSansChineseBold; hover13Name.fontSize = 36;
        hover14Name.text = TreasueChestName; hover14Name.font = notoSansChineseBold;
        hover15Name.text = coinFlippingRitualName; hover15Name.font = notoSansChineseBold; hover15Name.fontSize = 36;
        hoverFlipAll.text = "掷全部"; hoverFlipAll.font = notoSansChineseBold;
        hoverAutoUpgrade.text = "自动升级"; hoverAutoUpgrade.font = notoSansChineseBold;
        hovergamble.text = "赌博"; hovergamble.font = notoSansChineseBold; hovergamble.fontSize = 35;
        hoverAutoFlip.text = autoUpgradeName; hoverAutoFlip.font = notoSansChineseBold; hoverAutoFlip.fontSize = 36;
        hoverPile.text = pileOfCoinsName; hoverPile.font = notoSansChineseBold;
        hoverhigherChance.text = higherChanceName; hoverhigherChance.font = notoSansChineseBold;
        hoverLucky.text = getLuckyName; hoverLucky.font = notoSansChineseBold;
        hoverEndless.text = "无限膨胀"; hoverEndless.font = notoSansChineseBold;
        hoverUpgradedFlips.text = upgradedFlipsName; hoverUpgradedFlips.font = notoSansChineseBold; hoverUpgradedFlips.fontSize = 35;
        hoverOn.text = "开启自动抛硬币"; hoverOn.font = notoSansChineseBold;
        hoverOff.text = "关闭自动掷币"; hoverOff.font = notoSansChineseBold;

        purchased = "购买: ";

        purchased1.text = "购买: " + MoreCoinsButton.moreCoinsUpgrades; purchased2.text = "购买: " + MoreCoinsButton.greaterCoinsCount;
        purchased3.text = "购买: " + KnowledgeUpgrade.knowledgeUpgradeCount; purchased4.text = "购买: " + StrongerFist.fistUpgradeCount;
        purchased5.text = "购买: " + HandInecjtion.injectionUpgradeCount; purchased6.text = "购买: " + BrainPower.brainPowerUpgradeCount;
        purchased7.text = "购买: " + ExplosiveFlips.explosiveUpgradeCount; purchased8.text = "购买: " + HydrationButton.hydrationUpgradeCount;
        purchased9.text = "购买: " + StrangePotion.potionUpgradeCount; purchased10.text = "购买: " + MasterFlipper.MasterFlipsUpgradeCount;
        purchased11.text = "购买: " + HandShake.handShakeUpgradeCount; purchased12.text = "购买: " + Upgrade12.upgrade12Count;
        purchased13.text = "购买: " + MagicFlipsUpgrade.magicUpgradeCount; purchased14.text = "购买: " + TreasureChest.treasureCount;
        purchased15.text = "购买: " + RitualUpgrade.treasureCount;
        purchased16.text = "购买: " + GlobalCoinMaker.coinsPerFlipUpgrades; purchased17.text = "购买: " + PurchaseLog.higherChanceUpgradeCount;
        purchased18.text = "购买: " + PurchaseLog.luckyCoinHigherChanceCount; purchased19.text = "购买: " + GoldenFlipsButton.goldenCoinsUpgradeCount;
        purchased20.text = "购买: " + PurchaseLog.pileOfCoinsCount; purchased21.text = "购买: ";


        purchased1.font = notoSansChineseBold; purchased2.font = notoSansChineseBold; purchased3.font = notoSansChineseBold; purchased4.font = notoSansChineseBold;
        purchased5.font = notoSansChineseBold; purchased6.font = notoSansChineseBold; purchased7.font = notoSansChineseBold; purchased8.font = notoSansChineseBold;
        purchased9.font = notoSansChineseBold; purchased10.font = notoSansChineseBold; purchased11.font = notoSansChineseBold; purchased12.font = notoSansChineseBold;
        purchased13.font = notoSansChineseBold; purchased14.font = notoSansChineseBold; purchased15.font = notoSansChineseBold;
        purchased16.font = notoSansChineseBold;
        purchased17.font = notoSansChineseBold; purchased18.font = notoSansChineseBold; purchased19.font = notoSansChineseBold;
        purchased20.font = notoSansChineseBold; purchased21.font = notoSansChineseBold;

        thousandC = " 千个硬币"; millionc = " 百万个硬币"; billionc = " 十亿个硬币"; trillionc = " 兆个硬币"; quadrillionc = " 京个硬币"; quintillionc = " 垓个硬币";
        sextillionc = " 秭个硬币"; septillionc = "  穰个硬币"; octillionc = " 沟个硬币"; nonillionc = " 澗个硬币"; decillionc = " 正个硬币";
        undecillionc = " 载个硬币";

        description1.text = "\"你多年来一直在训练你的二头肌、三头肌和前臂。而随着这种力量的增强，现在你可以用更大的力量掷币了!\"";
        description2.text = "\"有一天你决定捡起一个在人行道上躺着的硬币。结果当你掷这个硬币时，你得到更多的硬币!\"";
        description3.text = "\"你知道有什么东西比强壮的臂膀和大币更好吗？那就是知识\"";
        description4.text = "\"在健身房里，每个人都在锻炼全身。而你的注意力完全集中在你的拳头上。你的注意力却完全集中在你的拳头上。你单独训练每个手指，这使得你整个拳头都得到了强烈的锻炼.\"";
        description5.text = "\"街上的一个陌生人卖给了你一支注射器，里面装着一些奇怪的液体。你把它注射到手里，出乎意料的是，你感觉比以前更好了.\"";
        description6.text = "\"由于你多年来不断进行掷币，你的大脑现在可以拥有超过100%的能力.\"";
        description7.text = "\"现在掷币已经变得相当危险了。你每掷一次硬币， 你的拇指上会产生一个小爆炸。尽管是爆炸，但它只是感觉一点刺痛罢了.\"";
        description8.text = "\"整天掷币很辛苦，有时只需要一些冰凉清新的水就能轻松坚持下去。所以，记得要多喝水!\"";
        description9.text = "\"你一直在床底下放着一瓶奇怪的药水。 今天你决定喝下它，就像补充剂一样，你从未感觉如此良好\"";
        description10.text = "\"你多年来对硬币掷币的奉献，让你可以获得掷币大师勋章.\"";
        description11.text = "\"你与一位职业掷币商人握手。不管用什么方式，你和他将把掷币变成世界上最成功的生意......\"";
        description12.text = "\"你与一位对你来说非常重要的人击掌。这给了你超乎想象的掷币力量.\"";
        description13.text = "\"你前往某个巫师学校学习魔法掷币的才能。你掷的硬币现在每次都会发出魔法般的光芒。这使人们感到震叹\"";
        description14.text = "\"在你无数次环游世界的过程中，你发现了一些已经遗失很久的宝藏箱。因此，你开始掷箱内的硬币\"";
        description15.text = "\"掷币这件事忽然发生黑暗的转变。你变得着迷于寻找新的掷币的方式。你开始执行黑暗的仪式，希望将掷币提升到最高境界\"";
        description16.text = "\"有时候，让别人替你掷币会更好。每次升级都会自动为您翻掷1个硬币\"";
        description17.text = "\"现在你的掷币将有多1%的成功机会。如果你运气好的话，这能给你带来更多的钱币！\"";
        description18.text = "\"有时你的掷币可能会有点不同。当这些不同的掷币发生时，你可以获得5倍的硬币。每次升级会给你+0.5％\"";
        description19.text = "\"每次购买将升级1个掷币器到升级版本。掷币将为您提供2倍的硬币，幸运硬币将为您提供10倍\"";
        description20.text = "\"你是个赌徒吗？如果是的话，你敢尝试翻倍所有的硬币吗？这里不靠技能，只靠运气。还有请记得，如果你不想，你不需要这样做\"";
        description21.text = "-选择要自动升级的升级。选择要自动升级的升级\n\n-如果你有足够的钱，自动升级将每5秒购买你选择的升级。\n\n-当游戏关闭时，自动升级不起作用";
        description22.text = "-你可以开启或关闭自动掷币\n-当你掷完所有硬币时，必须等待3秒才能再次掷币\n-当你关闭自动掷币时，不能主动掷任何硬币\n-在关闭自动掷币时，自动升级和升级后的硬币掷币都被锁定";
        description23.text = "\"一个硬币堆会出现在左下角。随着时间，这堆硬币将产生越来越多的硬币。一旦点击，你就会得到所有的硬币\"";
        descEndless1.text = "\"建议玩家在解锁大部分膨胀升级之前不要开始购买此升级.\"";
        descEndless2.text = "此升级的运作方式与“富有”的膨胀升级相同。每次购买的硬币奖励等于升级价格";
        description1.font = notoSansChinese; description2.font = notoSansChinese; description3.font = notoSansChinese; description4.font = notoSansChinese; description5.font = notoSansChinese;
        description6.font = notoSansChinese; description7.font = notoSansChinese; description8.font = notoSansChinese; description9.font = notoSansChinese; description10.font = notoSansChinese;
        description11.font = notoSansChinese; description12.font = notoSansChinese; description13.font = notoSansChinese; description14.font = notoSansChinese; description15.font = notoSansChinese;
        description16.font = notoSansChinese; description17.font = notoSansChinese; description18.font = notoSansChinese; description19.font = notoSansChinese; description20.font = notoSansChinese;
        description21.font = notoSansChinese; description22.font = notoSansChinese; description23.font = notoSansChinese; descEndless1.font = notoSansChinese; descEndless2.font = notoSansChinese;

        description2.fontSize = 15; description4.fontSize = 15; description5.fontSize = 15; description7.fontSize = 15; description8.fontSize = 15;
        description11.fontSize = 15; description13.fontSize = 15; description14.fontSize = 15; description15.fontSize = 14.7f; description16.fontSize = 15; description18.fontSize = 15; description19.fontSize = 14.8f;
        description20.fontSize = 15; description22.fontSize = 15; description23.fontSize = 15; descEndless1.fontSize = 14.5f; descEndless2.fontSize = 14.7f;

        hoverCost1.font = notoSansChineseBold; hoverCost2.font = notoSansChineseBold; hoverCost3.font = notoSansChineseBold; hoverCost4.font = notoSansChineseBold; hoverCost5.font = notoSansChineseBold;
        hoverCost6.font = notoSansChineseBold; hoverCost7.font = notoSansChineseBold; hoverCost8.font = notoSansChineseBold; hoverCost9.font = notoSansChineseBold; hoverCost10.font = notoSansChineseBold;
        hoverCost11.font = notoSansChineseBold; hoverCost12.font = notoSansChineseBold; hoverCost13.font = notoSansChineseBold; hoverCost14.font = notoSansChineseBold; hoverCost15.font = notoSansChineseBold;
        hoverCost16.font = notoSansChineseBold; hoverCost17.font = notoSansChineseBold; hoverCost18.font = notoSansChineseBold; hoverCost19.font = notoSansChineseBold; hoverCost20.font = notoSansChineseBold;
        hoverCost21.font = notoSansChineseBold;

        p1.text = "价格:"; p2.text = "价格:"; p3.text = "价格:"; p4.text = "价格:"; p5.text = "价格:"; p6.text = "价格:"; p7.text = "价格:"; p8.text = "价格:"; p9.text = "价格:"; p10.text = "价格:";
        p11.text = "价格:";
        p12.text = "价格:"; p13.text = "价格:"; p14.text = "价格:"; p15.text = "价格:"; p16.text = "价格:"; p17.text = "价格:"; p18.text = "价格:"; p19.text = "价格:"; p20.text = "价格:"; p21.text = "价格:";

        p1.font = notoSansChineseBold; p2.font = notoSansChineseBold; p3.font = notoSansChineseBold; p4.font = notoSansChineseBold; p5.font = notoSansChineseBold; p6.font = notoSansChineseBold;
        p7.font = notoSansChineseBold; p8.font = notoSansChineseBold; p9.font = notoSansChineseBold; p10.font = notoSansChineseBold; p11.font = notoSansChineseBold; p12.font = notoSansChineseBold;
        p13.font = notoSansChineseBold; p14.font = notoSansChineseBold; p15.font = notoSansChineseBold; p16.font = notoSansChineseBold; p17.font = notoSansChineseBold; p18.font = notoSansChineseBold;
        p19.font = notoSansChineseBold; p20.font = notoSansChineseBold; p21.font = notoSansChineseBold;

        plussCoins = " 每次成功翻转都有硬币！";
        plussthousandCoins = " 千每次成功翻转都有硬币!";
        plussMillionCoins = " 百万每次成功翻转都有硬币!";
        plussBillionCoins = " 十亿每次成功翻转都有硬币!";
        plussTrillionCoins = " 兆每次成功翻转都有硬币!";
        plussQuadrillionCoins = " 京每次成功翻转都有硬币!";
        plussQuintillionCoins = " 垓每次成功翻转都有硬币!";
        plussSextillionCoins = " 秭每次成功翻转都有硬币!";
        plussSeptillionCoins = " 穰每次成功翻转都有硬币!";

        pluss1.font = notoSansChineseBold; pluss2.font = notoSansChineseBold; pluss3.font = notoSansChineseBold; pluss4.font = notoSansChineseBold; pluss5.font = notoSansChineseBold; pluss6.font = notoSansChineseBold;
        pluss7.font = notoSansChineseBold; pluss8.font = notoSansChineseBold; pluss9.font = notoSansChineseBold; pluss10.font = notoSansChineseBold; pluss11.font = notoSansChineseBold; pluss12.font = notoSansChineseBold;
        pluss13.font = notoSansChineseBold; pluss14.font = notoSansChineseBold; pluss15.font = notoSansChineseBold;

        pluss1.fontSize = 15; pluss2.fontSize = 15; pluss3.fontSize = 15; pluss4.fontSize = 15; pluss5.fontSize = 15; pluss6.fontSize = 15; pluss7.fontSize = 15; pluss8.fontSize = 15; pluss9.fontSize = 15;
        pluss10.fontSize = 15; pluss11.fontSize = 15; pluss12.fontSize = 15; pluss13.fontSize = 15; pluss14.fontSize = 15; pluss15.fontSize = 15;

        gamblePreventCheating.text = "(每次赌博都会保存游戏，以防止作弊)"; gamblePreventCheating.font = notoSansChineseBold;
        gambleReset.text = "尝试数次将在膨胀期间重置"; gambleReset.font = notoSansChineseBold;
        gambleTries.font = priceTextEng; gambleChanceToWin.font = notoSansChineseBold; gambleChanceToLoose.font = notoSansChineseBold; pileGenerates.font = notoSansChineseBold;
        pileMinus1Second.text = "-每次购买减少1秒"; pileMinus1Second.font = notoSansChineseBold; chanceToHitHeads.font = notoSansChineseBold; chanceToHitTails.font = notoSansChineseBold;
        chanceToHitLuckyCoin.font = notoSansChineseBold; endlessInflationPercent.font = notoSansChineseBold; endlessInflationCoin.font = notoSansChineseBold; plussUpgradedCoinFlipper.font = notoSansChineseBold;
        plussUpgradedCoinFlipper.text = "+1 升级掷币器"; plussUpgradedCoinFlipper.fontSize = 20;

        gambleChanceToWin.text = PurchaseLog.gambleChanceEachTimeWIN + "%的机会使你的所有硬币翻倍"; gambleChanceToLoose.text = PurchaseLog.gambleChanceEachTimeLOOSE + "%的机会失去所有硬币";
        chanceToHitHeads.text = higherChanceHoverover.headsPercent + "%的概率可击中正面"; chanceToHitTails.text = higherChanceHoverover.tailsPercent + "%的机会可击中反面";
        chanceToHitLuckyCoin.text = GetLuckyHoverOver.luckyChance + "%的机会击中幸运硬币";
        endlessInflationPercent.text = EndlessInflation.endlessInflationPrice + "% 的硬币!"; endlessInflationCoin.text = EndlessInflation.endlessInflationPrice + " 个膨胀硬币";
        chanceToHitLuckyCoin.fontSize = 13.5f; chanceToHitHeads.fontSize = 15f; chanceToHitTails.fontSize = 15f;
        pileGenerates.text = "每 " + PileOfCoinsMechanics.waitTime + " 秒产生硬币!"; pileGenerates.fontSize = 11;

        gambleWinChance = "% 的机会使你的所有硬币翻倍"; gambleLoseChance = "% 的机会失去所有硬币"; gambleTriesString = "尝试: ";
        pileGeneratesEveyXSecond = "每 "; seconds = " 秒产生硬币!";
        higherChanceTails = "%的机会可击中反面"; higherChanceHeads = "%的概率可击中正面"; luckyCoinChance = "%的机会击中幸运硬币";
        endlessInflationCost = " 膨胀硬币"; endlessInflationPercentString = "% 的硬币!"; needs21Flippers = "你需要21个掷币器!";

        gambleTriesStringText.text = "尝试: " + PurchaseLog.gambleChances; gambleTriesStringText.font = notoSansChinese;
        gambleResultText.font = notoSansChinese;
        #endregion

        #region STATS

        inflateOnceToSeeStats.text = "膨胀一次以查看统计信息"; inflateOnceToSeeStats.font = notoSansChineseBold; inflateOnceToSeeStats.fontSize = 20;

        //GeneralStats
        coin = "硬币";
        youHaveFlipped = "你掷了"; youHaveFlippedText.font = notoSansChinese;
        youHaveActivelyFlipped = "您已主动掷了"; youHaveActivelyFlippedText.font = notoSansChinese;
        totalCoinsOnHeads = "个硬币掷中“正面"; totalCoinsOnHeadsText.font = notoSansChinese;
        totalCoinsOnTails = "抛硬币“反面"; totalCoinsOnTailsText.font = notoSansChinese;
        totalLockyCoins = "个硬币掷中了“幸运”硬币"; totalLockyCoinsText.font = notoSansChinese;

        stats.text = "统计资料"; general.text = "一般情况"; upgrades.text = "升级"; completedChallenges.text = "完成的挑战"; inflation.text = "膨胀"; specialUpgrades.text = "特殊升级";
        specialUpgrades.font = notoSansChinese;
        stats.font = notoSansChineseBold; general.font = notoSansChinese; upgrades.font = notoSansChinese; completedChallenges.font = notoSansChinese; inflation.font = notoSansChinese;

        //UpgradesText
        buyUpgrade = "购买升级以查看统计资料";
        your = "你的";
        statsStrongerArm = "个强壮手臂升级为你提供";
        statsGreater = "个大币升级为你提供";
        statsKnowledge = "个知识升级为你提供";
        statsFist = "个强壮拳头升级为你提供";
        statsInjection = "个 \"手部注射 \"升级为你提供";
        statsBrain = "个脑力升级为你提供";
        statsExplosive = "个爆炸掷币升级为你提供";
        statsHydration = "个补水升级为你提供";
        statsPorion = "个奇怪药水升级为你提供";
        statsMaster = "个掷币大师升级为你提供";
        statsHandshake = "个握手升级为你提供";
        statsHighFive = "个 \"击掌 \"升级为你提供";
        statsMagic = "个 \"魔法掷币 \"升级为你提供";
        statsTreasure = "个宝箱升级为你提供";
        statsRitual = "个 \"掷币仪式 \"升级为你提供";

        statsStrongerArmText.text = LocalizationStrings.your + MoreCoinsButton.moreCoinsUpgrades + LocalizationStrings.statsStrongerArm + FormatCoins(PurchaseLog.strongerHandsTextInfo) + LocalizationStrings.coins; statsStrongerArmText.font = notoSansChinese;

        statsGreaterText.font = notoSansChinese; statsKnowledgeText.font = notoSansChinese; statsFistText.font = notoSansChinese; statsInjectionText.font = notoSansChinese; statsBrainText.font = notoSansChinese; statsExplosiveText.font = notoSansChinese;
        statsHydrationText.font = notoSansChinese; statsPorionText.font = notoSansChinese; statsMasterText.font = notoSansChinese; statsHandshakeText.font = notoSansChinese; statsHighFiveText.font = notoSansChinese;
        statsMagicText.font = notoSansChinese; statsTreasureText.font = notoSansChinese; statsRitualText.font = notoSansChinese;

        if (MoreCoinsButton.greaterCoinsCount == 0) { statsGreaterText.text = buyUpgrade; }
        if (MoreCoinsButton.greaterCoinsCount > 0)
        {
            statsGreaterText.text = LocalizationStrings.your + MoreCoinsButton.greaterCoinsCount + LocalizationStrings.statsGreater + FormatCoins(PurchaseLog.greaterTextInfo) + LocalizationStrings.coins;
        }
        if (KnowledgeUpgrade.knowledgeUpgradeCount == 0) { statsKnowledgeText.text = buyUpgrade; }
        if (KnowledgeUpgrade.knowledgeUpgradeCount > 0)
        {
            statsKnowledgeText.text = LocalizationStrings.your + KnowledgeUpgrade.knowledgeUpgradeCount + LocalizationStrings.statsKnowledge + FormatCoins(PurchaseLog.knowledgeInfo) + LocalizationStrings.coins;
        }
        if (StrongerFist.fistUpgradeCount == 0) { statsFistText.text = buyUpgrade; }
        if (StrongerFist.fistUpgradeCount > 0)
        {
            statsFistText.text = LocalizationStrings.your + StrongerFist.fistUpgradeCount + LocalizationStrings.statsFist + FormatCoins(PurchaseLog.fistInfo) + LocalizationStrings.coins;
        }
        if (HandInecjtion.injectionUpgradeCount == 0) { statsInjectionText.text = buyUpgrade; }
        if (HandInecjtion.injectionUpgradeCount > 0)
        {
            statsInjectionText.text = LocalizationStrings.your + HandInecjtion.injectionUpgradeCount + LocalizationStrings.statsInjection + FormatCoins(PurchaseLog.injectionInfo) + LocalizationStrings.coins;
        }
        if (BrainPower.brainPowerUpgradeCount == 0) { statsBrainText.text = buyUpgrade; }
        if (BrainPower.brainPowerUpgradeCount > 0)
        {
            statsBrainText.text = LocalizationStrings.your + BrainPower.brainPowerUpgradeCount + LocalizationStrings.statsBrain + FormatCoins(PurchaseLog.brainPowerInfo) + LocalizationStrings.coins;
        }
        if (ExplosiveFlips.explosiveUpgradeCount == 0) { statsExplosiveText.text = buyUpgrade; }
        if (ExplosiveFlips.explosiveUpgradeCount > 0)
        {
            statsExplosiveText.text = LocalizationStrings.your + ExplosiveFlips.explosiveUpgradeCount + LocalizationStrings.statsExplosive + FormatCoins(PurchaseLog.explosiveInfo) + LocalizationStrings.coins;
        }
        if (HydrationButton.hydrationUpgradeCount == 0) { statsHydrationText.text = buyUpgrade; }
        if (HydrationButton.hydrationUpgradeCount > 0)
        {
            statsHydrationText.text = LocalizationStrings.your + HydrationButton.hydrationUpgradeCount + LocalizationStrings.statsHydration + FormatCoins(PurchaseLog.hydrationInfo) + LocalizationStrings.coins;
        }
        if (StrangePotion.potionUpgradeCount == 0) { statsPorionText.text = buyUpgrade; }
        if (StrangePotion.potionUpgradeCount > 0)
        {
            statsPorionText.text = LocalizationStrings.your + StrangePotion.potionUpgradeCount + LocalizationStrings.statsPorion + FormatCoins(PurchaseLog.potionInfo) + LocalizationStrings.coins;
        }
        if (MasterFlipper.MasterFlipsUpgradeCount == 0) { statsMasterText.text = buyUpgrade; }
        if (MasterFlipper.MasterFlipsUpgradeCount > 0)
        {
            statsMasterText.text = LocalizationStrings.your + MasterFlipper.MasterFlipsUpgradeCount + LocalizationStrings.statsMaster + FormatCoins(PurchaseLog.masterFlipperInfo) + LocalizationStrings.coins;
        }
        if (HandShake.handShakeUpgradeCount == 0) { statsHandshakeText.text = buyUpgrade; }
        if (HandShake.handShakeUpgradeCount > 0)
        {
            statsHandshakeText.text = LocalizationStrings.your + HandShake.handShakeUpgradeCount + LocalizationStrings.statsHandshake + FormatCoins(PurchaseLog.handShakeInfo) + LocalizationStrings.coins;
        }
        if (Upgrade12.upgrade12Count == 0) { statsHighFiveText.text = buyUpgrade; }
        if (Upgrade12.upgrade12Count > 0)
        {
            statsHighFiveText.text = LocalizationStrings.your + Upgrade12.upgrade12Count + LocalizationStrings.statsHighFive + FormatCoins(PurchaseLog.upgrade12Info) + LocalizationStrings.coins;
        }
        if (MagicFlipsUpgrade.magicUpgradeCount == 0) { statsMagicText.text = buyUpgrade; }
        if (MagicFlipsUpgrade.magicUpgradeCount >= 1)
        {
            statsMagicText.text = LocalizationStrings.your + MagicFlipsUpgrade.magicUpgradeCount + LocalizationStrings.statsMagic + FormatCoins(PurchaseLog.magicFlipsInfo) + LocalizationStrings.coins;
        }
        if (TreasureChest.treasureCount == 0) { statsTreasureText.text = buyUpgrade; }
        if (TreasureChest.treasureCount >= 1)
        {
            statsTreasureText.text = LocalizationStrings.your + TreasureChest.treasureCount + LocalizationStrings.statsTreasure + FormatCoins(PurchaseLog.treasureInfo) + LocalizationStrings.coins;
        }
        if (RitualUpgrade.treasureCount == 0) { statsRitualText.text = buyUpgrade; }
        if (RitualUpgrade.treasureCount >= 1)
        {
            statsRitualText.text = LocalizationStrings.your + RitualUpgrade.treasureCount + LocalizationStrings.statsRitual + FormatCoins(PurchaseLog.ritualInfo) + LocalizationStrings.coins;
        }

        statsStrongerArmText.fontSize = 15; statsGreaterText.fontSize = 15; statsKnowledgeText.fontSize = 15; statsFistText.fontSize = 15; statsInjectionText.fontSize = 15;
        statsBrainText.fontSize = 15; statsExplosiveText.fontSize = 15; statsHydrationText.fontSize = 15; statsPorionText.fontSize = 15; statsMasterText.fontSize = 15;
        statsHandshakeText.fontSize = 15; statsHighFiveText.fontSize = 15; statsMagicText.fontSize = 15; statsTreasureText.fontSize = 15; statsRitualText.fontSize = 15;

        //SpecialUpgradesText
        times = "次"; youHitExtraLucky = "你赢得了一个额外幸运硬币"; youGambled = "你已经赌博了"; lostGambling = "你在赌博中输掉了所有的硬币，共";
        wonGambling = "您在赌博中翻倍了所有的硬币，共"; clickedPile = "您点击了\"硬币堆\""; pileTotalGenerated = "硬币堆总共产生了";
        completeChal1 = "完成挑战1以查看奖励"; completeChal2 = "完成挑战2以查看奖励";
        completeChal3 = "完成挑战3以查看奖励"; completeChal4 = "完成挑战4以查看奖励";
        chal1Completed = "挑战1奖励：解锁“掷全部硬币”按钮"; chal2completed = "挑战2奖励：前5个掷币肯定会成功";
        chal3completed = "挑战3奖励：第一个掷币器给出500％的额外硬币"; chal4completed = "挑战4奖励：获取最大15％的幸运硬币机会"; ;
        statsHeadsChanceText.text = higherChanceHoverover.headsPercent + LocalizationStrings.higherChanceHeads; statsHeadsChanceText.font = notoSansChinese;
        statsTailsChanceText.text = higherChanceHoverover.tailsPercent + LocalizationStrings.higherChanceTails; statsTailsChanceText.font = notoSansChinese;
        statsLuckyChanceText.text = GetLuckyHoverOver.luckyChance + LocalizationStrings.luckyCoinChance; statsLuckyChanceText.font = notoSansChinese;
        youHitExtraLuckyText.font = notoSansChinese;
        clickedPileText.text = LocalizationStrings.clickedPile + PileOfCoinsMechanics.incrementPileOfCoinsAmount + LocalizationStrings.times;
        youGambledText.text = LocalizationStrings.youGambled + (0 + PurchaseLog.amountOfTimesGambled) + LocalizationStrings.times; youGambledText.font = notoSansChinese; 
        lostGamblingText.font = notoSansChinese; lostGamblingText.text = LocalizationStrings.lostGambling + (0 + PurchaseLog.amountOfTimesGambledLOST) + LocalizationStrings.times;
        wonGamblingText.font = notoSansChinese; wonGamblingText.text = LocalizationStrings.wonGambling + (0 + PurchaseLog.amountOfTimesGambledWON) + LocalizationStrings.times;
        clickedPileText.font = notoSansChinese;
        pileTotalGeneratedText.font = notoSansChinese;

        completeChal1Text.font = notoSansChinese; completeChal2Text.font = notoSansChinese; completeChal3Text.font = notoSansChinese; completeChal4Text.font = notoSansChinese;

        completeChal1Text.fontSize = 16.6f; completeChal2Text.fontSize = 16.6f; completeChal3Text.fontSize = 16.6f; completeChal4Text.fontSize = 16.6f;

        if (Challenges.completedChallenge1 == 0) { completeChal1Text.text = completeChal1; }
        if (Challenges.completedChallenge1 == 1) { completeChal1Text.text = chal1Completed; }
        if (Challenges.completedChallenge2 == 0) { completeChal2Text.text = completeChal2; }
        if (Challenges.completedChallenge2 == 1) { completeChal2Text.text = chal2completed; }
        if (Challenges.completedChallenge3 == 0) { completeChal3Text.text = completeChal3; }
        if (Challenges.completedChallenge3 == 1) { completeChal3Text.text = chal3completed; }
        if (Challenges.completedChallenge4 == 0) { completeChal4Text.text = completeChal4; }
        if (Challenges.completedChallenge4 == 1) { completeChal4Text.text = chal4completed; }

        moreCoins = "%的额外硬币"; cheaper = "%便宜"; less = "%便宜"; coinsAfterInflating = "膨胀后您将拥有"; moreCoinsAfterInflating = "个硬币";

        inflateUpgradesStats = "升级可以让您获得"; inflateEndlessStats = "无限膨胀"; inflateCheaperStats = "升级"; inflateSpecialCheaperStats = "特殊升级";
        inflateActiveStats = "自动掷币可以让您获得"; inflateStartWithCoinsStats = "硬币"; inflatePileOfBagsStats = "堆叠袋子充气后可获得额外的";

        inflateEndlessStatsTEXT.text = LocalizationStrings.inflateEndlessStats + EndlessInflation.englessInflationBonusText + LocalizationStrings.moreCoins;
        inflateSpecialCheaperStatsTEXT.text = LocalizationStrings.inflateSpecialCheaperStats + (AscendScreen.totalSpecialReduction) + LocalizationStrings.less;
        inflateStartWithCoinsStatsTEXT.text = LocalizationStrings.inflateStartWithCoinsStats + AscendScreen.starWithCoinsAmount + LocalizationStrings.coinsAfterInflating;
        inflateUpgradesStatsTEXT.text = LocalizationStrings.inflateUpgradesStats + AscendScreen.moreCoinsUpgradePercent + LocalizationStrings.moreCoins;
        inflateCheaperStatsTEXT.text = LocalizationStrings.inflateCheaperStats + AscendScreen.cheaperUpgradesPercent + LocalizationStrings.cheaper;
        inflateActiveStatsTEXT.text = LocalizationStrings.inflateActiveStats + AscendScreen.activeFlipperPercent + LocalizationStrings.moreCoins;
        inflatePileOfBagsStatsTEXT.text = LocalizationStrings.inflatePileOfBagsStats + PileOfCoinsMechanics.PileBagAmount + LocalizationStrings.moreCoinsAfterInflating;

        inflateEndlessStatsTEXT.font = notoSansChinese; inflateSpecialCheaperStatsTEXT.font = notoSansChinese; inflateStartWithCoinsStatsTEXT.font = notoSansChinese; inflateUpgradesStatsTEXT.font = notoSansChinese;
        inflateCheaperStatsTEXT.font = notoSansChinese; inflateActiveStatsTEXT.font = notoSansChinese; inflatePileOfBagsStatsTEXT.font = notoSansChinese;

        inflateEndlessStatsTEXT.fontSize = 18; inflateSpecialCheaperStatsTEXT.fontSize = 18; inflateStartWithCoinsStatsTEXT.fontSize = 18; inflateUpgradesStatsTEXT.fontSize = 18;
        inflateCheaperStatsTEXT.fontSize = 18; inflateActiveStatsTEXT.fontSize = 18; inflatePileOfBagsStatsTEXT.fontSize = 18;

        if (AscendScreen.boughtRich1 == 0) { inflateUpgradesStatsTEXT.text = LocalizationStrings.inflateUpgradesStats + "0" + LocalizationStrings.moreCoins; }
        if (AscendScreen.boughtSale1 == 0) { inflateCheaperStatsTEXT.text = LocalizationStrings.inflateCheaperStats + "0" + cheaper; }
        if (AscendScreen.boughtBagOfCoins1 == 0) { inflateStartWithCoinsStatsTEXT.text = LocalizationStrings.inflateStartWithCoinsStats + "0" + LocalizationStrings.coinsAfterInflating; }
        if (AscendScreen.boughtActiveFlipper1 == 0) { inflateActiveStatsTEXT.text = LocalizationStrings.inflateActiveStats + "0" + LocalizationStrings.moreCoins; }



        #endregion

        #region achievements

        achievements.text = "成就"; achievements.font = notoSansChineseBold;
        ach1.text = "获得1个硬币"; ach1.font = notoSansChineseBold;
        ach2.text = "获得10个硬币"; ach2.font = notoSansChineseBold;
        ach3.text = "获得100个硬币"; ach3.font = notoSansChineseBold;
        ach4.text = "获得1000个硬币"; ach4.font = notoSansChineseBold;
        ach5.text = "获得10000个硬币"; ach5.font = notoSansChineseBold;
        ach6.text = "获得100000个硬币"; ach6.font = notoSansChineseBold;
        ach7.text = "获得1百万个硬币"; ach7.font = notoSansChineseBold;
        ach8.text = "获得10亿个硬币"; ach8.font = notoSansChineseBold;
        ach9.text = "获得1兆个硬币"; ach9.font = notoSansChineseBold;
        ach10.text = "获得1京个硬币"; ach10.font = notoSansChineseBold;
        ach11.text = "获得1垓个硬币"; ach11.font = notoSansChineseBold;
        ach12.text = "获得1秭个硬币"; ach12.font = notoSansChineseBold;
        ach13.text = "获得1穰个硬币"; ach13.font = notoSansChineseBold;
        ach14.text = "获得1沟个硬币"; ach14.font = notoSansChineseBold;
        ach15.text = "升级强壮臂力1次"; ach15.font = notoSansChineseBold;
        ach16.text = "升级强壮臂力10次"; ach16.font = notoSansChineseBold;
        ach17.text = "升级大币1次"; ach17.font = notoSansChineseBold;
        ach18.text = "升级大币10次"; ach18.font = notoSansChineseBold;
        ach19.text = "升级知识1次"; ach19.font = notoSansChineseBold;
        ach20.text = "升级知识10次"; ach20.font = notoSansChineseBold;
        ach21.text = "升级强壮拳头1次"; ach21.font = notoSansChineseBold;
        ach22.text = "升级强壮拳头10次"; ach22.font = notoSansChineseBold;
        ach23.text = "升级手部注射次"; ach23.font = notoSansChineseBold;
        ach24.text = "升级手部注射10次"; ach24.font = notoSansChineseBold;
        ach25.text = "升级脑量1次"; ach25.font = notoSansChineseBold;
        ach26.text = "升级脑量10次"; ach26.font = notoSansChineseBold;
        ach27.text = "升级爆炸掷币1次"; ach27.font = notoSansChineseBold;
        ach28.text = "升级爆炸掷币10次"; ach28.font = notoSansChineseBold;
        ach29.text = "升级补水1次"; ach29.font = notoSansChineseBold;
        ach30.text = "升级补水10次"; ach30.font = notoSansChineseBold;
        ach31.text = "升级奇怪药水1次"; ach31.font = notoSansChineseBold;
        ach32.text = "升级奇怪药水10次"; ach32.font = notoSansChineseBold;
        ach33.text = "升级掷币大师1次"; ach33.font = notoSansChineseBold;
        ach34.text = "升级掷币大师10次"; ach34.font = notoSansChineseBold;
        ach35.text = "升级握手1次"; ach35.font = notoSansChineseBold;
        ach36.text = "升级握手10次"; ach36.font = notoSansChineseBold;
        ach37.text = "升级魔术翻转1次"; ach37.font = notoSansChineseBold; ach37.fontSize = 8.4f;
        ach38.text = "升级魔术翻转10次"; ach38.font = notoSansChineseBold; ach38.fontSize = 8.4f;
        ach39.text = "有2.5%的几率获得幸运硬币"; ach39.font = notoSansChineseBold;
        ach40.text = "有5%的几率获得幸运硬币"; ach40.font = notoSansChineseBold;
        ach41.text = "获得1个幸运硬币"; ach41.font = notoSansChineseBold;
        ach42.text = "获得10个幸运硬币"; ach42.font = notoSansChineseBold;
        ach43.text = "获得100个幸运硬币"; ach43.font = notoSansChineseBold;
        ach44.text = "掷100个硬币"; ach44.font = notoSansChineseBold;
        ach45.text = "掷1000个硬币"; ach45.font = notoSansChineseBold;
        ach46.text = "掷10000个硬币"; ach46.font = notoSansChineseBold;
        ach47.text = "掷100000个硬币"; ach47.font = notoSansChineseBold;
        ach49.text = "同时掷出2个硬币"; ach49.font = notoSansChineseBold;
        ach50.text = "同时掷出5个硬币"; ach50.font = notoSansChineseBold;
        ach51.text = "同时掷10个硬币"; ach51.font = notoSansChineseBold;
        ach94.text = "同时掷21个硬币"; ach94.font = notoSansChineseBold;
        ach52.text = "升级1个掷币器"; ach52.font = notoSansChineseBold;
        ach53.text = "升级5个掷币器"; ach53.font = notoSansChineseBold;
        ach54.text = "升级10个掷币器"; ach54.font = notoSansChineseBold;
        ach55.text = "升级21个掷币器"; ach55.font = notoSansChineseBold;
        ach56.text = "有75%的几率成功掷币"; ach56.font = notoSansChineseBold;
        ach57.text = "有93.75%的几率成功掷币"; ach57.font = notoSansChineseBold;
        ach58.text = "掷所有硬币!"; ach58.font = notoSansChineseBold;
        ach59.text = "掷100万个硬币"; ach59.font = notoSansChineseBold;
        ach60.text = "获得1000次幸运硬币!"; ach60.font = notoSansChineseBold;
        ach61.text = "获得100000次反面!"; ach61.font = notoSansChineseBold;
        ach62.text = "获得100000次正面!"; ach62.font = notoSansChineseBold;
        ach63.text = "完成挑战＃1"; ach63.font = notoSansChineseBold;
        ach64.text = "完成挑战＃2"; ach64.font = notoSansChineseBold;
        ach65.text = "完成挑战＃3"; ach65.font = notoSansChineseBold;
        ach66.text = "完成挑战＃4"; ach66.font = notoSansChineseBold;
        ach67.text = "解锁自动升级"; ach67.font = notoSansChineseBold;
        ach68.text = "自动掷币100次"; ach68.font = notoSansChineseBold;
        ach69.text = "自动掷币1000次"; ach69.font = notoSansChineseBold;
        ach70.text = "自动掷币5000次"; ach70.font = notoSansChineseBold;
        ach71.text = "升级百宝箱1次"; ach71.font = notoSansChineseBold;
        ach72.text = "升级百宝箱10次"; ach72.font = notoSansChineseBold;
        ach73.text = "升级抛硬币仪式1次"; ach73.font = notoSansChineseBold;
        ach74.text = "升级抛硬币仪式10次"; ach74.font = notoSansChineseBold;
        ach75.text = "升级举手击掌10次"; ach75.font = notoSansChineseBold;
        ach76.text = "升级举手击掌10次"; ach76.font = notoSansChineseBold;
        ach77.text = "总共拥有25个膨胀硬币"; ach77.font = notoSansChineseBold;
        ach78.text = "总共拥有50个膨胀硬币"; ach78.font = notoSansChineseBold;
        ach79.text = "总共拥有75个膨胀硬币"; ach79.font = notoSansChineseBold;
        ach80.text = "解锁5个膨胀升级"; ach80.font = notoSansChineseBold;
        ach81.text = "解锁10个膨胀升级"; ach81.font = notoSansChineseBold;
        ach82.text = "解锁20个膨胀升级"; ach82.font = notoSansChineseBold;
        ach83.text = "解锁30个膨胀升级"; ach83.font = notoSansChineseBold;
        ach84.text = "解锁所有膨胀升级"; ach84.font = notoSansChineseBold;
        ach85.text = "点击硬币堆10次"; ach85.font = notoSansChineseBold;
        ach86.text = "点击硬币堆100次"; ach86.font = notoSansChineseBold;
        ach87.text = "膨胀!"; ach87.font = notoSansChineseBold;
        ach88.text = "膨胀5次!"; ach88.font = notoSansChineseBold;
        ach89.text = "赌博10次"; ach89.font = notoSansChineseBold;
        ach90.text = "你输了所有硬币5次:("; ach90.font = notoSansChineseBold;
        ach91.text = "你翻倍了所有硬币5次:)"; ach91.font = notoSansChineseBold;
        ach92.text = "找到隐藏的铜硬币!"; ach92.font = notoSansChineseBold;
        ach93.text = "找到隐藏的银硬币!"; ach93.font = notoSansChineseBold;


        #endregion

        #region InflationTree

        inflate.text = "膨胀"; inflate.font = notoSansChineseBold; inflate.fontSize = 20;
        youHave21Flippers.text = "你需要21个掷币器才能膨胀"; youHave21Flippers.font = notoSansChineseBold;
        youNeed21Flippers.text = "你有21个掷币器"; youNeed21Flippers.font = notoSansChineseBold; youNeed21Flippers.fontSize = 17.7f;
        youCanViewTreeAtAnyTime.text = "(你可以随时查看膨胀树)"; youCanViewTreeAtAnyTime.font = notoSansChineseBold;
        youCanViewTreeAtAnyTime.fontSize = 14;
        smallInflationDescription.text = "膨胀将重置您的所有统计数据（有少数例外），并带您进入一个屏幕，其中包含独特的永久升级。一旦你购买完膨胀升级，游戏将从头开始"; smallInflationDescription.font = notoSansChinese;
        smallInflationDescription.fontSize = 15;
        thisIsHowInflationWorks.text = "这就是膨胀系统的运作方式:"; thisIsHowInflationWorks.font = notoSansChineseBold;
        bigInflationDescription.text = "-每当您到达下一个硬币层级的四分之一时，您将获得膨胀硬币\n-硬币的层级为：百万，十亿，兆，京等等\n-例如：一旦您达到1百万，就会开始获得膨胀硬币。然后，当您达到以下时，将授予您膨胀硬币：1百万，2.5亿，5亿，7.5亿，10亿，2500亿，5000亿，7500亿等\n-每次获得膨胀硬币时，您获得的基础膨胀数为1, 购买“更大的膨胀”升级，可以在游戏中获得更多的膨胀币"; bigInflationDescription.font = notoSansChineseBold; bigInflationDescription.fontSize = 7.6f;
        youHave.text = "你有"; youHave.font = notoSansChineseBold;
        inflationCoins.text = "个膨胀硬币"; inflationCoins.font = notoSansChineseBold;
        dontInflateJustLook.text = "不要膨胀，只看树"; dontInflateJustLook.font = notoSansChineseBold; dontInflateJustLook.fontSize = 23;
        doYouWishToInflate.text = "你想膨胀吗?"; doYouWishToInflate.font = notoSansChineseBold; doYouWishToInflate.fontSize = 20;
        YES.text = "是"; YES.font = notoSansChinese;
        NO.text = "不"; NO.font = notoSansChinese;
        currentlyOnlyViewingTree.text = "! 你目前只能查看膨胀树，无法购买任何升级";
        currentlyOnlyViewingTree.font = notoSansChinese;
        backToFlipping.text = "返回到掷币!"; backToFlipping.font = notoSansChinese; backToFlipping.fontSize = 28;
        backToFlipping2.text = "返回到掷币!"; backToFlipping2.font = notoSansChineseBold; backToFlipping2.fontSize = 22;
        inflationCoinsText = "膨胀硬币：";
        InflationCoins.text = inflationCoinsText + AscendCoins.ascensionCoinAmount; InflationCoins.fontSize = 23; InflationCoins.font = notoSansChineseBold;

        rich1.text = "富有 一"; rich1.font = notoSansChineseBold;
        rich2.text = "富有 二"; rich2.font = notoSansChineseBold;
        rich3.text = "富有 三"; rich3.font = notoSansChineseBold;
        rich4.text = "富有 四"; rich4.font = notoSansChineseBold;
        rich5.text = "富有 五"; rich5.font = notoSansChineseBold;
        rich6.text = "富有 六"; rich6.font = notoSansChineseBold;
        rich7.text = "富有 七"; rich7.font = notoSansChineseBold;
        omegaRich.text = "无敌富有"; omegaRich.font = notoSansChineseBold;

        rich1Desc.text = "所有的升级都会给你增加1%的金币.\n富有升级适用于每一个挑战"; rich1Desc.font = notoSansChineseBold;
        rich1Desc.fontSize = 15;
        rich2Desc.text = "所有的升级都会给你增加20%的金币"; rich2Desc.font = notoSansChineseBold;
        rich3Desc.text = "所有的升级都会给你增加50%的金币"; rich3Desc.font = notoSansChineseBold;
        rich4Desc.text = "所有的升级都会给你增加100%的金币"; rich4Desc.font = notoSansChineseBold;
        rich5Desc.text = "所有的升级都会给你增加175%的金币"; rich5Desc.font = notoSansChineseBold;
        rich6Desc.text = "所有的升级都会给你增加300%的金币"; rich6Desc.font = notoSansChineseBold;
        rich7Desc.text = "所有的升级都会给你增加750%的金币"; rich7Desc.font = notoSansChineseBold;
        omegaRichDes.text = "所有的升级都会给你增加1250%的金币"; omegaRichDes.font = notoSansChineseBold;

        sale1.text = "促销 一"; sale1.font = notoSansChineseBold;
        sale2.text = "促销 二"; sale2.font = notoSansChineseBold;
        sale3.text = "促销 三"; sale3.font = notoSansChineseBold;
        sale4.text = "促销 四"; sale4.font = notoSansChineseBold;
        steamSale.text = "STEAM促销"; steamSale.font = notoSansChineseBold; steamSale.fontSize = 22;
        sale1Desc.text = "所有升级都会降低2%的费用. 此升级分支不影响特殊升级."; sale1Desc.font = notoSansChineseBold; sale1Desc.fontSize = 14;
        sale2Desc.text = "所有升级都会降低7%的费用"; sale2Desc.font = notoSansChineseBold;
        sale3Desc.text = "所有升级都会降低14%的费用"; sale3Desc.font = notoSansChineseBold;
        sale4Desc.text = "所有升级都会降低22%的费用"; sale4Desc.font = notoSansChineseBold;
        steamSaleDesc.text = "所有升级都会降低50%的费用"; steamSaleDesc.font = notoSansChineseBold;

        bag1.text = "一袋硬币 一"; bag1.font = notoSansChineseBold;
        bag2.text = "一袋硬币 二"; bag2.font = notoSansChineseBold;
        bag3.text = "一袋硬币 三"; bag3.font = notoSansChineseBold;
        bag4.text = "一袋硬币 四"; bag4.font = notoSansChineseBold;
        hugeBag.text = "一袋硬币 五"; hugeBag.font = notoSansChineseBold;
        pileOfBags.text = "一堆袋子"; pileOfBags.font = notoSansChineseBold;

        bag1Desc.text = "您可以在使用膨胀后获得75个硬币\n一袋硬币升级只适用于“无自动掷币”挑战"; bag1Desc.font = notoSansChineseBold;
        bag2Desc.text = "您可以在使用膨胀后获得500个硬币"; bag2Desc.font = notoSansChineseBold;
        bag3Desc.text = "您可以在使用膨胀后获得3000个硬币"; bag3Desc.font = notoSansChineseBold;
        bag4Desc.text = "您可以在使用膨胀后获得20000个硬币"; bag4Desc.font = notoSansChineseBold;
        hugeBasDesc.text = "您可以在使用膨胀后获得100000个硬币"; hugeBasDesc.font = notoSansChineseBold;
        pileOfBagsDesc.text = "每当你点击硬币堆时，在你使用膨胀后的硬币数量上将会增加250个硬币"; pileOfBagsDesc.font = notoSansChineseBold;

        greaterInflation1.text = "大通膨胀 一"; greaterInflation1.font = notoSansChineseBold;
        greaterInflation2.text = "大通膨胀 二"; greaterInflation2.font = notoSansChineseBold;
        greaterInflation3.text = "大通膨胀 三"; greaterInflation3.font = notoSansChineseBold;
        greaterInflation4.text = "大通膨胀 四"; greaterInflation4.font = notoSansChineseBold;
        greaterInflation5.text = "大通膨胀 五"; greaterInflation5.font = notoSansChineseBold;
        crazyInflation.text = "疯狂膨胀!!"; crazyInflation.font = notoSansChineseBold; crazyInflation.fontSize = 17;
        inflationGamble1.text = "膨胀赌博 一"; inflationGamble1.font = notoSansChineseBold; inflationGamble1.fontSize = 17;
        inflationGamble2.text = "膨胀赌博 二"; inflationGamble2.font = notoSansChineseBold; inflationGamble2.fontSize = 17;
        inflationGamble3.text = "膨胀赌博 三"; inflationGamble3.font = notoSansChineseBold; inflationGamble3.fontSize = 17;
        inflationGamble4.text = "膨胀赌博 四"; inflationGamble4.font = notoSansChineseBold; inflationGamble4.fontSize = 17;

        greaterInflation1Desc.text = "当你达到京级时，将获得+2个膨胀硬币\n除“永远幸运”挑战之外，所有膨胀升级都适用于所有挑战"; greaterInflation1Desc.font = notoSansChineseBold;
        greaterInflation2Desc.text = "当你达到京级时，+3个膨胀硬币"; greaterInflation2Desc.font = notoSansChineseBold;
        greaterInflation3Desc.text = "当你达到十亿级时，+2个膨胀币\n当你达到京级时，+3个膨胀币"; greaterInflation3Desc.font = notoSansChineseBold;
        greaterInflation4Desc.text = "当你达到兆级时，+3个膨胀币\n当你达到垓级时，+4个膨胀币"; greaterInflation4Desc.font = notoSansChineseBold;
        greaterInflation5Desc.text = "当你达到兆级时，+4个膨胀币\n当你达到秭级时，+5个膨胀币"; greaterInflation5Desc.font = notoSansChineseBold;
        crazyInflationDesc.text = "当你达到百万级时，+6膨胀硬币"; crazyInflationDesc.font = notoSansChineseBold;
        inflationGamble1Desc.text = "每次获得膨胀硬币时，有+3%的机会获得1个额外的膨胀硬币"; inflationGamble1Desc.font = notoSansChineseBold;
        inflationGamble2Desc.text = "每次获得膨胀硬币时，有+4%的机会获得1个额外的膨胀硬币"; inflationGamble2Desc.font = notoSansChineseBold;
        inflationGamble3Desc.text = "每次获得膨胀硬币时，有+5%的机会获得1个额外的膨胀硬币"; inflationGamble3Desc.font = notoSansChineseBold;
        inflationGamble4Desc.text = "每次获得膨胀硬币时，有+6%的机会获得1个额外的膨胀硬币"; inflationGamble4Desc.font = notoSansChineseBold;

        extraSpecialUpgrade1.text = "特别升级加强版 一"; extraSpecialUpgrade1.font = notoSansChineseBold; extraSpecialUpgrade1.fontSize = 15;
        extraSpecialUpgrade2.text = "特别升级加强版 二"; extraSpecialUpgrade2.font = notoSansChineseBold; extraSpecialUpgrade2.fontSize = 15;
        extraSpecialUpgrade3.text = "特别升级加强版 三"; extraSpecialUpgrade3.font = notoSansChineseBold; extraSpecialUpgrade3.fontSize = 15;
        extraExtraSpecialUpgrade1.text = "额外特别升级加强版"; extraExtraSpecialUpgrade1.font = notoSansChineseBold; extraExtraSpecialUpgrade1.fontSize = 13;
        biggerPile1.text = "更大的硬币堆 一"; biggerPile1.font = notoSansChineseBold;
        biggerPile2.text = "更大的硬币堆 二"; biggerPile2.font = notoSansChineseBold;
        theGambler.text = "赌徒"; theGambler.font = notoSansChineseBold;
        getLuckier.text = "好运降临"; getLuckier.font = notoSansChineseBold;
        autoUpgradeInflate.text = "自动升级"; autoUpgradeInflate.font = notoSansChineseBold;

        extraSpecialUpgrade1Desc.text = "赌博有2次机会\n这个分支中的每个升级都将减少所有特殊升级的价格1％，并适用于每个挑战"; extraSpecialUpgrade1Desc.font = notoSansChineseBold; extraSpecialUpgrade1Desc.fontSize = 12.6f;
        extraSpecialUpgrade2Desc.text = "现在赌博有51％的机会将您的硬币翻倍\n硬币堆产生更多硬币"; extraSpecialUpgrade2Desc.font = notoSansChineseBold;
        extraSpecialUpgrade3Desc.text = "当你从硬币堆中取出硬币时，有5％的机会硬币留在堆里"; extraSpecialUpgrade3Desc.font = notoSansChineseBold;
        extraExtraSpecialUpgrade1Desc.text = "特殊升级成本降低13％\n赌博有多1次机会\n获取2个可以产生硬币的硬币堆\n升级掷币级现在可让您获得3倍的硬币，幸运硬币可使您获得15倍"; extraExtraSpecialUpgrade1Desc.font = notoSansChineseBold;
        extraExtraSpecialUpgrade1Desc.fontSize = 11.6f;
        biggerPile1Desc.text = "硬币堆升级会让您获得一个可以生成硬币的硬币堆\n硬币堆升级会让您获得更多的硬币"; biggerPile1Desc.font = notoSansChineseBold;
        biggerPile2Desc.text = "硬币堆升级会让您获得一个可以生成硬币的硬币堆\n硬币堆升级会让您获得额外更多的硬币"; biggerPile2Desc.font = notoSansChineseBold;
        theGamblerDesc.text = "赌博有多1次机会\n每次赌博时，翻倍硬币的几率会增加1％"; theGamblerDesc.font = notoSansChineseBold;
        getLuckierDesc.text = "每当您掷到一个幸运硬币时，有5％的几率让它成为一个更幸运硬币，让您获得50倍的硬币"; getLuckierDesc.font = notoSansChineseBold; getLuckierDesc.fontSize = 12;
        autoUpgradeDesc.text = "解锁特殊升级选项卡中的自动升级"; autoUpgradeDesc.font = notoSansChineseBold;

        active1.text = "主动掷币 一"; active1.font = notoSansChineseBold; active1.fontSize = 17;
        active2.text = "主动掷币 二"; active2.font = notoSansChineseBold; active2.fontSize = 17;
        active3.text = "主动掷币 三"; active3.font = notoSansChineseBold; active3.fontSize = 17;
        active4.text = "主动掷币 四"; active4.font = notoSansChineseBold; active4.fontSize = 17;
        superActiveFlipper.text = "超级主动掷币"; superActiveFlipper.font = notoSansChineseBold; superActiveFlipper.fontSize = 17;
        activeEqualsBiggerPile.text = "主动掷币=更大的硬币堆"; activeEqualsBiggerPile.font = notoSansChineseBold; activeEqualsBiggerPile.fontSize = 13;

        active1Desc.text = "您主动掷币所获取的每个硬币都会让您获得额外的8%硬币\n主动掷币升级适用于所有挑战"; active1Desc.font = notoSansChineseBold; active1Desc.fontSize = 12;
        active2Desc.text = "您主动掷币所获取的每个硬币都会让您获得额外的23%硬币"; active2Desc.font = notoSansChineseBold;
        active3Desc.text = "您主动掷币所获取的每个硬币都会让您获得额外的40%硬币"; active3Desc.font = notoSansChineseBold;
        active4Desc.text = "您主动掷币所获取的每个硬币都会让您获得额外的69%硬币"; active4Desc.font = notoSansChineseBold;
        superActiveFlipperDesc.text = "您主动掷币所获取的每个硬币都会让您获得额外的300%硬币\n幸运硬币会让您获得10倍硬币"; superActiveFlipperDesc.font = notoSansChineseBold;
        activeEqualsBiggerPileDesc.text = "每次您进行主动掷币时，有5％的几率将正面/反面硬币的硬币数量添加到硬币堆中"; activeEqualsBiggerPileDesc.font = notoSansChineseBold;
        backToFlippingIflated.text = "您是否希望回到掷币的界面？"; backToFlippingIflated.font = notoSansChineseBold;
        yes.text = "是"; yes.font = notoSansChineseBold; no.text = "不"; no.font = notoSansChineseBold;

        for (int i = 0; i < unLocked.Length; i++)
        {
            unLocked[i].text = "封锁";
            unLocked[i].font = notoSansChinese;
            unLocked[i].fontSize = 14;
        }

        for (int i = 0; i < locked.Length; i++)
        {
            locked[i].text = "解锁";
            locked[i].font = notoSansChinese;
            locked[i].fontSize = 12;
        }


        #endregion

        #region settings

        music.text = "音乐"; music.font = notoSansChineseBold; audiotext.text = "音频"; audiotext.font = notoSansChineseBold;
        fullscreen.text = "全屏"; fullscreen.font = notoSansChinese;
        saveGame.text = "保存游戏"; saveGame.font = notoSansChineseBold;
        exitGame.text = "退出游戏"; exitGame.font = notoSansChineseBold; resetEverything.text = "重置一切"; resetEverything.font = notoSansChineseBold;
        gameIsSaved30Seconds.text = "(游戏每30秒保存一次)"; gameIsSaved30Seconds.font = notoSansChineseBold;
        foundHiddenBronze.text = "您找到了一个隐藏的铜币!"; foundHiddenBronze.font = notoSansChineseBold;
        foundHiddenSilver.text = "您找到了一个隐藏的银币!"; foundHiddenSilver.font = notoSansChineseBold;
        settings.text = "设置"; settings.font = notoSansChinese; settings.fontSize = 27;
        info.text = "信息"; info.font = notoSansChinese; info.fontSize = 27;
        socials.text = "社交媒体"; socials.font = notoSansChinese; socials.fontSize = 27;
        generalGameInfo.text = "游戏信息"; generalGameInfo.font = notoSansChinese;
        mechanicsExplanations.text = "机制说明:"; mechanicsExplanations.font = notoSansChinese;

        inflationSystem.text = "膨胀系统"; inflationSystem.font = notoSansChinese;
        inflationSystemDesc.text = "-每当您到达下一个硬币层级的四分之一时，您将获得膨胀硬币\n-硬币的层级为：百万，十亿，兆，京等等\n-例如：一旦您达到1百万，就会开始获得膨胀硬币。然后，当您达到以下时，将授予您膨胀硬币：1百万，2.5亿，5亿，7.5亿，10亿，2500亿，5000亿，7500亿等\n-每次获得膨胀硬币时，您获得的基础膨胀数为1, 购买“更大的膨胀”升级，可以在游戏中获得更多的膨胀币"; inflationSystemDesc.font = notoSansChinese;
        inflationSystemDesc.fontSize = 13;

        pileOfCoinsText.text = "硬币堆:"; pileOfCoinsText.font = notoSansChinese;
        pileOfCoinsDesc.text = "硬币堆将产生的数量是取决于每次掷币获得的硬币数以及您所拥有的掷币器数量+4。因此，如果您在正反面各有150个硬币，并且拥有4个掷币器，则产生的硬币数量将为150*(4+4)，即1200。如果玩家购买了“额外特殊升级”的膨胀升级，则数量将更大."; pileOfCoinsDesc.font = notoSansChinese;
        pileOfCoinsDesc.fontSize = 13;

        offlineProgression.text = "离线进展:"; offlineProgression.font = notoSansChinese;
        offlineProgressionDesc.text = "您将在离线时每分钟获得硬币。数量取决于您拥有的自动掷币器和正反面的硬币数量。因此，如果您在正反面有500,000个硬币并拥有4个自动掷币器，则每分钟将获得2百万硬币."; offlineProgressionDesc.font = notoSansChinese; offlineProgressionDesc.fontSize = 13;

        developerBy.text = "掷币器的开发者: <b>Simon Eftestøl</b>"; developerBy.font = notoSansChinese;
        musicBy.text = "音乐作者: <b>HSB Loops</b>"; musicBy.font = notoSansChinese;
        texturesProvidedBy.text = "提供纹理: <b>Free SVG</b>"; texturesProvidedBy.font = notoSansChinese;
        followMyTwitch.text = "关注我的Twitch!"; followMyTwitch.font = notoSansChinese;
        follotMyTwitter.text = "关注我的X!"; follotMyTwitter.font = notoSansChinese;
        joinTheDiscord.text = "加入Discord!"; joinTheDiscord.font = notoSansChinese;
        quitPlayingChallenge.text = "你想退出这个挑战吗?"; quitPlayingChallenge.font = notoSansChinese;
        quitChallengeDesc.text = "游戏将重置并返回“选择正面或反面”屏幕。 所有永久通货膨胀升级当然不会被重置。"; quitChallengeDesc.font = notoSansChinese;
        quitChalYes.text = "是"; quitChalYes.font = notoSansChineseBold;
        quitChalNo.text = "不"; quitChalNo.font = notoSansChineseBold;
        whishToResetGame.text = "您是否希望完全重新开始?"; whishToResetGame.font = notoSansChinese;
        wishToResetDesc.text = "所有内容都将被重置，游戏将从头开始"; wishToResetDesc.font = notoSansChinese;
        resetYes.text = "是"; resetYes.font = notoSansChineseBold;
        resetNo.text = "不"; resetNo.font = notoSansChineseBold;
        quitChall1.text = "退出挑战"; quitChall1.font = notoSansChineseBold; quitChall1.fontSize = 36;
        quitChall2.text = "退出挑战"; quitChall2.font = notoSansChineseBold; quitChall2.fontSize = 36;
        quitChall3.text = "退出挑战"; quitChall3.font = notoSansChineseBold; quitChall3.fontSize = 36;
        quitChall4.text = "退出挑战"; quitChall4.font = notoSansChineseBold; quitChall4.fontSize = 36;
        gameSaved.text = "游戏已保存"; gameSaved.font = notoSansChinese;
        gameSaved2.text = "游戏已保存"; gameSaved2.font = notoSansChinese;

        #endregion

        #region offlineEarnings

        days = "天"; hours = "小时"; minuts = "分钟"; secondsTime = "秒";

        offlineEarningTotalText.font = notoSansChineseBold;
        timeGoneText.font = notoSansChineseBold;

        welcomeBack.text = "欢迎回来!"; welcomeBack.font = notoSansChineseBold;
        youWereGoneFor.text = "你离开了:"; youWereGoneFor.font = notoSansChinese;
        offlineEarnings.text = "离线收益: "; offlineEarnings.font = notoSansChinese;
        offlineOK.text = "好的"; offlineOK.font = notoSansChineseBold;

        #endregion

        #region FINAL missed

        upgradesHover.text = "升级"; upgradesHover.font = notoSansChineseBold; upgradesHover.fontSize = 36;
        specialUpgradesHover.text = "特殊升级"; specialUpgradesHover.font = notoSansChineseBold; specialUpgradesHover.fontSize = 35;
        achievementsHover.text = "成就"; achievementsHover.font = notoSansChineseBold; achievementsHover.fontSize = 29;
        statsHover.text = "统计资料"; statsHover.font = notoSansChineseBold; statsHover.fontSize = 36;

        specialIpgradeWarning.text = "默认情况下，升级掷币将自动掷币。在购买此升级之前，您必须购买另一个“自动掷币”升级";
        specialIpgradeWarning.font = notoSansChineseBold; specialIpgradeWarning.fontSize = 8;

        congrats1.text = "恭喜你!"; congrats1.font = notoSansChineseBold;
        congrats2.text = "恭喜你!"; congrats2.font = notoSansChineseBold;
        congrats3.text = "恭喜你!"; congrats3.font = notoSansChineseBold;
        congrats4.text = "恭喜你!"; congrats4.font = notoSansChineseBold;
        youUnlocked1.text = "你已解锁:"; youUnlocked1.font = notoSansChineseBold; youUnlocked1.fontSize = 15;
        youUnlocked2.text = "你已解锁:"; youUnlocked2.font = notoSansChineseBold; youUnlocked2.fontSize = 15;
        youUnlocked3.text = "你已解锁:"; youUnlocked3.font = notoSansChineseBold; youUnlocked3.fontSize = 15;
        youUnlocked4.text = "你已解锁:"; youUnlocked4.font = notoSansChineseBold; youUnlocked4.fontSize = 15;
        youCompletedChal1.text = "您完成了挑战#1--\"无自动掷币\""; youCompletedChal1.font = notoSansChineseBold;
        youCompletedChal2.text = "您完成了挑战#2--\"不幸运\""; youCompletedChal2.font = notoSansChineseBold;
        youCompletedChal3.text = "您完成了挑战#3--\"1个掷币器\""; youCompletedChal3.font = notoSansChineseBold;
        youCompletedChal4.text = "您完成了挑战 #4 - \"幸运\""; youCompletedChal4.font = notoSansChineseBold;
        completedChalFlipAll.text = "掷全部"; completedChalFlipAll.font = notoSansChineseBold;
        completedChallAutoFlipsEquals.text = "自动翻转 ="; completedChallAutoFlipsEquals.font = notoSansChineseBold; completedChallAutoFlipsEquals.fontSize = 25;
        onText.text = "开启"; onText.font = notoSansChineseBold;
        onText2.text = "开启"; onText2.font = notoSansChineseBold;
        offText.text = "关闭"; offText.font = notoSansChineseBold;
        chal2CompletedRewardInfo.text = "前5个掷币肯定会成功"; chal2CompletedRewardInfo.font = notoSansChineseBold;
        chal3CompletedRewardInfo.text = "第一个掷币器总会成功，并获得+500%的硬币奖励!";
        chal3CompletedRewardInfo.font = notoSansChineseBold;
        chal4CompletedRewardInfo.text = "掷币现在有多达15％的机会命中幸运硬币"; chal4CompletedRewardInfo.font = notoSansChineseBold;
        chal4CompletedRewardInfo.fontSize = 10;

        totalCoins = "硬币数量: ";
        coinsMainText.text = "硬币数量: " + FormatCoins(GlobalCoins.CoinCount); coinsMainText.font = notoSansChineseBold;

        lockedAuto.text = "封锁"; lockedAuto.font = notoSansChineseBold;
        lockedDuplicate.text = "封锁"; lockedDuplicate.font = notoSansChineseBold;
        lockedLucky.text = "封锁"; lockedLucky.font = notoSansChineseBold;
        lockedHigherChance.text = "封锁"; lockedHigherChance.font = notoSansChineseBold;
        lockedSpecialUpgrade.text = "封锁"; lockedSpecialUpgrade.font = notoSansChineseBold;

        moreCoinsIn = ""; Xseconds = "秒内获得更多硬币";
        moreCoinsIn1.font = notoSansChineseBold;
        moreCoinsIn2.font = notoSansChineseBold;
        moreCoinsIn3.font = notoSansChineseBold;
        moreCoinsIn4.font = notoSansChineseBold;
        moreCoinsIn5.font = notoSansChineseBold;
        plussPile1.text = "+一堆硬币"; plussPile1.font = notoSansChineseBold;
        plussPile2.text = "+一堆硬币"; plussPile2.font = notoSansChineseBold;
        plussPile3.text = "+一堆硬币"; plussPile3.font = notoSansChineseBold;
        plussPile4.text = "+一堆硬币"; plussPile4.font = notoSansChineseBold;
        plussPile5.text = "+一堆硬币"; plussPile5.font = notoSansChineseBold;
        thisPileContains1.text = "这堆里有: "; thisPileContains1.font = notoSansChineseBold;
        thisPileContains2.text = "这堆里有: "; thisPileContains2.font = notoSansChineseBold;
        thisPileContains3.text = "这堆里有: "; thisPileContains3.font = notoSansChineseBold;
        thisPileContains4.text = "这堆里有: "; thisPileContains4.font = notoSansChineseBold;
        thisPileContains5.text = "这堆里有: "; thisPileContains5.font = notoSansChineseBold;
        totalCoinsPile1.font = notoSansChineseBold;
        totalCoinsPile2.font = notoSansChineseBold;
        totalCoinsPile3.font = notoSansChineseBold;
        totalCoinsPile4.font = notoSansChineseBold;
        totalCoinsPile5.font = notoSansChineseBold;

        totalCoinsPile1.text = FormatCoins2(PileOfCoinsMechanics.PileOfCoinsAmount1);
        totalCoinsPile2.text = FormatCoins2(PileOfCoinsMechanics.PileOfCoinsAmount2);
        totalCoinsPile3.text = FormatCoins2(PileOfCoinsMechanics.PileOfCoinsAmount3);
        totalCoinsPile4.text = FormatCoins2(PileOfCoinsMechanics.PileOfCoinsAmount4);
        totalCoinsPile5.text = FormatCoins2(PileOfCoinsMechanics.PileOfCoinsAmount5);

        heads = "正面! ";
        tails = "反面! ";
        luckyCoin = "幸运硬币! ";

        #endregion

        googlePlayText.text = "";
        googlePlayText.font = notoSansChineseBold;

        if (LoadSaves.isMobileBuild == true) { SetMobileTexts(); }
    }
    #endregion


    #region KOREANREGION
    //KOREAN
    public void Korean()
    {
        changeFont = 1;
        ChooseText = 4;
        PlayerPrefs.SetInt("ChosenText", ChooseText);
        #region ChooseScene
        HeadsOrTails.text = "앞면일까요 뒷면일까요?"; HeadsOrTails.font = nonoSansKoreanBold;
        youChoseHeads.text = "앞면을 선택하셨군요!"; youChoseHeads.font = nonoSansKoreanBold;
        youChoseTails.text = "뒷면을 선택하셨군요!"; youChoseTails.font = nonoSansKoreanBold;
        challengesText.text = "챌린지"; challengesText.font = nonoSansKoreanBold;
        challenge1Name.text = "자동 뒤집기 없음"; challenge1Name.font = nonoSansKoreanBold; challenge1Name.fontSize = 29;
        challenge2Name.text = "25% 뒤집기 확률"; challenge2Name.font = nonoSansKoreanBold; challenge2Name.fontSize = 29;
        challenge3Name.text = "1 코인 플리퍼"; challenge3Name.font = nonoSansKoreanBold; challenge3Name.fontSize = 29;
        challenge4Name.text = "언제나 럭키"; challenge4Name.font = nonoSansKoreanBold; challenge4Name.fontSize = 29;
        challenge1Text.text = "챌린지#1을"; challenge1Text.font = notoSansKorean;
        challenge2Text.text = "챌린지#2을"; challenge2Text.font = notoSansKorean;
        challenge3Text.text = "챌린지#3을"; challenge3Text.font = notoSansKorean;
        challenge4Text.text = "챌린지#4을"; challenge4Text.font = notoSansKorean;
        challengeNegative1.text = "* 자동 코인 뒤집기를 사용할 수 없습니다\n* 업그레이드 코인 뒤집기를 사용할 수 없습니다"; challengeNegative1.font = nonoSansKoreanBold; challengeNegative1.fontSize = 14.8f;
        challengeNegative2.text = "* 성공적으로 뒤집을 확률 25%로 고정\n * 성공 확률 증가를 사용할 수 없습니다"; challengeNegative2.font = nonoSansKoreanBold; challengeNegative2.fontSize = 14f;
        challengeNegative3.text = "* You o코인 플리퍼를 하나만 쓸 수 있습니다\n* 더 많은 코인 뒤집기를 사용할 수 없습니다"; challengeNegative3.font = nonoSansKoreanBold; challengeNegative3.fontSize = 14f;
        challengeNegative4.text = "* 이 챌린지 동안 인플레이션 코인을 얻을 수 없습니다"; challengeNegative4.font = nonoSansKoreanBold; challengeNegative4.fontSize = 14f;
        challengePositive1.text = "* 뒤집을 때 500% 더 많은 코인을 얻습니다"; challengePositive1.font = nonoSansKoreanBold;
        challengepositive2.text = "* 매번 행운의 동전을 뒤집습니다"; challengepositive2.font = nonoSansKoreanBold; challengepositive2.fontSize = 14;
        Goal1text.text = "목표:"; Goal1text.font = nonoSansKoreanBold;
        Goal2text.text = "목표:"; Goal2text.font = nonoSansKoreanBold;
        Goal3text.text = "목표:"; Goal3text.font = nonoSansKoreanBold;
        Goal4text.text = "목표:"; Goal4text.font = nonoSansKoreanBold;
        Goal1textInfo.text = "15개의 동전 플리퍼에 도달하십시오"; Goal1textInfo.font = nonoSansKoreanBold;
        Goal2textInfo.text = "7개의 코인 플리퍼 업그레이드하기 보상"; Goal2textInfo.font = nonoSansKoreanBold;
        Goal3textInfo.text = "총 70 쿼드릴리언 코인 얻기"; Goal3textInfo.font = nonoSansKoreanBold;
        Goal4textInfo.text = "코인 플리퍼 21개를 모두 업그레이드하기"; Goal4textInfo.font = nonoSansKoreanBold; Goal4textInfo.fontSize = 27;
        Reward1Text.text = "보상:"; Reward1Text.font = nonoSansKoreanBold;
        Reward2Text.text = "보상:"; Reward2Text.font = nonoSansKoreanBold;
        Reward3Text.text = "보상:"; Reward3Text.font = nonoSansKoreanBold;
        Reward4Text.text = "보상:"; Reward4Text.font = nonoSansKoreanBold;
        Reward1TextInfo.text = "잠긴 특별 업그레이드 잠금 해제"; Reward1TextInfo.font = nonoSansKoreanBold; Reward1TextInfo.fontSize = 20;
        Reward2TextInfo.text = "첫 5개의 코인 플리퍼는 100% 성공적으로 코인을 뒤집습니다"; Reward2TextInfo.font = nonoSansKoreanBold; Reward2TextInfo.fontSize = 20;
        Reward3TextInfo.text = "첫 코인 플리퍼는 항상 성공적으로 코인을 뒤집으며 500% 더 많은 코인을 얻습니다"; Reward3TextInfo.font = nonoSansKoreanBold; Reward3TextInfo.fontSize = 20;
        Reward4TextInfo.text = "행운의 동전을 뒤집을 확률 최대 15%"; Reward4TextInfo.font = nonoSansKoreanBold; Reward4TextInfo.fontSize = 20;
        questionInfo.text = "-최소 1회 인플레이션 한 뒤 챌린지에 참가할 것을 추천합니다\n \n" +
            "-각 계열의 첫 번째 인플레이션 업그레이드를 읽고 각 챌린지를 진행하는 동안 어떤 업그레이드가 작동하는지 확인하십시오\n \n" +
            "-한번에 1개의 챌린지를 선택할 수 있습니다\n \n" +
            "-모든 챌린지 보상은 영구적입니다"; questionInfo.fontSize = 22.2f;
        questionInfo.font = nonoSansKoreanBold;
        #endregion

        #region upgrades

        strongerArmName = "힘센 팔";
        greaterCoinName = "위대한 동전";
        knowledgeName = "지식";
        strongerFistName = "힘센 주먹";
        handInjectionName = "손 주사";
        brainPowerName = "브레인 파워";
        explosiveFlipsName = "폭발적 뒤집기";
        hydrationName = "수분보충";
        strangePotionName = "이상한 물약";
        masterFlipperName = "뒤집기 마스터";
        handShakeName = "악수";
        highFiveName = "하이파이브";
        magicFlipsName = "매직 플립";
        TreasueChestName = "보물상자";
        coinFlippingRitualName = "코인 뒤집기 의식";

        upgrade1.text = strongerArmName; upgrade1.font = nonoSansKoreanBold;
        upgrade2.text = greaterCoinName; upgrade2.font = nonoSansKoreanBold;
        upgrade3.text = knowledgeName; upgrade3.font = nonoSansKoreanBold;
        upgrade4.text = strongerFistName; upgrade4.font = nonoSansKoreanBold;
        upgrade5.text = handInjectionName; upgrade5.font = nonoSansKoreanBold;
        upgrade6.text = brainPowerName; upgrade6.font = nonoSansKoreanBold;
        upgrade7.text = explosiveFlipsName; upgrade7.font = nonoSansKoreanBold; upgrade7.fontSize = 30;
        upgrade8.text = hydrationName; upgrade8.font = nonoSansKoreanBold;
        upgrade9.text = strangePotionName; upgrade9.font = nonoSansKoreanBold;
        upgrade10.text = masterFlipperName; upgrade10.font = nonoSansKoreanBold;
        upgrade11.text = handShakeName; upgrade11.font = nonoSansKoreanBold;
        upgrade12.text = highFiveName; upgrade12.font = nonoSansKoreanBold;
        upgrade13.text = magicFlipsName; upgrade13.font = nonoSansKoreanBold; upgrade13.fontSize = 30;
        upgrade14.text = TreasueChestName; upgrade14.font = nonoSansKoreanBold;
        upgrade15.text = coinFlippingRitualName; upgrade15.font = nonoSansKoreanBold; upgrade15.fontSize = 30;

        upgrade1n.font = nonoSansKoreanBold;
        upgrade2n.font = nonoSansKoreanBold;
        upgrade3n.font = nonoSansKoreanBold;
        upgrade4n.font = nonoSansKoreanBold;
        upgrade5n.font = nonoSansKoreanBold;
        upgrade6n.font = nonoSansKoreanBold;
        upgrade7n.font = nonoSansKoreanBold; upgrade7n.fontSize = 30;
        upgrade8n.font = nonoSansKoreanBold;
        upgrade9n.font = nonoSansKoreanBold;
        upgrade10n.font = nonoSansKoreanBold;
        upgrade11n.font = nonoSansKoreanBold;
        upgrade12n.font = nonoSansKoreanBold;
        upgrade13n.font = nonoSansKoreanBold; upgrade13n.fontSize = 30;
        upgrade14n.font = nonoSansKoreanBold;
        upgrade15n.font = nonoSansKoreanBold; upgrade15n.fontSize = 30;

        flipMorePrice1.font = notoSansKorean;
        flipMorePrice2.font = notoSansKorean;

        thousand = "천";
        million = "백만";
        billion = "십억";
        trillion = "트릴리언";
        quadrillion = " 콰드릴리언";
        quintillion = " 퀸틸리언";
        sextillion = " 섹스틸리언";
        septillion = " 셉틸리언";
        octillion = " 옥틸리언";
        nonillion = " 노닐리언";
        decillion = " 데실리언";
        undecillion = " 언데실리언";
        coins = " 코인";
        coinsOnHeads = " 동전 중 앞면";
        coinsOnTails = " 동전 중 뒷면";

        price1.font = notoSansKorean;
        price2.font = notoSansKorean;
        price3.font = notoSansKorean;
        price4.font = notoSansKorean;
        price5.font = notoSansKorean;
        price6.font = notoSansKorean;
        price7.font = notoSansKorean;
        price8.font = notoSansKorean;
        price9.font = notoSansKorean;
        price10.font = notoSansKorean;
        price11.font = notoSansKorean;
        price12.font = notoSansKorean;
        price13.font = notoSansKorean;
        price14.font = notoSansKorean;
        price15.font = notoSansKorean;
        price16.font = notoSansKorean;
        price17.font = notoSansKorean;
        price18.font = notoSansKorean;
        price19.font = notoSansKorean;
        price20.font = notoSansKorean;

        price1c.font = notoSansKorean;
        price2c.font = notoSansKorean;
        price3c.font = notoSansKorean;
        price4c.font = notoSansKorean;
        price5c.font = notoSansKorean;
        price6c.font = notoSansKorean;
        price7c.font = notoSansKorean;
        price8c.font = notoSansKorean;
        price9c.font = notoSansKorean;
        price10c.font = notoSansKorean;
        price11c.font = notoSansKorean;
        price12c.font = notoSansKorean;
        price13c.font = notoSansKorean;
        price14c.font = notoSansKorean;
        price15c.font = notoSansKorean;
        price16c.font = notoSansKorean;
        price17c.font = notoSansKorean;
        price18c.font = notoSansKorean;
        price19c.font = notoSansKorean;
        price20c.font = notoSansKorean;

        flipAll.text = "모두 뒤집으세요"; flipAll.font = nonoSansKoreanBold;
        autoFlipsQeuals.text = "자동 뒤집기 ="; autoFlipsQeuals.font = nonoSansKoreanBold; autoFlipsQeuals.fontSize = 25;
        on.text = "켜기"; on.font = nonoSansKoreanBold;
        on2.text = "켜기"; on2.font = nonoSansKoreanBold;
        off.text = "끄기"; off.font = nonoSansKoreanBold;
        off2.text = "끄기"; off2.font = nonoSansKoreanBold;
        gamble.text = "도박"; gamble.font = nonoSansKoreanBold;
        gamblec.text = "도박"; gamblec.font = nonoSansKoreanBold;
        current.text = "현재:"; current.font = nonoSansKoreanBold; current.fontSize = 25;
        autoFlips.text = "자동 코인 뒤집기"; autoFlips.font = nonoSansKoreanBold; autoFlips.fontSize = 30;
        autoFlipsc.text = "자동 코인 뒤집기"; autoFlipsc.font = nonoSansKoreanBold; autoFlipsc.fontSize = 30;
        pileOfCoins.text = "코인 더미"; pileOfCoins.font = nonoSansKoreanBold;
        pileOfCoinsc.text = "코인 더미"; pileOfCoinsc.font = nonoSansKoreanBold;
        higherChance.text = "성공할 확률이 높아집니다"; higherChance.font = nonoSansKoreanBold;
        higherChancec.text = "성공할 확률이 높아집니다"; higherChancec.font = nonoSansKoreanBold;
        getLucky.text = "행운 빌기"; getLucky.font = nonoSansKoreanBold;
        getLuckyc.text = "행운 빌기"; getLuckyc.font = nonoSansKoreanBold;
        endlessInflation.text = "끝없는 인플레이션"; endlessInflation.font = nonoSansKoreanBold;
        upgradedFlips.text = "업그레이드 된 코인 뒤집기"; upgradedFlips.font = nonoSansKoreanBold; upgradedFlips.fontSize = 36;
        upgradedFlipsc.text = "업그레이드 된 코인 뒤집기"; upgradedFlipsc.font = nonoSansKoreanBold; upgradedFlipsc.fontSize = 36;
        unlockedViaChal1.text = "챌린지#1을 완료해 잠금 해제했습니다"; unlockedViaChal1.font = nonoSansKoreanBold; unlockedViaChal1.fontSize = 16;
        unlcokedViaInf.text = "인플레이션을 통해 잠금해제했습니다"; unlcokedViaInf.font = nonoSansKoreanBold;
        chooseAutoUpgrade.text = "자동화할 업그레이드 선택하기:"; chooseAutoUpgrade.font = nonoSansKoreanBold;
        diplicateFlips.font = nonoSansKoreanBold; diplicateFlips.fontSize = 36;
        diplicateFlipsc.font = nonoSansKoreanBold; diplicateFlipsc.fontSize = 36;
        autoUpgradeNameText.text = "자동 업그레이드"; autoUpgradeNameText.font = nonoSansKoreanBold;

        autoUpgradeName = "자동 코인 뒤집기";
        pileOfCoinsName = "코인 더미";
        higherChanceName = "성공할 확률이 높아집니다";
        getLuckyName = "행운 빌기";
        upgradedFlipsName = "업그레이드 된 코인 뒤집기";
        flipMoreCoinsName = "더 많은 코인을 뒤집으세요";
        spendNoMore = "최대";
        maxedOut = "최대";
        theyAllFlip = "최대";




        #endregion

        //Figure out "successful flips" texts

        #region hoverOverUpgrades
        hover1Name.text = strongerArmName; hover1Name.font = nonoSansKoreanBold;
        hover2Name.text = greaterCoinName; hover2Name.font = nonoSansKoreanBold;
        hover3Name.text = knowledgeName; hover3Name.font = nonoSansKoreanBold;
        hover4Name.text = strongerFistName; hover4Name.font = nonoSansKoreanBold;
        hover5Name.text = handInjectionName; hover5Name.font = nonoSansKoreanBold;
        hover6Name.text = brainPowerName; hover6Name.font = nonoSansKoreanBold;
        hover7Name.text = explosiveFlipsName; hover7Name.font = nonoSansKoreanBold; hover7Name.fontSize = 36;
        hover8Name.text = hydrationName; hover8Name.font = nonoSansKoreanBold;
        hover9Name.text = strangePotionName; hover9Name.font = nonoSansKoreanBold;
        hover10Name.text = masterFlipperName; hover10Name.font = nonoSansKoreanBold;
        hover11Name.text = handShakeName; hover11Name.font = nonoSansKoreanBold;
        hover12Name.text = highFiveName; hover12Name.font = nonoSansKoreanBold;
        hover13Name.text = magicFlipsName; hover13Name.font = nonoSansKoreanBold; hover13Name.fontSize = 36;
        hover14Name.text = TreasueChestName; hover14Name.font = nonoSansKoreanBold;
        hover15Name.text = coinFlippingRitualName; hover15Name.font = nonoSansKoreanBold; hover15Name.fontSize = 36;
        hoverFlipAll.text = "모두 뒤집으세요"; hoverFlipAll.font = nonoSansKoreanBold;
        hoverAutoUpgrade.text = "자동 업그레이드"; hoverAutoUpgrade.font = nonoSansKoreanBold;
        hovergamble.text = "도박"; hovergamble.font = nonoSansKoreanBold; hovergamble.fontSize = 35;
        hoverAutoFlip.text = "자동 코인 뒤집기"; hoverAutoFlip.font = nonoSansKoreanBold; hoverAutoFlip.fontSize = 36;
        hoverPile.text = "코인 더미"; hoverPile.font = nonoSansKoreanBold;
        hoverhigherChance.text = "성공할 확률이 높아집니다"; hoverhigherChance.font = nonoSansKoreanBold;
        hoverLucky.text = "행운 빌기"; hoverLucky.font = nonoSansKoreanBold;
        hoverEndless.text = "끝없는 인플레이션"; hoverEndless.font = nonoSansKoreanBold;
        hoverUpgradedFlips.text = "업그레이드 된 코인 뒤집기"; hoverUpgradedFlips.font = nonoSansKoreanBold; hoverUpgradedFlips.fontSize = 35;
        hoverOn.text = "오토 플립 켜기"; hoverOn.font = nonoSansKoreanBold;
        hoverOff.text = "오토 플립 끄기"; hoverOff.font = nonoSansKoreanBold;

        purchased = "구입완료: ";

        purchased1.text = "구입완료: " + MoreCoinsButton.moreCoinsUpgrades; purchased2.text = "구입완료: " + MoreCoinsButton.greaterCoinsCount;
        purchased3.text = "구입완료: " + KnowledgeUpgrade.knowledgeUpgradeCount; purchased4.text = "구입완료: " + StrongerFist.fistUpgradeCount;
        purchased5.text = "구입완료: " + HandInecjtion.injectionUpgradeCount; purchased6.text = "구입완료: " + BrainPower.brainPowerUpgradeCount;
        purchased7.text = "구입완료: " + ExplosiveFlips.explosiveUpgradeCount; purchased8.text = "구입완료: " + HydrationButton.hydrationUpgradeCount;
        purchased9.text = "구입완료: " + StrangePotion.potionUpgradeCount; purchased10.text = "구입완료: " + MasterFlipper.MasterFlipsUpgradeCount;
        purchased11.text = "구입완료: " + HandShake.handShakeUpgradeCount; purchased12.text = "구입완료: " + Upgrade12.upgrade12Count;
        purchased13.text = "구입완료: " + MagicFlipsUpgrade.magicUpgradeCount; purchased14.text = "구입완료: " + TreasureChest.treasureCount;
        purchased15.text = "구입완료: " + RitualUpgrade.treasureCount;
        purchased16.text = "구입완료: " + GlobalCoinMaker.coinsPerFlipUpgrades; purchased17.text = "구입완료: " + PurchaseLog.higherChanceUpgradeCount;
        purchased18.text = "구입완료: " + PurchaseLog.luckyCoinHigherChanceCount; purchased19.text = "구입완료: " + GoldenFlipsButton.goldenCoinsUpgradeCount;
        purchased20.text = "구입완료: " + PurchaseLog.pileOfCoinsCount; purchased21.text = "구입완료: ";


        purchased1.font = nonoSansKoreanBold; purchased2.font = nonoSansKoreanBold; purchased3.font = nonoSansKoreanBold; purchased4.font = nonoSansKoreanBold;
        purchased5.font = nonoSansKoreanBold; purchased6.font = nonoSansKoreanBold; purchased7.font = nonoSansKoreanBold; purchased8.font = nonoSansKoreanBold;
        purchased9.font = nonoSansKoreanBold; purchased10.font = nonoSansKoreanBold; purchased11.font = nonoSansKoreanBold; purchased12.font = nonoSansKoreanBold;
        purchased13.font = nonoSansKoreanBold; purchased14.font = nonoSansKoreanBold; purchased15.font = nonoSansKoreanBold;
        purchased16.font = nonoSansKoreanBold;
        purchased17.font = nonoSansKoreanBold; purchased18.font = nonoSansKoreanBold; purchased19.font = nonoSansKoreanBold;
        purchased20.font = nonoSansKoreanBold; purchased21.font = nonoSansKoreanBold;

        thousandC = "천 코인"; millionc = "백만 코인"; billionc = "빌리언 코인"; trillionc = "트릴리언 코인"; quadrillionc = "콰드릴리언 코인"; quintillionc = "퀸틸리언 코인";
        sextillionc = "섹스틸리언 코인"; septillionc = "셉틸리언 코인"; octillionc = "옥틸리언 코인,"; nonillionc = "노닐리언 코인"; decillionc = "데실리언 코인";
        undecillionc = "언데실리언 코인";

        description1.text = "\"몇년 간 이두, 삼두, 전완근을 단련시켰습니다. 이제 더 강한 힘으로 코인을 뒤집을 수 있습니다!\"";
        description2.text = "\"당신은 어느 날 길가에 떨어진 코인을 주웠습니다. 알고 보니 이 코인을 뒤집을 때마다 더 많은 코인을 얻을 수 있더군요!\"";
        description3.text = "\"힘센 팔과 위대한 동전보다 강한 것이 무엇일까요? 바로 지식입니다\"";
        description4.text = "\"체육관에 있는 다른 모든 사람들이 몸 전체를 훈련하는 동안, 여러분은 주먹에만 초점을 맞췄습니다. 각 손가락을 개별적으로 단련해 주먹 전체를 하나의 거대한 펌프로 만들었습니다\"";
        description5.text = "\"길을 가던 어떤 남자로부터 이상한 액체가 들어 있는 주사를 구입했습니다. 손에 주입하자 왠지 전보다 기분이 좋아집니다\"";
        description6.text = "\"몇 년간 코인을 뒤집다 보니, 뇌의 잠재력을 100% 이상으로 사용할 수 있게 되었습니다\"";
        description7.text = "\"코인 뒤집기는 점점 위험해지고 있습니다. 코인을 뒤집을 때마다 엄지손가락에 작은 폭발이 일어납니다. 사실 폭발이라고는 해도 조금 간지러운 것 뿐입니다\"";
        description8.text = "\"하루종일 코인을 뒤집는 건 힘든 일입니다. 가끔은 시원하고 상쾌한 물 한 잔이 계속하는 원동력이 됩니다. 늘 수분을 보충하세요\"";
        description9.text = "\"여러분은 아주 오랫동안 침대 밑에 이상한 물약을 보관해 왔습니다. 오늘은 드디어 그 뚜껑을 여는 날입니다. 마시자마자 살면서 처음으로 느껴보는, 바늘로 찌르는 듯한 날카로운 쾌감이 느껴집니다\"";
        description10.text = "\"수년간 코인 뒤집기에 헌신한 여러분은 뒤집기 마스터 메달을 받았습니다\"";
        description11.text = "\"프로페셔널 코인 뒤집기 사업가와 악수를 합니다. 이 남자와 함께라면 여러분은 코인 뒤집기를 세상에서 가장 성공적인 사업으로 만들 수 잇을 겁니다. 어떻게든...\"";
        description12.text = "\"중요한 사람과 하이파이브합니다. 상상도 못할 만큼 힘이 솟아나 코인을 뒤집게 됩니다\"";
        description13.text = "\"마법의 코인 뒤집기 기술을 배우기 위해 마법사학교로 견학을 갑니다. 이제 코인을 뒤집을 때마다 마법의 빛이 납니다. 사람들이 의아해하며 바라봅니다\"";
        description14.text = "\"셀 수없이 자주 세계여행을 떠난 결과, 낡디낡은 보물상자를 하나 발견했습니다. 이제 자연스럽게 그 상자 안에 있던 금화로 코인 뒤집기를 합니다\"";
        description15.text = "\"점차 코인 뒤집기가 변질되고 있습니다. 여러분은 코인을 뒤집는 새로운 방법을 찾는 데 집착합니다. 가능한 한 최고의 형태로 코인을 뒤집기 위해 어둠의 의식을 수행하기 시작합니다\"";
        description16.text = "\"다른 사람이 코인을 뒤집어 주는 게 더 좋을 때도 있습니다. 한 번 업그레이드 할 때마다 1개의 코인이 자동으로 뒤집힙니다\"";
        description17.text = "\"이제 뒤집기가 성공할 확률이 1% 더 높아집니다. 운이 좋으면 실제로 더 많은 코인을 모을 수 있습니다\"";
        description18.text = "\"가끔 코인 뒤집기가 조금 다르게 느껴집니다. 이런 새로운 느낌의 코인 뒤집기가 발생하면 코인을 5배로 얻을 수 있습니다. 업그레이드 할 때마다 +0.5%씩 상승합니다\"";
        description19.text = "\"매 구매시 코인 플리퍼 1개를 업그레이드합니다. 업그레이드시 일반 코인은 2배가 되고, 행운의 동전이 나오면 코인을 10배로 얻을 수 있습니다. +1 업그레이드 된 코인 플리퍼. 업그레이드된 코인 뒤집기가 기본적으로 자동화됩니다\"";
        description20.text = "\"여러분은 도박꾼인가요? 그렇다면, 한 번 코인을 두 배로 불려 보실래요? 기술은 필요하지 않습니다. 오직 운에 달려 있죠. 여러분이 원치 않는다면 도박할 필요가 없다는 걸 기억하세요\"";
        description21.text = "-자동화할 업그레이드를 선택하세요\n\n -자동 업그레이드는 여유가 있을 때마다 5초마다 선택한 업그레이드를 구매합니다.\n\n -게임을 종료하면 자동 업그레이드가 작동하지 않습니다";
        description22.text = "-자동 뒤집기를 켜고 끌 수 있습니다\n-모든 코인을 뒤집은 뒤에는 3초간 기다려야 다시 뒤집을 수 있습니다\n-자동 뒤집기를 끈 상태에서는 어떤 코인도 적극적으로 뒤집을 수 없습니다\n-자동 뒤집기가 꺼져 있으면 자동 뒤집기와 업그레이드 코인 뒤집기는 잠깁니다";
        description23.text = "\"왼쪽 아래에 코인 더미가 나타납니다. 시간이 지나면서 코인 더미에서 더 많은 코인이 만들어집니다. 클릭시 모든 코인이 표시됩니다\"";
        descEndless1.text = "\"대부분의 인플레이션 업그레이드를 해제한 뒤 이 업그레이드를 구매할 것을 추천합니다\"";
        descEndless2.text = "이 업그레이드는 «리치» 인플레이션 업그레이드와 동일한 방식으로 작용합니다. 각 구매시 코인 보너스는 업그레이드 가격과 동일합니다";
        description1.font = notoSansKorean; description2.font = notoSansKorean; description3.font = notoSansKorean; description4.font = notoSansKorean; description5.font = notoSansKorean;
        description6.font = notoSansKorean; description7.font = notoSansKorean; description8.font = notoSansKorean; description9.font = notoSansKorean; description10.font = notoSansKorean;
        description11.font = notoSansKorean; description12.font = notoSansKorean; description13.font = notoSansKorean; description14.font = notoSansKorean; description15.font = notoSansKorean;
        description16.font = notoSansKorean; description17.font = notoSansKorean; description18.font = notoSansKorean; description19.font = notoSansKorean; description20.font = notoSansKorean;
        description21.font = notoSansKorean; description22.font = notoSansKorean; description23.font = notoSansKorean; descEndless1.font = notoSansKorean; descEndless2.font = notoSansKorean;

        description2.fontSize = 15; description4.fontSize = 14; description5.fontSize = 15; description7.fontSize = 15; description8.fontSize = 15; description9.fontSize = 13.5f;
        description11.fontSize = 15; description13.fontSize = 15; description14.fontSize = 15; description15.fontSize = 14.7f; description16.fontSize = 15; description18.fontSize = 15; description19.fontSize = 11.6f;
        description20.fontSize = 15; description22.fontSize = 15; description23.fontSize = 15; descEndless1.fontSize = 14.5f; descEndless2.fontSize = 14.7f;

        hoverCost1.font = nonoSansKoreanBold; hoverCost2.font = nonoSansKoreanBold; hoverCost3.font = nonoSansKoreanBold; hoverCost4.font = nonoSansKoreanBold; hoverCost5.font = nonoSansKoreanBold;
        hoverCost6.font = nonoSansKoreanBold; hoverCost7.font = nonoSansKoreanBold; hoverCost8.font = nonoSansKoreanBold; hoverCost9.font = nonoSansKoreanBold; hoverCost10.font = nonoSansKoreanBold;
        hoverCost11.font = nonoSansKoreanBold; hoverCost12.font = nonoSansKoreanBold; hoverCost13.font = nonoSansKoreanBold; hoverCost14.font = nonoSansKoreanBold; hoverCost15.font = nonoSansKoreanBold;
        hoverCost16.font = nonoSansKoreanBold; hoverCost17.font = nonoSansKoreanBold; hoverCost18.font = nonoSansKoreanBold; hoverCost19.font = nonoSansKoreanBold; hoverCost20.font = nonoSansKoreanBold;
        hoverCost21.font = nonoSansKoreanBold;

        p1.text = "가격:"; p2.text = "가격:"; p3.text = "가격:"; p4.text = "가격:"; p5.text = "가격:"; p6.text = "가격:"; p7.text = "가격:"; p8.text = "가격:"; p9.text = "가격:"; p10.text = "가격:";
        p11.text = "가격:";
        p12.text = "가격:"; p13.text = "가격:"; p14.text = "가격:"; p15.text = "가격:"; p16.text = "가격:"; p17.text = "가격:"; p18.text = "가격:"; p19.text = "가격:"; p20.text = "가격:";
        p21.text = "가격:";

        p1.font = nonoSansKoreanBold; p2.font = nonoSansKoreanBold; p3.font = nonoSansKoreanBold; p4.font = nonoSansKoreanBold; p5.font = nonoSansKoreanBold; p6.font = nonoSansKoreanBold;
        p7.font = nonoSansKoreanBold; p8.font = nonoSansKoreanBold; p9.font = nonoSansKoreanBold; p10.font = nonoSansKoreanBold; p11.font = nonoSansKoreanBold; p12.font = nonoSansKoreanBold;
        p13.font = nonoSansKoreanBold; p14.font = nonoSansKoreanBold; p15.font = nonoSansKoreanBold; p16.font = nonoSansKoreanBold; p17.font = nonoSansKoreanBold; p18.font = nonoSansKoreanBold;
        p19.font = nonoSansKoreanBold; p20.font = nonoSansKoreanBold; p21.font = nonoSansKoreanBold;

        plussCoins = "코인";
        plussthousandCoins = "천 코인";
        plussMillionCoins = "밀리언 코인";
        plussBillionCoins = "빌리언 코인";
        plussTrillionCoins = "트릴리언 코인";
        plussQuadrillionCoins = "콰드릴리언 코인";
        plussQuintillionCoins = "퀸틸리언 코인";
        plussSextillionCoins = "섹스틸리언 코인";
        plussSeptillionCoins = "셉틸리언 코인";

        pluss1.font = nonoSansKoreanBold; pluss2.font = nonoSansKoreanBold; pluss3.font = nonoSansKoreanBold; pluss4.font = nonoSansKoreanBold; pluss5.font = nonoSansKoreanBold; pluss6.font = nonoSansKoreanBold;
        pluss7.font = nonoSansKoreanBold; pluss8.font = nonoSansKoreanBold; pluss9.font = nonoSansKoreanBold; pluss10.font = nonoSansKoreanBold; pluss11.font = nonoSansKoreanBold; pluss12.font = nonoSansKoreanBold;
        pluss13.font = nonoSansKoreanBold; pluss14.font = nonoSansKoreanBold; pluss15.font = nonoSansKoreanBold;

        pluss1.fontSize = 15; pluss2.fontSize = 15; pluss3.fontSize = 15; pluss4.fontSize = 15; pluss5.fontSize = 15; pluss6.fontSize = 15; pluss7.fontSize = 15; pluss8.fontSize = 15; pluss9.fontSize = 15;
        pluss10.fontSize = 15; pluss11.fontSize = 15; pluss12.fontSize = 15; pluss13.fontSize = 15; pluss14.fontSize = 15; pluss15.fontSize = 15;

        gamblePreventCheating.text = "(부정행위 방지를 위해 도박을 할 때마다 게임이 저장됩니다)"; gamblePreventCheating.font = nonoSansKoreanBold;
        gambleReset.text = "인플레이션시 모든 시도가 리셋됩니다"; gambleReset.font = nonoSansKoreanBold;
        gambleTries.font = priceTextEng; gambleChanceToWin.font = nonoSansKoreanBold; gambleChanceToLoose.font = nonoSansKoreanBold; pileGenerates.font = nonoSansKoreanBold;
        pileMinus1Second.text = "– 한 번 구매시 1초입니다."; pileMinus1Second.font = nonoSansKoreanBold; chanceToHitHeads.font = nonoSansKoreanBold; chanceToHitTails.font = nonoSansKoreanBold;
        chanceToHitLuckyCoin.font = nonoSansKoreanBold; endlessInflationPercent.font = nonoSansKoreanBold; endlessInflationCoin.font = nonoSansKoreanBold; plussUpgradedCoinFlipper.font = nonoSansKoreanBold;
        plussUpgradedCoinFlipper.text = "+1 업그레이드 된 코인 플리퍼"; plussUpgradedCoinFlipper.fontSize = 20;

        gambleChanceToWin.text = PurchaseLog.gambleChanceEachTimeWIN + "% 확률로 모든 코인을 2배로 늘릴 수 있습니다s"; gambleChanceToLoose.text = PurchaseLog.gambleChanceEachTimeLOOSE + "% 확률로 코인을 모두 잃을 수 있습니다";
        chanceToHitHeads.text = higherChanceHoverover.headsPercent + "%로 앞면을 맞춥니다"; chanceToHitTails.text = higherChanceHoverover.tailsPercent + "%로 뒷면을 맞춥니다";
        chanceToHitLuckyCoin.text = GetLuckyHoverOver.luckyChance + "%확률로 행운의 동전을 던질 수 있습니다";
        endlessInflationPercent.text = EndlessInflation.endlessInflationPrice + "% 더 많은 코인"; endlessInflationCoin.text = EndlessInflation.endlessInflationPrice + " 인플레이션 코인";
        chanceToHitLuckyCoin.fontSize = 13.5f; chanceToHitHeads.fontSize = 15f; chanceToHitTails.fontSize = 15f;
        pileGenerates.text = "" + PileOfCoinsMechanics.waitTime + "초마다 코인을 생성합니다"; pileGenerates.fontSize = 11;

        gambleWinChance = "% 확률로 모든 코인을 2배로 늘릴 수 있습니다"; gambleLoseChance = "% 확률로 코인을 모두 잃을 수 있습니다"; gambleTriesString = "시도 횟수: ";
        pileGeneratesEveyXSecond = ""; seconds = "초마다 코인을 생성합니다";
        higherChanceTails = "% 확률로 뒷면이 나옵니다"; higherChanceHeads = "% 확률로 앞면이 나옵니다"; luckyCoinChance = "% 확률로 행운의 동전 나옵니다";
        endlessInflationCost = " 인플레이션 코인s"; endlessInflationPercentString = "% 더 많은 코인"; needs21Flippers = "21개의 코인 플리퍼를";

        gambleTriesStringText.text = "시도 횟수: " + PurchaseLog.gambleChances; gambleTriesStringText.font = nonoSansKoreanBold;
        gambleResultText.font = nonoSansKoreanBold;

        #endregion

        #region STATS

        inflateOnceToSeeStats.text = "통계를 보려면 1회 인플레이션 하세요"; inflateOnceToSeeStats.font = nonoSansKoreanBold; inflateOnceToSeeStats.fontSize = 20;

        //GeneralStats
        coin = "동전";
        youHaveFlipped = "You have flipped "; youHaveFlippedText.font = notoSansKorean;
        youHaveActivelyFlipped = "You have actively flipped "; youHaveActivelyFlippedText.font = notoSansKorean;
        totalCoinsOnHeads = " - 앞."; totalCoinsOnHeadsText.font = notoSansKorean;
        totalCoinsOnTails = " - 뒷면"; totalCoinsOnTailsText.font = notoSansKorean;
        totalLockyCoins = " - 럭키코인"; totalLockyCoinsText.font = notoSansKorean;

        stats.text = "통계"; general.text = "통계"; upgrades.text = "업그레이드"; completedChallenges.text = "챌린지을 완료하세요"; inflation.text = "인플레이션"; specialUpgrades.text = "스페셜 업그레이드"; specialUpgrades.font = nonoSansKoreanBold;
        stats.font = nonoSansKoreanBold; general.font = notoSansKorean; upgrades.font = notoSansKorean; completedChallenges.font = notoSansKorean; inflation.font = notoSansKorean;


        //UpgradesText
        buyUpgrade = "통계를 보려면 업그레이드를 구매하세요";
        your = "";
        statsStrongerArm = "힘센 팔 = ";
        statsGreater = "위대한 동전 = ";
        statsKnowledge = "지식 = ";
        statsFist = "힘센 주먹 = ";
        statsInjection = "손 주사 = ";
        statsBrain = "브레인 파워 = ";
        statsExplosive = "폭발적 뒤집기 = ";
        statsHydration = "수분보충 = ";
        statsPorion = "이상한 물약 = ";
        statsMaster = "뒤집기 마스터 = ";
        statsHandshake = "악수 = ";
        statsHighFive = "하이파이브 = ";
        statsMagic = "매직 플립 = ";
        statsTreasure = "보물상자 = ";
        statsRitual = "코인 뒤집기 의식 = ";

        statsStrongerArmText.text = LocalizationStrings.your + MoreCoinsButton.moreCoinsUpgrades + LocalizationStrings.statsStrongerArm + FormatCoins(PurchaseLog.strongerHandsTextInfo) + LocalizationStrings.coins; statsStrongerArmText.font = notoSansKorean;

        statsGreaterText.font = notoSansKorean; statsKnowledgeText.font = notoSansKorean; statsFistText.font = notoSansKorean; statsInjectionText.font = notoSansKorean; statsBrainText.font = notoSansKorean; statsExplosiveText.font = notoSansKorean;
        statsHydrationText.font = notoSansKorean; statsPorionText.font = notoSansKorean; statsMasterText.font = notoSansKorean; statsHandshakeText.font = notoSansKorean; statsHighFiveText.font = notoSansKorean;
        statsMagicText.font = notoSansKorean; statsTreasureText.font = notoSansKorean; statsRitualText.font = notoSansKorean;

        if (MoreCoinsButton.greaterCoinsCount == 0) { statsGreaterText.text = buyUpgrade; }
        if (MoreCoinsButton.greaterCoinsCount > 0)
        {
            statsGreaterText.text = LocalizationStrings.your + MoreCoinsButton.greaterCoinsCount + LocalizationStrings.statsGreater + FormatCoins(PurchaseLog.greaterTextInfo) + LocalizationStrings.coins;
        }
        if (KnowledgeUpgrade.knowledgeUpgradeCount == 0) { statsKnowledgeText.text = buyUpgrade; }
        if (KnowledgeUpgrade.knowledgeUpgradeCount > 0)
        {
            statsKnowledgeText.text = LocalizationStrings.your + KnowledgeUpgrade.knowledgeUpgradeCount + LocalizationStrings.statsKnowledge + FormatCoins(PurchaseLog.knowledgeInfo) + LocalizationStrings.coins;
        }
        if (StrongerFist.fistUpgradeCount == 0) { statsFistText.text = buyUpgrade; }
        if (StrongerFist.fistUpgradeCount > 0)
        {
            statsFistText.text = LocalizationStrings.your + StrongerFist.fistUpgradeCount + LocalizationStrings.statsFist + FormatCoins(PurchaseLog.fistInfo) + LocalizationStrings.coins;
        }
        if (HandInecjtion.injectionUpgradeCount == 0) { statsInjectionText.text = buyUpgrade; }
        if (HandInecjtion.injectionUpgradeCount > 0)
        {
            statsInjectionText.text = LocalizationStrings.your + HandInecjtion.injectionUpgradeCount + LocalizationStrings.statsInjection + FormatCoins(PurchaseLog.injectionInfo) + LocalizationStrings.coins;
        }
        if (BrainPower.brainPowerUpgradeCount == 0) { statsBrainText.text = buyUpgrade; }
        if (BrainPower.brainPowerUpgradeCount > 0)
        {
            statsBrainText.text = LocalizationStrings.your + BrainPower.brainPowerUpgradeCount + LocalizationStrings.statsBrain + FormatCoins(PurchaseLog.brainPowerInfo) + LocalizationStrings.coins;
        }
        if (ExplosiveFlips.explosiveUpgradeCount == 0) { statsExplosiveText.text = buyUpgrade; }
        if (ExplosiveFlips.explosiveUpgradeCount > 0)
        {
            statsExplosiveText.text = LocalizationStrings.your + ExplosiveFlips.explosiveUpgradeCount + LocalizationStrings.statsExplosive + FormatCoins(PurchaseLog.explosiveInfo) + LocalizationStrings.coins;
        }
        if (HydrationButton.hydrationUpgradeCount == 0) { statsHydrationText.text = buyUpgrade; }
        if (HydrationButton.hydrationUpgradeCount > 0)
        {
            statsHydrationText.text = LocalizationStrings.your + HydrationButton.hydrationUpgradeCount + LocalizationStrings.statsHydration + FormatCoins(PurchaseLog.hydrationInfo) + LocalizationStrings.coins;
        }
        if (StrangePotion.potionUpgradeCount == 0) { statsPorionText.text = buyUpgrade; }
        if (StrangePotion.potionUpgradeCount > 0)
        {
            statsPorionText.text = LocalizationStrings.your + StrangePotion.potionUpgradeCount + LocalizationStrings.statsPorion + FormatCoins(PurchaseLog.potionInfo) + LocalizationStrings.coins;
        }
        if (MasterFlipper.MasterFlipsUpgradeCount == 0) { statsMasterText.text = buyUpgrade; }
        if (MasterFlipper.MasterFlipsUpgradeCount > 0)
        {
            statsMasterText.text = LocalizationStrings.your + MasterFlipper.MasterFlipsUpgradeCount + LocalizationStrings.statsMaster + FormatCoins(PurchaseLog.masterFlipperInfo) + LocalizationStrings.coins;
        }
        if (HandShake.handShakeUpgradeCount == 0) { statsHandshakeText.text = buyUpgrade; }
        if (HandShake.handShakeUpgradeCount > 0)
        {
            statsHandshakeText.text = LocalizationStrings.your + HandShake.handShakeUpgradeCount + LocalizationStrings.statsHandshake + FormatCoins(PurchaseLog.handShakeInfo) + LocalizationStrings.coins;
        }
        if (Upgrade12.upgrade12Count == 0) { statsHighFiveText.text = buyUpgrade; }
        if (Upgrade12.upgrade12Count > 0)
        {
            statsHighFiveText.text = LocalizationStrings.your + Upgrade12.upgrade12Count + LocalizationStrings.statsHighFive + FormatCoins(PurchaseLog.upgrade12Info) + LocalizationStrings.coins;
        }
        if (MagicFlipsUpgrade.magicUpgradeCount == 0) { statsMagicText.text = buyUpgrade; }
        if (MagicFlipsUpgrade.magicUpgradeCount >= 1)
        {
            statsMagicText.text = LocalizationStrings.your + MagicFlipsUpgrade.magicUpgradeCount + LocalizationStrings.statsMagic + FormatCoins(PurchaseLog.magicFlipsInfo) + LocalizationStrings.coins;
        }
        if (TreasureChest.treasureCount == 0) { statsTreasureText.text = buyUpgrade; }
        if (TreasureChest.treasureCount >= 1)
        {
            statsTreasureText.text = LocalizationStrings.your + TreasureChest.treasureCount + LocalizationStrings.statsTreasure + FormatCoins(PurchaseLog.treasureInfo) + LocalizationStrings.coins;
        }
        if (RitualUpgrade.treasureCount == 0) { statsRitualText.text = buyUpgrade; }
        if (RitualUpgrade.treasureCount >= 1)
        {
            statsRitualText.text = LocalizationStrings.your + RitualUpgrade.treasureCount + LocalizationStrings.statsRitual + FormatCoins(PurchaseLog.ritualInfo) + LocalizationStrings.coins;
        }

        statsStrongerArmText.fontSize = 15; statsGreaterText.fontSize = 15; statsKnowledgeText.fontSize = 15; statsFistText.fontSize = 15; statsInjectionText.fontSize = 15;
        statsBrainText.fontSize = 15; statsExplosiveText.fontSize = 15; statsHydrationText.fontSize = 15; statsPorionText.fontSize = 15; statsMasterText.fontSize = 15;
        statsHandshakeText.fontSize = 15; statsHighFiveText.fontSize = 15; statsMagicText.fontSize = 15; statsTreasureText.fontSize = 15; statsRitualText.fontSize = 15;

        //SpecialUpgradesText
        times = " times"; youHitExtraLucky = "You hit an EXTRA LUCKY Coin "; youGambled = "You have GAMBLED "; lostGambling = "You have lost all your coins GAMBLING ";
        wonGambling = "You have doubled all your coins GAMBLING "; clickedPile = "You have clicked on a PILE OF COINS "; pileTotalGenerated = "PILE OF COINS have generated a total of ";
        completeChal1 = "챌린지 1을 완료하여 보상을 확인하세요"; completeChal2 = "챌린지 2을 완료하여 보상을 확인하세요";
        completeChal3 = "챌린지 3을 완료하여 보상을 확인하세요"; completeChal4 = "챌린지 4을 완료하여 보상을 확인하세요";
        chal1Completed = "챌린지 1 보상: 모두 뒤집기 버튼을 해제하세요"; chal2completed = "챌린지 2 보상: 첫 5회 코인 뒤집기는 늘 성공입니다";
        chal3completed = "챌린지 3 보상: 첫 번째 코인 플리퍼에서 500% 더 많은 코인을 얻을 수 있습니다"; chal4completed = "챌린지 4 보상: 행운의 동전을 던질 확률이 최대 15%입니다"; ;
        
        statsHeadsChanceText.text = higherChanceHoverover.headsPercent + LocalizationStrings.higherChanceHeads; statsHeadsChanceText.font = notoSansKorean;
        statsTailsChanceText.text = higherChanceHoverover.tailsPercent + LocalizationStrings.higherChanceTails; statsTailsChanceText.font = notoSansKorean;
        statsLuckyChanceText.text = GetLuckyHoverOver.luckyChance + LocalizationStrings.luckyCoinChance; statsLuckyChanceText.font = notoSansKorean;
        youHitExtraLuckyText.font = notoSansKorean;
        clickedPileText.text = LocalizationStrings.clickedPile + PileOfCoinsMechanics.incrementPileOfCoinsAmount + LocalizationStrings.times;
        youGambledText.text = LocalizationStrings.youGambled + (0 + PurchaseLog.amountOfTimesGambled) + LocalizationStrings.times; youGambledText.font = notoSansKorean; 
        lostGamblingText.font = notoSansKorean; lostGamblingText.text = LocalizationStrings.lostGambling + (0 + PurchaseLog.amountOfTimesGambledLOST) + LocalizationStrings.times;
        wonGamblingText.font = notoSansKorean; wonGamblingText.text = LocalizationStrings.wonGambling + (0 + PurchaseLog.amountOfTimesGambledWON) + LocalizationStrings.times;
        clickedPileText.font = notoSansKorean;
        pileTotalGeneratedText.font = notoSansKorean; ;

        completeChal1Text.font = notoSansKorean; completeChal2Text.font = notoSansKorean; completeChal3Text.font = notoSansKorean; completeChal4Text.font = notoSansKorean;

        completeChal1Text.fontSize = 13f; completeChal2Text.fontSize = 13f; completeChal3Text.fontSize = 13f; completeChal4Text.fontSize = 13f;

        if (Challenges.completedChallenge1 == 0) { completeChal1Text.text = completeChal1; }
        if (Challenges.completedChallenge1 == 1) { completeChal1Text.text = chal1Completed; }
        if (Challenges.completedChallenge2 == 0) { completeChal2Text.text = completeChal2; }
        if (Challenges.completedChallenge2 == 1) { completeChal2Text.text = chal2completed; }
        if (Challenges.completedChallenge3 == 0) { completeChal3Text.text = completeChal3; }
        if (Challenges.completedChallenge3 == 1) { completeChal3Text.text = chal3completed; }
        if (Challenges.completedChallenge4 == 0) { completeChal4Text.text = completeChal4; }
        if (Challenges.completedChallenge4 == 1) { completeChal4Text.text = chal4completed; }

        moreCoins = "% 더 많은 코인"; cheaper = "% 더 저렴합니다"; less = "% 더 저렴합니다"; coinsAfterInflating = "개의 코인을 더 얻을 수 있습니다"; moreCoinsAfterInflating = " 코인부터 시작합니다";

        inflateUpgradesStats = "업그레이드시 코인을  "; inflateEndlessStats = "끝없는 인플레이션시 코인을 "; inflateCheaperStats = "업그레이드는 "; inflateSpecialCheaperStats = "특별 업그레이드는";
        inflateActiveStats = "적극적으로 코인 뒤집기시 코인을 "; inflateStartWithCoinsStats = "인플레이션시 "; inflatePileOfBagsStats = "인플레이션 후 코인 더미에서";

        inflateEndlessStatsTEXT.text = LocalizationStrings.inflateEndlessStats + EndlessInflation.englessInflationBonusText + LocalizationStrings.moreCoins;
        inflateSpecialCheaperStatsTEXT.text = LocalizationStrings.inflateSpecialCheaperStats + (AscendScreen.totalSpecialReduction) + LocalizationStrings.less;
        inflateStartWithCoinsStatsTEXT.text = LocalizationStrings.inflateStartWithCoinsStats + AscendScreen.starWithCoinsAmount + LocalizationStrings.coinsAfterInflating;
        inflateUpgradesStatsTEXT.text = LocalizationStrings.inflateUpgradesStats + AscendScreen.moreCoinsUpgradePercent + LocalizationStrings.moreCoins;
        inflateCheaperStatsTEXT.text = LocalizationStrings.inflateCheaperStats + AscendScreen.cheaperUpgradesPercent + LocalizationStrings.cheaper;
        inflateActiveStatsTEXT.text = LocalizationStrings.inflateActiveStats + AscendScreen.activeFlipperPercent + LocalizationStrings.moreCoins;
        inflatePileOfBagsStatsTEXT.text = LocalizationStrings.inflatePileOfBagsStats + PileOfCoinsMechanics.PileBagAmount + LocalizationStrings.moreCoinsAfterInflating;

        inflateEndlessStatsTEXT.font = notoSansKorean; inflateSpecialCheaperStatsTEXT.font = notoSansKorean; inflateStartWithCoinsStatsTEXT.font = notoSansKorean; inflateUpgradesStatsTEXT.font = notoSansKorean;
        inflateCheaperStatsTEXT.font = notoSansKorean; inflateActiveStatsTEXT.font = notoSansKorean; inflatePileOfBagsStatsTEXT.font = notoSansKorean;

        inflateEndlessStatsTEXT.fontSize = 18; inflateSpecialCheaperStatsTEXT.fontSize = 18; inflateStartWithCoinsStatsTEXT.fontSize = 18; inflateUpgradesStatsTEXT.fontSize = 18;
        inflateCheaperStatsTEXT.fontSize = 18; inflateActiveStatsTEXT.fontSize = 18; inflatePileOfBagsStatsTEXT.fontSize = 18;

        if (AscendScreen.boughtRich1 == 0) { inflateUpgradesStatsTEXT.text = LocalizationStrings.inflateUpgradesStats + "0" + LocalizationStrings.moreCoins; }
        if (AscendScreen.boughtSale1 == 0) { inflateCheaperStatsTEXT.text = LocalizationStrings.inflateCheaperStats + "0" + cheaper; }
        if (AscendScreen.boughtBagOfCoins1 == 0) { inflateStartWithCoinsStatsTEXT.text = LocalizationStrings.inflateStartWithCoinsStats + "0" + LocalizationStrings.coinsAfterInflating; }
        if (AscendScreen.boughtActiveFlipper1 == 0) { inflateActiveStatsTEXT.text = LocalizationStrings.inflateActiveStats + "0" + LocalizationStrings.moreCoins; }



        #endregion

        #region achievements

        achievements.text = "달성"; achievements.font = nonoSansKoreanBold;
        ach1.text = "1코인 얻기"; ach1.font = nonoSansKoreanBold;
        ach2.text = "10코인 얻기"; ach2.font = nonoSansKoreanBold;
        ach3.text = "100코인 얻기"; ach3.font = nonoSansKoreanBold;
        ach4.text = "1000코인 얻기"; ach4.font = nonoSansKoreanBold;
        ach5.text = "10000코인 얻기"; ach5.font = nonoSansKoreanBold;
        ach6.text = "100000코인 얻기"; ach6.font = nonoSansKoreanBold;
        ach7.text = "1밀리언 코인 얻기"; ach7.font = nonoSansKoreanBold;
        ach8.text = "1빌리언 코인 얻기"; ach8.font = nonoSansKoreanBold;
        ach9.text = "1트릴리언 코인 얻기!"; ach9.font = nonoSansKoreanBold;
        ach10.text = "1콰드릴리언 코인 얻기!"; ach10.font = nonoSansKoreanBold;
        ach11.text = "1퀸틸리언 코인 얻기!"; ach11.font = nonoSansKoreanBold;
        ach12.text = "1섹스틸리언 코인 얻기!"; ach12.font = nonoSansKoreanBold;
        ach13.text = "1셉틸리언 코인 얻기!"; ach13.font = nonoSansKoreanBold;
        ach14.text = "1옥틸리언 코인 얻기!"; ach14.font = nonoSansKoreanBold;
        ach15.text = "힘센 팔 1회 업그레이드"; ach15.font = nonoSansKoreanBold;
        ach16.text = "힘센 팔 10회 업그레이드"; ach16.font = nonoSansKoreanBold;
        ach17.text = "위대한 동전 1회 업그레이드"; ach17.font = nonoSansKoreanBold;
        ach18.text = "위대한 동전 10회 업그레이드"; ach18.font = nonoSansKoreanBold;
        ach19.text = "지식 1회 업그레이드"; ach19.font = nonoSansKoreanBold;
        ach20.text = "지식 10회 업그레이드"; ach20.font = nonoSansKoreanBold;
        ach21.text = "힘센 주먹 1회 업그레이드"; ach21.font = nonoSansKoreanBold;
        ach22.text = "힘센 주먹 10회 업그레이드"; ach22.font = nonoSansKoreanBold;
        ach23.text = "손 주사 1회 업그레이드"; ach23.font = nonoSansKoreanBold;
        ach24.text = "손 주사 10회 업그레이드"; ach24.font = nonoSansKoreanBold;
        ach25.text = "브레인 파워 1회 업그레이드"; ach25.font = nonoSansKoreanBold;
        ach26.text = "브레인 파워 10회 업그레이드"; ach26.font = nonoSansKoreanBold;
        ach27.text = "폭발적 뒤집기 1회 업그레이드"; ach27.font = nonoSansKoreanBold;
        ach28.text = "폭발적 뒤집기 10회 업그레이드"; ach28.font = nonoSansKoreanBold;
        ach29.text = "수분 보충 1회 업그레이드"; ach29.font = nonoSansKoreanBold;
        ach30.text = "수분 보충 10회 업그레이드"; ach30.font = nonoSansKoreanBold;
        ach31.text = "이상한 물약 1회 업그레이드"; ach31.font = nonoSansKoreanBold;
        ach32.text = "이상한 물약 10회 업그레이드"; ach32.font = nonoSansKoreanBold;
        ach33.text = "뒤집기 마스터 1회 업그레이드"; ach33.font = nonoSansKoreanBold;
        ach34.text = "뒤집기 마스터 10회 업그레이드"; ach34.font = nonoSansKoreanBold;
        ach35.text = "악수 1회 업그레이드"; ach35.font = nonoSansKoreanBold;
        ach36.text = "악수 10회 업그레이드"; ach36.font = nonoSansKoreanBold;
        ach37.text = "마법 던지기 업그레이드 한 번"; ach37.font = nonoSansKoreanBold; ach37.fontSize = 8.4f;
        ach38.text = "법 던지기 업그레이드 10번"; ach38.font = nonoSansKoreanBold; ach38.fontSize = 8.4f;
        ach39.text = "행운의 동전을 얻을 확률을 2.5%로 높이세요"; ach39.font = nonoSansKoreanBold;
        ach40.text = "행운의 동전을 얻을 확률을 5%로 높이세요"; ach40.font = nonoSansKoreanBold;
        ach41.text = "행운의 동전 1개를 던지세요"; ach41.font = nonoSansKoreanBold;
        ach42.text = "행운의 동전 10개를 던지세요"; ach42.font = nonoSansKoreanBold;
        ach43.text = "행운의 동전 100개를 던지세요"; ach43.font = nonoSansKoreanBold;
        ach44.text = "100 개의 코인을 뒤집으세요"; ach44.font = nonoSansKoreanBold;
        ach45.text = "1000 개의 코인을 뒤집으세요"; ach45.font = nonoSansKoreanBold;
        ach46.text = "10000 개의 코인을 뒤집으세요"; ach46.font = nonoSansKoreanBold;
        ach47.text = "100000 개의 코인을 뒤집으세요"; ach47.font = nonoSansKoreanBold;
        ach49.text = "2개의 코인을 동시에 뒤집으세요"; ach49.font = nonoSansKoreanBold;
        ach50.text = "5개의 코인을 동시에 뒤집으세요"; ach50.font = nonoSansKoreanBold;
        ach51.text = "10개의 코인을 동시에 뒤집으세요"; ach51.font = nonoSansKoreanBold;
        ach94.text = "21개의 코인을 동시에 뒤집으세요"; ach94.font = nonoSansKoreanBold;
        ach52.text = "1개의 코인 플리퍼를 업그레이드하세요"; ach52.font = nonoSansKoreanBold;
        ach53.text = "5개의 코인 플리퍼를 업그레이드하세요"; ach53.font = nonoSansKoreanBold;
        ach54.text = "10개의 코인 플리퍼를 업그레이드하세요"; ach54.font = nonoSansKoreanBold;
        ach55.text = "21개의 코인 플리퍼를 업그레이드하세요"; ach55.font = nonoSansKoreanBold;
        ach56.text = "75%로 코인 뒤집기에 성공하세요"; ach56.font = nonoSansKoreanBold;
        ach57.text = "93.75%로 코인 뒤집기에 성공하세요"; ach57.font = nonoSansKoreanBold;
        ach58.text = "모든 코인을 동시에 뒤집으세요!"; ach58.font = nonoSansKoreanBold;
        ach59.text = "백만개의 코인을 뒤집으세요!"; ach59.font = nonoSansKoreanBold;
        ach60.text = "행운의 동전 1000개를 던지세요!"; ach60.font = nonoSansKoreanBold;
        ach61.text = "뒷면을 100000번 던지세요!"; ach61.font = nonoSansKoreanBold;
        ach62.text = "앞면을 100000번 던지세요!"; ach62.font = nonoSansKoreanBold;
        ach63.text = "챌린지#1을 완료하세요"; ach63.font = nonoSansKoreanBold;
        ach64.text = "챌린지#2을 완료하세요"; ach64.font = nonoSansKoreanBold;
        ach65.text = "챌린지#3을 완료하세요"; ach65.font = nonoSansKoreanBold;
        ach66.text = "챌린지#4을 완료하세요"; ach66.font = nonoSansKoreanBold;
        ach67.text = "자동 업그레이드를 잠금해제하세요"; ach67.font = nonoSansKoreanBold;
        ach68.text = "코인을 적극적으로 100번 뒤집으세요!"; ach68.font = nonoSansKoreanBold;
        ach69.text = "코인을 적극적으로 1000번 뒤집으세요!"; ach69.font = nonoSansKoreanBold;
        ach70.text = "코인을 적극적으로 5000번 뒤집으세요!"; ach70.font = nonoSansKoreanBold;
        ach71.text = "보물 상자 1회 구매"; ach71.font = nonoSansKoreanBold;
        ach72.text = "보물 상자 10회 구매"; ach72.font = nonoSansKoreanBold;
        ach73.text = "코인 뒤집기 의식 1회 구매"; ach73.font = nonoSansKoreanBold;
        ach74.text = "코인 뒤집기 의식 10회 구입"; ach74.font = nonoSansKoreanBold;
        ach75.text = "하이파이브 1회 업그레이드."; ach75.font = nonoSansKoreanBold;
        ach76.text = "하이파이브 10회 업그레이드"; ach76.font = nonoSansKoreanBold;
        ach77.text = "총 25개의 인플레이션 코인을 보유하세요"; ach77.font = nonoSansKoreanBold;
        ach78.text = "총 50개의 인플레이션 코인을 보유하세요"; ach78.font = nonoSansKoreanBold;
        ach79.text = "총 75개의 인플레이션 코인을 보유하세요"; ach79.font = nonoSansKoreanBold;
        ach80.text = "5회 인플레이션 업그레이드를 잠금해제하세요"; ach80.font = nonoSansKoreanBold;
        ach81.text = "10회 인플레이션 업그레이드를 잠금해제하세요"; ach81.font = nonoSansKoreanBold;
        ach82.text = "20회 인플레이션 업그레이드를 잠금해제하세요"; ach82.font = nonoSansKoreanBold;
        ach83.text = "30회 인플레이션 업그레이드를 잠금해제하세요"; ach83.font = nonoSansKoreanBold;
        ach84.text = "모든 인플레이션 업그레이드를 잠금해제하세요"; ach84.font = nonoSansKoreanBold;
        ach85.text = "코인 더미를 10회 클릭하세요"; ach85.font = nonoSansKoreanBold;
        ach86.text = "코인 더미를 100회 클릭하세요"; ach86.font = nonoSansKoreanBold;
        ach87.text = "인플레이션하세요!"; ach87.font = nonoSansKoreanBold;
        ach88.text = "5회 인플레이션 하세요!"; ach88.font = nonoSansKoreanBold;
        ach89.text = "10회 도박하세요"; ach89.font = nonoSansKoreanBold;
        ach90.text = "5번 코인을 모두 잃었습니다"; ach90.font = nonoSansKoreanBold;
        ach91.text = "5번 코인을 두배로 불렸습니다"; ach91.font = nonoSansKoreanBold;
        ach92.text = "숨겨진 브론즈 코인을 찾으세요!"; ach92.font = nonoSansKoreanBold;
        ach93.text = "숨겨진 실버 코인을 찾으세요!"; ach93.font = nonoSansKoreanBold;


        #endregion

        #region InflationTree

        inflate.text = "인플레이션"; inflate.font = nonoSansKoreanBold; inflate.fontSize = 15;
        youHave21Flippers.text = "21 코인플리퍼를 보유하고 있습니다!"; youHave21Flippers.font = nonoSansKoreanBold;
        youNeed21Flippers.text = "인플레이션하려면 21 코인 플리퍼가 필요합니다!"; youNeed21Flippers.font = nonoSansKoreanBold; youNeed21Flippers.fontSize = 15f;
        youCanViewTreeAtAnyTime.text = "(언제든지 인플레이션 나무를 확인할 수 있습니다)"; youCanViewTreeAtAnyTime.font = nonoSansKoreanBold;
        youCanViewTreeAtAnyTime.fontSize = 14;
        smallInflationDescription.text = "업그레이드시 (몇 가지를 제외한) 현재 스탯은 모두 리셋되며 특별한 영구 업그레이드 화면으로 넘어갑니다"; smallInflationDescription.font = notoSansKorean;
        smallInflationDescription.fontSize = 15;
        thisIsHowInflationWorks.text = "인플레이션 시스템이 작동하는 방법은 다음과 같습니다:"; thisIsHowInflationWorks.font = nonoSansKoreanBold;
        thisIsHowInflationWorks.fontSize = 9;
        bigInflationDescription.text = "-다음 코인 등급의 1/4을 달성할 때마다 인플레이션 코인을 얻습니다\n-코인 등급은 밀리언, 빌리언, 트릴리언으로 이어집니다\n-예시: 1 밀리언을 달성하면 첫 인플레이션 코인을 얻습니다. 그 후로 1 밀리언, 250 밀리언, 500 밀리언, 750 밀리언, 1 빌리언, 250 빌리언, 500 빌리언, 750 빌리언과 같이 이후로도 달성할 때마다 인플레이션 코인을 얻을 수 있습니다\n"; bigInflationDescription.font = nonoSansKoreanBold; bigInflationDescription.fontSize = 7.6f;
        youHave.text = "인플레이션 코인:"; youHave.font = nonoSansKoreanBold; youHave.fontSize = 8;
        inflationCoins.text = ""; inflationCoins.font = nonoSansKoreanBold;
        dontInflateJustLook.text = "인플레이션 대신 나무에만 집중하세요"; dontInflateJustLook.font = nonoSansKoreanBold; dontInflateJustLook.fontSize = 23;
        doYouWishToInflate.text = "인플레이션 하시겠습니까?"; doYouWishToInflate.font = nonoSansKoreanBold; doYouWishToInflate.fontSize = 20;
        YES.text = "예"; YES.font = notoSansKorean;
        NO.text = "아니오"; NO.font = notoSansKorean; NO.fontSize = 8;
        currentlyOnlyViewingTree.text = "! 현재 인플레이션 나무만을 볼 수 있으며 업그레이드를 구매할 수 없습니다";
        currentlyOnlyViewingTree.font = notoSansKorean;
        backToFlipping.text = "다시 뒤집으러 가기"; backToFlipping.font = notoSansKorean; backToFlipping.fontSize = 25;
        backToFlipping2.text = "다시 뒤집으러 가기"; backToFlipping2.font = nonoSansKoreanBold; backToFlipping2.fontSize = 22;
        inflationCoinsText = "인플레이션 코인: ";
        InflationCoins.text = inflationCoinsText + AscendCoins.ascensionCoinAmount; InflationCoins.fontSize = 23; InflationCoins.font = nonoSansKoreanBold;

        rich1.text = "리치 I"; rich1.font = nonoSansKoreanBold;
        rich2.text = "리치 II"; rich2.font = nonoSansKoreanBold;
        rich3.text = "리치 III"; rich3.font = nonoSansKoreanBold;
        rich4.text = "리치 IV"; rich4.font = nonoSansKoreanBold;
        rich5.text = "리치 V"; rich5.font = nonoSansKoreanBold;
        rich6.text = "리치 VI"; rich6.font = nonoSansKoreanBold;
        rich7.text = "리치 VII"; rich7.font = nonoSansKoreanBold;
        omegaRich.text = "오메가 리치"; omegaRich.font = nonoSansKoreanBold;

        rich1Desc.text = "모든 업그레이드시 1% 더 많은 코인을 얻습니다\n리치 업그레이드는 모든 챌린지에 적용됩니다"; rich1Desc.font = nonoSansKoreanBold;
        rich1Desc.fontSize = 15;
        rich2Desc.text = "모든 업그레이드시 20% 더 많은 코인을 얻습니다"; rich2Desc.font = nonoSansKoreanBold;
        rich3Desc.text = "모든 업그레이드시 50% 더 많은 코인을 얻습니다"; rich3Desc.font = nonoSansKoreanBold;
        rich4Desc.text = "모든 업그레이드시 100% 더 많은 코인을 얻습니다"; rich4Desc.font = nonoSansKoreanBold;
        rich5Desc.text = "모든 업그레이드시 175% 더 많은 코인을 얻습니다"; rich5Desc.font = nonoSansKoreanBold;
        rich6Desc.text = "모든 업그레이드시 300% 더 많은 코인을 얻습니다"; rich6Desc.font = nonoSansKoreanBold;
        rich7Desc.text = "모든 업그레이드시 750% 더 많은 코인을 얻습니다"; rich7Desc.font = nonoSansKoreanBold;
        omegaRichDes.text = "모든 업그레이드시 1250% 더 많은 코인을 얻습니다"; omegaRichDes.font = nonoSansKoreanBold;

        sale1.text = "세일 I"; sale1.font = nonoSansKoreanBold;
        sale2.text = "세일 II"; sale2.font = nonoSansKoreanBold;
        sale3.text = "세일 III"; sale3.font = nonoSansKoreanBold;
        sale4.text = "세일 IV"; sale4.font = nonoSansKoreanBold;
        steamSale.text = "스팀 세일"; steamSale.font = nonoSansKoreanBold; steamSale.fontSize = 22;
        sale1Desc.text = "모든 업그레이드가 2% 저렴해집니다. 이 업그레이드 가지는 스페셜 업그레이드에 영향을 주지 않습니다"; sale1Desc.font = nonoSansKoreanBold; sale1Desc.fontSize = 14;
        sale2Desc.text = "모든 업그레이드가 7% 저렴해집니다"; sale2Desc.font = nonoSansKoreanBold;
        sale3Desc.text = "모든 업그레이드가 14% 저렴해집니다"; sale3Desc.font = nonoSansKoreanBold;
        sale4Desc.text = "모든 업그레이드가 22% 저렴해집니다"; sale4Desc.font = nonoSansKoreanBold;
        steamSaleDesc.text = "모든 업그레이드가 50% 저렴해집니다"; steamSaleDesc.font = nonoSansKoreanBold;

        bag1.text = "코인 자루 I"; bag1.font = nonoSansKoreanBold;
        bag2.text = "코인 자루 II"; bag2.font = nonoSansKoreanBold;
        bag3.text = "코인 자루 III"; bag3.font = nonoSansKoreanBold;
        bag4.text = "코인 자루 IV"; bag4.font = nonoSansKoreanBold;
        hugeBag.text = "거대한 동전 주머니"; hugeBag.font = nonoSansKoreanBold;
        pileOfBags.text = "자루 더미"; pileOfBags.font = nonoSansKoreanBold;

        bag1Desc.text = "인플레이션 이후 총 75개의 코인으로 게임을 시작합니다\n코인 자루는 «자동 뒤집기 없음» 챌린지에서만 적용됩니다"; bag1Desc.font = nonoSansKoreanBold;
        bag2Desc.text = "인플레이션 이후 총 500개의 코인으로 게임을 시작합니다"; bag2Desc.font = nonoSansKoreanBold;
        bag3Desc.text = "인플레이션 이후 총 3000개의 코인으로 게임을 시작합니다"; bag3Desc.font = nonoSansKoreanBold;
        bag4Desc.text = "인플레이션 이후 총 20000개의 코인으로 게임을 시작합니다"; bag4Desc.font = nonoSansKoreanBold;
        hugeBasDesc.text = "인플레이션 이후 총 100000개의 코인으로 게임을 시작합니다"; hugeBasDesc.font = nonoSansKoreanBold;
        pileOfBagsDesc.text = "코인 더미를 클릭할 때마다, 인플레이션 이후 가지고 시작하는 코인 개수가+250개씩 늘어납니다"; pileOfBagsDesc.font = nonoSansKoreanBold;

        greaterInflation1.text = "위대한 인플레이션 I"; greaterInflation1.font = nonoSansKoreanBold;
        greaterInflation2.text = "위대한 인플레이션 II"; greaterInflation2.font = nonoSansKoreanBold;
        greaterInflation3.text = "위대한 인플레이션 III"; greaterInflation3.font = nonoSansKoreanBold;
        greaterInflation4.text = "위대한 인플레이션 IV"; greaterInflation4.font = nonoSansKoreanBold;
        greaterInflation5.text = "위대한 인플레이션 V"; greaterInflation5.font = nonoSansKoreanBold;
        crazyInflation.text = "크레이지 인플레이션!!"; crazyInflation.font = nonoSansKoreanBold; crazyInflation.fontSize = 17;
        inflationGamble1.text = "인플레이션 돱ㄱ I"; inflationGamble1.font = nonoSansKoreanBold; inflationGamble1.fontSize = 17;
        inflationGamble2.text = "인플레이션 돱ㄱ II"; inflationGamble2.font = nonoSansKoreanBold; inflationGamble2.fontSize = 17;
        inflationGamble3.text = "인플레이션 돱ㄱ III"; inflationGamble3.font = nonoSansKoreanBold; inflationGamble3.fontSize = 17;
        inflationGamble4.text = "인플레이션 돱ㄱ IV"; inflationGamble4.font = nonoSansKoreanBold; inflationGamble4.fontSize = 17;

        greaterInflation1Desc.text = "콰드릴리언 등급 이상을 달성하면 인플레이션 코인이 +2개 추가됩니다\n모든 인플레이션 업그레이드는 «언제나 럭키» 챌린지를 제외한 모든 챌린지에서 적용됩니다"; greaterInflation1Desc.font = nonoSansKoreanBold;
        greaterInflation2Desc.text = "콰드릴리언 등급 이상을 달성하면 인플레이션 코인이 +3개 추가됩니다"; greaterInflation2Desc.font = nonoSansKoreanBold;
        greaterInflation3Desc.text = "빌리언 등급 이상을 달성하면 인플레이션 코인이 +2개 추가됩니다\n콰드릴리언 등급 이상을 달성하면 인플레이션 코인이 +3개 추가됩니다"; greaterInflation3Desc.font = nonoSansKoreanBold;
        greaterInflation4Desc.text = "트릴리언 등급 이상을 달성하면 인플레이션 코인이 +3개 추가됩니다\n퀸틸리언 등급 이상을 달성하면 인플레이션 코인이 4 개 추가됩니다"; greaterInflation4Desc.font = nonoSansKoreanBold;
        greaterInflation5Desc.text = "트릴리언 등급 이상을 달성하면 인플레이션 코인이 +4개 추가됩니다\n섹스틸리언 등급 이상을 달성하면 인플레이션 코인이 +5개 추가됩니다"; greaterInflation5Desc.font = nonoSansKoreanBold;
        crazyInflationDesc.text = "밀리언 등급 이상을 달성하면 인플레이션 코인이 +6개 추가됩니다"; crazyInflationDesc.font = nonoSansKoreanBold;
        inflationGamble1Desc.text = "인플레이션 코인을 얻을 때마다 3% 확률로 1개의 인플레이션 코인을 추가로 얻습니다"; inflationGamble1Desc.font = nonoSansKoreanBold;
        inflationGamble2Desc.text = "인플레이션 코인을 얻을 때마다 4% 확률로 1개의 인플레이션 코인을 추가로 얻습니다"; inflationGamble2Desc.font = nonoSansKoreanBold;
        inflationGamble3Desc.text = "인플레이션 코인을 얻을 때마다 5% 확률로 1개의 인플레이션 코인을 추가로 얻습니다"; inflationGamble3Desc.font = nonoSansKoreanBold;
        inflationGamble4Desc.text = "인플레이션 코인을 얻을 때마다 6% 확률로 1개의 인플레이션 코인을 추가로 얻습니다"; inflationGamble4Desc.font = nonoSansKoreanBold;

        extraSpecialUpgrade1.text = "엑스트라 스페셜 업그레이드 I"; extraSpecialUpgrade1.font = nonoSansKoreanBold; extraSpecialUpgrade1.fontSize = 15;
        extraSpecialUpgrade2.text = "엑스트라 스페셜 업그레이드 II"; extraSpecialUpgrade2.font = nonoSansKoreanBold; extraSpecialUpgrade2.fontSize = 15;
        extraSpecialUpgrade3.text = "엑스트라 스페셜 업그레이드 III"; extraSpecialUpgrade3.font = nonoSansKoreanBold; extraSpecialUpgrade3.fontSize = 15;
        extraExtraSpecialUpgrade1.text = "엑스트라 엑스트라 스페셜 업그레이드"; extraExtraSpecialUpgrade1.font = nonoSansKoreanBold; extraExtraSpecialUpgrade1.fontSize = 13;
        biggerPile1.text = "더 큰 코인 더미 I"; biggerPile1.font = nonoSansKoreanBold;
        biggerPile2.text = "더 큰 코인 더미 II"; biggerPile2.font = nonoSansKoreanBold;
        theGambler.text = "도박꾼"; theGambler.font = nonoSansKoreanBold;
        getLuckier.text = "행운 빌기"; getLuckier.font = nonoSansKoreanBold;
        autoUpgradeInflate.text = "자동 업그레이드"; autoUpgradeInflate.font = nonoSansKoreanBold;

        extraSpecialUpgrade1Desc.text = "도박시 2회의 기회가 더 주어집니다\n이 계열을 업그레이드할 때마다 모든 스페셜 업그레이드 비용이 1%씩 절감되며 모든 챌린지에 적용됩니다"; extraSpecialUpgrade1Desc.font = nonoSansKoreanBold; extraSpecialUpgrade1Desc.fontSize = 12.6f;
        extraSpecialUpgrade2Desc.text = "이제 도박시 코인이 2배가 될 확률이 51%입니다\n코인 더미가 더 많은 코인을 생성합니다"; extraSpecialUpgrade2Desc.font = nonoSansKoreanBold;
        extraSpecialUpgrade3Desc.text = "코인 더미에서 코인을 가져갈 때, 5% 확률로 코인이 더미에 남습니다"; extraSpecialUpgrade3Desc.font = nonoSansKoreanBold;
        extraExtraSpecialUpgrade1Desc.text = "스페셜 업그레이드시 비용이 13% 절감됩니다\n도박시 기회가 1번 더 주어집니다\n코인을 생성하는 코인 더미가 2개 추가됩니다\n업그레이드된 코인 뒤집기시 코인을 3배 더 얻으며 행운의 동전을 뒤집을 경우 15배 더 얻습니다"; extraExtraSpecialUpgrade1Desc.font = nonoSansKoreanBold;
        extraExtraSpecialUpgrade1Desc.fontSize = 11.6f;
        biggerPile1Desc.text = "코인 더미가 1개 더 추가됩니다\n코인 더미에서 코인이 더 많이 생성됩니다"; biggerPile1Desc.font = nonoSansKoreanBold;
        biggerPile2Desc.text = "코인 더미가 1개 더 추가됩니다\n코인더미에서 그보다 더 많은 코인이 생성됩니다"; biggerPile2Desc.font = nonoSansKoreanBold;
        theGamblerDesc.text = "도박시 기회가 1번 더 주어집니다\n도박할 때마다 코인이 2배가 될 확률이 1%씩 올라갑니다"; theGamblerDesc.font = nonoSansKoreanBold;
        getLuckierDesc.text = "행운의 동전을 던질 때마다, 5% 확률로 50배 코인을 얻을 수 있는 더욱 행운의 동전이 될 수 있습니다"; getLuckierDesc.font = nonoSansKoreanBold; getLuckierDesc.fontSize = 12;
        autoUpgradeDesc.text = "스페셜 업그레이드 탭에 있는 자동 업그레이드를 잠금 해제합니다"; autoUpgradeDesc.font = nonoSansKoreanBold;

        active1.text = "액티브 플리퍼 I"; active1.font = nonoSansKoreanBold; active1.fontSize = 17;
        active2.text = "액티브 플리퍼 II"; active2.font = nonoSansKoreanBold; active2.fontSize = 17;
        active3.text = "액티브 플리퍼 III"; active3.font = nonoSansKoreanBold; active3.fontSize = 17;
        active4.text = "액티브 플리퍼 IV"; active4.font = nonoSansKoreanBold; active4.fontSize = 17;
        superActiveFlipper.text = "슈퍼 액티브 플리퍼"; superActiveFlipper.font = nonoSansKoreanBold; superActiveFlipper.fontSize = 17;
        activeEqualsBiggerPile.text = "액티브 = 더 큰 코인 더미"; activeEqualsBiggerPile.font = nonoSansKoreanBold; activeEqualsBiggerPile.fontSize = 13;

        active1Desc.text = "적극적으로 코인을 뒤집을 때마다 코인을 8% 추가로 얻습니다\n액티브 플리퍼는 모든 챌린지에서 적용됩니다"; active1Desc.font = nonoSansKoreanBold; active1Desc.fontSize = 12;
        active2Desc.text = "적극적으로 코인을 뒤집을 때마다 코인을 23% 추가로 얻습니다"; active2Desc.font = nonoSansKoreanBold;
        active3Desc.text = "적극적으로 코인을 뒤집을 때마다 코인을 40% 추가로 얻습니다"; active3Desc.font = nonoSansKoreanBold;
        active4Desc.text = "적극적으로 코인을 뒤집을 때마다 코인을 69% 추가로 얻습니다"; active4Desc.font = nonoSansKoreanBold;
        superActiveFlipperDesc.text = "적극적으로 코인을 뒤집을 때마다 코인을 300% 추가로 얻습니다\n행운의 동전은 10배입니다"; superActiveFlipperDesc.font = nonoSansKoreanBold;
        activeEqualsBiggerPileDesc.text = "적극적으로 코인을 뒤집을 때마다, 5% 확률로 보유하고 있는 앞/뒷면 코인의 양만큼이 코인 더미에 더해집니다"; activeEqualsBiggerPileDesc.font = nonoSansKoreanBold;
        backToFlippingIflated.text = "다시 코인 뒤집기로 가시겠습니까?"; backToFlippingIflated.font = nonoSansKoreanBold;
        yes.text = "예"; yes.font = nonoSansKoreanBold; no.text = "아니오"; no.font = nonoSansKoreanBold;

        for (int i = 0; i < unLocked.Length; i++)
        {
            unLocked[i].text = "잠금";
            unLocked[i].font = notoSansKorean;
            unLocked[i].fontSize = 14;
        }

        for (int i = 0; i < locked.Length; i++)
        {
            locked[i].text = "잠금해제";
            locked[i].font = notoSansKorean;
            locked[i].fontSize = 12;
        }


        #endregion

        #region settings

        music.text = "음악"; music.font = nonoSansKoreanBold; audiotext.text = "오디오"; audiotext.font = nonoSansKoreanBold;
        fullscreen.text = "전체 화면"; fullscreen.font = notoSansKorean;
        saveGame.text = "게임 저장하기"; saveGame.font = nonoSansKoreanBold;
        exitGame.text = "게임 나가기"; exitGame.font = nonoSansKoreanBold; resetEverything.text = "리셋하기"; resetEverything.font = nonoSansKoreanBold;
        gameIsSaved30Seconds.text = "(게임은 30초마다 자동 저장됩니다)"; gameIsSaved30Seconds.font = nonoSansKoreanBold;
        foundHiddenBronze.text = "숨겨진 브론즈 코인을 찾았습니다!"; foundHiddenBronze.font = nonoSansKoreanBold;
        foundHiddenSilver.text = "숨겨진 실버 코인을 찾았씁니다!"; foundHiddenSilver.font = nonoSansKoreanBold;
        settings.text = "설정"; settings.font = notoSansKorean; settings.fontSize = 27;
        info.text = "정보"; info.font = notoSansKorean; info.fontSize = 27;
        socials.text = "소셜미디어"; socials.font = notoSansKorean; socials.fontSize = 12;
        generalGameInfo.text = "게임 정보"; generalGameInfo.font = notoSansKorean;
        mechanicsExplanations.text = "기술 설명"; mechanicsExplanations.font = notoSansKorean;

        inflationSystem.text = "인플레이션 시스템"; inflationSystem.font = notoSansKorean;
        inflationSystemDesc.text = "-다음 코인 등급의 1/4을 달성할 때마다 인플레이션 코인을 얻습니다\n-코인 등급은 밀리언, 빌리언, 트릴리언으로 이어집니다\n-예시: 1 밀리언을 달성하면 첫 인플레이션 코인을 얻습니다. 그 후로 1 밀리언, 250 밀리언, 500 밀리언, 750 밀리언, 1 빌리언, 250 빌리언, 500 빌리언, 750 빌리언과 같이 이후로도 달성할 때마다 인플레이션 코인을 얻을 수 있습니다\n"; inflationSystemDesc.font = notoSansKorean;
        inflationSystemDesc.fontSize = 13;

        pileOfCoinsText.text = "코인 더미"; pileOfCoinsText.font = notoSansKorean;
        pileOfCoinsDesc.text = "코인 더미에서 생성되는 코인의 양은 성공적인 뒤집기마다 보유한 코인의 수와 코인 플리퍼의 수 +4에 따라 정해집니다. 예를 들어 150개의 앞/뒷면 코인과 4개의 코인 플리퍼를 가지고 있다면, 150 * (4+4)에 해당하는 1200개의 코인이 생성됩니다. «엑스트라 스페셜 업그레이드» 인플레이션 업그레이드를 구매한 경우 생성되는 코인은 늘어납니다"; pileOfCoinsDesc.font = notoSansKorean;
        pileOfCoinsDesc.fontSize = 13;

        offlineProgression.text = "오프라인 진행"; offlineProgression.font = notoSansKorean;
        offlineProgressionDesc.text = "오프라인 상태에서 매분마다 코인을 얻습니다. 보유한 자동 플리퍼와 앞/뒷면 코인의 수에 따라 그 양이 달라집니다. 예를 들어 50만개의 앞/뒷면 코인과 4개의 자동 플리퍼를 보유하고 있다면, 매분 200만 (2 밀리언)개의 코인을 얻을 수 있습니다"; offlineProgressionDesc.font = notoSansKorean; offlineProgressionDesc.fontSize = 13;

        developerBy.text = "코인 플리퍼(Coin Flipper) 개발자: <b>Simon Eftestøl</b>"; developerBy.font = notoSansKorean;
        musicBy.text = "음악: <b>HSB Loops</b>"; musicBy.font = notoSansKorean;
        texturesProvidedBy.text = "텍스쳐: <b>Free SVG</b>"; texturesProvidedBy.font = notoSansKorean;
        followMyTwitch.text = "트위치 계정을 팔로우하세요"; followMyTwitch.font = notoSansKorean;
        follotMyTwitter.text = "내 X를 팔로우하세요!"; follotMyTwitter.font = notoSansKorean;
        joinTheDiscord.text = "디스코드에 가입하세요!"; joinTheDiscord.font = notoSansKorean;
        quitPlayingChallenge.text = "그만두기 도전?"; quitPlayingChallenge.font = notoSansKorean;
        quitChallengeDesc.text = "게임은 초기화되어 \"앞면 또는 뒷면 선택\" 화면으로 돌아갑니다. 모든 영구적인 인플레이션 업그레이드는 물론 초기화되지 않습니다"; quitChallengeDesc.font = notoSansKorean;
        quitChalYes.text = "예"; quitChalYes.font = nonoSansKoreanBold;
        quitChalNo.text = "아니오"; quitChalNo.font = nonoSansKoreanBold;
        whishToResetGame.text = "완전히 다시 시작하시겠습니까?"; whishToResetGame.font = notoSansKorean;
        wishToResetDesc.text = "모든 것이 초기화되고 처음부터 시작합니다"; wishToResetDesc.font = notoSansKorean;
        resetYes.text = "예"; resetYes.font = nonoSansKoreanBold;
        resetNo.text = "아니오"; resetNo.font = nonoSansKoreanBold;
        quitChall1.text = "그만두기 도전"; quitChall1.font = nonoSansKoreanBold; quitChall1.fontSize = 36;
        quitChall2.text = "그만두기 도전"; quitChall2.font = nonoSansKoreanBold; quitChall2.fontSize = 36;
        quitChall3.text = "그만두기 도전"; quitChall3.font = nonoSansKoreanBold; quitChall3.fontSize = 36;
        quitChall4.text = "그만두기 도전"; quitChall4.font = nonoSansKoreanBold; quitChall4.fontSize = 36;
        gameSaved.text = "게임이 저장되었습니다"; gameSaved.font = notoSansKorean;
        gameSaved2.text = "게임이 저장되었습니다"; gameSaved2.font = notoSansKorean;

        #endregion

        #region offlineEarnings

        days = "일 "; hours = "시간 "; minuts = "분 "; secondsTime = "초";

        offlineEarningTotalText.font = nonoSansKoreanBold;
        timeGoneText.font = nonoSansKoreanBold;

        welcomeBack.text = "돌아오신 걸 환영해요"; welcomeBack.font = nonoSansKoreanBold;
        youWereGoneFor.text = "자리를 비운 시간:"; youWereGoneFor.font = notoSansKorean;
        offlineEarnings.text = "오프라인 보상: "; offlineEarnings.font = notoSansKorean;
        offlineOK.text = "오케이"; offlineOK.font = nonoSansKoreanBold; offlineOK.fontSize = 30;

        #endregion

        #region FINAL missed

        upgradesHover.text = "업그레이드"; upgradesHover.font = nonoSansKoreanBold; upgradesHover.fontSize = 32;
        specialUpgradesHover.text = "스페셜 업그레이드"; specialUpgradesHover.font = nonoSansKoreanBold; specialUpgradesHover.fontSize = 32;
        achievementsHover.text = "달성"; achievementsHover.font = nonoSansKoreanBold; achievementsHover.fontSize = 29;
        statsHover.text = "통계"; statsHover.font = nonoSansKoreanBold; statsHover.fontSize = 36;

        specialIpgradeWarning.text = "업그레이드된 코인 뒤집기가 기본적으로 자동화됩니다. 이 업그레이드를 구매하기 전 «자동 코인 뒤집기»를 구매해야 합니다";
        specialIpgradeWarning.font = nonoSansKoreanBold; specialIpgradeWarning.fontSize = 8;

        congrats1.text = "축하합니다!"; congrats1.font = nonoSansKoreanBold;
        congrats2.text = "축하합니다!"; congrats2.font = nonoSansKoreanBold;
        congrats3.text = "축하합니다!"; congrats3.font = nonoSansKoreanBold;
        congrats4.text = "축하합니다!"; congrats4.font = nonoSansKoreanBold;
        youUnlocked1.text = "다음을 잠금해제했습니다:"; youUnlocked1.font = nonoSansKoreanBold; youUnlocked1.fontSize = 11;
        youUnlocked2.text = "다음을 잠금해제했습니다:"; youUnlocked2.font = nonoSansKoreanBold; youUnlocked2.fontSize = 11;
        youUnlocked3.text = "다음을 잠금해제했습니다:"; youUnlocked3.font = nonoSansKoreanBold; youUnlocked3.fontSize = 11;
        youUnlocked4.text = "다음을 잠금해제했습니다:"; youUnlocked4.font = nonoSansKoreanBold; youUnlocked4.fontSize = 11;
        youCompletedChal1.text = "챌린지 #1 – «자동 뒤집기 없음»을 완료했습니다"; youCompletedChal1.font = nonoSansKoreanBold;
        youCompletedChal2.text = "챌린지 #2 – «언럭키»를 완료했습니다"; youCompletedChal2.font = nonoSansKoreanBold;
        youCompletedChal3.text = "챌린지 #3 – «1 코인 플리퍼»를 완료했습니다"; youCompletedChal3.font = nonoSansKoreanBold;
        youCompletedChal4.text = "챌린지 #4 – «럭키»를 완료했습니다"; youCompletedChal4.font = nonoSansKoreanBold;
        completedChalFlipAll.text = "모두 뒤집으세요"; completedChalFlipAll.font = nonoSansKoreanBold;
        completedChallAutoFlipsEquals.text = "자동 뒤집기 ="; completedChallAutoFlipsEquals.font = nonoSansKoreanBold; completedChallAutoFlipsEquals.fontSize = 25;
        onText.text = "켜기"; onText.font = nonoSansKoreanBold;
        onText2.text = "켜기"; onText2.font = nonoSansKoreanBold;
        offText.text = "끄기"; offText.font = nonoSansKoreanBold;
        chal2CompletedRewardInfo.text = "이제 첫 5개의 코인 플리퍼는 언제나 성공적으로 코인을 뒤집습니다"; chal2CompletedRewardInfo.font = nonoSansKoreanBold;
        chal3CompletedRewardInfo.text = "이제 첫 코인 플리퍼는 언제나 성공적으로 코인을 뒤집으며 +500% 코인 보너스를 얻습니다";
        chal3CompletedRewardInfo.font = nonoSansKoreanBold;
        chal4CompletedRewardInfo.text = "이제 코인 플리퍼가 행운의 동전을 뒤집을 확률이 15%입니다"; chal4CompletedRewardInfo.font = nonoSansKoreanBold;
        chal4CompletedRewardInfo.fontSize = 10;

        totalCoins = "코인: ";
        coinsMainText.text = "코인: " + FormatCoins(GlobalCoins.CoinCount); coinsMainText.font = nonoSansKoreanBold;

        lockedAuto.text = "잠금"; lockedAuto.font = nonoSansKoreanBold;
        lockedDuplicate.text = "잠금"; lockedDuplicate.font = nonoSansKoreanBold;
        lockedLucky.text = "잠금"; lockedLucky.font = nonoSansKoreanBold;
        lockedHigherChance.text = "잠금"; lockedHigherChance.font = nonoSansKoreanBold;
        lockedSpecialUpgrade.text = "잠금"; lockedSpecialUpgrade.font = nonoSansKoreanBold;

        moreCoinsIn = ""; Xseconds = "";
        moreCoinsIn1.font = nonoSansKoreanBold;
        moreCoinsIn2.font = nonoSansKoreanBold;
        moreCoinsIn3.font = nonoSansKoreanBold;
        moreCoinsIn4.font = nonoSansKoreanBold;
        moreCoinsIn5.font = nonoSansKoreanBold;
        plussPile1.text = "+코인 더미"; plussPile1.font = nonoSansKoreanBold;
        plussPile2.text = "+코인 더미"; plussPile2.font = nonoSansKoreanBold;
        plussPile3.text = "+코인 더미S"; plussPile3.font = nonoSansKoreanBold;
        plussPile4.text = "+코인 더미"; plussPile4.font = nonoSansKoreanBold;
        plussPile5.text = "+코인 더미"; plussPile5.font = nonoSansKoreanBold;
        thisPileContains1.text = "이 더미에는 다음이 포합됩니다: "; thisPileContains1.font = nonoSansKoreanBold;
        thisPileContains2.text = "이 더미에는 다음이 포합됩니다: "; thisPileContains2.font = nonoSansKoreanBold;
        thisPileContains3.text = "이 더미에는 다음이 포합됩니다: "; thisPileContains3.font = nonoSansKoreanBold;
        thisPileContains4.text = "이 더미에는 다음이 포합됩니다: "; thisPileContains4.font = nonoSansKoreanBold;
        thisPileContains5.text = "이 더미에는 다음이 포합됩니다: "; thisPileContains5.font = nonoSansKoreanBold;
        totalCoinsPile1.font = nonoSansKoreanBold;
        totalCoinsPile2.font = nonoSansKoreanBold;
        totalCoinsPile3.font = nonoSansKoreanBold;
        totalCoinsPile4.font = nonoSansKoreanBold;
        totalCoinsPile5.font = nonoSansKoreanBold;

        totalCoinsPile1.text = FormatCoins2(PileOfCoinsMechanics.PileOfCoinsAmount1);
        totalCoinsPile2.text = FormatCoins2(PileOfCoinsMechanics.PileOfCoinsAmount2);
        totalCoinsPile3.text = FormatCoins2(PileOfCoinsMechanics.PileOfCoinsAmount3);
        totalCoinsPile4.text = FormatCoins2(PileOfCoinsMechanics.PileOfCoinsAmount4);
        totalCoinsPile5.text = FormatCoins2(PileOfCoinsMechanics.PileOfCoinsAmount5);

        heads = "앞면! ";
        tails = "뒷면! ";
        luckyCoin = "럭키코인! ";

        #endregion

        googlePlayText.text = "";
        googlePlayText.font = nonoSansKoreanBold;

        if (LoadSaves.isMobileBuild == true) { SetMobileTexts(); }
    }
    #endregion


    #region JAPANESEREGION
    //JAPANESE
    public void Japanese()
    {
        changeFont = 1;
        ChooseText = 5;
        PlayerPrefs.SetInt("ChosenText", ChooseText);
        #region ChooseScene
        HeadsOrTails.text = "頭や尾?"; HeadsOrTails.font = notoSansJapaneseBold;
        youChoseHeads.text = "あなたは頭を選びました!"; youChoseHeads.font = notoSansJapaneseBold;
        youChoseTails.text = "なたは尾を選んだ!"; youChoseTails.font = notoSansJapaneseBold;
        challengesText.text = "課題"; challengesText.font = notoSansJapaneseBold;
        challenge1Name.text = "自動反転はありません"; challenge1Name.font = notoSansJapaneseBold; challenge1Name.fontSize = 25;
        challenge2Name.text = "25%フリップチャンス"; challenge2Name.font = notoSansJapaneseBold; challenge2Name.fontSize = 25;
        challenge3Name.text = "1コインフリッパー"; challenge3Name.font = notoSansJapaneseBold; challenge3Name.fontSize = 29;
        challenge4Name.text = "いつもラッキー"; challenge4Name.font = notoSansJapaneseBold; challenge4Name.fontSize = 29;
        challenge1Text.text = "チャレンジ #1"; challenge1Text.font = notoSans;
        challenge2Text.text = "チャレンジ #2"; challenge2Text.font = notoSans;
        challenge3Text.text = "チャレンジ #3"; challenge3Text.font = notoSans;
        challenge4Text.text = "チャレンジ #4"; challenge4Text.font = notoSans;
        challengeNegative1.text = "* 自動コインフリップはロックされています\n* アップグレードされたコインフリップはロックされています"; challengeNegative1.font = notoSansJapaneseBold; challengeNegative1.fontSize = 13f;
        challengeNegative2.text = "* 成功したフリップのための恒久的な25％\n * 成功のためのより高いチャンスがロックされています"; challengeNegative2.font = notoSansJapaneseBold; challengeNegative2.fontSize = 13f;
        challengeNegative3.text = "* あなたは1コインフリッパーを持っているだけです\n* フリップより多くのコインがロックされています"; challengeNegative3.font = notoSansJapaneseBold; challengeNegative3.fontSize = 11f;
        challengeNegative4.text = "* このチャレンジ中にインフレコインを獲得することはできません"; challengeNegative4.font = notoSansJapaneseBold; challengeNegative4.fontSize = 14f;
        challengePositive1.text = "* あなたのフリップは500％以上のコインを得る"; challengePositive1.font = notoSansJapaneseBold; challengePositive1.fontSize = 11.5f;
        challengepositive2.text = "* すべてのコインフリップはラッキーコインです"; challengepositive2.font = notoSansJapaneseBold; challengepositive2.fontSize = 14;
        Goal1text.text = "目標:"; Goal1text.font = notoSansJapaneseBold;
        Goal2text.text = "目標:"; Goal2text.font = notoSansJapaneseBold;
        Goal3text.text = "目標:"; Goal3text.font = notoSansJapaneseBold;
        Goal4text.text = "目標:"; Goal4text.font = notoSansJapaneseBold;
        Goal1textInfo.text = "15コイン足ひれに到達します"; Goal1textInfo.font = notoSansJapaneseBold;
        Goal2textInfo.text = "アップグレード7コイン足ひれ"; Goal2textInfo.font = notoSansJapaneseBold;
        Goal3textInfo.text = "70兆コインの合計に到達します"; Goal3textInfo.font = notoSansJapaneseBold;
        Goal4textInfo.text = "すべての21コイン足ひれをアップグレードします"; Goal4textInfo.font = notoSansJapaneseBold; Goal4textInfo.fontSize = 22;
        Reward1Text.text = "報酬:"; Reward1Text.font = notoSansJapaneseBold;
        Reward2Text.text = "報酬:"; Reward2Text.font = notoSansJapaneseBold;
        Reward3Text.text = "報酬:"; Reward3Text.font = notoSansJapaneseBold;
        Reward4Text.text = "報酬:"; Reward4Text.font = notoSansJapaneseBold;
        Reward1TextInfo.text = "ロックされた特別なアップグレードのロックを解除します"; Reward1TextInfo.font = notoSansJapaneseBold; Reward1TextInfo.fontSize = 20;
        Reward2TextInfo.text = "最初の5コインフリッパーは、常に100％成功したフリップチャンスを持っています"; Reward2TextInfo.font = notoSansJapaneseBold; Reward2TextInfo.fontSize = 19;
        Reward3TextInfo.text = "最初のコインフリッパーは常に成功し、あなたに+500％以上のコインを与えます"; Reward3TextInfo.font = notoSansJapaneseBold; Reward3TextInfo.fontSize = 20;
        Reward4TextInfo.text = "幸運なコインは最大15％の確率を持つことができます"; Reward4TextInfo.font = notoSansJapaneseBold; Reward4TextInfo.fontSize = 20;
        questionInfo.text = "-少なくとも一度は膨らませる前に挑戦を試みることはお勧めしません\n \n" +
            "-各チャレンジ中にどのアップグレードが機能するかを確認するために、各木の枝の最初のインフレーションアップグレードを読んでください\n \n" +
            "-あなたは一度に1つの挑戦を選択することができます\n \n" +
            "-各チャレンジはあなたに恒久的な報酬を与えます"; questionInfo.fontSize = 21;
        questionInfo.font = notoSansJapaneseBold;
        #endregion

        #region upgrades

        strongerArmName = "より強い腕";
        greaterCoinName = "より大きなコイン";
        knowledgeName = "知識";
        strongerFistName = "最初に強い";
        handInjectionName = "手の注入";
        brainPowerName = "脳の力";
        explosiveFlipsName = "爆発的なフリップ";
        hydrationName = "水分補給";
        strangePotionName = "奇妙なポーション";
        masterFlipperName = "マスター-フリッパー";
        handShakeName = "握手";
        highFiveName = "ハイファイブ";
        magicFlipsName = "魔法が反転します";
        TreasueChestName = "宝箱";
        coinFlippingRitualName = "コイン反転の儀式";

        upgrade1.text = strongerArmName; upgrade1.font = notoSansJapaneseBold;
        upgrade2.text = greaterCoinName; upgrade2.font = notoSansJapaneseBold;
        upgrade3.text = knowledgeName; upgrade3.font = notoSansJapaneseBold;
        upgrade4.text = strongerFistName; upgrade4.font = notoSansJapaneseBold;
        upgrade5.text = handInjectionName; upgrade5.font = notoSansJapaneseBold;
        upgrade6.text = brainPowerName; upgrade6.font = notoSansJapaneseBold;
        upgrade7.text = explosiveFlipsName; upgrade7.font = notoSansJapaneseBold; upgrade7.fontSize = 30;
        upgrade8.text = hydrationName; upgrade8.font = notoSansJapaneseBold;
        upgrade9.text = strangePotionName; upgrade9.font = notoSansJapaneseBold;
        upgrade10.text = masterFlipperName; upgrade10.font = notoSansJapaneseBold;
        upgrade11.text = handShakeName; upgrade11.font = notoSansJapaneseBold;
        upgrade12.text = highFiveName; upgrade12.font = notoSansJapaneseBold;
        upgrade13.text = magicFlipsName; upgrade13.font = notoSansJapaneseBold; upgrade13.fontSize = 30;
        upgrade14.text = TreasueChestName; upgrade14.font = notoSansJapaneseBold;
        upgrade15.text = coinFlippingRitualName; upgrade15.font = notoSansJapaneseBold; upgrade15.fontSize = 30;

        upgrade1n.font = notoSansJapaneseBold;
        upgrade2n.font = notoSansJapaneseBold;
        upgrade3n.font = notoSansJapaneseBold;
        upgrade4n.font = notoSansJapaneseBold;
        upgrade5n.font = notoSansJapaneseBold;
        upgrade6n.font = notoSansJapaneseBold;
        upgrade7n.font = notoSansJapaneseBold; upgrade7n.fontSize = 30;
        upgrade8n.font = notoSansJapaneseBold;
        upgrade9n.font = notoSansJapaneseBold;
        upgrade10n.font = notoSansJapaneseBold;
        upgrade11n.font = notoSansJapaneseBold;
        upgrade12n.font = notoSansJapaneseBold;
        upgrade13n.font = notoSansJapaneseBold; upgrade13n.fontSize = 30;
        upgrade14n.font = notoSansJapaneseBold;
        upgrade15n.font = notoSansJapaneseBold; upgrade15n.fontSize = 30;

        flipMorePrice1.font = notoSans;
        flipMorePrice2.font = notoSans;

        thousand = "千の";
        million = "百万";
        billion = "地金";
        trillion = "兆の";
        quadrillion = "クアドリリオン";
        quintillion = "クインティリオン";
        sextillion = "セクスティリオン";
        septillion = "セプティリオン";
        octillion = "オクチリオン";
        nonillion = "ノニリオン";
        decillion = "Decillion";
        undecillion = " Undecillion";
        coins = "コイン";
        coinsOnHeads = " - ヘッド";
        coinsOnTails = " - 尾";

        price1.font = notoSans;
        price2.font = notoSans;
        price3.font = notoSans;
        price4.font = notoSans;
        price5.font = notoSans;
        price6.font = notoSans;
        price7.font = notoSans;
        price8.font = notoSans;
        price9.font = notoSans;
        price10.font = notoSans;
        price11.font = notoSans;
        price12.font = notoSans;
        price13.font = notoSans;
        price14.font = notoSans;
        price15.font = notoSans;
        price16.font = notoSans;
        price17.font = notoSans;
        price18.font = notoSans;
        price19.font = notoSans;
        price20.font = notoSans;

        price1c.font = notoSans;
        price2c.font = notoSans;
        price3c.font = notoSans;
        price4c.font = notoSans;
        price5c.font = notoSans;
        price6c.font = notoSans;
        price7c.font = notoSans;
        price8c.font = notoSans;
        price9c.font = notoSans;
        price10c.font = notoSans;
        price11c.font = notoSans;
        price12c.font = notoSans;
        price13c.font = notoSans;
        price14c.font = notoSans;
        price15c.font = notoSans;
        price16c.font = notoSans;
        price17c.font = notoSans;
        price18c.font = notoSans;
        price19c.font = notoSans;
        price20c.font = notoSans;

        flipAll.text = "すべて反転します"; flipAll.font = notoSansJapaneseBold;
        autoFlipsQeuals.text = "自動反転="; autoFlipsQeuals.font = notoSansJapaneseBold; autoFlipsQeuals.fontSize = 25;
        on.text = "オン"; on.font = notoSansJapaneseBold;
        on2.text = "オン"; on2.font = notoSansJapaneseBold;
        off.text = "オフ"; off.font = notoSansJapaneseBold;
        off2.text = "オフ"; off2.font = notoSansJapaneseBold;
        gamble.text = "ギャンブルだ"; gamble.font = notoSansJapaneseBold;
        gamblec.text = "ギャンブルだ"; gamblec.font = notoSansJapaneseBold;
        current.text = "現在の:"; current.font = notoSansJapaneseBold; current.fontSize = 25;
        autoFlips.text = "自動コインフリップ"; autoFlips.font = notoSansJapaneseBold; autoFlips.fontSize = 30;
        autoFlipsc.text = "自動コインフリップ"; autoFlipsc.font = notoSansJapaneseBold; autoFlipsc.fontSize = 30;
        pileOfCoins.text = "コインの山"; pileOfCoins.font = notoSansJapaneseBold;
        pileOfCoinsc.text = "コインの山"; pileOfCoinsc.font = notoSansJapaneseBold;
        higherChance.text = "成功のためのより高いチャンス"; higherChance.font = notoSansJapaneseBold;
        higherChancec.text = "成功のためのより高いチャンス"; higherChancec.font = notoSansJapaneseBold;
        getLucky.text = "幸運を得る"; getLucky.font = notoSansJapaneseBold;
        getLuckyc.text = "幸運を得る"; getLuckyc.font = notoSansJapaneseBold;
        endlessInflation.text = "無限のインフレ"; endlessInflation.font = notoSansJapaneseBold;
        upgradedFlips.text = "アップグレードされたコインフリップ"; upgradedFlips.font = notoSansJapaneseBold; upgradedFlips.fontSize = 28;
        upgradedFlipsc.text = "アップグレードされたコインフリップ"; upgradedFlipsc.font = notoSansJapaneseBold; upgradedFlipsc.fontSize = 28;
        unlockedViaChal1.text = "チャレンジ＃1を完了することによってロックを解除"; unlockedViaChal1.font = notoSansJapaneseBold; unlockedViaChal1.fontSize = 16;
        unlcokedViaInf.text = "インフレを介してロック解除された"; unlcokedViaInf.font = notoSansJapaneseBold;
        chooseAutoUpgrade.text = "自動的にアップグレードするアップグレードを選択します:"; chooseAutoUpgrade.font = notoSansJapaneseBold;
        diplicateFlips.font = notoSansJapaneseBold; diplicateFlips.fontSize = 36;
        diplicateFlipsc.font = notoSansJapaneseBold; diplicateFlipsc.fontSize = 36;
        autoUpgradeNameText.text = "自動アップグレード"; autoUpgradeNameText.font = notoSansJapaneseBold;

         autoUpgradeName = "自動コインフリップ";
        pileOfCoinsName = "コインの山";
        higherChanceName = "成功のためのより高いチャンス";
        getLuckyName = "幸運を得る";
        upgradedFlipsName = "アップグレードされたコインフリップ";
        flipMoreCoinsName = "より多くのコインを反転";
        spendNoMore = "マックス";
        maxedOut = "マックス";
        theyAllFlip = "マックス";




        #endregion

        #region hoverOverUpgrades
        hover1Name.text = strongerArmName; hover1Name.font = notoSansJapaneseBold;
        hover2Name.text = greaterCoinName; hover2Name.font = notoSansJapaneseBold;
        hover3Name.text = knowledgeName; hover3Name.font = notoSansJapaneseBold;
        hover4Name.text = strongerFistName; hover4Name.font = notoSansJapaneseBold;
        hover5Name.text = handInjectionName; hover5Name.font = notoSansJapaneseBold;
        hover6Name.text = brainPowerName; hover6Name.font = notoSansJapaneseBold;
        hover7Name.text = explosiveFlipsName; hover7Name.font = notoSansJapaneseBold; hover7Name.fontSize = 36;
        hover8Name.text = hydrationName; hover8Name.font = notoSansJapaneseBold;
        hover9Name.text = strangePotionName; hover9Name.font = notoSansJapaneseBold;
        hover10Name.text = masterFlipperName; hover10Name.font = notoSansJapaneseBold;
        hover11Name.text = handShakeName; hover11Name.font = notoSansJapaneseBold;
        hover12Name.text = highFiveName; hover12Name.font = notoSansJapaneseBold;
        hover13Name.text = magicFlipsName; hover13Name.font = notoSansJapaneseBold; hover13Name.fontSize = 36;
        hover14Name.text = TreasueChestName; hover14Name.font = notoSansJapaneseBold;
        hover15Name.text = coinFlippingRitualName; hover15Name.font = notoSansJapaneseBold; hover15Name.fontSize = 36;
        hoverFlipAll.text = "すべて反転します"; hoverFlipAll.font = notoSansJapaneseBold;
        hoverAutoUpgrade.text = "自動アップグレード"; hoverAutoUpgrade.font = notoSansJapaneseBold;
        hovergamble.text = "ギャンブルだ"; hovergamble.font = notoSansJapaneseBold; hovergamble.fontSize = 25;
        hoverAutoFlip.text = "自動コインフリップ"; hoverAutoFlip.font = notoSansJapaneseBold; hoverAutoFlip.fontSize = 36;
        hoverPile.text = "コインの山"; hoverPile.font = notoSansJapaneseBold;
        hoverhigherChance.text = "成功のためのより高いチャンス"; hoverhigherChance.font = notoSansJapaneseBold; hoverhigherChance.fontSize = 31;
        hoverLucky.text = "幸運を得る"; hoverLucky.font = notoSansJapaneseBold;
        hoverEndless.text = "無限のインフレ"; hoverEndless.font = notoSansJapaneseBold;
        hoverUpgradedFlips.text = "アップグレードされたコインフリップ"; hoverUpgradedFlips.font = notoSansJapaneseBold; hoverUpgradedFlips.fontSize = 27;
        hoverOn.text = "自動でめくるをオンにする"; hoverOn.font = notoSansJapaneseBold; hoverOn.fontSize = 30;
        hoverOff.text = "自動でめくるをオフにする"; hoverOff.font = notoSansJapaneseBold; hoverOff.fontSize = 30;

        purchased = "購入: ";

        purchased1.text = "購入: " + MoreCoinsButton.moreCoinsUpgrades; purchased2.text = "購入: " + MoreCoinsButton.greaterCoinsCount;
        purchased3.text = "購入: " + KnowledgeUpgrade.knowledgeUpgradeCount; purchased4.text = "購入: " + StrongerFist.fistUpgradeCount;
        purchased5.text = "購入: " + HandInecjtion.injectionUpgradeCount; purchased6.text = "購入: " + BrainPower.brainPowerUpgradeCount;
        purchased7.text = "購入: " + ExplosiveFlips.explosiveUpgradeCount; purchased8.text = "購入: " + HydrationButton.hydrationUpgradeCount;
        purchased9.text = "購入: " + StrangePotion.potionUpgradeCount; purchased10.text = "購入: " + MasterFlipper.MasterFlipsUpgradeCount;
        purchased11.text = "購入: " + HandShake.handShakeUpgradeCount; purchased12.text = "購入: " + Upgrade12.upgrade12Count;
        purchased13.text = "購入: " + MagicFlipsUpgrade.magicUpgradeCount; purchased14.text = "購入: " + TreasureChest.treasureCount;
        purchased15.text = "購入: " + RitualUpgrade.treasureCount;
        purchased16.text = "購入: " + GlobalCoinMaker.coinsPerFlipUpgrades; purchased17.text = "購入: " + PurchaseLog.higherChanceUpgradeCount;
        purchased18.text = "購入: " + PurchaseLog.luckyCoinHigherChanceCount; purchased19.text = "購入: " + GoldenFlipsButton.goldenCoinsUpgradeCount;
        purchased20.text = "購入: " + PurchaseLog.pileOfCoinsCount; purchased21.text = "購入: ";


        purchased1.font = notoSansJapaneseBold; purchased2.font = notoSansJapaneseBold; purchased3.font = notoSansJapaneseBold; purchased4.font = notoSansJapaneseBold;
        purchased5.font = notoSansJapaneseBold; purchased6.font = notoSansJapaneseBold; purchased7.font = notoSansJapaneseBold; purchased8.font = notoSansJapaneseBold;
        purchased9.font = notoSansJapaneseBold; purchased10.font = notoSansJapaneseBold; purchased11.font = notoSansJapaneseBold; purchased12.font = notoSansJapaneseBold;
        purchased13.font = notoSansJapaneseBold; purchased14.font = notoSansJapaneseBold; purchased15.font = notoSansJapaneseBold;
        purchased16.font = notoSansJapaneseBold;
        purchased17.font = notoSansJapaneseBold; purchased18.font = notoSansJapaneseBold; purchased19.font = notoSansJapaneseBold;
        purchased20.font = notoSansJapaneseBold; purchased21.font = notoSansJapaneseBold;

        thousandC = "千のコイン"; millionc = "百万コイン"; billionc = "地金コイン"; trillionc = "兆のコイン"; quadrillionc = "クアドリリオンコイン"; quintillionc = "クインティリオンコイン";
        sextillionc = "セクスティリオンコイン"; septillionc = "セプティリオンコイン"; octillionc = "オクチリオンコイン"; nonillionc = "ノニリオンコイン"; decillionc = " Decillionコイン";
        undecillionc = "アンデミリオンコイン";

        description1.text = "\"あなたは何年もあなたの上腕二頭筋、上腕三頭筋と前腕を訓練してきました。そして、この増加した強さで、あなたは今、増加した電力であなたのコインを反転することができます\"";
        description2.text = "\"ある日、あなたはちょうど歩道にそこに敷設されているコインを拾うことにしました。あなたがこのコインを反転するたびに、あなたはより多くのコインを得ることが判明\"";
        description3.text = "\"あなたは、より強い武器とより大きなコインよりも優れているものを知っていますか？ 知識.\"";
        description4.text = "\"ジムの他のみんなが体全体をトレーニングしている間。あなたの焦点は完全にあなたの拳にあります。あなたはあなたの全体の拳に巨大なポンプを与える各指を個別に訓練します\"";
        description5.text = "\"路上でいくつかのランダムな男は、その中にいくつかの奇妙な探して液体であなたに針を販売しました。あなたはそれをあなたの手に注入し、何らかの理由であなたはこれまで以上に気分が良くなります\"";
        description6.text = "\"コインを反転のあなたの年のすべての間に、あなたの脳は今、その容量の100％以上を超えることができます\"";
        description7.text = "\"コインをひっくり返すことは今ではかなり危険になっています。あなたが反転するすべてのコインは、親指に小さな爆発を作成します。それは爆発ですが、それは少しくすぐる以外の何ものでもありません\"";
        description8.text = "\"一日中コインを反転することは大変な作業であり、時にはそれが継続するために必要なすべては、いくつかの冷たい新鮮な水です。だから、水分を保つことを忘れないでください\"";
        description9.text = "\"あなたは非常に長い間、あなたのベッドの下に奇妙なポーションを維持してきました。 今日はあなたがそれを飲む日であり、針のように、あなたはあなたの人生全体で気分が良くなったことはありません\"";
        description10.text = "\"コインフリップへの長年の献身により、マスターフリッパーメダルが授与されました\"";
        description11.text = "\"あなたはビジネスマンを反転プロのコインで手を振る。あなたとこの男は何とか、世界で最も成功したビジネスに反転コインを有効にしようとしています...\"";
        description12.text = "\"あなたにとって非常に重要なあなたのハイファイブの誰か。これはあなたが夢を見ることができるより多くの反転力を与えます\"";
        description13.text = "\"あなたは魔法のコイン反転の芸術を学ぶためにウィザードのために特定の学校に旅行します。あなたのコインは今、あなたがそれらを反転するたびに魔法の輝きを持っています。これは人々を疑わしいものにします\"";
        description14.text = "\"世界中のあなたの無数の旅行で、あなたは長い間失われた古い宝箱を発見します。だから自然に、あなたは胸の中のコインをひっくり返し始めます\"";
        description15.text = "\"このコイン反転のことは暗いターンを取っています。あなたはコインを反転する新しい方法を見つけることに夢中になります。あなたは可能な限り最高の形にコイン反転を取ることを期待して暗い儀式を実行し始めます\"";
        description16.text = "\"時々、他の誰かがあなたのためにコインをひっくり返してもらう方が良いでしょう。各アップグレードは自動的にあなたのために1コインを反転します\"";
        description17.text = "\"あなたのフリップは今、成功するために1％以上のチャンスを持つことになります。うまくいけば、運が良ければ、これは実際にあなたにもっと多くのコインを与えるでしょう\"";
        description18.text = "\"時にはあなたのコインフリップは少し異なることができます。そして、これらの異なるフリップが起こるとき、あなたは5倍のコインを得る。各アップグレードはあなたに+0.5％を与えます\"";
        description19.text = "\"すべての購入は、アップグレードされたバージョンに1コインフリッパーをアップグレードします。これらのコインフリップはあなたにコインの量の2倍を与え、幸運なコインはあなたに10倍を与えるでしょう\"";
        description20.text = "\"あなたはギャンブラーですか？ もしそうなら、あなたは試してみて、あなたのコインのすべてを倍増する勇気がありますか？ ここにはスキルはなく、運だけが含まれています。また、「インフレ中に試行がリセットされる」ことを望まない場合は、これを行う必要はないことを忘れないでください\"";
        description21.text = "-自動的にアップグレードするアップグレードを選択します\n\n -あなたがそれを買う余裕があれば、自動アップグレードは5秒ごとにあなたの選択のアップグレードを購入します。\n\nゲームが閉じられているときに自動アップグレードが機能しません";
        description22.text = "-自動反転のオンとオフを切り替えることができます\n-すべてのコインを反転するときは、再び反転できるようになるまで3秒待つ必要があります\n-自動反転がオフになっているときは、コインを積極的に反転することはできません\n-自動フリップがオフになっている間、自動フリップとアップグレードされたコインフリップはロックされます";
        description23.text = "\"コインの山が左下に表示されます。時間が経つにつれて、この杭は、より多くのコインを生成します。クリックすると、すべてのコインが得られます\"";
        descEndless1.text = "\"ほとんどのインフレーションアップグレードのロックを解除する前に、プレイヤーがこのアップグレードを購入し始めることはお勧めしません\"";
        descEndless2.text = "このアップグレードは、「リッチ」インフレーションアップグレードと同じように機能します。コインボーナスは、各購入は、アップグレード価格に等しいです";
        description1.font = notoSans; description2.font = notoSans; description3.font = notoSans; description4.font = notoSans; description5.font = notoSans;
        description6.font = notoSans; description7.font = notoSans; description8.font = notoSans; description9.font = notoSans; description10.font = notoSans;
        description11.font = notoSans; description12.font = notoSans; description13.font = notoSans; description14.font = notoSans; description15.font = notoSans;
        description16.font = notoSans; description17.font = notoSans; description18.font = notoSans; description19.font = notoSans; description20.font = notoSans;
        description21.font = notoSans; description22.font = notoSans; description23.font = notoSans; descEndless1.font = notoSans; descEndless2.font = notoSans;

        description1.fontSize = 12; description2.fontSize = 12; description3.fontSize = 11.5f;
        description4.fontSize = 13; description5.fontSize = 12; description6.fontSize = 12; description7.fontSize = 12; description8.fontSize = 12; description9.fontSize = 12;
        description10.fontSize = 12; description12.fontSize = 12;
        description11.fontSize = 12; description13.fontSize = 12; description14.fontSize = 12; description15.fontSize = 12f; description16.fontSize = 11; description17.fontSize = 12; description18.fontSize = 12; description19.fontSize = 11f;
        description20.fontSize = 10; description21.fontSize = 12; description22.fontSize = 12; description23.fontSize = 12; descEndless1.fontSize = 12f; descEndless2.fontSize = 12f;

        hoverCost1.font = notoSansJapaneseBold; hoverCost2.font = notoSansJapaneseBold; hoverCost3.font = notoSansJapaneseBold; hoverCost4.font = notoSansJapaneseBold; hoverCost5.font = notoSansJapaneseBold;
        hoverCost6.font = notoSansJapaneseBold; hoverCost7.font = notoSansJapaneseBold; hoverCost8.font = notoSansJapaneseBold; hoverCost9.font = notoSansJapaneseBold; hoverCost10.font = notoSansJapaneseBold;
        hoverCost11.font = notoSansJapaneseBold; hoverCost12.font = notoSansJapaneseBold; hoverCost13.font = notoSansJapaneseBold; hoverCost14.font = notoSansJapaneseBold; hoverCost15.font = notoSansJapaneseBold;
        hoverCost16.font = notoSansJapaneseBold; hoverCost17.font = notoSansJapaneseBold; hoverCost18.font = notoSansJapaneseBold; hoverCost19.font = notoSansJapaneseBold; hoverCost20.font = notoSansJapaneseBold;
        hoverCost21.font = notoSansJapaneseBold;

        p1.text = "価格:"; p2.text = "価格:"; p3.text = "価格:"; p4.text = "価格:"; p5.text = "価格:"; p6.text = "価格:"; p7.text = "価格:"; p8.text = "価格:"; p9.text = "価格:"; p10.text = "価格:";
        p11.text = "価格:";
        p12.text = "価格:"; p13.text = "価格:"; p14.text = "価格:"; p15.text = "価格:"; p16.text = "価格:"; p17.text = "価格:"; p18.text = "価格:"; p19.text = "価格:"; p20.text = "価格:";
        p21.text = "価格:";

        p1.font = notoSansJapaneseBold; p2.font = notoSansJapaneseBold; p3.font = notoSansJapaneseBold; p4.font = notoSansJapaneseBold; p5.font = notoSansJapaneseBold; p6.font = notoSansJapaneseBold;
        p7.font = notoSansJapaneseBold; p8.font = notoSansJapaneseBold; p9.font = notoSansJapaneseBold; p10.font = notoSansJapaneseBold; p11.font = notoSansJapaneseBold; p12.font = notoSansJapaneseBold;
        p13.font = notoSansJapaneseBold; p14.font = notoSansJapaneseBold; p15.font = notoSansJapaneseBold; p16.font = notoSansJapaneseBold; p17.font = notoSansJapaneseBold; p18.font = notoSansJapaneseBold;
        p19.font = notoSansJapaneseBold; p20.font = notoSansJapaneseBold; p21.font = notoSansJapaneseBold;

        plussCoins = "コイン";
        plussthousandCoins = "千のコイン";
        plussMillionCoins = "百万コイン";
        plussBillionCoins = "地金コイン";
        plussTrillionCoins = "兆のコイン";
        plussQuadrillionCoins = "クアドリリオンコイン";
        plussQuintillionCoins = "クインティリオンコイン";
        plussSextillionCoins = "セクスティリオンコイン";
        plussSeptillionCoins = "セプティリオンコイン";

        pluss1.font = notoSansJapaneseBold; pluss2.font = notoSansJapaneseBold; pluss3.font = notoSansJapaneseBold; pluss4.font = notoSansJapaneseBold; pluss5.font = notoSansJapaneseBold; pluss6.font = notoSansJapaneseBold;
        pluss7.font = notoSansJapaneseBold; pluss8.font = notoSansJapaneseBold; pluss9.font = notoSansJapaneseBold; pluss10.font = notoSansJapaneseBold; pluss11.font = notoSansJapaneseBold; pluss12.font = notoSansJapaneseBold;
        pluss13.font = notoSansJapaneseBold; pluss14.font = notoSansJapaneseBold; pluss15.font = notoSansJapaneseBold;

        pluss1.fontSize = 15; pluss2.fontSize = 15; pluss3.fontSize = 15; pluss4.fontSize = 15; pluss5.fontSize = 15; pluss6.fontSize = 15; pluss7.fontSize = 15; pluss8.fontSize = 15; pluss9.fontSize = 15;
        pluss10.fontSize = 15; pluss11.fontSize = 15; pluss12.fontSize = 15; pluss13.fontSize = 15; pluss14.fontSize = 15; pluss15.fontSize = 15;

        gamblePreventCheating.text = "(ゲームはあなたが不正行為を防ぐためにギャンブルするたびに保存されます)"; gamblePreventCheating.font = notoSansJapaneseBold; gamblePreventCheating.fontSize = 8;
        gambleReset.text = ""; gambleReset.font = notoSansJapaneseBold;
        gambleTries.font = priceTextEng; gambleChanceToWin.font = notoSansJapaneseBold; gambleChanceToLoose.font = notoSansJapaneseBold; pileGenerates.font = notoSansJapaneseBold;
        pileMinus1Second.text = "すべての購入に-1秒"; pileMinus1Second.font = notoSansJapaneseBold; chanceToHitHeads.font = notoSansJapaneseBold; chanceToHitTails.font = notoSansJapaneseBold;
        chanceToHitLuckyCoin.font = notoSansJapaneseBold; endlessInflationPercent.font = notoSansJapaneseBold; endlessInflationCoin.font = notoSansJapaneseBold; plussUpgradedCoinFlipper.font = notoSansJapaneseBold;
        plussUpgradedCoinFlipper.text = "+1アップグレードされたコインフリッパー"; plussUpgradedCoinFlipper.fontSize = 14;

        gambleChanceToWin.text = PurchaseLog.gambleChanceEachTimeWIN + "%のチャンスは、すべてのあなたのコインを倍増させます"; gambleChanceToLoose.text = PurchaseLog.gambleChanceEachTimeLOOSE + "%の確率で、あなたのすべてのコインを失う可能性があります";
        gambleChanceToWin.fontSize = 7;
        gambleChanceToLoose.fontSize = 7;
        chanceToHitHeads.text = higherChanceHoverover.headsPercent + "%チャンスヘッドをヒットします."; chanceToHitTails.text = higherChanceHoverover.tailsPercent + "%チャンス尾をヒットします";
        chanceToHitLuckyCoin.text = GetLuckyHoverOver.luckyChance + "%幸運なコインをヒットするチャンス";
        endlessInflationPercent.text = EndlessInflation.endlessInflationPrice + "%より多くのコイン!"; endlessInflationCoin.text = EndlessInflation.endlessInflationPrice + "インフレコイン";
        chanceToHitLuckyCoin.fontSize = 12f; chanceToHitHeads.fontSize = 12f; chanceToHitTails.fontSize = 12f;
        pileGenerates.text = "" + PileOfCoinsMechanics.waitTime + "秒ごとにコインを生成します"; pileGenerates.fontSize = 11;

        gambleWinChance = "%のチャンスは、すべてのあなたのコインを倍増させます"; gambleLoseChance = "%の確率で、あなたのすべてのコインを失う可能性があります";
        gambleTriesString = "試行: ";
        pileGeneratesEveyXSecond = ""; seconds = "秒ごとにコインを生成します";
        higherChanceTails = "%チャンス尾をヒットします"; higherChanceHeads = "%チャンスヘッドをヒットします"; luckyCoinChance = "幸運なコインをヒットするチャンス";
        endlessInflationCost = "インフレコイン"; endlessInflationPercentString = "%より多くのコイン!"; needs21Flippers = "コインフリッパー 21個!";

        gambleTriesStringText.text = "試行: " + PurchaseLog.gambleChances; gambleTriesStringText.font = notoSans;
        gambleResultText.font = notoSans;

        #endregion

        #region STATS

        inflateOnceToSeeStats.text = "統計を見るために一度膨らませる"; inflateOnceToSeeStats.font = notoSansJapaneseBold; inflateOnceToSeeStats.fontSize = 20;

        //GeneralStats
        coin = "coin";
        youHaveFlipped = $"あなたは{StatsAll.flippedAmount}コインを反転しています"; youHaveFlippedText.font = notoSans;
        youHaveActivelyFlipped = $"あなたは積極的に{MainButtonClick.activeFlipsAmount}コインを反転しています"; youHaveActivelyFlippedText.font = notoSans;

        totalCoinsOnHeads = "枚のコインが頭に着地しました"; totalCoinsOnHeadsText.font = notoSans;
        totalCoinsOnTails = "枚のコインが尾に着地しました"; totalCoinsOnTailsText.font = notoSans;
        totalLockyCoins = "枚のコインが幸運なコインに上陸しました"; totalLockyCoinsText.font = notoSans; 

        stats.text = "統計"; general.text = "将軍"; upgrades.text = "アップグレード"; completedChallenges.text = "チャレンジを完了します"; inflation.text = "インフレ"; specialUpgrades.text = "特別なアップグレード"; specialUpgrades.font = notoSansJapaneseBold;
        stats.font = notoSansJapaneseBold; general.font = notoSans; upgrades.font = notoSans; completedChallenges.font = notoSans; inflation.font = notoSans;

        //UpgradesText
        buyUpgrade = "統計を見るためにアップグレードを購入します";
        your = "あなたの";
        statsStrongerArm = "強い腕のアップグレードはあなたに";
        statsGreater = "大きなコインのアップグレードはあなたに";
        statsKnowledge = "のアップグレードは、あなたに";
        statsFist = "強い拳のアップグレードはあなたに";
        statsInjection = "手の注入のアップグレードはあなたに";
        statsBrain = "脳力のアップグレードはあなたに";
        statsExplosive = "爆発的なフリップのアップグレードはあなたに";
        statsHydration = "の水分補給のアップグレードはあなたに";
        statsPorion = "奇妙なポーションのアップグレードはあなたに";
        statsMaster = "マスターフリッパーのアップグレードはあなたに";
        statsHandshake = "ハンドシェイクアップグレードはあなたに";
        statsHighFive = "ハイファイブアップグレードはあなたに";
        statsMagic = "マジックフリップアップグレードはあなたに";
        statsTreasure = "宝箱のアップグレードはあなたに";
        statsRitual = "コイン反転儀式のアップグレードはあなたに";

        statsStrongerArmText.text = LocalizationStrings.your + MoreCoinsButton.moreCoinsUpgrades + LocalizationStrings.statsStrongerArm + FormatCoins(PurchaseLog.strongerHandsTextInfo) + LocalizationStrings.coins; statsStrongerArmText.font = notoSans;

        statsGreaterText.font = notoSans; statsKnowledgeText.font = notoSans; statsFistText.font = notoSans; statsInjectionText.font = notoSans; statsBrainText.font = notoSans; statsExplosiveText.font = notoSans;
        statsHydrationText.font = notoSans; statsPorionText.font = notoSans; statsMasterText.font = notoSans; statsHandshakeText.font = notoSans; statsHighFiveText.font = notoSans;
        statsMagicText.font = notoSans; statsTreasureText.font = notoSans; statsRitualText.font = notoSans;

        if (MoreCoinsButton.greaterCoinsCount == 0) { statsGreaterText.text = buyUpgrade; }
        if (MoreCoinsButton.greaterCoinsCount > 0)
        {
            statsGreaterText.text = LocalizationStrings.your + MoreCoinsButton.greaterCoinsCount + LocalizationStrings.statsGreater + FormatCoins(PurchaseLog.greaterTextInfo) + LocalizationStrings.coins;
        }
        if (KnowledgeUpgrade.knowledgeUpgradeCount == 0) { statsKnowledgeText.text = buyUpgrade; }
        if (KnowledgeUpgrade.knowledgeUpgradeCount > 0)
        {
            statsKnowledgeText.text = LocalizationStrings.your + KnowledgeUpgrade.knowledgeUpgradeCount + LocalizationStrings.statsKnowledge + FormatCoins(PurchaseLog.knowledgeInfo) + LocalizationStrings.coins;
        }
        if (StrongerFist.fistUpgradeCount == 0) { statsFistText.text = buyUpgrade; }
        if (StrongerFist.fistUpgradeCount > 0)
        {
            statsFistText.text = LocalizationStrings.your + StrongerFist.fistUpgradeCount + LocalizationStrings.statsFist + FormatCoins(PurchaseLog.fistInfo) + LocalizationStrings.coins;
        }
        if (HandInecjtion.injectionUpgradeCount == 0) { statsInjectionText.text = buyUpgrade; }
        if (HandInecjtion.injectionUpgradeCount > 0)
        {
            statsInjectionText.text = LocalizationStrings.your + HandInecjtion.injectionUpgradeCount + LocalizationStrings.statsInjection + FormatCoins(PurchaseLog.injectionInfo) + LocalizationStrings.coins;
        }
        if (BrainPower.brainPowerUpgradeCount == 0) { statsBrainText.text = buyUpgrade; }
        if (BrainPower.brainPowerUpgradeCount > 0)
        {
            statsBrainText.text = LocalizationStrings.your + BrainPower.brainPowerUpgradeCount + LocalizationStrings.statsBrain + FormatCoins(PurchaseLog.brainPowerInfo) + LocalizationStrings.coins;
        }
        if (ExplosiveFlips.explosiveUpgradeCount == 0) { statsExplosiveText.text = buyUpgrade; }
        if (ExplosiveFlips.explosiveUpgradeCount > 0)
        {
            statsExplosiveText.text = LocalizationStrings.your + ExplosiveFlips.explosiveUpgradeCount + LocalizationStrings.statsExplosive + FormatCoins(PurchaseLog.explosiveInfo) + LocalizationStrings.coins;
        }
        if (HydrationButton.hydrationUpgradeCount == 0) { statsHydrationText.text = buyUpgrade; }
        if (HydrationButton.hydrationUpgradeCount > 0)
        {
            statsHydrationText.text = LocalizationStrings.your + HydrationButton.hydrationUpgradeCount + LocalizationStrings.statsHydration + FormatCoins(PurchaseLog.hydrationInfo) + LocalizationStrings.coins;
        }
        if (StrangePotion.potionUpgradeCount == 0) { statsPorionText.text = buyUpgrade; }
        if (StrangePotion.potionUpgradeCount > 0)
        {
            statsPorionText.text = LocalizationStrings.your + StrangePotion.potionUpgradeCount + LocalizationStrings.statsPorion + FormatCoins(PurchaseLog.potionInfo) + LocalizationStrings.coins;
        }
        if (MasterFlipper.MasterFlipsUpgradeCount == 0) { statsMasterText.text = buyUpgrade; }
        if (MasterFlipper.MasterFlipsUpgradeCount > 0)
        {
            statsMasterText.text = LocalizationStrings.your + MasterFlipper.MasterFlipsUpgradeCount + LocalizationStrings.statsMaster + FormatCoins(PurchaseLog.masterFlipperInfo) + LocalizationStrings.coins;
        }
        if (HandShake.handShakeUpgradeCount == 0) { statsHandshakeText.text = buyUpgrade; }
        if (HandShake.handShakeUpgradeCount > 0)
        {
            statsHandshakeText.text = LocalizationStrings.your + HandShake.handShakeUpgradeCount + LocalizationStrings.statsHandshake + FormatCoins(PurchaseLog.handShakeInfo) + LocalizationStrings.coins;
        }
        if (Upgrade12.upgrade12Count == 0) { statsHighFiveText.text = buyUpgrade; }
        if (Upgrade12.upgrade12Count > 0)
        {
            statsHighFiveText.text = LocalizationStrings.your + Upgrade12.upgrade12Count + LocalizationStrings.statsHighFive + FormatCoins(PurchaseLog.upgrade12Info) + LocalizationStrings.coins;
        }
        if (MagicFlipsUpgrade.magicUpgradeCount == 0) { statsMagicText.text = buyUpgrade; }
        if (MagicFlipsUpgrade.magicUpgradeCount >= 1)
        {
            statsMagicText.text = LocalizationStrings.your + MagicFlipsUpgrade.magicUpgradeCount + LocalizationStrings.statsMagic + FormatCoins(PurchaseLog.magicFlipsInfo) + LocalizationStrings.coins;
        }
        if (TreasureChest.treasureCount == 0) { statsTreasureText.text = buyUpgrade; }
        if (TreasureChest.treasureCount >= 1)
        {
            statsTreasureText.text = LocalizationStrings.your + TreasureChest.treasureCount + LocalizationStrings.statsTreasure + FormatCoins(PurchaseLog.treasureInfo) + LocalizationStrings.coins;
        }
        if (RitualUpgrade.treasureCount == 0) { statsRitualText.text = buyUpgrade; }
        if (RitualUpgrade.treasureCount >= 1)
        {
            statsRitualText.text = LocalizationStrings.your + RitualUpgrade.treasureCount + LocalizationStrings.statsRitual + FormatCoins(PurchaseLog.ritualInfo) + LocalizationStrings.coins;
        }

        statsStrongerArmText.fontSize = 11.7f; statsGreaterText.fontSize = 11.7f; statsKnowledgeText.fontSize = 11.7f; statsFistText.fontSize = 11.7f; statsInjectionText.fontSize = 11.7f;
        statsBrainText.fontSize = 11.7f; statsExplosiveText.fontSize = 11.7f; statsHydrationText.fontSize = 11.7f; statsPorionText.fontSize = 11.7f; statsMasterText.fontSize = 11.7f;
        statsHandshakeText.fontSize = 11.7f; statsHighFiveText.fontSize = 11.7f; statsMagicText.fontSize = 11.7f; statsTreasureText.fontSize = 11.7f; statsRitualText.fontSize = 11.7f;

        //SpecialUpgradesText
        times = ""; youHitExtraLucky = $"あなたは余分な幸運なコインを{AscendScreen.hitEvenLuckerCoin}回ヒットします";
        youGambled = $"あなたはギャンブルをしました{PurchaseLog.amountOfTimesGambled}回";
        lostGambling = $"あなたはすべてのあなたのコインを失っていますギャンブル{PurchaseLog.amountOfTimesGambledLOST}回";
        wonGambling = $"あなたはすべてのあなたのコインを倍増していますギャンブル{PurchaseLog.amountOfTimesGambledWON}回";
        clickedPile = $"あなたは{PileOfCoinsMechanics.incrementPileOfCoinsAmount}回のコインの山をクリックしました";
        pileTotalGenerated = $"コインの山は4{PileOfCoinsMechanics.totalAmountOfPileGenerated}コインの合計を生成しています";
        completeChal1 = "報酬を見るために挑戦1を完了します"; completeChal2 = "報酬を見るために挑戦2を完了します";
        completeChal3 = "報酬を見るために挑戦3を完了します"; completeChal4 = "報酬を見るために挑戦4を完了します";
        chal1Completed = "チャレンジ1報酬：すべて反転ボタンのロックを解除しました"; chal2completed = "チャレンジ2報酬：最初の5コイン足ひれは常に成功しています";
        chal3completed = "チャレンジ3報酬：最初のコインフリッパーは500％以上のコインを与えます"; chal4completed = "チャレンジ4報酬：最大15％のラッキーコインチャンス"; ;
        statsHeadsChanceText.text = higherChanceHoverover.headsPercent + LocalizationStrings.higherChanceHeads; statsHeadsChanceText.font = notoSansJapaneseBold;
        statsTailsChanceText.text = higherChanceHoverover.tailsPercent + LocalizationStrings.higherChanceTails; statsTailsChanceText.font = notoSansJapaneseBold;
        statsLuckyChanceText.text = GetLuckyHoverOver.luckyChance + LocalizationStrings.luckyCoinChance; statsLuckyChanceText.font = notoSansJapaneseBold;
        youHitExtraLuckyText.font = notoSans;
        clickedPileText.text = LocalizationStrings.clickedPile + PileOfCoinsMechanics.incrementPileOfCoinsAmount + LocalizationStrings.times;
        youGambledText.text = LocalizationStrings.youGambled + (0 + PurchaseLog.amountOfTimesGambled) + LocalizationStrings.times; youGambledText.font = notoSans; 
        lostGamblingText.font = notoSans; lostGamblingText.text = LocalizationStrings.lostGambling + (0 + PurchaseLog.amountOfTimesGambledLOST) + LocalizationStrings.times;
        wonGamblingText.font = notoSans; wonGamblingText.text = LocalizationStrings.wonGambling + (0 + PurchaseLog.amountOfTimesGambledWON) + LocalizationStrings.times;
        lostGamblingText.fontSize = 15;
        wonGamblingText.fontSize = 15;
        pileTotalGeneratedText.fontSize = 15f;
        clickedPileText.font = notoSans;
        pileTotalGeneratedText.font = notoSans; 

        completeChal1Text.font = notoSans; completeChal2Text.font = notoSans; completeChal3Text.font = notoSans; completeChal4Text.font = notoSans;

        completeChal1Text.fontSize = 16.6f; completeChal2Text.fontSize = 16.6f; completeChal3Text.fontSize = 16.6f; completeChal4Text.fontSize = 16.6f;

        if (Challenges.completedChallenge1 == 0) { completeChal1Text.text = completeChal1; }
        if (Challenges.completedChallenge1 == 1) { completeChal1Text.text = chal1Completed; }
        if (Challenges.completedChallenge2 == 0) { completeChal2Text.text = completeChal2; }
        if (Challenges.completedChallenge2 == 1) { completeChal2Text.text = chal2completed; }
        if (Challenges.completedChallenge3 == 0) { completeChal3Text.text = completeChal3; }
        if (Challenges.completedChallenge3 == 1) { completeChal3Text.text = chal3completed; }
        if (Challenges.completedChallenge4 == 0) { completeChal4Text.text = completeChal4; }
        if (Challenges.completedChallenge4 == 1) { completeChal4Text.text = chal4completed; }

        moreCoins = "%以上のコインを与えますs"; cheaper = "%安いです"; less = "%安いです"; coinsAfterInflating = "コインから始めます"; moreCoinsAfterInflating = "つのより多くの硬貨を与えます";

        inflateUpgradesStats = "アップグレードはあなたに"; inflateEndlessStats = "無限のインフレはあなたに"; inflateCheaperStats = "アップグレードは"; inflateSpecialCheaperStats = "特別なアップグレード";
        inflateActiveStats = "積極的にコインを反転すると、"; inflateStartWithCoinsStats = "膨張した後、"; inflatePileOfBagsStats = "袋の山は膨脹の後で";

        inflateEndlessStatsTEXT.text = LocalizationStrings.inflateEndlessStats + EndlessInflation.englessInflationBonusText + LocalizationStrings.moreCoins;
        inflateSpecialCheaperStatsTEXT.text = LocalizationStrings.inflateSpecialCheaperStats + (AscendScreen.totalSpecialReduction) + LocalizationStrings.less;
        inflateStartWithCoinsStatsTEXT.text = LocalizationStrings.inflateStartWithCoinsStats + AscendScreen.starWithCoinsAmount + LocalizationStrings.coinsAfterInflating;
        inflateUpgradesStatsTEXT.text = LocalizationStrings.inflateUpgradesStats + AscendScreen.moreCoinsUpgradePercent + LocalizationStrings.moreCoins;
        inflateCheaperStatsTEXT.text = LocalizationStrings.inflateCheaperStats + AscendScreen.cheaperUpgradesPercent + LocalizationStrings.cheaper;
        inflateActiveStatsTEXT.text = LocalizationStrings.inflateActiveStats + AscendScreen.activeFlipperPercent + LocalizationStrings.moreCoins;
        inflatePileOfBagsStatsTEXT.text = LocalizationStrings.inflatePileOfBagsStats + PileOfCoinsMechanics.PileBagAmount + LocalizationStrings.moreCoinsAfterInflating;

        inflateEndlessStatsTEXT.font = notoSans; inflateSpecialCheaperStatsTEXT.font = notoSans; inflateStartWithCoinsStatsTEXT.font = notoSans; inflateUpgradesStatsTEXT.font = notoSans;
        inflateCheaperStatsTEXT.font = notoSans; inflateActiveStatsTEXT.font = notoSans; inflatePileOfBagsStatsTEXT.font = notoSans;

        inflateEndlessStatsTEXT.fontSize = 16; inflateSpecialCheaperStatsTEXT.fontSize = 16; inflateStartWithCoinsStatsTEXT.fontSize = 16; inflateUpgradesStatsTEXT.fontSize = 16;
        inflateCheaperStatsTEXT.fontSize = 16; inflateActiveStatsTEXT.fontSize = 16; inflatePileOfBagsStatsTEXT.fontSize = 16;

        if (AscendScreen.boughtRich1 == 0) { inflateUpgradesStatsTEXT.text = LocalizationStrings.inflateUpgradesStats + "0" + LocalizationStrings.moreCoins; }
        if (AscendScreen.boughtSale1 == 0) { inflateCheaperStatsTEXT.text = LocalizationStrings.inflateCheaperStats + "0" + cheaper; }
        if (AscendScreen.boughtBagOfCoins1 == 0) { inflateStartWithCoinsStatsTEXT.text = LocalizationStrings.inflateStartWithCoinsStats + "0" + LocalizationStrings.coinsAfterInflating; }
        if (AscendScreen.boughtActiveFlipper1 == 0) { inflateActiveStatsTEXT.text = LocalizationStrings.inflateActiveStats + "0" + LocalizationStrings.moreCoins; }



        #endregion

        #region achievements

        achievements.text = "実績"; achievements.font = notoSansJapaneseBold;
        ach1.text = "コインを1つ獲得します"; ach1.font = notoSansJapaneseBold;
        ach2.text = "10コインを獲得します"; ach2.font = notoSansJapaneseBold;
        ach3.text = "100コインを獲得します"; ach3.font = notoSansJapaneseBold;
        ach4.text = "1000コインを獲得します"; ach4.font = notoSansJapaneseBold;
        ach5.text = "10000コインを獲得します"; ach5.font = notoSansJapaneseBold;
        ach6.text = "100000コインを獲得します"; ach6.font = notoSansJapaneseBold;
        ach7.text = "100万コインを獲得します"; ach7.font = notoSansJapaneseBold;
        ach8.text = "1億コインを獲得します"; ach8.font = notoSansJapaneseBold;
        ach9.text = "1兆コインを獲得します"; ach9.font = notoSansJapaneseBold;
        ach10.text = "1兆コインを獲得します"; ach10.font = notoSansJapaneseBold;
        ach11.text = "クインティリオンコインを1つ獲得します"; ach11.font = notoSansJapaneseBold;
        ach12.text = "セクスティリオンコインを1つ獲得します"; ach12.font = notoSansJapaneseBold;
        ach13.text = "セプティリオンコインを1つ獲得します"; ach13.font = notoSansJapaneseBold;
        ach14.text = "1オクタリオンコインを獲得"; ach14.font = notoSansJapaneseBold;
        ach15.text = "一度より強い腕をアップグレードしてください"; ach15.font = notoSansJapaneseBold;
        ach16.text = "より強い腕を10倍にアップグレードします"; ach16.font = notoSansJapaneseBold;
        ach17.text = "度大きなコインをアップグレードします"; ach17.font = notoSansJapaneseBold;
        ach18.text = "より大きなコインをアップグレード10回s"; ach18.font = notoSansJapaneseBold;
        ach19.text = "一度知識をアップグレードします"; ach19.font = notoSansJapaneseBold;
        ach20.text = "知識を10倍にアップグレードします"; ach20.font = notoSansJapaneseBold;
        ach21.text = "一度強い拳をアップグレードします"; ach21.font = notoSansJapaneseBold;
        ach22.text = "より強い拳を10倍にアップグレードします"; ach22.font = notoSansJapaneseBold;
        ach23.text = "一度手の注入をアップグレードします"; ach23.font = notoSansJapaneseBold;
        ach24.text = "手の注入を10回改善して下さい"; ach24.font = notoSansJapaneseBold;
        ach25.text = "一度脳の力をアップグレードします"; ach25.font = notoSansJapaneseBold;
        ach26.text = "脳の力を10倍アップグレードします"; ach26.font = notoSansJapaneseBold;
        ach27.text = "爆発的なフリップを一度アップグレードします"; ach27.font = notoSansJapaneseBold;
        ach28.text = "アップグレード爆発は10回反転します"; ach28.font = notoSansJapaneseBold;
        ach29.text = "一度水分補給をアップグレードします"; ach29.font = notoSansJapaneseBold;
        ach30.text = "水分補給を10倍にアップグレードします"; ach30.font = notoSansJapaneseBold;
        ach31.text = "一度奇妙なポーションをアップグレードします"; ach31.font = notoSansJapaneseBold;
        ach32.text = "奇妙なポーションを10回アップグレードします"; ach32.font = notoSansJapaneseBold;
        ach33.text = "マスターフリッパーを1回アップグレードします"; ach33.font = notoSansJapaneseBold;
        ach34.text = "マスターフリッパーを10回アップグレードします"; ach34.font = notoSansJapaneseBold;
        ach35.text = "ハンドシェイクを1回アップグレードします"; ach35.font = notoSansJapaneseBold;
        ach36.text = "ハンドシェイクを10回アップグレードします"; ach36.font = notoSansJapaneseBold;
        ach37.text = "アップグレード魔法は一度反転します"; ach37.font = notoSansJapaneseBold; ach37.fontSize = 8.4f;
        ach38.text = "アップグレード魔法は10回反転します"; ach38.font = notoSansJapaneseBold; ach38.fontSize = 8.4f;
        ach39.text = "幸運なコインを得るために2.5％のチャンスを持っています"; ach39.font = notoSansJapaneseBold;
        ach40.text = "幸運なコインを得るために5％のチャンスを持っています"; ach40.font = notoSansJapaneseBold;
        ach41.text = "ラッキーコインを1つヒットします"; ach41.font = notoSansJapaneseBold;
        ach42.text = "10ラッキーコインをヒット"; ach42.font = notoSansJapaneseBold;
        ach43.text = "100ラッキーコインをヒット"; ach43.font = notoSansJapaneseBold;
        ach44.text = "100コインを反転します"; ach44.font = notoSansJapaneseBold;
        ach45.text = "1000コインを反転します"; ach45.font = notoSansJapaneseBold;
        ach46.text = "10000コインを反転します"; ach46.font = notoSansJapaneseBold;
        ach47.text = "100000コインを反転します"; ach47.font = notoSansJapaneseBold;
        ach49.text = "同時に2つのコインを反転します"; ach49.font = notoSansJapaneseBold;
        ach50.text = "同時に5つのコインを反転します"; ach50.font = notoSansJapaneseBold;
        ach51.text = "同時に10つのコインを反転します"; ach51.font = notoSansJapaneseBold;
        ach94.text = "同時に21つのコインを反転します"; ach94.font = notoSansJapaneseBold;
        ach52.text = "アップグレード1コインフリッパー"; ach52.font = notoSansJapaneseBold;
        ach53.text = "アップグレード5コイン足ひれ"; ach53.font = notoSansJapaneseBold;
        ach54.text = "アップグレード10コイン足ひれ"; ach54.font = notoSansJapaneseBold;
        ach55.text = "アップグレード21コイン足ひれ"; ach55.font = notoSansJapaneseBold;
        ach56.text = "持っています75%成功したフリップのためのチャンス"; ach56.font = notoSansJapaneseBold;
        ach57.text = "持っています93.75%成功したフリップのためのチャンス"; ach57.font = notoSansJapaneseBold;
        ach58.text = "すべてのコインを反転"; ach58.font = notoSansJapaneseBold;
        ach59.text = "100万コインを反転します"; ach59.font = notoSansJapaneseBold;
        ach60.text = "1000ラッキーコインをヒット"; ach60.font = notoSansJapaneseBold;
        ach61.text = "尾を100000回ヒット"; ach61.font = notoSansJapaneseBold;
        ach62.text = "頭を100000回ヒット!"; ach62.font = notoSansJapaneseBold;
        ach63.text = "チャレンジ#1を完了します"; ach63.font = notoSansJapaneseBold;
        ach64.text = "チャレンジ#2を完了します"; ach64.font = notoSansJapaneseBold;
        ach65.text = "チャレンジ#3を完了します"; ach65.font = notoSansJapaneseBold;
        ach66.text = "チャレンジ#4を完了します"; ach66.font = notoSansJapaneseBold;
        ach67.text = "自動アップグレードのロックを解除します"; ach67.font = notoSansJapaneseBold;
        ach68.text = "積極的にコインを100回反転"; ach68.font = notoSansJapaneseBold;
        ach69.text = "積極的にコインを1000回反転"; ach69.font = notoSansJapaneseBold;
        ach70.text = "積極的にコインを5000回反転"; ach70.font = notoSansJapaneseBold;
        ach71.text = "一度宝箱を購入します"; ach71.font = notoSansJapaneseBold;
        ach72.text = "宝箱を10回購入します"; ach72.font = notoSansJapaneseBold;
        ach73.text = "一度コイン反転儀式を購入します"; ach73.font = notoSansJapaneseBold;
        ach74.text = "コインを10回反転させる儀式を購入します"; ach74.font = notoSansJapaneseBold;
        ach75.text = "ハイファイブを一度アップグレードしてください"; ach75.font = notoSansJapaneseBold;
        ach76.text = "ハイファイブアップグレード10回"; ach76.font = notoSansJapaneseBold;
        ach77.text = "合計25枚のインフレーションコインを持っています"; ach77.font = notoSansJapaneseBold;
        ach78.text = "合計50枚のインフレーションコインを持っています"; ach78.font = notoSansJapaneseBold;
        ach79.text = "合計75枚のインフレーションコインを持っています"; ach79.font = notoSansJapaneseBold;
        ach80.text = "5インフレーションアップグレードのロックを解除します"; ach80.font = notoSansJapaneseBold;
        ach81.text = "10インフレーションアップグレードのロックを解除します"; ach81.font = notoSansJapaneseBold;
        ach82.text = "20インフレーションアップグレードのロックを解除します"; ach82.font = notoSansJapaneseBold;
        ach83.text = "30インフレーションアップグレードのロックを解除します"; ach83.font = notoSansJapaneseBold;
        ach84.text = "すべてのインフレーションアップグレードのロックを解除します"; ach84.font = notoSansJapaneseBold;
        ach85.text = "コインの山を10回クリックします"; ach85.font = notoSansJapaneseBold;
        ach86.text = "コインの山を100回クリックします"; ach86.font = notoSansJapaneseBold;
        ach87.text = "膨らませて"; ach87.font = notoSansJapaneseBold;
        ach88.text = "5回膨らませてください"; ach88.font = notoSansJapaneseBold;
        ach89.text = "ギャンブル10回"; ach89.font = notoSansJapaneseBold;
        ach90.text = "あなたはすべてのあなたのコインを失った5回"; ach90.font = notoSansJapaneseBold;
        ach91.text = "あなたはすべてのあなたのコインを倍増5回"; ach91.font = notoSansJapaneseBold;
        ach92.text = "隠されたブロンズコインを見つけます"; ach92.font = notoSansJapaneseBold;
        ach93.text = "隠された銀のコインを見つけます"; ach93.font = notoSansJapaneseBold;


        #endregion

        #region InflationTree

        inflate.text = "膨らませます"; inflate.font = notoSansJapaneseBold; inflate.fontSize = 12;
        youHave21Flippers.text = "あなたは21コイン足ひれを持っています"; youHave21Flippers.font = notoSansJapaneseBold; youHave21Flippers.fontSize = 15;
        youNeed21Flippers.text = "あなたが必要21コイン足ひれに膨らませる"; youNeed21Flippers.font = notoSansJapaneseBold; youNeed21Flippers.fontSize = 15;
        youCanViewTreeAtAnyTime.text = "(あなたはいつでもインフレツリーを見ることができます)"; youCanViewTreeAtAnyTime.font = notoSansJapaneseBold;
        youCanViewTreeAtAnyTime.fontSize = 11;
        smallInflationDescription.text = "インフレは（いくつかの例外を除いて）すべての統計をリセットし、ユニークな永続的なアップグ インフレのアップグレードの購入が完了すると、ゲームは最初から開始されます"; smallInflationDescription.font = notoSans;
        smallInflationDescription.fontSize = 14;
        thisIsHowInflationWorks.text = "これはインフレシステムがどのように機能するかです:"; thisIsHowInflationWorks.font = notoSansJapaneseBold; thisIsHowInflationWorks.fontSize = 9;
        bigInflationDescription.text = "-あなたはインフレコインあなたがコインの次の層への道の四分の一を得るたびに獲得します\n-コインの層は、百万、十億、兆、兆などです\n-例：100万に達すると、インフレコインを獲得し始めます。そして、100万、2億5000万、5億5000万、7億5000万、10億、2500億、5000億、7500億などに達すると、インフレコインが授与されます\n-あなたはインフレコインを得るたびに得るベースインフレコイン量は1です。あなたがプレイするときに、より多くのインフレコインを得るために\"大きなインフレ\"のアップグレードを購入します"; bigInflationDescription.font = notoSansJapaneseBold; bigInflationDescription.fontSize = 7.6f;
        youHave.text = "あなたは"; youHave.font = notoSansJapaneseBold;
        inflationCoins.text = "つのインフレコインを持っています"; inflationCoins.font = notoSansJapaneseBold;
        dontInflateJustLook.text = "膨らませないで、木だけを見てください"; dontInflateJustLook.font = notoSansJapaneseBold; dontInflateJustLook.fontSize = 23;
        doYouWishToInflate.text = "あなたは膨らませたいですか?"; doYouWishToInflate.font = notoSansJapaneseBold; doYouWishToInflate.fontSize = 20;
        YES.text = "はい"; YES.font = notoSans;
        NO.text = "いいえ"; NO.font = notoSans;
        currentlyOnlyViewingTree.text = "! 現在、インフレツリーのみを表示しており、アップグレードを購入することはできません";
        currentlyOnlyViewingTree.font = notoSans;
        backToFlipping.text = "反転に戻る"; backToFlipping.font = notoSans; backToFlipping.fontSize = 28;
        backToFlipping2.text = "反転に戻る"; backToFlipping2.font = notoSansJapaneseBold; backToFlipping2.fontSize = 22;
        inflationCoinsText = "インフレコイン: ";
        InflationCoins.text = inflationCoinsText + AscendCoins.ascensionCoinAmount; InflationCoins.fontSize = 23; InflationCoins.font = notoSansJapaneseBold;

        rich1.text = "リッチ I"; rich1.font = notoSansJapaneseBold;
        rich2.text = "リッチ II"; rich2.font = notoSansJapaneseBold;
        rich3.text = "リッチ III"; rich3.font = notoSansJapaneseBold;
        rich4.text = "リッチ IV"; rich4.font = notoSansJapaneseBold;
        rich5.text = "リッチ V"; rich5.font = notoSansJapaneseBold;
        rich6.text = "リッチ VI"; rich6.font = notoSansJapaneseBold;
        rich7.text = "リッチ VII"; rich7.font = notoSansJapaneseBold;
        omegaRich.text = "オメガリッチ"; omegaRich.font = notoSansJapaneseBold;

        rich1Desc.text = "すべてのアップグレードはあなたに1%以上のコインを与えます\n豊富なアップグレードは、すべての挑戦のために動作します"; rich1Desc.font = notoSansJapaneseBold;
        rich1Desc.fontSize = 15;
        rich2Desc.text = "すべてのアップグレードはあなたに20%以上のコインを与えます"; rich2Desc.font = notoSansJapaneseBold;
        rich3Desc.text = "すべてのアップグレードはあなたに50%以上のコインを与えます"; rich3Desc.font = notoSansJapaneseBold;
        rich4Desc.text = "すべてのアップグレードはあなたに100%以上のコインを与えます"; rich4Desc.font = notoSansJapaneseBold;
        rich5Desc.text = "すべてのアップグレードはあなたに175%以上のコインを与えます"; rich5Desc.font = notoSansJapaneseBold;
        rich6Desc.text = "すべてのアップグレードはあなたに300%以上のコインを与えます"; rich6Desc.font = notoSansJapaneseBold;
        rich7Desc.text = "すべてのアップグレードはあなたに750%以上のコインを与えます"; rich7Desc.font = notoSansJapaneseBold;
        omegaRichDes.text = "すべてのアップグレードはあなたに1250%以上のコインを与えます"; omegaRichDes.font = notoSansJapaneseBold;

        sale1.text = "販売 I"; sale1.font = notoSansJapaneseBold;
        sale2.text = "販売 II"; sale2.font = notoSansJapaneseBold;
        sale3.text = "販売 III"; sale3.font = notoSansJapaneseBold;
        sale4.text = "販売 IV"; sale4.font = notoSansJapaneseBold;
        steamSale.text = "スチームセール"; steamSale.font = notoSansJapaneseBold; steamSale.fontSize = 22;
        sale1Desc.text = "すべてのアップグレードのコストは2%安くなります. このアップグレードブランチは特別なものには影響しません"; sale1Desc.font = notoSansJapaneseBold; sale1Desc.fontSize = 14;
        sale2Desc.text = "すべてのアップグレードのコストは7%安くなります"; sale2Desc.font = notoSansJapaneseBold;
        sale3Desc.text = "すべてのアップグレードのコストは14%安くなります"; sale3Desc.font = notoSansJapaneseBold;
        sale4Desc.text = "すべてのアップグレードのコストは22%安くなります"; sale4Desc.font = notoSansJapaneseBold;
        steamSaleDesc.text = "すべてのアップグレードのコストは50%安くなります"; steamSaleDesc.font = notoSansJapaneseBold;

        bag1.text = "コインの袋 I"; bag1.font = notoSansJapaneseBold;
        bag2.text = "コインの袋 II"; bag2.font = notoSansJapaneseBold;
        bag3.text = "コインの袋 III"; bag3.font = notoSansJapaneseBold;
        bag4.text = "コインの袋 IV"; bag4.font = notoSansJapaneseBold;
        hugeBag.text = "コインの袋 V"; hugeBag.font = notoSansJapaneseBold;
        pileOfBags.text = "袋の山"; pileOfBags.font = notoSansJapaneseBold;

        bag1Desc.text = "あなたは膨張した後、75コインの合計でゲームを開始します\nコインのアップグレードの袋は、唯一の\"いいえ自動反転\"の挑戦のために動作します"; bag1Desc.font = notoSansJapaneseBold;
        bag2Desc.text = "あなたは膨張した後、500コインの合計でゲームを開始します"; bag2Desc.font = notoSansJapaneseBold;
        bag3Desc.text = "あなたは膨張した後、3000コインの合計でゲームを開始します"; bag3Desc.font = notoSansJapaneseBold;
        bag4Desc.text = "あなたは膨張した後、20000コインの合計でゲームを開始します"; bag4Desc.font = notoSansJapaneseBold;
        hugeBasDesc.text = "あなたは膨張した後、100000コインの合計でゲームを開始します"; hugeBasDesc.font = notoSansJapaneseBold;
        pileOfBagsDesc.text = "あなたはコインの山をクリックするたびに、+250コインは、あなたが膨張した後で始まるコインの量に追加されます"; pileOfBagsDesc.font = notoSansJapaneseBold;

        greaterInflation1.text = "より大きなインフレ I"; greaterInflation1.font = notoSansJapaneseBold;
        greaterInflation2.text = "より大きなインフレ II"; greaterInflation2.font = notoSansJapaneseBold;
        greaterInflation3.text = "より大きなインフレ III"; greaterInflation3.font = notoSansJapaneseBold;
        greaterInflation4.text = "より大きなインフレ IV"; greaterInflation4.font = notoSansJapaneseBold;
        greaterInflation5.text = "より大きなインフレ V"; greaterInflation5.font = notoSansJapaneseBold;
        crazyInflation.text = "クレイジーインフレ!!"; crazyInflation.font = notoSansJapaneseBold; crazyInflation.fontSize = 17;
        inflationGamble1.text = "インフレギャンブル I"; inflationGamble1.font = notoSansJapaneseBold; inflationGamble1.fontSize = 17;
        inflationGamble2.text = "インフレギャンブル II"; inflationGamble2.font = notoSansJapaneseBold; inflationGamble2.fontSize = 17;
        inflationGamble3.text = "インフレギャンブル III"; inflationGamble3.font = notoSansJapaneseBold; inflationGamble3.fontSize = 17;
        inflationGamble4.text = "インフレギャンブル IV"; inflationGamble4.font = notoSansJapaneseBold; inflationGamble4.fontSize = 17;

        greaterInflation1Desc.text = "+あなたが兆層+をヒットしたときに2インフレコイン\nすべてのインフレのアップグレードは、\"常に幸運\"の挑戦を除くすべての挑戦のために動作します"; greaterInflation1Desc.font = notoSansJapaneseBold;
        greaterInflation2Desc.text = "+3あなたが兆ティアをヒットしたときのインフレーションコイン+"; greaterInflation2Desc.font = notoSansJapaneseBold;
        greaterInflation3Desc.text = "+2億ティアをヒットしたときのインフレコイン+\n+3あなたが兆ティアをヒットしたときのインフレーションコイン+"; greaterInflation3Desc.font = notoSansJapaneseBold;
        greaterInflation4Desc.text = "+3兆ティアをヒットしたときのインフレコイン+\n+クインティリオンティアをヒットしたときのインフレーションコイン4枚+"; greaterInflation4Desc.font = notoSansJapaneseBold;
        greaterInflation5Desc.text = "+4兆TIERをヒットしたときのインフレコイン+\nTIERをヒットしたときのインフレコイン5枚+"; greaterInflation5Desc.font = notoSansJapaneseBold;
        crazyInflationDesc.text = "+百万ティアをヒットしたときのインフレコイン6枚+"; crazyInflationDesc.font = notoSansJapaneseBold;
        inflationGamble1Desc.text = "あなたはインフレコインを得るたびに1余分なインフレコインを得るために+3%のチャンスがあります"; inflationGamble1Desc.font = notoSansJapaneseBold;
        inflationGamble2Desc.text = "あなたはインフレコインを得るたびに1余分なインフレコインを得るために+4%のチャンスがあります"; inflationGamble2Desc.font = notoSansJapaneseBold;
        inflationGamble3Desc.text = "あなたはインフレコインを得るたびに1余分なインフレコインを得るために+5％のチャンスがあります"; inflationGamble3Desc.font = notoSansJapaneseBold;
        inflationGamble4Desc.text = "あなたはインフレコインを得るたびに1余分なインフレコインを得るために+6％のチャンスがあります"; inflationGamble4Desc.font = notoSansJapaneseBold;

        extraSpecialUpgrade1.text = "エクストラスペシャルアップグレード I"; extraSpecialUpgrade1.font = notoSansJapaneseBold; extraSpecialUpgrade1.fontSize = 12;
        extraSpecialUpgrade2.text = "エクストラスペシャルアップグレード II"; extraSpecialUpgrade2.font = notoSansJapaneseBold; extraSpecialUpgrade2.fontSize = 12;
        extraSpecialUpgrade3.text = "エクストラスペシャルアップグレード III"; extraSpecialUpgrade3.font = notoSansJapaneseBold; extraSpecialUpgrade3.fontSize = 12;
        extraExtraSpecialUpgrade1.text = "エクストラ-エクストラ-スペシャル-アップグレード"; extraExtraSpecialUpgrade1.font = notoSansJapaneseBold; extraExtraSpecialUpgrade1.fontSize = 10;
        biggerPile1.text = "コインの大きな山 I"; biggerPile1.font = notoSansJapaneseBold;
        biggerPile2.text = "コインの大きな山 II"; biggerPile2.font = notoSansJapaneseBold;
        theGambler.text = "ザ-ギャンブラー"; theGambler.font = notoSansJapaneseBold;
        getLuckier.text = "幸運を得る"; getLuckier.font = notoSansJapaneseBold;
        autoUpgradeInflate.text = "自動アップグレード"; autoUpgradeInflate.font = notoSansJapaneseBold;

        extraSpecialUpgrade1Desc.text = "ギャンブルにはさらに2回の試行があります\nこのブランチのすべてのアップグレードは、すべての特別なアップグレードの価格を1％削減し、すべての挑戦のために動作します"; extraSpecialUpgrade1Desc.font = notoSansJapaneseBold; extraSpecialUpgrade1Desc.fontSize = 12.6f;
        extraSpecialUpgrade2Desc.text = "ギャンブルは今、あなたのコインを倍増する51％のチャンスを持っています\nコインの山はより多くのコインを生成します"; extraSpecialUpgrade2Desc.font = notoSansJapaneseBold;
        extraSpecialUpgrade3Desc.text = "あなたはコインの山からあなたのコインを取るとき、コインが山にとどまることを5％のチャンスがあります"; extraSpecialUpgrade3Desc.font = notoSansJapaneseBold;
        extraExtraSpecialUpgrade1Desc.text = "特別なアップグレードの費用は13％少なくなります\nギャンブルにはもう1つの試みがあります\nコインを生成するコインの2つのより多くの山\nアップグレードされたコインフリップは今あなたに3倍のコインを与え、幸運なコインはあなたに15倍を与えます"; extraExtraSpecialUpgrade1Desc.font = notoSansJapaneseBold;
        extraExtraSpecialUpgrade1Desc.fontSize = 11f;
        biggerPile1Desc.text = "コインの山はあなたにコインを生成する+1パイルを与えます\nコインの山はあなたに多くのコインを与えます"; biggerPile1Desc.font = notoSansJapaneseBold;
        biggerPile2Desc.text = "コインの山はあなたにコインを生成する+1パイルを与えます\nコインの山はあなたにさらに多くのコインを与えます"; biggerPile2Desc.font = notoSansJapaneseBold;
        theGamblerDesc.text = "ギャンブルにはもう1つの試みがあります\nあなたがギャンブルするたびに、あなたのコインを倍増させる可能性が1増加します%"; theGamblerDesc.font = notoSansJapaneseBold;
        getLuckierDesc.text = "あなたが幸運なコインを打つたびに。幸運なコインがさらに幸運なコインになる可能性が5％あり、コインの50倍になります"; getLuckierDesc.font = notoSansJapaneseBold; getLuckierDesc.fontSize = 12;
        autoUpgradeDesc.text = "特別なアップグレード]タブ内の[自動アップグレードのロックを解除します"; autoUpgradeDesc.font = notoSansJapaneseBold;

        active1.text = "アクティブフリッパー I"; active1.font = notoSansJapaneseBold; active1.fontSize = 17;
        active2.text = "アクティブフリッパー II"; active2.font = notoSansJapaneseBold; active2.fontSize = 17;
        active3.text = "アクティブフリッパー III"; active3.font = notoSansJapaneseBold; active3.fontSize = 17;
        active4.text = "アクティブフリッパー IV"; active4.font = notoSansJapaneseBold; active4.fontSize = 17;
        superActiveFlipper.text = "スーパーアクティブフリッパー"; superActiveFlipper.font = notoSansJapaneseBold; superActiveFlipper.fontSize = 17;
        activeEqualsBiggerPile.text = "アクティブ=コインの大きな山"; activeEqualsBiggerPile.font = notoSansJapaneseBold; activeEqualsBiggerPile.fontSize = 13;

        active1Desc.text = "あなたが積極的に反転するすべてのコインはあなたに8%より多くのコインを与えるでしょう\nアクティブフリッパーのアップグレードは、すべての挑戦のために動作します"; active1Desc.font = notoSansJapaneseBold; active1Desc.fontSize = 12;
        active2Desc.text = "あなたが積極的に反転するすべてのコインはあなたに23%より多くのコインを与えるでしょう"; active2Desc.font = notoSansJapaneseBold;
        active3Desc.text = "あなたが積極的に反転するすべてのコインはあなたに40%より多くのコインを与えるでしょう"; active3Desc.font = notoSansJapaneseBold;
        active4Desc.text = "あなたが積極的に反転するすべてのコインはあなたに69%より多くのコインを与えるでしょう"; active4Desc.font = notoSansJapaneseBold;
        superActiveFlipperDesc.text = "あなたが積極的に反転するすべてのコインはあなたに300%より多くのコインを与えるでしょう\nラッキーコインはあなたに10倍を与えます"; superActiveFlipperDesc.font = notoSansJapaneseBold;
        activeEqualsBiggerPileDesc.text = "あなたが積極的にコインを反転するたびに、あなたが頭/尾に持っているコインの量がコインの山に追加されることを5％のチャンスがあります"; activeEqualsBiggerPileDesc.font = notoSansJapaneseBold;
        backToFlippingIflated.text = "あなたはコインを反転することに戻りたいですか?"; backToFlippingIflated.font = notoSansJapaneseBold;
        yes.text = "はい"; yes.font = notoSansJapaneseBold; no.text = "いいえ"; no.font = notoSansJapaneseBold;

        for (int i = 0; i < unLocked.Length; i++)
        {
            unLocked[i].text = "ロックされている";
            unLocked[i].font = notoSans;
            unLocked[i].fontSize = 9;
        }

        for (int i = 0; i < locked.Length; i++)
        {
            locked[i].text = "ロック解除";
            locked[i].font = notoSans;
            locked[i].fontSize = 12;
        }


        #endregion

        #region settings

        music.text = "音楽"; music.font = notoSansJapaneseBold; audiotext.text = "オーディオ"; audiotext.font = notoSansJapaneseBold;
        fullscreen.text = "フルスクリーン"; fullscreen.font = notoSans;
        saveGame.text = "ゲームを保存します"; saveGame.font = notoSansJapaneseBold;
        exitGame.text = "ゲームを終了します"; exitGame.font = notoSansJapaneseBold; resetEverything.text = "すべてをリセットします"; resetEverything.font = notoSansJapaneseBold;
        gameIsSaved30Seconds.text = "(ゲームは30秒ごとに保存されます)"; gameIsSaved30Seconds.font = notoSansJapaneseBold;
        foundHiddenBronze.text = "あなたは隠された青銅のコインを見つけました"; foundHiddenBronze.font = notoSansJapaneseBold;
        foundHiddenSilver.text = "あなたは隠された銀貨を見つけました"; foundHiddenSilver.font = notoSansJapaneseBold;
        settings.text = "設定"; settings.font = notoSans; settings.fontSize = 27;
        info.text = "情報"; info.font = notoSans; info.fontSize = 27;
        socials.text = "ソーシャルメディア"; socials.font = notoSans; socials.fontSize = 12;
        generalGameInfo.text = "一般的なゲーム情報"; generalGameInfo.font = notoSans;
        mechanicsExplanations.text = "力学の説明:"; mechanicsExplanations.font = notoSans;

        inflationSystem.text = "インフレーションシステム"; inflationSystem.font = notoSans; inflationSystem.fontSize = 17;
        inflationSystemDesc.text = "-あなたはインフレコインあなたがコインの次の層への道の四分の一を得るたびに獲得します\n-コインの層は、百万、十億、兆、兆などです\n-例：100万に達すると、インフレコインを獲得し始めます。そして、100万、2億5000万、5億5000万、7億5000万、10億、2500億、5000億、7500億などに達すると、インフレコインが授与されます\nあなたはインフレコインを得るたびに得るベースインフレコイン量は1です。あなたがプレイするときに、より多くのインフレコインを得るために\"大きなインフレ\"のアップグレードを購入します"; inflationSystemDesc.font = notoSans;
        inflationSystemDesc.fontSize = 12.7f;

        pileOfCoinsText.text = "コインの山:"; pileOfCoinsText.font = notoSans;
        pileOfCoinsDesc.text = "パイルが生成するコインの量は、成功したフリップごとに持っているコインの数と、+4を持っているコインの足ひれの数に基づいています。したがって、頭/尾に150枚のコインと4枚のコインの足ひれがある場合、生成される量は150*（4+4）になり、1200になります。プレイヤーは、いくつかの\"余分な特別なアップグレード\"インフレのアップグレードを購入した場合、量が大きくなります"; pileOfCoinsDesc.font = notoSans;
        pileOfCoinsDesc.fontSize = 11.5f;

        offlineProgression.text = "オフライン進行:"; offlineProgression.font = notoSans;
        offlineProgressionDesc.text = "あなたはコインあなたがオフラインであることを毎分を獲得します。量は、あなたが持っている頭/尾にどのように多くの自動足ひれとコインに基づいています。だからあなたが頭/尾と4つの自動足ひれに500千のコインを持っているならば。あなたは毎分200万コインを獲得します"; offlineProgressionDesc.font = notoSans; offlineProgressionDesc.fontSize = 11;

        developerBy.text = "コインフリッパーはによって開発されています: <b>Simon Eftestøl</b>"; developerBy.font = notoSans;
        musicBy.text = "音楽によって: <b>HSB Loops</b>"; musicBy.font = notoSans;
        texturesProvidedBy.text = "テクスチャによって提供される: <b>Free SVG</b>"; texturesProvidedBy.font = notoSans;
        followMyTwitch.text = "私の単収縮に従ってください"; followMyTwitch.font = notoSans;
        follotMyTwitter.text = "私のXに従ってください"; follotMyTwitter.font = notoSans;
        joinTheDiscord.text = "不和に参加してください"; joinTheDiscord.font = notoSans;
        quitPlayingChallenge.text = "挑戦をやめますか？"; quitPlayingChallenge.font = notoSans;
        quitChallengeDesc.text = "ゲームはリセットされ、「表か裏かを選ぶ」画面に戻ります。もちろん、すべての永続的なインフレアップグレードはリセットされません"; quitChallengeDesc.font = notoSans;
        quitChalYes.text = "はい"; quitChalYes.font = notoSansJapaneseBold;
        quitChalNo.text = "いいえ"; quitChalNo.font = notoSansJapaneseBold;
        whishToResetGame.text = "あなたは完全にやり直したいですか?"; whishToResetGame.font = notoSans;
        wishToResetDesc.text = "すべてがリセットされ、ゲームは最初から始まります"; wishToResetDesc.font = notoSans;
        resetYes.text = "はい"; resetYes.font = notoSansJapaneseBold;
        resetNo.text = "いいえ"; resetNo.font = notoSansJapaneseBold;
        quitChall1.text = "挑戦をやめる"; quitChall1.font = notoSansJapaneseBold; quitChall1.fontSize = 36;
        quitChall2.text = "挑戦をやめる"; quitChall2.font = notoSansJapaneseBold; quitChall2.fontSize = 36;
        quitChall3.text = "挑戦をやめる"; quitChall3.font = notoSansJapaneseBold; quitChall3.fontSize = 36;
        quitChall4.text = "挑戦をやめる"; quitChall4.font = notoSansJapaneseBold; quitChall4.fontSize = 36;
        gameSaved.text = "ゲームが保存されました"; gameSaved.font = notoSans;
        gameSaved2.text = "ゲームが保存されました"; gameSaved2.font = notoSans;

        #endregion

        #region offlineEarnings

        days = "日、"; hours = "時間、"; minuts = "分"; secondsTime = "秒のために行っていました";

        offlineEarningTotalText.font = notoSansJapaneseBold;
        timeGoneText.font = notoSansJapaneseBold;

        welcomeBack.text = "おかえりなさい!"; welcomeBack.font = notoSansJapaneseBold;
        youWereGoneFor.text = "あなたは"; youWereGoneFor.font = notoSans;
        offlineEarnings.text = "オフライン収益: "; offlineEarnings.font = notoSans;
        offlineOK.text = "わかった"; offlineOK.font = notoSansJapaneseBold; offlineOK.fontSize = 24;

        #endregion

        #region FINAL missed

        upgradesHover.text = "アップグレード"; upgradesHover.font = notoSansJapaneseBold; upgradesHover.fontSize = 30;
        specialUpgradesHover.text = "特別なアップグレード"; specialUpgradesHover.font = notoSansJapaneseBold; specialUpgradesHover.fontSize = 29;
        achievementsHover.text = "実績"; achievementsHover.font = notoSansJapaneseBold; achievementsHover.fontSize = 29;
        statsHover.text = "統計"; statsHover.font = notoSansJapaneseBold; statsHover.fontSize = 36;

        specialIpgradeWarning.text = "このアップグレードを購入する前に、別の\"自動コインフリップ\"アップグレードを購入する必要があります";
        specialIpgradeWarning.font = notoSansJapaneseBold; specialIpgradeWarning.fontSize = 8;

        congrats1.text = "おめでとう!"; congrats1.font = notoSansJapaneseBold;
        congrats2.text = "おめでとう!"; congrats2.font = notoSansJapaneseBold;
        congrats3.text = "おめでとう!"; congrats3.font = notoSansJapaneseBold;
        congrats4.text = "おめでとう!"; congrats4.font = notoSansJapaneseBold;
        youUnlocked1.text = "ロックを解除しました:"; youUnlocked1.font = notoSansJapaneseBold; youUnlocked1.fontSize = 11;
        youUnlocked2.text = "ロックを解除しました:"; youUnlocked2.font = notoSansJapaneseBold; youUnlocked2.fontSize = 11;
        youUnlocked3.text = "ロックを解除しました:"; youUnlocked3.font = notoSansJapaneseBold; youUnlocked3.fontSize = 11;
        youUnlocked4.text = "ロックを解除しました:"; youUnlocked4.font = notoSansJapaneseBold; youUnlocked4.fontSize = 11;
        youCompletedChal1.text = "あなたは挑戦＃1を完了しました-\"自動反転なし\""; youCompletedChal1.font = notoSansJapaneseBold;
        youCompletedChal2.text = "あなたは挑戦＃2を完了しました-\"不運\""; youCompletedChal2.font = notoSansJapaneseBold;
        youCompletedChal3.text = "あなたは挑戦＃3を完了しました-\"1コインフリッパー\""; youCompletedChal3.font = notoSansJapaneseBold;
        youCompletedChal4.text = "あなたは挑戦＃4を完了しました-\"ラッキー\""; youCompletedChal4.font = notoSansJapaneseBold;
        completedChalFlipAll.text = "すべて反転します"; completedChalFlipAll.font = notoSansJapaneseBold;
        completedChallAutoFlipsEquals.text = "自動反転="; completedChallAutoFlipsEquals.font = notoSansJapaneseBold; completedChallAutoFlipsEquals.fontSize = 25;
        onText.text = "オン"; onText.font = notoSansJapaneseBold;
        onText2.text = "オン"; onText2.font = notoSansJapaneseBold;
        offText.text = "オフ"; offText.font = notoSansJapaneseBold;
        chal2CompletedRewardInfo.text = "最初の5コイン足ひれは常に成功します"; chal2CompletedRewardInfo.font = notoSansJapaneseBold;
        chal3CompletedRewardInfo.text = "最初のコインフリッパーは常に成功し、+500％のコインボーナスを獲得します";
        chal3CompletedRewardInfo.font = notoSansJapaneseBold;
        chal4CompletedRewardInfo.text = "コインフリップは今まで持っています15%幸運なコインをヒットするチャンス"; chal4CompletedRewardInfo.font = notoSansJapaneseBold;
        chal4CompletedRewardInfo.fontSize = 10;

        totalCoins = "コイン: ";
        coinsMainText.text = "コイン: " + FormatCoins(GlobalCoins.CoinCount); coinsMainText.font = notoSansJapaneseBold;

        lockedAuto.text = "ロックされている"; lockedAuto.font = notoSansJapaneseBold;
        lockedDuplicate.text = "ロックされている"; lockedDuplicate.font = notoSansJapaneseBold;
        lockedLucky.text = "ロックされている"; lockedLucky.font = notoSansJapaneseBold;
        lockedHigherChance.text = "ロックされている"; lockedHigherChance.font = notoSansJapaneseBold;
        lockedSpecialUpgrade.text = "ロックされている"; lockedSpecialUpgrade.font = notoSansJapaneseBold;

        moreCoinsIn = ""; Xseconds = "";
        moreCoinsIn1.font = notoSansJapaneseBold;
        moreCoinsIn2.font = notoSansJapaneseBold;
        moreCoinsIn3.font = notoSansJapaneseBold;
        moreCoinsIn4.font = notoSansJapaneseBold;
        moreCoinsIn5.font = notoSansJapaneseBold;
        plussPile1.text = "+コインの山"; plussPile1.font = notoSansJapaneseBold;
        plussPile2.text = "+コインの山"; plussPile2.font = notoSansJapaneseBold;
        plussPile3.text = "+コインの山"; plussPile3.font = notoSansJapaneseBold;
        plussPile4.text = "+コインの山"; plussPile4.font = notoSansJapaneseBold;
        plussPile5.text = "+コインの山"; plussPile5.font = notoSansJapaneseBold;
        thisPileContains1.text = "この山には以下が含まれます: "; thisPileContains1.font = notoSansJapaneseBold;
        thisPileContains2.text = "この山には以下が含まれます: "; thisPileContains2.font = notoSansJapaneseBold;
        thisPileContains3.text = "この山には以下が含まれます: "; thisPileContains3.font = notoSansJapaneseBold;
        thisPileContains4.text = "この山には以下が含まれます: "; thisPileContains4.font = notoSansJapaneseBold;
        thisPileContains5.text = "この山には以下が含まれます: "; thisPileContains5.font = notoSansJapaneseBold;

        totalCoinsPile1.text = FormatCoins2(PileOfCoinsMechanics.PileOfCoinsAmount1);
        totalCoinsPile2.text = FormatCoins2(PileOfCoinsMechanics.PileOfCoinsAmount2);
        totalCoinsPile3.text = FormatCoins2(PileOfCoinsMechanics.PileOfCoinsAmount3);
        totalCoinsPile4.text = FormatCoins2(PileOfCoinsMechanics.PileOfCoinsAmount4);
        totalCoinsPile5.text = FormatCoins2(PileOfCoinsMechanics.PileOfCoinsAmount5);

        totalCoinsPile1.font = notoSansJapaneseBold;
        totalCoinsPile2.font = notoSansJapaneseBold;
        totalCoinsPile3.font = notoSansJapaneseBold;
        totalCoinsPile4.font = notoSansJapaneseBold;
        totalCoinsPile5.font = notoSansJapaneseBold;

        heads = "ヘッド! ";
        tails = "尾! ";
        luckyCoin = "ラッキーコイン! ";

        #endregion

        googlePlayText.text = "";
        googlePlayText.font = notoSansJapaneseBold;
    }
    #endregion



    public TextMeshProUGUI upgradeClose, pileClose, achievementClose, closeAutoUpgradeFrame, inflateClose, inlfateUpgradeClose, inflateInfoClose, challengesInfoClose, challengesClose;
    public TextMeshProUGUI pileCollectText, inflateView, inflateUpgradePurchase;
    public static string challengesSelect, challengesUnselect;
    public TextMeshProUGUI challengesSelectUnbselectText;

    public void SetMobileTexts()
    {
        if (ChooseText == 1) 
        {
            challengesSelect = "SELECT";
            challengesUnselect = "UNSELECT";
            challengesSelectUnbselectText.font = JostHeavyEngAndRuss;

            upgradeClose.text = "CLOSE"; upgradeClose.font = JostHeavyEngAndRuss;
            pileClose.text = "CLOSE"; pileClose.font = JostHeavyEngAndRuss;
            achievementClose.text = "CLOSE"; achievementClose.font = JostHeavyEngAndRuss;
            closeAutoUpgradeFrame.text = "CLOSE"; closeAutoUpgradeFrame.font = JostHeavyEngAndRuss;
            inflateClose.text = "CLOSE"; inflateClose.font = JostHeavyEngAndRuss;
            inlfateUpgradeClose.text = "CLOSE"; inlfateUpgradeClose.font = JostHeavyEngAndRuss;
            inflateInfoClose.text = "CLOSE"; inflateInfoClose.font = JostHeavyEngAndRuss;
            challengesInfoClose.text = "CLOSE"; challengesInfoClose.font = JostHeavyEngAndRuss;
            challengesClose.text = "CLOSE"; challengesClose.font = JostHeavyEngAndRuss;

            pileCollectText.text = "COLLECT"; pileCollectText.font = JostHeavyEngAndRuss;
            inflateView.text = "VIEW"; inflateView.font = JostHeavyEngAndRuss;
            inflateUpgradePurchase.text = "PURCHASE"; inflateUpgradePurchase.font = JostHeavyEngAndRuss;
        }
        if (ChooseText == 2) 
        {
            //RUSSIAN
            challengesSelect = "<size=40>ВЫБРАТЬ";
            challengesUnselect = "<size=27>СНЯТЬ ВЫБОР";
            challengesSelectUnbselectText.font = JostHeavyEngAndRuss;

            upgradeClose.text = "<size=11>ЗАКРЫТЬ"; upgradeClose.font = JostHeavyEngAndRuss;
            pileClose.text = "<size=34>ЗАКРЫТЬ"; pileClose.font = JostHeavyEngAndRuss;
            achievementClose.text = "<size=6>ЗАКРЫТЬ"; achievementClose.font = JostHeavyEngAndRuss;
            closeAutoUpgradeFrame.text = "<size=9>ЗАКРЫТЬ"; closeAutoUpgradeFrame.font = JostHeavyEngAndRuss;
            inflateClose.text = "<size=25>ЗАКРЫТЬ"; inflateClose.font = JostHeavyEngAndRuss;
            inlfateUpgradeClose.text = "<size=34>ЗАКРЫТЬ"; inlfateUpgradeClose.font = JostHeavyEngAndRuss;
            inflateInfoClose.text = "<size=25>ЗАКРЫТЬ"; inflateInfoClose.font = JostHeavyEngAndRuss;
            challengesInfoClose.text = "<size=32>ЗАКРЫТЬ"; challengesInfoClose.font = JostHeavyEngAndRuss;
            challengesClose.text = "<size=40>ЗАКРЫТЬ"; challengesClose.font = JostHeavyEngAndRuss;

            pileCollectText.text = "СОБРАТЬ"; pileCollectText.font = JostHeavyEngAndRuss;
            inflateView.text = "<size=23>ПРОСМОТР"; inflateView.font = JostHeavyEngAndRuss;
            inflateUpgradePurchase.text = "ПОКУПКА"; inflateUpgradePurchase.font = JostHeavyEngAndRuss;
        }
        if (ChooseText == 3)
        {
            //Chinese
            challengesSelect = "选择";
            challengesUnselect = "离开";
            challengesSelectUnbselectText.font = notoSansChineseBold;

            upgradeClose.text = "关闭"; upgradeClose.font = notoSansChineseBold;
            pileClose.text = "关闭"; pileClose.font = notoSansChineseBold;
            achievementClose.text = "关闭"; achievementClose.font = notoSansChineseBold;
            closeAutoUpgradeFrame.text = "关闭"; closeAutoUpgradeFrame.font = notoSansChineseBold;
            inflateClose.text = "关闭"; inflateClose.font = notoSansChineseBold;
            inlfateUpgradeClose.text = "关闭"; inlfateUpgradeClose.font = notoSansChineseBold;
            inflateInfoClose.text = "关闭"; inflateInfoClose.font = notoSansChineseBold;
            challengesInfoClose.text = "关闭"; challengesInfoClose.font = notoSansChineseBold;
            challengesClose.text = "关闭"; challengesClose.font = notoSansChineseBold;

            pileCollectText.text = "收集"; pileCollectText.font = notoSansChineseBold;
            inflateView.text = "查看"; inflateView.font = notoSansChineseBold;
            inflateUpgradePurchase.text = "购买"; inflateUpgradePurchase.font = notoSansChineseBold;
        }
        if (ChooseText == 4) 
        {
            //Korean
            challengesSelect = "선택";
            challengesUnselect = "선택 해제";
            challengesSelectUnbselectText.font = nonoSansKoreanBold;

            upgradeClose.text = "떠나다"; upgradeClose.font = nonoSansKoreanBold;
            pileClose.text = "떠나다"; pileClose.font = nonoSansKoreanBold;
            achievementClose.text = "떠나다"; achievementClose.font = nonoSansKoreanBold;
            closeAutoUpgradeFrame.text = "떠나다"; closeAutoUpgradeFrame.font = nonoSansKoreanBold;
            inflateClose.text = "떠나다"; inflateClose.font = nonoSansKoreanBold;
            inlfateUpgradeClose.text = "떠나다"; inlfateUpgradeClose.font = nonoSansKoreanBold;
            inflateInfoClose.text = "떠나다"; inflateInfoClose.font = nonoSansKoreanBold;
            challengesInfoClose.text = "떠나다"; challengesInfoClose.font = nonoSansKoreanBold;
            challengesClose.text = "떠나다"; challengesClose.font = nonoSansKoreanBold;

            pileCollectText.text = "수집"; pileCollectText.font = nonoSansKoreanBold;
            inflateView.text = "보기"; inflateView.font = nonoSansKoreanBold;
            inflateUpgradePurchase.text = "구매"; inflateUpgradePurchase.font = nonoSansKoreanBold;
        }
        if (ChooseText == 5) 
        {
            //Japanese
            challengesSelect = "選択";
            challengesUnselect = "選択解除";
            challengesSelectUnbselectText.font = notoSansJapaneseBold;

            upgradeClose.text = "閉じる"; upgradeClose.font = notoSansJapaneseBold;
            pileClose.text = "閉じる"; pileClose.font = notoSansJapaneseBold;
            achievementClose.text = "閉じる"; achievementClose.font = notoSansJapaneseBold;
            closeAutoUpgradeFrame.text = "閉じる"; closeAutoUpgradeFrame.font = notoSansJapaneseBold;
            inflateClose.text = "閉じる"; inflateClose.font = notoSansJapaneseBold;
            inlfateUpgradeClose.text = "閉じる"; inlfateUpgradeClose.font = notoSansJapaneseBold;
            inflateInfoClose.text = "閉じる"; inflateInfoClose.font = notoSansJapaneseBold;
            challengesInfoClose.text = "閉じる"; challengesInfoClose.font = notoSansJapaneseBold;
            challengesClose.text = "閉じる"; challengesClose.font = notoSansJapaneseBold;

            pileCollectText.text = "集める"; pileCollectText.font = notoSansJapaneseBold;
            inflateView.text = "表示"; inflateView.font = notoSansJapaneseBold;
            inflateUpgradePurchase.text = "購入"; inflateUpgradePurchase.font = notoSansJapaneseBold;
        }
    }

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
            _ => ((float)coins / 1.0).ToString("##")
        };
    }

    public static string FormatCoins2(float coins)
    {
        return coins switch
        {
            >= 1E+36f => ((float)coins / 1E+36).ToString("0.##") + LocalizationStrings.undecillionc,
            >= 1E+33f => ((float)coins / 1E+33).ToString("0.##") + LocalizationStrings.decillionc,
            >= 1E+30f => ((float)coins / 1E+30).ToString("0.##") + LocalizationStrings.nonillionc,
            >= 1E+27f => ((float)coins / 1E+27).ToString("0.##") + LocalizationStrings.octillionc,
            >= 1E+24f => ((float)coins / 1E+24).ToString("0.##") + LocalizationStrings.septillionc,
            >= 1E+21f => ((float)coins / 1E+21).ToString("0.##") + LocalizationStrings.sextillionc,
            >= 1E+18f => ((float)coins / 1E+18).ToString("0.##") + LocalizationStrings.quintillionc,
            >= 1E+15f => ((float)coins / 1E+15).ToString("0.##") + LocalizationStrings.quadrillionc,
            >= 1E+12f => ((float)coins / 1000000000000.0).ToString("0.##") + LocalizationStrings.trillionc,
            >= 1E+09f => ((float)coins / 1000000000.0).ToString("0.##") + LocalizationStrings.billionc,
            >= 1000000f => ((float)coins / 1000000.0).ToString("0.##") + LocalizationStrings.millionc,
            >= 1000f => ((float)coins / 1000.0).ToString("0.##") + LocalizationStrings.thousandC,
            _ => ((float)coins / 1.0).ToString("##") + LocalizationStrings.coins
        };
    }
}
