using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchTooltipOpen : MonoBehaviour
{
    public GameObject[] achTooltips;
    public int achNumberOpen;
    public GameObject blackBlock;
    public GameObject closeAchButton;

    public void ResetAchTooltip()
    {
        for (int i = 0; i < achTooltips.Length; i++)
        {
            achTooltips[i].SetActive(false);
        }
    }

    public void OpenAchToolTip(int achNumber)
    {
        if(LoadSaves.isMobileBuild == true)
        {
            closeAchButton.SetActive(true);
            blackBlock.SetActive(true);
            achNumberOpen = achNumber;
            achTooltips[achNumber].SetActive(true);
            achTooltips[achNumber].transform.localScale = new Vector2(13.7f, 13.7f);
            achTooltips[achNumber].transform.localPosition = new Vector2(0, -123);
        }
    }

    public void CloseAchTooltip()
    {
        closeAchButton.SetActive(false);
        blackBlock.SetActive(false);
        achTooltips[achNumberOpen].SetActive(false);
    }
}
