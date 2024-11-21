using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FasterAnimations : MonoBehaviour
{
    public GameObject speedUpAnim;
    public GameObject fakeSpeedUpAnim;
    public TextMeshProUGUI realText;
    public TextMeshProUGUI fakeText;
    public TextMeshProUGUI fasterFlipsCost;
    public TextMeshProUGUI fakeFasterFlipsCost;

    public static float fasterAnimbuttonValue = 100;
    public float currentCoins;
    public static bool turnOffButton = false;

    private void Update()
    {
        currentCoins = GlobalCoins.CoinCount;
        realText.GetComponent<TextMeshProUGUI>().text = "Faster Coin Flips";
        fakeText.GetComponent<TextMeshProUGUI>().text = "Faster Coin Flips";

        fasterFlipsCost.color = Color.green;
        fasterFlipsCost.GetComponent<TextMeshProUGUI>().text = "" + fasterAnimbuttonValue + "";
        fakeFasterFlipsCost.color = Color.red;
        fakeFasterFlipsCost.GetComponent<TextMeshProUGUI>().text = "" + fasterAnimbuttonValue + "";

        if (currentCoins >= fasterAnimbuttonValue)
        {
            speedUpAnim.SetActive(true);
            fakeSpeedUpAnim.SetActive(false);
        }
        if(currentCoins < fasterAnimbuttonValue)
        {
            speedUpAnim.SetActive(false);
            fakeSpeedUpAnim.SetActive(true);
        }
        if(turnOffButton == true)
        {
            speedUpAnim.SetActive(true);
            fakeSpeedUpAnim.SetActive(false);
            turnOffButton = false;
        }



    }

}
