using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class hydrationHoverOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject textBar;
    public TextMeshProUGUI textPrice;
    public TextMeshProUGUI textPlussAmount;
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
        if (HydrationButton.currentCoins >= HydrationButton.hydrationVost)
        {
            textPrice.color = Color.green;
            textPrice.text = FormatCoins(HydrationButton.hydrationVost);

         

        }
        if (HydrationButton.currentCoins < HydrationButton.hydrationVost)
        {
            textPrice.color = Color.red;

            textPrice.text = FormatCoins(HydrationButton.hydrationVost);

        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (LoadSaves.isMobileBuild == false)
        {
            SetFrame();
        }
    }

    public void SetFrame()
    {
        textBar.SetActive(true);

        if (PurchaseLog.hydrationFlipsPlussAmount >= 1000000000)
        {
            textPlussAmount.GetComponent<TextMeshProUGUI>().text = "+" + (PurchaseLog.hydrationFlipsPlussAmount / 1000000000D).ToString("0.##") + LocalizationStrings.plussBillionCoins;
        }
        else if (PurchaseLog.hydrationFlipsPlussAmount >= 1000000)
        {
            textPlussAmount.GetComponent<TextMeshProUGUI>().text = "+" + (PurchaseLog.hydrationFlipsPlussAmount / 1000000D).ToString("0.##") + LocalizationStrings.plussMillionCoins;
        }

        if (LoadSaves.isMobileBuild == true)
        {
            textBar.transform.localScale = new Vector2(SetInfoAllButtons.scale, SetInfoAllButtons.scale);
            textBar.transform.position = new Vector2(SetInfoAllButtons.xpos, SetInfoAllButtons.ypos - 2.07f);
        }
        else
        {
            textBar.transform.position = transformBar.position;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (LoadSaves.isMobileBuild == false)
        {
            textBar.SetActive(false);
        }
    }
}
