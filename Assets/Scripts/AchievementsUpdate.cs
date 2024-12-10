using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Steamworks;
using TMPro;

public class AchievementsUpdate : MonoBehaviour
{
    public GameObject SeptillionCoins;
    public GameObject AscensionUpgrades5;
    public GameObject AscensionUpgrades10;
    public GameObject AscensionUpgrades20;
    public GameObject AscensionUpgrades30;
    public GameObject AscensionUpgradesALL;
    public GameObject AscensionCoins25;
    public GameObject AscensionCoins50;
    public GameObject AscensionCoins75;
    public GameObject AscendOnce;
    public GameObject Ascend5Times;
    public GameObject hiddenBronze;
    public GameObject hiddenSilver;
    public GameObject gamble10Times;
    public GameObject gamble5Lose;
    public GameObject gamble5Won;
    public GameObject Magic1;
    public GameObject Magic10;
    public GameObject pile10;
    public GameObject pile100;

    public GameObject challenge1;
    public GameObject challenge2;
    public GameObject challenge3;
    public GameObject challenge4;
    public GameObject octillion1;
    public GameObject activeFlips100;
    public GameObject activeFlips1000;
    public GameObject activeFlips5000;
    public GameObject chest1;
    public GameObject chest10;
    public GameObject ritual1;
    public GameObject ritual10;
    public GameObject autoUpgrade;

    public static int ACH1IsUnlocked;
    public static int ACH2IsUnlocked;
    public static int ACH3IsUnlocked;
    public static int ACH4IsUnlocked;
    public static int ACH5IsUnlocked;
    public static int ACH6IsUnlocked;
    public static int ACH7IsUnlocked;
    public static int ACH8IsUnlocked;
    public static int ACH9IsUnlocked;
    public static int ACH10IsUnlocked;
    public static int ACH11IsUnlocked;
    public static int ACH12IsUnlocked;
    public static int ACH13IsUnlocked;
    public static int ACH14IsUnlocked;
    public static int ACH15IsUnlocked;
    public static int ACH16IsUnlocked;
    public static int ACH17IsUnlocked;
    public static int ACH18IsUnlocked;
    public static int ACH19IsUnlocked;
    public static int ACH20IsUnlocked;

    public static int ACH21IsUnlocked;
    public static int ACH22IsUnlocked;
    public static int ACH23IsUnlocked;
    public static int ACH24IsUnlocked;
    public static int ACH25IsUnlocked;
    public static int ACH26IsUnlocked;
    public static int ACH27IsUnlocked;
    public static int ACH28IsUnlocked;
    public static int ACH29IsUnlocked;
    public static int ACH30IsUnlocked;
    public static int ACH31IsUnlocked;
    public static int ACH32IsUnlocked;
    public static int ACH33IsUnlocked;

    public GameObject button;

    public void Start()
    {
        StartCoroutine(SetAch());
    }

    #region Reset ach
    public void ResetAch()
    {
        SeptillionCoins.SetActive(false); 
        AscensionUpgrades5.SetActive(false); 
        AscensionUpgrades10.SetActive(false); 
        AscensionUpgrades20.SetActive(false); 
        AscensionUpgrades30.SetActive(false); 
        AscensionUpgradesALL.SetActive(false); 
        AscensionCoins25.SetActive(false); 
        AscensionCoins50.SetActive(false); 
        AscensionCoins75.SetActive(false); 
        AscendOnce.SetActive(false); 
        Ascend5Times.SetActive(false); 
        gamble10Times.SetActive(false); 
        gamble5Won.SetActive(false); 
        Magic1.SetActive(false); 
        Magic10.SetActive(false); 
        pile10.SetActive(false); 
        pile100.SetActive(false); 
        hiddenBronze.SetActive(false); 
        hiddenSilver.SetActive(false); 
        gamble5Lose.SetActive(false); 

        challenge1.SetActive(false); 
        challenge2.SetActive(false); 
        challenge3.SetActive(false); 
        challenge4.SetActive(false); 
        activeFlips100.SetActive(false); 
        activeFlips1000.SetActive(false); 
        activeFlips5000.SetActive(false); 
        chest1.SetActive(false); 
        chest10.SetActive(false); 
        ritual1.SetActive(false); 
        ritual10.SetActive(false); 
        autoUpgrade.SetActive(false); 
        octillion1.SetActive(false); 
    }
    #endregion

