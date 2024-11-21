using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class AutoUpgrade : MonoBehaviour
{
    public GameObject button;
    public GameObject buttonGreater;
    public GameObject buttonKnowledge;
    public GameObject buttonFist;
    public GameObject buttonInection;
    public GameObject buttonBrain;
    public GameObject buttonExplosion;
    public GameObject buttonHydration;
    public GameObject buttonPotion;
    public GameObject buttonMaster;
    public GameObject buttonHandShake;
    public GameObject buttonHighFive;
    public GameObject buttonMagic;
    public GameObject buttonChest;
    public GameObject buttonRitual;
    public GameObject buttonAuto;
    public GameObject buttonPile;
    public GameObject buttonHigherChance;
    public GameObject buttonLucky;
    public GameObject buttonUpgraded;
    public GameObject chooseWhatToAutoUpgrade;
    public GameObject autoUpgradeOn;
    public GameObject autoUpgradeOff;

    public int autoUpgradeArms;
    public int autoUpgradeGreaterCoin;
    public int autoUpgradeKnowledge;
    public int autoUpgradeFist;
    public int autoUpgradeInjection;
    public int autoUpgradeBrain;
    public int autoUpgradeExplosion;
    public int autoUpgradeHydration;
    public int autoUpgradePotion;
    public int autoUpgradeMaster;
    public int autoUpgradeHandShake;
    public int autoUpgradeHighFive;
    public int autoUpgradeMagic;
    public int autoUpgradeChest;
    public int autoUpgradeRitual;
    public int autoUpgradeAutoFlipper;
    public int autoUpgradePile;
    public int autoUpgradeHigerChance;
    public int autoUpgradeLucky;
    public int autoUpgradeUpgradedFlips;

    bool autoUpgrade = false;

    public GameObject armIcon;
    public GameObject greaterIcon;
    public GameObject knowledgeIcon;
    public GameObject fistIcon;
    public GameObject injectionIcon;
    public GameObject brainIcon;
    public GameObject explotionIcon;
    public GameObject hydrationIcon;
    public GameObject potionIcon;
    public GameObject masterIcon;
    public GameObject handShakeIcon;
    public GameObject highFiveIcon;
    public GameObject magicIcon;
    public GameObject chestIcon;
    public GameObject ritualIcon;
    public GameObject autoIcon;
    public GameObject pileIcon;
    public GameObject higherChanceIcon;
    public GameObject luckyIcon;
    public GameObject upgradecIcon;
    public GameObject xNonIcon;

    public GameObject blockUpgrade2;
    public GameObject blockUpgrade3;
    public GameObject blockUpgrade4;
    public GameObject blockUpgrade5;
    public GameObject blockUpgrade6;
    public GameObject blockUpgrade7;
    public GameObject blockUpgrade8;
    public GameObject blockUpgrade9;
    public GameObject blockUpgrade10;
    public GameObject blockUpgrade11;
    public GameObject blockUpgrade12;
    public GameObject blockUpgrade13;
    public GameObject blockUpgrade14;
    public GameObject blockUpgrade15;

    public GameObject blockAuto;
    public GameObject blockHigher;
    public GameObject blockLucky;
    public GameObject blockUpgraded;

    public void Start()
    {
        autoUpgrade = false;
        xNonIcon.SetActive(true);
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
        CheckBlockUpgrades();
    }

    public Transform transformMobile;
    public GameObject autoUpgradeBlackFrame;
    public GameObject closeAutoBtn;

    public void CloseAutoFrame()
    {
        autoUpgradeBlackFrame.SetActive(false);
        chooseWhatToAutoUpgrade.SetActive(false);
        closeAutoBtn.SetActive(false);
    }

    public void chooseAutoOn()
    {
        chooseWhatToAutoUpgrade.SetActive(true);

        if (LoadSaves.isMobileBuild == true)
        {
            closeAutoBtn.SetActive(true);
            autoUpgradeBlackFrame.SetActive(true);
            chooseWhatToAutoUpgrade.transform.SetParent(transformMobile);
            chooseWhatToAutoUpgrade.transform.localScale = new Vector2(2, 2);
            chooseWhatToAutoUpgrade.transform.localPosition = new Vector2(-226, -2.3f);

            autoUpgradeOn.SetActive(true);
        }
        else
        {
            autoUpgradeOn.SetActive(false);
            autoUpgradeOff.SetActive(true);
        }
    }

    public void chooseAutoOff()
    {
        chooseWhatToAutoUpgrade.SetActive(false);
        autoUpgradeOn.SetActive(true);
        autoUpgradeOff.SetActive(false);
    }


    public void AutoUpgradeArms() { SetAllToZero(); autoUpgradeArms = 1;  autoUpgrade = true; SetAllIconOff(); armIcon.SetActive(true); StopAllCoroutines(); }
    public void AutoUpgradeGraterCoin() { SetAllToZero(); autoUpgradeGreaterCoin = 1; autoUpgrade = true; SetAllIconOff(); greaterIcon.SetActive(true); StopAllCoroutines(); }
    public void AutoUpgradeKnowledge() { SetAllToZero(); autoUpgradeKnowledge = 1; autoUpgrade = true; SetAllIconOff(); knowledgeIcon.SetActive(true); StopAllCoroutines(); }
    public void AutoUpgradeFist() { SetAllToZero(); autoUpgradeFist = 1; autoUpgrade = true; SetAllIconOff(); fistIcon.SetActive(true); StopAllCoroutines(); }
    public void AutoUpgradeInjection() { SetAllToZero(); autoUpgradeInjection = 1; autoUpgrade = true; SetAllIconOff(); injectionIcon.SetActive(true); StopAllCoroutines(); }
    public void AutoUpgradeBrain() { SetAllToZero(); autoUpgradeBrain = 1; autoUpgrade = true; SetAllIconOff(); brainIcon.SetActive(true); StopAllCoroutines(); }
    public void AutoUpgradeExplosion() { SetAllToZero(); autoUpgradeExplosion = 1; autoUpgrade = true; SetAllIconOff(); explotionIcon.SetActive(true); StopAllCoroutines(); }
    public void AutoUpgradeHydration() { SetAllToZero(); autoUpgradeHydration = 1; autoUpgrade = true; SetAllIconOff(); hydrationIcon.SetActive(true); StopAllCoroutines(); }
    public void AutoUpgradePotion() { SetAllToZero(); autoUpgradePotion = 1; autoUpgrade = true; SetAllIconOff(); potionIcon.SetActive(true); StopAllCoroutines(); }
    public void AutoUpgradeMasterFlipper() { SetAllToZero(); autoUpgradeMaster = 1; autoUpgrade = true; SetAllIconOff(); masterIcon.SetActive(true); StopAllCoroutines(); }
    public void AutoUpgradeHansShake() { SetAllToZero(); autoUpgradeHandShake = 1; autoUpgrade = true; SetAllIconOff(); handShakeIcon.SetActive(true); StopAllCoroutines(); }
    public void AutoUpgradeHighFive() { SetAllToZero(); autoUpgradeHighFive = 1; autoUpgrade = true; SetAllIconOff(); highFiveIcon.SetActive(true); StopAllCoroutines(); }
    public void AutoUpgradeMagic() { SetAllToZero(); autoUpgradeMagic = 1; autoUpgrade = true; SetAllIconOff(); magicIcon.SetActive(true); StopAllCoroutines(); }
    public void AutoUpgradeTreasure() { SetAllToZero(); autoUpgradeChest = 1; autoUpgrade = true; SetAllIconOff(); chestIcon.SetActive(true); StopAllCoroutines(); }
    public void AutoUpgradeRitual() { SetAllToZero(); autoUpgradeRitual = 1; autoUpgrade = true; SetAllIconOff(); ritualIcon.SetActive(true); StopAllCoroutines(); }
    public void AutoUpgradeAutoFlips() { SetAllToZero(); autoUpgradeAutoFlipper = 1; autoUpgrade = true; SetAllIconOff(); autoIcon.SetActive(true); StopAllCoroutines(); }
    public void AutoUpgradePileOfCoins() { SetAllToZero(); autoUpgradePile = 1; autoUpgrade = true; SetAllIconOff(); pileIcon.SetActive(true); StopAllCoroutines(); }
    public void AutoUpgradeHigherChance() { SetAllToZero(); autoUpgradeHigerChance = 1; autoUpgrade = true; SetAllIconOff(); higherChanceIcon.SetActive(true); StopAllCoroutines(); }
    public void AutoUpgradeLucky() { SetAllToZero(); autoUpgradeLucky = 1; autoUpgrade = true; SetAllIconOff(); luckyIcon.SetActive(true); StopAllCoroutines(); }
    public void AutoUpgradeAutoUpgrade() { SetAllToZero(); autoUpgradeUpgradedFlips = 1; autoUpgrade = true; SetAllIconOff(); upgradecIcon.SetActive(true); StopAllCoroutines(); }
    public void AutoSetAllNon() { SetAllToZero(); autoUpgrade = false; SetAllIconOff(); xNonIcon.SetActive(true); StopAllCoroutines(); }

    public GameObject questionMark2, questionMark3, questionMark4, questionMark5, questionMark6, questionMark7, questionMark8, questionMark9, questionMark10, questionMark11, questionMark12, questionMark13, questionMark14, questionMark15;

    public GameObject viewText2, viewText3, viewText4, viewText5, viewText6, viewText7, viewText8, viewText9, viewText10, viewText11, viewText12, viewText13, viewText14, viewText15;

    public Button info2BTN, info3BTN, info4BTN, info5BTN, info6BTN, info7BTN, info8BTN, info9BTN, info10BTN, info11BTN, info12BTN, info13BTN, info14BTN, info15BTN;

    public void CheckBlockUpgrades()
    {
        if (MoreCoinsButton.moreCoinsUpgrades == 0) { blockUpgrade2.SetActive(true); }
        if (MoreCoinsButton.greaterCoinsCount == 0) { blockUpgrade3.SetActive(true); }
        if (KnowledgeUpgrade.knowledgeUpgradeCount == 0) { blockUpgrade4.SetActive(true); }
        if (StrongerFist.fistUpgradeCount == 0) { blockUpgrade5.SetActive(true); }
        if (HandInecjtion.injectionUpgradeCount == 0) { blockUpgrade6.SetActive(true);  }
        if (BrainPower.brainPowerUpgradeCount == 0) { blockUpgrade7.SetActive(true); }
        if (ExplosiveFlips.explosiveUpgradeCount == 0) { blockUpgrade8.SetActive(true);  }
        if (HydrationButton.hydrationUpgradeCount == 0) { blockUpgrade9.SetActive(true);  }
        if (StrangePotion.potionUpgradeCount == 0) { blockUpgrade10.SetActive(true); }
        if (MasterFlipper.MasterFlipsUpgradeCount == 0) { blockUpgrade11.SetActive(true);  }
        if (HandShake.handShakeUpgradeCount == 0) { blockUpgrade12.SetActive(true); }
        if (Upgrade12.upgrade12Count == 0) { blockUpgrade13.SetActive(true); }
        if (MagicFlipsUpgrade.magicUpgradeCount == 0) { blockUpgrade14.SetActive(true);  }
        if (TreasureChest.treasureCount == 0) { blockUpgrade15.SetActive(true);  }

        if (MoreCoinsButton.moreCoinsUpgrades > 0) { blockUpgrade2.SetActive(false); }
        if (MoreCoinsButton.greaterCoinsCount > 0) { blockUpgrade3.SetActive(false); }
        if (KnowledgeUpgrade.knowledgeUpgradeCount > 0) { blockUpgrade4.SetActive(false); }
        if (StrongerFist.fistUpgradeCount > 0) { blockUpgrade5.SetActive(false); }
        if (HandInecjtion.injectionUpgradeCount > 0) { blockUpgrade6.SetActive(false); }
        if (BrainPower.brainPowerUpgradeCount > 0) { blockUpgrade7.SetActive(false);}
        if (ExplosiveFlips.explosiveUpgradeCount > 0) { blockUpgrade8.SetActive(false); }
        if (HydrationButton.hydrationUpgradeCount > 0) { blockUpgrade9.SetActive(false); }
        if (StrangePotion.potionUpgradeCount > 0) { blockUpgrade10.SetActive(false); }
        if (MasterFlipper.MasterFlipsUpgradeCount > 0) { blockUpgrade11.SetActive(false); }
        if (HandShake.handShakeUpgradeCount > 0) { blockUpgrade12.SetActive(false);  }
        if (Upgrade12.upgrade12Count > 0) { blockUpgrade13.SetActive(false); }
        if (MagicFlipsUpgrade.magicUpgradeCount > 0) { blockUpgrade14.SetActive(false); }
        if (TreasureChest.treasureCount > 0) { blockUpgrade15.SetActive(false); }


        if(LoadSaves.isMobileBuild == true)
        {
            if (MoreCoinsButton.moreCoinsUpgrades == 0) { questionMark2.SetActive(true); viewText2.SetActive(false); info2BTN.interactable = false; }
            if (MoreCoinsButton.greaterCoinsCount == 0) {  questionMark3.SetActive(true); viewText3.SetActive(false); info3BTN.interactable = false; }
            if (KnowledgeUpgrade.knowledgeUpgradeCount == 0) {  questionMark4.SetActive(true); viewText4.SetActive(false); info4BTN.interactable = false; }
            if (StrongerFist.fistUpgradeCount == 0) {  questionMark5.SetActive(true); viewText5.SetActive(false); info5BTN.interactable = false; }
            if (HandInecjtion.injectionUpgradeCount == 0) { questionMark6.SetActive(true); viewText6.SetActive(false); info6BTN.interactable = false; }
            if (BrainPower.brainPowerUpgradeCount == 0) { questionMark7.SetActive(true); viewText7.SetActive(false); info7BTN.interactable = false; }
            if (ExplosiveFlips.explosiveUpgradeCount == 0) { questionMark8.SetActive(true); viewText8.SetActive(false); info8BTN.interactable = false; }
            if (HydrationButton.hydrationUpgradeCount == 0) { questionMark9.SetActive(true); viewText9.SetActive(false); info9BTN.interactable = false; }
            if (StrangePotion.potionUpgradeCount == 0) {  questionMark10.SetActive(true); viewText10.SetActive(false); info10BTN.interactable = false; }
            if (MasterFlipper.MasterFlipsUpgradeCount == 0) { questionMark11.SetActive(true); viewText11.SetActive(false); info11BTN.interactable = false; }
            if (HandShake.handShakeUpgradeCount == 0) {  questionMark12.SetActive(true); viewText12.SetActive(false); info12BTN.interactable = false; }
            if (Upgrade12.upgrade12Count == 0) { questionMark13.SetActive(true); viewText13.SetActive(false); info13BTN.interactable = false; }
            if (MagicFlipsUpgrade.magicUpgradeCount == 0) {  questionMark14.SetActive(true); viewText14.SetActive(false); info14BTN.interactable = false; }
            if (TreasureChest.treasureCount == 0) { questionMark15.SetActive(true); viewText15.SetActive(false); info15BTN.interactable = false; }

            if (MoreCoinsButton.moreCoinsUpgrades > 0) { questionMark2.SetActive(false); viewText2.SetActive(true); info2BTN.interactable = true; }
            if (MoreCoinsButton.greaterCoinsCount > 0) { questionMark3.SetActive(false); viewText3.SetActive(true); info3BTN.interactable = true; }
            if (KnowledgeUpgrade.knowledgeUpgradeCount > 0) { questionMark4.SetActive(false); viewText4.SetActive(true); info4BTN.interactable = true; }
            if (StrongerFist.fistUpgradeCount > 0) { questionMark5.SetActive(false); viewText5.SetActive(true); info5BTN.interactable = true; }
            if (HandInecjtion.injectionUpgradeCount > 0) { questionMark6.SetActive(false); viewText6.SetActive(true); info6BTN.interactable = true; }
            if (BrainPower.brainPowerUpgradeCount > 0) {  questionMark7.SetActive(false); viewText7.SetActive(true); info7BTN.interactable = true; }
            if (ExplosiveFlips.explosiveUpgradeCount > 0) {  questionMark8.SetActive(false); viewText8.SetActive(true); info8BTN.interactable = true; }
            if (HydrationButton.hydrationUpgradeCount > 0) { questionMark9.SetActive(false); viewText9.SetActive(true); info9BTN.interactable = true; }
            if (StrangePotion.potionUpgradeCount > 0) { questionMark10.SetActive(false); viewText10.SetActive(true); info10BTN.interactable = true; }
            if (MasterFlipper.MasterFlipsUpgradeCount > 0) { questionMark11.SetActive(false); viewText11.SetActive(true); info11BTN.interactable = true; }
            if (HandShake.handShakeUpgradeCount > 0) {  questionMark12.SetActive(false); viewText12.SetActive(true); info12BTN.interactable = true; }
            if (Upgrade12.upgrade12Count > 0) { questionMark13.SetActive(false); viewText13.SetActive(true); info13BTN.interactable = true; }
            if (MagicFlipsUpgrade.magicUpgradeCount > 0) {questionMark14.SetActive(false); viewText14.SetActive(true); info14BTN.interactable = true; }
            if (TreasureChest.treasureCount > 0) { questionMark15.SetActive(false); viewText15.SetActive(true); info15BTN.interactable = true; }
        }

    }

    public void Update()
    {
        if(Challenges.isChallenge2Active == 0 && Challenges.isChallenge4Active == 0 && Challenges.isChallenge1Active == 0) { }
        else
        {
            if (Challenges.isChallenge2Active == 1) { blockHigher.SetActive(true); blockLucky.SetActive(true); }
            else if (Challenges.isChallenge4Active == 1) { blockHigher.SetActive(true); blockLucky.SetActive(true); }
            else if (Challenges.isChallenge1Active == 1) { blockAuto.SetActive(true); blockUpgraded.SetActive(true); }
        }

        if (autoUpgrade == true)
        {
            StartCoroutine(wait1Minute());

        }
    }
    public GameObject upgradedHover; 

    IEnumerator wait1Minute()
    {
        autoUpgrade = false;
        yield return new WaitForSeconds(5);
        if(autoUpgradeArms == 1) { if (GlobalCoins.CoinCount >= MoreCoinsButton.moreCoinClickValue) { button.GetComponent<Button>().onClick.Invoke(); }  }
        if (autoUpgradeGreaterCoin == 1) { if (GlobalCoins.CoinCount >= MoreCoinsButton.greaterCoinsCost) { buttonGreater.GetComponent<Button>().onClick.Invoke(); } }
        if (autoUpgradeKnowledge == 1) { if (GlobalCoins.CoinCount >= KnowledgeUpgrade.knowledgeClickValue) { buttonKnowledge.GetComponent<Button>().onClick.Invoke(); } }
        if (autoUpgradeFist == 1) { if (GlobalCoins.CoinCount >= StrongerFist.fistCost) { buttonFist.GetComponent<Button>().onClick.Invoke(); } }
        if (autoUpgradeInjection == 1) { if (GlobalCoins.CoinCount >= StrongerFist.fistCost) { buttonInection.GetComponent<Button>().onClick.Invoke(); } }
        if (autoUpgradeBrain == 1) { if (GlobalCoins.CoinCount >= BrainPower.brainPowerCost) { buttonBrain.GetComponent<Button>().onClick.Invoke(); } }
        if (autoUpgradeExplosion == 1) { if (GlobalCoins.CoinCount >= ExplosiveFlips.explosiveCost) { buttonExplosion.GetComponent<Button>().onClick.Invoke(); } }
        if (autoUpgradeHydration == 1) { if (GlobalCoins.CoinCount >= HydrationButton.hydrationVost) { buttonHydration.GetComponent<Button>().onClick.Invoke(); } }
        if (autoUpgradePotion == 1) { if (GlobalCoins.CoinCount >= StrangePotion.potionCost) { buttonPotion.GetComponent<Button>().onClick.Invoke(); } }
        if (autoUpgradeMaster == 1) { if (GlobalCoins.CoinCount >= MasterFlipper.MasterFlipsCost) { buttonMaster.GetComponent<Button>().onClick.Invoke(); } }
        if (autoUpgradeHandShake == 1) { if (GlobalCoins.CoinCount >= HandShake.handshakeCost) { buttonHandShake.GetComponent<Button>().onClick.Invoke(); } }
        if (autoUpgradeHighFive == 1) { if (GlobalCoins.CoinCount >= Upgrade12.upgrade12Cost) { buttonHighFive.GetComponent<Button>().onClick.Invoke(); } }
        if (autoUpgradeMagic == 1) { if (GlobalCoins.CoinCount >= MagicFlipsUpgrade.magicUpgradeCost) { buttonMagic.GetComponent<Button>().onClick.Invoke(); } }
        if (autoUpgradeChest == 1) { if (GlobalCoins.CoinCount >= TreasureChest.treasureCost) { buttonChest.GetComponent<Button>().onClick.Invoke(); } }
        if (autoUpgradeRitual == 1) { if (GlobalCoins.CoinCount >= RitualUpgrade.ritualCost) { buttonRitual.GetComponent<Button>().onClick.Invoke(); } }
        if (autoUpgradeAutoFlipper == 1) { if (GlobalCoins.CoinCount >= GlobalCoinMaker.coinValue && GlobalCoinMaker.coinsPerFlipUpgrades <= MainButtonClick.numberOfDuplicationUpgrades) { buttonAuto.GetComponent<Button>().onClick.Invoke(); } }
        if (autoUpgradePile == 1)
        { 
            if(PurchaseLog.pileOfCoinsCount < 55)
            {
                if (GlobalCoins.CoinCount >= PileOfCoins.pileOfCoinsCost)
                {
                    buttonPile.GetComponent<Button>().onClick.Invoke();
                }
            }
            
        }


        if (autoUpgradeHigerChance == 1)
        {
            if(PurchaseLog.higherChanceUpgradeCount < 44 && Challenges.completedChallenge4 == 0)
            {
                if (GlobalCoins.CoinCount >= HigherChance.higherChanceValue)
                {
                    buttonHigherChance.GetComponent<Button>().onClick.Invoke();
                }
            }
            if (PurchaseLog.higherChanceUpgradeCount < 34 && Challenges.completedChallenge4 == 1)
            {
                if (GlobalCoins.CoinCount >= HigherChance.higherChanceValue)
                {
                    buttonHigherChance.GetComponent<Button>().onClick.Invoke();
                }
            }
        }


        if (autoUpgradeLucky == 1) 
        {
            if (PurchaseLog.luckyCoinHigherChanceCount < 9 && Challenges.completedChallenge4 == 0)
            {
                if (GlobalCoins.CoinCount >= LuckyCoinChance.luckyCoinValue)
                {
                    buttonLucky.GetComponent<Button>().onClick.Invoke();
                }
            }
            if(Challenges.completedChallenge4 < 1 && PurchaseLog.luckyCoinHigherChanceCount == 29)
            {
                if (GlobalCoins.CoinCount >= LuckyCoinChance.luckyCoinValue)
                {
                    buttonLucky.GetComponent<Button>().onClick.Invoke();
                }
            }
        }

        if (autoUpgradeUpgradedFlips == 1) { if (GlobalCoins.CoinCount >= GOLDENFLIPS.specialCoinsButtonCost && GlobalCoinMaker.coinsPerFlipUpgrades > GoldenFlipsButton.goldenCoinsUpgradeCount && MainButtonClick.numberOfDuplicationUpgrades == 20) { buttonUpgraded.GetComponent<Button>().onClick.Invoke(); } }
        autoUpgrade = true;

    }

    public void SetAllToZero()
    {
        autoUpgradeArms = 0;
        autoUpgradeGreaterCoin = 0;
        autoUpgradeKnowledge = 0;
        autoUpgradeFist = 0;
        autoUpgradeInjection = 0;
        autoUpgradeBrain = 0;
        autoUpgradeExplosion = 0;
        autoUpgradeHydration = 0;
        autoUpgradePotion = 0;
        autoUpgradeMaster = 0;
        autoUpgradeHandShake = 0;
        autoUpgradeHighFive = 0;
        autoUpgradeMagic = 0;
        autoUpgradeChest = 0;
        autoUpgradeRitual = 0;
        autoUpgradeAutoFlipper = 0;
        autoUpgradePile = 0;
        autoUpgradeHigerChance = 0;
        autoUpgradeLucky = 0;
        autoUpgradeUpgradedFlips = 0;
    }

    public void SetAllIconOff()
    {
        armIcon.SetActive(false);
        greaterIcon.SetActive(false);
        knowledgeIcon.SetActive(false);
        fistIcon.SetActive(false);
        injectionIcon.SetActive(false);
        brainIcon.SetActive(false);
        explotionIcon.SetActive(false);
        hydrationIcon.SetActive(false);
        potionIcon.SetActive(false);
        masterIcon.SetActive(false);
        handShakeIcon.SetActive(false);
        highFiveIcon.SetActive(false);
        magicIcon.SetActive(false);
        chestIcon.SetActive(false);
        ritualIcon.SetActive(false);
        autoIcon.SetActive(false);
        pileIcon.SetActive(false);
        higherChanceIcon.SetActive(false);
        luckyIcon.SetActive(false);
        upgradecIcon.SetActive(false);
        xNonIcon.SetActive(false);
    }


}
