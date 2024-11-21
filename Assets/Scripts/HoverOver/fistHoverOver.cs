using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class fistHoverOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject textBar;
    public TextMeshProUGUI text;
    public TextMeshProUGUI text2;
    public Transform transformBar;

    public static string FormatCoins(float coins)
    {
        return coins switch
        {
            >= 1E+36f => ((float)coins / 1E+36).ToString("0.##") + LocalizationStrings.undecillionc,
            >= 1E+33f => ((float)coins / 1E+33).ToString("0.##") + LocalizationStrings.decillionc,
            >= 1E+30f => ((float)coins / 1E+30).ToString("0.##") + LocalizationStrings.nonillionc,
            >= 1E+27f => ((float)coins / 1E+27).ToString("0.##") + LocalizationStrings.octillionc,
            >= 1E+24f => ((float)coins / 1E+24).ToString("0.##") + LocalizationStrings.septillionc,
            >= 1E+21f => ((float)coins / 1E+21).ToString("0.##") + LocalizationStrings.sextillionc,
            >= 1E+18f => ((float)coins / 1E+18).ToString("0.##") + LocalizationStrings.quintillionc,
            >= 1E+15f => ((float)coins / 1E+15).ToString("0.##") + LocalizationStrings.quadrillionc,
            >= 1E+12f => ((float)coins / 1000000000000.0).ToString("0.##") + LocalizationStrings.trillionc,
            >= 1E+09f => ((float)coins / 1000000000.0).ToString("0.##") + LocalizationStrings.billionc,
            >= 1000000f => ((float)coins / 1000000.0).ToString("0.##") + LocalizationStrings.millionc,
            >= 1000f => ((float)coins / 1000.0).ToString("0.##") + LocalizationStrings.thousandC,
            _ => ((float)coins / 1.0).ToString("##") + LocalizationStrings.coins
        };
    }

    void Update()
    {
        if (StrongerFist.currentCoins >= StrongerFist.fistCost)
        {
            text.color = Color.green;
            text.text = FormatCoins(StrongerFist.fistCost);

        }
        if (StrongerFist.currentCoins < StrongerFist.fistCost)
        {
            text.color = Color.red;
            text.text = FormatCoins(StrongerFist.fistCost);

        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (LoadSaves.isMobileBuild == false)
        {
            SetBar();
        }
    }

    public void SetBar()
    {
        textBar.SetActive(true);

        if (LoadSaves.isMobileBuild == true)
        {
            textBar.transform.localScale = new Vector2(SetInfoAllButtons.scale, SetInfoAllButtons.scale);
            textBar.transform.position = new Vector2(SetInfoAllButtons.xpos, SetInfoAllButtons.ypos);
        }
        else
        {
            textBar.transform.position = transformBar.position;
        }

        text2.GetComponent<TextMeshProUGUI>().text = "+" + PurchaseLog.fistPlussAmount + LocalizationStrings.plussCoins;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (LoadSaves.isMobileBuild == false)
        {
            textBar.SetActive(false);
        }
    }
}


