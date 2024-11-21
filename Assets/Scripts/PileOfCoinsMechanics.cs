using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PileOfCoinsMechanics : MonoBehaviour
{
    public static int isPile1Unlocked = 0;
    public static int isPile2Unlocked = 0;
    public static int isPile3Unlocked = 0;
    public static int isPile4Unlocked = 0;
    public static int isPile5Unlocked = 0;
    public static bool waitTimeOver1 = false;
    public static bool waitTimeOver2 = false;
    public static bool waitTimeOver3 = false;
    public static bool waitTimeOver4 = false;
    public static bool waitTimeOver5 = false;
    public GameObject PileOfCoins1;
    public static int waitTime;
    public static int PileOfCounsBoughtFirstTime = 0;

    public TextMeshProUGUI PileOfCoinsAmountText1;
    public TextMeshProUGUI PileOfCoinsAmountText2;
    public TextMeshProUGUI PileOfCoinsAmountText3;
    public TextMeshProUGUI PileOfCoinsAmountText4;
    public TextMeshProUGUI PileOfCoinsAmountText5;

    public static int incrementPileOfCoinsAmount;
    public static float PileOfCoinsAmount1;
    public static float PileOfCoinsAmount2;
    public static float PileOfCoinsAmount3;
    public static float PileOfCoinsAmount4;
    public static float PileOfCoinsAmount5;

    public GameObject pileOfCoin1;
    public GameObject pileOfCoin2;
    public GameObject pileOfCoin3;
    public GameObject pileOfCoin4;
    public GameObject pileOfCoin5;

    public GameObject pile1IsEmpty;
    public GameObject pile2IsEmpty;
    public GameObject pile3IsEmpty;
    public GameObject pile4IsEmpty;
    public GameObject pile5IsEmpty;

    public GameObject blockPile1;
    public GameObject blockPile2;
    public GameObject blockPile3;
    public GameObject blockPile4;
    public GameObject blockPile5;

    public TextMeshProUGUI totalPileamountText;
    public static float totalAmountOfPileGenerated;
    public TextMeshProUGUI amountOfTimesClickedOnPile;
    public int pileNotLostChance = 7;

    public AudioSource pileClick;
    public AudioClip pileClickSound;

    public TextMeshProUGUI pileBagStatsText;

    public static string FormatCoins(float coins)
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
    public static string FormatCoins2(float coins)
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


    public void StopCorutines()
    {
        StopAllCoroutines();
    }

    public void PlayAudio()
    {
        pileClick.PlayOneShot(pileClickSound);
    }

    public void Start()
    {
        if(AscendScreen.boughtPileBag == 0)
        {
            pileBagStatsText.text = LocalizationStrings.inflatePileOfBagsStats + "0" + LocalizationStrings.moreCoinsAfterInflating;
        }
        if (AscendScreen.boughtPileBag == 1)
        {
            pileBagStatsText.text = LocalizationStrings.inflatePileOfBagsStats + PileBagAmount + LocalizationStrings.moreCoinsAfterInflating;
        }
        currentTime = waitTime;
        currentTime2 = waitTime;
        currentTime3 = waitTime;
        currentTime4 = waitTime;
        currentTime5 = waitTime;

        if (incrementPileOfCoinsAmount == 0)
        {
            amountOfTimesClickedOnPile.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.clickedPile + "0" + LocalizationStrings.times;
        }
        if(incrementPileOfCoinsAmount > 0)
        {
            amountOfTimesClickedOnPile.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.clickedPile + incrementPileOfCoinsAmount + LocalizationStrings.times;

        }

        StartCoroutine(isPilesZero());

        PileOfCoinsAmountText1.text = FormatCoins(PileOfCoinsAmount1);

        PileOfCoinsAmountText2.text = FormatCoins(PileOfCoinsAmount2);

        PileOfCoinsAmountText3.text = FormatCoins(PileOfCoinsAmount3);

        PileOfCoinsAmountText4.text = FormatCoins(PileOfCoinsAmount4);

        PileOfCoinsAmountText5.text = FormatCoins(PileOfCoinsAmount5);
    }

    IEnumerator isPilesZero()
    {
        yield return new WaitForSeconds(0.1f);

        if (PileOfCoinsAmount1 == 0) { PileOfCoinsAmountText1.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.coins; }
        if (PileOfCoinsAmount2 == 0) { PileOfCoinsAmountText2.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.coins; }
        if (PileOfCoinsAmount3 == 0) { PileOfCoinsAmountText3.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.coins; }
        if (PileOfCoinsAmount4 == 0) { PileOfCoinsAmountText4.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.coins; }
        if (PileOfCoinsAmount5 == 0) { PileOfCoinsAmountText5.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.coins; }
        SetPileOfCoins();
    }

    public static float currentTime;
    public  TextMeshProUGUI timerText;
    public static float currentTime2;
    public TextMeshProUGUI timerText2;
    public static float currentTime3;
    public TextMeshProUGUI timerText3;
    public static float currentTime4;
    public TextMeshProUGUI timerText4;
    public static float currentTime5;
    public TextMeshProUGUI timerText5;

    public void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        timerText.text = currentTime.ToString(LocalizationStrings.moreCoinsIn + "0" + LocalizationStrings.Xseconds);

        currentTime2 -= 1 * Time.deltaTime;
        timerText2.text = currentTime2.ToString(LocalizationStrings.moreCoinsIn + "0" + LocalizationStrings.Xseconds);

        currentTime3 -= 1 * Time.deltaTime;
        timerText3.text = currentTime3.ToString(LocalizationStrings.moreCoinsIn + "0" + LocalizationStrings.Xseconds);

        currentTime4 -= 1 * Time.deltaTime;
        timerText4.text = currentTime4.ToString(LocalizationStrings.moreCoinsIn + "0" + LocalizationStrings.Xseconds);

        currentTime5 -= 1 * Time.deltaTime;
        timerText5.text = currentTime5.ToString(LocalizationStrings.moreCoinsIn + "0" + LocalizationStrings.Xseconds);

        if (totalAmountOfPileGenerated == 0)
        {
            if (LocalizationStrings.ChooseText == 1 || LocalizationStrings.ChooseText == 2 || LocalizationStrings.ChooseText == 3)
            {
                totalPileamountText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.pileTotalGenerated + "0" + LocalizationStrings.coins;
            }
            if (LocalizationStrings.ChooseText == 4)
            {
                totalPileamountText.GetComponent<TextMeshProUGUI>().text = "코인 더미가 총" + "0" + "개의 코인을 만들어냈습니다";
            }
            if (LocalizationStrings.ChooseText == 5)
            {
                totalPileamountText.GetComponent<TextMeshProUGUI>().text = "コインの山は4" + "0" + "コインの合計を生成しています";
            }
        }
        else
        {
            if(LocalizationStrings.ChooseText == 1 || LocalizationStrings.ChooseText == 2 || LocalizationStrings.ChooseText == 3)
            {
                totalPileamountText.text = LocalizationStrings.pileTotalGenerated + FormatCoins(totalAmountOfPileGenerated);
            }
            if (LocalizationStrings.ChooseText == 4)
            {
                totalPileamountText.text = "코인 더미가 총" + FormatCoins(totalAmountOfPileGenerated) + "개의 코인을 만들어냈습니다";
            }
            if (LocalizationStrings.ChooseText == 5)
            {
                totalPileamountText.text = "コインの山は4" + FormatCoins(totalAmountOfPileGenerated) + "コインの合計を生成しています";
            }
        }

        if (isPile1Unlocked == 1)
        {
            if (waitTimeOver1 == false && isPile1Unlocked == 1 && PileOfCounsBoughtFirstTime == 1)
            {
                waitTimeOver1 = true;
                StartCoroutine(waitForBundleOfCoins());
            }
            if (waitTimeOver2 == false && isPile2Unlocked == 1 && PileOfCounsBoughtFirstTime == 1)
            {
                waitTimeOver2 = true;
                StartCoroutine(waitForBundleOfCoins2());
            }
            if (waitTimeOver3 == false && isPile3Unlocked == 1 && PileOfCounsBoughtFirstTime == 1)
            {
                waitTimeOver3 = true;
                StartCoroutine(waitForBundleOfCoins3());
            }
            if (waitTimeOver4 == false && isPile4Unlocked == 1 && PileOfCounsBoughtFirstTime == 1)
            {
                waitTimeOver4 = true;
                StartCoroutine(waitForBundleOfCoins4());
            }
            if (waitTimeOver5 == false && isPile5Unlocked == 1 && PileOfCounsBoughtFirstTime == 1)
            {
                waitTimeOver5 = true;
                StartCoroutine(waitForBundleOfCoins5());
            }
        }
    }

    #region Set Pile of coins
    public void SetPileOfCoins()
    {
        if (PileOfCounsBoughtFirstTime == 0)
        {
            pileOfCoin1.SetActive(false);
            pileOfCoin2.SetActive(false);
            pileOfCoin3.SetActive(false);
            pileOfCoin4.SetActive(false);
            pileOfCoin5.SetActive(false);
            pile1IsEmpty.SetActive(false);
            pile2IsEmpty.SetActive(false);
            pile3IsEmpty.SetActive(false);
            pile4IsEmpty.SetActive(false);
            pile5IsEmpty.SetActive(false);
            blockPile1.SetActive(true);
            blockPile2.SetActive(true);
            blockPile3.SetActive(true);
            blockPile4.SetActive(true);
            blockPile5.SetActive(true);
        }
        if (PileOfCounsBoughtFirstTime == 1 && isPile1Unlocked == 1)
        {
            pileOfCoin1.SetActive(true);
        }
        if (PileOfCounsBoughtFirstTime == 1 && isPile2Unlocked == 1)
        {
            pileOfCoin2.SetActive(true);
        }
        if (PileOfCounsBoughtFirstTime == 1 && isPile3Unlocked == 1)
        {
            pileOfCoin3.SetActive(true);
        }
        if (PileOfCounsBoughtFirstTime == 1 && isPile4Unlocked == 1)
        {
            pileOfCoin4.SetActive(true);
        }
        if (PileOfCounsBoughtFirstTime == 1 && isPile5Unlocked == 1)
        {
            pileOfCoin5.SetActive(true);
        }

        if (isPile1Unlocked == 0 && PileOfCounsBoughtFirstTime == 0) { blockPile1.SetActive(true); }
        if (isPile2Unlocked == 0 && PileOfCounsBoughtFirstTime == 0) { blockPile2.SetActive(true); }
        if (isPile3Unlocked == 0 && PileOfCounsBoughtFirstTime == 0) { blockPile3.SetActive(true); }
        if (isPile4Unlocked == 0 && PileOfCounsBoughtFirstTime == 0) { blockPile4.SetActive(true); }
        if (isPile5Unlocked == 0 && PileOfCounsBoughtFirstTime == 0) { blockPile5.SetActive(true); }
        if (isPile1Unlocked == 1 && PileOfCounsBoughtFirstTime == 1) { blockPile1.SetActive(false); }
        if (isPile2Unlocked == 1 && PileOfCounsBoughtFirstTime == 1) { blockPile2.SetActive(false); }
        if (isPile3Unlocked == 1 && PileOfCounsBoughtFirstTime == 1) { blockPile3.SetActive(false); }
        if (isPile4Unlocked == 1 && PileOfCounsBoughtFirstTime == 1) { blockPile4.SetActive(false); }
        if (isPile5Unlocked == 1 && PileOfCounsBoughtFirstTime == 1) { blockPile5.SetActive(false); }

        if (PileOfCoinsAmount1 == 0) { pile1IsEmpty.SetActive(true); PileOfCoinsAmountText1.color = Color.red; }
        if (PileOfCoinsAmount2 == 0) { pile2IsEmpty.SetActive(true); PileOfCoinsAmountText2.color = Color.red; }
        if (PileOfCoinsAmount3 == 0) { pile3IsEmpty.SetActive(true); PileOfCoinsAmountText3.color = Color.red; }
        if (PileOfCoinsAmount4 == 0) { pile4IsEmpty.SetActive(true); PileOfCoinsAmountText4.color = Color.red; }
        if (PileOfCoinsAmount5 == 0) { pile5IsEmpty.SetActive(true); PileOfCoinsAmountText5.color = Color.red; }

        if (PileOfCoinsAmount1 > 0) { pile1IsEmpty.SetActive(false); PileOfCoinsAmountText1.color = Color.yellow; }
        if (PileOfCoinsAmount2 > 0) { pile2IsEmpty.SetActive(false); PileOfCoinsAmountText2.color = Color.yellow; }
        if (PileOfCoinsAmount3 > 0) { pile3IsEmpty.SetActive(false); PileOfCoinsAmountText3.color = Color.yellow; }
        if (PileOfCoinsAmount4 > 0) { pile4IsEmpty.SetActive(false); PileOfCoinsAmountText4.color = Color.yellow; }
        if (PileOfCoinsAmount5 > 0) { pile5IsEmpty.SetActive(false); PileOfCoinsAmountText5.color = Color.yellow; }
    }
    #endregion

    public GameObject pileTooltip1, pileTooltip2, pileTooltip3, pileTooltip4, pileTooltip5;
    public GameObject pileCollectBtn, pileCloseBtn, blackScreen;

    public int pileOpenNumber;

    public bool openPileFrame;

    public void OpenPileToolTip(int pileNumber)
    {
        if(LoadSaves.isMobileBuild == true)
        {
            openPileFrame = true;
            blackScreen.SetActive(true);
            pileOpenNumber = pileNumber;

            pileCollectBtn.SetActive(true);
            pileCloseBtn.SetActive(true);

            if (pileNumber == 1) 
            {
                pileTooltip1.SetActive(true);
                pileTooltip1.transform.localPosition = new Vector2(-189.892f, -20.53901f);
                pileTooltip1.transform.localScale = new Vector2(2.057733f, 2.057733f);
            }
            if (pileNumber == 2)
            {
                pileTooltip2.SetActive(true);
                pileTooltip2.transform.localPosition = new Vector2(-189.892f, -20.53901f);
                pileTooltip2.transform.localScale = new Vector2(2.057733f, 2.057733f);
            }
            if (pileNumber == 3)
            {
                pileTooltip3.SetActive(true);
                pileTooltip3.transform.localPosition = new Vector2(-189.892f, -20.53901f);
                pileTooltip3.transform.localScale = new Vector2(2.057733f, 2.057733f);
            }
            if (pileNumber == 4)
            {
                pileTooltip4.SetActive(true);
                pileTooltip4.transform.localPosition = new Vector2(-189.892f, -20.53901f);
                pileTooltip4.transform.localScale = new Vector2(2.057733f, 2.057733f);
            }
            if (pileNumber == 5)
            {
                pileTooltip5.SetActive(true);
                pileTooltip5.transform.localPosition = new Vector2(-189.892f, -20.53901f);
                pileTooltip5.transform.localScale = new Vector2(2.057733f, 2.057733f);
            }
        }
    }

    public void Collect()
    {
        if(pileOpenNumber == 1 && PileOfCoinsAmount1 > 0) { ClickPile1(); }
        if (pileOpenNumber == 2 && PileOfCoinsAmount2 > 0) { ClickPile2(); }
        if (pileOpenNumber == 3 && PileOfCoinsAmount3 > 0) { ClickPile3(); }
        if (pileOpenNumber == 4 && PileOfCoinsAmount4 > 0) { ClickPile4(); }
        if (pileOpenNumber == 5 && PileOfCoinsAmount5 > 0) { ClickPile5(); }
    }

    public void ClosePileTOoltip()
    {
        pileCollectBtn.SetActive(false);
        pileCloseBtn.SetActive(false);
        openPileFrame = false;
        blackScreen.SetActive(false);
        pileTooltip1.SetActive(false);
        pileTooltip2.SetActive(false);
        pileTooltip3.SetActive(false);
        pileTooltip4.SetActive(false);
        pileTooltip5.SetActive(false);
    }


    public static int PileBagAmount;

    public GameObject pile1PopUp;
    public GameObject pile2PopUp;
    public GameObject pile3PopUp;
    public GameObject pile4PopUp;
    public GameObject pile5PopUp;

    //-90.7, -200
    //0.411, 0.411

    public void ClickPile1()
    {
        if(LoadSaves.isMobileBuild == true && openPileFrame == false)
        {
            return;
        }

        PlayAudio();
        pile1PopUp.SetActive(true);
        StartCoroutine(setPopUpFalse1());
        incrementPileOfCoinsAmount += 1;
        amountOfTimesClickedOnPile.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.clickedPile + incrementPileOfCoinsAmount + LocalizationStrings.times;

        int random = Random.Range(1, 101);
        if (AscendScreen.isSpecialUpgrade3Baugh == 1)
        {
            GlobalCoins.CoinCount += PileOfCoinsAmount1;
            if (random < pileNotLostChance)
            {

                PileOfCoinsAmountText1.text = FormatCoins(PileOfCoinsAmount1);

               
            }
            if (random >= pileNotLostChance)
            { PileOfCoinsAmount1 -= PileOfCoinsAmount1;
                PileOfCoinsAmountText1.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.coins;
            }
        }

        if(AscendScreen.isSpecialUpgrade3Baugh == 0)
        {
            GlobalCoins.CoinCount += PileOfCoinsAmount1;
            PileOfCoinsAmount1 -= PileOfCoinsAmount1;
            PileOfCoinsAmountText1.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.coins;
        }
        if(AscendScreen.boughtPileBag == 1) {
            PileBagAmount += 250;
            pileBagStatsText.text = LocalizationStrings.inflatePileOfBagsStats + PileBagAmount + LocalizationStrings.moreCoinsAfterInflating;
        }
        SetPileOfCoins();
    }


    public void ClickPile2()
    {
        if (LoadSaves.isMobileBuild == true && openPileFrame == false)
        {
            return;
        }

        pile2PopUp.SetActive(true);
        StartCoroutine(setPopUpFalse2());
        PlayAudio();
        incrementPileOfCoinsAmount += 1;
        amountOfTimesClickedOnPile.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.clickedPile + incrementPileOfCoinsAmount + LocalizationStrings.times;

        if (AscendScreen.isSpecialUpgrade3Baugh == 1)
        {
            GlobalCoins.CoinCount += PileOfCoinsAmount2;
            int random = Random.Range(1, 101);
            if (random < pileNotLostChance) {


                PileOfCoinsAmountText2.text = FormatCoins(PileOfCoinsAmount2);
            }
            if (random >= pileNotLostChance) { PileOfCoinsAmount2 -= PileOfCoinsAmount2; 
            PileOfCoinsAmountText2.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.coins;
            }
        }
        if (AscendScreen.isSpecialUpgrade3Baugh == 0)
        {
            GlobalCoins.CoinCount += PileOfCoinsAmount2;
            PileOfCoinsAmount2 -= PileOfCoinsAmount2;
            PileOfCoinsAmountText2.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.coins;
        }
        if (AscendScreen.boughtPileBag == 1)
        {
            PileBagAmount += 250;
            pileBagStatsText.text = LocalizationStrings.inflatePileOfBagsStats + PileBagAmount + LocalizationStrings.moreCoinsAfterInflating;
        }
        SetPileOfCoins();
    }

    public void ClickPile3()
    {
        if (LoadSaves.isMobileBuild == true && openPileFrame == false)
        {
            return;
        }

        pile3PopUp.SetActive(true);
        StartCoroutine(setPopUpFalse3());
        PlayAudio();
        incrementPileOfCoinsAmount += 1;
        amountOfTimesClickedOnPile.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.clickedPile + incrementPileOfCoinsAmount + LocalizationStrings.times;
        if (AscendScreen.isSpecialUpgrade3Baugh == 1)
        {
            GlobalCoins.CoinCount += PileOfCoinsAmount3;
            int random = Random.Range(1, 101);
            if (random < pileNotLostChance) {

                PileOfCoinsAmountText3.text = FormatCoins(PileOfCoinsAmount3);

            }
            if (random >= pileNotLostChance) { PileOfCoinsAmount3 -= PileOfCoinsAmount3; PileOfCoinsAmountText3.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.coins; }
        }
        if (AscendScreen.isSpecialUpgrade3Baugh == 0)
        {
            PileOfCoinsAmount3 -= PileOfCoinsAmount3;
            GlobalCoins.CoinCount += PileOfCoinsAmount3;
            PileOfCoinsAmountText3.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.coins;
        }
        if (AscendScreen.boughtPileBag == 1)
        {
            PileBagAmount += 250;
            pileBagStatsText.text = LocalizationStrings.inflatePileOfBagsStats + PileBagAmount + LocalizationStrings.moreCoinsAfterInflating;
        }

        SetPileOfCoins();
    }
    public void ClickPile4()
    {
        if (LoadSaves.isMobileBuild == true && openPileFrame == false)
        {
            return;
        }

        pile4PopUp.SetActive(true);
        StartCoroutine(setPopUpFalse4());
        PlayAudio();
        incrementPileOfCoinsAmount += 1;
        amountOfTimesClickedOnPile.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.clickedPile + incrementPileOfCoinsAmount + LocalizationStrings.times;
        if (AscendScreen.isSpecialUpgrade3Baugh == 1)
        {
            GlobalCoins.CoinCount += PileOfCoinsAmount4;

            int random = Random.Range(1, 101);
            if (random < pileNotLostChance) {

                PileOfCoinsAmountText4.text = FormatCoins(PileOfCoinsAmount4);
            }
            if (random >= pileNotLostChance) { PileOfCoinsAmount4 -= PileOfCoinsAmount4; PileOfCoinsAmountText4.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.coins; }
        }
        if (AscendScreen.isSpecialUpgrade3Baugh == 0)
        {
            GlobalCoins.CoinCount += PileOfCoinsAmount4;
            PileOfCoinsAmount4 -= PileOfCoinsAmount4;
            PileOfCoinsAmountText4.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.coins;
        }
        if (AscendScreen.boughtPileBag == 1)
        {
            PileBagAmount += 250;
            pileBagStatsText.text = LocalizationStrings.inflatePileOfBagsStats + PileBagAmount + LocalizationStrings.moreCoinsAfterInflating;
        }
        SetPileOfCoins();
    }

    public void ClickPile5()
    {
        if (LoadSaves.isMobileBuild == true && openPileFrame == false)
        {
            return;
        }

        pile5PopUp.SetActive(true);
        StartCoroutine(setPopUpFalse5());
        PlayAudio();
        incrementPileOfCoinsAmount += 1;
        amountOfTimesClickedOnPile.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.clickedPile + incrementPileOfCoinsAmount + LocalizationStrings.times;
        if (AscendScreen.isSpecialUpgrade3Baugh == 1)
        {
            GlobalCoins.CoinCount += PileOfCoinsAmount5;

            int random = Random.Range(1, 101);
            if (random < pileNotLostChance)
            {

                PileOfCoinsAmountText5.text = FormatCoins(PileOfCoinsAmount5);
            }
            if (random >= pileNotLostChance) { PileOfCoinsAmount5 -= PileOfCoinsAmount5; PileOfCoinsAmountText5.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.coins; }
        }
        if (AscendScreen.isSpecialUpgrade3Baugh == 0)
        {
            GlobalCoins.CoinCount += PileOfCoinsAmount5;
            PileOfCoinsAmount5 -= PileOfCoinsAmount5;
            PileOfCoinsAmountText5.GetComponent<TextMeshProUGUI>().text = "0" + LocalizationStrings.coins;
        }
        if (AscendScreen.boughtPileBag == 1)
        {
            PileBagAmount += 250;
            pileBagStatsText.text = LocalizationStrings.inflatePileOfBagsStats + PileBagAmount + LocalizationStrings.moreCoinsAfterInflating;
        }
        SetPileOfCoins();
    }


    IEnumerator waitForBundleOfCoins()
    {
  
        yield return new WaitForSeconds(waitTime);
        currentTime = waitTime;

        PileOfCoinsAmount1 += (MainButtonClick.coinsPerClick * (MainButtonClick.numberOfDuplicationUpgrades +(AscendScreen.morePileOfCoinsGain + 5)));
        totalAmountOfPileGenerated += (MainButtonClick.coinsPerClick * (MainButtonClick.numberOfDuplicationUpgrades + (AscendScreen.morePileOfCoinsGain + 5)));

        PileOfCoinsAmountText1.text = FormatCoins(PileOfCoinsAmount1);

        
        waitTimeOver1 = false;
        SetPileOfCoins();
    }
    IEnumerator waitForBundleOfCoins2()
    {
        
        yield return new WaitForSeconds(waitTime);
        currentTime2 = waitTime;

        PileOfCoinsAmount2 += (MainButtonClick.coinsPerClick * (MainButtonClick.numberOfDuplicationUpgrades + (AscendScreen.morePileOfCoinsGain + 5)));
        totalAmountOfPileGenerated += (MainButtonClick.coinsPerClick * (MainButtonClick.numberOfDuplicationUpgrades + (AscendScreen.morePileOfCoinsGain + 5)));

        PileOfCoinsAmountText2.text = FormatCoins(PileOfCoinsAmount2);

        waitTimeOver2 = false;
        SetPileOfCoins();
    }
    IEnumerator waitForBundleOfCoins3()
    {
    
        yield return new WaitForSeconds(waitTime);
        currentTime3 = waitTime;

        PileOfCoinsAmount3 += (MainButtonClick.coinsPerClick * (MainButtonClick.numberOfDuplicationUpgrades + (AscendScreen.morePileOfCoinsGain + 5)));
        totalAmountOfPileGenerated += (MainButtonClick.coinsPerClick * (MainButtonClick.numberOfDuplicationUpgrades + (AscendScreen.morePileOfCoinsGain + 5)));

        PileOfCoinsAmountText3.text = FormatCoins(PileOfCoinsAmount3);

        waitTimeOver3 = false;
        SetPileOfCoins();
    }
    IEnumerator waitForBundleOfCoins4()
    {
     
        yield return new WaitForSeconds(waitTime);
        currentTime4 = waitTime;

        PileOfCoinsAmount4 += (MainButtonClick.coinsPerClick * (MainButtonClick.numberOfDuplicationUpgrades + (AscendScreen.morePileOfCoinsGain + 5)));
        totalAmountOfPileGenerated += (MainButtonClick.coinsPerClick * (MainButtonClick.numberOfDuplicationUpgrades + (AscendScreen.morePileOfCoinsGain + 5)));

        PileOfCoinsAmountText4.text = FormatCoins(PileOfCoinsAmount4);

        waitTimeOver4 = false;
        SetPileOfCoins();
    }
    IEnumerator waitForBundleOfCoins5()
    {
        yield return new WaitForSeconds(waitTime);
        currentTime5 = waitTime;

        PileOfCoinsAmount5 += (MainButtonClick.coinsPerClick * (MainButtonClick.numberOfDuplicationUpgrades + (AscendScreen.morePileOfCoinsGain + 5)));
        totalAmountOfPileGenerated += (MainButtonClick.coinsPerClick * (MainButtonClick.numberOfDuplicationUpgrades + (AscendScreen.morePileOfCoinsGain + 5)));

        PileOfCoinsAmountText5.text = FormatCoins(PileOfCoinsAmount5);

        waitTimeOver5 = false;
        SetPileOfCoins();
    }

    IEnumerator setPopUpFalse1()
    {
        yield return new WaitForSeconds(1.5f);
        pile1PopUp.SetActive(false);
    }
    IEnumerator setPopUpFalse2()
    {
        yield return new WaitForSeconds(1.5f);
        pile2PopUp.SetActive(false);
    }
    IEnumerator setPopUpFalse3()
    {
        yield return new WaitForSeconds(1.5f);
        pile3PopUp.SetActive(false);
    }
    IEnumerator setPopUpFalse4()
    {
        yield return new WaitForSeconds(1.5f);
        pile4PopUp.SetActive(false);
    }
    IEnumerator setPopUpFalse5()
    {
        yield return new WaitForSeconds(1.5f);
        pile5PopUp.SetActive(false);
    }

   

}
