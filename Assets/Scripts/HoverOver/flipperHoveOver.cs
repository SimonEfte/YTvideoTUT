using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class flipperHoveOver : MonoBehaviour, IPointerEnterHandler
{
    public GameObject muteFlipper;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(LoadSaves.isMobileBuild == false) { muteFlipper.SetActive(true); }
    }
}
