using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class GridBuildingSystem2D : MonoBehaviour
{
    [SerializeField] private Transform platTranform;

    private Grid<GridObject> grid;

    private void Awake()
    {

        int gridWidth = 10;
        int gridHeight = 10;
        float cellSize = 10f;
        grid = new Grid<GridObject>(gridWidth, gridHeight, cellSize, new Vector3(0, 0, 0), (Grid<GridObject> g, int x, int y) => new GridObject(g, x, y));

    }

    public class GridObject
    {

        private Grid<GridObject> grid;
        private int x;
        private int y;
        private Transform transform;

        public GridObject(Grid<GridObject> grid, int x, int y)
        {
            this.grid = grid;
            this.x = x;
            this.y = y;
        }
        public void SetTransform(Transform transform)
        {
            this.transform = transform;
            grid.TriggerGridObjectChanged(x, y);
        }

        public void ClearTransform()
        {
            transform = null;
            grid.TriggerGridObjectChanged(x, y);
        }

        public bool CanBuild()
        {
            return transform == null;
        }
        public override string ToString()
        {
            return x + ", " + y /*+ "\n" + transform*/;
        }

    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = UtilsClass.GetMouseWorldPosition();
            grid.GetXY(mousePosition, out int x, out int y);

            GridObject gridObject = grid.GetGridObject(x, y);
            if (gridObject.CanBuild())
            {
                Transform builtTransform = Instantiate(platTranform, grid.GetWorldPosition(x * 1, y *1), Quaternion.identity);
                gridObject.SetTransform(builtTransform);
            }
            else
            {
                UtilsClass.CreateWorldTextPopup("No Puede Poner Plataforma", mousePosition);
            }
            
        }
    }
   

}
