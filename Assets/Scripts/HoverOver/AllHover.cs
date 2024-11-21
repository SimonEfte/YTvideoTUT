using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class AllHover : MonoBehaviour, IPointerEnterHandler
{

    public GameObject strongerHover;
    public GameObject greaterHover;
    public GameObject knowledgeHover;
    public GameObject firstHover;
    public GameObject strongerHover2;
    public GameObject greaterHover2;
    public GameObject knowledgeHover2;
    public GameObject firstHover2;


    public void OnPointerEnter(PointerEventData eventData)
    {
        strongerHover.SetActive(false);
        greaterHover.SetActive(false);
        knowledgeHover.SetActive(false);
        firstHover.SetActive(false);
        strongerHover2.SetActive(false);
        greaterHover2.SetActive(false);
        knowledgeHover2.SetActive(false);
        firstHover2.SetActive(false);
    }


}
