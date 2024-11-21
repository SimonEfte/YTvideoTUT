using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSaves : MonoBehaviour
{
    public static bool isMobileBuild;

    public void Awake()
    {
        isMobileBuild = true;
    }

    private void Start()
    {
        //55 Saves
        GlobalCoins.CoinCount = PlayerPrefs.GetFloat("SaveGlobalCoins");
        EnterText.choseTails = PlayerPrefs.GetInt("SavedChoseTails");
        EnterText.choseHeads = PlayerPrefs.GetInt("SavedChoseHeads");
        MoreCoinsButton.moreCoinsUpgrades = PlayerPrefs.GetInt("StrongerArmsCount");
        MainButtonClick.coinsPerClick = PlayerPrefs.GetFloat("SavedCoinsPerFlipAmount");
        MoreCoinsButton.moreCoinClickValue = PlayerPrefs.GetFloat("StrongerArmsCost");
        MoreCoinsButton.greaterCoinsCount = PlayerPrefs.GetInt("GreaterCoinsCount");
        MoreCoinsButton.greaterCoinsCost = PlayerPrefs.GetFloat("GreaterCoinsCost");
        KnowledgeUpgrade.knowledgeUpgradeCount = PlayerPrefs.GetInt("KnowledgeCount");
        KnowledgeUpgrade.knowledgeClickValue = PlayerPrefs.GetFloat("KnowledgeCost");
        StrongerFist.fistUpgradeCount = PlayerPrefs.GetInt("StrongerFistCount");
        StrongerFist.fistCost = PlayerPrefs.GetFloat("StrongerFistCost");

        HandInecjtion.injectionUpgradeCount = PlayerPrefs.GetInt("HandInjectionCount");
        HandInecjtion.injectionCost = PlayerPrefs.GetFloat("HandInjectionCost");
        BrainPower.brainPowerUpgradeCount = PlayerPrefs.GetInt("BrainPowerCount");
        BrainPower.brainPowerCost = PlayerPrefs.GetFloat("BrainPowerCost");
        ExplosiveFlips.explosiveUpgradeCount = PlayerPrefs.GetInt("ExplosiveCount");
        ExplosiveFlips.explosiveCost = PlayerPrefs.GetFloat("ExplosiveCost");
        HydrationButton.hydrationUpgradeCount = PlayerPrefs.GetInt("HydrationCount");
        HydrationButton.hydrationVost = PlayerPrefs.GetFloat("HydrationCost");
        StrangePotion.potionUpgradeCount = PlayerPrefs.GetInt("PotionCount");
        StrangePotion.potionCost = PlayerPrefs.GetFloat("PotionCost");
        MasterFlipper.MasterFlipsUpgradeCount = PlayerPrefs.GetInt("MasterFlipperCount");
        MasterFlipper.MasterFlipsCost = PlayerPrefs.GetFloat("MasterFlipperCost");
        HandShake.handShakeUpgradeCount = PlayerPrefs.GetInt("HandShakeCount");
        HandShake.handshakeCost = PlayerPrefs.GetFloat("HandShakeCost");
        GlobalCoinMaker.coinsPerFlipUpgrades = PlayerPrefs.GetInt("SavedNumberOfAutoFlips");
        GlobalCoinMaker.coinValue = PlayerPrefs.GetFloat("AutoCost");
        PurchaseLog.higherChanceUpgradeCount = PlayerPrefs.GetInt("HigherChanceCount");
        HigherChance.higherChanceValue = PlayerPrefs.GetFloat("HigherChanceCost");
        PurchaseLog.luckyCoinHigherChanceCount = PlayerPrefs.GetInt("LuckyCoinCount");
        LuckyCoinChance.luckyCoinValue = PlayerPrefs.GetFloat("LuckyCoinCost");
        GoldenFlipsButton.goldenCoinsUpgradeCount = PlayerPrefs.GetInt("GoldenFlipsCount");
        GOLDENFLIPS.specialCoinsButtonCost = PlayerPrefs.GetFloat("GoldenFlipsCost");
        Upgrade12.upgrade12Count = PlayerPrefs.GetInt("Upgrade12Count");
        Upgrade12.upgrade12Cost = PlayerPrefs.GetFloat("Upgrade12Cost");
        PurchaseLog.upgrade12Info = PlayerPrefs.GetFloat("SavedUpgrade12");
        MagicFlipsUpgrade.magicUpgradeCount = PlayerPrefs.GetInt("MagicCount");
        MagicFlipsUpgrade.magicUpgradeCost = PlayerPrefs.GetFloat("MagicCost");

        DuplicateCoin.duplicatePrice = PlayerPrefs.GetFloat("SavedDuplicateCost");
        MuteAudio.muteAudio = PlayerPrefs.GetInt("MutedAudio");
        higherChanceHoverover.tailsPercent = PlayerPrefs.GetFloat("SavetailsPercent");
        higherChanceHoverover.headsPercent = PlayerPrefs.GetFloat("SaveHeadsPercent");
        MainButtonClick.higherCoinChance = PlayerPrefs.GetInt("SavehigherCoinsChance");
        MainButtonClick.lowerCoinChance = PlayerPrefs.GetInt("SavelowerCoinsChance");
        MainButtonClick.lowSpecialChance = PlayerPrefs.GetInt("SaveLuckyChance");
        GetLuckyHoverOver.luckyChance = PlayerPrefs.GetFloat("SaveLuckyPercent");

        StatsAll.flippedAmount = PlayerPrefs.GetFloat("SavedNumberOfflips");
        StatsAll.headsFlippedAmount = PlayerPrefs.GetFloat("SavedHeadsFlips");
        StatsAll.tailsFlippedAmount = PlayerPrefs.GetFloat("SavedTailsFlips");
        StatsAll.luckyCoinsAmount = PlayerPrefs.GetFloat("SavedLuckyFlips");
        PurchaseLog.strongerHandsTextInfo = PlayerPrefs.GetFloat("SavedStrongerHandInfo");
        PurchaseLog.greaterTextInfo = PlayerPrefs.GetFloat("SavedGreaterCoinInfo");
        PurchaseLog.knowledgeInfo = PlayerPrefs.GetFloat("SavedKnowledgefo");
        PurchaseLog.fistInfo = PlayerPrefs.GetFloat("SavedFistInfo");
        PurchaseLog.injectionInfo = PlayerPrefs.GetFloat("SavedInjectionInfo");
        PurchaseLog.brainPowerInfo = PlayerPrefs.GetFloat("SavedBrainPowerInfo");
        PurchaseLog.explosiveInfo = PlayerPrefs.GetFloat("SavedExplosionInfo");
        PurchaseLog.hydrationInfo = PlayerPrefs.GetFloat("SavedHydration");
        PurchaseLog.potionInfo = PlayerPrefs.GetFloat("SavedPotionInfo");
        PurchaseLog.masterFlipperInfo = PlayerPrefs.GetFloat("SavedMasterFlipperInfo");
        PurchaseLog.handShakeInfo = PlayerPrefs.GetFloat("SavedHandShake");
        PurchaseLog.magicFlipsInfo = PlayerPrefs.GetFloat("SavedMagicFlips");

        AscendScreen.boughtPileBag = PlayerPrefs.GetInt("BoughtPileBag");
        AscendScreen.boughtRich1250 = PlayerPrefs.GetInt("BoughtRich1250");
        AscendScreen.boughtAuto = PlayerPrefs.GetInt("BoughtAuto");
    }
}
