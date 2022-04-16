
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler {

    [SerializeField] private Canvas canvas;

    private RectTransform rectTransform;
   
    private CanvasGroup canvasGroup1;
    public GameObject parent;


    private void Awake() {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup1 = GetComponent<CanvasGroup>();
    }

    public void Start()
    {
        parent = transform.parent.gameObject;
        canvas = parent.GetComponent<Canvas>();
    }


    public void OnBeginDrag(PointerEventData eventData) {
        Debug.Log("OnBeginDrag");
        canvasGroup1.alpha = .6f;
        canvasGroup1.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData) {
        //Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData) {
        Debug.Log("OnEndDrag");
        canvasGroup1.alpha = 1f;
        canvasGroup1.blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData) {
        Debug.Log("OnPointerDown");
    }

}
