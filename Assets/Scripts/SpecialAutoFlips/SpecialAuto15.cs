using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using TMPro;

public class SpecialAuto15 : MonoBehaviour
{
    public static int flipAuto = 0;
    public bool CreatingCoin = false;
    public AudioSource autoCoinFlipSound;
    public AudioSource autoCoinFlipSound2;
    public AudioSource luckyCoinEffect;
    GoldenFlipsButton goldenFlip;
    public VideoPlayer specialAnim15;
    public GameObject transformPopUp;
    public GameObject coverOver15;
    public TestingNewAnim newFlipScript;

    public void Awake()
    {
        goldenFlip = specialAnim15.GetComponent<GoldenFlipsButton>();
        coverOver15.SetActive(false);
    }

    void Update()
    {
        if (GlobalCoinMaker.coinsPerFlipUpgrades == 0) { CreatingCoin = false; }
        if (CreatingCoin == false && flipAuto == 1)
        {
            CreatingCoin = true;
            StartCoroutine(WaitAlilBit());
        }
    }

    IEnumerator WaitAlilBit()
    {
        yield return new WaitForSeconds(Challenges.wait5Seconds);
        yield return new WaitForSeconds(AutoCoin.wait);
        CreateTheCoin();
    }

    public float killTime = 0.7f;
    public Transform parent;
    public GameObject coinPopUpHeads;
    public GameObject coinPopUpTails;
    public GameObject luckyCoinPopUp;

    public void CreateTheCoin()
    {
        if (LoadSaves.isMobileBuild == false) { specialAnim15.Play(); }
        else { newFlipScript.FlipSpecial(15); }

        StatsAll.flippedAmount += 1;
        PlayFlipSound();
        int random = Random.Range(1, 202);
        if (EnterText.choseHeads == 1)
        {
            if (random > MainButtonClick.higherCoinChance) { StartCoroutine(CreatePopUpHeads()); }
            if (random > MainButtonClick.lowSpecialChance && random < MainButtonClick.lowerCoinChance) { StartCoroutine(CreatePopUpTails()); }
            if (random <= MainButtonClick.lowSpecialChance) { StartCoroutine(playerDidGetLucky()); }
        }
        if (EnterText.choseTails == 1)
        {
            if (random > MainButtonClick.higherCoinChance) { StartCoroutine(ChoseTailsHitTails()); }
            if (random > MainButtonClick.lowSpecialChance && random < MainButtonClick.lowerCoinChance) { StartCoroutine(ChoseTailsHitHeads()); }
            if (random <= MainButtonClick.lowSpecialChance) { StartCoroutine(playerDidGetLucky()); }
        }
    }

