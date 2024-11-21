using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using TMPro;
public class PurchaseLog : MonoBehaviour
{
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

    public GameObject AutoCoinFlips;
    public GameObject AutoCoinFlips2;
    public GameObject AutoCoinFlips3;
    public GameObject AutoCoinFlips4;
    public GameObject AutoCoinFlips5;
    public GameObject AutoCoinFlips6;
    public GameObject AutoCoinFlips7;
    public GameObject AutoCoinFlips8;
    public GameObject AutoCoinFlips9;
    public GameObject AutoCoinFlips10;
    public GameObject AutoCoinFlips11;
    public GameObject AutoCoinFlips12;
    public GameObject AutoCoinFlips13;
    public GameObject AutoCoinFlips14;
    public GameObject AutoCoinFlips15;
    public GameObject AutoCoinFlips16;
    public GameObject AutoCoinFlips17;
    public GameObject AutoCoinFlips18;
    public GameObject AutoCoinFlips19;
    public GameObject AutoCoinFlips20;
    public GameObject AutoCoinFlips21;
    public GameObject MoreCoinsPerClick;
    public GameObject FasterAnim;
    public GameObject HigherChanceForCoin;
    public AudioSource UpgradeSound1;
    public AudioSource UpgradeSound2;
    public int generateRandomUpgradeSound;
    public static int coinsPerUpgrade = 1;
    MainButtonClick mainButtonClick1;
    public VideoPlayer videoPlayer;
    public GameObject flipObject;
    public GameObject greaterCoinsUpgrade;

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
    public TextMeshProUGUI treasureCountText;
    public TextMeshProUGUI ritualCountText;

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
            >= 1000f => ((float)coins / 1000.0).ToString("0.##")+ LocalizationStrings.thousand,
            _ => ((float)coins / 1.0).ToString("##") 
        };
    }

    public static string FormatCoinsGamble(float coins)
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

    private void Awake()
    {
        mainButtonClick1 = videoPlayer.GetComponent<MainButtonClick>();
        mainButtonClick1 = flipObject.GetComponent<MainButtonClick>();
    }

    public void Start()
    {
        StartFlippers();
        StartCoroutine(SetText());
    }

    IEnumerator SetText()
    {
        yield return new WaitForSeconds(0.1f);

        if (Challenges.isChallenge2Active == 1)
        {
            higherChanceHoverover.headsPercent = 73.75f;
            higherChanceHoverover.tailsPercent = 25.75f;
            MainButtonClick.lowerCoinChance = 150;
            MainButtonClick.higherCoinChance = 149;
            MainButtonClick.lowSpecialChance = 1;
            headChance.GetComponent<TextMeshProUGUI>().text = higherChanceHoverover.headsPercent + LocalizationStrings.higherChanceHeads;
            tailsChance.GetComponent<TextMeshProUGUI>().text = higherChanceHoverover.tailsPercent + LocalizationStrings.higherChanceTails;
            luckyChance.GetComponent<TextMeshProUGUI>().text = GetLuckyHoverOver.luckyChance + LocalizationStrings.luckyCoinChance;
        }
        if (Challenges.isChallenge4Active == 1)
        {
            headChance.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.higherChanceHeads;
            tailsChance.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.higherChanceTails;
            luckyChance.GetComponent<TextMeshProUGUI>().text = "100" + LocalizationStrings.luckyCoinChance;
            MainButtonClick.lowSpecialChance = 202;
            MainButtonClick.higherCoinChance = 203;
            MainButtonClick.lowerCoinChance = 204;
        }
        if (Challenges.isChallenge4Active == 0 && Challenges.isChallenge2Active == 0)
        {
            headChance.GetComponent<TextMeshProUGUI>().text = higherChanceHoverover.headsPercent + LocalizationStrings.higherChanceHeads;
            tailsChance.GetComponent<TextMeshProUGUI>().text = higherChanceHoverover.tailsPercent + LocalizationStrings.higherChanceTails;
            luckyChance.GetComponent<TextMeshProUGUI>().text = GetLuckyHoverOver.luckyChance + LocalizationStrings.luckyCoinChance;
        }
          


        pileCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + pileOfCoinsCount;
        pileWaitTimeText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.pileGeneratesEveyXSecond;
        gambleTimesAmountText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.youGambled + (0 + amountOfTimesGambled) + LocalizationStrings.times;
        gambleTimesAmountWONText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.wonGambling + (0 + amountOfTimesGambledWON) + LocalizationStrings.times;
        gambleTimesAmountLOSTText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.lostGambling + (0 + amountOfTimesGambledLOST) + LocalizationStrings.times;

        if(MagicFlipsUpgrade.magicUpgradeCount == 0)
        {
            magicInfo.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.buyUpgrade;
        }
        if(MagicFlipsUpgrade.magicUpgradeCount >= 1)
        {

            magicInfo.text = LocalizationStrings.your + MagicFlipsUpgrade.magicUpgradeCount + LocalizationStrings.statsMagic + FormatCoins(PurchaseLog.magicFlipsInfo) + LocalizationStrings.coins;

        }

        if(TreasureChest.treasureCount == 0)
        {
            treasureInfoText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.buyUpgrade;
        }
        if(TreasureChest.treasureCount >= 1)
        {

            treasureInfoText.text = LocalizationStrings.your + TreasureChest.treasureCount + LocalizationStrings.statsTreasure + FormatCoins(PurchaseLog.treasureInfo) + LocalizationStrings.coins;

        }
        if(RitualUpgrade.treasureCount == 0)
        {
            ritualInfoText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.buyUpgrade;
        }
        if (RitualUpgrade.treasureCount >= 1)
        {

            ritualInfoText.text = LocalizationStrings.your + RitualUpgrade.treasureCount + LocalizationStrings.statsRitual + FormatCoins(PurchaseLog.ritualInfo) + LocalizationStrings.coins;

        }

    }

    public void StartFlippers()
    {
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 0)
        {
            StartCoroutine(waitForAutoFlip1());
        }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 1)
        {
            StartCoroutine(waitForAutoFlip2());
        }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 2)
        {
            StartCoroutine(waitForAutoFlip3());
        }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 3)
        {
            StartCoroutine(waitForAutoFlip4());
        }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 4)
        {
            StartCoroutine(waitForAutoFlip5());
        }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 5)
        {
            StartCoroutine(waitForAutoFlip6());
        }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 6)
        {
            StartCoroutine(waitForAutoFlip7());
        }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 7)
        {
            StartCoroutine(waitForAutoFlip8());
        }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 8)
        {
            StartCoroutine(waitForAutoFlip9());
        }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 9)
        {
            StartCoroutine(waitForAutoFlip10());
        }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 10)
        {
            StartCoroutine(waitForAutoFlip11());
        }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 11)
        {
            StartCoroutine(waitForAutoFlip12());
        }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 12)
        {
            StartCoroutine(waitForAutoFlip13());
        }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 13)
        {
            StartCoroutine(waitForAutoFlip14());
        }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 14)
        {
            StartCoroutine(waitForAutoFlip15());
        }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 15)
        {
            StartCoroutine(waitForAutoFlip16());
        }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 16)
        {
            StartCoroutine(waitForAutoFlip17());
        }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 17)
        {
            StartCoroutine(waitForAutoFlip18());
        }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 18)
        {
            StartCoroutine(waitForAutoFlip19());
        }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 19)
        {
            StartCoroutine(waitForAutoFlip20());
        }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 20)
        {
            StartCoroutine(waitForAutoFlip21());
        }

    }

    public GameObject brainPowerHover;
    public int brainPowerMax;
    public int maxBuyCount;
    public GameObject buyTextObject;
    public TextMeshProUGUI buyCountText;

    public void Update()
    {
        if (GlobalCoins.CoinCount < 0)
        {
            GlobalCoins.CoinCount = 0;
        }

        strongerHandsGetMoreCoins =  (1 + AscendScreen.coinMulitplier + EndlessInflation.endlessInflationBonus) * 1;
        greaterCoinsGetMoreCoins = (1 + AscendScreen.coinMulitplier + EndlessInflation.endlessInflationBonus) * 5;
        knowledgePlussAmount = (1 + AscendScreen.coinMulitplier + EndlessInflation.endlessInflationBonus) * 40;
        fistPlussAmount = (1 + AscendScreen.coinMulitplier + EndlessInflation.endlessInflationBonus) * 500;
        injectionPlussAmount = (1 + AscendScreen.coinMulitplier + EndlessInflation.endlessInflationBonus) * 10800;
        brainPowerPlussAmount = (1 + AscendScreen.coinMulitplier + EndlessInflation.endlessInflationBonus) * 235000;
        explosiveFlipsPlussAmount = (1 + AscendScreen.coinMulitplier + EndlessInflation.endlessInflationBonus) * 18000000;
        hydrationFlipsPlussAmount = (1 + AscendScreen.coinMulitplier + EndlessInflation.endlessInflationBonus) * 570000000;
        strangePotiongPlussAmount = (1 + AscendScreen.coinMulitplier + EndlessInflation.endlessInflationBonus) * 22500000000;
        masterFlipsPlussAmount = (1 + AscendScreen.coinMulitplier + EndlessInflation.endlessInflationBonus) * 400000000000;
        handShakePlussAmount = (1 + AscendScreen.coinMulitplier + EndlessInflation.endlessInflationBonus) * 13800000000000;
        upgrade12Pluss = (1 + AscendScreen.coinMulitplier + EndlessInflation.endlessInflationBonus) * 350000000000000;
        magicFlipsPluss = (1 + AscendScreen.coinMulitplier + EndlessInflation.endlessInflationBonus) * 1050000000000000000;
        treasureChestPluss = (1 + AscendScreen.coinMulitplier + EndlessInflation.endlessInflationBonus) * 65000000000000000000f;
        ritualPluss = (1 + AscendScreen.coinMulitplier + EndlessInflation.endlessInflationBonus) * 4500000000000000000000f;

        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 0) { AutoCoin.ascendedAuto1 = 0; }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 1) { AutoCoin2.ascendedAuto2 = 0; }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 2) { AutoCoin3.ascendedAuto3 = 0; }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 3) { AutoCoin4.ascendedAuto4 = 0; }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 4) { AutoCoin5.ascendedAuto5 = 0; }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 5) { AutoCoin6.ascendedAuto6 = 0; }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 6) { AutoCoin7.ascendedAuto7 = 0; }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 7) { AutoCoin8.ascendedAuto8 = 0; }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 8) { AutoCoin9.ascendedAuto9 = 0; }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 9) { AutoCoin10.ascendedAuto10 = 0; }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 10) { AutoCoin11.ascendedAuto11 = 0; }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 11) { AutoCoin12.ascendedAuto12 = 0; }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 12) { AutoCoin13.ascendedAuto13 = 0; }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 13) { AutoCoin14.ascendedAuto14 = 0; }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 14) { AutoCoin15.ascendedAuto15 = 0; }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 15) { AutoCoin16.ascendedAuto17 = 0; }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 16) { AutoCoin17.ascendedAuto16 = 0; }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 17) { AutoCoin18.ascendedAuto19 = 0; }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 18) { AutoCoin19.ascendedAuto18 = 0; }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 19) { AutoCoin20.ascendedAuto20 = 0; }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 20) { AutoCoin21.ascendedAuto21 = 0; }

        if(GlobalCoinMaker.coinsPerFlipUpgrades == 0)
        {
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
        }

    }

    IEnumerator waitForAutoFlip1()
    {
        float random = Random.Range(0.1f, 1.85f);
        flipper1.SetActive(false);
        yield return new WaitForSeconds(random);
        AutoCoin.ascendedAuto1 = 1;
    }
    IEnumerator waitForAutoFlip2()
    {
        float random = Random.Range(1f, 1.2f);
        flipper2.SetActive(false);
        yield return new WaitForSeconds(random);
        AutoCoin2.ascendedAuto2 = 1;
    }
    IEnumerator waitForAutoFlip3()
    {
        float random = Random.Range(0.1f, 1.85f);
        flipper3.SetActive(false);
        yield return new WaitForSeconds(random);
        AutoCoin3.ascendedAuto3 = 1;
    }
    IEnumerator waitForAutoFlip4()
    {
        float random = Random.Range(0.1f, 1.85f);
        flipper4.SetActive(false);
        yield return new WaitForSeconds(random);
        AutoCoin4.ascendedAuto4 = 1;
    }
    IEnumerator waitForAutoFlip5()
    {
        float random = Random.Range(0.1f, 1.8f);
        flipper5.SetActive(false);
        yield return new WaitForSeconds(random);
        AutoCoin5.ascendedAuto5 = 1;
    }
    IEnumerator waitForAutoFlip6()
    {
        float random = Random.Range(0.1f, 1.8f);
        flipper6.SetActive(false);
        yield return new WaitForSeconds(random);
        AutoCoin6.ascendedAuto6 = 1;
    }
    IEnumerator waitForAutoFlip7()
    {
        float random = Random.Range(0.1f, 1.8f);
        flipper7.SetActive(false);
        yield return new WaitForSeconds(random);
        AutoCoin7.ascendedAuto7 = 1;
    }
    IEnumerator waitForAutoFlip8()
    {
        float random = Random.Range(0.1f, 1.8f);
        flipper8.SetActive(false);
        yield return new WaitForSeconds(random);
        AutoCoin8.ascendedAuto8 = 1;
    }
    IEnumerator waitForAutoFlip9()
    {
        float random = Random.Range(0.1f, 1.8f);
        flipper9.SetActive(false);
        yield return new WaitForSeconds(random);
        AutoCoin9.ascendedAuto9 = 1;
    }
    IEnumerator waitForAutoFlip10()
    {
        float random = Random.Range(0.1f, 1.8f);
        flipper10.SetActive(false);
        yield return new WaitForSeconds(random);
        AutoCoin10.ascendedAuto10 = 1;
    }
    IEnumerator waitForAutoFlip11()
    {
        float random = Random.Range(0.1f, 1.8f);
        flipper11.SetActive(false);
        yield return new WaitForSeconds(random);
        AutoCoin11.ascendedAuto11 = 1;
    }
    IEnumerator waitForAutoFlip12()
    {
        float random = Random.Range(0.1f, 0.2f);
        flipper12.SetActive(false);
        yield return new WaitForSeconds(random);
        AutoCoin12.ascendedAuto12 = 1;
    }
    IEnumerator waitForAutoFlip13()
    {
        float random = Random.Range(0.5f, 1.5f);
        flipper13.SetActive(false);
        yield return new WaitForSeconds(random);
        AutoCoin13.ascendedAuto13 = 1;
    }
    IEnumerator waitForAutoFlip14()
    {
        float random = Random.Range(0.1f, 1.2f);
        flipper14.SetActive(false);
        yield return new WaitForSeconds(random);
        AutoCoin14.ascendedAuto14 = 1;
    }
    IEnumerator waitForAutoFlip15()
    {
        float random = Random.Range(0.1f, 1.1f);
        flipper15.SetActive(false);
        yield return new WaitForSeconds(random);
        AutoCoin15.ascendedAuto15 = 1;
    }
    IEnumerator waitForAutoFlip16()
    {
        float random = Random.Range(0.1f, 3.2f);
        flipper16.SetActive(false);
        yield return new WaitForSeconds(random);
        AutoCoin16.ascendedAuto17= 1;
    }
    IEnumerator waitForAutoFlip17()
    {
        float random = Random.Range(0.1f, 3.8f);
        flipper17.SetActive(false);
        yield return new WaitForSeconds(random);
        AutoCoin17.ascendedAuto16 = 1;
    }
    IEnumerator waitForAutoFlip18()
    {
        float random = Random.Range(0.1f, 3.6f);
        flipper18.SetActive(false);
        yield return new WaitForSeconds(random);
        AutoCoin18.ascendedAuto19 = 1;
    }
    IEnumerator waitForAutoFlip19()
    {
        float random = Random.Range(0.1f, 1.2f);
        flipper19.SetActive(false);
        yield return new WaitForSeconds(random);
        AutoCoin19.ascendedAuto18 = 1;
    }
    IEnumerator waitForAutoFlip20()
    {
        float random = Random.Range(0.1f, 1.4f);
        flipper20.SetActive(false);
        yield return new WaitForSeconds(random);
        AutoCoin20.ascendedAuto20 = 1;
    }
    IEnumerator waitForAutoFlip21()
    {
        float random = Random.Range(0.1f, 2.8f);
        flipper21.SetActive(false);
        yield return new WaitForSeconds(random);
        AutoCoin21.ascendedAuto21 = 1;
    }

    public MainButtonClick mainScript;

    public void StartAutoFlip()
    {
        if (GlobalCoins.CoinCount >= GlobalCoinMaker.coinValue)
        {
            UpgradeClickSound();
            GlobalCoinMaker.coinsPerFlipUpgrades += 1;
            mainScript.SetMuteFlipper();
            GlobalCoins.CoinCount -= GlobalCoinMaker.coinValue;
            GlobalCoinMaker.coinValue *=7.4f;
            GlobalCoinMaker.turnOffButton = true;
            if (GlobalCoinMaker.coinsPerFlipUpgrades > 0)
            {
                if(ManualClicking.isSwitchOff == 0) { AutoCoin.ascendedAuto1 = 1;  } 
                flipper1.SetActive(false);
            }
            if (GlobalCoinMaker.coinsPerFlipUpgrades > 1)
            {
                if (ManualClicking.isSwitchOff == 0) { AutoCoin2.ascendedAuto2 = 1; }
                flipper2.SetActive(false);
            }
            if (GlobalCoinMaker.coinsPerFlipUpgrades > 2)
            {
                if (ManualClicking.isSwitchOff == 0) { AutoCoin3.ascendedAuto3= 1; } 
                flipper3.SetActive(false);
            }
            if (GlobalCoinMaker.coinsPerFlipUpgrades > 3)
            {
                if (ManualClicking.isSwitchOff == 0) { AutoCoin4.ascendedAuto4 = 1; } 
                flipper4.SetActive(false);
            }
            if (GlobalCoinMaker.coinsPerFlipUpgrades > 4)
            {
                if (ManualClicking.isSwitchOff == 0) { AutoCoin5.ascendedAuto5 = 1; }
                flipper5.SetActive(false);
            }
            if (GlobalCoinMaker.coinsPerFlipUpgrades > 5)
            {
                if (ManualClicking.isSwitchOff == 0) { AutoCoin6.ascendedAuto6 = 1; }
                flipper6.SetActive(false);
            }
            if (GlobalCoinMaker.coinsPerFlipUpgrades > 6)
            {
                if (ManualClicking.isSwitchOff == 0) { AutoCoin7.ascendedAuto7 = 1; }
                flipper7.SetActive(false);
            }
            if (GlobalCoinMaker.coinsPerFlipUpgrades > 7)
            {
                if (ManualClicking.isSwitchOff == 0) { AutoCoin8.ascendedAuto8 = 1; }
                flipper8.SetActive(false);
            }
            if (GlobalCoinMaker.coinsPerFlipUpgrades > 8)
            {
                if (ManualClicking.isSwitchOff == 0) { AutoCoin9.ascendedAuto9 = 1; }
                flipper9.SetActive(false);
            }
            if (GlobalCoinMaker.coinsPerFlipUpgrades > 9)
            {
                if (ManualClicking.isSwitchOff == 0) { AutoCoin10.ascendedAuto10 = 1; }
                flipper10.SetActive(false);
            }
            if (GlobalCoinMaker.coinsPerFlipUpgrades > 10)
            {
                if (ManualClicking.isSwitchOff == 0) { AutoCoin11.ascendedAuto11 = 1; }
                flipper11.SetActive(false);
            }
            if (GlobalCoinMaker.coinsPerFlipUpgrades > 11)
            {
                if (ManualClicking.isSwitchOff == 0) { AutoCoin12.ascendedAuto12 = 1; }
                flipper12.SetActive(false);
            }
            if (GlobalCoinMaker.coinsPerFlipUpgrades > 12)
            {
                if (ManualClicking.isSwitchOff == 0) { AutoCoin13.ascendedAuto13 = 1; }
                flipper13.SetActive(false);
            }
            if (GlobalCoinMaker.coinsPerFlipUpgrades > 13)
            {
                if (ManualClicking.isSwitchOff == 0) { AutoCoin14.ascendedAuto14 = 1; }
                flipper14.SetActive(false);
            }
            if (GlobalCoinMaker.coinsPerFlipUpgrades > 14)
            {
                if (ManualClicking.isSwitchOff == 0) { AutoCoin15.ascendedAuto15 = 1; }
                flipper15.SetActive(false);
            }
            if (GlobalCoinMaker.coinsPerFlipUpgrades > 15)
            {
                if (ManualClicking.isSwitchOff == 0) { AutoCoin16.ascendedAuto17 = 1; }
                flipper16.SetActive(false);
            }
            if (GlobalCoinMaker.coinsPerFlipUpgrades > 16)
            {
                if (ManualClicking.isSwitchOff == 0) { AutoCoin17.ascendedAuto16 = 1; }
                flipper17.SetActive(false);
            }
            if (GlobalCoinMaker.coinsPerFlipUpgrades > 17)
            {
                if (ManualClicking.isSwitchOff == 0) { AutoCoin18.ascendedAuto19 = 1; }
                flipper18.SetActive(false);
            }
            if (GlobalCoinMaker.coinsPerFlipUpgrades > 18)
            {
                if (ManualClicking.isSwitchOff == 0) { AutoCoin19.ascendedAuto18 = 1; }
                flipper19.SetActive(false);
            }
            if (GlobalCoinMaker.coinsPerFlipUpgrades > 19)
            {
                if (ManualClicking.isSwitchOff == 0) { AutoCoin20.ascendedAuto20 = 1; }
                flipper20.SetActive(false);
            }
            if (GlobalCoinMaker.coinsPerFlipUpgrades > 20)
            {
                if (ManualClicking.isSwitchOff == 0) { AutoCoin21.ascendedAuto21 = 1; }
                flipper21.SetActive(false);
            }
        }
    }


    public TextMeshProUGUI strongerHandsText;

    public static float strongerHandsGetMoreCoins = 1;
    public static float strongerHandsTextInfo;

    public void MoreCoinsPerClickButton()
    {
        if (GlobalCoins.CoinCount >= MoreCoinsButton.moreCoinClickValue)
        {
            MoreCoinsPerClick.SetActive(true);
            UpgradeClickSound();

            GlobalCoins.CoinCount -= MoreCoinsButton.moreCoinClickValue;
            MoreCoinsButton.moreCoinClickValue += MoreCoinsButton.moreCoinClickValue / 4;

            MoreCoinsButton.moreCoinsUpgrades += 1;
            MainButtonClick.coinsPerClick += strongerHandsGetMoreCoins;
            MoreCoinsButton.turnOffMoreCoinClickValueButton = true;
            strongerHandsTextInfo += strongerHandsGetMoreCoins;

            strongerHandsText.text = LocalizationStrings.your + MoreCoinsButton.moreCoinsUpgrades + LocalizationStrings.statsStrongerArm + FormatCoins(PurchaseLog.strongerHandsTextInfo) + LocalizationStrings.coins;

            strongerHandsCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + MoreCoinsButton.moreCoinsUpgrades;
        }
    }

    public TextMeshProUGUI greaterCoinsText;
    public static float greaterCoinsGetMoreCoins = 5;
    public static float greaterTextInfo;

    public void GreaterCoinUpgrade()
    {

        if (GlobalCoins.CoinCount >= MoreCoinsButton.greaterCoinsCost && MoreCoinsButton.moreCoinsUpgrades > 0)
        {
            greaterCoinsUpgrade.SetActive(true);
            UpgradeClickSound();
            GlobalCoins.CoinCount -= MoreCoinsButton.greaterCoinsCost;
            MoreCoinsButton.greaterCoinsCost += MoreCoinsButton.greaterCoinsCost /4;
            MainButtonClick.coinsPerClick += greaterCoinsGetMoreCoins;
            MoreCoinsButton.turnOffGraterCoinsUpgrade = true;
            MoreCoinsButton.greaterCoinsCount += 1;
            greaterTextInfo += greaterCoinsGetMoreCoins;

            greaterCoinsCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + MoreCoinsButton.greaterCoinsCount;

            greaterCoinsText.text = LocalizationStrings.your + MoreCoinsButton.greaterCoinsCount + LocalizationStrings.statsGreater + FormatCoins(PurchaseLog.greaterTextInfo) + LocalizationStrings.coins;

        }

    }

    public TextMeshProUGUI knowledgeText;
    public GameObject knowledgeUpgradeButton;
    public static float knowledgePlussAmount = 40;
    public static float knowledgeInfo;

    public void KnowledgeUpgradeButton()
    {

        if (GlobalCoins.CoinCount >= KnowledgeUpgrade.knowledgeClickValue)
        {
            knowledgeUpgradeButton.SetActive(true);
            UpgradeClickSound();
            GlobalCoins.CoinCount -= KnowledgeUpgrade.knowledgeClickValue;
            KnowledgeUpgrade.knowledgeClickValue += KnowledgeUpgrade.knowledgeClickValue / 4;
            MainButtonClick.coinsPerClick += knowledgePlussAmount;
            KnowledgeUpgrade.turnOffKnowledgeButton = true;
            KnowledgeUpgrade.knowledgeUpgradeCount += 1;
            knowledgeInfo += knowledgePlussAmount;

            knowledgeText.text = LocalizationStrings.your + KnowledgeUpgrade.knowledgeUpgradeCount + LocalizationStrings.statsKnowledge + FormatCoins(PurchaseLog.knowledgeInfo) + LocalizationStrings.coins;

            knowledgeCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + KnowledgeUpgrade.knowledgeUpgradeCount;
        }

    }

    public TextMeshProUGUI strongerFistText;
    public GameObject fistUpgradeButton;
    public static float fistPlussAmount;
    public static float fistInfo;

    public void fistButton()
    {

        if (GlobalCoins.CoinCount >= StrongerFist.fistCost)
        {
            fistUpgradeButton.SetActive(true);
            UpgradeClickSound();
            GlobalCoins.CoinCount -= StrongerFist.fistCost;
            StrongerFist.fistCost += StrongerFist.fistCost / 4;
            MainButtonClick.coinsPerClick += fistPlussAmount;
            StrongerFist.turnOffFistButton = true;
            StrongerFist.fistUpgradeCount += 1;
            fistInfo += fistPlussAmount;

            strongerFistText.text = LocalizationStrings.your + StrongerFist.fistUpgradeCount + LocalizationStrings.statsFist + FormatCoins(PurchaseLog.fistInfo) + LocalizationStrings.coins;

            strongerFistCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + StrongerFist.fistUpgradeCount;
        }

    }

    public TextMeshProUGUI handInjectionText;
    public GameObject injectionButton;
    public static float injectionPlussAmount = 10800;
    public static float injectionInfo;

    public void injectionButtonUpgrade()
    {

        if (GlobalCoins.CoinCount >= HandInecjtion.injectionCost)
        {
            injectionButton.SetActive(true);
            UpgradeClickSound();
            GlobalCoins.CoinCount -= HandInecjtion.injectionCost;
            HandInecjtion.injectionCost += HandInecjtion.injectionCost / 4;
            MainButtonClick.coinsPerClick += injectionPlussAmount;
            HandInecjtion.turnOffInjectionButton = true;
            HandInecjtion.injectionUpgradeCount += 1;
            injectionInfo += injectionPlussAmount;

            handInjectionText.text = LocalizationStrings.your + HandInecjtion.injectionUpgradeCount + LocalizationStrings.statsInjection + FormatCoins(PurchaseLog.injectionInfo) + LocalizationStrings.coins;

            handInjectionCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + HandInecjtion.injectionUpgradeCount;
        }

    }

    public TextMeshProUGUI brainPowerText;
    public GameObject brainPower;
    public static float brainPowerPlussAmount = 235000;
    public static float brainPowerInfo;

    public void BrainPowerUpgrade()
    {
        UpgradeClickSound();

        if (Input.GetKey(KeyCode.LeftControl))
        {
            if (GlobalCoins.CoinCount >= BrainPower.brainPowerCost * Mathf.Pow(1 + 0.25f, 5) - BrainPower.brainPowerCost)
            {
               /* GlobalCoins.CoinCount -= BrainPower.brainPowerCost * Mathf.Pow(1 + 0.25f, 5) - BrainPower.brainPowerCost;
                BrainPower.brainPowerCost += BrainPower.brainPowerCost * Mathf.Pow(1 + 0.25f, 5) - BrainPower.brainPowerCost;
                BrainPower.brainPowerUpgradeCount += 5;
                brainPowerInfo += (brainPowerPlussAmount * 5);
                MainButtonClick.coinsPerClick += (brainPowerPlussAmount * 5);*/
            }
        }
        else
        {
            if (GlobalCoins.CoinCount >= BrainPower.brainPowerCost)
            {
                GlobalCoins.CoinCount -= BrainPower.brainPowerCost;
                BrainPower.brainPowerCost += BrainPower.brainPowerCost / 4;
                MainButtonClick.coinsPerClick += brainPowerPlussAmount;
                BrainPower.turnOffBrainPowerButton = true;
                BrainPower.brainPowerUpgradeCount += 1;
                brainPowerInfo += brainPowerPlussAmount;
            }
        }

        brainPowerText.text = LocalizationStrings.your + BrainPower.brainPowerUpgradeCount + LocalizationStrings.statsBrain + FormatCoins(PurchaseLog.brainPowerInfo) + LocalizationStrings.coins;

        brainPowerCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + BrainPower.brainPowerUpgradeCount;

    }

    public TextMeshProUGUI explosiveText;
    public GameObject explosiveFlips;
    public static float explosiveFlipsPlussAmount = 18000000;
    public static float explosiveInfo;

    public void ExplosiveUpgrade()
    {

        if (GlobalCoins.CoinCount >= ExplosiveFlips.explosiveCost)
        {
            explosiveFlips.SetActive(true);
            UpgradeClickSound();
            GlobalCoins.CoinCount -= ExplosiveFlips.explosiveCost;
            ExplosiveFlips.explosiveCost += ExplosiveFlips.explosiveCost / 4;
            MainButtonClick.coinsPerClick += explosiveFlipsPlussAmount;
            ExplosiveFlips.turnOffExplosiveButton= true;
            ExplosiveFlips.explosiveUpgradeCount += 1;
            explosiveInfo += explosiveFlipsPlussAmount;

            explosiveText.text = LocalizationStrings.your + ExplosiveFlips.explosiveUpgradeCount + LocalizationStrings.statsExplosive + FormatCoins(PurchaseLog.explosiveInfo) + LocalizationStrings.coins;

            explosiveFlipsCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + ExplosiveFlips.explosiveUpgradeCount;
        }

    }

    public TextMeshProUGUI hydrationText;
    public GameObject hydration;
    public static float hydrationFlipsPlussAmount = 570000000;
    public static float hydrationInfo;

    public void HydrationUpgrade()
    {

        if (GlobalCoins.CoinCount >= HydrationButton.hydrationVost)
        {
            explosiveFlips.SetActive(true);
            UpgradeClickSound();
            GlobalCoins.CoinCount -= HydrationButton.hydrationVost;
            HydrationButton.hydrationVost += HydrationButton.hydrationVost / 4;
            MainButtonClick.coinsPerClick += hydrationFlipsPlussAmount;
            HydrationButton.turnOffHydrationButton = true;
            HydrationButton.hydrationUpgradeCount += 1;
            hydrationInfo += hydrationFlipsPlussAmount;

            hydrationText.text = LocalizationStrings.your + HydrationButton.hydrationUpgradeCount + LocalizationStrings.statsHydration + FormatCoins(PurchaseLog.hydrationInfo) + LocalizationStrings.coins;

            hydrationCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + HydrationButton.hydrationUpgradeCount;
        }

    }

    public TextMeshProUGUI potionText;
    public GameObject strangePotion;
    public static float strangePotiongPlussAmount = 22500000000;
    public static float potionInfo;

    public void PotionUpgrade()
    {

        if (GlobalCoins.CoinCount >= StrangePotion.potionCost)
        {
            explosiveFlips.SetActive(true);
            UpgradeClickSound();
            GlobalCoins.CoinCount -= StrangePotion.potionCost;
            StrangePotion.potionCost += StrangePotion.potionCost / 4;
            MainButtonClick.coinsPerClick += strangePotiongPlussAmount;
            StrangePotion.turnOffPotionButton = true;
            StrangePotion.potionUpgradeCount += 1;
            potionInfo += strangePotiongPlussAmount;

            potionText.text = LocalizationStrings.your + StrangePotion.potionUpgradeCount + LocalizationStrings.statsPorion + FormatCoins(PurchaseLog.potionInfo) + LocalizationStrings.coins;

            
            potionCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + StrangePotion.potionUpgradeCount;
        }

    }

    public TextMeshProUGUI masterFlipperText;
    public GameObject masterFlips;
    public static float masterFlipsPlussAmount = 400000000000;
    public static float masterFlipperInfo;

    public void MasterFlipsUpgrade()
    {

        if (GlobalCoins.CoinCount >= MasterFlipper.MasterFlipsCost)
        {
            masterFlips.SetActive(true);
            UpgradeClickSound();
            GlobalCoins.CoinCount -= MasterFlipper.MasterFlipsCost;
            MasterFlipper.MasterFlipsCost += MasterFlipper.MasterFlipsCost / 4;
            MainButtonClick.coinsPerClick += masterFlipsPlussAmount;
            MasterFlipper.turnOffMasterFlipsButton = true;
            MasterFlipper.MasterFlipsUpgradeCount += 1;
            masterFlipperInfo += masterFlipsPlussAmount;

            masterFlipperText.text = LocalizationStrings.your + MasterFlipper.MasterFlipsUpgradeCount + LocalizationStrings.statsMaster + FormatCoins(PurchaseLog.masterFlipperInfo) + LocalizationStrings.coins;

            masterFlipperCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + MasterFlipper.MasterFlipsUpgradeCount;

        }

    }

    public TextMeshProUGUI handShakeText;
    public GameObject handSake;
    public static float handShakePlussAmount = 13800000000000;
    public static float handShakeInfo;

    public void HandShakeUpgrade()
    {

        if (GlobalCoins.CoinCount >= HandShake.handshakeCost)
        {
            handSake.SetActive(true);
            UpgradeClickSound();
            GlobalCoins.CoinCount -= HandShake.handshakeCost;
            HandShake.handshakeCost += HandShake.handshakeCost / 4;
            MainButtonClick.coinsPerClick += handShakePlussAmount;
            HandShake.turnOffHandsShakeButton = true;
            HandShake.handShakeUpgradeCount += 1;
            handShakeInfo += handShakePlussAmount;

            handShakeText.text = LocalizationStrings.your + HandShake.handShakeUpgradeCount + LocalizationStrings.statsHandshake + FormatCoins(PurchaseLog.handShakeInfo) + LocalizationStrings.coins;

            handShakeCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + HandShake.handShakeUpgradeCount;
        }

    }

    public TextMeshProUGUI upgrade12Text;
    public GameObject upgrade12;
    public static float upgrade12Pluss = 350000000000000;
    public static float upgrade12Info;

    public void Upgrade12Button()
    {

        if (GlobalCoins.CoinCount >= Upgrade12.upgrade12Cost)
        {
            upgrade12.SetActive(true);
            UpgradeClickSound();
            GlobalCoins.CoinCount -= Upgrade12.upgrade12Cost;
            Upgrade12.upgrade12Cost += Upgrade12.upgrade12Cost / 4;
            MainButtonClick.coinsPerClick += upgrade12Pluss;
            Upgrade12.turnOffUpgrade12 = true;
            Upgrade12.upgrade12Count += 1;
            upgrade12Info += upgrade12Pluss;

            upgrade12Text.text = LocalizationStrings.your + Upgrade12.upgrade12Count + LocalizationStrings.statsHighFive + FormatCoins(PurchaseLog.upgrade12Info) + LocalizationStrings.coins;

            highFiveCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + Upgrade12.upgrade12Count;
        }

    }


    public GameObject magicFlips;
    public static float magicFlipsPluss = 35000000000000000;
    public static float magicFlipsInfo;
    public TextMeshProUGUI magicInfo;

    public void MagicFlips()
    {
        UpgradeClickSound();
        magicFlips.SetActive(true);
        GlobalCoins.CoinCount -= MagicFlipsUpgrade.magicUpgradeCost;
        MagicFlipsUpgrade.magicUpgradeCost += MagicFlipsUpgrade.magicUpgradeCost / 4;
        MainButtonClick.coinsPerClick += magicFlipsPluss;
        MagicFlipsUpgrade.turnoffMagicUpgrade = true;
        MagicFlipsUpgrade.magicUpgradeCount += 1;
        magicFlipsInfo += magicFlipsPluss;

        magicInfo.text = LocalizationStrings.your + MagicFlipsUpgrade.magicUpgradeCount + LocalizationStrings.statsMagic + FormatCoins(PurchaseLog.magicFlipsInfo) + LocalizationStrings.coins;

        wizardCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + MagicFlipsUpgrade.magicUpgradeCount;
    }

    public GameObject treasureChest;
    public static float treasureChestPluss = 95000000000000000000f;
    public static float treasureInfo;
    public TextMeshProUGUI treasureInfoText;

    public void TreasureChestButton()
    {
        UpgradeClickSound();
        treasureChest.SetActive(true);
        GlobalCoins.CoinCount -= TreasureChest.treasureCost;
        TreasureChest.treasureCost += TreasureChest.treasureCost / 4;
        MainButtonClick.coinsPerClick += treasureChestPluss;
        TreasureChest.turnOffTreasure = true;
        TreasureChest.treasureCount += 1;
        treasureInfo += treasureChestPluss;

        treasureInfoText.text = LocalizationStrings.your + TreasureChest.treasureCount + LocalizationStrings.statsTreasure + FormatCoins(PurchaseLog.treasureInfo) + LocalizationStrings.coins;

        treasureCountText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + TreasureChest.treasureCount;
    }

    public GameObject ritual;
    public static float ritualPluss = 17500000000000000000000f;
    public static float ritualInfo;
    public TextMeshProUGUI ritualInfoText;

    public void RitualButton()
    {
        UpgradeClickSound();
        ritual.SetActive(true);
        GlobalCoins.CoinCount -= RitualUpgrade.ritualCost;
        RitualUpgrade.ritualCost += RitualUpgrade.ritualCost / 4;
        MainButtonClick.coinsPerClick += ritualPluss;
        RitualUpgrade.turnOffritual = true;
        RitualUpgrade.treasureCount += 1;
        ritualInfo += ritualPluss;

        ritualInfoText.text = LocalizationStrings.your + RitualUpgrade.treasureCount + LocalizationStrings.statsRitual + FormatCoins(PurchaseLog.ritualInfo) + LocalizationStrings.coins;

       
        ritualCountText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + RitualUpgrade.treasureCount;
    }


    public static int higherChanceUpgradeCount = 0;
    public void higherCoinFlipChance()
    {
        HigherChanceForCoin.SetActive(true);
        UpgradeClickSound();

        if(EnterText.choseHeads == 1)
        {
            higherChanceHoverover.headsPercent += 1;
            higherChanceHoverover.tailsPercent -= 1;
        }
        if (EnterText.choseTails == 1)
        {
            higherChanceHoverover.headsPercent -= 1;
            higherChanceHoverover.tailsPercent += 1;
        }

        if (GlobalCoins.CoinCount >= HigherChance.higherChanceValue)
        {
            higherChanceUpgradeCount += 1;
            GlobalCoins.CoinCount -= HigherChance.higherChanceValue;
            HigherChance.higherChanceValue *= 2.2f;
            MainButtonClick.higherCoinChance -= 2;
            MainButtonClick.lowerCoinChance -= 2;

        }
        headChance.GetComponent<TextMeshProUGUI>().text = higherChanceHoverover.headsPercent + LocalizationStrings.higherChanceHeads;
        tailsChance.GetComponent<TextMeshProUGUI>().text = higherChanceHoverover.tailsPercent + LocalizationStrings.higherChanceTails;
   
    }
    public TextMeshProUGUI luckyChance;
    public TextMeshProUGUI headChance;
    public TextMeshProUGUI tailsChance;

    public static int luckyCoinHigherChanceCount = 0;
    public void LuckyCoinHigherChance()
    {
        UpgradeClickSound();
        GetLuckyHoverOver.luckyChance += 0.5f;
        if (EnterText.choseHeads == 1)
        {
            higherChanceHoverover.tailsPercent -= 0.5f;
        }
        if (EnterText.choseTails == 1)
        {
            higherChanceHoverover.headsPercent -= 0.5f;
        }
        luckyCoinHigherChanceCount += 1;
        GlobalCoins.CoinCount -= LuckyCoinChance.luckyCoinValue;
        if(Challenges.completedChallenge4 == 0)
        {
            LuckyCoinChance.luckyCoinValue *= 19.5f;
        }
        if (Challenges.completedChallenge4 == 1)
        {
            LuckyCoinChance.luckyCoinValue *= 3.9f;
        }
        MainButtonClick.lowSpecialChance += 1;
        
        luckyChance.GetComponent<TextMeshProUGUI>().text = GetLuckyHoverOver.luckyChance + LocalizationStrings.luckyCoinChance;


    }

    public static int gambleChances = 5;
    public TextMeshProUGUI plussOrMinusAllCoinsText;
    public GameObject gambleResultText;
    public static int gambleChanceEachTimeWIN = 50;
    public static int gambleChanceEachTimeLOOSE = 50;
    public TextMeshProUGUI gamblePositiveText;
    public TextMeshProUGUI gambleNegativeText;
    public static int isGambleBoughtOnce = 0;

    public static int amountOfTimesGambled;
    public static int amountOfTimesGambledWON;
    public static int amountOfTimesGambledLOST;
    public TextMeshProUGUI gambleTimesAmountText;
    public TextMeshProUGUI gambleTimesAmountWONText;
    public TextMeshProUGUI gambleTimesAmountLOSTText;

   

    public void GambleUpgrade()
    {
        amountOfTimesGambled += 1;
        gambleTimesAmountText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.youGambled + (amountOfTimesGambled) + LocalizationStrings.times;
        isGambleBoughtOnce = 1;
        gambleChances -= 1;
        int random = Random.Range(1, 101);
        if (AscendScreen.isGamblerPurchased == 1) { gambleChanceEachTimeWIN += 1; gambleChanceEachTimeLOOSE -= 1;}

        if (random <= gambleChanceEachTimeWIN)
        {
            UpgradeClickSound();
            amountOfTimesGambledWON += 1;
            gambleTimesAmountWONText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.wonGambling + (0 + amountOfTimesGambledWON) + LocalizationStrings.times;
            gambleResultText.SetActive(true);
            plussOrMinusAllCoinsText.color = Color.green;

            plussOrMinusAllCoinsText.text = "+" + FormatCoinsGamble(GlobalCoins.CoinCount);

          
            GlobalCoins.CoinCount *= 2;
            gamblePositiveText.GetComponent<TextMeshProUGUI>().text = gambleChanceEachTimeWIN + LocalizationStrings.gambleWinChance;
            gambleNegativeText.GetComponent<TextMeshProUGUI>().text = gambleChanceEachTimeLOOSE + LocalizationStrings.gambleLoseChance;
            StartCoroutine(SetGableTextFalse());
        }
        if(random > gambleChanceEachTimeWIN)
        {
            UpgradeClickSound();
            amountOfTimesGambledLOST += 1;
            gambleTimesAmountLOSTText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.lostGambling + (0+ amountOfTimesGambledLOST) + LocalizationStrings.times;
            gambleResultText.SetActive(true);
            plussOrMinusAllCoinsText.color = Color.red;

            plussOrMinusAllCoinsText.text = "-" + FormatCoinsGamble(GlobalCoins.CoinCount);

            GlobalCoins.CoinCount -= GlobalCoins.CoinCount;

            gamblePositiveText.GetComponent<TextMeshProUGUI>().text = gambleChanceEachTimeWIN + LocalizationStrings.gambleWinChance;
            gambleNegativeText.GetComponent<TextMeshProUGUI>().text = gambleChanceEachTimeLOOSE + LocalizationStrings.gambleLoseChance;

            StartCoroutine(SetGableTextFalse());
        }
    }

    public GameObject pileOfCoins1;
    public GameObject pileOfCoins2;
    public GameObject pileOfCoins3;
    public GameObject pileOfCoins4;

    IEnumerator SetGableTextFalse()
    {
        yield return new WaitForSeconds(1.3f);
        gambleResultText.SetActive(false);
    }

    public static int pileOfCoinsCount;
    public TextMeshProUGUI pileWaitTimeText;
    public TextMeshProUGUI pileCount;


    #region Pile of coins
    public PileOfCoinsMechanics pileOfCoinsScript;

    public void PileOfCoinsButton()
    {
        pileOfCoinsCount += 1;
        pileCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + pileOfCoinsCount;
        PileOfCoinsMechanics.isPile1Unlocked = 1;
        GlobalCoins.CoinCount -= PileOfCoins.pileOfCoinsCost;
        PileOfCoins.pileOfCoinsCost *= 2;
        PileOfCoins.turnOfPileOfCoins = true;
        PileOfCoinsMechanics.waitTime -= 1;

        pileWaitTimeText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.pileGeneratesEveyXSecond + PileOfCoinsMechanics.waitTime + LocalizationStrings.seconds;

        if (PileOfCoinsMechanics.PileOfCounsBoughtFirstTime == 0)
        {
            PileOfCoinsMechanics.PileOfCoinsAmount1 = 0;
            PileOfCoinsMechanics.PileOfCoinsAmount2 = 0;
            PileOfCoinsMechanics.PileOfCoinsAmount3 = 0;
            PileOfCoinsMechanics.PileOfCoinsAmount4 = 0;
            PileOfCoinsMechanics.PileOfCoinsAmount5 = 0;
            PileOfCoinsMechanics.currentTime = PileOfCoinsMechanics.waitTime;
            PileOfCoinsMechanics.currentTime2 = PileOfCoinsMechanics.waitTime;
            PileOfCoinsMechanics.currentTime3 = PileOfCoinsMechanics.waitTime;
            PileOfCoinsMechanics.currentTime4 = PileOfCoinsMechanics.waitTime;
            PileOfCoinsMechanics.currentTime5 = PileOfCoinsMechanics.waitTime;
        }
       
        PileOfCoinsMechanics.PileOfCounsBoughtFirstTime = 1;

        pileOfCoinsScript.SetPileOfCoins();
        UpgradeClickSound();
    }
    #endregion

    public void UpgradeClickSound()
    {
        generateRandomUpgradeSound = Random.Range(1, 3);
        if (generateRandomUpgradeSound == 1)
        {
            UpgradeSound1.Play();
        }
        else if (generateRandomUpgradeSound == 2)
        {
            UpgradeSound2.Play();
        }
    }

}
