using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HoverOverTabs : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject textBar;
    public Transform transformBar;

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

        if (LoadSaves.isMobileBuild == true)
        {
            textBar.transform.localScale = new Vector2(SetInfoAllButtons.scale, SetInfoAllButtons.scale);
            textBar.transform.position = new Vector2(SetInfoAllButtons.xpos, SetInfoAllButtons.ypos);
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
            if (textBar.activeInHierarchy == false)
            {
                textBar.SetActive(false);
            }
        }
    }
}
