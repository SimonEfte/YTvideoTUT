using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class StatsAll : MonoBehaviour
{
    public static float flippedAmount;
    public static float headsFlippedAmount;
    public static float tailsFlippedAmount;
    public static float luckyCoinsAmount;
    public static float luckyCoinsTotalAmountOfCoins;

    public TextMeshProUGUI flipAmountText;
    public TextMeshProUGUI tailsAmountText;
    public TextMeshProUGUI headsAmountText;
    public TextMeshProUGUI luckyAmountText;

    public TextMeshProUGUI strongerHandsText;
    public TextMeshProUGUI greaterCoinsText;
    public TextMeshProUGUI knowledgeText;
    public TextMeshProUGUI strongerFistText;
    public TextMeshProUGUI handInjectionText;
    public TextMeshProUGUI brainPowerText;
    public TextMeshProUGUI explosiveText;
    public TextMeshProUGUI hydrationText;
    public TextMeshProUGUI potionText;
    public TextMeshProUGUI masterFlipperText;
    public TextMeshProUGUI handShakeText;
    public TextMeshProUGUI upgrade12Text;

    public TextMeshProUGUI headChance;
    public TextMeshProUGUI tailsChance;
    public TextMeshProUGUI luckyChance;
    public TextMeshProUGUI extraLuckyCoin;

    public TextMeshProUGUI strongerHandsCount;
    public TextMeshProUGUI greaterCoinsCount;
    public TextMeshProUGUI knowledgeCount;
    public TextMeshProUGUI strongerFistCount;
    public TextMeshProUGUI handInjectionCount;
    public TextMeshProUGUI brainPowerCount;
    public TextMeshProUGUI explosiveFlipsCount;
    public TextMeshProUGUI hydrationCount;
    public TextMeshProUGUI potionCount;
    public TextMeshProUGUI masterFlipperCount;
    public TextMeshProUGUI handShakeCount;
    public TextMeshProUGUI highFiveCount;
    public TextMeshProUGUI wizardCount;
    public TextMeshProUGUI treasureCount;
    public TextMeshProUGUI ritualCount;

    public static string FormatCoins(float coins)
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

    public void Start()
    {
        StartCoroutine(SetText());   
    }

    IEnumerator SetText()
    {
        yield return new WaitForSeconds(0.1f);

        strongerHandsCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + MoreCoinsButton.moreCoinsUpgrades;
        greaterCoinsCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + MoreCoinsButton.greaterCoinsCount;
        knowledgeCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + KnowledgeUpgrade.knowledgeUpgradeCount;
        strongerFistCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + StrongerFist.fistUpgradeCount;
        handInjectionCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + HandInecjtion.injectionUpgradeCount;
        brainPowerCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + BrainPower.brainPowerUpgradeCount;
        explosiveFlipsCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + ExplosiveFlips.explosiveUpgradeCount;
        hydrationCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + HydrationButton.hydrationUpgradeCount;
        potionCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + StrangePotion.potionUpgradeCount;
        masterFlipperCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + MasterFlipper.MasterFlipsUpgradeCount;
        handShakeCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + HandShake.handShakeUpgradeCount;
        highFiveCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + Upgrade12.upgrade12Count;
        wizardCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + MagicFlipsUpgrade.magicUpgradeCount;
        treasureCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + TreasureChest.treasureCount;
        ritualCount.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.purchased + RitualUpgrade.treasureCount;

        //StrongerArms
        strongerHandsText.text = LocalizationStrings.your + MoreCoinsButton.moreCoinsUpgrades + LocalizationStrings.statsStrongerArm + FormatCoins(PurchaseLog.strongerHandsTextInfo) + LocalizationStrings.coins;

        //GreaterCoins

        if (MoreCoinsButton.greaterCoinsCount == 0)
        {
            greaterCoinsText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.buyUpgrade;

        }
        if (MoreCoinsButton.greaterCoinsCount > 0)
        {
            greaterCoinsText.text = LocalizationStrings.your + MoreCoinsButton.greaterCoinsCount + LocalizationStrings.statsGreater + FormatCoins(PurchaseLog.greaterTextInfo) + LocalizationStrings.coins;
        }

        //Knwoledge

        if (KnowledgeUpgrade.knowledgeUpgradeCount == 0)
        {
            knowledgeText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.buyUpgrade;
        }
        if (KnowledgeUpgrade.knowledgeUpgradeCount > 0)
        {

            knowledgeText.text = LocalizationStrings.your + KnowledgeUpgrade.knowledgeUpgradeCount + LocalizationStrings.statsKnowledge + FormatCoins(PurchaseLog.knowledgeInfo) + LocalizationStrings.coins;
        }

        //StrongerFirst
        if (StrongerFist.fistUpgradeCount == 0)
        {
            strongerFistText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.buyUpgrade;
        }
        if (StrongerFist.fistUpgradeCount > 0)
        {
            strongerFistText.text = LocalizationStrings.your + StrongerFist.fistUpgradeCount + LocalizationStrings.statsFist + FormatCoins(PurchaseLog.fistInfo) + LocalizationStrings.coins;
        }

        //HandInjection
        if (HandInecjtion.injectionUpgradeCount == 0)
        {
            handInjectionText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.buyUpgrade;
        }
        if (HandInecjtion.injectionUpgradeCount > 0)
        {
            handInjectionText.text = LocalizationStrings.your + HandInecjtion.injectionUpgradeCount + LocalizationStrings.statsInjection + FormatCoins(PurchaseLog.injectionInfo) + LocalizationStrings.coins;
        }

        //BrainPower
        if (BrainPower.brainPowerUpgradeCount == 0)
        {
            brainPowerText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.buyUpgrade;
        }
        if (BrainPower.brainPowerUpgradeCount > 0)
        {

            brainPowerText.text = LocalizationStrings.your + BrainPower.brainPowerUpgradeCount + LocalizationStrings.statsBrain + FormatCoins(PurchaseLog.brainPowerInfo) + LocalizationStrings.coins;
        }

        //Explosive Flips
        if (ExplosiveFlips.explosiveUpgradeCount == 0)
        {
            explosiveText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.buyUpgrade;
        }
        if (ExplosiveFlips.explosiveUpgradeCount > 0)
        {
            explosiveText.text = LocalizationStrings.your + ExplosiveFlips.explosiveUpgradeCount + LocalizationStrings.statsExplosive + FormatCoins(PurchaseLog.explosiveInfo) + LocalizationStrings.coins;
        }

        //Hydration

        if (HydrationButton.hydrationUpgradeCount == 0)
        {
            hydrationText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.buyUpgrade;
        }
        if (HydrationButton.hydrationUpgradeCount > 0)
        {
            hydrationText.text = LocalizationStrings.your + HydrationButton.hydrationUpgradeCount + LocalizationStrings.statsHydration + FormatCoins(PurchaseLog.hydrationInfo) + LocalizationStrings.coins;
        }

        //StrangePortion

        if (StrangePotion.potionUpgradeCount == 0)
        {
            potionText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.buyUpgrade;
        }
        if (StrangePotion.potionUpgradeCount > 0)
        {
            potionText.text = LocalizationStrings.your + StrangePotion.potionUpgradeCount + LocalizationStrings.statsPorion + FormatCoins(PurchaseLog.potionInfo) + LocalizationStrings.coins;
        }

        //MAsterFlipper

        if (MasterFlipper.MasterFlipsUpgradeCount == 0)
        {
            masterFlipperText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.buyUpgrade;
        }
        if (MasterFlipper.MasterFlipsUpgradeCount > 0)
        {
            masterFlipperText.text = LocalizationStrings.your + MasterFlipper.MasterFlipsUpgradeCount + LocalizationStrings.statsMaster + FormatCoins(PurchaseLog.masterFlipperInfo) + LocalizationStrings.coins;

        }

        //HandShake


        if (HandShake.handShakeUpgradeCount == 0)
        {
            handShakeText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.buyUpgrade;
        }
        if (HandShake.handShakeUpgradeCount > 0)
        {
            handShakeText.text = LocalizationStrings.your + HandShake.handShakeUpgradeCount + LocalizationStrings.statsHandshake + FormatCoins(PurchaseLog.handShakeInfo) + LocalizationStrings.coins;
        }

        //HighFive


        if (Upgrade12.upgrade12Count == 0)
        {
            upgrade12Text.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.buyUpgrade;

        }
        if (Upgrade12.upgrade12Count > 0)
        {
            upgrade12Text.text = LocalizationStrings.your + Upgrade12.upgrade12Count + LocalizationStrings.statsHighFive + FormatCoins(PurchaseLog.upgrade12Info) + LocalizationStrings.coins;
        }

        //MagicFlips

    }

    public TextMeshProUGUI activeFlipsAmountText;

    public TextMeshProUGUI extraLuckyCoinText;
    public TextMeshProUGUI gambledAmount;
    public TextMeshProUGUI gambledLost;
    public TextMeshProUGUI gambledWon;
    public TextMeshProUGUI clickedPile;
    public TextMeshProUGUI totalPile;

    public GameObject statsFrame;

    public void Update()
    {
        if(statsFrame.activeInHierarchy == true)
        {
            if (AscendScreen.hitEvenLuckerCoin == 0)
            {
                extraLuckyCoin.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.youHitExtraLucky + "0" + LocalizationStrings.times;
            }
            if (AscendScreen.hitEvenLuckerCoin > 0)
            {
                extraLuckyCoin.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.youHitExtraLucky + AscendScreen.hitEvenLuckerCoin + LocalizationStrings.times;
            }

            if (LocalizationStrings.ChooseText == 1 || LocalizationStrings.ChooseText == 2 || LocalizationStrings.ChooseText == 3)
            {
                activeFlipsAmountText.text = LocalizationStrings.youHaveActivelyFlipped + MainButtonClick.activeFlipsAmount + LocalizationStrings.coins;
                flipAmountText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.youHaveFlipped + flippedAmount + LocalizationStrings.coins;
            }

            if (LocalizationStrings.ChooseText == 5)
            {
                activeFlipsAmountText.text = $"あなたは積極的に{MainButtonClick.activeFlipsAmount}コインを反転しています";
                flipAmountText.GetComponent<TextMeshProUGUI>().text = $"あなたは{StatsAll.flippedAmount}コインを反転しています";
                extraLuckyCoinText.text = $"あなたは余分な幸運なコインを{AscendScreen.hitEvenLuckerCoin}回ヒットします";
                gambledAmount.text = $"あなたはギャンブルをしました{PurchaseLog.amountOfTimesGambled}回";
                gambledLost.text = $"あなたはすべてのあなたのコインを失っていますギャンブル{PurchaseLog.amountOfTimesGambledLOST}回";
                gambledWon.text = $"あなたはすべてのあなたのコインを倍増していますギャンブル{PurchaseLog.amountOfTimesGambledWON}回";
                clickedPile.text = $"あなたは{PileOfCoinsMechanics.incrementPileOfCoinsAmount}回のコインの山をクリックしました";
            }
            else if (LocalizationStrings.ChooseText == 4)
            {
                activeFlipsAmountText.text = $"{MainButtonClick.activeFlipsAmount}개의 코인을 적극적으로 뒤집었습니다";
                flipAmountText.GetComponent<TextMeshProUGUI>().text = $"{flippedAmount}개의 코인을 뒤집었습니다";
                extraLuckyCoinText.text = $"추가 행운의 동전을 {AscendScreen.hitEvenLuckerCoin}번 던졌습니다";
                gambledAmount.text = $"{PurchaseLog.amountOfTimesGambled}회 도박했습니다";
                gambledLost.text = $"{PurchaseLog.amountOfTimesGambledLOST}회 도박하여 모든 코인을 잃었습니다";
                gambledWon.text = $"{PurchaseLog.amountOfTimesGambledWON}회 도박하여 코인을 2배로 벌었습니다";
                clickedPile.text = $"코인 더미를 {PileOfCoinsMechanics.incrementPileOfCoinsAmount}회 클릭했습니다";
            }

            tailsAmountText.GetComponent<TextMeshProUGUI>().text = tailsFlippedAmount + LocalizationStrings.totalCoinsOnTails;
            headsAmountText.GetComponent<TextMeshProUGUI>().text = headsFlippedAmount + LocalizationStrings.totalCoinsOnHeads;
            luckyAmountText.GetComponent<TextMeshProUGUI>().text = luckyCoinsAmount + LocalizationStrings.totalLockyCoins;
        }
    }
}