    IEnumerator SetAch()
    {
        yield return new WaitForSeconds(1f);
        if (ACH1IsUnlocked == 1) { SeptillionCoins.SetActive(true); CheckACHUnlocked("1Septillion"); }
        if (ACH2IsUnlocked == 1) { AscensionUpgrades5.SetActive(true); CheckACHUnlocked("5InflationUpgrades"); }
        if (ACH3IsUnlocked == 1) { AscensionUpgrades10.SetActive(true); CheckACHUnlocked("10InflationUpgrades"); }
        if (ACH4IsUnlocked == 1) { AscensionUpgrades20.SetActive(true); CheckACHUnlocked("29InflationUpgrades"); }
        if (ACH5IsUnlocked == 1) { AscensionUpgrades30.SetActive(true); CheckACHUnlocked("30InflationUpgrades"); }
        if (ACH6IsUnlocked == 1) { AscensionUpgradesALL.SetActive(true); CheckACHUnlocked("AllInfaltion"); }
        if (ACH7IsUnlocked == 1) { AscensionCoins25.SetActive(true); CheckACHUnlocked("25InfaltionCoins"); }
        if (ACH8IsUnlocked == 1) { AscensionCoins50.SetActive(true); CheckACHUnlocked("50InfaltionCoins"); }
        if (ACH9IsUnlocked == 1) { AscensionCoins75.SetActive(true); CheckACHUnlocked("75InfaltionCoins"); }
        if (ACH10IsUnlocked == 1) { AscendOnce.SetActive(true); CheckACHUnlocked("inflate1"); }
        if (ACH11IsUnlocked == 1) { Ascend5Times.SetActive(true); CheckACHUnlocked("inflate5"); }
        if (ACH12IsUnlocked == 1) { gamble10Times.SetActive(true); CheckACHUnlocked("gamble10"); }
        if (ACH13IsUnlocked == 1) { gamble5Won.SetActive(true); CheckACHUnlocked("gamblewon"); }
        if (ACH14IsUnlocked == 1) { Magic1.SetActive(true); CheckACHUnlocked("Magic1"); }
        if (ACH15IsUnlocked == 1) { Magic10.SetActive(true); CheckACHUnlocked("Mafic10"); }
        if (ACH16IsUnlocked == 1) { pile10.SetActive(true); CheckACHUnlocked("pile10"); }
        if (ACH17IsUnlocked == 1) { pile100.SetActive(true); CheckACHUnlocked("pile100"); }
        if (ACH18IsUnlocked == 1) { hiddenBronze.SetActive(true); CheckACHUnlocked("HiddenBronce"); }
        if (ACH19IsUnlocked == 1) { hiddenSilver.SetActive(true); CheckACHUnlocked("HiddenSilver"); }
        if (ACH20IsUnlocked == 1) { gamble5Lose.SetActive(true); CheckACHUnlocked("gamblelost"); }

        if (ACH21IsUnlocked == 1) { challenge1.SetActive(true); CheckACHUnlocked("challenge1"); }
        if (ACH22IsUnlocked == 1) { challenge2.SetActive(true); CheckACHUnlocked("challenge2"); }
        if (ACH23IsUnlocked == 1) { challenge3.SetActive(true); CheckACHUnlocked("challenge3"); }
        if (ACH24IsUnlocked == 1) { challenge4.SetActive(true); CheckACHUnlocked("challenge4"); }
        if (ACH25IsUnlocked == 1) { activeFlips100.SetActive(true); CheckACHUnlocked("100Active"); }
        if (ACH26IsUnlocked == 1) { activeFlips1000.SetActive(true); CheckACHUnlocked("1000Active"); }
        if (ACH27IsUnlocked == 1) { activeFlips5000.SetActive(true); CheckACHUnlocked("5000Active"); }
        if (ACH28IsUnlocked == 1) { chest1.SetActive(true); CheckACHUnlocked("1chest"); }
        if (ACH29IsUnlocked == 1) { chest10.SetActive(true); CheckACHUnlocked("10chest"); }
        if (ACH30IsUnlocked == 1) { ritual1.SetActive(true); CheckACHUnlocked("1ritual"); }
        if (ACH31IsUnlocked == 1) { ritual10.SetActive(true); CheckACHUnlocked("10ritual"); }
        if (ACH32IsUnlocked == 1) { autoUpgrade.SetActive(true); CheckACHUnlocked("auto"); }
        if (ACH33IsUnlocked == 1) { octillion1.SetActive(true); CheckACHUnlocked("1oct"); }
    }

