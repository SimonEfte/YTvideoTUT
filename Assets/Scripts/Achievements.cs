using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Steamworks;
using TMPro;

public class Achievements : MonoBehaviour
{
    public int achUnlockedAmount;

    public GameObject coin1;
    public GameObject coin10;
    public GameObject coin100;
    public GameObject coin1000;
    public GameObject coin10000;
    public GameObject coin100000;
    public GameObject coin1000000;
    public GameObject coin1000000000;
    public GameObject coinBillion;
    public GameObject coinTrillion;
    public GameObject coinQuadrillion;
    public GameObject coinQuntillion;
    public GameObject coinSextillion;
    public GameObject arm1;
    public GameObject arm10;
    public GameObject greaterCoing1;
    public GameObject greaterCoin10;
    public GameObject knowledge1;
    public GameObject knowledge10;
    public GameObject fist1;
    public GameObject fist10;
    public GameObject needle1;
    public GameObject needle10;
    public GameObject brain1;
    public GameObject brain10;
    public GameObject explosion1;
    public GameObject explosion10;
    public GameObject hydration1;
    public GameObject hydration10;
    public GameObject potion1;
    public GameObject potion10;
    public GameObject masterFlipper1;
    public GameObject masterFlipper10;
    public GameObject handShake1;
    public GameObject handShake10;
    public GameObject highFive1;
    public GameObject highFive10;
    public GameObject lucky1;
    public GameObject lucky10;
    public GameObject lucky100;
    public GameObject lucky1000;
    public GameObject flipper2;
    public GameObject flipper5;
    public GameObject flipper10;
    public GameObject flipper21;
    public GameObject specialFlipper1;
    public GameObject specialFlipper5;
    public GameObject specialFlipper10;
    public GameObject specialFlipper21;
    public GameObject lucky2point5percent;
    public GameObject lucky5percent;
    public GameObject percent75;
    public GameObject percent93point75;
    public GameObject flip100;
    public GameObject flip1000;
    public GameObject flip10000;
    public GameObject flip100000;
    public GameObject flip1Million;
    public GameObject theyAllFlip;
    public GameObject tails100KTimes;
    public GameObject heads100KTimes;

    public GameObject buttonClick;

    private void Start()
    {
        StartCoroutine(SetAch());
    }

    #region Reset ach
    public void ResetAch()
    {
        coin1.SetActive(false); 
        coin10.SetActive(false); 
        coin100.SetActive(false); 
        coin1000.SetActive(false); 
        coin10000.SetActive(false); 
        coin100000.SetActive(false); 
        coin1000000.SetActive(false); 
        coin1000000000.SetActive(false); 
        coinTrillion.SetActive(false); 
        coinQuadrillion.SetActive(false); 
        coinQuntillion.SetActive(false); 
        coinSextillion.SetActive(false); 
        flip100.SetActive(false); 
        flip1000.SetActive(false); 
        flip10000.SetActive(false); 
        flip100000.SetActive(false); 
        specialFlipper1.SetActive(false); 
        specialFlipper5.SetActive(false); 
        specialFlipper10.SetActive(false); 
        specialFlipper21.SetActive(false); 
        lucky2point5percent.SetActive(false); 
        lucky5percent.SetActive(false); 
        percent75.SetActive(false); 
        percent93point75.SetActive(false); 
        percent93point75.SetActive(false); 
        arm1.SetActive(false); 
        arm10.SetActive(false); 
        greaterCoing1.SetActive(false); 
        greaterCoin10.SetActive(false); 
        knowledge1.SetActive(false); 
        knowledge10.SetActive(false); 
        fist1.SetActive(false); 
        fist10.SetActive(false); 
        needle1.SetActive(false); 
        needle10.SetActive(false); 
        brain1.SetActive(false); 
        brain10.SetActive(false); 
        explosion1.SetActive(false); 
        explosion10.SetActive(false); 
        hydration1.SetActive(false); 
        hydration10.SetActive(false); 
        potion1.SetActive(false); 
        potion10.SetActive(false); 
        masterFlipper1.SetActive(false); 
        masterFlipper10.SetActive(false); 
        handShake1.SetActive(false); 
        handShake10.SetActive(false); 
        highFive1.SetActive(false); 
        highFive10.SetActive(false); 
        lucky1.SetActive(false); 
        lucky10.SetActive(false); 
        lucky100.SetActive(false); 
        flipper2.SetActive(false); 
        flipper5.SetActive(false); 
        percent75.SetActive(false); 
        flipper10.SetActive(false); 
        flipper21.SetActive(false); 
        flip1Million.SetActive(false); 
        heads100KTimes.SetActive(false); 
        tails100KTimes.SetActive(false); 
        theyAllFlip.SetActive(false); 
         lucky1000.SetActive(false); 
    }
    #endregion

