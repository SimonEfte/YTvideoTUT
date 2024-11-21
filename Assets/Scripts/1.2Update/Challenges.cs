using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Challenges : MonoBehaviour
{
    public static int isChallenge1Active = 0;
    public static int isChallenge2Active = 0;
    public static int isChallenge3Active = 0;
    public static int isChallenge4Active = 0;

    public static int completedChallenge1 = 0;
    public static int completedChallenge2 = 0;
    public static int completedChallenge3 = 0;
    public static int completedChallenge4 = 0;

    public static float wait5Seconds;
    
    public GameObject lockAutoFlips;
    public GameObject lockUpgradedCoinFlips;
    public GameObject lockHigherChance;
    public GameObject lockFlipMoreCoins;
    public GameObject lockLucky;

    public GameObject challengeButton1Set;
    public GameObject challengeButton1unSet;
    public GameObject challengeButton2Set;
    public GameObject challengeButton2unSet;
    public GameObject challengeButton3Set;
    public GameObject challengeButton3unSet;
    public GameObject challengeButton4Set;
    public GameObject challengeButton4unSet;

    public GameObject completedChal1PopUp;
    public GameObject completedChal2PopUp;
    public GameObject completedChal3PopUp;
    public GameObject completedChal4PopUp;

    public GameObject completedIcon1;
    public GameObject completedIcon2;
    public GameObject completedIcon3;
    public GameObject completedIcon4;

    public GameObject notCompledIcon1;
    public GameObject notCompledIcon2;
    public GameObject notCompledIcon3;
    public GameObject notCompledIcon4;

    public GameObject quitChallengeButton1;
    public GameObject quitChallengeButton2;
    public GameObject quitChallengeButton3;
    public GameObject quitChallengeButton4;

    public bool isChal1Compled;
    public bool isChal2Compled;
    public bool isChal3Compled;
    public bool isChal4Compled;

    public GameObject currentActiveChallenge1;
    public GameObject currentActiveChallenge2;
    public GameObject currentActiveChallenge3;
    public GameObject currentActiveChallenge4;

    public TextMeshProUGUI chal1Stats;
    public TextMeshProUGUI chal2Stats;
    public TextMeshProUGUI chal3Stats;
    public TextMeshProUGUI chal4Stats;

    public GameObject lockedDuplicate;

    public void ResetChall()
    {
        selectedChall = 0;

        choseBtn.SetActive(false);
        closeBtn.SetActive(false);
        blackFrame.SetActive(false);
        challTooltip1.SetActive(false);
        challTooltip2.SetActive(false);
        challTooltip3.SetActive(false);
        challTooltip4.SetActive(false);

        if(completedChallenge1 == 0) { lockedSwitchButton.SetActive(true); }
        if(AscendScreen.boughtAuto == 0) { blockAuto.SetActive(true); }

        blockHigher.SetActive(false);
        blockLucky.SetActive(false);
        blockUpgradedAuto.SetActive(false);
        lockedDuplicate.SetActive(false);

        currentActiveChallenge1.SetActive(false);
        currentActiveChallenge2.SetActive(false);
        currentActiveChallenge3.SetActive(false);
        currentActiveChallenge4.SetActive(false);

        challengeButton1unSet.SetActive(false);
        challengeButton2unSet.SetActive(false);
        challengeButton3unSet.SetActive(false);
        challengeButton4unSet.SetActive(false);

        challengeButton1Set.SetActive(true);
        challengeButton2Set.SetActive(true);
        challengeButton3Set.SetActive(true);
        challengeButton4Set.SetActive(true);

        isChallenge1Active = 0;
        isChallenge2Active = 0;
        isChallenge3Active = 0;
        isChallenge4Active = 0;

        PlayerPrefs.SetInt("SavedChallenge1", Challenges.isChallenge1Active);
        PlayerPrefs.SetInt("SavedChallenge2", Challenges.isChallenge2Active);
        PlayerPrefs.SetInt("SavedChallenge3", Challenges.isChallenge3Active);
        PlayerPrefs.SetInt("SavedChallenge4", Challenges.isChallenge4Active);

        quitChallengeButton1.SetActive(false);
        quitChallengeButton2.SetActive(false);
        quitChallengeButton3.SetActive(false);
        quitChallengeButton4.SetActive(false);
    }

    public void Start()
    {
        isChallenge1Active = PlayerPrefs.GetInt("SavedChallenge1");
        isChallenge2Active = PlayerPrefs.GetInt("SavedChallenge2");
        isChallenge3Active = PlayerPrefs.GetInt("SavedChallenge3");
        isChallenge4Active = PlayerPrefs.GetInt("SavedChallenge4");
        completedChallenge1 = PlayerPrefs.GetInt("CompledetChal1");
        completedChallenge2 = PlayerPrefs.GetInt("CompledetChal2");
        completedChallenge3 = PlayerPrefs.GetInt("CompledetChal3");
        completedChallenge4 = PlayerPrefs.GetInt("CompledetChal4");

        if (completedChallenge1 == 0) { lockedSwitchButton.SetActive(true); chal1Stats.text = LocalizationStrings.completeChal1; }
        if (completedChallenge1 == 1) { lockedSwitchButton.SetActive(false); chal1Stats.text = LocalizationStrings.chal1Completed; }
        if (completedChallenge2 == 0) { chal2Stats.text = LocalizationStrings.completeChal2; }
        if (completedChallenge2 == 1) { chal2Stats.text = LocalizationStrings.chal2completed; }
        if (completedChallenge3 == 0) { chal3Stats.text = LocalizationStrings.completeChal3; }
        if (completedChallenge3 == 1) { chal3Stats.text = LocalizationStrings.chal3completed; ; }
        if (completedChallenge4 == 0) { chal4Stats.text = LocalizationStrings.completeChal4; }
        if (completedChallenge4 == 1) { chal4Stats.text = LocalizationStrings.chal4completed; ; }


        if (isChallenge1Active == 1)
        {
            quitChallengeButton1.SetActive(true);
            currentActiveChallenge1.SetActive(true);
            lockAutoFlips.SetActive(true);
            lockUpgradedCoinFlips.SetActive(true);
        }
        if (isChallenge1Active == 0)
        {
            quitChallengeButton1.SetActive(false);
            currentActiveChallenge1.SetActive(false);
            lockAutoFlips.SetActive(false);
            lockUpgradedCoinFlips.SetActive(false);
        }

        if(isChallenge2Active == 1)
        {
            quitChallengeButton2.SetActive(true);
            currentActiveChallenge2.SetActive(true);
            lockHigherChance.SetActive(true);
            lockLucky.SetActive(true);

            if (EnterText.choseHeads == 1)
            {
                higherChanceHoverover.tailsPercent = 73.75f;
                higherChanceHoverover.headsPercent = 25.75f;

            }
            if (EnterText.choseTails == 1)
            {
                higherChanceHoverover.headsPercent = 73.75f;
                higherChanceHoverover.tailsPercent = 25.75f;
            }

            MainButtonClick.lowerCoinChance = 149;
            MainButtonClick.higherCoinChance = 148;
            MainButtonClick.lowSpecialChance = 1;
        }
        if (isChallenge2Active == 0)
        {
            quitChallengeButton2.SetActive(false);
            currentActiveChallenge3.SetActive(true);
            lockHigherChance.SetActive(false);
            lockLucky.SetActive(false);
        }

        if(isChallenge3Active == 1)
        {
            quitChallengeButton3.SetActive(true);
            chall3Bonus = 5;
            currentActiveChallenge3.SetActive(true);
            lockFlipMoreCoins.SetActive(true);
        }
        if (isChallenge3Active == 0)
        {
            quitChallengeButton3.SetActive(false);
            chall3Bonus = 0;
            currentActiveChallenge3.SetActive(false);
            lockFlipMoreCoins.SetActive(false);
        }

        if(isChallenge4Active == 1)
        {
            quitChallengeButton4.SetActive(true);
            currentActiveChallenge4.SetActive(true);
            MainButtonClick.lowSpecialChance = 202;
            MainButtonClick.higherCoinChance = 203;
            MainButtonClick.lowerCoinChance = 204;
            lockHigherChance.SetActive(true);
            lockLucky.SetActive(true);
            lockHigherChance.SetActive(true);
            lockLucky.SetActive(true);
        }
        if (isChallenge4Active == 0)
        {
            quitChallengeButton4.SetActive(false);
            lockHigherChance.SetActive(false);
            lockLucky.SetActive(false);
            currentActiveChallenge4.SetActive(false);
            wait5Seconds = 0f;
        }

        SetCompleteIcon();
    }

    public GameObject blockAuto;
    public GameObject blockHigher;
    public GameObject blockLucky;
    public GameObject blockUpgradedAuto;

    public void Update()
    {
        if (isChallenge1Active == 1 && MainButtonClick.numberOfDuplicationUpgrades == 14 && isChal1Compled == false)
        {
            isChal1Compled = true;
            completedChal1PopUp.SetActive(true);
        }

        if (isChallenge2Active == 1 && GoldenFlipsButton.goldenCoinsUpgradeCount == 7 && isChal2Compled == false)
        {
            isChal2Compled = true;
         
            completedChal2PopUp.SetActive(true);
            SetCompleteIcon();
        }

        if (isChallenge3Active == 1 && GlobalCoins.CoinCount >= 70000000000000000 && isChal3Compled == false)
        {
            isChal3Compled = true;
            
            completedChal3PopUp.SetActive(true);
            SetCompleteIcon();
        }

        if (isChallenge4Active == 1 && GoldenFlipsButton.goldenCoinsUpgradeCount == 21 && isChal4Compled == false)
        {
            isChal4Compled = true;
          
            completedChal4PopUp.SetActive(true);
            SetCompleteIcon();
        }

        if(isChallenge4Active == 1) 
        {
            wait5Seconds = 0;
            lockHigherChance.SetActive(true);
            lockLucky.SetActive(true);
        }
        if (isChallenge4Active == 0)
        {
            wait5Seconds = 0;
        }

        if(isChallenge2Active == 1)
        {
            lockHigherChance.SetActive(true);
            lockLucky.SetActive(true);
        }
    }

    public void SetCompleteIcon()
    {
        if (completedChallenge1 == 1) { completedIcon1.SetActive(true); notCompledIcon1.SetActive(false); }
        if (completedChallenge2 == 1) { completedIcon2.SetActive(true); notCompledIcon2.SetActive(false); }
        if (completedChallenge3 == 1) { completedIcon3.SetActive(true); notCompledIcon3.SetActive(false); }
        if (completedChallenge4 == 1) { completedIcon4.SetActive(true); notCompledIcon4.SetActive(false); }

        if (completedChallenge1 == 0) { completedIcon1.SetActive(false); notCompledIcon1.SetActive(true); }
        if (completedChallenge2 == 0) { completedIcon2.SetActive(false); notCompledIcon2.SetActive(true); }
        if (completedChallenge3 == 0) { completedIcon3.SetActive(false); notCompledIcon3.SetActive(true); }
        if (completedChallenge4 == 0) { completedIcon4.SetActive(false); notCompledIcon4.SetActive(true); }
    }

    //Challenge1-------------------------------------------------------
    public GameObject infoBar, infoCloseBar, blackFRameChall;

    //-25, 13.
    //0.04, 0.04r

    public void OpenChallInfo()
    {
        if(LoadSaves.isMobileBuild == true)
        {
            infoBar.SetActive(true); infoCloseBar.SetActive(true);
            infoBar.transform.localPosition = new Vector2(-3.1f, 1.9f);
            infoBar.transform.localScale = new Vector2(0.088f, 0.088f);
            blackFRameChall.SetActive(true);
        }
    }
    public void ChoseChallInfo()
    {
        blackFRameChall.SetActive(false);
        infoBar.SetActive(false); infoCloseBar.SetActive(false);
    }

    public GameObject challTooltip1, challTooltip2, challTooltip3, challTooltip4;
    public int openedChallNumber;

    public GameObject blackFrame, closeBtn, choseBtn;
    public bool choseChall;

    public void OpenChall(int challNumber)
    {
        if(LoadSaves.isMobileBuild == true)
        {
            choseChall = false;
            blackFrame.SetActive(true);
            closeBtn.transform.localPosition = new Vector2(147.5f, -424f);
            closeBtn.SetActive(true);
            choseBtn.SetActive(true);

            openedChallNumber = challNumber;
            if (challNumber == 1) 
            {
                challTooltip1.SetActive(true);
                challTooltip1.transform.localPosition = new Vector2(0,51);
                challTooltip1.transform.localScale = new Vector2(2.43f, 2.43f);
            }
            if (challNumber == 2) 
            {
                challTooltip2.SetActive(true);
                challTooltip2.transform.localPosition = new Vector2(0, 51);
                challTooltip2.transform.localScale = new Vector2(2.43f, 2.43f);
            }
            if (challNumber == 3)
            {
                challTooltip3.SetActive(true);
                challTooltip3.transform.localPosition = new Vector2(0, 51);
                challTooltip3.transform.localScale = new Vector2(2.43f, 2.43f);
            }
            if (challNumber == 4) 
            { 
                challTooltip4.SetActive(true);
                challTooltip4.transform.localPosition = new Vector2(0, 51);
                challTooltip4.transform.localScale = new Vector2(2.43f, 2.43f);
            }

            if(openedChallNumber == selectedChall)
            {
                choseOrNotChoseText.text = "UNSELECT";
                choseOrNotChoseText.fontSize = 38.5f;
            }
            else
            {
                choseOrNotChoseText.text = "SELECT";
                choseOrNotChoseText.fontSize = 52f;
            }
        }
    }

    public void CloseChallChoose()
    {
        blackFrame.SetActive(false);
        closeBtn.SetActive(false);
        choseBtn.SetActive(false);

        challTooltip1.SetActive(false);
        challTooltip2.SetActive(false);
        challTooltip3.SetActive(false);
        challTooltip4.SetActive(false);
    }

    public TextMeshProUGUI choseOrNotChoseText;
    public int selectedChall;

    public void OpenChallIngame(int chall)
    {
        if(LoadSaves.isMobileBuild == true)
        {
            blackFrame.SetActive(true);
            closeBtn.SetActive(true);
            closeBtn.transform.localPosition = new Vector2(0, -424f);

            if (chall == 1)
            {
                challTooltip1.SetActive(true);
                challTooltip1.transform.localPosition = new Vector2(0, 51);
                challTooltip1.transform.localScale = new Vector2(2.43f, 2.43f);
            }
            if (chall == 2)
            {
                challTooltip2.SetActive(true);
                challTooltip2.transform.localPosition = new Vector2(0, 51);
                challTooltip2.transform.localScale = new Vector2(2.43f, 2.43f);
            }
            if (chall == 3)
            {
                challTooltip3.SetActive(true);
                challTooltip3.transform.localPosition = new Vector2(0, 51);
                challTooltip3.transform.localScale = new Vector2(2.43f, 2.43f);
            }
            if (chall == 4)
            {
                challTooltip4.SetActive(true);
                challTooltip4.transform.localPosition = new Vector2(0, 51);
                challTooltip4.transform.localScale = new Vector2(2.43f, 2.43f);
            }
        }
    }

    public void SetChall()
    {
        bool active = false;
        if(selectedChall == openedChallNumber)
        {
            choseChall = true;
            if (selectedChall == 1) { UnCheckChallenge1(); }
            if (selectedChall == 2) { UnSetChallenge2(); }
            if (selectedChall == 3) { UnSetChallenge3(); }
            if (selectedChall == 4) { UnSetChallenge4(); }
            active = true;
        }

        selectedChall = openedChallNumber;

        if(active == false)
        {
            choseOrNotChoseText.text = "UNSELECT";
            choseOrNotChoseText.fontSize = 38.5f;
            choseChall = true;

            if (selectedChall == 1) { SetChallenge1(); UnSetChallenge2(); UnSetChallenge3(); UnSetChallenge4(); }
            if (selectedChall == 2) { UnCheckChallenge1(); SetChallenge2(); UnSetChallenge3(); UnSetChallenge4(); }
            if (selectedChall == 3) { UnCheckChallenge1(); UnSetChallenge2(); SetChallenge3(); UnSetChallenge4(); }
            if (selectedChall == 4) { UnCheckChallenge1(); UnSetChallenge2(); UnSetChallenge3(); SetChallenge4(); }
        }
        else
        {
            selectedChall = 0;
            choseOrNotChoseText.text = "SELECT";
            choseOrNotChoseText.fontSize = 52f;
            choseChall = false;
        }
    }

    public void SetChallenge1()
    {
        if(LoadSaves.isMobileBuild == true && choseChall == false)
        {
            return;
        }

        quitChallengeButton1.SetActive(true);
        challengeButton4Set.SetActive(true);
        challengeButton3Set.SetActive(true);
        challengeButton2Set.SetActive(true);
        currentActiveChallenge1.SetActive(true);
        challengeButton1Set.SetActive(false);
        challengeButton1unSet.SetActive(true);

        isChallenge1Active = 1;
         lockAutoFlips.SetActive(true);
        lockUpgradedCoinFlips.SetActive(true);
        PlayerPrefs.SetInt("SavedChallenge1", isChallenge1Active);
    }

    public void UnCheckChallenge1()
    {
        if (LoadSaves.isMobileBuild == true && choseChall == false)
        {
            return;
        }
        quitChallengeButton1.SetActive(false);
        currentActiveChallenge1.SetActive(false);
        challengeButton1Set.SetActive(true);
        challengeButton1unSet.SetActive(false);

        isChallenge1Active = 0;
        lockAutoFlips.SetActive(false);
        lockUpgradedCoinFlips.SetActive(false);
        PlayerPrefs.SetInt("SavedChallenge1", isChallenge1Active);
    }

    //Challenge2-------------------------------------------------------

    public void SetChallenge2()
    {
        if (LoadSaves.isMobileBuild == true && choseChall == false)
        {
            return;
        }
        quitChallengeButton2.SetActive(true);
        challengeButton4Set.SetActive(true);
        challengeButton3Set.SetActive(true);
        challengeButton1Set.SetActive(true);
        currentActiveChallenge2.SetActive(true);
        challengeButton2Set.SetActive(false);
        challengeButton2unSet.SetActive(true);
        lockHigherChance.SetActive(true);
        lockLucky.SetActive(true);

        lockLucky.SetActive(true);

        isChallenge2Active = 1;
        lockHigherChance.SetActive(true);
        PlayerPrefs.SetInt("SavedChallenge2", isChallenge2Active);
    }
    public void UnSetChallenge2()
    {
        if (LoadSaves.isMobileBuild == true && choseChall == false)
        {
            return;
        }

        quitChallengeButton2.SetActive(false);
        lockHigherChance.SetActive(false);
        lockLucky.SetActive(false);
        currentActiveChallenge2.SetActive(false);
        lockLucky.SetActive(false);
        challengeButton2Set.SetActive(true);
        challengeButton2unSet.SetActive(false);
        isChallenge2Active = 0;
        lockHigherChance.SetActive(false);
        PlayerPrefs.SetInt("SavedChallenge2", isChallenge2Active);

    }

    //Challenge3-------------------------------------------------------

    public static float chall3Bonus;

    public void SetChallenge3()
    {
        if (LoadSaves.isMobileBuild == true && choseChall == false)
        {
            return;
        }

        quitChallengeButton3.SetActive(true);
        challengeButton4Set.SetActive(true);
        challengeButton2Set.SetActive(true);
        challengeButton1Set.SetActive(true);
        currentActiveChallenge3.SetActive(true);
        challengeButton3Set.SetActive(false);
        challengeButton3unSet.SetActive(true);
        isChallenge3Active = 1;
        chall3Bonus = 5;
        PlayerPrefs.SetInt("SavedChallenge3", isChallenge3Active);
        lockFlipMoreCoins.SetActive(true);
    }

    public void UnSetChallenge3()
    {
        if (LoadSaves.isMobileBuild == true && choseChall == false)
        {
            return;
        }

        quitChallengeButton3.SetActive(false);
        currentActiveChallenge3.SetActive(false);
        challengeButton3Set.SetActive(true);
        challengeButton3unSet.SetActive(false);
        isChallenge3Active = 0;
        chall3Bonus = 0;
        PlayerPrefs.SetInt("SavedChallenge3", isChallenge3Active);
        lockFlipMoreCoins.SetActive(false);
    }

    //Challenge3-------------------------------------------------------

    public void SetChallenge4()
    {
        if (LoadSaves.isMobileBuild == true && choseChall == false)
        {
            return;
        }

        quitChallengeButton4.SetActive(true);
        
        challengeButton3Set.SetActive(true);
        challengeButton1Set.SetActive(true);
        challengeButton2Set.SetActive(true);
        currentActiveChallenge4.SetActive(true);
        challengeButton4Set.SetActive(false);
        challengeButton4unSet.SetActive(true);
        isChallenge4Active = 1;
        wait5Seconds = 0;
        PlayerPrefs.SetInt("SavedChallenge4", isChallenge4Active);
    }

    public void UnSetChallenge4()
    {
        if (LoadSaves.isMobileBuild == true && choseChall == false)
        {
            return;
        }

        quitChallengeButton4.SetActive(false);
        lockHigherChance.SetActive(false);
        lockLucky.SetActive(false);
        currentActiveChallenge4.SetActive(false);
        challengeButton4Set.SetActive(true);
        challengeButton4unSet.SetActive(false);
        isChallenge4Active = 0;
        wait5Seconds = 0;
        PlayerPrefs.SetInt("SavedChallenge4", isChallenge4Active);
    }

    public GameObject lockedSwitchButton;
    public GameObject buttonDropBar;

    public TextMeshProUGUI headsChance;
    public TextMeshProUGUI tailsChance;
    public TextMeshProUGUI luckyChance;

    public void ClickOkOnChallengePopUp1()
    {
        blockAuto.SetActive(false);
        blockHigher.SetActive(false);
        blockLucky.SetActive(false);
        blockUpgradedAuto.SetActive(false);
        buttonDropBar.GetComponent<Button>().onClick.Invoke();
        quitChallengeButton1.SetActive(false);
        chal1Stats.text = LocalizationStrings.chal1Completed;
        currentActiveChallenge1.SetActive(false);
        lockedSwitchButton.SetActive(false);
        completedChal1PopUp.SetActive(false);
        challengeButton1Set.SetActive(true);
        challengeButton1unSet.SetActive(false);
        isChallenge1Active = 0;
        isChal1Compled = false;
        lockAutoFlips.SetActive(false);
        lockUpgradedCoinFlips.SetActive(false);
        completedChallenge1 = 1;
        PlayerPrefs.SetInt("CompledetChal1", completedChallenge1);
        PlayerPrefs.SetInt("SavedChallenge1", isChallenge1Active);
        SetCompleteIcon();
    }

    public void ClickOkOnChallengePopUp2()
    {
        blockAuto.SetActive(false);
        blockHigher.SetActive(false);
        blockLucky.SetActive(false);
        blockUpgradedAuto.SetActive(false);
        buttonDropBar.GetComponent<Button>().onClick.Invoke();
        quitChallengeButton2.SetActive(false);
        chal2Stats.text = LocalizationStrings.chal2completed;
        currentActiveChallenge2.SetActive(false);
        completedChal2PopUp.SetActive(false);
        higherChanceHoverover.tailsPercent = 49.75f;
        higherChanceHoverover.headsPercent = 49.75f;
        MainButtonClick.lowSpecialChance = 1;
        MainButtonClick.higherCoinChance = 100;
        MainButtonClick.lowerCoinChance = 101;
        lockLucky.SetActive(false);
        challengeButton2Set.SetActive(true);
        challengeButton2unSet.SetActive(false);
        isChallenge2Active = 0;
        isChal2Compled = false;
        lockHigherChance.SetActive(false);
        PlayerPrefs.SetInt("SavedChallenge2", isChallenge2Active);
        headsChance.GetComponent<TextMeshProUGUI>().text = higherChanceHoverover.headsPercent + LocalizationStrings.higherChanceHeads;
        tailsChance.GetComponent<TextMeshProUGUI>().text = higherChanceHoverover.tailsPercent + LocalizationStrings.higherChanceTails;
        luckyChance.GetComponent<TextMeshProUGUI>().text = GetLuckyHoverOver.luckyChance + LocalizationStrings.luckyCoinChance;
        completedChallenge2 = 1;
        PlayerPrefs.SetInt("CompledetChal2", completedChallenge2);
        SetCompleteIcon();
    }

    public void ClickOkOnChallengePopUp3()
    {
        blockAuto.SetActive(false);
        blockHigher.SetActive(false);
        blockLucky.SetActive(false);
        blockUpgradedAuto.SetActive(false);
        buttonDropBar.GetComponent<Button>().onClick.Invoke();
        quitChallengeButton3.SetActive(false);
        chal3Stats.text = LocalizationStrings.chal3completed;
        currentActiveChallenge3.SetActive(false);
        completedChal3PopUp.SetActive(false);
        challengeButton3Set.SetActive(true);
        challengeButton3unSet.SetActive(false);
        isChallenge3Active = 0;
        chall3Bonus = 0;
        isChal3Compled = false;
        PlayerPrefs.SetInt("SavedChallenge3", isChallenge3Active);
        lockFlipMoreCoins.SetActive(false);
        completedChallenge3 = 1;
        PlayerPrefs.SetInt("CompledetChal3", completedChallenge3);
        SetCompleteIcon();
    }

    public void ClickOkOnChallengePopUp4()
    {
        blockAuto.SetActive(false);
        blockHigher.SetActive(false);
        blockLucky.SetActive(false);
        blockUpgradedAuto.SetActive(false);
        buttonDropBar.GetComponent<Button>().onClick.Invoke();
        quitChallengeButton4.SetActive(false);
        chal4Stats.text = LocalizationStrings.chal4completed;
        lockHigherChance.SetActive(false);
        lockLucky.SetActive(false);
        currentActiveChallenge4.SetActive(false);
        completedChal4PopUp.SetActive(false);
        Challenges.wait5Seconds = 0;
        higherChanceHoverover.tailsPercent = 49.75f;
        higherChanceHoverover.headsPercent = 49.75f;
        MainButtonClick.lowSpecialChance = 1;
        MainButtonClick.higherCoinChance = 100;
        MainButtonClick.lowerCoinChance = 101;
        challengeButton4Set.SetActive(true);
        challengeButton4unSet.SetActive(false);
        isChallenge4Active = 0;
        isChal4Compled = false;
        wait5Seconds = 0;
        PlayerPrefs.SetInt("SavedChallenge4", isChallenge4Active);
        headsChance.GetComponent<TextMeshProUGUI>().text = higherChanceHoverover.headsPercent + LocalizationStrings.higherChanceHeads;
        tailsChance.GetComponent<TextMeshProUGUI>().text = higherChanceHoverover.tailsPercent + LocalizationStrings.higherChanceTails;
        luckyChance.GetComponent<TextMeshProUGUI>().text = GetLuckyHoverOver.luckyChance + LocalizationStrings.luckyCoinChance;
        completedChallenge4 = 1;
        PlayerPrefs.SetInt("CompledetChal4", completedChallenge4);
        SetCompleteIcon();
    }
}

