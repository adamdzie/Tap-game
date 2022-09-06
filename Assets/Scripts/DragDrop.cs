using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler,IDragHandler, IDropHandler, IPointerUpHandler, IPointerEnterHandler
{
    private Canvas canvas;
    private Canvas canvas2;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    InventorySlot slot;
    Image active;
    Vector2 position;
    Inventory inventory;
    Tooltip tool;
    public delegate void OnPointDown(PointerEventData eventData);
    public OnPointDown onPointDownCallback;
    PointerEventData eventData;
    private void Awake()
    {
        canvas = GameObject.FindGameObjectWithTag("Canvasinio").GetComponent<Canvas>();
        canvas2 = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Canvas>();
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        position = rectTransform.anchoredPosition;
        slot = GetComponentInParent<Transform>().GetComponentInParent<Transform>().GetComponentInParent<InventorySlot>();
        tool = GameObject.FindGameObjectWithTag("Tooltip").GetComponent<Tooltip>();
    }
    void Start()
    {
        inventory = Inventory.instance;
        //onPointDownCallback += after;
    }
    void Update()
    {
        //if(flag)
      //  {
      //      onPointDownCallback.Invoke(eventData);
       // }
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        canvasGroup.blocksRaycasts = false;
        slot.OffIcon();
        tool.OffTooltip();
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        
        Debug.Log(canvas.name);
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor /  new Vector2(0.9f,0.9f);
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        canvasGroup.blocksRaycasts = true;
        rectTransform.anchoredPosition = position;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");

        slot.OnActiveSlot();
        tool.OnActive(eventData.pointerEnter.GetComponentInParent<Transform>().GetComponentInParent<InventorySlot>());

    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if(slot.index < 42)
        {
            Reverse(eventData);
        }
        else if(eventData.pointerPress.GetComponentInParent<Transform>().GetComponentInParent<InventorySlot>().GetItem().itemType == slot.slotType)
        {
               Reverse(eventData);
        }
        
    }
    void Reverse(PointerEventData eventData)
    {
        Item it = eventData.pointerPress.GetComponentInParent<Transform>().GetComponentInParent<InventorySlot>().GetItem();
        inventory.Insert(eventData.pointerPress.GetComponentInParent<Transform>().GetComponentInParent<InventorySlot>().index, slot.GetItem());
        inventory.Insert(slot.index, it);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("OnPointerUp");
        slot.OffIcon();
        
        tool.OffTooltip();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("onPointerEnter");
        
    }
}
