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
    private game_manager game_manager;

    private void Start(){
        game_manager = game_manager.instance;

    }
    public void OnDrag(PointerEventData eventData)
    {
        plant_drag_instance.transform.position = Input.mousePosition;  

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        plant_drag_instance = Instantiate(plant_drag, canvas.transform);    //ghost overlay
        plant_drag_instance.transform.position = Input.mousePosition;   //position the ghost overlay
        plant_drag_instance.GetComponent<plant_drag>().slot = this; //assign this into the dragged plant

        game_manager.dragging_plant = plant_drag_instance;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        game_manager.PlacePlant(); //adds the plant in the correct position
        
        game_manager.dragging_plant = null;

        Destroy(plant_drag_instance); //destroy ghost overlay and plant reference

    }
}
