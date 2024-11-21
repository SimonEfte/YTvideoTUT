using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class setHoversBack : MonoBehaviour, IPointerEnterHandler
{
    public GameObject arm1;
    public GameObject arm2;
    public GameObject arm3;
    public GameObject arm4;
    public GameObject arm5;
    public GameObject arm6;
    public GameObject arm7;
    public GameObject arm8;
    public GameObject arm9;
    public GameObject arm10;
    public GameObject arm11;
    public GameObject arm12;
    public GameObject arm13;
    public GameObject arm14;
    public GameObject arm15;
    public GameObject arm16;
    public GameObject arm17;
    public GameObject arm18;
    public GameObject arm19;
    public GameObject arm20;
    public GameObject arm21;
    public GameObject arm22;
    public GameObject arm23;
    public GameObject arm24;
    public GameObject arm25;
    public GameObject arm26;
    public GameObject arm27;
    public GameObject arm28;
    public GameObject arm29;
    public GameObject arm30;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (LoadSaves.isMobileBuild == false)
        {
            arm1.SetActive(true);
            arm2.SetActive(true);
            arm3.SetActive(true);
            arm4.SetActive(true);
            arm5.SetActive(true);
            arm6.SetActive(true);
            arm7.SetActive(true);
            arm8.SetActive(true);
            arm9.SetActive(true);
            arm10.SetActive(true);
            arm11.SetActive(true);
            arm12.SetActive(true);
            arm13.SetActive(true);
            arm14.SetActive(true);
            arm15.SetActive(true);
            arm16.SetActive(true);
            arm17.SetActive(true);
            arm18.SetActive(true);
            arm19.SetActive(true);
            arm20.SetActive(true);
            arm21.SetActive(true);
            arm22.SetActive(true);
            arm23.SetActive(true);
            arm24.SetActive(true);
            arm25.SetActive(true);
            arm26.SetActive(true);
            arm27.SetActive(true);
            arm28.SetActive(true);
            arm29.SetActive(true);
            arm30.SetActive(true);
        }
    }
}
