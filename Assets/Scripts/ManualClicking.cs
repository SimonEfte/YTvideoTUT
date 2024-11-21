using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ManualClicking : MonoBehaviour
{
    public TextMeshProUGUI mathText;
    public float math;
    public GameObject clickableButton;
    public GameObject notClickableButton;
    public static int isSwitchOff = 0;

    public static float flipAllBonus;

    public GameObject blockScreen;
    public int waitForButton;
    public TextMeshProUGUI waitText;
    public GameObject onText;
    public GameObject offText;
    public GameObject offButtonBlock;

    public void SetTurnOffBack()
    {
        blockScreen.SetActive(false);
        offButtonBlock.SetActive(false);
        flipAllBonus = 0;
    }

    public void TurnOffAutoFlippers()
    {
        blockScreen.SetActive(true);
        offButtonBlock.SetActive(true);
        flipAllBonus = AscendScreen.activeFlipperMiltiplier;
        hideSwitchButton.SetActive(true);
        blockAutoFlips.SetActive(true);
        blockUpgradedFlips.SetActive(true);
        StartCoroutine(WaitAFewSecsTurnOff());
        onText.SetActive(false);
        offText.SetActive(true);
        isSwitchOff = 1;
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

    IEnumerator WaitAFewSecsTurnOff()
    {
        waitText.text = "3";
        yield return new WaitForSeconds(1);
        waitText.text = "2";
        yield return new WaitForSeconds(1);
        waitText.text = "1";
        yield return new WaitForSeconds(1);
        waitText.text = "";
        clickableButton.SetActive(true);
        notClickableButton.SetActive(false);
        hideSwitchButton.SetActive(false);
    }

    IEnumerator WaitAFewSecsTurnOn()
    {
        waitText.text = "3";
        yield return new WaitForSeconds(1);
        waitText.text = "2";
        yield return new WaitForSeconds(1);
        waitText.text = "1";
        yield return new WaitForSeconds(1);
        waitText.text = "";
        clickableButton.SetActive(false);
        notClickableButton.SetActive(true);
        hideSwitchButton.SetActive(false);
    }

    IEnumerator WaitAFewSecs()
    {
        waitText.text = "3";
        yield return new WaitForSeconds(1);
        waitText.text = "2";
        yield return new WaitForSeconds(1);
        waitText.text = "1";
        yield return new WaitForSeconds(1);
        waitText.text = "";
        hideSwitchButton.SetActive(false);
        clickableButton.SetActive(true);
        notClickableButton.SetActive(false);
    }

    public GameObject blockAutoFlips;
    public GameObject blockUpgradedFlips;
    public GameObject hideSwitchButton;

    public void FlipAllCoins()
    {
        clickableButton.SetActive(false);
        notClickableButton.SetActive(true);
        flippers();
        StartCoroutine(WaitAFewSecs());
        hideSwitchButton.SetActive(true);

        if (MainButtonClick.numberOfDuplicationUpgrades == 0 && GoldenFlipsButton.goldenCoinsUpgradeCount == 0)
        {
            AutoCoin.ascendedAuto1 = 1;
            MainButtonClick.activeFlipsAmount += 1;
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 1 && GoldenFlipsButton.goldenCoinsUpgradeCount == 0)
        {
            AutoCoin.ascendedAuto1 = 1;
            AutoCoin2.ascendedAuto2 = 1;
            MainButtonClick.activeFlipsAmount += 2;
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 2 && GoldenFlipsButton.goldenCoinsUpgradeCount == 0)
        {
            AutoCoin.ascendedAuto1 = 1;
            AutoCoin2.ascendedAuto2 = 1;
            AutoCoin3.ascendedAuto3 = 1;
            MainButtonClick.activeFlipsAmount += 3;
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 3 && GoldenFlipsButton.goldenCoinsUpgradeCount == 0)
        {
            AutoCoin.ascendedAuto1 = 1;
            AutoCoin2.ascendedAuto2 = 1;
            AutoCoin4.ascendedAuto4 = 1;
            AutoCoin3.ascendedAuto3 = 1;
            MainButtonClick.activeFlipsAmount += 4;
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 4 && GoldenFlipsButton.goldenCoinsUpgradeCount == 0)
        {
            AutoCoin.ascendedAuto1 = 1;
            AutoCoin2.ascendedAuto2 = 1;
            AutoCoin5.ascendedAuto5 = 1;
            AutoCoin3.ascendedAuto3 = 1;
            AutoCoin4.ascendedAuto4 = 1;
            MainButtonClick.activeFlipsAmount += 5;
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 5 && GoldenFlipsButton.goldenCoinsUpgradeCount == 0)
        {
            AutoCoin.ascendedAuto1 = 1;
            AutoCoin2.ascendedAuto2 = 1;
            AutoCoin6.ascendedAuto6 = 1;
            AutoCoin3.ascendedAuto3 = 1;
            AutoCoin4.ascendedAuto4 = 1;
            AutoCoin5.ascendedAuto5 = 1;
            MainButtonClick.activeFlipsAmount += 6;
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 6 && GoldenFlipsButton.goldenCoinsUpgradeCount == 0)
        {
            AutoCoin.ascendedAuto1 = 1;
            AutoCoin2.ascendedAuto2 = 1;
            AutoCoin3.ascendedAuto3 = 1;
            AutoCoin4.ascendedAuto4 = 1;
            AutoCoin5.ascendedAuto5 = 1;
            AutoCoin6.ascendedAuto6 = 1;
            AutoCoin7.ascendedAuto7 = 1;
            MainButtonClick.activeFlipsAmount += 7;
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 7 && GoldenFlipsButton.goldenCoinsUpgradeCount == 0)
        {
            AutoCoin.ascendedAuto1 = 1;
            AutoCoin2.ascendedAuto2 = 1;
            AutoCoin3.ascendedAuto3 = 1;
            AutoCoin4.ascendedAuto4 = 1;
            AutoCoin5.ascendedAuto5 = 1;
            AutoCoin6.ascendedAuto6 = 1;
            AutoCoin7.ascendedAuto7 = 1;
            AutoCoin8.ascendedAuto8 = 1;
            MainButtonClick.activeFlipsAmount += 8;
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 8 && GoldenFlipsButton.goldenCoinsUpgradeCount == 0)
        {
            AutoCoin.ascendedAuto1 = 1;
            AutoCoin2.ascendedAuto2 = 1;
            AutoCoin3.ascendedAuto3 = 1;
            AutoCoin4.ascendedAuto4 = 1;
            AutoCoin5.ascendedAuto5 = 1;
            AutoCoin6.ascendedAuto6 = 1;
            AutoCoin7.ascendedAuto7 = 1;
            AutoCoin8.ascendedAuto8 = 1;
            AutoCoin9.ascendedAuto9 = 1;
            MainButtonClick.activeFlipsAmount += 9;
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 9 && GoldenFlipsButton.goldenCoinsUpgradeCount == 0)
        {
            AutoCoin.ascendedAuto1 = 1;
            AutoCoin2.ascendedAuto2 = 1;
            AutoCoin3.ascendedAuto3 = 1;
            AutoCoin4.ascendedAuto4 = 1;
            AutoCoin5.ascendedAuto5 = 1;
            AutoCoin6.ascendedAuto6 = 1;
            AutoCoin7.ascendedAuto7 = 1;
            AutoCoin8.ascendedAuto8 = 1;
            AutoCoin9.ascendedAuto9 = 1;
            AutoCoin10.ascendedAuto10 = 1;
            MainButtonClick.activeFlipsAmount += 10;
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 10 && GoldenFlipsButton.goldenCoinsUpgradeCount == 0)
        {
            AutoCoin.ascendedAuto1 = 1;
            AutoCoin2.ascendedAuto2 = 1;
            AutoCoin3.ascendedAuto3 = 1;
            AutoCoin4.ascendedAuto4 = 1;
            AutoCoin5.ascendedAuto5 = 1;
            AutoCoin6.ascendedAuto6 = 1;
            AutoCoin7.ascendedAuto7 = 1;
            AutoCoin8.ascendedAuto8 = 1;
            AutoCoin9.ascendedAuto9 = 1;
            AutoCoin10.ascendedAuto10 = 1;
            AutoCoin11.ascendedAuto11 = 1;
            MainButtonClick.activeFlipsAmount += 11;
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 11 && GoldenFlipsButton.goldenCoinsUpgradeCount == 0)
        {
            AutoCoin.ascendedAuto1 = 1;
            AutoCoin2.ascendedAuto2 = 1;
            AutoCoin3.ascendedAuto3 = 1;
            AutoCoin4.ascendedAuto4 = 1;
            AutoCoin5.ascendedAuto5 = 1;
            AutoCoin6.ascendedAuto6 = 1;
            AutoCoin7.ascendedAuto7 = 1;
            AutoCoin8.ascendedAuto8 = 1;
            AutoCoin9.ascendedAuto9 = 1;
            AutoCoin10.ascendedAuto10 = 1;
            AutoCoin11.ascendedAuto11 = 1;
            AutoCoin12.ascendedAuto12 = 1;
            MainButtonClick.activeFlipsAmount += 12;
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 12 && GoldenFlipsButton.goldenCoinsUpgradeCount == 0)
        {
            AutoCoin.ascendedAuto1 = 1;
            AutoCoin2.ascendedAuto2 = 1;
            AutoCoin3.ascendedAuto3 = 1;
            AutoCoin4.ascendedAuto4 = 1;
            AutoCoin5.ascendedAuto5 = 1;
            AutoCoin6.ascendedAuto6 = 1;
            AutoCoin7.ascendedAuto7 = 1;
            AutoCoin8.ascendedAuto8 = 1;
            AutoCoin9.ascendedAuto9 = 1;
            AutoCoin10.ascendedAuto10 = 1;
            AutoCoin11.ascendedAuto11 = 1;
            AutoCoin12.ascendedAuto12 = 1;
            AutoCoin13.ascendedAuto13 = 1;
            MainButtonClick.activeFlipsAmount += 13;
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 13 && GoldenFlipsButton.goldenCoinsUpgradeCount == 0)
        {
            AutoCoin.ascendedAuto1 = 1;
            AutoCoin2.ascendedAuto2 = 1;
            AutoCoin3.ascendedAuto3 = 1;
            AutoCoin4.ascendedAuto4 = 1;
            AutoCoin5.ascendedAuto5 = 1;
            AutoCoin6.ascendedAuto6 = 1;
            AutoCoin7.ascendedAuto7 = 1;
            AutoCoin8.ascendedAuto8 = 1;
            AutoCoin9.ascendedAuto9 = 1;
            AutoCoin10.ascendedAuto10 = 1;
            AutoCoin11.ascendedAuto11 = 1;
            AutoCoin12.ascendedAuto12 = 1;
            AutoCoin13.ascendedAuto13 = 1;
            AutoCoin14.ascendedAuto14 = 1;
            MainButtonClick.activeFlipsAmount += 14;
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 14 && GoldenFlipsButton.goldenCoinsUpgradeCount == 0)
        {
            AutoCoin.ascendedAuto1 = 1;
            AutoCoin2.ascendedAuto2 = 1;
            AutoCoin3.ascendedAuto3 = 1;
            AutoCoin4.ascendedAuto4 = 1;
            AutoCoin5.ascendedAuto5 = 1;
            AutoCoin6.ascendedAuto6 = 1;
            AutoCoin7.ascendedAuto7 = 1;
            AutoCoin8.ascendedAuto8 = 1;
            AutoCoin9.ascendedAuto9 = 1;
            AutoCoin10.ascendedAuto10 = 1;
            AutoCoin11.ascendedAuto11 = 1;
            AutoCoin12.ascendedAuto12 = 1;
            AutoCoin13.ascendedAuto13 = 1;
            AutoCoin14.ascendedAuto14 = 1;
            AutoCoin15.ascendedAuto15 = 1;
            MainButtonClick.activeFlipsAmount += 15;
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 15 && GoldenFlipsButton.goldenCoinsUpgradeCount == 0)
        {
            AutoCoin.ascendedAuto1 = 1;
            AutoCoin2.ascendedAuto2 = 1;
            AutoCoin3.ascendedAuto3 = 1;
            AutoCoin4.ascendedAuto4 = 1;
            AutoCoin5.ascendedAuto5 = 1;
            AutoCoin6.ascendedAuto6 = 1;
            AutoCoin7.ascendedAuto7 = 1;
            AutoCoin8.ascendedAuto8 = 1;
            AutoCoin9.ascendedAuto9 = 1;
            AutoCoin10.ascendedAuto10 = 1;
            AutoCoin11.ascendedAuto11 = 1;
            AutoCoin12.ascendedAuto12 = 1;
            AutoCoin13.ascendedAuto13 = 1;
            AutoCoin14.ascendedAuto14 = 1;
            AutoCoin15.ascendedAuto15 = 1;
            AutoCoin16.ascendedAuto17 = 1;
            MainButtonClick.activeFlipsAmount += 16;
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 16 && GoldenFlipsButton.goldenCoinsUpgradeCount == 0)
        {
            AutoCoin.ascendedAuto1 = 1;
            AutoCoin2.ascendedAuto2 = 1;
            AutoCoin3.ascendedAuto3 = 1;
            AutoCoin4.ascendedAuto4 = 1;
            AutoCoin5.ascendedAuto5 = 1;
            AutoCoin6.ascendedAuto6 = 1;
            AutoCoin7.ascendedAuto7 = 1;
            AutoCoin8.ascendedAuto8 = 1;
            AutoCoin9.ascendedAuto9 = 1;
            AutoCoin10.ascendedAuto10 = 1;
            AutoCoin11.ascendedAuto11 = 1;
            AutoCoin12.ascendedAuto12 = 1;
            AutoCoin13.ascendedAuto13 = 1;
            AutoCoin14.ascendedAuto14 = 1;
            AutoCoin15.ascendedAuto15 = 1;
            AutoCoin16.ascendedAuto17 = 1;
            AutoCoin17.ascendedAuto16 = 1;
            MainButtonClick.activeFlipsAmount += 17;
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 17 && GoldenFlipsButton.goldenCoinsUpgradeCount == 0)
        {
            AutoCoin.ascendedAuto1 = 1;
            AutoCoin2.ascendedAuto2 = 1;
            AutoCoin3.ascendedAuto3 = 1;
            AutoCoin4.ascendedAuto4 = 1;
            AutoCoin5.ascendedAuto5 = 1;
            AutoCoin6.ascendedAuto6 = 1;
            AutoCoin7.ascendedAuto7 = 1;
            AutoCoin8.ascendedAuto8 = 1;
            AutoCoin9.ascendedAuto9 = 1;
            AutoCoin10.ascendedAuto10 = 1;
            AutoCoin11.ascendedAuto11 = 1;
            AutoCoin12.ascendedAuto12 = 1;
            AutoCoin13.ascendedAuto13 = 1;
            AutoCoin14.ascendedAuto14 = 1;
            AutoCoin15.ascendedAuto15 = 1;
            AutoCoin16.ascendedAuto17 = 1;
            AutoCoin17.ascendedAuto16 = 1;
            AutoCoin18.ascendedAuto19 = 1;
            MainButtonClick.activeFlipsAmount += 18;
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 18 && GoldenFlipsButton.goldenCoinsUpgradeCount == 0)
        {
            AutoCoin.ascendedAuto1 = 1;
            AutoCoin2.ascendedAuto2 = 1;
            AutoCoin3.ascendedAuto3 = 1;
            AutoCoin4.ascendedAuto4 = 1;
            AutoCoin5.ascendedAuto5 = 1;
            AutoCoin6.ascendedAuto6 = 1;
            AutoCoin7.ascendedAuto7 = 1;
            AutoCoin8.ascendedAuto8 = 1;
            AutoCoin9.ascendedAuto9 = 1;
            AutoCoin10.ascendedAuto10 = 1;
            AutoCoin11.ascendedAuto11 = 1;
            AutoCoin12.ascendedAuto12 = 1;
            AutoCoin13.ascendedAuto13 = 1;
            AutoCoin14.ascendedAuto14 = 1;
            AutoCoin15.ascendedAuto15 = 1;
            AutoCoin16.ascendedAuto17 = 1;
            AutoCoin17.ascendedAuto16 = 1;
            AutoCoin18.ascendedAuto19 = 1;
            AutoCoin19.ascendedAuto18 = 1;
            MainButtonClick.activeFlipsAmount += 19;
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 19 && GoldenFlipsButton.goldenCoinsUpgradeCount == 0)
        {
            AutoCoin.ascendedAuto1 = 1;
            AutoCoin2.ascendedAuto2 = 1;
            AutoCoin3.ascendedAuto3 = 1;
            AutoCoin4.ascendedAuto4 = 1;
            AutoCoin5.ascendedAuto5 = 1;
            AutoCoin6.ascendedAuto6 = 1;
            AutoCoin7.ascendedAuto7 = 1;
            AutoCoin8.ascendedAuto8 = 1;
            AutoCoin9.ascendedAuto9 = 1;
            AutoCoin10.ascendedAuto10 = 1;
            AutoCoin11.ascendedAuto11 = 1;
            AutoCoin12.ascendedAuto12 = 1;
            AutoCoin13.ascendedAuto13 = 1;
            AutoCoin14.ascendedAuto14 = 1;
            AutoCoin15.ascendedAuto15 = 1;
            AutoCoin16.ascendedAuto17 = 1;
            AutoCoin17.ascendedAuto16 = 1;
            AutoCoin18.ascendedAuto19 = 1;
            AutoCoin19.ascendedAuto18 = 1;
            AutoCoin20.ascendedAuto20 = 1;
            MainButtonClick.activeFlipsAmount += 20;
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 20 && GoldenFlipsButton.goldenCoinsUpgradeCount == 0)
        {
            AutoCoin.ascendedAuto1 = 1;
            AutoCoin2.ascendedAuto2 = 1;
            AutoCoin3.ascendedAuto3 = 1;
            AutoCoin4.ascendedAuto4 = 1;
            AutoCoin5.ascendedAuto5 = 1;
            AutoCoin6.ascendedAuto6 = 1;
            AutoCoin7.ascendedAuto7 = 1;
            AutoCoin8.ascendedAuto8 = 1;
            AutoCoin9.ascendedAuto9 = 1;
            AutoCoin10.ascendedAuto10 = 1;
            AutoCoin11.ascendedAuto11 = 1;
            AutoCoin12.ascendedAuto12 = 1;
            AutoCoin13.ascendedAuto13 = 1;
            AutoCoin14.ascendedAuto14 = 1;
            AutoCoin15.ascendedAuto15 = 1;
            AutoCoin16.ascendedAuto17 = 1;
            AutoCoin17.ascendedAuto16 = 1;
            AutoCoin18.ascendedAuto19 = 1;
            AutoCoin19.ascendedAuto18 = 1;
            AutoCoin20.ascendedAuto20 = 1;
            AutoCoin21.ascendedAuto21 = 1;
            MainButtonClick.activeFlipsAmount += 21;
        }
       



        if (GoldenFlipsButton.goldenCoinsUpgradeCount == 1)
        {
            MainButtonClick.activeFlipsAmount += 21;
            SpecialAuto1.flipAuto = 1;
            AutoCoin.ascendedAuto1 = 0;
            AutoCoin2.ascendedAuto2 = 1;
            AutoCoin3.ascendedAuto3 = 1;
            AutoCoin4.ascendedAuto4 = 1;
            AutoCoin5.ascendedAuto5 = 1;
            AutoCoin6.ascendedAuto6 = 1;
            AutoCoin7.ascendedAuto7 = 1;
            AutoCoin8.ascendedAuto8 = 1;
            AutoCoin9.ascendedAuto9 = 1;
            AutoCoin10.ascendedAuto10 = 1;
            AutoCoin11.ascendedAuto11 = 1;
            AutoCoin12.ascendedAuto12 = 1;
            AutoCoin13.ascendedAuto13 = 1;
            AutoCoin14.ascendedAuto14 = 1;
            AutoCoin15.ascendedAuto15 = 1;
            AutoCoin16.ascendedAuto17 = 1;
            AutoCoin17.ascendedAuto16 = 1;
            AutoCoin18.ascendedAuto19 = 1;
            AutoCoin19.ascendedAuto18 = 1;
            AutoCoin20.ascendedAuto20 = 1;
            AutoCoin21.ascendedAuto21 = 1;

        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount == 2)
        {
            MainButtonClick.activeFlipsAmount += 21;
            SpecialAuto1.flipAuto = 1;
            SpecialAuto2.flipAuto = 1;
            AutoCoin2.ascendedAuto2 = 0;
            AutoCoin2.ascendedAuto2 = 0;
            AutoCoin3.ascendedAuto3 = 1;
            AutoCoin4.ascendedAuto4 = 1;
            AutoCoin5.ascendedAuto5 = 1;
            AutoCoin6.ascendedAuto6 = 1;
            AutoCoin7.ascendedAuto7 = 1;
            AutoCoin8.ascendedAuto8 = 1;
            AutoCoin9.ascendedAuto9 = 1;
            AutoCoin10.ascendedAuto10 = 1;
            AutoCoin11.ascendedAuto11 = 1;
            AutoCoin12.ascendedAuto12 = 1;
            AutoCoin13.ascendedAuto13 = 1;
            AutoCoin14.ascendedAuto14 = 1;
            AutoCoin15.ascendedAuto15 = 1;
            AutoCoin16.ascendedAuto17 = 1;
            AutoCoin17.ascendedAuto16 = 1;
            AutoCoin18.ascendedAuto19 = 1;
            AutoCoin19.ascendedAuto18 = 1;
            AutoCoin20.ascendedAuto20 = 1;
            AutoCoin21.ascendedAuto21 = 1;
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount == 3)
        {
            MainButtonClick.activeFlipsAmount += 21;
            SpecialAuto1.flipAuto = 1;
            SpecialAuto2.flipAuto = 1;
            SpecialAuto3.flipAuto = 1;
            AutoCoin3.ascendedAuto3 = 0;
            AutoCoin2.ascendedAuto2 = 0;
            AutoCoin3.ascendedAuto3 = 0;
            AutoCoin4.ascendedAuto4 = 1;
            AutoCoin5.ascendedAuto5 = 1;
            AutoCoin6.ascendedAuto6 = 1;
            AutoCoin7.ascendedAuto7 = 1;
            AutoCoin8.ascendedAuto8 = 1;
            AutoCoin9.ascendedAuto9 = 1;
            AutoCoin10.ascendedAuto10 = 1;
            AutoCoin11.ascendedAuto11 = 1;
            AutoCoin12.ascendedAuto12 = 1;
            AutoCoin13.ascendedAuto13 = 1;
            AutoCoin14.ascendedAuto14 = 1;
            AutoCoin15.ascendedAuto15 = 1;
            AutoCoin16.ascendedAuto17 = 1;
            AutoCoin17.ascendedAuto16 = 1;
            AutoCoin18.ascendedAuto19 = 1;
            AutoCoin19.ascendedAuto18 = 1;
            AutoCoin20.ascendedAuto20 = 1;
            AutoCoin21.ascendedAuto21 = 1;
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount == 4)
        {
            MainButtonClick.activeFlipsAmount += 21;
            SpecialAuto1.flipAuto = 1;
            SpecialAuto2.flipAuto = 1;
            SpecialAuto3.flipAuto = 1;
            SpecialAuto4.flipAuto = 1;
            AutoCoin4.ascendedAuto4 = 0;
            AutoCoin2.ascendedAuto2 = 0;
            AutoCoin3.ascendedAuto3 = 0;
            AutoCoin4.ascendedAuto4 = 0;
            AutoCoin5.ascendedAuto5 = 1;
            AutoCoin6.ascendedAuto6 = 1;
            AutoCoin7.ascendedAuto7 = 1;
            AutoCoin8.ascendedAuto8 = 1;
            AutoCoin9.ascendedAuto9 = 1;
            AutoCoin10.ascendedAuto10 = 1;
            AutoCoin11.ascendedAuto11 = 1;
            AutoCoin12.ascendedAuto12 = 1;
            AutoCoin13.ascendedAuto13 = 1;
            AutoCoin14.ascendedAuto14 = 1;
            AutoCoin15.ascendedAuto15 = 1;
            AutoCoin16.ascendedAuto17 = 1;
            AutoCoin17.ascendedAuto16 = 1;
            AutoCoin18.ascendedAuto19 = 1;
            AutoCoin19.ascendedAuto18 = 1;
            AutoCoin20.ascendedAuto20 = 1;
            AutoCoin21.ascendedAuto21 = 1;
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount == 5)
        {
            MainButtonClick.activeFlipsAmount += 21;
            SpecialAuto1.flipAuto = 1;
            SpecialAuto2.flipAuto = 1;
            SpecialAuto3.flipAuto = 1;
            SpecialAuto4.flipAuto = 1;
            SpecialAuto5.flipAuto = 1;
            AutoCoin5.ascendedAuto5 = 0;
            AutoCoin4.ascendedAuto4 = 0;
            AutoCoin2.ascendedAuto2 = 0;
            AutoCoin3.ascendedAuto3 = 0;
            AutoCoin4.ascendedAuto4 = 0;
            AutoCoin5.ascendedAuto5 = 0;
            AutoCoin6.ascendedAuto6 = 1;
            AutoCoin7.ascendedAuto7 = 1;
            AutoCoin8.ascendedAuto8 = 1;
            AutoCoin9.ascendedAuto9 = 1;
            AutoCoin10.ascendedAuto10 = 1;
            AutoCoin11.ascendedAuto11 = 1;
            AutoCoin12.ascendedAuto12 = 1;
            AutoCoin13.ascendedAuto13 = 1;
            AutoCoin14.ascendedAuto14 = 1;
            AutoCoin15.ascendedAuto15 = 1;
            AutoCoin16.ascendedAuto17 = 1;
            AutoCoin17.ascendedAuto16 = 1;
            AutoCoin18.ascendedAuto19 = 1;
            AutoCoin19.ascendedAuto18 = 1;
            AutoCoin20.ascendedAuto20 = 1;
            AutoCoin21.ascendedAuto21 = 1;
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount == 6)
        {
            MainButtonClick.activeFlipsAmount += 21;
            SpecialAuto1.flipAuto = 1;
            SpecialAuto2.flipAuto = 1;
            SpecialAuto3.flipAuto = 1;
            SpecialAuto4.flipAuto = 1;
            SpecialAuto5.flipAuto = 1;
            SpecialAuto6.flipAuto = 1;
            AutoCoin6.ascendedAuto6 = 0;
            AutoCoin4.ascendedAuto4 = 0;
            AutoCoin2.ascendedAuto2 = 0;
            AutoCoin3.ascendedAuto3 = 0;
            AutoCoin4.ascendedAuto4 = 0;
            AutoCoin5.ascendedAuto5 = 0;
            AutoCoin6.ascendedAuto6 = 0;
            AutoCoin7.ascendedAuto7 = 1;
            AutoCoin8.ascendedAuto8 = 1;
            AutoCoin9.ascendedAuto9 = 1;
            AutoCoin10.ascendedAuto10 = 1;
            AutoCoin11.ascendedAuto11 = 1;
            AutoCoin12.ascendedAuto12 = 1;
            AutoCoin13.ascendedAuto13 = 1;
            AutoCoin14.ascendedAuto14 = 1;
            AutoCoin15.ascendedAuto15 = 1;
            AutoCoin16.ascendedAuto17 = 1;
            AutoCoin17.ascendedAuto16 = 1;
            AutoCoin18.ascendedAuto19 = 1;
            AutoCoin19.ascendedAuto18 = 1;
            AutoCoin20.ascendedAuto20 = 1;
            AutoCoin21.ascendedAuto21 = 1;
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount == 7)
        {
            MainButtonClick.activeFlipsAmount += 21;
            SpecialAuto1.flipAuto = 1;
            SpecialAuto2.flipAuto = 1;
            SpecialAuto3.flipAuto = 1;
            SpecialAuto4.flipAuto = 1;
            SpecialAuto5.flipAuto = 1;
            SpecialAuto6.flipAuto = 1;
            SpecialAuto7.flipAuto = 1;
            AutoCoin7.ascendedAuto7 = 0;
            AutoCoin4.ascendedAuto4 = 0;
            AutoCoin2.ascendedAuto2 = 0;
            AutoCoin3.ascendedAuto3 = 0;
            AutoCoin4.ascendedAuto4 = 0;
            AutoCoin5.ascendedAuto5 = 0;
            AutoCoin6.ascendedAuto6 = 0;
            AutoCoin7.ascendedAuto7 = 0;
            AutoCoin8.ascendedAuto8 = 1;
            AutoCoin9.ascendedAuto9 = 1;
            AutoCoin10.ascendedAuto10 = 1;
            AutoCoin11.ascendedAuto11 = 1;
            AutoCoin12.ascendedAuto12 = 1;
            AutoCoin13.ascendedAuto13 = 1;
            AutoCoin14.ascendedAuto14 = 1;
            AutoCoin15.ascendedAuto15 = 1;
            AutoCoin16.ascendedAuto17 = 1;
            AutoCoin17.ascendedAuto16 = 1;
            AutoCoin18.ascendedAuto19 = 1;
            AutoCoin19.ascendedAuto18 = 1;
            AutoCoin20.ascendedAuto20 = 1;
            AutoCoin21.ascendedAuto21 = 1;
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount == 8)
        {
            MainButtonClick.activeFlipsAmount += 21;
            SpecialAuto1.flipAuto = 1;
            SpecialAuto2.flipAuto = 1;
            SpecialAuto3.flipAuto = 1;
            SpecialAuto4.flipAuto = 1;
            SpecialAuto5.flipAuto = 1;
            SpecialAuto6.flipAuto = 1;
            SpecialAuto7.flipAuto = 1;
            SpecialAuto8.flipAuto = 1;
            AutoCoin8.ascendedAuto8 = 0;
            AutoCoin4.ascendedAuto4 = 0;
            AutoCoin2.ascendedAuto2 = 0;
            AutoCoin3.ascendedAuto3 = 0;
            AutoCoin4.ascendedAuto4 = 0;
            AutoCoin5.ascendedAuto5 = 0;
            AutoCoin6.ascendedAuto6 = 0;
            AutoCoin7.ascendedAuto7 = 0;
            AutoCoin8.ascendedAuto8 = 0;
            AutoCoin9.ascendedAuto9 = 1;
            AutoCoin10.ascendedAuto10 = 1;
            AutoCoin11.ascendedAuto11 = 1;
            AutoCoin12.ascendedAuto12 = 1;
            AutoCoin13.ascendedAuto13 = 1;
            AutoCoin14.ascendedAuto14 = 1;
            AutoCoin15.ascendedAuto15 = 1;
            AutoCoin16.ascendedAuto17 = 1;
            AutoCoin17.ascendedAuto16 = 1;
            AutoCoin18.ascendedAuto19 = 1;
            AutoCoin19.ascendedAuto18 = 1;
            AutoCoin20.ascendedAuto20 = 1;
            AutoCoin21.ascendedAuto21 = 1;
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount == 9)
        {
            MainButtonClick.activeFlipsAmount += 21;
            SpecialAuto1.flipAuto = 1;
            SpecialAuto2.flipAuto = 1;
            SpecialAuto3.flipAuto = 1;
            SpecialAuto4.flipAuto = 1;
            SpecialAuto5.flipAuto = 1;
            SpecialAuto6.flipAuto = 1;
            SpecialAuto7.flipAuto = 1;
            SpecialAuto8.flipAuto = 1;
            SpecialAuto9.flipAuto = 1;
            AutoCoin9.ascendedAuto9 = 0;
            AutoCoin4.ascendedAuto4 = 0;
            AutoCoin2.ascendedAuto2 = 0;
            AutoCoin3.ascendedAuto3 = 0;
            AutoCoin4.ascendedAuto4 = 0;
            AutoCoin5.ascendedAuto5 = 0;
            AutoCoin6.ascendedAuto6 = 0;
            AutoCoin7.ascendedAuto7 = 0;
            AutoCoin8.ascendedAuto8 = 0;
            AutoCoin9.ascendedAuto9 = 0;
            AutoCoin10.ascendedAuto10 = 1;
            AutoCoin11.ascendedAuto11 = 1;
            AutoCoin12.ascendedAuto12 = 1;
            AutoCoin13.ascendedAuto13 = 1;
            AutoCoin14.ascendedAuto14 = 1;
            AutoCoin15.ascendedAuto15 = 1;
            AutoCoin16.ascendedAuto17 = 1;
            AutoCoin17.ascendedAuto16 = 1;
            AutoCoin18.ascendedAuto19 = 1;
            AutoCoin19.ascendedAuto18 = 1;
            AutoCoin20.ascendedAuto20 = 1;
            AutoCoin21.ascendedAuto21 = 1;
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount == 10)
        {
            MainButtonClick.activeFlipsAmount += 21;
            SpecialAuto1.flipAuto = 1;
            SpecialAuto2.flipAuto = 1;
            SpecialAuto3.flipAuto = 1;
            SpecialAuto4.flipAuto = 1;
            SpecialAuto5.flipAuto = 1;
            SpecialAuto6.flipAuto = 1;
            SpecialAuto7.flipAuto = 1;
            SpecialAuto8.flipAuto = 1;
            SpecialAuto9.flipAuto = 1;
            SpecialAuto10.flipAuto = 1;
            AutoCoin10.ascendedAuto10 = 0;
            AutoCoin4.ascendedAuto4 = 0;
            AutoCoin2.ascendedAuto2 = 0;
            AutoCoin3.ascendedAuto3 = 0;
            AutoCoin4.ascendedAuto4 = 0;
            AutoCoin5.ascendedAuto5 = 0;
            AutoCoin6.ascendedAuto6 = 0;
            AutoCoin7.ascendedAuto7 = 0;
            AutoCoin8.ascendedAuto8 = 0;
            AutoCoin9.ascendedAuto9 = 0;
            AutoCoin10.ascendedAuto10 = 0;
            AutoCoin11.ascendedAuto11 = 1;
            AutoCoin12.ascendedAuto12 = 1;
            AutoCoin13.ascendedAuto13 = 1;
            AutoCoin14.ascendedAuto14 = 1;
            AutoCoin15.ascendedAuto15 = 1;
            AutoCoin16.ascendedAuto17 = 1;
            AutoCoin17.ascendedAuto16 = 1;
            AutoCoin18.ascendedAuto19 = 1;
            AutoCoin19.ascendedAuto18 = 1;
            AutoCoin20.ascendedAuto20 = 1;
            AutoCoin21.ascendedAuto21 = 1;
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount == 11)
        {
            MainButtonClick.activeFlipsAmount += 21;
            SpecialAuto1.flipAuto = 1;
            SpecialAuto2.flipAuto = 1;
            SpecialAuto3.flipAuto = 1;
            SpecialAuto4.flipAuto = 1;
            SpecialAuto5.flipAuto = 1;
            SpecialAuto6.flipAuto = 1;
            SpecialAuto7.flipAuto = 1;
            SpecialAuto8.flipAuto = 1;
            SpecialAuto9.flipAuto = 1;
            SpecialAuto10.flipAuto = 1;
            SpecialAuto11.flipAuto = 1;
            AutoCoin11.ascendedAuto11 = 0;
            AutoCoin4.ascendedAuto4 = 0;
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
            AutoCoin12.ascendedAuto12 = 1;
            AutoCoin13.ascendedAuto13 = 1;
            AutoCoin14.ascendedAuto14 = 1;
            AutoCoin15.ascendedAuto15 = 1;
            AutoCoin16.ascendedAuto17 = 1;
            AutoCoin17.ascendedAuto16 = 1;
            AutoCoin18.ascendedAuto19 = 1;
            AutoCoin19.ascendedAuto18 = 1;
            AutoCoin20.ascendedAuto20 = 1;
            AutoCoin21.ascendedAuto21 = 1;
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount == 12)
        {
            MainButtonClick.activeFlipsAmount += 21;
            SpecialAuto1.flipAuto = 1;
            SpecialAuto2.flipAuto = 1;
            SpecialAuto3.flipAuto = 1;
            SpecialAuto4.flipAuto = 1;
            SpecialAuto5.flipAuto = 1;
            SpecialAuto6.flipAuto = 1;
            SpecialAuto7.flipAuto = 1;
            SpecialAuto8.flipAuto = 1;
            SpecialAuto9.flipAuto = 1;
            SpecialAuto10.flipAuto = 1;
            SpecialAuto11.flipAuto = 1;
            SpecialAuto12.flipAuto = 1;
            AutoCoin12.ascendedAuto12 = 0;
            AutoCoin4.ascendedAuto4 = 0;
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
            AutoCoin13.ascendedAuto13 = 1;
            AutoCoin14.ascendedAuto14 = 1;
            AutoCoin15.ascendedAuto15 = 1;
            AutoCoin16.ascendedAuto17 = 1;
            AutoCoin17.ascendedAuto16 = 1;
            AutoCoin18.ascendedAuto19 = 1;
            AutoCoin19.ascendedAuto18 = 1;
            AutoCoin20.ascendedAuto20 = 1;
            AutoCoin21.ascendedAuto21 = 1;
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount == 13)
        {
            MainButtonClick.activeFlipsAmount += 21;
            SpecialAuto1.flipAuto = 1;
            SpecialAuto2.flipAuto = 1;
            SpecialAuto3.flipAuto = 1;
            SpecialAuto4.flipAuto = 1;
            SpecialAuto5.flipAuto = 1;
            SpecialAuto6.flipAuto = 1;
            SpecialAuto7.flipAuto = 1;
            SpecialAuto8.flipAuto = 1;
            SpecialAuto9.flipAuto = 1;
            SpecialAuto10.flipAuto = 1;
            SpecialAuto11.flipAuto = 1;
            SpecialAuto12.flipAuto = 1;
            SpecialAuto13.flipAuto = 1;
            AutoCoin13.ascendedAuto13 = 0;
            AutoCoin4.ascendedAuto4 = 0;
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
            AutoCoin14.ascendedAuto14 = 1;
            AutoCoin15.ascendedAuto15 = 1;
            AutoCoin16.ascendedAuto17 = 1;
            AutoCoin17.ascendedAuto16 = 1;
            AutoCoin18.ascendedAuto19 = 1;
            AutoCoin19.ascendedAuto18 = 1;
            AutoCoin20.ascendedAuto20 = 1;
            AutoCoin21.ascendedAuto21 = 1;
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount == 14)
        {
            MainButtonClick.activeFlipsAmount += 21;
            SpecialAuto1.flipAuto = 1;
            SpecialAuto2.flipAuto = 1;
            SpecialAuto3.flipAuto = 1;
            SpecialAuto4.flipAuto = 1;
            SpecialAuto5.flipAuto = 1;
            SpecialAuto6.flipAuto = 1;
            SpecialAuto7.flipAuto = 1;
            SpecialAuto8.flipAuto = 1;
            SpecialAuto9.flipAuto = 1;
            SpecialAuto10.flipAuto = 1;
            SpecialAuto11.flipAuto = 1;
            SpecialAuto12.flipAuto = 1;
            SpecialAuto13.flipAuto = 1;
            SpecialAuto14.flipAuto = 1;
            AutoCoin14.ascendedAuto14 = 0;
            AutoCoin4.ascendedAuto4 = 0;
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
            AutoCoin15.ascendedAuto15 = 1;
            AutoCoin16.ascendedAuto17 = 1;
            AutoCoin17.ascendedAuto16 = 1;
            AutoCoin18.ascendedAuto19 = 1;
            AutoCoin19.ascendedAuto18 = 1;
            AutoCoin20.ascendedAuto20 = 1;
            AutoCoin21.ascendedAuto21 = 1;
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount == 15)
        {
            MainButtonClick.activeFlipsAmount += 21;
            SpecialAuto1.flipAuto = 1;
            SpecialAuto2.flipAuto = 1;
            SpecialAuto3.flipAuto = 1;
            SpecialAuto4.flipAuto = 1;
            SpecialAuto5.flipAuto = 1;
            SpecialAuto6.flipAuto = 1;
            SpecialAuto7.flipAuto = 1;
            SpecialAuto8.flipAuto = 1;
            SpecialAuto9.flipAuto = 1;
            SpecialAuto10.flipAuto = 1;
            SpecialAuto11.flipAuto = 1;
            SpecialAuto12.flipAuto = 1;
            SpecialAuto13.flipAuto = 1;
            SpecialAuto14.flipAuto = 1;
            SpecialAuto15.flipAuto = 1;
            AutoCoin15.ascendedAuto15 = 0;
            AutoCoin4.ascendedAuto4 = 0;
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
            AutoCoin16.ascendedAuto17 = 1;
            AutoCoin17.ascendedAuto16 = 1;
            AutoCoin18.ascendedAuto19 = 1;
            AutoCoin19.ascendedAuto18 = 1;
            AutoCoin20.ascendedAuto20 = 1;
            AutoCoin21.ascendedAuto21 = 1;
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount == 16)
        {
            MainButtonClick.activeFlipsAmount += 21;
            SpecialAuto1.flipAuto = 1;
            SpecialAuto2.flipAuto = 1;
            SpecialAuto3.flipAuto = 1;
            SpecialAuto4.flipAuto = 1;
            SpecialAuto5.flipAuto = 1;
            SpecialAuto6.flipAuto = 1;
            SpecialAuto7.flipAuto = 1;
            SpecialAuto8.flipAuto = 1;
            SpecialAuto9.flipAuto = 1;
            SpecialAuto10.flipAuto = 1;
            SpecialAuto11.flipAuto = 1;
            SpecialAuto12.flipAuto = 1;
            SpecialAuto13.flipAuto = 1;
            SpecialAuto14.flipAuto = 1;
            SpecialAuto15.flipAuto = 1;
            SpecialAuto16.flipAuto = 1;

            AutoCoin16.ascendedAuto17 = 0;
            AutoCoin4.ascendedAuto4 = 0;
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
            AutoCoin17.ascendedAuto16 = 1;
            AutoCoin18.ascendedAuto19 = 1;
            AutoCoin19.ascendedAuto18 = 1;
            AutoCoin20.ascendedAuto20 = 1;
            AutoCoin21.ascendedAuto21 = 1;
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount == 17)
        {
            MainButtonClick.activeFlipsAmount += 21;
            SpecialAuto1.flipAuto = 1;
            SpecialAuto2.flipAuto = 1;
            SpecialAuto3.flipAuto = 1;
            SpecialAuto4.flipAuto = 1;
            SpecialAuto5.flipAuto = 1;
            SpecialAuto6.flipAuto = 1;
            SpecialAuto7.flipAuto = 1;
            SpecialAuto8.flipAuto = 1;
            SpecialAuto9.flipAuto = 1;
            SpecialAuto10.flipAuto = 1;
            SpecialAuto11.flipAuto = 1;
            SpecialAuto12.flipAuto = 1;
            SpecialAuto13.flipAuto = 1;
            SpecialAuto14.flipAuto = 1;
            SpecialAuto15.flipAuto = 1;
            SpecialAuto16.flipAuto = 1;
            SpecialAuto17.flipAuto = 1;
            AutoCoin17.ascendedAuto16 = 0;
            AutoCoin4.ascendedAuto4 = 0;
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
            AutoCoin18.ascendedAuto19 = 1;
            AutoCoin19.ascendedAuto18 = 1;
            AutoCoin20.ascendedAuto20 = 1;
            AutoCoin21.ascendedAuto21 = 1;
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount == 18)
        {
            MainButtonClick.activeFlipsAmount += 21;
            SpecialAuto1.flipAuto = 1;
            SpecialAuto2.flipAuto = 1;
            SpecialAuto3.flipAuto = 1;
            SpecialAuto4.flipAuto = 1;
            SpecialAuto5.flipAuto = 1;
            SpecialAuto6.flipAuto = 1;
            SpecialAuto7.flipAuto = 1;
            SpecialAuto8.flipAuto = 1;
            SpecialAuto9.flipAuto = 1;
            SpecialAuto10.flipAuto = 1;
            SpecialAuto11.flipAuto = 1;
            SpecialAuto12.flipAuto = 1;
            SpecialAuto13.flipAuto = 1;
            SpecialAuto14.flipAuto = 1;
            SpecialAuto15.flipAuto = 1;
            SpecialAuto16.flipAuto = 1;
            SpecialAuto17.flipAuto = 1;
            SpecialAuto18.flipAuto = 1;
            AutoCoin18.ascendedAuto19 = 0;
            AutoCoin4.ascendedAuto4 = 0;
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
            AutoCoin19.ascendedAuto18 = 1;
            AutoCoin20.ascendedAuto20 = 1;
            AutoCoin21.ascendedAuto21 = 1;
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount == 19)
        {
            MainButtonClick.activeFlipsAmount += 21;
            SpecialAuto1.flipAuto = 1;
            SpecialAuto2.flipAuto = 1;
            SpecialAuto3.flipAuto = 1;
            SpecialAuto4.flipAuto = 1;
            SpecialAuto5.flipAuto = 1;
            SpecialAuto6.flipAuto = 1;
            SpecialAuto7.flipAuto = 1;
            SpecialAuto8.flipAuto = 1;
            SpecialAuto9.flipAuto = 1;
            SpecialAuto10.flipAuto = 1;
            SpecialAuto11.flipAuto = 1;
            SpecialAuto12.flipAuto = 1;
            SpecialAuto13.flipAuto = 1;
            SpecialAuto14.flipAuto = 1;
            SpecialAuto15.flipAuto = 1;
            SpecialAuto16.flipAuto = 1;
            SpecialAuto17.flipAuto = 1;
            SpecialAuto18.flipAuto = 1;
            SpecialAuto19.flipAuto = 1;
            AutoCoin19.ascendedAuto18 = 0;
            AutoCoin4.ascendedAuto4 = 0;
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
            AutoCoin20.ascendedAuto20 = 1;
            AutoCoin21.ascendedAuto21 = 1;
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount == 20)
        {
            MainButtonClick.activeFlipsAmount += 21;
            SpecialAuto1.flipAuto = 1;
            SpecialAuto2.flipAuto = 1;
            SpecialAuto3.flipAuto = 1;
            SpecialAuto4.flipAuto = 1;
            SpecialAuto5.flipAuto = 1;
            SpecialAuto6.flipAuto = 1;
            SpecialAuto7.flipAuto = 1;
            SpecialAuto8.flipAuto = 1;
            SpecialAuto9.flipAuto = 1;
            SpecialAuto10.flipAuto = 1;
            SpecialAuto11.flipAuto = 1;
            SpecialAuto12.flipAuto = 1;
            SpecialAuto13.flipAuto = 1;
            SpecialAuto14.flipAuto = 1;
            SpecialAuto15.flipAuto = 1;
            SpecialAuto16.flipAuto = 1;
            SpecialAuto17.flipAuto = 1;
            SpecialAuto18.flipAuto = 1;
            SpecialAuto19.flipAuto = 1;
            SpecialAuto20.flipAuto = 1;
            AutoCoin20.ascendedAuto20 = 0;
            AutoCoin4.ascendedAuto4 = 0;
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
            AutoCoin21.ascendedAuto21 = 1;
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount == 21)
        {
            MainButtonClick.activeFlipsAmount += 21;
            SpecialAuto1.flipAuto = 1;
            SpecialAuto2.flipAuto = 1;
            SpecialAuto3.flipAuto = 1;
            SpecialAuto4.flipAuto = 1;
            SpecialAuto5.flipAuto = 1;
            SpecialAuto6.flipAuto = 1;
            SpecialAuto7.flipAuto = 1;
            SpecialAuto8.flipAuto = 1;
            SpecialAuto9.flipAuto = 1;
            SpecialAuto10.flipAuto = 1;
            SpecialAuto11.flipAuto = 1;
            SpecialAuto12.flipAuto = 1;
            SpecialAuto13.flipAuto = 1;
            SpecialAuto14.flipAuto = 1;
            SpecialAuto15.flipAuto = 1;
            SpecialAuto16.flipAuto = 1;
            SpecialAuto17.flipAuto = 1;
            SpecialAuto18.flipAuto = 1;
            SpecialAuto19.flipAuto = 1;
            SpecialAuto20.flipAuto = 1;
            SpecialAuto21.flipAuto = 1;
            AutoCoin21.ascendedAuto21 = 0;
            AutoCoin4.ascendedAuto4 = 0;
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
        }

        StartCoroutine(StopCoins());
    }

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

    public void flippers()
    {
        flipper1.SetActive(false);
        if (MainButtonClick.numberOfDuplicationUpgrades > 0) { flipper2.SetActive(false); }
        if (MainButtonClick.numberOfDuplicationUpgrades > 1) { flipper3.SetActive(false); }
        if (MainButtonClick.numberOfDuplicationUpgrades > 2) { flipper4.SetActive(false); }
        if (MainButtonClick.numberOfDuplicationUpgrades > 3) { flipper5.SetActive(false); }
        if (MainButtonClick.numberOfDuplicationUpgrades > 4) { flipper6.SetActive(false); }
        if (MainButtonClick.numberOfDuplicationUpgrades > 5) { flipper7.SetActive(false); }
        if (MainButtonClick.numberOfDuplicationUpgrades > 6) { flipper8.SetActive(false); }
        if (MainButtonClick.numberOfDuplicationUpgrades > 7) { flipper9.SetActive(false); }
        if (MainButtonClick.numberOfDuplicationUpgrades > 8) { flipper10.SetActive(false); }
        if (MainButtonClick.numberOfDuplicationUpgrades > 9) { flipper11.SetActive(false); }
        if (MainButtonClick.numberOfDuplicationUpgrades > 10) { flipper12.SetActive(false); }
        if (MainButtonClick.numberOfDuplicationUpgrades > 11) { flipper13.SetActive(false); }
        if (MainButtonClick.numberOfDuplicationUpgrades > 12) { flipper14.SetActive(false); }
        if (MainButtonClick.numberOfDuplicationUpgrades > 13) { flipper15.SetActive(false); }
        if (MainButtonClick.numberOfDuplicationUpgrades > 14) { flipper16.SetActive(false); }
        if (MainButtonClick.numberOfDuplicationUpgrades > 15) { flipper17.SetActive(false); }
        if (MainButtonClick.numberOfDuplicationUpgrades > 16) { flipper18.SetActive(false); }
        if (MainButtonClick.numberOfDuplicationUpgrades > 17) { flipper19.SetActive(false); }
        if (MainButtonClick.numberOfDuplicationUpgrades > 18) { flipper20.SetActive(false); }
        if (MainButtonClick.numberOfDuplicationUpgrades > 19) { flipper21.SetActive(false); }

       
    }


    IEnumerator StopCoins()
    {
        yield return new WaitForSeconds(0.1f);
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
        yield return new WaitForSeconds(1.49f);
        if(GlobalCoinMaker.coinsPerFlipUpgrades > 0) { flipper1.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 1) { flipper2.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 2) { flipper3.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 3) { flipper4.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 4) { flipper5.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 5) { flipper6.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 6) { flipper7.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 7) { flipper8.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 8) { flipper9.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 9) { flipper10.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 10) { flipper11.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 11) { flipper12.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 12) { flipper13.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 13) { flipper14.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 14) { flipper15.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 15) { flipper16.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 16) { flipper17.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 17) { flipper18.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 18) { flipper19.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 19) { flipper20.SetActive(true); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 20) { flipper21.SetActive(true); }
        yield return new WaitForSeconds(1.4f);
        hideSwitchButton.SetActive(false);

    }

    public void SetFlipperBack()
    {

        flipper1.SetActive(true);
        flipper2.SetActive(true);
        flipper3.SetActive(true);
        flipper4.SetActive(true);
        flipper5.SetActive(true);
        flipper6.SetActive(true);
        flipper7.SetActive(true);
        flipper8.SetActive(true);
        flipper9.SetActive(true);
        flipper10.SetActive(true);
        flipper11.SetActive(true);
        flipper12.SetActive(true);
        flipper13.SetActive(true);
        flipper14.SetActive(true);
        flipper15.SetActive(true);
        flipper16.SetActive(true);
        flipper17.SetActive(true);
        flipper18.SetActive(true);
        flipper19.SetActive(true);
        flipper20.SetActive(true);
        flipper21.SetActive(true);


        if (GlobalCoinMaker.coinsPerFlipUpgrades > 0) { flipper1.SetActive(false); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 1) { flipper2.SetActive(false); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 2) { flipper3.SetActive(false); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 3) { flipper4.SetActive(false); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 4) { flipper5.SetActive(false); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 5) { flipper6.SetActive(false); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 6) { flipper7.SetActive(false); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 7) { flipper8.SetActive(false); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 8) { flipper9.SetActive(false); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 9) { flipper10.SetActive(false); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 10) { flipper11.SetActive(false); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 11) { flipper12.SetActive(false); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 12) { flipper13.SetActive(false); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 13) { flipper14.SetActive(false); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 14) { flipper15.SetActive(false); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 15) { flipper16.SetActive(false); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 16) { flipper17.SetActive(false); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 17) { flipper18.SetActive(false); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 18) { flipper19.SetActive(false); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 19) { flipper20.SetActive(false); }
        if (GlobalCoinMaker.coinsPerFlipUpgrades > 20) { flipper21.SetActive(false); }
    }

    public void SetAutoFlipsBack()
    {
        blockScreen.SetActive(false);
        SetFlipperBack();
        flipAllBonus = 0;
        offButtonBlock.SetActive(false);
        blockAutoFlips.SetActive(false);
        blockUpgradedFlips.SetActive(false);
        onText.SetActive(true);
        offText.SetActive(false);
        isSwitchOff = 0;
        clickableButton.SetActive(false);
        notClickableButton.SetActive(true);
        //StartCoroutine(WaitAFewSecsTurnOn());

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

        ////

        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 0)
        {
            StartCoroutine(waitForSpecialAutoFlip21());
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 1)
        {
            StartCoroutine(waitForSpecialAutoFlip22());
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 2)
        {
            StartCoroutine(waitForSpecialAutoFlip23());
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 3)
        {
            StartCoroutine(waitForSpecialAutoFlip24());
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 4)
        {
            StartCoroutine(waitForSpecialAutoFlip25());
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 5)
        {
            StartCoroutine(waitForSpecialAutoFlip26());
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 6)
        {
            StartCoroutine(waitForSpecialAutoFlip27());
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 7)
        {
            StartCoroutine(waitForSpecialAutoFlip28());
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 8)
        {
            StartCoroutine(waitForSpecialAutoFlip29());
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 9)
        {
            StartCoroutine(waitForSpecialAutoFlip30());
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 10)
        {
            StartCoroutine(waitForSpecialAutoFlip31());
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 11)
        {
            StartCoroutine(waitForSpecialAutoFlip32());
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 12)
        {
            StartCoroutine(waitForSpecialAutoFlip33());
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 13)
        {
            StartCoroutine(waitForSpecialAutoFlip34());
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 14)
        {
            StartCoroutine(waitForSpecialAutoFlip35());
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 15)
        {
            StartCoroutine(waitForSpecialAutoFlip36());
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 16)
        {
            StartCoroutine(waitForSpecialAutoFlip37());
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 17)
        {
            StartCoroutine(waitForSpecialAutoFlip38());
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 18)
        {
            StartCoroutine(waitForSpecialAutoFlip39());
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 19)
        {
            StartCoroutine(waitForSpecialAutoFlip40());
        }
        if (GoldenFlipsButton.goldenCoinsUpgradeCount > 20)
        {
            StartCoroutine(waitForSpecialAutoFlip41());
        }


    }

    IEnumerator waitForAutoFlip1()
    {
        float random = Random.Range(0.1f, 1.85f);
        yield return new WaitForSeconds(random);
        AutoCoin.ascendedAuto1 = 1;
    }
    IEnumerator waitForAutoFlip2()
    {
        float random = Random.Range(1f, 1.2f);
        yield return new WaitForSeconds(random);
        AutoCoin2.ascendedAuto2 = 1;
    }
    IEnumerator waitForAutoFlip3()
    {
        float random = Random.Range(0.1f, 1.85f);
        yield return new WaitForSeconds(random);
        AutoCoin3.ascendedAuto3 = 1;
    }
    IEnumerator waitForAutoFlip4()
    {
        float random = Random.Range(0.1f, 1.85f);
        yield return new WaitForSeconds(random);
        AutoCoin4.ascendedAuto4 = 1;
    }
    IEnumerator waitForAutoFlip5()
    {
        float random = Random.Range(0.1f, 1.8f);
        yield return new WaitForSeconds(random);
        AutoCoin5.ascendedAuto5 = 1;
    }
    IEnumerator waitForAutoFlip6()
    {
        float random = Random.Range(0.1f, 1.8f);
        yield return new WaitForSeconds(random);
        AutoCoin6.ascendedAuto6 = 1;
    }
    IEnumerator waitForAutoFlip7()
    {
        float random = Random.Range(0.1f, 1.8f);
        yield return new WaitForSeconds(random);
        AutoCoin7.ascendedAuto7 = 1;
    }
    IEnumerator waitForAutoFlip8()
    {
        float random = Random.Range(0.1f, 1.8f);
        yield return new WaitForSeconds(random);
        AutoCoin8.ascendedAuto8 = 1;
    }
    IEnumerator waitForAutoFlip9()
    {
        float random = Random.Range(0.1f, 1.8f);
        yield return new WaitForSeconds(random);
        AutoCoin9.ascendedAuto9 = 1;
    }
    IEnumerator waitForAutoFlip10()
    {
        float random = Random.Range(0.1f, 1.8f);
        yield return new WaitForSeconds(random);
        AutoCoin10.ascendedAuto10 = 1;
    }
    IEnumerator waitForAutoFlip11()
    {
        float random = Random.Range(0.1f, 1.8f);
        yield return new WaitForSeconds(random);
        AutoCoin11.ascendedAuto11 = 1;
    }
    IEnumerator waitForAutoFlip12()
    {
        float random = Random.Range(0.1f, 0.2f);
        yield return new WaitForSeconds(random);
        AutoCoin12.ascendedAuto12 = 1;
    }
    IEnumerator waitForAutoFlip13()
    {
        float random = Random.Range(0.5f, 1.5f);
        yield return new WaitForSeconds(random);
        AutoCoin13.ascendedAuto13 = 1;
    }
    IEnumerator waitForAutoFlip14()
    {
        float random = Random.Range(0.1f, 1.2f);
        yield return new WaitForSeconds(random);
        AutoCoin14.ascendedAuto14 = 1;
    }
    IEnumerator waitForAutoFlip15()
    {
        float random = Random.Range(0.1f, 1.1f);
        yield return new WaitForSeconds(random);
        AutoCoin15.ascendedAuto15 = 1;
    }
    IEnumerator waitForAutoFlip16()
    {
        float random = Random.Range(0.1f, 3.2f);
        yield return new WaitForSeconds(random);
        AutoCoin16.ascendedAuto17 = 1;
    }
    IEnumerator waitForAutoFlip17()
    {
        float random = Random.Range(0.1f, 3.8f);
        yield return new WaitForSeconds(random);
        AutoCoin17.ascendedAuto16 = 1;
    }
    IEnumerator waitForAutoFlip18()
    {
        float random = Random.Range(0.1f, 3.6f);
        yield return new WaitForSeconds(random);
        AutoCoin18.ascendedAuto19 = 1;
    }
    IEnumerator waitForAutoFlip19()
    {
        float random = Random.Range(0.1f, 1.2f);
        yield return new WaitForSeconds(random);
        AutoCoin19.ascendedAuto18 = 1;
    }
    IEnumerator waitForAutoFlip20()
    {
        float random = Random.Range(0.1f, 1.4f);
        yield return new WaitForSeconds(random);
        AutoCoin20.ascendedAuto20 = 1;
    }
    IEnumerator waitForAutoFlip21()
    {
        float random = Random.Range(0.1f, 2.8f);
        yield return new WaitForSeconds(random);
        AutoCoin21.ascendedAuto21 = 1;
    }

    //Special

    IEnumerator waitForSpecialAutoFlip21()
    {
        float random = Random.Range(0.1f, 2.8f);
        yield return new WaitForSeconds(random);
        SpecialAuto1.flipAuto = 1;
    }
    IEnumerator waitForSpecialAutoFlip22()
    {
        float random = Random.Range(0.1f, 2.8f);
        yield return new WaitForSeconds(random);
        SpecialAuto2.flipAuto = 1;
    }
    IEnumerator waitForSpecialAutoFlip23()
    {
        float random = Random.Range(0.1f, 2.8f);
        yield return new WaitForSeconds(random);
        SpecialAuto3.flipAuto = 1;
    }
    IEnumerator waitForSpecialAutoFlip24()
    {
        float random = Random.Range(0.1f, 2.8f);
        yield return new WaitForSeconds(random);
        SpecialAuto4.flipAuto = 1;
    }
    IEnumerator waitForSpecialAutoFlip25()
    {
        float random = Random.Range(0.1f, 2.8f);
        yield return new WaitForSeconds(random);
        SpecialAuto5.flipAuto = 1;
    }
    IEnumerator waitForSpecialAutoFlip26()
    {
        float random = Random.Range(0.1f, 2.8f);
        yield return new WaitForSeconds(random);
        SpecialAuto6.flipAuto = 1;
    }
    IEnumerator waitForSpecialAutoFlip27()
    {
        float random = Random.Range(0.1f, 2.8f);
        yield return new WaitForSeconds(random);
        SpecialAuto7.flipAuto = 1;
    }
    IEnumerator waitForSpecialAutoFlip28()
    {
        float random = Random.Range(0.1f, 2.8f);
        yield return new WaitForSeconds(random);
        SpecialAuto8.flipAuto = 1;
    }
    IEnumerator waitForSpecialAutoFlip29()
    {
        float random = Random.Range(0.1f, 2.8f);
        yield return new WaitForSeconds(random);
        SpecialAuto9.flipAuto = 1;
    }
    IEnumerator waitForSpecialAutoFlip30()
    {
        float random = Random.Range(0.1f, 2.8f);
        yield return new WaitForSeconds(random);
        SpecialAuto10.flipAuto = 1;
    }
    IEnumerator waitForSpecialAutoFlip31()
    {
        float random = Random.Range(0.1f, 2.8f);
        yield return new WaitForSeconds(random);
        SpecialAuto11.flipAuto = 1;
    }
    IEnumerator waitForSpecialAutoFlip32()
    {
        float random = Random.Range(0.1f, 2.8f);
        yield return new WaitForSeconds(random);
        SpecialAuto12.flipAuto = 1;
    }
    IEnumerator waitForSpecialAutoFlip33()
    {
        float random = Random.Range(0.1f, 2.8f);
        yield return new WaitForSeconds(random);
        SpecialAuto13.flipAuto = 1;
    }
    IEnumerator waitForSpecialAutoFlip34()
    {
        float random = Random.Range(0.1f, 2.8f);
        yield return new WaitForSeconds(random);
        SpecialAuto14.flipAuto = 1;
    }
    IEnumerator waitForSpecialAutoFlip35()
    {
        float random = Random.Range(0.1f, 2.8f);
        yield return new WaitForSeconds(random);
        SpecialAuto15.flipAuto = 1;
    }
    IEnumerator waitForSpecialAutoFlip36()
    {
        float random = Random.Range(0.1f, 2.8f);
        yield return new WaitForSeconds(random);
        SpecialAuto16.flipAuto = 1;
    }
    IEnumerator waitForSpecialAutoFlip37()
    {
        float random = Random.Range(0.1f, 2.8f);
        yield return new WaitForSeconds(random);
        SpecialAuto17.flipAuto = 1;
    }
    IEnumerator waitForSpecialAutoFlip38()
    {
        float random = Random.Range(0.1f, 2.8f);
        yield return new WaitForSeconds(random);
        SpecialAuto18.flipAuto = 1;
    }
    IEnumerator waitForSpecialAutoFlip39()
    {
        float random = Random.Range(0.1f, 2.8f);
        yield return new WaitForSeconds(random);
        SpecialAuto19.flipAuto = 1;
    }
    IEnumerator waitForSpecialAutoFlip40()
    {
        float random = Random.Range(0.1f, 2.8f);
        yield return new WaitForSeconds(random);
        SpecialAuto20.flipAuto = 1;
    }

    IEnumerator waitForSpecialAutoFlip41()
    {
        float random = Random.Range(0.1f, 2.8f);
        yield return new WaitForSeconds(random);
        SpecialAuto21.flipAuto = 1;
    }
}
