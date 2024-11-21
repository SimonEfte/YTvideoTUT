using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolTip : MonoBehaviour
{
    private Text toolTipText;
    private RectTransform backroundRectTransform;

    private void Awake()
    {
        backroundRectTransform = transform.Find("background").GetComponent<RectTransform>();
        toolTipText = transform.Find("text").GetComponent<Text>();

        ShowToolTip("Random ToolTip Text");
    }

    private void ShowToolTip(string toolTipString)
    {
        gameObject.SetActive(true);
        toolTipText.text = toolTipString;
        float textPaddingSize = 4f;
        Vector2 backgroundSize = new Vector2(toolTipText.preferredWidth + textPaddingSize *2f, toolTipText.preferredHeight + textPaddingSize * 2f);
        backroundRectTransform.sizeDelta = backgroundSize;
    }
    private void HideToolTip()
    {
        gameObject.SetActive(false);
    }
}