    IEnumerator SetAch()
    {
        yield return new WaitForSeconds(1f);
        if (ACH1IsUnlocked == 1) { coin1.SetActive(true); }
        if (ACH2IsUnlocked == 1) { coin10.SetActive(true); }
        if (ACH3IsUnlocked == 1) { coin100.SetActive(true); }
        if (ACH4IsUnlocked == 1) { coin1000.SetActive(true); }
        if (ACH5IsUnlocked == 1) { coin10000.SetActive(true); }
        if (ACH6IsUnlocked == 1) { coin100000.SetActive(true); }
        if (ACH7IsUnlocked == 1) { coin1000000.SetActive(true); }
        if (ACH8IsUnlocked == 1) { coin1000000000.SetActive(true); }
        if (ACH9IsUnlocked == 1) { coinTrillion.SetActive(true); }
        if (ACH10IsUnlocked == 1) { coinQuadrillion.SetActive(true); }
        if (ACH11IsUnlocked == 1) { coinQuntillion.SetActive(true); }
        if (ACH12IsUnlocked == 1) { coinSextillion.SetActive(true); }
        if (ACH13IsUnlocked == 1) { flip100.SetActive(true); }
        if (ACH14IsUnlocked == 1) { flip1000.SetActive(true); }
        if (ACH15IsUnlocked == 1) { flip10000.SetActive(true); }
        if (ACH16IsUnlocked == 1) { flip100000.SetActive(true); }
        if (ACH17IsUnlocked == 1) { specialFlipper1.SetActive(true); }
        if (ACH18IsUnlocked == 1) { specialFlipper5.SetActive(true); }
        if (ACH19IsUnlocked == 1) { specialFlipper10.SetActive(true); }
        if (ACH20IsUnlocked == 1) { specialFlipper21.SetActive(true); }
        if (ACH21IsUnlocked == 1) { lucky2point5percent.SetActive(true); }
        if (ACH22IsUnlocked == 1) { lucky5percent.SetActive(true); }
        if (ACH23IsUnlocked == 1) { percent75.SetActive(true); }
        if (ACH24IsUnlocked == 1) { percent93point75.SetActive(true); }
        if (ACH25IsUnlocked == 1) { percent93point75.SetActive(true); }
        if (ACH26IsUnlocked == 1) { arm1.SetActive(true); }
        if (ACH27IsUnlocked == 1) { arm10.SetActive(true); }
        if (ACH28IsUnlocked == 1) { greaterCoing1.SetActive(true); }
        if (ACH29IsUnlocked == 1) { greaterCoin10.SetActive(true); }
        if (ACH30IsUnlocked == 1) { knowledge1.SetActive(true); }
        if (ACH31IsUnlocked == 1) { knowledge10.SetActive(true); }
        if (ACH32IsUnlocked == 1) { fist1.SetActive(true); }
        if (ACH33IsUnlocked == 1) { fist10.SetActive(true); }
        if (ACH34IsUnlocked == 1) { needle1.SetActive(true); }
        if (ACH35IsUnlocked == 1) { needle10.SetActive(true); }
        if (ACH36IsUnlocked == 1) { brain1.SetActive(true); }
        if (ACH37IsUnlocked == 1) { brain10.SetActive(true); }
        if (ACH38IsUnlocked == 1) { explosion1.SetActive(true); }
        if (ACH39IsUnlocked == 1) { explosion10.SetActive(true); }
        if (ACH40IsUnlocked == 1) { hydration1.SetActive(true); }
        if (ACH41IsUnlocked == 1) { hydration10.SetActive(true); }
        if (ACH42IsUnlocked == 1) { potion1.SetActive(true); }
        if (ACH43IsUnlocked == 1) { potion10.SetActive(true); }
        if (ACH44IsUnlocked == 1) { masterFlipper1.SetActive(true); }
        if (ACH45IsUnlocked == 1) { masterFlipper10.SetActive(true); }
        if (ACH46IsUnlocked == 1) { handShake1.SetActive(true); }
        if (ACH47IsUnlocked == 1) { handShake10.SetActive(true); }
        if (ACH48IsUnlocked == 1) { highFive1.SetActive(true); }
        if (ACH49IsUnlocked == 1) { highFive10.SetActive(true); }
        if (ACH50IsUnlocked == 1) { lucky1.SetActive(true); }
        if (ACH51IsUnlocked == 1) { lucky10.SetActive(true); }
        if (ACH52IsUnlocked == 1) { lucky100.SetActive(true); }
        if (ACH53IsUnlocked == 1) { flipper2.SetActive(true); }
        if (ACH54IsUnlocked == 1) { flipper5.SetActive(true); }
        if (ACH55IsUnlocked == 1) { percent75.SetActive(true); }
        if (ACH56IsUnlocked == 1) { flipper10.SetActive(true); }
        if (ACH57IsUnlocked == 1) { flipper21.SetActive(true); }
        if (ACH58IsUnlocked == 1) { flip1Million.SetActive(true); }
        if (ACH59IsUnlocked == 1) { heads100KTimes.SetActive(true); }
        if (ACH60IsUnlocked == 1) { tails100KTimes.SetActive(true); }
        if (ACH61IsUnlocked == 1) { theyAllFlip.SetActive(true); }
        if (ACH62IsUnlocked == 1) { lucky1000.SetActive(true); }
    }

