using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using Random = UnityEngine.Random;
using TMPro;

public class MainButtonClick : MonoBehaviour
{
    public GameObject DuplicateCoinFlipps;
    public GameObject coinFlipper1;
    public GameObject empty1;
    public AudioSource playCoinFlipSound;
    public AudioSource playCoinFlipSound2;
    public AudioSource luckySound;
    public VideoPlayer animVideo;
    public AudioClip flipSound;
    public AudioClip flipSound2;
    public AudioClip luckyFlip;

    public TextMeshProUGUI pileAmountText1;
    public TextMeshProUGUI pileAmountText2;
    public TextMeshProUGUI pileAmountText3;
    public TextMeshProUGUI pileAmountText4;
    public TextMeshProUGUI pileAmountText5;

    public static float coinsPerClick = 1;

    public static int numberOfDuplicationUpgrades = 0;

    public void Start()
    {
        StartCoroutine(waitForCheckingGoldenFlips());
    }

    IEnumerator waitForCheckingGoldenFlips()
    {
        yield return new WaitForSeconds(0.1f);
        SetMuteFlipper();
    }

    void Update()
    {
         Application.runInBackground = true;
         if(GoldenFlipsButton.goldenCoinsUpgradeCount == 0) {empty1.SetActive(true); }
    }

    public void SetMuteFlipper()
    {
        if (GlobalCoinMaker.coinsPerFlipUpgrades == 0) { muteFlipperHover1.SetActive(false); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 0) { muteFlipperHover1.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 1) { muteFlipperHover2.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 2) { muteFlipperHover3.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 3) { muteFlipperHover4.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 4) { muteFlipperHover5.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 5) { muteFlipperHover6.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 6) { muteFlipperHover7.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 7) { muteFlipperHover8.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 8) { muteFlipperHover9.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 9) { muteFlipperHover10.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 10) { muteFlipperHover11.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 11) { muteFlipperHover12.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 12) { muteFlipperHover13.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 13) { muteFlipperHover14.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 14) { muteFlipperHover15.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 15) { muteFlipperHover16.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 16) { muteFlipperHover17.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 17) { muteFlipperHover18.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 18) { muteFlipperHover19.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 19) { muteFlipperHover20.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 20) { muteFlipperHover21.SetActive(true); }

        if (numberOfDuplicationUpgrades == 0)
        {
            empty1.transform.localPosition = new Vector3(235f, -12, 0f);
            empty1.transform.localScale = new Vector3(1.107344f, 1.107344f, 1.107344f);
            empty2.SetActive(false);
            empty3.SetActive(false);
            empty4.SetActive(false);
            empty5.SetActive(false);
            empty6.SetActive(false);
            empty7.SetActive(false);
            empty8.SetActive(false);
            empty9.SetActive(false);
            empty10.SetActive(false);
            empty11.SetActive(false);
            empty12.SetActive(false);
            empty13.SetActive(false);
            empty14.SetActive(false);
            empty15.SetActive(false);
            empty16.SetActive(false);
            empty17.SetActive(false);
            empty18.SetActive(false);
            empty19.SetActive(false);
            empty20.SetActive(false);
            empty21.SetActive(false);
        }
    }

    Renderer render;

    public GameObject muteFlipper1;
    public GameObject muteFlipper2;
    public GameObject muteFlipper3;
    public GameObject muteFlipper4;
    public GameObject muteFlipper5;
    public GameObject muteFlipper6;
    public GameObject muteFlipper7;
    public GameObject muteFlipper8;
    public GameObject muteFlipper9;
    public GameObject muteFlipper10;
    public GameObject muteFlipper11;
    public GameObject muteFlipper12;
    public GameObject muteFlipper13;
    public GameObject muteFlipper14;
    public GameObject muteFlipper15;
    public GameObject muteFlipper16;
    public GameObject muteFlipper17;
    public GameObject muteFlipper18;
    public GameObject muteFlipper19;
    public GameObject muteFlipper20;
    public GameObject muteFlipper21;
    public static int activeFlipsAmount;
    public static float chall3CompletedBonus;

    //BUTTON1
    public void ClickTheButton ()
    {
        activeFlipsAmount += 1;
        muteFlipperHover1.SetActive(true);
        StatsAll.flippedAmount += 1;
        coinFlipper1.SetActive(false);
        StartCoroutine(AnimationTime());

        if(Challenges.completedChallenge3 == 1)
        {
            chall3CompletedBonus = 5;
        }

        if (Challenges.completedChallenge2 == 0 && Challenges.completedChallenge3 == 0)
        {
            
            StartCoroutine(FlipChanceHeadsOrTails());
        }

        if (Challenges.completedChallenge2 == 1 || Challenges.completedChallenge3 == 1) 
        {
            if(EnterText.choseHeads == 1)
            {
                int random = Random.Range(1, 202);
                if (random > lowSpecialChance) { StartCoroutine(CreatePopUpHeads()); StartCoroutine(flipRandomChanceHeads()); }
                if (random <= lowSpecialChance) { StartCoroutine(playerGotLucky()); StartCoroutine(playerDidGetLucky()); }
            }
            if (EnterText.choseTails == 1)
            {
                int random = Random.Range(1, 202);
                if (random > lowSpecialChance) { StartCoroutine(ChoseTailsHitTails()); StartCoroutine(flipRandomChanceTails1()); }
                if (random <= lowSpecialChance) { StartCoroutine(playerGotLucky()); StartCoroutine(playerDidGetLucky()); }
            }
        }

        if (muteFlipper1.activeInHierarchy)
        {
            PlayCoinFlipSound();
        }
        else 
        {
            if(LoadSaves.isMobileBuild == true) { PlayCoinFlipSound(); }
        }

        if(LoadSaves.isMobileBuild == false)
        {
            animVideo.Play();
            animVideo.playbackSpeed = fasterAnim;
        }
    }

    //BUTTON2
    public GameObject empty2;
    public GameObject coinFlipper2;
    public VideoPlayer animVideo2;

    public void ClickTheButton2()
    {
        activeFlipsAmount += 1;
        chall3CompletedBonus = 0;
        muteFlipperHover2.SetActive(true);
        StatsAll.flippedAmount += 1;
        if (LoadSaves.isMobileBuild == false)
        {
            animVideo2.Play();
            animVideo2.playbackSpeed = fasterAnim;
        }
       
        coinFlipper2.SetActive(false);
        StartCoroutine(AnimationTime2());

        if (Challenges.completedChallenge2 == 0)
        {

            StartCoroutine(FlipChanceHeadsOrTails());
        }

        if (Challenges.completedChallenge2 == 1)
        {
            if (EnterText.choseHeads == 1)
            {
                int random = Random.Range(1, 202);
                if (random > lowSpecialChance) { StartCoroutine(CreatePopUpHeads()); StartCoroutine(flipRandomChanceHeads()); }
                if (random <= lowSpecialChance) { StartCoroutine(playerGotLucky()); StartCoroutine(playerDidGetLucky()); }
            }
            if (EnterText.choseTails == 1)
            {
                int random = Random.Range(1, 202);
                if (random > lowSpecialChance) { StartCoroutine(ChoseTailsHitTails()); StartCoroutine(flipRandomChanceTails1()); }
                if (random <= lowSpecialChance) { StartCoroutine(playerGotLucky()); StartCoroutine(playerDidGetLucky()); }
            }
        }

        if (muteFlipper2.activeInHierarchy)
        {
            PlayCoinFlipSound();
        }
        else
        {
            if (LoadSaves.isMobileBuild == true) { PlayCoinFlipSound(); }
        }
    }

    //BUTTON3
    public GameObject empty3;
    public GameObject coinFlipper3;
    public VideoPlayer animVideo3;

    public void ClickTheButton3()
    {
        activeFlipsAmount += 1;
        chall3CompletedBonus = 0;
        muteFlipperHover3.SetActive(true);
        StatsAll.flippedAmount += 1;
        if (LoadSaves.isMobileBuild == false)
        {
            animVideo3.Play();
            animVideo3.playbackSpeed = fasterAnim;
        }
        coinFlipper3.SetActive(false);
        StartCoroutine(AnimationTime3());
        if (Challenges.completedChallenge2 == 0)
        {

            StartCoroutine(FlipChanceHeadsOrTails());
        }

        if (Challenges.completedChallenge2 == 1)
        {
            if (EnterText.choseHeads == 1)
            {
                int random = Random.Range(1, 202);
                if (random > lowSpecialChance) { StartCoroutine(CreatePopUpHeads()); StartCoroutine(flipRandomChanceHeads()); }
                if (random <= lowSpecialChance) { StartCoroutine(playerGotLucky()); StartCoroutine(playerDidGetLucky()); }
            }
            if (EnterText.choseTails == 1)
            {
                int random = Random.Range(1, 202);
                if (random > lowSpecialChance) { StartCoroutine(ChoseTailsHitTails()); StartCoroutine(flipRandomChanceTails1()); }
                if (random <= lowSpecialChance) { StartCoroutine(playerGotLucky()); StartCoroutine(playerDidGetLucky()); }
            }
        }

        if (muteFlipper3.activeInHierarchy)
        {
            PlayCoinFlipSound();
        }
        else
        {
            if (LoadSaves.isMobileBuild == true) { PlayCoinFlipSound(); }
        }
    }

    //BUTTON4
    public GameObject empty4;
    public GameObject coinFlipper4;
    public VideoPlayer animVideo4;

