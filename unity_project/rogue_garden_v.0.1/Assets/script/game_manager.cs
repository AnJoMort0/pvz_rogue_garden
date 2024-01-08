using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class game_manager : MonoBehaviour
{
    public GameObject dragging_plant;
    public GameObject current_garden_field;

    public static game_manager instance;

    private void Awake()
    {
        instance = this;
    }

    public void PlacePlant(){
        if (dragging_plant != null && current_garden_field != null){
            Instantiate(dragging_plant.GetComponent<plant_drag>().slot.plant_game, current_garden_field.transform);
            current_garden_field.GetComponent<garden_field>().isFull = true;
        }
    }
}