    /*
    public void UnlockAchievement1(string OneCoin_AC_Test)
    {
        if(GlobalCoins.CoinCount >= 1)
        {
            var ach = new Steamworks.Data.Achievement(OneCoin_AC_Test);
            
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
            
        }
    }
    public void UnlockACH2(string ACH2)
    {
        if (GlobalCoins.CoinCount >= 10)
        {
            var ach = new Steamworks.Data.Achievement(ACH2);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH3(string ID)
    {
        if (GlobalCoins.CoinCount >= 100)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH4(string ID)
    {
        if (GlobalCoins.CoinCount >= 1000)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH5(string ID)
    {
        if (GlobalCoins.CoinCount >= 10000)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH6(string ID)
    {
        if (GlobalCoins.CoinCount >= 100000)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH7(string ID)
    {
        if (GlobalCoins.CoinCount >= 1000000)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH8(string ID)
    {
        if (GlobalCoins.CoinCount >= 1000000000)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH9(string ID)
    {
        if (GlobalCoins.CoinCount >= 1000000000000)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH10(string ID)
    {
        if (GlobalCoins.CoinCount >= 1000000000000000)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH11(string ID)
    {
        if (GlobalCoins.CoinCount >= 1000000000000000000)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH12(string ID)
    {
        if (GlobalCoins.CoinCount >= 1000000000000000000000f)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH13(string ID)
    {
        if (StatsAll.flippedAmount >= 100)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH14(string ID)
    {
        if (StatsAll.flippedAmount >= 1000)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH15(string ID)
    {
        if (StatsAll.flippedAmount >= 10000)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH16(string ID)
    {
        if (StatsAll.flippedAmount >= 100000)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }

    public void UnlockACH17(string ID)
    {
        if (GoldenFlipsButton.goldenCoinsUpgradeCount >= 1)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH18(string ID)
    {
        if (GoldenFlipsButton.goldenCoinsUpgradeCount >= 5)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH19(string ID)
    {
        if (GoldenFlipsButton.goldenCoinsUpgradeCount >= 10)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH20(string ID)
    {
        if (GoldenFlipsButton.goldenCoinsUpgradeCount >= 21)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH21(string ID)
    {
        if (GetLuckyHoverOver.luckyChance >= 2.5f)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH22(string ID)
    {
        if (GetLuckyHoverOver.luckyChance >= 5f)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH23(string ID)
    {
        if (higherChanceHoverover.headsPercent >= 75 || higherChanceHoverover.tailsPercent >= 75)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH24(string ID)
    {

        if (Challenges.completedChallenge4 == 1)
        {
            if (higherChanceHoverover.headsPercent >= 83.75 || higherChanceHoverover.tailsPercent >= 83.75)
            {
                var ach = new Steamworks.Data.Achievement(ID);
                if (!ach.Trigger())
                {
                    ach.Trigger();
                }
            }
        }
        if (higherChanceHoverover.headsPercent >= 93.75 || higherChanceHoverover.tailsPercent >= 93.75)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH25(string ID)
    {
        if (MoreCoinsButton.moreCoinsUpgrades >= 1)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH26(string ID)
    {
        if (MoreCoinsButton.moreCoinsUpgrades >= 10)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }

    public void UnlockACH27(string ID)
    {
        if (MoreCoinsButton.greaterCoinsCount >= 1)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH28(string ID)
    {
        if (MoreCoinsButton.greaterCoinsCount >= 10)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH29(string ID)
    {
        if (KnowledgeUpgrade.knowledgeUpgradeCount >= 1)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH30(string ID)
    {
        if (KnowledgeUpgrade.knowledgeUpgradeCount >= 10)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH31(string ID)
    {
        if (StrongerFist.fistUpgradeCount >= 1)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH32(string ID)
    {
        if (StrongerFist.fistUpgradeCount >= 10)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH33(string ID)
    {
        if (HandInecjtion.injectionUpgradeCount >= 1)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH34(string ID)
    {
        if (HandInecjtion.injectionUpgradeCount >= 10)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH35(string ID)
    {
        if (BrainPower.brainPowerUpgradeCount >= 1)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH36(string ID)
    {
        if (BrainPower.brainPowerUpgradeCount >= 10)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }

    public void UnlockACH37(string ID)
    {
        if (ExplosiveFlips.explosiveUpgradeCount >= 1)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH38(string ID)
    {
        if (ExplosiveFlips.explosiveUpgradeCount >= 10)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH39(string ID)
    {
        if (HydrationButton.hydrationUpgradeCount >= 1)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH40(string ID)
    {
        if (HydrationButton.hydrationUpgradeCount >= 10)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH41(string ID)
    {
        if (StrangePotion.potionUpgradeCount >= 1)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH42(string ID)
    {
        if (StrangePotion.potionUpgradeCount >= 10)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH43(string ID)
    {
        if (MasterFlipper.MasterFlipsUpgradeCount >= 1)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH44(string ID)
    {
        if (MasterFlipper.MasterFlipsUpgradeCount >= 10)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH45(string ID)
    {
        if (HandShake.handShakeUpgradeCount >= 1)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH46(string ID)
    {
        if (HandShake.handShakeUpgradeCount >= 10)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH47(string ID)
    {
        if (StatsAll.luckyCoinsAmount >= 1)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH48(string ID)
    {
        if (StatsAll.luckyCoinsAmount >= 10)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH49(string ID)
    {
        if (StatsAll.luckyCoinsAmount >= 100)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH50(string ID)
    {
        if (MainButtonClick.numberOfDuplicationUpgrades >= 1)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH51(string ID)
    {
        if (MainButtonClick.numberOfDuplicationUpgrades >= 4)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH52(string ID)
    {
        if (MainButtonClick.numberOfDuplicationUpgrades >= 9)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH53(string ID)
    {
        if (MainButtonClick.numberOfDuplicationUpgrades >= 20)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH54(string ID)
    {
        if (Upgrade12.upgrade12Count >= 1)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockACH55(string ID)
    {
        if (Upgrade12.upgrade12Count >= 10)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockAchievement56(string ID)
    {
        if (StatsAll.flippedAmount >= 1000000)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement57(string ID)
    {
        if (StatsAll.luckyCoinsAmount >= 1000)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement58(string ID)
    {
        if (StatsAll.headsFlippedAmount >= 100000)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement59(string ID)
    {
        if (StatsAll.tailsFlippedAmount >= 100000)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockAchievement60(string ID)
    {
        if (GlobalCoinMaker.coinsPerFlipUpgrades == 21)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    */

