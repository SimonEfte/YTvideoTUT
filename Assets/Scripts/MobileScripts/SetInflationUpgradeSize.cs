using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInflationUpgradeSize : MonoBehaviour
{
    public void Start()
    {
        if (LoadSaves.isMobileBuild == true)
        {
            Transform childTransform = transform.Find("inFrame");

            if (childTransform != null)
            {
                GameObject childGameObject = childTransform.gameObject;
                childGameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(342.32f, 206.59f);
            }
        }
    }

    private void OnEnable()
    {
        if(LoadSaves.isMobileBuild == true)
        {
            gameObject.transform.localPosition = new Vector2(0, -22);
            gameObject.transform.localScale = new Vector2(4.2f, 4.2f);
            gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(316.05f, 183f);
        }
        else
        {
            gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(316.05f, 155f);
            //gameObject.transform.localScale = new Vector2(1.410537f, 1.410537f);
        }
    }


}
