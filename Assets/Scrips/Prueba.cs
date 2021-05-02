using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Prueba : MonoBehaviour
{
    [SerializeField] private TilemapVisualDos tilemapVisual;
    private Tilemap tilemap;

    //private Tilemap.TilemapObject.TilemapSprite tilemapSprite;

    void Start()
    {
        tilemap = new Tilemap(20, 10, 5f, Vector3.zero);

        tilemap.SetTilemapVisual(tilemapVisual);

    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouseWorldPosition = UtilsClass.GetMouseWorldPosition();
            tilemap.SetTilemapSprite(mouseWorldPosition, Tilemap.TilemapObject.TilemapSprite.Platform);
        }
    }

  
}