    public static int ACH1IsUnlocked = 0;
    public static int ACH2IsUnlocked = 0;
    public static int ACH3IsUnlocked = 0;
    public static int ACH4IsUnlocked = 0;
    public static int ACH5IsUnlocked = 0;
    public static int ACH6IsUnlocked = 0;
    public static int ACH7IsUnlocked = 0;
    public static int ACH8IsUnlocked = 0;
    public static int ACH9IsUnlocked = 0;
    public static int ACH10IsUnlocked = 0;
    public static int ACH11IsUnlocked = 0;
    public static int ACH12IsUnlocked = 0;
    public static int ACH13IsUnlocked = 0;
    public static int ACH14IsUnlocked = 0;
    public static int ACH15IsUnlocked = 0;
    public static int ACH16IsUnlocked = 0;
    public static int ACH17IsUnlocked = 0;
    public static int ACH18IsUnlocked = 0;
    public static int ACH19IsUnlocked = 0;
    public static int ACH20IsUnlocked = 0;
    public static int ACH21IsUnlocked = 0;
    public static int ACH22IsUnlocked = 0;
    public static int ACH23IsUnlocked = 0;
    public static int ACH24IsUnlocked = 0;
    public static int ACH25IsUnlocked = 0;
    public static int ACH26IsUnlocked = 0;
    public static int ACH27IsUnlocked = 0;
    public static int ACH28IsUnlocked = 0;
    public static int ACH29IsUnlocked = 0;
    public static int ACH30IsUnlocked = 0;
    public static int ACH31IsUnlocked = 0;
    public static int ACH32IsUnlocked = 0;
    public static int ACH33IsUnlocked = 0;
    public static int ACH34IsUnlocked = 0;
    public static int ACH35IsUnlocked = 0;
    public static int ACH36IsUnlocked = 0;
    public static int ACH37IsUnlocked = 0;
    public static int ACH38IsUnlocked = 0;
    public static int ACH39IsUnlocked = 0;
    public static int ACH40IsUnlocked = 0;
    public static int ACH41IsUnlocked = 0;
    public static int ACH42IsUnlocked = 0;
    public static int ACH43IsUnlocked = 0;
    public static int ACH44IsUnlocked = 0;
    public static int ACH45IsUnlocked = 0;
    public static int ACH46IsUnlocked = 0;
    public static int ACH47IsUnlocked = 0;
    public static int ACH48IsUnlocked = 0;
    public static int ACH49IsUnlocked = 0;
    public static int ACH50IsUnlocked = 0;
    public static int ACH51IsUnlocked = 0;
    public static int ACH52IsUnlocked = 0;
    public static int ACH53IsUnlocked = 0;
    public static int ACH54IsUnlocked = 0;
    public static int ACH55IsUnlocked = 0;
    public static int ACH56IsUnlocked = 0;
    public static int ACH57IsUnlocked = 0;
    public static int ACH58IsUnlocked = 0;
    public static int ACH59IsUnlocked = 0;
    public static int ACH60IsUnlocked = 0;
    public static int ACH61IsUnlocked = 0;
    public static int ACH62IsUnlocked = 0;