    public void ClickTheButton4()
    {
        activeFlipsAmount += 1;
        chall3CompletedBonus = 0;
        muteFlipperHover4.SetActive(true);
        StatsAll.flippedAmount += 1;
        if (LoadSaves.isMobileBuild == false)
        {
            animVideo4.Play();
            animVideo4.playbackSpeed = fasterAnim;
        }
        coinFlipper4.SetActive(false);
        StartCoroutine(AnimationTime4());
        if (Challenges.completedChallenge2 == 0)
        {

            StartCoroutine(FlipChanceHeadsOrTails());
        }

        if (Challenges.completedChallenge2 == 1)
        {
            if (EnterText.choseHeads == 1)
            {
                int random = Random.Range(1, 202);
                if (random > lowSpecialChance) { StartCoroutine(CreatePopUpHeads()); StartCoroutine(flipRandomChanceHeads()); }
                if (random <= lowSpecialChance) { StartCoroutine(playerGotLucky()); StartCoroutine(playerDidGetLucky()); }
            }
            if (EnterText.choseTails == 1)
            {
                int random = Random.Range(1, 202);
                if (random > lowSpecialChance) { StartCoroutine(ChoseTailsHitTails()); StartCoroutine(flipRandomChanceTails1()); }
                if (random <= lowSpecialChance) { StartCoroutine(playerGotLucky()); StartCoroutine(playerDidGetLucky()); }
            }
        }

        if (muteFlipper4.activeInHierarchy)
        {
            PlayCoinFlipSound();
        }
        else
        {
            if (LoadSaves.isMobileBuild == true) { PlayCoinFlipSound(); }
        }
    }
    //BUTTON5
    public GameObject empty5;
    public GameObject coinFlipper5;
    public VideoPlayer animVideo5;

    public void ClickTheButton5()
    {
        activeFlipsAmount += 1;
        chall3CompletedBonus = 0;
        muteFlipperHover5.SetActive(true);
        StatsAll.flippedAmount += 1;
        if (LoadSaves.isMobileBuild == false)
        {
            animVideo5.Play();
            animVideo5.playbackSpeed = fasterAnim;
        }
        coinFlipper5.SetActive(false);
        StartCoroutine(AnimationTime5());
        if (Challenges.completedChallenge2 == 0)
        {

            StartCoroutine(FlipChanceHeadsOrTails());
        }

        if (Challenges.completedChallenge2 == 1)
        {
            chall3CompletedBonus = 0;
            if (EnterText.choseHeads == 1)
            {
                int random = Random.Range(1, 202);
                if (random > lowSpecialChance) { StartCoroutine(CreatePopUpHeads()); StartCoroutine(flipRandomChanceHeads()); }
                if (random <= lowSpecialChance) { StartCoroutine(playerGotLucky()); StartCoroutine(playerDidGetLucky()); }
            }
            if (EnterText.choseTails == 1)
            {
                int random = Random.Range(1, 202);
                if (random > lowSpecialChance) { StartCoroutine(ChoseTailsHitTails()); StartCoroutine(flipRandomChanceTails1()); }
                if (random <= lowSpecialChance) { StartCoroutine(playerGotLucky()); StartCoroutine(playerDidGetLucky()); }
            }
        }

        if (muteFlipper5.activeInHierarchy)
        {
            PlayCoinFlipSound();
        }
        else
        {
            if (LoadSaves.isMobileBuild == true) { PlayCoinFlipSound(); }
        }
    }

    //BUTTON6
    public GameObject empty6;
    public GameObject coinFlipper6;
    public VideoPlayer animVideo6;

    public void ClickTheButton6()
    {
        activeFlipsAmount += 1;
        chall3CompletedBonus = 0;
        muteFlipperHover6.SetActive(true);
        StatsAll.flippedAmount += 1;
        if (LoadSaves.isMobileBuild == false)
        {
            animVideo6.Play();
            animVideo6.playbackSpeed = fasterAnim;
        }
        coinFlipper6.SetActive(false);
        StartCoroutine(AnimationTime6());
        StartCoroutine(FlipChanceHeadsOrTails());
        if (muteFlipper6.activeInHierarchy)
        {
            PlayCoinFlipSound();
        }
        else
        {
            if (LoadSaves.isMobileBuild == true) { PlayCoinFlipSound(); }
        }
    }
    //BUTTON7
    public GameObject empty7;
    public GameObject coinFlipper7;
    public VideoPlayer animVideo7;

    public void ClickTheButton7()
    {
        activeFlipsAmount += 1;
        chall3CompletedBonus = 0;
        muteFlipperHover7.SetActive(true);
        StatsAll.flippedAmount += 1;
        if (LoadSaves.isMobileBuild == false)
        {
            animVideo7.Play();
            animVideo7.playbackSpeed = fasterAnim;
        }
        coinFlipper7.SetActive(false);
        StartCoroutine(AnimationTime7());
        StartCoroutine(FlipChanceHeadsOrTails());
        if (muteFlipper7.activeInHierarchy)
        {
            PlayCoinFlipSound();
        }
        else
        {
            if (LoadSaves.isMobileBuild == true) { PlayCoinFlipSound(); }
        }
    }

    //BUTTON8
    public GameObject empty8;
    public GameObject coinFlipper8;
    public VideoPlayer animVideo8;

    public void ClickTheButton8()
    {
        chall3CompletedBonus = 0;
        muteFlipperHover8.SetActive(true);
        StatsAll.flippedAmount += 1;
        if (LoadSaves.isMobileBuild == false)
        {
            animVideo8.Play();
            animVideo8.playbackSpeed = fasterAnim;
        }
        coinFlipper8.SetActive(false);
        StartCoroutine(AnimationTime8());
        StartCoroutine(FlipChanceHeadsOrTails());
        if (muteFlipper8.activeInHierarchy)
        {
            PlayCoinFlipSound();
        }
        else
        {
            if (LoadSaves.isMobileBuild == true) { PlayCoinFlipSound(); }
        }
    }

    //BUTTON9
    public GameObject empty9;
    public GameObject coinFlipper9;
    public VideoPlayer animVideo9;

    public void ClickTheButton9()
    {
        activeFlipsAmount += 1;
        chall3CompletedBonus = 0;
        muteFlipperHover9.SetActive(true);
        StatsAll.flippedAmount += 1;
        if (LoadSaves.isMobileBuild == false)
        {
            animVideo9.Play();
            animVideo9.playbackSpeed = fasterAnim;
        }
        coinFlipper9.SetActive(false);
        StartCoroutine(AnimationTime9());
        StartCoroutine(FlipChanceHeadsOrTails());
        if (muteFlipper9.activeInHierarchy)
        {
            PlayCoinFlipSound();
        }
        else
        {
            if (LoadSaves.isMobileBuild == true) { PlayCoinFlipSound(); }
        }
    }

    //BUTTON10
    public GameObject empty10;
    public GameObject coinFlipper10;
    public VideoPlayer animVideo10;

    public void ClickTheButton10()
    {
        activeFlipsAmount += 1;
        chall3CompletedBonus = 0;
        muteFlipperHover10.SetActive(true);
        StatsAll.flippedAmount += 1;
        if (LoadSaves.isMobileBuild == false)
        {
            animVideo10.Play();
            animVideo10.playbackSpeed = fasterAnim;
        }
        coinFlipper10.SetActive(false);
        StartCoroutine(AnimationTime10());
        StartCoroutine(FlipChanceHeadsOrTails());
        if (muteFlipper10.activeInHierarchy)
        {
            PlayCoinFlipSound();
        }
        else
        {
            if (LoadSaves.isMobileBuild == true) { PlayCoinFlipSound(); }
        }
    }

    //BUTTON11
    public GameObject empty11;
    public GameObject coinFlipper11;
    public VideoPlayer animVideo11;

    public void ClickTheButton11()
    {
        activeFlipsAmount += 1;
        chall3CompletedBonus = 0;
        muteFlipperHover11.SetActive(true);
        StatsAll.flippedAmount += 1;
        if (LoadSaves.isMobileBuild == false)
        {
            animVideo11.Play();
            animVideo11.playbackSpeed = fasterAnim;
        }
        coinFlipper11.SetActive(false);
        StartCoroutine(AnimationTime11());
        StartCoroutine(FlipChanceHeadsOrTails());
        if (muteFlipper11.activeInHierarchy)
        {
            PlayCoinFlipSound();
        }
        else
        {
            if (LoadSaves.isMobileBuild == true) { PlayCoinFlipSound(); }
        }
    }
    //BUTTON12
    public GameObject empty12;
    public GameObject coinFlipper12;
    public VideoPlayer animVideo12;

    public void ClickTheButton12()
    {
        activeFlipsAmount += 1;
        chall3CompletedBonus = 0;
        muteFlipperHover12.SetActive(true);
        StatsAll.flippedAmount += 1;
        if (LoadSaves.isMobileBuild == false)
        {
            animVideo12.Play();
            animVideo12.playbackSpeed = fasterAnim;
        }
        coinFlipper12.SetActive(false);
        StartCoroutine(AnimationTime12());
        StartCoroutine(FlipChanceHeadsOrTails());
        if (muteFlipper12.activeInHierarchy)
        {
            PlayCoinFlipSound();
        }
        else
        {
            if (LoadSaves.isMobileBuild == true) { PlayCoinFlipSound(); }
        }
    }
    //BUTTON13
    public GameObject empty13;
    public GameObject coinFlipper13;
    public VideoPlayer animVideo13;

    public void ClickTheButton13()
    {
        activeFlipsAmount += 1;
        chall3CompletedBonus = 0;
        muteFlipperHover13.SetActive(true);
        StatsAll.flippedAmount += 1;
        if (LoadSaves.isMobileBuild == false)
        {
            animVideo13.Play();
            animVideo13.playbackSpeed = fasterAnim;
        }
        coinFlipper13.SetActive(false);
        StartCoroutine(AnimationTime13());
        StartCoroutine(FlipChanceHeadsOrTails());
        if (muteFlipper13.activeInHierarchy)
        {
            PlayCoinFlipSound();
        }
        else
        {
            if (LoadSaves.isMobileBuild == true) { PlayCoinFlipSound(); }
        }
    }
    //BUTTON14
    public GameObject empty14;
    public GameObject coinFlipper14;
    public VideoPlayer animVideo14;

    public void ClickTheButton14()
    {
        activeFlipsAmount += 1;
        chall3CompletedBonus = 0;
        muteFlipperHover14.SetActive(true);
        StatsAll.flippedAmount += 1;
        if (LoadSaves.isMobileBuild == false)
        {
            animVideo14.Play();
            animVideo14.playbackSpeed = fasterAnim;
        }
        coinFlipper14.SetActive(false);
        StartCoroutine(AnimationTime14());
        StartCoroutine(FlipChanceHeadsOrTails());
        if (muteFlipper14.activeInHierarchy)
        {
            PlayCoinFlipSound();
        }
        else
        {
            if (LoadSaves.isMobileBuild == true) { PlayCoinFlipSound(); }
        }
    }
    //BUTTON15
    public GameObject empty15;
    public GameObject coinFlipper15;
    public VideoPlayer animVideo15;

