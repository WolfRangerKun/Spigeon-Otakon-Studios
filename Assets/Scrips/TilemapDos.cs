using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Tilemap 
{
    //private GridDos<TilemapObject> grid;

    //public Tilemap(int width, int heigt, float cellSize, Vector3 originPosition)
    //{
    //    grid = new GridDos<TilemapObject>(width, heigt, cellSize, originPosition, (GridDos<TilemapObject> g, int x, int y) => new TilemapObject(g, x, y));
    //}

    //public void SetTilemapSprite(Vector3 worldPosition, TilemapObject.TilemapSprite tilemapSprite)
    //{
    //    TilemapObject tilemapObject =  grid.GetGridObject(worldPosition);
    //    if(tilemapObject != null)
    //    {
    //        tilemapObject.SetTilemapSprite(tilemapSprite);
    //    }
    //}

    //public void SetTilemapVisual(TilemapVisualDos tilemapVisual)
    //{
    //    tilemapVisual.SetGrid(grid);
    //}


    //public class TilemapObject
    //{
    //    public enum TilemapSprite
    //    {
    //        None,
    //        Platform
    //    }
        

    //    public GridDos<TilemapObject> grid;
    //    int x;
    //    int y;
    //    private TilemapSprite tilemapSprite;

    //    public TilemapObject(GridDos<TilemapObject> grid, int x, int y)
    //    {
    //        this.grid =grid;
    //        this.x = x;
    //        this.y = y;
    //    }

    //    public void SetTilemapSprite(TilemapSprite tilemapSprite)
    //    {
    //        this.tilemapSprite = tilemapSprite;
    //        grid.TriggerGridObjectChanged(x, y);
    //    }

    //    public TilemapSprite GetTilemapSprite()
    //    {
    //        return tilemapSprite;
    //    }
    //    public override string ToString()
    //    {
    //        return tilemapSprite.ToString();
    //    }
    //}
}