    public void CheckACHUnlocked(string achName)
    {
         //var ach = new Steamworks.Data.Achievement(achName);
         //
         //if (ach.State == false)
         //{
         //ach.Trigger();
         //}
    }

   /*
    
    public void UnlockAchievement1(string ID)
    {
        if (GlobalCoins.CoinCount >= 1000000000000000000000000f)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }

    public void UnlockAchievement2(string ID)
    {
        if (AscendScreen.ascendUpgradeAmount >= 5)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockAchievement3(string ID)
    {
        if (AscendScreen.ascendUpgradeAmount >= 10)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement4(string ID)
    {
        if (AscendScreen.ascendUpgradeAmount >= 20)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement5(string ID)
    {
        if (AscendScreen.ascendUpgradeAmount >= 30)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement6(string ID)
    {
        if (AscendScreen.ascendUpgradeAmount >= 44)
        {
            var ach = new Steamworks.Data.Achievement(ID);
            ach.Trigger();

        }
    }
    public void UnlockAchievement7(string ID)
    {
        if (AscendCoins.ascensionCoinAmount >= 25)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement8(string ID)
    {
        if (AscendCoins.ascensionCoinAmount >= 50)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement9(string ID)
    {
        if (AscendCoins.ascensionCoinAmount >= 75)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement10(string ID)
    {
        if (Ascend.AscendTimesAmount >= 1)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement11(string ID)
    {
        if (Ascend.AscendTimesAmount >= 5)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement12(string ID)
    {
        if (PurchaseLog.amountOfTimesGambled >= 10)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement13(string ID)
    {
        if (PurchaseLog.amountOfTimesGambledWON >= 5)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement14(string ID)
    {
        if (PurchaseLog.amountOfTimesGambledLOST >= 5)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement15(string ID)
    {
        if (MagicFlipsUpgrade.magicUpgradeCount >= 1)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement16(string ID)
    {
        if (MagicFlipsUpgrade.magicUpgradeCount >= 10)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement17(string ID)
    {
        if (PileOfCoinsMechanics.incrementPileOfCoinsAmount >= 10)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement18(string ID)
    {
        if (PileOfCoinsMechanics.incrementPileOfCoinsAmount >= 100)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement19(string ID)
    {
        if (hiddenCoins.foundBronce == 1)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement20(string ID)
    {
        if (hiddenCoins.foundSilver == 1)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }

    //1.2

    public void UnlockAchievement21(string ID)
    {
        if (Challenges.completedChallenge1 == 1)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement22(string ID)
    {
        if (Challenges.completedChallenge2 == 1)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement23(string ID)
    {
        if (Challenges.completedChallenge3 == 1)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement24(string ID)
    {
        if (Challenges.completedChallenge4 == 1)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement25(string ID)
    {
        if (MainButtonClick.activeFlipsAmount >= 100)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement26(string ID)
    {
        if (MainButtonClick.activeFlipsAmount >= 1000)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement27(string ID)
    {
        if (MainButtonClick.activeFlipsAmount >= 5000)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement28(string ID)
    {
        if (TreasureChest.treasureCount >= 1)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement29(string ID)
    {
        if (TreasureChest.treasureCount >= 10)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockAchievement30(string ID)
    {
        if (RitualUpgrade.treasureCount >= 1)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockAchievement31(string ID)
    {
        if (RitualUpgrade.treasureCount >= 10)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }
        }
    }
    public void UnlockAchievement32(string ID)
    {
        if (AscendScreen.boughtAuto == 1)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
    public void UnlockAchievement33(string ID)
    {
        if (GlobalCoins.CoinCount >= 1000000000000000000000000000f)
        {
            var ach = new Steamworks.Data.Achievement(ID);

            if (!ach.Trigger())
            {
                ach.Trigger();
            }

        }
    }
   */

