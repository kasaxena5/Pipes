using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
[RequireComponent(typeof(CanvasGroup))]
public class Pipe : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private Canvas canvas;
    private CanvasGroup canvasGroup;
    private RectTransform rectTransform;
    
    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
    }

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(Slot.size, Slot.size);
        canvasGroup = GetComponent<CanvasGroup>();
        canvas = FindObjectOfType<Canvas>();
        transform.SetParent(canvas.transform, false);
    }
}
