using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KnowledgeUpgrade : MonoBehaviour
{
    public GameObject realKnowledge;
    public GameObject fakeKnowledge;
    public TextMeshProUGUI knowledgeCostText;
    public TextMeshProUGUI fakeKnowledgeHandsCostText;
    public static float currentCoins;
    public static float knowledgeClickValue = 850;
    public static bool turnOffKnowledgeButton = false;
    public static int knowledgeUpgradeCount;
    public GameObject coverOver;
    public GameObject buttonIcon;
    public TextMeshProUGUI buttonName;

    //public TextMeshProUGUI knowledgeStats;

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
            _ => ((float)coins / 1.0).ToString("##") ?? ""
        };
    }

    void Update()
    {
        if (MoreCoinsButton.greaterCoinsCount == 0)
        {
            buttonIcon.SetActive(false);
            coverOver.SetActive(true);
            fakeKnowledge.SetActive(true);
            realKnowledge.SetActive(false);
            fakeKnowledgeHandsCostText.color = Color.white;
            fakeKnowledgeHandsCostText.GetComponent<TextMeshProUGUI>().text = "???";
            buttonName.color = Color.white;
            buttonName.GetComponent<TextMeshProUGUI>().text = "????? ?????";
        }
        if (MoreCoinsButton.greaterCoinsCount > 0)
        {
            buttonName.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.knowledgeName;
            currentCoins = GlobalCoins.CoinCount;
            buttonIcon.SetActive(true);
            coverOver.SetActive(false);
            knowledgeCostText.color = Color.green;
            fakeKnowledgeHandsCostText.color = Color.red;

            knowledgeCostText.text = FormatCoins(knowledgeClickValue);
            fakeKnowledgeHandsCostText.text = FormatCoins(knowledgeClickValue);
         
            

            if (currentCoins >= knowledgeClickValue)
            {
                realKnowledge.SetActive(true);
                fakeKnowledge.SetActive(false);
            }
            if (currentCoins < knowledgeClickValue)
            {
                realKnowledge.SetActive(false);
                fakeKnowledge.SetActive(true);
            }
            if (turnOffKnowledgeButton == true)
            {
                realKnowledge.SetActive(true);
                fakeKnowledge.SetActive(false);
                turnOffKnowledgeButton = false;
            }
        }
        
    }
}
