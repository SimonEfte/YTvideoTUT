using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangrUpgradeLength : MonoBehaviour
{
    public float xpos, ypos;
    public float rectWith, rectHeight;

    public void Start()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (gameObject.tag == "CoverUp")
            {
                if (gameObject.name != "CoverUp1")
                {
                    gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(354, 80f);
                    gameObject.transform.localPosition = new Vector2(-52.5f, 0);
                }
                else
                {
                    gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(354, 80f);
                    gameObject.transform.localPosition = new Vector2(-101f, 50f);
                }
            }
            else if (gameObject.tag == "Special")
            {
                xpos = -41f;
                gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(rectWith, rectHeight);
                if (gameObject.name == "LuckyCoinButton" || gameObject.name == "FakeLuckyCoinButton")
                {
                    gameObject.transform.localPosition = new Vector2(-41f, -10.7f);
                }
                if (gameObject.name == "SpecialCoinsUpgrade" || gameObject.name == "FakeSpecialCoinsUpgrade")
                {
                    gameObject.transform.localPosition = new Vector2(-30.9f, -5.6f);
                    xpos = -30.9f;
                }
                else if (gameObject.name == "FlipAllButton")
                {
                    gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(124, 30f);
                    xpos = -14.6f;
                    ypos = -4.3f;
                }
                else
                {
                    gameObject.transform.localPosition = new Vector2(-41f, 0f);
                }

                gameObject.transform.localPosition = new Vector2(xpos, ypos);
            }
            else
            {
                gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(410, 94.79f);

                if (gameObject.name != "GreaterCoins" && gameObject.name != "fakeGreaterCoins")
                {
                    gameObject.transform.localPosition = new Vector2(-50f, 0f);
                }
                else
                {
                    gameObject.transform.localPosition = new Vector2(-98.7f, 50.66f);
                }
            }
        }

        //346
    }
}