    public void ClickTheButton15()
    {
        activeFlipsAmount += 1;
        chall3CompletedBonus = 0;
        muteFlipperHover15.SetActive(true);
        StatsAll.flippedAmount += 1;
        if (LoadSaves.isMobileBuild == false)
        {
            animVideo15.Play();
            animVideo15.playbackSpeed = fasterAnim;
        }
        coinFlipper15.SetActive(false);
        StartCoroutine(AnimationTime15());
        StartCoroutine(FlipChanceHeadsOrTails());
        if (muteFlipper15.activeInHierarchy)
        {
            PlayCoinFlipSound();
        }
        else
        {
            if (LoadSaves.isMobileBuild == true) { PlayCoinFlipSound(); }
        }
    }
    //BUTTON16
    public GameObject empty16;
    public GameObject coinFlipper16;
    public VideoPlayer animVideo16;

    public void ClickTheButton16()
    {
        activeFlipsAmount += 1;
        chall3CompletedBonus = 0;
        muteFlipperHover16.SetActive(true);
        StatsAll.flippedAmount += 1;
        if (LoadSaves.isMobileBuild == false)
        {
            animVideo16.Play();
            animVideo16.playbackSpeed = fasterAnim;
        }
        coinFlipper16.SetActive(false);
        StartCoroutine(AnimationTime16());
        StartCoroutine(FlipChanceHeadsOrTails());
        if (muteFlipper16.activeInHierarchy)
        {
            PlayCoinFlipSound();
        }
        else
        {
            if (LoadSaves.isMobileBuild == true) { PlayCoinFlipSound(); }
        }
    }
    //BUTTON17
    public GameObject empty17;
    public GameObject coinFlipper17;
    public VideoPlayer animVideo17;

    public void ClickTheButton17()
    {
        activeFlipsAmount += 1;
        chall3CompletedBonus = 0;
        muteFlipperHover17.SetActive(true);
        StatsAll.flippedAmount += 1;
        if (LoadSaves.isMobileBuild == false)
        {
            animVideo17.Play();
            animVideo17.playbackSpeed = fasterAnim;
        }
        coinFlipper17.SetActive(false);
        StartCoroutine(AnimationTime17());
        StartCoroutine(FlipChanceHeadsOrTails());
        if (muteFlipper17.activeInHierarchy)
        {
            PlayCoinFlipSound();
        }
        else
        {
            if (LoadSaves.isMobileBuild == true) { PlayCoinFlipSound(); }
        }
    }
    //BUTTON18
    public GameObject empty18;
    public GameObject coinFlipper18;
    public VideoPlayer animVideo18;

    public void ClickTheButton18()
    {
        activeFlipsAmount += 1;
        chall3CompletedBonus = 0;
        muteFlipperHover18.SetActive(true);
        StatsAll.flippedAmount += 1;
        if (LoadSaves.isMobileBuild == false)
        {
            animVideo18.Play();
            animVideo18.playbackSpeed = fasterAnim;
        }
        coinFlipper18.SetActive(false);
        StartCoroutine(AnimationTime18());
        StartCoroutine(FlipChanceHeadsOrTails());
        if (muteFlipper18.activeInHierarchy)
        {
            PlayCoinFlipSound();
        }
        else
        {
            if (LoadSaves.isMobileBuild == true) { PlayCoinFlipSound(); }
        }
    }
    //BUTTON19
    public GameObject empty19;
    public GameObject coinFlipper19;
    public VideoPlayer animVideo19;

    public void ClickTheButton19()
    {
        activeFlipsAmount += 1;
        chall3CompletedBonus = 0;
        muteFlipperHover19.SetActive(true);
        StatsAll.flippedAmount += 1;
        if (LoadSaves.isMobileBuild == false)
        {
            animVideo19.Play();
            animVideo19.playbackSpeed = fasterAnim;
        }
        coinFlipper19.SetActive(false);
        StartCoroutine(AnimationTime19());
        StartCoroutine(FlipChanceHeadsOrTails());
        if (muteFlipper19.activeInHierarchy)
        {
            PlayCoinFlipSound();
        }
        else
        {
            if (LoadSaves.isMobileBuild == true) { PlayCoinFlipSound(); }
        }
    }
    //BUTTON20
    public GameObject empty20;
    public GameObject coinFlipper20;
    public VideoPlayer animVideo20;

    public void ClickTheButton20()
    {
        activeFlipsAmount += 1;
        chall3CompletedBonus = 0;
        muteFlipperHover20.SetActive(true);
        StatsAll.flippedAmount += 1;
        if (LoadSaves.isMobileBuild == false)
        {
            animVideo20.Play();
            animVideo20.playbackSpeed = fasterAnim;
        }
        coinFlipper20.SetActive(false);
        StartCoroutine(AnimationTime20());
        StartCoroutine(FlipChanceHeadsOrTails());
        if (muteFlipper20.activeInHierarchy)
        {
            PlayCoinFlipSound();
        }
        else
        {
            if (LoadSaves.isMobileBuild == true) { PlayCoinFlipSound(); }
        }
    }
    //BUTTON21
    public GameObject empty21;
    public GameObject coinFlipper21;
    public VideoPlayer animVideo21;

    public void ClickTheButton21()
    {
        activeFlipsAmount += 1;
        chall3CompletedBonus = 0;
        muteFlipperHover21.SetActive(true);
        StatsAll.flippedAmount += 1;
        if (LoadSaves.isMobileBuild == false)
        {
            animVideo21.Play();
            animVideo21.playbackSpeed = fasterAnim;
        }
        coinFlipper21.SetActive(false);
        StartCoroutine(AnimationTime21());
        StartCoroutine(FlipChanceHeadsOrTails());
        if (muteFlipper21.activeInHierarchy)
        {
            PlayCoinFlipSound();
        }
        else
        {
            if (LoadSaves.isMobileBuild == true) { PlayCoinFlipSound(); }
        }
    }

    public static float waitForAnimTime = 1.33336f;
    public static float fasterAnim = 1.0f;
    public static float AnimTime = 1.26f;

    public static int lowerCoinChance = 101;
    public static int higherCoinChance = 100;
    public static int lowSpecialChance = 1;