    public void Update()
    {
        if (GlobalCoins.CoinCount >= 1000000000000000000000000f)
        {
            if (ACH1IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH1IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH63", AchievementsUpdate.ACH1IsUnlocked);
                SeptillionCoins.SetActive(true);
            }
        }

        if (AscendScreen.ascendUpgradeAmount >= 5)
        {
            if (ACH2IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH2IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH64", AchievementsUpdate.ACH2IsUnlocked);
                AscensionUpgrades5.SetActive(true);
            }
        }

        if (AscendScreen.ascendUpgradeAmount >= 10)
        {
            if (ACH3IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH3IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH65", AchievementsUpdate.ACH3IsUnlocked);
                AscensionUpgrades10.SetActive(true);
            }
        }

        if (AscendScreen.ascendUpgradeAmount >= 20)
        {

            if (ACH4IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH4IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH66", AchievementsUpdate.ACH4IsUnlocked);
                AscensionUpgrades20.SetActive(true);
            }
        }

        if (AscendScreen.ascendUpgradeAmount >= 30)
        {
            if (ACH5IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH5IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH67", AchievementsUpdate.ACH5IsUnlocked);
                AscensionUpgrades30.SetActive(true);
            }
        }

        if (AscendScreen.ascendUpgradeAmount >= 44)
        {
            if (ACH6IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH6IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH68", AchievementsUpdate.ACH6IsUnlocked);
                AscensionUpgradesALL.SetActive(true);
            }
        }

        if (AscendCoins.ascensionCoinAmount >= 25)
        {
            if (ACH7IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH7IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH69", AchievementsUpdate.ACH7IsUnlocked);
                AscensionCoins25.SetActive(true);
            }
        }

        if (AscendCoins.ascensionCoinAmount >= 50)
        {
            if (ACH8IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH8IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH70", AchievementsUpdate.ACH8IsUnlocked);
                AscensionCoins50.SetActive(true);
            }
        }

        if (AscendCoins.ascensionCoinAmount >= 75)
        {
            if (ACH9IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH9IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH71", AchievementsUpdate.ACH9IsUnlocked);
                AscensionCoins75.SetActive(true);
            }
        }

        if (Ascend.AscendTimesAmount >= 1)
        {
            if (ACH10IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH10IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH72", AchievementsUpdate.ACH10IsUnlocked);
                AscendOnce.SetActive(true);
            }
        }

        if (Ascend.AscendTimesAmount >= 5)
        {
            if (ACH11IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH11IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH73", AchievementsUpdate.ACH11IsUnlocked);
                Ascend5Times.SetActive(true);
            }
        }

        if (PurchaseLog.amountOfTimesGambled >= 10)
        {
            if (ACH12IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH12IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH74", AchievementsUpdate.ACH12IsUnlocked);

                gamble10Times.SetActive(true);
            }
        }

        if (PurchaseLog.amountOfTimesGambledWON >= 5)
        {
            if (ACH13IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH13IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH75", AchievementsUpdate.ACH13IsUnlocked);
                gamble5Won.SetActive(true);
            }
        }

        if (PurchaseLog.amountOfTimesGambledLOST >= 5)
        {
            if (ACH20IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH20IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH82", AchievementsUpdate.ACH20IsUnlocked);
                gamble5Lose.SetActive(true);
            }
        }

        if (MagicFlipsUpgrade.magicUpgradeCount >= 1)
        {
            if (ACH14IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH14IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH76", AchievementsUpdate.ACH14IsUnlocked);

                Magic1.SetActive(true);
            }
        }

        if (MagicFlipsUpgrade.magicUpgradeCount >= 10)
        {
            if (ACH15IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH15IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH77", AchievementsUpdate.ACH15IsUnlocked);
                Magic10.SetActive(true);
            }
        }

        if (PileOfCoinsMechanics.incrementPileOfCoinsAmount >= 10)
        {
            if (ACH16IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH16IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH78", AchievementsUpdate.ACH16IsUnlocked);
                pile10.SetActive(true);
            }
        }

        if (PileOfCoinsMechanics.incrementPileOfCoinsAmount >= 100)
        {
            if (ACH17IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH17IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH79", AchievementsUpdate.ACH17IsUnlocked);
                pile100.SetActive(true);
            }
        }

        if (hiddenCoins.foundBronce == 1)
        {
            if (ACH18IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH18IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH80", AchievementsUpdate.ACH18IsUnlocked);
                hiddenBronze.SetActive(true);
            }
        }

        if (hiddenCoins.foundSilver == 1)
        {
            if (ACH19IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH19IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH81", AchievementsUpdate.ACH19IsUnlocked);
                hiddenSilver.SetActive(true);
            }
        }

        //1.2

        if (Challenges.completedChallenge1 == 1)
        {
            if (ACH21IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH21IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH83", AchievementsUpdate.ACH21IsUnlocked);
                challenge1.SetActive(true);
            }
        }

        if (Challenges.completedChallenge2 == 1)
        {
            if (ACH22IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH22IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH84", AchievementsUpdate.ACH22IsUnlocked);
                challenge2.SetActive(true);
            }
        }

        if (Challenges.completedChallenge3 == 1)
        {
            if (ACH23IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH23IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH85", AchievementsUpdate.ACH23IsUnlocked);
                challenge3.SetActive(true);
            }
        }

        if (Challenges.completedChallenge4 == 1)
        {
            if (ACH24IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH24IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH86", AchievementsUpdate.ACH24IsUnlocked);

                challenge4.SetActive(true);
            }
        }

        if (MainButtonClick.activeFlipsAmount >= 100)
        {
            if (ACH25IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH25IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH87", AchievementsUpdate.ACH25IsUnlocked);

                activeFlips100.SetActive(true);
            }
        }

        if (MainButtonClick.activeFlipsAmount >= 1000)
        {
            if (ACH26IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH26IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH88", AchievementsUpdate.ACH26IsUnlocked);

                activeFlips1000.SetActive(true);
            }
        }

        if (MainButtonClick.activeFlipsAmount >= 5000)
        {
            if (ACH27IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH27IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH89", AchievementsUpdate.ACH27IsUnlocked);
                activeFlips5000.SetActive(true);
            }
        }

        if (TreasureChest.treasureCount >= 1)
        {
            if (ACH28IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH28IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH90", AchievementsUpdate.ACH28IsUnlocked);
                chest1.SetActive(true);
            }
        }

        if (TreasureChest.treasureCount >= 10)
        {
            if (ACH29IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH29IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH91", AchievementsUpdate.ACH29IsUnlocked);
                chest10.SetActive(true);
            }
        }

        if (RitualUpgrade.treasureCount >= 1)
        {
            if (ACH30IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH30IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH92", AchievementsUpdate.ACH30IsUnlocked);
                ritual1.SetActive(true);
            }
        }

        if (RitualUpgrade.treasureCount >= 10)
        {
            if (ACH31IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH31IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH93", AchievementsUpdate.ACH31IsUnlocked);
                ritual10.SetActive(true);
            }
        }

        if (AscendScreen.boughtAuto == 1)
        {
            if (ACH32IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH32IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH94", AchievementsUpdate.ACH32IsUnlocked);
                autoUpgrade.SetActive(true);
            }
        }

        if (GlobalCoins.CoinCount >= 1000000000000000000000000000f)
        {
            if (ACH33IsUnlocked == 0)
            {
                if (LoadSaves.isMobileBuild == false) { button.GetComponent<Button>().onClick.Invoke(); }
                ACH33IsUnlocked = 1;
                PlayerPrefs.SetInt("ACH95", AchievementsUpdate.ACH33IsUnlocked);
                octillion1.SetActive(true);
            }
        }
    }
}
