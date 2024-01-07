using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class plant_slot : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    public GameObject plant_drag;
    public GameObject plant_game;
    public Canvas canvas;
    private GameObject plant_drag_instance;
    public void OnDrag(PointerEventData eventData)
    {
        plant_drag_instance.transform.position = Input.mousePosition;  

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        plant_drag_instance = Instantiate(plant_drag, canvas.transform);    
        plant_drag_instance.transform.position = Input.mousePosition;  
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Destroy(plant_drag_instance);
    }
}
