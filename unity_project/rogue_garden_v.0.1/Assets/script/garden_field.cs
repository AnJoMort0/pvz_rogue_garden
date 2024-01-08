using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class garden_field : MonoBehaviour
{
    public bool isFull;
    public game_manager game_manager;
    public Image background_image;

    private void Start(){
        game_manager = game_manager.instance;
    }
    public void OnTriggerEnter2D(Collider2D other) {
        if (game_manager.dragging_plant != null && isFull == false){
            game_manager.current_garden_field = this.gameObject;
            background_image.enabled = true; //adds an image to hover over cell
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        game_manager.current_garden_field = null;
        background_image.enabled = false; //removes an image to hover over cell
    }
}
