
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler  {

    public void OnDrop(PointerEventData eventData) {
        Debug.Log("se dropeo en el frame");
        if (eventData.pointerDrag != null ) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }


    

}
