using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;




public class upgradesHoverBugFix : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject upgrade1;
    public GameObject upgrade2;

    public void OnPointerEnter(PointerEventData eventData)
    {
        upgrade1.SetActive(false);
        upgrade2.SetActive(false);

    }

    public void OnPointerExit(PointerEventData eventData)
    {

    }

}
