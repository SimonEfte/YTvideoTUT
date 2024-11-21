using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class hiddenCoins : MonoBehaviour
{
    public GameObject YOUFOUNDBronze;
    public GameObject YOUFOUNDSilver;

    public GameObject hiddenSilver;
    public GameObject hiddenBronze;

    public static int foundBronce = 0;
    public static int foundSilver = 0;
    public static int update1point2;


    public TextMeshProUGUI endlessPrice;
    public TextMeshProUGUI fakeEndlessPrice;
    public TextMeshProUGUI endlesHoverPrice;

    public GameObject setUpdateStats;

    public void Start()
    {
        update1point2 = PlayerPrefs.GetInt("SavedUpdate1.2");
        foundBronce = PlayerPrefs.GetInt("FoundBronce");
        foundSilver = PlayerPrefs.GetInt("FoundSilver");

    }

    public void Update()
    {
        if(LoadSaves.isMobileBuild == false)
        {
            if (update1point2 == 0)
            {
                setUpdateStats.SetActive(true);
            }
            if (update1point2 == 1)
            {
                setUpdateStats.SetActive(false);
            }
        }
    }

    public TextMeshProUGUI percentBonusText;

    public void ClickOkOnUpdate()
    {
        EndlessInflation.inflationUpgadeCount = 0;
        EndlessInflation.endlessInflationPrice = 1;
        EndlessInflation.endlessInflationBonus = 0;
        EndlessInflation.englessInflationBonusText = 0;
        EndlessInflation.endlessInflationCostEqualsBonus = 0;
        endlessPrice.text = "" + EndlessInflation.endlessInflationPrice;
        fakeEndlessPrice.text = "" + EndlessInflation.endlessInflationPrice;
        percentBonusText.text = "+" + EndlessInflation.endlessInflationPrice + "% More Coins!";
        endlesHoverPrice.text = EndlessInflation.endlessInflationPrice + " Inflation Coins";
        TreasureChest.treasureCost = 950000000000000000000000f * (1 - AscendScreen.cheaperPrice);
        RitualUpgrade.ritualCost = 375000000000000000000000000f * (1 - AscendScreen.cheaperPrice);
        TreasureChest.treasureCount = 0;
        RitualUpgrade.treasureCount = 0;
        setUpdateStats.SetActive(false);
        StartCoroutine(lol());
    }

    IEnumerator lol()
    {
        update1point2 = 1;
        yield return new WaitForSeconds(0.1f);
        PlayerPrefs.SetInt("SavedUpdate1.2", update1point2);

    }

    public void ClickOnBronce()
    {
        YOUFOUNDBronze.SetActive(true);
        foundBronce = 1;
        hiddenBronze.SetActive(false);
        PlayerPrefs.SetInt("FoundBronce", foundBronce);
        StartCoroutine(RemovePoUpBronce());
    }


    public void ClickOnSilver()
    {
        YOUFOUNDSilver.SetActive(true);
        foundSilver = 1;
        PlayerPrefs.SetInt("FoundSilver", foundSilver);
        hiddenSilver.SetActive(false);
        StartCoroutine(RemovePoUpSilver());
    }

    IEnumerator RemovePoUpBronce()
    {
        yield return new WaitForSeconds(3);
        YOUFOUNDBronze.SetActive(false);
    }

    IEnumerator RemovePoUpSilver()
    {
        yield return new WaitForSeconds(3);
        YOUFOUNDSilver.SetActive(false);
    }

    public void coinsGet()
    {
        //GlobalCoins.CoinCount += 534534535455454543454454434f;
    }

    public void coinsGet2()
    {
        //GlobalCoins.CoinCount += 1000;
    }

}