    public float waitTime = 1.23f;
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
            >= 1E+15f => ((float)coins / 1E+15).ToString("0.##") + LocalizationStrings.quadrillion,
            >= 1E+12f => ((float)coins / 1000000000000.0).ToString("0.##") + LocalizationStrings.trillionc,
            >= 1E+09f => ((float)coins / 1000000000.0).ToString("0.##") + LocalizationStrings.billionc,
            >= 1000000f => ((float)coins / 1000000.0).ToString("0.##") + LocalizationStrings.millionc,
            >= 1000f => ((float)coins / 1000.0).ToString("0.##") + LocalizationStrings.thousandC,
            _ => ((float)coins / 1.0).ToString("##") + LocalizationStrings.coins
        };
    }

    IEnumerator CreatePopUpHeads()
    {
        GameObject popUpHeadsCopy = ObjectPool.instance.GetHeadsFromPool();
        popUpHeadsCopy.transform.position = transformPopUp.transform.position;
        popUpHeadsCopy.SetActive(false);

        popUpHeadsCopy.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = LocalizationStrings.heads + "+" + FormatCoins(MainButtonClick.coinsPerClick * (2 + AscendScreen.specialFlipperCoinMultiplier + ManualClicking.flipAllBonus));


        if (Screen.width == 1920 && Screen.height == 1080)
        {
            if (MainButtonClick.numberOfDuplicationUpgrades < 3) { popUpHeadsCopy.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 3 || MainButtonClick.numberOfDuplicationUpgrades > 3) { popUpHeadsCopy.transform.localScale = new Vector3(0.70f, 0.70f, 0.70f); }
            if (MainButtonClick.numberOfDuplicationUpgrades > 8 || MainButtonClick.numberOfDuplicationUpgrades == 8) { popUpHeadsCopy.transform.localScale = new Vector3(0.60f, 0.60f, 0.60f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 10) { popUpHeadsCopy.transform.localScale = new Vector3(0.55f, 0.55f, 0.55f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 11 || MainButtonClick.numberOfDuplicationUpgrades > 11) { popUpHeadsCopy.transform.localScale = new Vector3(0.50f, 0.50f, 0.50f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 15 || MainButtonClick.numberOfDuplicationUpgrades > 15) { popUpHeadsCopy.transform.localScale = new Vector3(0.45f, 0.45f, 0.45f); }
            if (MainButtonClick.numberOfDuplicationUpgrades >= 18) { popUpHeadsCopy.transform.localScale = new Vector3(0.40f, 0.40f, 0.40f); }
        }
        else
        {
            if (MainButtonClick.numberOfDuplicationUpgrades < 3) { popUpHeadsCopy.transform.localScale = new Vector3(0.60f, 0.60f, 0.60f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 3 || MainButtonClick.numberOfDuplicationUpgrades > 3) { popUpHeadsCopy.transform.localScale = new Vector3(0.55f, 0.55f, 0.55f); }
            if (MainButtonClick.numberOfDuplicationUpgrades > 8 || MainButtonClick.numberOfDuplicationUpgrades == 8) { popUpHeadsCopy.transform.localScale = new Vector3(0.50f, 0.50f, 0.50f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 10) { popUpHeadsCopy.transform.localScale = new Vector3(0.47f, 0.47f, 0.47f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 11 || MainButtonClick.numberOfDuplicationUpgrades > 11) { popUpHeadsCopy.transform.localScale = new Vector3(0.46f, 0.46f, 0.46f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 15 || MainButtonClick.numberOfDuplicationUpgrades > 15) { popUpHeadsCopy.transform.localScale = new Vector3(0.43f, 0.43f, 0.43f); }
            if (MainButtonClick.numberOfDuplicationUpgrades >= 18) { popUpHeadsCopy.transform.localScale = new Vector3(0.41f, 0.41f, 0.41f); }
        }

        yield return new WaitForSeconds(MainButtonClick.AnimTime);
        popUpHeadsCopy.SetActive(true);
        StatsAll.headsFlippedAmount += 1;
        GlobalCoins.CoinCount += MainButtonClick.coinsPerClick * (2 + AscendScreen.specialFlipperCoinMultiplier + ManualClicking.flipAllBonus);
        CreatingCoin = false;
        popUpHeadsCopy.transform.SetParent(parent);
        ObjectPool.instance.ReturnHeadsToPool(popUpHeadsCopy.gameObject);
    }

    IEnumerator CreatePopUpTails()
    {
        GameObject popUpHeadsTails = ObjectPool.instance.GetTailsFromPool();
        popUpHeadsTails.transform.position = transformPopUp.transform.position;
        popUpHeadsTails.SetActive(false);
        popUpHeadsTails.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = LocalizationStrings.tails + "+0" + LocalizationStrings.coins;

        if (Screen.width == 1920 && Screen.height == 1080)
        {
            if (MainButtonClick.numberOfDuplicationUpgrades < 3) { popUpHeadsTails.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 3 || MainButtonClick.numberOfDuplicationUpgrades > 3) { popUpHeadsTails.transform.localScale = new Vector3(0.70f, 0.70f, 0.70f); }
            if (MainButtonClick.numberOfDuplicationUpgrades > 8 || MainButtonClick.numberOfDuplicationUpgrades == 8) { popUpHeadsTails.transform.localScale = new Vector3(0.60f, 0.60f, 0.60f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 10) { popUpHeadsTails.transform.localScale = new Vector3(0.55f, 0.55f, 0.55f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 11 || MainButtonClick.numberOfDuplicationUpgrades > 11) { popUpHeadsTails.transform.localScale = new Vector3(0.50f, 0.50f, 0.50f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 15 || MainButtonClick.numberOfDuplicationUpgrades > 15) { popUpHeadsTails.transform.localScale = new Vector3(0.45f, 0.45f, 0.45f); }
            if (MainButtonClick.numberOfDuplicationUpgrades >= 18) { popUpHeadsTails.transform.localScale = new Vector3(0.40f, 0.40f, 0.40f); }
        }
        else
        {
            if (MainButtonClick.numberOfDuplicationUpgrades < 3) { popUpHeadsTails.transform.localScale = new Vector3(0.60f, 0.60f, 0.60f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 3 || MainButtonClick.numberOfDuplicationUpgrades > 3) { popUpHeadsTails.transform.localScale = new Vector3(0.55f, 0.55f, 0.55f); }
            if (MainButtonClick.numberOfDuplicationUpgrades > 8 || MainButtonClick.numberOfDuplicationUpgrades == 8) { popUpHeadsTails.transform.localScale = new Vector3(0.50f, 0.50f, 0.50f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 10) { popUpHeadsTails.transform.localScale = new Vector3(0.47f, 0.47f, 0.47f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 11 || MainButtonClick.numberOfDuplicationUpgrades > 11) { popUpHeadsTails.transform.localScale = new Vector3(0.46f, 0.46f, 0.46f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 15 || MainButtonClick.numberOfDuplicationUpgrades > 15) { popUpHeadsTails.transform.localScale = new Vector3(0.43f, 0.43f, 0.43f); }
            if (MainButtonClick.numberOfDuplicationUpgrades >= 18) { popUpHeadsTails.transform.localScale = new Vector3(0.41f, 0.41f, 0.41f); }
        }

        yield return new WaitForSeconds(MainButtonClick.AnimTime);
        popUpHeadsTails.SetActive(true);
        StatsAll.tailsFlippedAmount += 1;
        GlobalCoins.CoinCount += 0;
        CreatingCoin = false;
        popUpHeadsTails.transform.SetParent(parent);
        ObjectPool.instance.ReturnTailsToPool(popUpHeadsTails.gameObject);
    }

    IEnumerator ChoseTailsHitTails()
    {
        GameObject popUpHeadsTails = ObjectPool.instance.GetHeadsFromPool();
        popUpHeadsTails.transform.position = transformPopUp.transform.position;
        popUpHeadsTails.SetActive(false);

        popUpHeadsTails.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = LocalizationStrings.tails + "+" + FormatCoins(MainButtonClick.coinsPerClick * (2 + AscendScreen.specialFlipperCoinMultiplier + ManualClicking.flipAllBonus));



        if (Screen.width == 1920 && Screen.height == 1080)
        {
            if (MainButtonClick.numberOfDuplicationUpgrades < 3) { popUpHeadsTails.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 3 || MainButtonClick.numberOfDuplicationUpgrades > 3) { popUpHeadsTails.transform.localScale = new Vector3(0.70f, 0.70f, 0.70f); }
            if (MainButtonClick.numberOfDuplicationUpgrades > 8 || MainButtonClick.numberOfDuplicationUpgrades == 8) { popUpHeadsTails.transform.localScale = new Vector3(0.60f, 0.60f, 0.60f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 10) { popUpHeadsTails.transform.localScale = new Vector3(0.55f, 0.55f, 0.55f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 11 || MainButtonClick.numberOfDuplicationUpgrades > 11) { popUpHeadsTails.transform.localScale = new Vector3(0.50f, 0.50f, 0.50f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 15 || MainButtonClick.numberOfDuplicationUpgrades > 15) { popUpHeadsTails.transform.localScale = new Vector3(0.45f, 0.45f, 0.45f); }
            if (MainButtonClick.numberOfDuplicationUpgrades >= 18) { popUpHeadsTails.transform.localScale = new Vector3(0.40f, 0.40f, 0.40f); }
        }
        else
        {
            if (MainButtonClick.numberOfDuplicationUpgrades < 3) { popUpHeadsTails.transform.localScale = new Vector3(0.60f, 0.60f, 0.60f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 3 || MainButtonClick.numberOfDuplicationUpgrades > 3) { popUpHeadsTails.transform.localScale = new Vector3(0.55f, 0.55f, 0.55f); }
            if (MainButtonClick.numberOfDuplicationUpgrades > 8 || MainButtonClick.numberOfDuplicationUpgrades == 8) { popUpHeadsTails.transform.localScale = new Vector3(0.50f, 0.50f, 0.50f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 10) { popUpHeadsTails.transform.localScale = new Vector3(0.47f, 0.47f, 0.47f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 11 || MainButtonClick.numberOfDuplicationUpgrades > 11) { popUpHeadsTails.transform.localScale = new Vector3(0.46f, 0.46f, 0.46f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 15 || MainButtonClick.numberOfDuplicationUpgrades > 15) { popUpHeadsTails.transform.localScale = new Vector3(0.43f, 0.43f, 0.43f); }
            if (MainButtonClick.numberOfDuplicationUpgrades >= 18) { popUpHeadsTails.transform.localScale = new Vector3(0.41f, 0.41f, 0.41f); }
        }

        yield return new WaitForSeconds(MainButtonClick.AnimTime);
        popUpHeadsTails.SetActive(true);
        StatsAll.tailsFlippedAmount += 1;
        GlobalCoins.CoinCount += MainButtonClick.coinsPerClick * (2 + AscendScreen.specialFlipperCoinMultiplier + ManualClicking.flipAllBonus);
        popUpHeadsTails.transform.SetParent(parent);
        ObjectPool.instance.ReturnHeadsToPool(popUpHeadsTails.gameObject);
        CreatingCoin = false;
    }

    IEnumerator ChoseTailsHitHeads()
    {
        GameObject popUpHeadsCopy = ObjectPool.instance.GetTailsFromPool();
        popUpHeadsCopy.transform.position = transformPopUp.transform.position;
        popUpHeadsCopy.SetActive(false);
        popUpHeadsCopy.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = LocalizationStrings.heads + "+0" + LocalizationStrings.coins;

        if (Screen.width == 1920 && Screen.height == 1080)
        {
            if (MainButtonClick.numberOfDuplicationUpgrades < 3) { popUpHeadsCopy.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 3 || MainButtonClick.numberOfDuplicationUpgrades > 3) { popUpHeadsCopy.transform.localScale = new Vector3(0.70f, 0.70f, 0.70f); }
            if (MainButtonClick.numberOfDuplicationUpgrades > 8 || MainButtonClick.numberOfDuplicationUpgrades == 8) { popUpHeadsCopy.transform.localScale = new Vector3(0.60f, 0.60f, 0.60f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 10) { popUpHeadsCopy.transform.localScale = new Vector3(0.55f, 0.55f, 0.55f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 11 || MainButtonClick.numberOfDuplicationUpgrades > 11) { popUpHeadsCopy.transform.localScale = new Vector3(0.50f, 0.50f, 0.50f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 15 || MainButtonClick.numberOfDuplicationUpgrades > 15) { popUpHeadsCopy.transform.localScale = new Vector3(0.45f, 0.45f, 0.45f); }
            if (MainButtonClick.numberOfDuplicationUpgrades >= 18) { popUpHeadsCopy.transform.localScale = new Vector3(0.40f, 0.40f, 0.40f); }
        }
        else
        {
            if (MainButtonClick.numberOfDuplicationUpgrades < 3) { popUpHeadsCopy.transform.localScale = new Vector3(0.60f, 0.60f, 0.60f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 3 || MainButtonClick.numberOfDuplicationUpgrades > 3) { popUpHeadsCopy.transform.localScale = new Vector3(0.55f, 0.55f, 0.55f); }
            if (MainButtonClick.numberOfDuplicationUpgrades > 8 || MainButtonClick.numberOfDuplicationUpgrades == 8) { popUpHeadsCopy.transform.localScale = new Vector3(0.50f, 0.50f, 0.50f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 10) { popUpHeadsCopy.transform.localScale = new Vector3(0.47f, 0.47f, 0.47f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 11 || MainButtonClick.numberOfDuplicationUpgrades > 11) { popUpHeadsCopy.transform.localScale = new Vector3(0.46f, 0.46f, 0.46f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 15 || MainButtonClick.numberOfDuplicationUpgrades > 15) { popUpHeadsCopy.transform.localScale = new Vector3(0.43f, 0.43f, 0.43f); }
            if (MainButtonClick.numberOfDuplicationUpgrades >= 18) { popUpHeadsCopy.transform.localScale = new Vector3(0.41f, 0.41f, 0.41f); }
        }

        yield return new WaitForSeconds(MainButtonClick.AnimTime);
        popUpHeadsCopy.SetActive(true);
        StatsAll.headsFlippedAmount += 1;
        GlobalCoins.CoinCount += 0;
        popUpHeadsCopy.transform.SetParent(parent);
        ObjectPool.instance.ReturnTailsToPool(popUpHeadsCopy.gameObject);
        CreatingCoin = false;
    }
    IEnumerator playerDidGetLucky()
    {
        GameObject luckyPopUpCopy = ObjectPool.instance.GetLuckyFromPool();
        luckyPopUpCopy.transform.position = transformPopUp.transform.position;
        luckyPopUpCopy.SetActive(false);

        luckyPopUpCopy.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = LocalizationStrings.luckyCoin + "+" + FormatCoins(MainButtonClick.coinsPerClick * (10 + AscendScreen.specialFlipperCoinLuckyMultiplier));



        if (Screen.width == 1920 && Screen.height == 1080)
        {
            if (MainButtonClick.numberOfDuplicationUpgrades < 3) { luckyPopUpCopy.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 3 || MainButtonClick.numberOfDuplicationUpgrades > 3) { luckyPopUpCopy.transform.localScale = new Vector3(0.70f, 0.70f, 0.70f); }
            if (MainButtonClick.numberOfDuplicationUpgrades > 8 || MainButtonClick.numberOfDuplicationUpgrades == 8) { luckyPopUpCopy.transform.localScale = new Vector3(0.60f, 0.60f, 0.60f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 10) { luckyPopUpCopy.transform.localScale = new Vector3(0.55f, 0.55f, 0.55f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 11 || MainButtonClick.numberOfDuplicationUpgrades > 11) { luckyPopUpCopy.transform.localScale = new Vector3(0.50f, 0.50f, 0.50f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 15 || MainButtonClick.numberOfDuplicationUpgrades > 15) { luckyPopUpCopy.transform.localScale = new Vector3(0.45f, 0.45f, 0.45f); }
            if (MainButtonClick.numberOfDuplicationUpgrades >= 18) { luckyPopUpCopy.transform.localScale = new Vector3(0.40f, 0.40f, 0.40f); }
        }
        else
        {
            if (MainButtonClick.numberOfDuplicationUpgrades < 3) { luckyPopUpCopy.transform.localScale = new Vector3(0.60f, 0.60f, 0.60f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 3 || MainButtonClick.numberOfDuplicationUpgrades > 3) { luckyPopUpCopy.transform.localScale = new Vector3(0.55f, 0.55f, 0.55f); }
            if (MainButtonClick.numberOfDuplicationUpgrades > 8 || MainButtonClick.numberOfDuplicationUpgrades == 8) { luckyPopUpCopy.transform.localScale = new Vector3(0.50f, 0.50f, 0.50f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 10) { luckyPopUpCopy.transform.localScale = new Vector3(0.47f, 0.47f, 0.47f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 11 || MainButtonClick.numberOfDuplicationUpgrades > 11) { luckyPopUpCopy.transform.localScale = new Vector3(0.46f, 0.46f, 0.46f); }
            if (MainButtonClick.numberOfDuplicationUpgrades == 15 || MainButtonClick.numberOfDuplicationUpgrades > 15) { luckyPopUpCopy.transform.localScale = new Vector3(0.43f, 0.43f, 0.43f); }
            if (MainButtonClick.numberOfDuplicationUpgrades >= 18) { luckyPopUpCopy.transform.localScale = new Vector3(0.41f, 0.41f, 0.41f); }
        }

        if (AscendScreen.boughtSpecialLUCKER == 1)
        {
            int random = Random.Range(1, 101);
            if (random < 6)
            {
                AscendScreen.hitEvenLuckerCoin += 1;
                GlobalCoins.CoinCount += MainButtonClick.coinsPerClick * (50);

            }
        }

        yield return new WaitForSeconds(MainButtonClick.AnimTime);
        luckyPopUpCopy.SetActive(true);
        GlobalCoins.CoinCount += MainButtonClick.coinsPerClick * (10 + AscendScreen.specialFlipperCoinLuckyMultiplier);
        StatsAll.luckyCoinsAmount += 1;
        luckyCoinEffect.PlayOneShot(luckyCoinSound);
        CreatingCoin = false;
        luckyPopUpCopy.transform.SetParent(parent);
        ObjectPool.instance.ReturnLuckyToPool(luckyPopUpCopy.gameObject);
    }

    public AudioClip flipSound;
    public AudioClip flipSound2;
    public AudioClip luckyCoinSound;

    public void PlayFlipSound()
    {
        if (FlipperMute.flipperMute15 == 0)
        {
            int random = Random.Range(1, 3);
            if (random == 1)
            {
                autoCoinFlipSound.PlayOneShot(flipSound);
            }
            if (random == 2)
            {
                autoCoinFlipSound2.PlayOneShot(flipSound2);
            }

        }
        else { }

    }


}