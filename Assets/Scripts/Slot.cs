using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Image))]
public class Slot : MonoBehaviour, IDropHandler
{
    private Transform canvasTransform;
    private RectTransform rectTransform;

    public static int size = 32;
    
    public void Awake()
    {
        canvasTransform = FindObjectOfType<Canvas>().transform;
        transform.SetParent(canvasTransform, false);
        rectTransform = GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(size, size);
    }

    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null)
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = rectTransform.anchoredPosition;
    }
}
