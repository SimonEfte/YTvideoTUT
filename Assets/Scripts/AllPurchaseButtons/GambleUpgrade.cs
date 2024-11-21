using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GambleUpgrade : MonoBehaviour
{
    public GameObject noMoreTriesButton;
    public GameObject gambleButton;
    public TextMeshProUGUI GambleButtonTriesText;

    public void Update()
    {
        if (PurchaseLog.gambleChances == 0)
        {
            gambleButton.SetActive(false);
            noMoreTriesButton.SetActive(true);
            GambleButtonTriesText.color = Color.red;
        }
        if(PurchaseLog.gambleChances > 0)
        {
            gambleButton.SetActive(true);
            noMoreTriesButton.SetActive(false);
            GambleButtonTriesText.color = Color.green;
        }
        GambleButtonTriesText.GetComponent<TextMeshProUGUI>().text = LocalizationStrings.gambleTriesString + PurchaseLog.gambleChances;
    }

}
