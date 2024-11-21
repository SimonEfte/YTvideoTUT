using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverOverScroll : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Texture2D cursor1;

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        if (LoadSaves.isMobileBuild == false) { Cursor.SetCursor(cursor1, Vector2.zero, CursorMode.Auto); }
    }
    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        if (LoadSaves.isMobileBuild == false) { Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto); }
    }
}
