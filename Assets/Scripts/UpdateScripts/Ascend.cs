using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ascend : MonoBehaviour
{
    public Challenges challScript;


    public float waitTime;
    public int setAutoFlipped = 0;

    public GameObject chooseToAscend;
    public GameObject ascensionScreen;

    public GameObject hideMuteFlipperHoverOver1;
    public GameObject hideMuteFlipperHoverOver2;
    public GameObject hideMuteFlipperHoverOver3;
    public GameObject hideMuteFlipperHoverOver4;
    public GameObject hideMuteFlipperHoverOver5;
    public GameObject hideMuteFlipperHoverOver6;
    public GameObject hideMuteFlipperHoverOver7;
    public GameObject hideMuteFlipperHoverOver8;
    public GameObject hideMuteFlipperHoverOver9;
    public GameObject hideMuteFlipperHoverOver10;
    public GameObject hideMuteFlipperHoverOver11;
    public GameObject hideMuteFlipperHoverOver12;
    public GameObject hideMuteFlipperHoverOver13;
    public GameObject hideMuteFlipperHoverOver14;
    public GameObject hideMuteFlipperHoverOver15;
    public GameObject hideMuteFlipperHoverOver16;
    public GameObject hideMuteFlipperHoverOver17;
    public GameObject hideMuteFlipperHoverOver18;
    public GameObject hideMuteFlipperHoverOver19;
    public GameObject hideMuteFlipperHoverOver20;
    public GameObject hideMuteFlipperHoverOver21;

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

    public GameObject specialFlipper1;
    public GameObject specialFlipper2;
    public GameObject specialFlipper3;
    public GameObject specialFlipper4;
    public GameObject specialFlipper5;
    public GameObject specialFlipper6;
    public GameObject specialFlipper7;
    public GameObject specialFlipper8;
    public GameObject specialFlipper9;
    public GameObject specialFlipper10;
    public GameObject specialFlipper11;
    public GameObject specialFlipper12;
    public GameObject specialFlipper13;
    public GameObject specialFlipper14;
    public GameObject specialFlipper15;
    public GameObject specialFlipper16;
    public GameObject specialFlipper17;
    public GameObject specialFlipper18;
    public GameObject specialFlipper19;
    public GameObject specialFlipper20;
    public GameObject specialFlipper21;

    public GameObject justViewInflationScreen;

    public GameObject viewScreenUpgrade1;
    public GameObject viewScreenUpgrade2;
    public GameObject viewScreenUpgrade3;
    public GameObject viewScreenUpgrade4;
    public GameObject viewScreenUpgrade5;
    public GameObject viewScreenUpgrade6;
    public GameObject viewScreenUpgrade7;
    public GameObject viewScreenUpgrade8;
    public GameObject viewScreenUpgrade9;
    public GameObject viewScreenUpgrade10;
    public GameObject viewScreenUpgrade11;
    public GameObject viewScreenUpgrade12;
    public GameObject viewScreenUpgrade13;
    public GameObject viewScreenUpgrade14;
    public GameObject viewScreenUpgrade15;
    public GameObject viewScreenUpgrade16;
    public GameObject viewScreenUpgrade17;
    public GameObject viewScreenUpgrade18;
    public GameObject viewScreenUpgrade19;
    public GameObject viewScreenUpgrade20;
    public GameObject viewScreenUpgrade21;
    public GameObject viewScreenUpgrade22;
    public GameObject viewScreenUpgrade23;
    public GameObject viewScreenUpgrade24;
    public GameObject viewScreenUpgrade25;
    public GameObject viewScreenUpgrade26;
    public GameObject viewScreenUpgrade27;
    public GameObject viewScreenUpgrade28;
    public GameObject viewScreenUpgrade29;
    public GameObject viewScreenUpgrade30;
    public GameObject viewScreenUpgrade31;
    public GameObject viewScreenUpgrade32;
    public GameObject viewScreenUpgrade33;
    public GameObject viewScreenUpgrade34;
    public GameObject viewScreenUpgrade35;
    public GameObject viewScreenUpgrade36;
    public GameObject viewScreenUpgrade37;
    public GameObject viewScreenUpgrade38;
    public GameObject viewScreenUpgrade39;
    public GameObject viewScreenUpgrade40;

    public GameObject viewScreenUpgradeRich1250;
    public GameObject viewScreenUpgradeAuto;
    public GameObject viewScreenUpgradPileCoins;
    public GameObject viewScreenUpgradeBiggerPile2;

    public GameObject backToFlippingButton;
    public GameObject justViweingText;

    public GameObject has21FlippsAscendButton;
    public GameObject doesNotHave21FlippsAscendButton;

    public GameObject youNeed21FlippersText;
    public GameObject youHave21FlippersText;
    public GameObject inflateOncE;

    //ChallengeObjects
    public GameObject lockFipMore;
    public GameObject lockAutoFlips;
    public GameObject lockUpgradedFlips;
    public GameObject lockHigherChance;
    public GameObject lockLucky;

    public GameObject challenge1Active;
    public GameObject challenge2Active;
    public GameObject challenge3Active;
    public GameObject challenge4Active;

    public GameObject closeButton;
    public GameObject need21FlipperTooltip, close21FLipperBtn, veiwBtn, dark21Flipper;
    public bool pressedView;

    //scale = 1.48
    //pos = -9.3, 390

    public void ViewBtn()
    {
        if(LoadSaves.isMobileBuild == true)
        {
            need21FlipperTooltip.SetActive(false);
            close21FLipperBtn.SetActive(false);
            veiwBtn.SetActive(false);
            pressedView = true;
            onlyViewing = true;
        }
    }

    public void CLose21Btn()
    {
        need21FlipperTooltip.SetActive(false);
        close21FLipperBtn.SetActive(false);
        veiwBtn.SetActive(false);
        pressedView = false;
        dark21Flipper.SetActive(false);
        onlyViewing = false;
    }

    public static bool onlyViewing;
    public GameObject muteBtn, unmuteBtn, settingOnBtn, settingOffBtn;

    public void openJustLookAtInflationTree()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if(pressedView == false && MainButtonClick.numberOfDuplicationUpgrades < 20)
            {
                need21FlipperTooltip.SetActive(true);
                need21FlipperTooltip.transform.localPosition = new Vector2(0, 43);
                need21FlipperTooltip.transform.localScale = new Vector2(2.8f, 2.8f);
                close21FLipperBtn.SetActive(true);
                veiwBtn.SetActive(true);
                dark21Flipper.SetActive(true);
            }

            onlyViewing = true;
            purchaseButton.SetActive(false);
            closeButton.transform.localPosition = new Vector2(0, 0f);
        }
        
        if (LoadSaves.isMobileBuild == false)
        {
            onlyViewing = true;
            justViweingText.SetActive(true);
            ascensionScreen.SetActive(true);
            viewScreenUpgradeRich1250.SetActive(true);
            viewScreenUpgradeAuto.SetActive(true);
            viewScreenUpgradPileCoins.SetActive(true);
            viewScreenUpgradeBiggerPile2.SetActive(true);
        }

        if ((LoadSaves.isMobileBuild == true && pressedView == true) || MainButtonClick.numberOfDuplicationUpgrades == 20)
        {
            muteBtn.SetActive(false); unmuteBtn.SetActive(false); settingOnBtn.SetActive(false); settingOffBtn.SetActive(false);

            pressedView = false;
            dark21Flipper.SetActive(false);
            justViweingText.SetActive(true);
            backToFlippingButton.SetActive(false);
            justViewInflationScreen.SetActive(true); //
        }

        if (LoadSaves.isMobileBuild == false)
        {
            backToFlippingButton.SetActive(false);
            viewScreenUpgrade1.SetActive(true);
            viewScreenUpgrade2.SetActive(true);
            viewScreenUpgrade3.SetActive(true);
            viewScreenUpgrade4.SetActive(true);
            viewScreenUpgrade5.SetActive(true);
            viewScreenUpgrade6.SetActive(true);
            viewScreenUpgrade7.SetActive(true);
            viewScreenUpgrade8.SetActive(true);
            viewScreenUpgrade9.SetActive(true);
            viewScreenUpgrade10.SetActive(true);
            viewScreenUpgrade11.SetActive(true);
            viewScreenUpgrade12.SetActive(true);
            viewScreenUpgrade13.SetActive(true);
            viewScreenUpgrade14.SetActive(true);
            viewScreenUpgrade15.SetActive(true);
            viewScreenUpgrade16.SetActive(true);
            viewScreenUpgrade17.SetActive(true);
            viewScreenUpgrade18.SetActive(true);
            viewScreenUpgrade19.SetActive(true);
            viewScreenUpgrade20.SetActive(true);
            viewScreenUpgrade21.SetActive(true);
            viewScreenUpgrade22.SetActive(true);
            viewScreenUpgrade23.SetActive(true);
            viewScreenUpgrade24.SetActive(true);
            viewScreenUpgrade25.SetActive(true);
            viewScreenUpgrade26.SetActive(true);
            viewScreenUpgrade27.SetActive(true);
            viewScreenUpgrade28.SetActive(true);
            viewScreenUpgrade29.SetActive(true);
            viewScreenUpgrade30.SetActive(true);
            viewScreenUpgrade31.SetActive(true);
            viewScreenUpgrade32.SetActive(true);
            viewScreenUpgrade33.SetActive(true);
            viewScreenUpgrade34.SetActive(true);
            viewScreenUpgrade35.SetActive(true);
            viewScreenUpgrade36.SetActive(true);
            viewScreenUpgrade37.SetActive(true);
            viewScreenUpgrade38.SetActive(true);
            viewScreenUpgrade39.SetActive(true);
            viewScreenUpgrade40.SetActive(true);
        }
       
        ascendScreenScript.CheckInflationUpgradePriceColor();
    }

    public GameObject purchaseButton;

    public void closeJustLookAtInflationTree()
    {
        muteBtn.SetActive(true); unmuteBtn.SetActive(true); settingOnBtn.SetActive(true); settingOffBtn.SetActive(true);

        viewScreenUpgradeRich1250.SetActive(false);
        viewScreenUpgradeAuto.SetActive(false);
        viewScreenUpgradPileCoins.SetActive(false);
        viewScreenUpgradeBiggerPile2.SetActive(false);

        justViweingText.SetActive(false);
        backToFlippingButton.SetActive(true);
        justViewInflationScreen.SetActive(false);
        viewScreenUpgrade1.SetActive(false);
        viewScreenUpgrade2.SetActive(false);
        viewScreenUpgrade3.SetActive(false);
        viewScreenUpgrade4.SetActive(false);
        viewScreenUpgrade5.SetActive(false);
        viewScreenUpgrade6.SetActive(false);
        viewScreenUpgrade7.SetActive(false);
        viewScreenUpgrade8.SetActive(false);
        viewScreenUpgrade9.SetActive(false);
        viewScreenUpgrade10.SetActive(false);
        viewScreenUpgrade11.SetActive(false);
        viewScreenUpgrade12.SetActive(false);
        viewScreenUpgrade13.SetActive(false);
        viewScreenUpgrade14.SetActive(false);
        viewScreenUpgrade15.SetActive(false);
        viewScreenUpgrade16.SetActive(false);
        viewScreenUpgrade17.SetActive(false);
        viewScreenUpgrade18.SetActive(false);
        viewScreenUpgrade19.SetActive(false);
        viewScreenUpgrade20.SetActive(false);
        viewScreenUpgrade21.SetActive(false);
        viewScreenUpgrade22.SetActive(false);
        viewScreenUpgrade23.SetActive(false);
        viewScreenUpgrade24.SetActive(false);
        viewScreenUpgrade25.SetActive(false);
        viewScreenUpgrade26.SetActive(false);
        viewScreenUpgrade27.SetActive(false);
        viewScreenUpgrade28.SetActive(false);
        viewScreenUpgrade29.SetActive(false);
        viewScreenUpgrade30.SetActive(false);
        viewScreenUpgrade31.SetActive(false);
        viewScreenUpgrade32.SetActive(false);
        viewScreenUpgrade33.SetActive(false);
        viewScreenUpgrade34.SetActive(false);
        viewScreenUpgrade35.SetActive(false);
        viewScreenUpgrade36.SetActive(false);
        viewScreenUpgrade37.SetActive(false);
        viewScreenUpgrade38.SetActive(false);
        viewScreenUpgrade39.SetActive(false);
        viewScreenUpgrade40.SetActive(false);

        //1.2UpdateviewScreen

    }

    public void Start()
    {
        waitTime = 0.1f;
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(1f);
    }

    public void Update()
    {
        if(MainButtonClick.numberOfDuplicationUpgrades == 20) { has21FlippsAscendButton.SetActive(true); doesNotHave21FlippsAscendButton.SetActive(false); }
        if (MainButtonClick.numberOfDuplicationUpgrades < 20) { has21FlippsAscendButton.SetActive(false); doesNotHave21FlippsAscendButton.SetActive(true); }

        if(MainButtonClick.numberOfDuplicationUpgrades == 20) { youNeed21FlippersText.SetActive(false); youHave21FlippersText.SetActive(true); }
        if (MainButtonClick.numberOfDuplicationUpgrades < 20) { youNeed21FlippersText.SetActive(true); youHave21FlippersText.SetActive(false); }

        if(AscendTimesAmount == 0) { inflateOncE.SetActive(true); }
        if (AscendTimesAmount > 0) { inflateOncE.SetActive(false); }
    }

    public void ChooseAscendButton()
    {
        chooseToAscend.SetActive(true);
    }

    public GameObject chal1;
    public GameObject chal2;
    public GameObject chal3;
    public GameObject chal4;


    public GameObject button;

    public void ASCENTNOW()
    {
        onlyViewing = false;
        if (LoadSaves.isMobileBuild == true)
        {
            closeButton.transform.localPosition = new Vector2(376, 0f);
            purchaseButton.SetActive(true);
        }

        button.GetComponent<Button>().onClick.Invoke();
        chal1.SetActive(true);
        chal2.SetActive(true);
        chal3.SetActive(true);
        chal4.SetActive(true);

        chooseToAscend.SetActive(false);
        StartCoroutine(SetEverythingFalse());
        ascendScreenScript.CheckInflationUpgradePriceColor();

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

    public GameObject blockScreen;

    IEnumerator SetEverythingFalse()
    {
        blockScreen.SetActive(true);
        PlayAudio();
        flipper21.SetActive(false);
        specialFlipper21.SetActive(false);
        yield return new WaitForSeconds(0.65f);

        PlayAudio();
        flipper20.SetActive(false);
        specialFlipper20.SetActive(false);
        yield return new WaitForSeconds(0.6f);

        PlayAudio();
        flipper19.SetActive(false);
        specialFlipper19.SetActive(false);
        yield return new WaitForSeconds(0.5f);

        PlayAudio();
        flipper18.SetActive(false);
        specialFlipper18.SetActive(false);
        yield return new WaitForSeconds(0.5f);

        PlayAudio();
        flipper17.SetActive(false);
        specialFlipper17.SetActive(false);
        yield return new WaitForSeconds(0.4f);

        PlayAudio();
        flipper16.SetActive(false);
        specialFlipper16.SetActive(false);
        yield return new WaitForSeconds(0.4f);

        PlayAudio();
        flipper15.SetActive(false);
        specialFlipper15.SetActive(false);
        yield return new WaitForSeconds(0.3f);

        PlayAudio();
        flipper14.SetActive(false);
        specialFlipper14.SetActive(false);
        yield return new WaitForSeconds(0.3f);

        PlayAudio();
        flipper13.SetActive(false);
        specialFlipper13.SetActive(false);
        yield return new WaitForSeconds(0.3f);

        PlayAudio();
        flipper12.SetActive(false);
        specialFlipper12.SetActive(false);
        yield return new WaitForSeconds(0.3f);

        PlayAudio();
        flipper11.SetActive(false);
        specialFlipper11.SetActive(false);
        yield return new WaitForSeconds(0.2f);

        PlayAudio();
        flipper10.SetActive(false);
        specialFlipper10.SetActive(false);
        yield return new WaitForSeconds(0.15f);

        PlayAudio();
        flipper9.SetActive(false);
        specialFlipper9.SetActive(false);
        yield return new WaitForSeconds(0.1f);

        PlayAudio();
        flipper8.SetActive(false);
        specialFlipper8.SetActive(false);
        yield return new WaitForSeconds(0.1f);

        PlayAudio();
        flipper7.SetActive(false);
        specialFlipper7.SetActive(false);
        yield return new WaitForSeconds(0.1f);

        PlayAudio();
        flipper6.SetActive(false);
        specialFlipper6.SetActive(false);
        yield return new WaitForSeconds(0.1f);

        PlayAudio();
        flipper5.SetActive(false);
        specialFlipper5.SetActive(false);
        yield return new WaitForSeconds(0.1f);

        PlayAudio();
        flipper4.SetActive(false);
        specialFlipper4.SetActive(false);
        yield return new WaitForSeconds(0.1f);

        PlayAudio();
        flipper3.SetActive(false);
        specialFlipper3.SetActive(false);
        yield return new WaitForSeconds(0.1f);

        PlayAudio();
        flipper2.SetActive(false);
        specialFlipper2.SetActive(false);
        yield return new WaitForSeconds(0.1f);

        PlayAudio();
        flipper1.SetActive(false);
        specialFlipper1.SetActive(false);
        SetAllVariables();
        challScript.ResetChall();
        yield return new WaitForSeconds(0.75f);

        muteBtn.SetActive(false); unmuteBtn.SetActive(false); settingOnBtn.SetActive(false); settingOffBtn.SetActive(false);

        PlayAudio();
        flipAllAutoOnButton.GetComponent<Button>().onClick.Invoke();
        ascensionScreen.SetActive(true);
        blockScreen.SetActive(false);
        backToFlippingButton.SetActive(true);
    }

    public AscendScreen ascendScreenScript;
    public AudioSource poofSound;
    public AudioClip pooSoundEffect;
    public PileOfCoinsMechanics pileOfCoinsScript;

    public void PlayAudio()
    {
        poofSound.PlayOneShot(pooSoundEffect);
    }

    public static int AscendTimesAmount;
    public void SetAllVariables()
    {
        GlobalCoins.CoinCount = 0;
        EnterText.choseHeads = 0;
        EnterText.choseTails = 0;
        MainButtonClick.coinsPerClick = 1;

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
        PileOfCoinsMechanics.totalAmountOfPileGenerated = 0;
        PileOfCoinsMechanics.PileOfCoinsAmount1 = 0;
        PileOfCoinsMechanics.PileOfCoinsAmount2 = 0;
        PileOfCoinsMechanics.PileOfCoinsAmount3 = 0;
        PileOfCoinsMechanics.PileOfCoinsAmount4 = 0;
        PileOfCoinsMechanics.PileOfCounsBoughtFirstTime = 0;

        higherChanceHoverover.tailsPercent = 49.75f;
        higherChanceHoverover.headsPercent = 49.75f;
        MainButtonClick.higherCoinChance = 100;
        MainButtonClick.lowerCoinChance = 101;
        MainButtonClick.lowSpecialChance = 1;

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

        MagicFlipsUpgrade.magicUpgradeCount = 0;

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

        Challenges.isChallenge1Active = 0;
        Challenges.isChallenge2Active = 0;
        Challenges.isChallenge3Active = 0;
        Challenges.isChallenge4Active = 0;

        lockFipMore.SetActive(false);
        lockAutoFlips.SetActive(false);
        lockUpgradedFlips.SetActive(false);
        lockHigherChance.SetActive(false);
        lockLucky.SetActive(false);

        challenge1Active.SetActive(false);
        challenge2Active.SetActive(false);
        challenge3Active.SetActive(false);
        challenge4Active.SetActive(false);

        blockAuto.SetActive(false);
        blockHigher.SetActive(false);
        blockLucky.SetActive(false);
        blockUpgradedAuto.SetActive(false);

        AscendTimesAmount += 1;
        mainScript.SetMuteFlipper();
        pileOfCoinsScript.SetPileOfCoins();
        goldenFlipsScript.SetPosAndScale();
    }

    public GoldenFlipsButton goldenFlipsScript;

    public void DontAscent()
    {
        chooseToAscend.SetActive(false);
    }

    public GameObject choose;
    public GameObject menu;
    public GameObject HeadsOrTails;
    public GameObject chooseHOTtext;
    public GameObject chooseToGoBackToPlipping;

    public void choosePopUp()
    {
        chooseToGoBackToPlipping.SetActive(true);
    }

    public void starInAscend()
    {
        chooseToGoBackToPlipping.SetActive(false);
    }

    public void BackToFlipping()
    {
        muteBtn.SetActive(true); unmuteBtn.SetActive(true); settingOnBtn.SetActive(true); settingOffBtn.SetActive(true);

        chooseToGoBackToPlipping.SetActive(false);
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

        SetBackGainedCoins();

        hideMuteFlipperHoverOver1.SetActive(false);
        hideMuteFlipperHoverOver2.SetActive(false);
        hideMuteFlipperHoverOver3.SetActive(false);
        hideMuteFlipperHoverOver4.SetActive(false);
        hideMuteFlipperHoverOver5.SetActive(false);
        hideMuteFlipperHoverOver6.SetActive(false);
        hideMuteFlipperHoverOver7.SetActive(false);
        hideMuteFlipperHoverOver8.SetActive(false);
        hideMuteFlipperHoverOver9.SetActive(false);
        hideMuteFlipperHoverOver10.SetActive(false);
        hideMuteFlipperHoverOver11.SetActive(false);
        hideMuteFlipperHoverOver12.SetActive(false);
        hideMuteFlipperHoverOver13.SetActive(false);
        hideMuteFlipperHoverOver14.SetActive(false);
        hideMuteFlipperHoverOver15.SetActive(false);
        hideMuteFlipperHoverOver16.SetActive(false);
        hideMuteFlipperHoverOver17.SetActive(false);
        hideMuteFlipperHoverOver18.SetActive(false);
        hideMuteFlipperHoverOver19.SetActive(false);
        hideMuteFlipperHoverOver20.SetActive(false);
        hideMuteFlipperHoverOver21.SetActive(false);
        ascensionScreen.SetActive(false);

        chooseHOTtext.SetActive(true);
        HeadsOrTails.SetActive(true);
        menu.SetActive(false);
        choose.SetActive(false);

    }

    public GameObject challengeYesOrNo;

    public void DoYouWichToQuitChallenge()
    {
        challengeYesOrNo.SetActive(true);
    }

    public void quitChallengesNo()
    {
        challengeYesOrNo.SetActive(false);
    }

    public GameObject quitChallengeButton1;
    public GameObject quitChallengeButton2;
    public GameObject quitChallengeButton3;
    public GameObject quitChallengeButton4;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;

    public GameObject blockHeadsOrTails;

    public GameObject savebutton;

    public GameObject buttonDropBar;

    public GameObject flipAllAutoOnButton;

    public GameObject blockAuto;
    public GameObject blockHigher;
    public GameObject blockLucky;
    public GameObject blockUpgradedAuto;
    public MainButtonClick mainScript;

    public void quitChallengesYes()
    {
        muteBtn.SetActive(true); unmuteBtn.SetActive(true); settingOnBtn.SetActive(true); settingOffBtn.SetActive(true);

        blockAuto.SetActive(false);
        blockHigher.SetActive(false);
        blockLucky.SetActive(false);
        blockUpgradedAuto.SetActive(false);
        flipAllAutoOnButton.GetComponent<Button>().onClick.Invoke();
        buttonDropBar.GetComponent<Button>().onClick.Invoke();
        blockHeadsOrTails.SetActive(true);
        button1.GetComponent<Button>().onClick.Invoke();
        button2.GetComponent<Button>().onClick.Invoke();
        button3.GetComponent<Button>().onClick.Invoke();
        button4.GetComponent<Button>().onClick.Invoke();
        hideMuteFlipperHoverOver1.SetActive(false);
        hideMuteFlipperHoverOver2.SetActive(false);
        hideMuteFlipperHoverOver3.SetActive(false);
        hideMuteFlipperHoverOver4.SetActive(false);
        hideMuteFlipperHoverOver5.SetActive(false);
        hideMuteFlipperHoverOver6.SetActive(false);
        hideMuteFlipperHoverOver7.SetActive(false);
        hideMuteFlipperHoverOver8.SetActive(false);
        hideMuteFlipperHoverOver9.SetActive(false);
        hideMuteFlipperHoverOver10.SetActive(false);
        hideMuteFlipperHoverOver11.SetActive(false);
        hideMuteFlipperHoverOver12.SetActive(false);
        hideMuteFlipperHoverOver13.SetActive(false);
        hideMuteFlipperHoverOver14.SetActive(false);
        hideMuteFlipperHoverOver15.SetActive(false);
        hideMuteFlipperHoverOver16.SetActive(false);
        hideMuteFlipperHoverOver17.SetActive(false);
        hideMuteFlipperHoverOver18.SetActive(false);
        hideMuteFlipperHoverOver19.SetActive(false);
        hideMuteFlipperHoverOver20.SetActive(false);
        hideMuteFlipperHoverOver21.SetActive(false);

        quitChallengeButton1.SetActive(false);
        quitChallengeButton2.SetActive(false);
        quitChallengeButton3.SetActive(false);
        quitChallengeButton4.SetActive(false);
        chal1.SetActive(true);
        chal2.SetActive(true);
        chal3.SetActive(true);
        chal4.SetActive(true);

        GlobalCoinMaker.coinsPerFlipUpgrades = 0;

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

        challengeYesOrNo.SetActive(false);
        lockFipMore.SetActive(false);
        lockAutoFlips.SetActive(false);
        lockUpgradedFlips.SetActive(false);
        lockHigherChance.SetActive(false);
        lockLucky.SetActive(false);

        challenge1Active.SetActive(false);
        challenge2Active.SetActive(false);
        challenge3Active.SetActive(false);
        challenge4Active.SetActive(false);

        GlobalCoins.CoinCount = 0;
        EnterText.choseHeads = 0;
        EnterText.choseTails = 0;
        MainButtonClick.coinsPerClick = 1;

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
        PileOfCoinsMechanics.totalAmountOfPileGenerated = 0;
        PileOfCoinsMechanics.PileOfCoinsAmount1 = 0;
        PileOfCoinsMechanics.PileOfCoinsAmount2 = 0;
        PileOfCoinsMechanics.PileOfCoinsAmount3 = 0;
        PileOfCoinsMechanics.PileOfCoinsAmount4 = 0;
        PileOfCoinsMechanics.PileOfCounsBoughtFirstTime = 0;

        higherChanceHoverover.tailsPercent = 49.75f;
        higherChanceHoverover.headsPercent = 49.75f;
        MainButtonClick.higherCoinChance = 100;
        MainButtonClick.lowerCoinChance = 101;
        MainButtonClick.lowSpecialChance = 1;

        GlobalCoinMaker.coinValue = 350;
        PurchaseLog.higherChanceUpgradeCount = 0;
        HigherChance.higherChanceValue = 150000;
        PurchaseLog.luckyCoinHigherChanceCount = 0;
        LuckyCoinChance.luckyCoinValue = 175000000;
        GoldenFlipsButton.goldenCoinsUpgradeCount = 0;
        GOLDENFLIPS.specialCoinsButtonCost = 35000000;
        DuplicateCoin.duplicatePrice = 75;
        GetLuckyHoverOver.luckyChance = 0.5f;

        MagicFlipsUpgrade.magicUpgradeCount = 0;

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

        Challenges.isChallenge1Active = 0;
        Challenges.isChallenge2Active = 0;
        Challenges.isChallenge3Active = 0;
        Challenges.isChallenge4Active = 0;

        PlayerPrefs.SetInt("SavedChallenge1", Challenges.isChallenge1Active);
        PlayerPrefs.SetInt("SavedChallenge2", Challenges.isChallenge2Active);
        PlayerPrefs.SetInt("SavedChallenge3", Challenges.isChallenge3Active);
        PlayerPrefs.SetInt("SavedChallenge4", Challenges.isChallenge4Active);

        MainButtonClick.numberOfDuplicationUpgrades = 0;

        headsOrTails.SetActive(true);
        menu.SetActive(false);
        StartCoroutine(setFlippersOff());
        pileOfCoinsScript.SetPileOfCoins();

        goldenFlipsScript.SetPosAndScale();
        challScript.ResetChall();
    }

    public GameObject headsOrTails;

    IEnumerator setFlippersOff()
    {
        yield return new WaitForSeconds(2.3f);
        savebutton.GetComponent<Button>().onClick.Invoke();
        blockHeadsOrTails.SetActive(false);
        flipper1.SetActive(false);
        flipper2.SetActive(false);
        flipper3.SetActive(false);
        flipper4.SetActive(false);
        flipper5.SetActive(false);
        flipper6.SetActive(false);
        flipper7.SetActive(false);
        flipper8.SetActive(false);
        flipper9.SetActive(false);
        flipper10.SetActive(false);
        flipper11.SetActive(false);
        flipper12.SetActive(false);
        flipper13.SetActive(false);
        flipper14.SetActive(false);
        flipper15.SetActive(false);
        flipper16.SetActive(false);
        flipper17.SetActive(false);
        flipper18.SetActive(false);
        flipper19.SetActive(false);
        flipper20.SetActive(false);
        flipper21.SetActive(false);
        specialFlipper1.SetActive(false);
        specialFlipper2.SetActive(false);
        specialFlipper3.SetActive(false);
        specialFlipper4.SetActive(false);
        specialFlipper5.SetActive(false);
        specialFlipper6.SetActive(false);
        specialFlipper7.SetActive(false);
        specialFlipper8.SetActive(false);
        specialFlipper9.SetActive(false);
        specialFlipper10.SetActive(false);
        specialFlipper11.SetActive(false);
        specialFlipper12.SetActive(false);
        specialFlipper13.SetActive(false);
        specialFlipper14.SetActive(false);
        specialFlipper15.SetActive(false);
        specialFlipper16.SetActive(false);
        specialFlipper17.SetActive(false);
        specialFlipper18.SetActive(false);
        specialFlipper19.SetActive(false);
        specialFlipper20.SetActive(false);
        specialFlipper21.SetActive(false);
        mainScript.SetMuteFlipper();
    }

    public void SetBackGainedCoins()
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
