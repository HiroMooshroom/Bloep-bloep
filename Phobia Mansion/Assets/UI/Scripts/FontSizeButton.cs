using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class FontSizeButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TMP_Text buttonText;

    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonText.fontSize = 120f;

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonText.fontSize = 110f;
    }
}