    IEnumerator AnimationTime()
    {
        yield return new WaitForSeconds(AnimTime);
        yield return new WaitForSeconds(Challenges.wait5Seconds);
        muteFlipperHover1.SetActive(false);
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 0)
        { coinFlipper1.SetActive(false); }
        else
        { coinFlipper1.SetActive(true); }
    }

    IEnumerator AnimationTime2()
    {
        yield return new WaitForSeconds(AnimTime);
        yield return new WaitForSeconds(Challenges.wait5Seconds);
        muteFlipperHover2.SetActive(false);
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 1)
        { coinFlipper2.SetActive(false); }
        else
        { coinFlipper2.SetActive(true); }
    }
    IEnumerator AnimationTime3()
    {
        yield return new WaitForSeconds(AnimTime);
        yield return new WaitForSeconds(Challenges.wait5Seconds);
        muteFlipperHover3.SetActive(false);
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 2)
        { coinFlipper3.SetActive(false); }
        else
        { coinFlipper3.SetActive(true); }
    }
    IEnumerator AnimationTime4()
    {
        yield return new WaitForSeconds(AnimTime);
        yield return new WaitForSeconds(Challenges.wait5Seconds);
        muteFlipperHover4.SetActive(false);
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 3)
        { coinFlipper4.SetActive(false); }
        else
        { coinFlipper4.SetActive(true); }
    }
    IEnumerator AnimationTime5()
    {
        yield return new WaitForSeconds(AnimTime);
        yield return new WaitForSeconds(Challenges.wait5Seconds);
        muteFlipperHover5.SetActive(false);
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 4)
        { coinFlipper5.SetActive(false); }
        else
        { coinFlipper5.SetActive(true); }
    }
    IEnumerator AnimationTime6()
    {
        yield return new WaitForSeconds(AnimTime);
        yield return new WaitForSeconds(Challenges.wait5Seconds);
        muteFlipperHover6.SetActive(false);
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 5)
        { coinFlipper6.SetActive(false); }
        else
        { coinFlipper6.SetActive(true); }
    }

    IEnumerator AnimationTime7()
    {
        yield return new WaitForSeconds(AnimTime);
        yield return new WaitForSeconds(Challenges.wait5Seconds);
        muteFlipperHover7.SetActive(false);
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 6)
        { coinFlipper7.SetActive(false); }
        else
        { coinFlipper7.SetActive(true); }
    }
    IEnumerator AnimationTime8()
    {
        yield return new WaitForSeconds(AnimTime);
        yield return new WaitForSeconds(Challenges.wait5Seconds);
        muteFlipperHover8.SetActive(false);
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 7)
        { coinFlipper8.SetActive(false); }
        else
        { coinFlipper8.SetActive(true); }
    }
    IEnumerator AnimationTime9()
    {
        yield return new WaitForSeconds(AnimTime);
        yield return new WaitForSeconds(Challenges.wait5Seconds);
        muteFlipperHover9.SetActive(false);
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 8)
        { coinFlipper9.SetActive(false); }
        else
        { coinFlipper9.SetActive(true); }
    }
    IEnumerator AnimationTime10()
    {
        yield return new WaitForSeconds(AnimTime);
        yield return new WaitForSeconds(Challenges.wait5Seconds);
        muteFlipperHover10.SetActive(false);
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 9)
        { coinFlipper10.SetActive(false); }
        else
        { coinFlipper10.SetActive(true); }
    }

    IEnumerator AnimationTime11()
    {
        yield return new WaitForSeconds(AnimTime);
        yield return new WaitForSeconds(Challenges.wait5Seconds);
        muteFlipperHover11.SetActive(false);
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 10)
        { coinFlipper11.SetActive(false); }
        else
        { coinFlipper11.SetActive(true); }
    }
    IEnumerator AnimationTime12()
    {
        yield return new WaitForSeconds(AnimTime);
        yield return new WaitForSeconds(Challenges.wait5Seconds);
        muteFlipperHover12.SetActive(false);
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 11)
        { coinFlipper12.SetActive(false); }
        else
        { coinFlipper12.SetActive(true); }
    }
    IEnumerator AnimationTime13()
    {
        yield return new WaitForSeconds(AnimTime);
        yield return new WaitForSeconds(Challenges.wait5Seconds);
        muteFlipperHover13.SetActive(false);
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 12)
        { coinFlipper13.SetActive(false); }
        else
        { coinFlipper13.SetActive(true); }
    }
    IEnumerator AnimationTime14()
    {
        yield return new WaitForSeconds(AnimTime);
        yield return new WaitForSeconds(Challenges.wait5Seconds);
        muteFlipperHover14.SetActive(false);
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 13)
        { coinFlipper14.SetActive(false); }
        else
        { coinFlipper14.SetActive(true); }
    }
    IEnumerator AnimationTime15()
    {
        yield return new WaitForSeconds(AnimTime);
        yield return new WaitForSeconds(Challenges.wait5Seconds);
        muteFlipperHover15.SetActive(false);
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 14)
        { coinFlipper15.SetActive(false); }
        else
        { coinFlipper15.SetActive(true); }
    }
    IEnumerator AnimationTime16()
    {
        yield return new WaitForSeconds(AnimTime);
        yield return new WaitForSeconds(Challenges.wait5Seconds);
        muteFlipperHover16.SetActive(false);
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 15)
        { coinFlipper16.SetActive(false); }
        else
        { coinFlipper16.SetActive(true); }
    }
    IEnumerator AnimationTime17()
    {
        yield return new WaitForSeconds(AnimTime);
        yield return new WaitForSeconds(Challenges.wait5Seconds);
        muteFlipperHover17.SetActive(false);
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 16)
        { coinFlipper17.SetActive(false); }
        else
        { coinFlipper17.SetActive(true); }
    }
    IEnumerator AnimationTime18()
    {
        yield return new WaitForSeconds(AnimTime);
        yield return new WaitForSeconds(Challenges.wait5Seconds);
        muteFlipperHover18.SetActive(false);
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 17)
        { coinFlipper18.SetActive(false); }
        else
        { coinFlipper18.SetActive(true); }
    }
    IEnumerator AnimationTime19()
    {
        yield return new WaitForSeconds(AnimTime);
        yield return new WaitForSeconds(Challenges.wait5Seconds);
        muteFlipperHover19.SetActive(false);
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 18)
        { coinFlipper19.SetActive(false); }
        else
        { coinFlipper19.SetActive(true); }
    }
    IEnumerator AnimationTime20()
    {
        yield return new WaitForSeconds(AnimTime);
        yield return new WaitForSeconds(Challenges.wait5Seconds);
        muteFlipperHover20.SetActive(false);
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 19)
        { coinFlipper20.SetActive(false); }
        else
        { coinFlipper20.SetActive(true); }
    }
    IEnumerator AnimationTime21()
    {
        yield return new WaitForSeconds(AnimTime);
        yield return new WaitForSeconds(Challenges.wait5Seconds);
        muteFlipperHover21.SetActive(false);
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 20)
        { coinFlipper21.SetActive(false); }
        else
        { coinFlipper21.SetActive(true); }
    }

    IEnumerator FlipChanceHeadsOrTails()
    {
        int random = Random.Range(1, 202);
        if (EnterText.choseHeads == 1)
        {
            if (random > higherCoinChance) { StartCoroutine(CreatePopUpHeads()); StartCoroutine(flipRandomChanceHeads()); }
            if (random > lowSpecialChance && random < lowerCoinChance) { StartCoroutine(CreatePopUpTails()); StartCoroutine(flipRandomChanceTails()); }
            if (random <= lowSpecialChance) { StartCoroutine(playerGotLucky()); StartCoroutine(playerDidGetLucky()); }
        }
        if (EnterText.choseTails == 1)
        {
            if (random > higherCoinChance) { StartCoroutine(ChoseTailsHitTails()); StartCoroutine(flipRandomChanceTails1()); }
            if (random > lowSpecialChance && random < lowerCoinChance) { StartCoroutine(ChoseTailsHitHeads()); StartCoroutine(flipRandomChanceHeads1()); }
            if (random <= lowSpecialChance) { StartCoroutine(playerGotLucky()); StartCoroutine(playerDidGetLucky()); }
        }
        yield return new WaitForSeconds(AnimTime);
    }

    public void PlayCoinFlipSound()
    {
        int random = Random.Range(1, 3);
        if (random == 1)
        {
            playCoinFlipSound.PlayOneShot(flipSound);
        }
        if (random == 2)
        {
            playCoinFlipSound2.PlayOneShot(flipSound2);
        }

    }

    public GameObject coinPopUpHeads;
    public GameObject coinPopUpTails;
    public GameObject luckyCoinPopUp;
    public float coinPopUpTime;
    public Transform parent;
    public bool worldPositionStays;
    public float popUpKillTime = 0.5f;
    public float moveSpeed = 10.0f;
    public GameObject tranformPopUpHere;
    IEnumerator CreatePopUpHeads()
    {
        GameObject heads = ObjectPool.instance.GetHeadsFromPool();
        heads.transform.position = tranformPopUpHere.transform.position;
        heads.SetActive(false);

        heads.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = LocalizationStrings.heads + "+" + FormatCoins(MainButtonClick.coinsPerClick * (1 + AscendScreen.activeFlipperMiltiplier + Challenges.chall3Bonus + chall3CompletedBonus));

        if (Screen.width == 1920 && Screen.height == 1080)
        {
            if (numberOfDuplicationUpgrades < 3) { heads.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f); }
            if (numberOfDuplicationUpgrades == 3 || numberOfDuplicationUpgrades > 3) { heads.transform.localScale = new Vector3(0.70f, 0.70f, 0.70f); }
            if (numberOfDuplicationUpgrades > 8 || numberOfDuplicationUpgrades == 8) { heads.transform.localScale = new Vector3(0.60f, 0.60f, 0.60f); }
            if (numberOfDuplicationUpgrades == 10) { heads.transform.localScale = new Vector3(0.55f, 0.55f, 0.55f); }
            if (numberOfDuplicationUpgrades == 11 || numberOfDuplicationUpgrades > 11) { heads.transform.localScale = new Vector3(0.50f, 0.50f, 0.50f); }
            if (numberOfDuplicationUpgrades == 15 || numberOfDuplicationUpgrades > 15) { heads.transform.localScale = new Vector3(0.45f, 0.45f, 0.45f); }
            if (numberOfDuplicationUpgrades >= 18) { heads.transform.localScale = new Vector3(0.40f, 0.40f, 0.40f); }
        }
        else
        {
            if (numberOfDuplicationUpgrades < 3) { heads.transform.localScale = new Vector3(0.60f, 0.60f, 0.60f); }
            if (numberOfDuplicationUpgrades == 3 || numberOfDuplicationUpgrades > 3) { heads.transform.localScale = new Vector3(0.55f, 0.55f, 0.55f); }
            if (numberOfDuplicationUpgrades > 8 || numberOfDuplicationUpgrades == 8) { heads.transform.localScale = new Vector3(0.50f, 0.50f, 0.50f); }
            if (numberOfDuplicationUpgrades == 10) { heads.transform.localScale = new Vector3(0.47f, 0.47f, 0.47f); }
            if (numberOfDuplicationUpgrades == 11 || numberOfDuplicationUpgrades > 11) { heads.transform.localScale = new Vector3(0.46f, 0.46f, 0.46f); }
            if (numberOfDuplicationUpgrades == 15 || numberOfDuplicationUpgrades > 15) { heads.transform.localScale = new Vector3(0.43f, 0.43f, 0.43f); }
            if (numberOfDuplicationUpgrades >= 18) { heads.transform.localScale = new Vector3(0.41f, 0.41f, 0.41f); }
        }
        
        yield return new WaitForSeconds(AnimTime);
        heads.SetActive(true);
        StatsAll.headsFlippedAmount += 1;
        heads.transform.SetParent(parent);
        ObjectPool.instance.ReturnHeadsToPool(heads.gameObject);
    }

    IEnumerator CreatePopUpTails()
    {
        GameObject tails = ObjectPool.instance.GetTailsFromPool();
        tails.transform.position = tranformPopUpHere.transform.position;
        tails.SetActive(false);

        tails.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = LocalizationStrings.tails + "+0" + LocalizationStrings.coins;
        if (Screen.width == 1920 && Screen.height == 1080)
        {
            if (numberOfDuplicationUpgrades < 3) { tails.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f); }
            if (numberOfDuplicationUpgrades == 3 || numberOfDuplicationUpgrades > 3) { tails.transform.localScale = new Vector3(0.70f, 0.70f, 0.70f); }
            if (numberOfDuplicationUpgrades > 8 || numberOfDuplicationUpgrades == 8) { tails.transform.localScale = new Vector3(0.60f, 0.60f, 0.60f); }
            if (numberOfDuplicationUpgrades == 10) { tails.transform.localScale = new Vector3(0.55f, 0.55f, 0.55f); }
            if (numberOfDuplicationUpgrades == 11 || numberOfDuplicationUpgrades > 11) { tails.transform.localScale = new Vector3(0.50f, 0.50f, 0.50f); }
            if (numberOfDuplicationUpgrades == 15 || numberOfDuplicationUpgrades > 15) { tails.transform.localScale = new Vector3(0.45f, 0.45f, 0.45f); }
            if (numberOfDuplicationUpgrades >= 18) { tails.transform.localScale = new Vector3(0.40f, 0.40f, 0.40f); }
        }
        else
        {
            if (numberOfDuplicationUpgrades < 3) { tails.transform.localScale = new Vector3(0.60f, 0.60f, 0.60f); }
            if (numberOfDuplicationUpgrades == 3 || numberOfDuplicationUpgrades > 3) { tails.transform.localScale = new Vector3(0.55f, 0.55f, 0.55f); }
            if (numberOfDuplicationUpgrades > 8 || numberOfDuplicationUpgrades == 8) { tails.transform.localScale = new Vector3(0.50f, 0.50f, 0.50f); }
            if (numberOfDuplicationUpgrades == 10) { tails.transform.localScale = new Vector3(0.47f, 0.47f, 0.47f); }
            if (numberOfDuplicationUpgrades == 11 || numberOfDuplicationUpgrades > 11) { tails.transform.localScale = new Vector3(0.46f, 0.46f, 0.46f); }
            if (numberOfDuplicationUpgrades == 15 || numberOfDuplicationUpgrades > 15) { tails.transform.localScale = new Vector3(0.43f, 0.43f, 0.43f); }
            if (numberOfDuplicationUpgrades >= 18) { tails.transform.localScale = new Vector3(0.41f, 0.41f, 0.41f); }
        }
        yield return new WaitForSeconds(AnimTime);
        tails.SetActive(true);
        StatsAll.tailsFlippedAmount += 1;
        tails.transform.SetParent(parent);
        ObjectPool.instance.ReturnTailsToPool(tails.gameObject);
    }

    IEnumerator ChoseTailsHitTails()
    {
        GameObject tails = ObjectPool.instance.GetHeadsFromPool();
        tails.transform.position = tranformPopUpHere.transform.position;
        tails.SetActive(false);

        tails.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = LocalizationStrings.tails + "+" + FormatCoins(MainButtonClick.coinsPerClick * (1 + AscendScreen.activeFlipperMiltiplier + Challenges.chall3Bonus + chall3CompletedBonus));

        if (Screen.width == 1920 && Screen.height == 1080)
        {
            if (numberOfDuplicationUpgrades < 3) { tails.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f); }
            if (numberOfDuplicationUpgrades == 3 || numberOfDuplicationUpgrades > 3) { tails.transform.localScale = new Vector3(0.70f, 0.70f, 0.70f); }
            if (numberOfDuplicationUpgrades > 8 || numberOfDuplicationUpgrades == 8) { tails.transform.localScale = new Vector3(0.60f, 0.60f, 0.60f); }
            if (numberOfDuplicationUpgrades == 10) { tails.transform.localScale = new Vector3(0.55f, 0.55f, 0.55f); }
            if (numberOfDuplicationUpgrades == 11 || numberOfDuplicationUpgrades > 11) { tails.transform.localScale = new Vector3(0.50f, 0.50f, 0.50f); }
            if (numberOfDuplicationUpgrades == 15 || numberOfDuplicationUpgrades > 15) { tails.transform.localScale = new Vector3(0.45f, 0.45f, 0.45f); }
            if (numberOfDuplicationUpgrades >= 18) { tails.transform.localScale = new Vector3(0.40f, 0.40f, 0.40f); }
        }
        else
        {
            if (numberOfDuplicationUpgrades < 3) { tails.transform.localScale = new Vector3(0.60f, 0.60f, 0.60f); }
            if (numberOfDuplicationUpgrades == 3 || numberOfDuplicationUpgrades > 3) { tails.transform.localScale = new Vector3(0.55f, 0.55f, 0.55f); }
            if (numberOfDuplicationUpgrades > 8 || numberOfDuplicationUpgrades == 8) { tails.transform.localScale = new Vector3(0.50f, 0.50f, 0.50f); }
            if (numberOfDuplicationUpgrades == 10) { tails.transform.localScale = new Vector3(0.47f, 0.47f, 0.47f); }
            if (numberOfDuplicationUpgrades == 11 || numberOfDuplicationUpgrades > 11) { tails.transform.localScale = new Vector3(0.46f, 0.46f, 0.46f); }
            if (numberOfDuplicationUpgrades == 15 || numberOfDuplicationUpgrades > 15) { tails.transform.localScale = new Vector3(0.43f, 0.43f, 0.43f); }
            if (numberOfDuplicationUpgrades >= 18) { tails.transform.localScale = new Vector3(0.41f, 0.41f, 0.41f); }
        }

        yield return new WaitForSeconds(AnimTime);
        tails.SetActive(true);
        StatsAll.tailsFlippedAmount += 1;
        tails.transform.SetParent(parent);
        ObjectPool.instance.ReturnHeadsToPool(tails.gameObject);
    }

    IEnumerator ChoseTailsHitHeads()
    {
        GameObject heads = ObjectPool.instance.GetTailsFromPool();
        heads.transform.position = tranformPopUpHere.transform.position;
        heads.SetActive(false);
        heads.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = LocalizationStrings.heads+ "+0" + LocalizationStrings.coins;
        if (Screen.width == 1920 && Screen.height == 1080)
        {
            if (numberOfDuplicationUpgrades < 3) { heads.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f); }
            if (numberOfDuplicationUpgrades == 3 || numberOfDuplicationUpgrades > 3) { heads.transform.localScale = new Vector3(0.70f, 0.70f, 0.70f); }
            if (numberOfDuplicationUpgrades > 8 || numberOfDuplicationUpgrades == 8) { heads.transform.localScale = new Vector3(0.60f, 0.60f, 0.60f); }
            if (numberOfDuplicationUpgrades == 10) { heads.transform.localScale = new Vector3(0.55f, 0.55f, 0.55f); }
            if (numberOfDuplicationUpgrades == 11 || numberOfDuplicationUpgrades > 11) { heads.transform.localScale = new Vector3(0.50f, 0.50f, 0.50f); }
            if (numberOfDuplicationUpgrades == 15 || numberOfDuplicationUpgrades > 15) { heads.transform.localScale = new Vector3(0.45f, 0.45f, 0.45f); }
            if (numberOfDuplicationUpgrades >= 18) { heads.transform.localScale = new Vector3(0.40f, 0.40f, 0.40f); }
        }
        else
        {
            if (numberOfDuplicationUpgrades < 3) { heads.transform.localScale = new Vector3(0.60f, 0.60f, 0.60f); }
            if (numberOfDuplicationUpgrades == 3 || numberOfDuplicationUpgrades > 3) { heads.transform.localScale = new Vector3(0.55f, 0.55f, 0.55f); }
            if (numberOfDuplicationUpgrades > 8 || numberOfDuplicationUpgrades == 8) { heads.transform.localScale = new Vector3(0.50f, 0.50f, 0.50f); }
            if (numberOfDuplicationUpgrades == 10) { heads.transform.localScale = new Vector3(0.47f, 0.47f, 0.47f); }
            if (numberOfDuplicationUpgrades == 11 || numberOfDuplicationUpgrades > 11) { heads.transform.localScale = new Vector3(0.46f, 0.46f, 0.46f); }
            if (numberOfDuplicationUpgrades == 15 || numberOfDuplicationUpgrades > 15) { heads.transform.localScale = new Vector3(0.43f, 0.43f, 0.43f); }
            if (numberOfDuplicationUpgrades >= 18) { heads.transform.localScale = new Vector3(0.41f, 0.41f, 0.41f); }
        }
        yield return new WaitForSeconds(AnimTime);
        heads.SetActive(true);
        StatsAll.headsFlippedAmount += 1;
        heads.transform.SetParent(parent);
        ObjectPool.instance.ReturnTailsToPool(heads.gameObject);
    }
    IEnumerator playerDidGetLucky()
    {
        GameObject lucky = ObjectPool.instance.GetLuckyFromPool();
        lucky.transform.position = tranformPopUpHere.transform.position;
        lucky.SetActive(false);

        lucky.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = LocalizationStrings.luckyCoin + "+" + FormatCoins((coinsPerClick * (1 + AscendScreen.activeFlipperMiltiplier + Challenges.chall3Bonus + chall3CompletedBonus)) * (5 + AscendScreen.luckyCoinMiltiplier));

        if (Screen.width == 1920 && Screen.height == 1080)
        {
            if (numberOfDuplicationUpgrades < 3) { lucky.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f); }
            if (numberOfDuplicationUpgrades == 3 || numberOfDuplicationUpgrades > 3) { lucky.transform.localScale = new Vector3(0.70f, 0.70f, 0.70f); }
            if (numberOfDuplicationUpgrades > 8 || numberOfDuplicationUpgrades == 8) { lucky.transform.localScale = new Vector3(0.60f, 0.60f, 0.60f); }
            if (numberOfDuplicationUpgrades == 10) { lucky.transform.localScale = new Vector3(0.55f, 0.55f, 0.55f); }
            if (numberOfDuplicationUpgrades == 11 || numberOfDuplicationUpgrades > 11) { lucky.transform.localScale = new Vector3(0.50f, 0.50f, 0.50f); }
            if (numberOfDuplicationUpgrades == 15 || numberOfDuplicationUpgrades > 15) { lucky.transform.localScale = new Vector3(0.45f, 0.45f, 0.45f); }
            if (numberOfDuplicationUpgrades >= 18) { lucky.transform.localScale = new Vector3(0.40f, 0.40f, 0.40f); }
        }
        else
        {
            if (numberOfDuplicationUpgrades < 3) { lucky.transform.localScale = new Vector3(0.60f, 0.60f, 0.60f); }
            if (numberOfDuplicationUpgrades == 3 || numberOfDuplicationUpgrades > 3) { lucky.transform.localScale = new Vector3(0.55f, 0.55f, 0.55f); }
            if (numberOfDuplicationUpgrades > 8 || numberOfDuplicationUpgrades == 8) { lucky.transform.localScale = new Vector3(0.50f, 0.50f, 0.50f); }
            if (numberOfDuplicationUpgrades == 10) { lucky.transform.localScale = new Vector3(0.47f, 0.47f, 0.47f); }
            if (numberOfDuplicationUpgrades == 11 || numberOfDuplicationUpgrades > 11) { lucky.transform.localScale = new Vector3(0.46f, 0.46f, 0.46f); }
            if (numberOfDuplicationUpgrades == 15 || numberOfDuplicationUpgrades > 15) { lucky.transform.localScale = new Vector3(0.43f, 0.43f, 0.43f); }
            if (numberOfDuplicationUpgrades >= 18) { lucky.transform.localScale = new Vector3(0.41f, 0.41f, 0.41f); }
        }

        if (AscendScreen.boughtSpecialLUCKER == 1)
        {
            int random = Random.Range(1, 101);
            if (random < 6)
            {
                AscendScreen.hitEvenLuckerCoin += 1;
                GlobalCoins.CoinCount += coinsPerClick * (50);
            }
        }
        yield return new WaitForSeconds(AnimTime);
        luckySound.PlayOneShot(luckyFlip);
        lucky.SetActive(true);
        StatsAll.luckyCoinsAmount += 1;
        lucky.transform.SetParent(parent);
        ObjectPool.instance.ReturnLuckyToPool(lucky.gameObject);
    }

    IEnumerator flipRandomChanceHeads()
    {
        yield return new WaitForSeconds(AnimTime);
        GlobalCoins.CoinCount += coinsPerClick * ( 1 + AscendScreen.activeFlipperMiltiplier + Challenges.chall3Bonus + chall3CompletedBonus);
        int random = Random.Range(1, 101); 
        if(random < 6 && AscendScreen.isActivePilePurchased == 1)
        { 
          PileOfCoinsMechanics.PileOfCoinsAmount1 += coinsPerClick; 
          PileOfCoinsMechanics.PileOfCoinsAmount2 += coinsPerClick; 
          PileOfCoinsMechanics.PileOfCoinsAmount3 += coinsPerClick; 
          PileOfCoinsMechanics.PileOfCoinsAmount4 += coinsPerClick;
          PileOfCoinsMechanics.PileOfCoinsAmount5 += coinsPerClick;

            pileAmountText1.text =  FormatCoins(PileOfCoinsMechanics.PileOfCoinsAmount1);
            pileAmountText2.text = FormatCoins(PileOfCoinsMechanics.PileOfCoinsAmount1);
            pileAmountText3.text = FormatCoins(PileOfCoinsMechanics.PileOfCoinsAmount1);
            pileAmountText4.text = FormatCoins(PileOfCoinsMechanics.PileOfCoinsAmount1);
            pileAmountText5.text = FormatCoins(PileOfCoinsMechanics.PileOfCoinsAmount1);
        }
    }

    IEnumerator flipRandomChanceTails()
    {
        yield return new WaitForSeconds(AnimTime);
        GlobalCoins.CoinCount += 0;
    }
    IEnumerator flipRandomChanceHeads1()
    {
        yield return new WaitForSeconds(AnimTime);
        GlobalCoins.CoinCount += 0;
    }

    IEnumerator flipRandomChanceTails1()
    {
        yield return new WaitForSeconds(AnimTime);
        GlobalCoins.CoinCount += coinsPerClick * (1 + AscendScreen.activeFlipperMiltiplier + Challenges.chall3Bonus + chall3CompletedBonus);
        int random = Random.Range(1, 101);

        if (random < 6 && AscendScreen.isActivePilePurchased == 1)
        {
            PileOfCoinsMechanics.PileOfCoinsAmount1 += coinsPerClick;
            PileOfCoinsMechanics.PileOfCoinsAmount2 += coinsPerClick;
            PileOfCoinsMechanics.PileOfCoinsAmount3 += coinsPerClick; 
            PileOfCoinsMechanics.PileOfCoinsAmount4 += coinsPerClick;
            PileOfCoinsMechanics.PileOfCoinsAmount5 += coinsPerClick;

            pileAmountText1.text = FormatCoins(PileOfCoinsMechanics.PileOfCoinsAmount1);
            pileAmountText2.text = FormatCoins(PileOfCoinsMechanics.PileOfCoinsAmount1);
            pileAmountText3.text = FormatCoins(PileOfCoinsMechanics.PileOfCoinsAmount1);
            pileAmountText4.text = FormatCoins(PileOfCoinsMechanics.PileOfCoinsAmount1);
            pileAmountText5.text = FormatCoins(PileOfCoinsMechanics.PileOfCoinsAmount1);
        }
    }

    IEnumerator playerGotLucky()
    {
        yield return new WaitForSeconds(AnimTime);
        GlobalCoins.CoinCount += (coinsPerClick * (1 + AscendScreen.activeFlipperMiltiplier + Challenges.chall3Bonus + chall3CompletedBonus)) * (5 + AscendScreen.luckyCoinMiltiplier);
    }

    public AudioSource UpgradeSound1;
    public AudioSource UpgradeSound2;

    public void UpgradeClickSound()
    {
        int generateRandomUpgradeSound = Random.Range(1, 3);
        if (generateRandomUpgradeSound == 1)
        {
            UpgradeSound1.Play();
        }
        else if (generateRandomUpgradeSound == 2)
        {
            UpgradeSound2.Play();
        }
    }

    public GameObject muteFlipperHover1;
    public GameObject muteFlipperHover2;
    public GameObject muteFlipperHover3;
    public GameObject muteFlipperHover4;
    public GameObject muteFlipperHover5;
    public GameObject muteFlipperHover6;
    public GameObject muteFlipperHover7;
    public GameObject muteFlipperHover8;
    public GameObject muteFlipperHover9;
    public GameObject muteFlipperHover10;
    public GameObject muteFlipperHover11;
    public GameObject muteFlipperHover12;
    public GameObject muteFlipperHover13;
    public GameObject muteFlipperHover14;
    public GameObject muteFlipperHover15;
    public GameObject muteFlipperHover16;
    public GameObject muteFlipperHover17;
    public GameObject muteFlipperHover18;
    public GameObject muteFlipperHover19;
    public GameObject muteFlipperHover20;
    public GameObject muteFlipperHover21;

    #region duplicate
    public GoldenFlipsButton goldenFlipsScript;

    public void DuplicateCoinFlipper()
    {
        if (GlobalCoins.CoinCount >= DuplicateCoin.duplicatePrice)
        {
            DuplicateCoinFlipps.SetActive(true);
            UpgradeClickSound();

            numberOfDuplicationUpgrades += 1;
            goldenFlipsScript.SetPosAndScale();
            GlobalCoins.CoinCount -= DuplicateCoin.duplicatePrice;
            DuplicateCoin.duplicatePrice *= 5.4f;
            DuplicateCoin.turnOffDuplicateButton = true;

            if (numberOfDuplicationUpgrades == 1)
            {
                empty1.transform.localPosition = new Vector3(580f, -12, 0f);
                empty1.transform.localScale = new Vector3(1.107344f, 1.107344f, 1.107344f);
                empty2.SetActive(true);
                empty2.transform.localPosition = new Vector3(12, -12, 0f);
                empty2.transform.localScale = new Vector3(1.107344f, 1.107344f, 1.107344f);
            }
            if (numberOfDuplicationUpgrades == 2)
            {
                empty1.transform.localPosition = new Vector3(12f, 102, 0f);
                empty1.transform.localScale = new Vector3(1.107344f, 1.107344f, 1.107344f);
                empty2.transform.localPosition = new Vector3(580f, 102, 0f);
                empty2.transform.localScale = new Vector3(1.107344f, 1.107344f, 1.107344f);
                empty3.SetActive(true);
                empty3.transform.localPosition = new Vector3(235, -218, 0f);
                empty3.transform.localScale = new Vector3(1.107344f, 1.107344f, 1.107344f);
            }
            if (numberOfDuplicationUpgrades == 3)
            {
                empty1.transform.localPosition = new Vector3(12f, 145, 0f);
                empty1.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
                empty2.transform.localPosition = new Vector3(580, 145, 0f);
                empty2.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
                empty3.transform.localPosition = new Vector3(12, -240, 0f);
                empty3.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
                empty4.SetActive(true);
                empty4.transform.localPosition = new Vector3(580, -240, 0f);
                empty4.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            }
            if (numberOfDuplicationUpgrades == 4)
            {
                empty1.transform.localPosition = new Vector3(12f, 145, 0f);
                empty1.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
                empty2.transform.localPosition = new Vector3(580, 145, 0f);
                empty2.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
                empty3.transform.localPosition = new Vector3(12, -240, 0f);
                empty3.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
                empty4.transform.localPosition = new Vector3(580, -240, 0f);
                empty4.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
                empty5.SetActive(true);
                empty5.transform.localPosition = new Vector3(285, -48f, 0f);
                empty5.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            }
            if (numberOfDuplicationUpgrades == 5)
            {
                empty1.transform.localPosition = new Vector3(-156f, 145, 0);
                empty1.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
                empty2.transform.localPosition = new Vector3(283, 145, 0);
                empty2.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
                empty3.transform.localPosition = new Vector3(737, 145, 0);
                empty3.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
                empty4.transform.localPosition = new Vector3(-156, -240, 0);
                empty4.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
                empty5.transform.localPosition = new Vector3(283, -240, 0);
                empty5.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
                empty6.SetActive(true);
                empty6.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
                empty6.transform.localPosition = new Vector3(737, -240, 0);
            }
            if (numberOfDuplicationUpgrades == 6)
            {
                empty1.transform.localPosition = new Vector3(-152f, 145, 0);
                empty1.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
                empty2.transform.localPosition = new Vector3(136, 145, 0);
                empty2.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
                empty3.transform.localPosition = new Vector3(436, 145, 0);
                empty3.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
                empty4.transform.localPosition = new Vector3(736, 145, 0);
                empty4.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
                empty5.transform.localPosition = new Vector3(-27, -225, 0);
                empty5.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
                empty6.transform.localPosition = new Vector3(274, -225, 0);
                empty6.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
                empty7.SetActive(true);
                empty7.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
                empty7.transform.localPosition = new Vector3(578, -225, 0);
            }
            if (numberOfDuplicationUpgrades == 7)
            {
                empty1.transform.localPosition = new Vector3(-152f, 145, 0);
                empty1.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
                empty2.transform.localPosition = new Vector3(136, 145, 0);
                empty2.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
                empty3.transform.localPosition = new Vector3(436, 145, 0);
                empty3.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
                empty4.transform.localPosition = new Vector3(736, 145, 0);
                empty4.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
                empty5.transform.localPosition = new Vector3(-152, -225, 0);
                empty5.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
                empty6.transform.localPosition = new Vector3(136, -225, 0);
                empty6.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
                empty7.transform.localPosition = new Vector3(436, -225, 0);
                empty7.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
                empty8.SetActive(true);
                empty8.transform.localPosition = new Vector3(736, -225, 0);
                empty8.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            }
            if (numberOfDuplicationUpgrades == 8)
            {
               
                empty1.transform.localPosition = new Vector3(-152f, 154, 0);
                empty1.transform.localScale = new Vector3(0.7429143f, 0.7429143f, 0.7429143f);
                empty2.transform.localPosition = new Vector3(136, 154, 0);
                empty2.transform.localScale = new Vector3(0.7429143f, 0.7429143f, 0.7429143f);
                empty3.transform.localPosition = new Vector3(436, 154, 0);
                empty3.transform.localScale = new Vector3(0.7429143f, 0.7429143f, 0.7429143f);
                empty4.transform.localPosition = new Vector3(736, 154, 0);
                empty4.transform.localScale = new Vector3(0.7429143f, 0.7429143f, 0.7429143f);
                empty5.transform.localPosition = new Vector3(-228, -206, 0);
                empty5.transform.localScale = new Vector3(0.7429143f, 0.7429143f, 0.7429143f);
                empty6.transform.localPosition = new Vector3(35, -206, 0);
                empty6.transform.localScale = new Vector3(0.7429143f, 0.7429143f, 0.7429143f);
                empty7.transform.localPosition = new Vector3(308, -206, 0);
                empty7.transform.localScale = new Vector3(0.7429143f, 0.7429143f, 0.7429143f);
                empty8.transform.localPosition = new Vector3(571, -206, 0);
                empty8.transform.localScale = new Vector3(0.7429143f, 0.7429143f, 0.7429143f);
                empty9.SetActive(true);
                empty9.transform.localPosition = new Vector3(834, -206, 0);
                empty9.transform.localScale = new Vector3(0.7429143f, 0.74291436f, 0.7429143f);
            }
            if (numberOfDuplicationUpgrades == 9)
            {
               
                empty1.transform.localPosition = new Vector3(-228f, 154, 0);
                empty1.transform.localScale = new Vector3(0.7429143f, 0.74291436f, 0.7429143f);
                empty2.transform.localPosition = new Vector3(35, 154, 0);
                empty2.transform.localScale = new Vector3(0.7429143f, 0.74291436f, 0.7429143f);
                empty3.transform.localPosition = new Vector3(308, 154, 0);
                empty3.transform.localScale = new Vector3(0.7429143f, 0.74291436f, 0.7429143f);
                empty4.transform.localPosition = new Vector3(571, 154, 0);
                empty4.transform.localScale = new Vector3(0.7429143f, 0.74291436f, 0.7429143f);
                empty5.transform.localPosition = new Vector3(834, 154, 0);
                empty5.transform.localScale = new Vector3(0.7429143f, 0.74291436f, 0.7429143f);
                empty6.transform.localPosition = new Vector3(-228, -206, 0);
                empty6.transform.localScale = new Vector3(0.7429143f, 0.74291436f, 0.7429143f);
                empty7.transform.localPosition = new Vector3(35, -206, 0);
                empty7.transform.localScale = new Vector3(0.7429143f, 0.74291436f, 0.7429143f);
                empty8.transform.localPosition = new Vector3(308, -206, 0);
                empty8.transform.localScale = new Vector3(0.7429143f, 0.74291436f, 0.7429143f);
                empty9.transform.localPosition = new Vector3(571, -206, 0);
                empty9.transform.localScale = new Vector3(0.7429143f, 0.74291436f, 0.7429143f);
                empty10.SetActive(true);
                empty10.transform.localPosition = new Vector3(834, -206, 0);
                empty10.transform.localScale = new Vector3(0.7429143f, 0.74291436f, 0.7429143f);
            }
            if (numberOfDuplicationUpgrades == 10)
            {

                empty1.transform.localPosition = new Vector3(-185f, 173, 0);
                empty1.transform.localScale = new Vector3(0.6641134f, 0.6641134f, 0.6641134f);
                empty2.transform.localPosition = new Vector3(132, 173, 0);
                empty2.transform.localScale = new Vector3(0.6641134f, 0.6641134f, 0.6641134f);
                empty3.transform.localPosition = new Vector3(453, 173, 0);
                empty3.transform.localScale = new Vector3(0.6641134f, 0.6641134f, 0.6641134f);
                empty4.transform.localPosition = new Vector3(767, 173, 0);
                empty4.transform.localScale = new Vector3(0.6641134f, 0.6641134f, 0.6641134f);
                empty5.transform.localPosition = new Vector3(-35, -70, 0);
                empty5.transform.localScale = new Vector3(0.6641134f, 0.6641134f, 0.6641134f);
                empty6.transform.localPosition = new Vector3(287, -70, 0);
                empty6.transform.localScale = new Vector3(0.6641134f, 0.6641134f, 0.6641134f);
                empty7.transform.localPosition = new Vector3(606, -70, 0);
                empty7.transform.localScale = new Vector3(0.6641134f, 0.6641134f, 0.6641134f);
                empty8.transform.localPosition = new Vector3(-185f, -305, 0);
                empty8.transform.localScale = new Vector3(0.6641134f, 0.6641134f, 0.6641134f);
                empty9.transform.localPosition = new Vector3(132, -305, 0);
                empty9.transform.localScale = new Vector3(0.6641134f, 0.6641134f, 0.6641134f);
                empty10.transform.localPosition = new Vector3(453, -305, 0);
                empty10.transform.localScale = new Vector3(0.6641134f, 0.6641134f, 0.6641134f);
                empty11.SetActive(true);
                empty11.transform.localPosition = new Vector3(767, -305, 0);
                empty11.transform.localScale = new Vector3(0.6641134f, 0.6641134f, 0.6641134f);
            }
            if (numberOfDuplicationUpgrades == 11)
            {
               
                empty1.transform.localPosition = new Vector3(-207f, 200, 0);
                empty1.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty2.transform.localPosition = new Vector3(43, 200, 0);
                empty2.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty3.transform.localPosition = new Vector3(293, 200, 0);
                empty3.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty4.transform.localPosition = new Vector3(543, 200, 0);
                empty4.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty5.transform.localPosition = new Vector3(793, 200, 0);
                empty5.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty6.transform.localPosition = new Vector3(-208, -50, 0);
                empty6.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty7.transform.localPosition = new Vector3(43, -50, 0);
                empty7.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty8.transform.localPosition = new Vector3(293, -50, 0);
                empty8.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty9.transform.localPosition = new Vector3(543, -50, 0);
                empty9.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty10.transform.localPosition = new Vector3(793, -50, 0);
                empty10.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty11.transform.localPosition = new Vector3(-208, -300, 0);
                empty11.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty12.SetActive(true);
                empty12.transform.localPosition = new Vector3(43, -300, 0);
                empty12.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            }
            if (numberOfDuplicationUpgrades == 12)
            {
             
                empty1.transform.localPosition = new Vector3(-207f, 200, 0);
                empty1.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty2.transform.localPosition = new Vector3(43, 200, 0);
                empty2.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty3.transform.localPosition = new Vector3(293, 200, 0);
                empty3.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty4.transform.localPosition = new Vector3(543, 200, 0);
                empty4.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty5.transform.localPosition = new Vector3(793, 200, 0);
                empty5.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty6.transform.localPosition = new Vector3(-208, -50, 0);
                empty6.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty7.transform.localPosition = new Vector3(43, -50, 0);
                empty7.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty8.transform.localPosition = new Vector3(293, -50, 0);
                empty8.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty9.transform.localPosition = new Vector3(543, -50, 0);
                empty9.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty10.transform.localPosition = new Vector3(793, -50, 0);
                empty10.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty11.transform.localPosition = new Vector3(-208, -300, 0);
                empty11.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty12.transform.localPosition = new Vector3(43, -300, 0);
                empty12.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty13.SetActive(true);
                empty13.transform.localPosition = new Vector3(293, -300, 0);
                empty13.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            }
            if (numberOfDuplicationUpgrades == 13)
            {
              
                empty1.transform.localPosition = new Vector3(-207f, 200, 0);
                empty1.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty2.transform.localPosition = new Vector3(43, 200, 0);
                empty2.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty3.transform.localPosition = new Vector3(293, 200, 0);
                empty3.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty4.transform.localPosition = new Vector3(543, 200, 0);
                empty4.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty5.transform.localPosition = new Vector3(793, 200, 0);
                empty5.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty6.transform.localPosition = new Vector3(-208, -50, 0);
                empty6.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty7.transform.localPosition = new Vector3(43, -50, 0);
                empty7.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty8.transform.localPosition = new Vector3(293, -50, 0);
                empty8.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty9.transform.localPosition = new Vector3(543, -50, 0);
                empty9.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty10.transform.localPosition = new Vector3(793, -50, 0);
                empty10.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty11.transform.localPosition = new Vector3(-208, -300, 0);
                empty11.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty12.transform.localPosition = new Vector3(43, -300, 0);
                empty12.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty13.transform.localPosition = new Vector3(293, -300, 0);
                empty13.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty14.SetActive(true);
                empty14.transform.localPosition = new Vector3(543, -300, 0);
                empty14.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            }
            if (numberOfDuplicationUpgrades == 14)
            {
               
                empty1.transform.localPosition = new Vector3(-207f, 200, 0);
                empty1.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty2.transform.localPosition = new Vector3(43, 200, 0);
                empty2.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty3.transform.localPosition = new Vector3(293, 200, 0);
                empty3.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty4.transform.localPosition = new Vector3(543, 200, 0);
                empty4.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty5.transform.localPosition = new Vector3(793, 200, 0);
                empty5.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty6.transform.localPosition = new Vector3(-208, -50, 0);
                empty6.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty7.transform.localPosition = new Vector3(43, -50, 0);
                empty7.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty8.transform.localPosition = new Vector3(293, -50, 0);
                empty8.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty9.transform.localPosition = new Vector3(543, -50, 0);
                empty9.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty10.transform.localPosition = new Vector3(793, -50, 0);
                empty10.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty11.transform.localPosition = new Vector3(-208, -300, 0);
                empty11.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty12.transform.localPosition = new Vector3(43, -300, 0);
                empty12.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty13.transform.localPosition = new Vector3(293, -300, 0);
                empty13.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty14.transform.localPosition = new Vector3(543, -300, 0);
                empty14.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty15.SetActive(true);
                empty15.transform.localPosition = new Vector3(793, -300, 0);
                empty15.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            }
            if (numberOfDuplicationUpgrades == 15)
            {
          

                empty1.transform.localPosition = new Vector3(-210f, 200, 0);
                empty1.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty2.transform.localPosition = new Vector3(-10, 200, 0);
                empty2.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty3.transform.localPosition = new Vector3(190, 200, 0);
                empty3.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty4.transform.localPosition = new Vector3(390, 200, 0);
                empty4.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty5.transform.localPosition = new Vector3(590, 200, 0);
                empty5.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty6.transform.localPosition = new Vector3(790, 200, 0);
                empty6.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty7.transform.localPosition = new Vector3(-210, -50, 0);
                empty7.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty8.transform.localPosition = new Vector3(-10, -50, 0);
                empty8.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty9.transform.localPosition = new Vector3(190, -50, 0);
                empty9.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty10.transform.localPosition = new Vector3(390, -50, 0);
                empty10.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty11.transform.localPosition = new Vector3(590, -50, 0);
                empty11.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty12.transform.localPosition = new Vector3(790f, -50, 0);
                empty12.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty13.transform.localPosition = new Vector3(-210f, -300, 0);
                empty13.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty14.transform.localPosition = new Vector3(-10f, -300, 0);
                empty14.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty15.transform.localPosition = new Vector3(190f, -300, 0);
                empty15.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty16.SetActive(true);
                empty16.transform.localPosition = new Vector3(390, -300, 0);
                empty16.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            }
            if (numberOfDuplicationUpgrades == 16)
            {
                empty1.transform.localPosition = new Vector3(-210f, 200, 0);
                empty1.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty2.transform.localPosition = new Vector3(-10, 200, 0);
                empty2.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty3.transform.localPosition = new Vector3(190, 200, 0);
                empty3.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty4.transform.localPosition = new Vector3(390, 200, 0);
                empty4.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty5.transform.localPosition = new Vector3(590, 200, 0);
                empty5.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty6.transform.localPosition = new Vector3(790, 200, 0);
                empty6.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty7.transform.localPosition = new Vector3(-210, -50, 0);
                empty7.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty8.transform.localPosition = new Vector3(-10, -50, 0);
                empty8.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty9.transform.localPosition = new Vector3(190, -50, 0);
                empty9.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty10.transform.localPosition = new Vector3(390, -50, 0);
                empty10.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty11.transform.localPosition = new Vector3(590, -50, 0);
                empty11.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty12.transform.localPosition = new Vector3(790f, -50, 0);
                empty12.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty13.transform.localPosition = new Vector3(-210f, -300, 0);
                empty13.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty14.transform.localPosition = new Vector3(-10f, -300, 0);
                empty14.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty15.transform.localPosition = new Vector3(190f, -300, 0);
                empty15.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty16.transform.localPosition = new Vector3(390, -300, 0);
                empty16.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty17.SetActive(true);
                empty17.transform.localPosition = new Vector3(590, -300, 0);
                empty17.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            }
            if (numberOfDuplicationUpgrades == 17)
            {
                empty1.transform.localPosition = new Vector3(-210f, 200, 0);
                empty1.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty2.transform.localPosition = new Vector3(-10, 200, 0);
                empty2.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty3.transform.localPosition = new Vector3(190, 200, 0);
                empty3.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty4.transform.localPosition = new Vector3(390, 200, 0);
                empty4.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty5.transform.localPosition = new Vector3(590, 200, 0);
                empty5.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty6.transform.localPosition = new Vector3(790, 200, 0);
                empty6.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty7.transform.localPosition = new Vector3(-210, -50, 0);
                empty7.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty8.transform.localPosition = new Vector3(-10, -50, 0);
                empty8.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty9.transform.localPosition = new Vector3(190, -50, 0);
                empty9.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty10.transform.localPosition = new Vector3(390, -50, 0);
                empty10.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty11.transform.localPosition = new Vector3(590, -50, 0);
                empty11.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty12.transform.localPosition = new Vector3(790f, -50, 0);
                empty12.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty13.transform.localPosition = new Vector3(-210f, -300, 0);
                empty13.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty14.transform.localPosition = new Vector3(-10f, -300, 0);
                empty14.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty15.transform.localPosition = new Vector3(190f, -300, 0);
                empty15.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty16.transform.localPosition = new Vector3(390, -300, 0);
                empty16.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty17.transform.localPosition = new Vector3(590, -300, 0);
                empty17.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
                empty18.SetActive(true);
                empty18.transform.localPosition = new Vector3(790, -300, 0);
                empty18.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            }
            if (numberOfDuplicationUpgrades == 18)
            {
                empty1.transform.localPosition = new Vector3(-221f, 220, 0);
                empty1.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty2.transform.localPosition = new Vector3(-51, 220, 0);
                empty2.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty3.transform.localPosition = new Vector3(119, 220, 0);
                empty3.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty4.transform.localPosition = new Vector3(289, 220, 0);
                empty4.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty5.transform.localPosition = new Vector3(459, 220, 0);
                empty5.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty6.transform.localPosition = new Vector3(629, 220, 0);
                empty6.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty7.transform.localPosition = new Vector3(799, 220, 0);
                empty7.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty8.transform.localPosition = new Vector3(-221, -40, 0);
                empty8.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty9.transform.localPosition = new Vector3(-50, -40, 0);
                empty9.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty10.transform.localPosition = new Vector3(119, -40, 0);
                empty10.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty11.transform.localPosition = new Vector3(289, -40, 0);
                empty11.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty12.transform.localPosition = new Vector3(459f, -40, 0);
                empty12.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty13.transform.localPosition = new Vector3(629f, -40, 0);
                empty13.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty14.transform.localPosition = new Vector3(799f, -40, 0);
                empty14.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty15.transform.localPosition = new Vector3(-221f, -300, 0);
                empty15.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty16.transform.localPosition = new Vector3(-51, -300, 0);
                empty16.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty17.transform.localPosition = new Vector3(119, -300, 0);
                empty17.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty18.transform.localPosition = new Vector3(289, -300, 0);
                empty18.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty19.SetActive(true);
                empty19.transform.localPosition = new Vector3(459, -300, 0);
                empty19.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            }
            if (numberOfDuplicationUpgrades == 19)
            {
                empty1.transform.localPosition = new Vector3(-221f, 220, 0);
                empty1.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty2.transform.localPosition = new Vector3(-51, 220, 0);
                empty2.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty3.transform.localPosition = new Vector3(119, 220, 0);
                empty3.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty4.transform.localPosition = new Vector3(289, 220, 0);
                empty4.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty5.transform.localPosition = new Vector3(459, 220, 0);
                empty5.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty6.transform.localPosition = new Vector3(629, 220, 0);
                empty6.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty7.transform.localPosition = new Vector3(799, 220, 0);
                empty7.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty8.transform.localPosition = new Vector3(-221, -40, 0);
                empty8.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty9.transform.localPosition = new Vector3(-50, -40, 0);
                empty9.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty10.transform.localPosition = new Vector3(119, -40, 0);
                empty10.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty11.transform.localPosition = new Vector3(289, -40, 0);
                empty11.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty12.transform.localPosition = new Vector3(459f, -40, 0);
                empty12.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty13.transform.localPosition = new Vector3(629f, -40, 0);
                empty13.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty14.transform.localPosition = new Vector3(799f, -40, 0);
                empty14.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty15.transform.localPosition = new Vector3(-221f, -300, 0);
                empty15.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty16.transform.localPosition = new Vector3(-51, -300, 0);
                empty16.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty17.transform.localPosition = new Vector3(119, -300, 0);
                empty17.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty18.transform.localPosition = new Vector3(289, -300, 0);
                empty18.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty19.transform.localPosition = new Vector3(459, -300, 0);
                empty19.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty20.SetActive(true);
                empty20.transform.localPosition = new Vector3(629, -300, 0);
                empty20.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            }
            if (numberOfDuplicationUpgrades == 20)
            {
                empty1.transform.localPosition = new Vector3(-221f, 220, 0);
                empty1.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty2.transform.localPosition = new Vector3(-51, 220, 0);
                empty2.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty3.transform.localPosition = new Vector3(119, 220, 0);
                empty3.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty4.transform.localPosition = new Vector3(289, 220, 0);
                empty4.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty5.transform.localPosition = new Vector3(459, 220, 0);
                empty5.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty6.transform.localPosition = new Vector3(629, 220, 0);
                empty6.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty7.transform.localPosition = new Vector3(799, 220, 0);
                empty7.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty8.transform.localPosition = new Vector3(-221, -40, 0);
                empty8.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty9.transform.localPosition = new Vector3(-50, -40, 0);
                empty9.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty10.transform.localPosition = new Vector3(119, -40, 0);
                empty10.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty11.transform.localPosition = new Vector3(289, -40, 0);
                empty11.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty12.transform.localPosition = new Vector3(459f, -40, 0);
                empty12.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty13.transform.localPosition = new Vector3(629f, -40, 0);
                empty13.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty14.transform.localPosition = new Vector3(799f, -40, 0);
                empty14.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty15.transform.localPosition = new Vector3(-221f, -300, 0);
                empty15.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty16.transform.localPosition = new Vector3(-51, -300, 0);
                empty16.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty17.transform.localPosition = new Vector3(119, -300, 0);
                empty17.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty18.transform.localPosition = new Vector3(289, -300, 0);
                empty18.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty19.transform.localPosition = new Vector3(459, -300, 0);
                empty19.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty20.transform.localPosition = new Vector3(629, -300, 0);
                empty20.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                empty21.SetActive(true);
                empty21.transform.localPosition = new Vector3(799, -300, 0);
                empty21.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
                DuplicateCoinFlipps.SetActive(false);
            }

        }
    }

    #endregion

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
}
