using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Parvietosana : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler {
    private RectTransform transKomponente;
    public Canvas kanva;

    void Start() {
        transKomponente = GetComponent<RectTransform>();
    }
    void Update() { 

    }
    public void OnPointerDown(PointerEventData notikums){
        Debug.Log("Izdarits klikskis uz objekta");
    }
    public void OnBeginDrag(PointerEventData notikums) {
        Debug.Log("Uzsakta objekta vilksana");
    }
    public void OnDrag(PointerEventData notikums) {
        Debug.Log("Notiek objekta parvietosana");
        transKomponente.anchoredPosition += notikums.delta / kanva.scaleFactor;
    }
    public void OnEndDrag(PointerEventData notikums) { 
         Debug.Log("Pabeigta objekta vilksana");
    }
}