    void Update()
    {
        if (GlobalCoins.CoinCount >= 1)
        {
            if (ACH1IsUnlocked == 0)
            {
                coin1.SetActive(true);
                achUnlockedAmount += 1;
                if(LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH1IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH1", Achievements.ACH1IsUnlocked);
            }
        }
        
        if (GlobalCoins.CoinCount >= 10)
        {
            if (ACH2IsUnlocked == 0)
            {
                coin10.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH2IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH2", Achievements.ACH2IsUnlocked);
            }
        }
       
        if (GlobalCoins.CoinCount >= 100)
        {
            if (ACH3IsUnlocked == 0)
            {
                coin100.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH3IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH3", Achievements.ACH3IsUnlocked);
            }
        }
        
        if (GlobalCoins.CoinCount >= 1000) {
            if (ACH4IsUnlocked == 0)
            {
                coin1000.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH4IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH4", Achievements.ACH4IsUnlocked);
            }
        }
       
        if (GlobalCoins.CoinCount >= 10000) 
        {
            if (ACH5IsUnlocked == 0)
            {
                coin10000.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH5IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH5", Achievements.ACH5IsUnlocked);
            }
        }
        
        if (GlobalCoins.CoinCount >= 100000)
        {
            if (ACH6IsUnlocked == 0)
            {
                coin100000.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH6IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH6", Achievements.ACH6IsUnlocked);
            }
        }
      
        if (GlobalCoins.CoinCount >= 1000000)
        { 
            if (ACH7IsUnlocked == 0)
            {
                coin1000000.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH7IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH7", Achievements.ACH7IsUnlocked);
            }
        }
        
        if (GlobalCoins.CoinCount >= 1000000000)
        { 
            if (ACH8IsUnlocked == 0)
            {
                coin1000000000.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH8IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH8", Achievements.ACH8IsUnlocked);
            }
        }

        if (GlobalCoins.CoinCount >= 1000000000000) { 
            if (ACH9IsUnlocked == 0)
            {
                coinTrillion.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH9IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH9", Achievements.ACH9IsUnlocked);
            }
        }

        if (GlobalCoins.CoinCount >= 1000000000000000) { 
            if (ACH10IsUnlocked == 0)
            {
                coinQuadrillion.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH10IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH10", Achievements.ACH10IsUnlocked);
            }
        }

        if (GlobalCoins.CoinCount >= 1000000000000000000) {
            if (ACH11IsUnlocked == 0)
            {
                coinQuntillion.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH11IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH11", Achievements.ACH11IsUnlocked);
            }
        }

        if (GlobalCoins.CoinCount >= 1000000000000000000000f) { 
            if (ACH12IsUnlocked == 0)
            {
                coinSextillion.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH12IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH12", Achievements.ACH12IsUnlocked);
            }
        }

        if(StatsAll.flippedAmount >= 100)
        { 
            if (ACH13IsUnlocked == 0)
            {
                flip100.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH13IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH13", Achievements.ACH13IsUnlocked);
            }
        }

        if (StatsAll.flippedAmount >= 1000)
        {
            if (ACH14IsUnlocked == 0)
            {
                flip1000.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH14IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH14", Achievements.ACH14IsUnlocked);
            }
        }

        if (StatsAll.flippedAmount >= 10000)
        {
            if (ACH15IsUnlocked == 0)
            {
                flip10000.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH15IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH15", Achievements.ACH15IsUnlocked);
            }
        }

        if (StatsAll.flippedAmount >= 100000) 
        { 
            if (ACH16IsUnlocked == 0)
            {
                flip100000.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH16IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH16", Achievements.ACH16IsUnlocked);
            }
        }

        if (GoldenFlipsButton.goldenCoinsUpgradeCount  >= 1) 
        { 
            if (ACH17IsUnlocked == 0)
            {
                specialFlipper1.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH17IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH17", Achievements.ACH17IsUnlocked);
            }
        }

        if (GoldenFlipsButton.goldenCoinsUpgradeCount >= 5) {
            if (ACH18IsUnlocked == 0)
            {
                specialFlipper5.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH18IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH18", Achievements.ACH18IsUnlocked);
            }
        }

        if (GoldenFlipsButton.goldenCoinsUpgradeCount >= 10) { 
            if (ACH19IsUnlocked == 0)
            {
                specialFlipper10.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH19IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH19", Achievements.ACH19IsUnlocked);
            }
        }

        if (GoldenFlipsButton.goldenCoinsUpgradeCount >= 21)
        { 
            if (ACH20IsUnlocked == 0)
            {
                specialFlipper21.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH20IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH20", Achievements.ACH20IsUnlocked);
            }
        }

        if(GetLuckyHoverOver.luckyChance >= 2.5f) 
        { 
            if (ACH21IsUnlocked == 0)
            {
                lucky2point5percent.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH21IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH21", Achievements.ACH21IsUnlocked);
            }
        }

        if (GetLuckyHoverOver.luckyChance >= 5f) 
        { 
            if (ACH22IsUnlocked == 0)
            {
                lucky5percent.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH22IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH22", Achievements.ACH22IsUnlocked);
            }
        }

        if(EnterText.choseHeads == 1)
        {
            if (higherChanceHoverover.headsPercent >= 75) { 
                if (ACH23IsUnlocked == 0)
                {
                    percent75.SetActive(true);
                    achUnlockedAmount += 1;
                    if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                    ACH23IsUnlocked = 1;
                    PlayerPrefs.SetInt("ACH23", Achievements.ACH23IsUnlocked);
                }
            }

            if (Challenges.completedChallenge4 == 1)
            {
                if (higherChanceHoverover.headsPercent >= 83.75 || higherChanceHoverover.tailsPercent >= 83.75)
                {
                    if (ACH24IsUnlocked == 0)
                    {
                        percent93point75.SetActive(true);
                        achUnlockedAmount += 1;
                        if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                        ACH24IsUnlocked = 1;
                        PlayerPrefs.SetInt("ACH24", Achievements.ACH24IsUnlocked);
                    }
                }
            }
            

            if (higherChanceHoverover.headsPercent >= 93.75) { 
                if (ACH24IsUnlocked == 0)
                {
                    percent93point75.SetActive(true);
                    achUnlockedAmount += 1;
                    if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                    ACH24IsUnlocked = 1;
                    PlayerPrefs.SetInt("ACH24", Achievements.ACH24IsUnlocked);
                }
            }
        }
        if (EnterText.choseTails == 1)
        {

            if (Challenges.completedChallenge4 == 1)
            {
                if (higherChanceHoverover.headsPercent >= 83.75 || higherChanceHoverover.tailsPercent >= 83.75)
                {
                    if (ACH24IsUnlocked == 0)
                    {
                        percent93point75.SetActive(true);
                        achUnlockedAmount += 1;
                        if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                        ACH24IsUnlocked = 1;
                        PlayerPrefs.SetInt("ACH24", Achievements.ACH24IsUnlocked);
                    }
                }
            }

            if (higherChanceHoverover.tailsPercent >= 93.75f) 
            {
                if (ACH25IsUnlocked == 0)
                {
                    percent93point75.SetActive(true);
                    achUnlockedAmount += 1;
                    if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                    ACH25IsUnlocked = 1;
                    PlayerPrefs.SetInt("ACH25", Achievements.ACH25IsUnlocked);
                }
            }

            if (higherChanceHoverover.tailsPercent >= 75f) 
            { 
                if (ACH55IsUnlocked == 0)
                {
                    percent75.SetActive(true);
                    achUnlockedAmount += 1;
                    if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                    ACH55IsUnlocked = 1;
                    PlayerPrefs.SetInt("ACH55", Achievements.ACH55IsUnlocked);
                }
            }
        }

        if (MoreCoinsButton.moreCoinsUpgrades >= 1) 
        { 
            if (ACH26IsUnlocked == 0)
            {
                arm1.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH26IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH26", Achievements.ACH26IsUnlocked);
            }
        }
        if (MoreCoinsButton.moreCoinsUpgrades >= 10)
        { 
            if (ACH27IsUnlocked == 0)
            {
                arm10.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH27IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH27", Achievements.ACH27IsUnlocked);
            }
        }

        if(MoreCoinsButton.greaterCoinsCount >= 1) { 
            if (ACH28IsUnlocked == 0)
            {
                greaterCoing1.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH28IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH28", Achievements.ACH28IsUnlocked);
            }
        }
        if (MoreCoinsButton.greaterCoinsCount >= 10) 
        {
            if (ACH29IsUnlocked == 0)
            {
                greaterCoin10.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH29IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH29", Achievements.ACH29IsUnlocked);
            }
        }

        if(KnowledgeUpgrade.knowledgeUpgradeCount >= 1)
        { 
            if (ACH30IsUnlocked == 0)
            {
                knowledge1.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH30IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH30", Achievements.ACH30IsUnlocked);
            }
        }
        if (KnowledgeUpgrade.knowledgeUpgradeCount >= 10) 
        { 
            if (ACH31IsUnlocked == 0)
            {
                knowledge10.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH31IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH31", Achievements.ACH31IsUnlocked);
            }
        }

        if(StrongerFist.fistUpgradeCount >= 1) {
            if (ACH32IsUnlocked == 0)
            {
                fist1.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH32IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH32", Achievements.ACH32IsUnlocked);
            }
        }
        if (StrongerFist.fistUpgradeCount >= 10)
        {
            if (ACH33IsUnlocked == 0)
            {
                fist10.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH33IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH33", Achievements.ACH33IsUnlocked);
            }
        }

        if(HandInecjtion.injectionUpgradeCount >= 1) 
        { 
            if (ACH34IsUnlocked == 0)
            {
                needle1.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH34IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH34", Achievements.ACH34IsUnlocked);
            }
        }
        if (HandInecjtion.injectionUpgradeCount >= 10)
        { 
            if (ACH35IsUnlocked == 0)
            {
                needle10.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH35IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH35", Achievements.ACH35IsUnlocked);
            }
        }

        if(BrainPower.brainPowerUpgradeCount >= 1) 
        { 
            if (ACH36IsUnlocked == 0)
            {
                brain1.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH36IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH36", Achievements.ACH36IsUnlocked);
            }
        }
        if (BrainPower.brainPowerUpgradeCount >= 10) 
        {
            if (ACH37IsUnlocked == 0)
            {
                brain10.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH37IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH37", Achievements.ACH37IsUnlocked);
            }
        }

        if(ExplosiveFlips.explosiveUpgradeCount >= 1) { 
            if (ACH38IsUnlocked == 0)
            {
                explosion1.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH38IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH38", Achievements.ACH38IsUnlocked);
            }
        }
        if (ExplosiveFlips.explosiveUpgradeCount >= 10) { 
            if (ACH39IsUnlocked == 0)
            {
                explosion10.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH39IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH39", Achievements.ACH39IsUnlocked);
            }
        }

        if(HydrationButton.hydrationUpgradeCount >= 1 ) {
            if (ACH40IsUnlocked == 0)
            {
                hydration1.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH40IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH40", Achievements.ACH40IsUnlocked);
            }
        }
        if (HydrationButton.hydrationUpgradeCount >= 10) { 
            if (ACH41IsUnlocked == 0)
            {
                hydration10.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH41IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH41", Achievements.ACH41IsUnlocked);
            }
        }

        if(StrangePotion.potionUpgradeCount >= 1)
        { 
            if (ACH42IsUnlocked == 0)
            {
                potion1.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH42IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH42", Achievements.ACH42IsUnlocked);
            }
        }
        if (StrangePotion.potionUpgradeCount >= 10) 
        {
            if (ACH43IsUnlocked == 0)
            {
                potion10.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH43IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH43", Achievements.ACH43IsUnlocked);
            }
        }

        if(MasterFlipper.MasterFlipsUpgradeCount >= 1) { 
            if (ACH44IsUnlocked == 0)
            {
                masterFlipper1.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH44IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH44", Achievements.ACH44IsUnlocked);
            }
        }
        if (MasterFlipper.MasterFlipsUpgradeCount >= 10) {
            if (ACH45IsUnlocked == 0)
            {
                masterFlipper10.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH45IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH45", Achievements.ACH45IsUnlocked);
            }
        }

        if(HandShake.handShakeUpgradeCount >= 1) { 
            if (ACH46IsUnlocked == 0)
            {
                handShake1.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH46IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH46", Achievements.ACH46IsUnlocked);
            }
        }
        if (HandShake.handShakeUpgradeCount >= 10) {
            if (ACH47IsUnlocked == 0)
            {
                handShake10.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH47IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH47", Achievements.ACH47IsUnlocked);
            }
        }

        if (Upgrade12.upgrade12Count >= 1) { 
            if (ACH48IsUnlocked == 0)
            {
                highFive1.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH48IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH48", Achievements.ACH48IsUnlocked);
            }
        }
        if (Upgrade12.upgrade12Count >= 10)
        {
            if (ACH49IsUnlocked == 0)
            {
                highFive10.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH49IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH49", Achievements.ACH49IsUnlocked);
            }
        }

        if (StatsAll.luckyCoinsAmount >= 1)
        { 
            if (ACH50IsUnlocked == 0)
            {
                lucky1.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH50IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH50", Achievements.ACH50IsUnlocked);
            }
        }

        if (StatsAll.luckyCoinsAmount >= 10) 
        { 
            if (ACH51IsUnlocked == 0)
            {
                lucky10.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH51IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH51", Achievements.ACH51IsUnlocked);
            }
        }
        if (StatsAll.luckyCoinsAmount >= 100)
        { 
            if (ACH52IsUnlocked == 0)
            {
                lucky100.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH52IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH52", Achievements.ACH52IsUnlocked);
            }
        }

        if(MainButtonClick.numberOfDuplicationUpgrades >= 1) { 
            if (ACH53IsUnlocked == 0)
            {
                flipper2.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH53IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH53", Achievements.ACH53IsUnlocked);
            }
        }
        if (MainButtonClick.numberOfDuplicationUpgrades >= 4) { 
            if (ACH54IsUnlocked == 0)
            {
                flipper5.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH54IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH54", Achievements.ACH54IsUnlocked);
            }
        }
    
        if (MainButtonClick.numberOfDuplicationUpgrades >= 9) { 
            if (ACH56IsUnlocked == 0)
            {
                flipper10.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH56IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH56", Achievements.ACH56IsUnlocked);
            }
        }
     
        if (MainButtonClick.numberOfDuplicationUpgrades >= 20) { 
            if (ACH57IsUnlocked == 0)
            {
                flipper21.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH57IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH57", Achievements.ACH57IsUnlocked);
            }
        }
  

        if (StatsAll.flippedAmount >= 1000000)
        {
            if (ACH58IsUnlocked == 0)
            {
                achUnlockedAmount += 1;
                flip1Million.SetActive(true);
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH58IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH58", Achievements.ACH58IsUnlocked);
            }
        }
      

        //headsFlipped 100K
        if (StatsAll.headsFlippedAmount >= 100000)
        {
            if (ACH59IsUnlocked == 0)
            {
                achUnlockedAmount += 1;
                heads100KTimes.SetActive(true);
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH59IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH59", Achievements.ACH59IsUnlocked);
            }
        }
   


        //tailsFlipped 100K
        if (StatsAll.tailsFlippedAmount >= 100000)
        {
            if (ACH60IsUnlocked == 0)
            {
                tails100KTimes.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH60IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH60", Achievements.ACH60IsUnlocked);
            }
        }
     

        //AllFlips
        if (GlobalCoinMaker.coinsPerFlipUpgrades == 21)
        {
            if (ACH61IsUnlocked == 0)
            {
                theyAllFlip.SetActive(true);
                achUnlockedAmount += 1;
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH61IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH61", Achievements.ACH61IsUnlocked);
            }
        }

        //Lucky1K
        if (StatsAll.luckyCoinsAmount >= 1000)
        {
            if (ACH62IsUnlocked == 0)
            {
                achUnlockedAmount += 1;
                lucky1000.SetActive(true);
                if (LoadSaves.isMobileBuild == false) { buttonClick.GetComponent<Button>().onClick.Invoke(); }
                ACH62IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH62", Achievements.ACH62IsUnlocked);
            }
        }
    }
}
