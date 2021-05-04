using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class GridBuildingSystem2D : MonoBehaviour
{
    //Pausa
    private GameManager gameManager;
    //Pausa


    [SerializeField] private Transform platTranform;


    private Grid<GridObject> grid;

    private void Awake()
    {

        int gridWidth = 40;
        int gridHeight = 40;
        float cellSize = 5f;
        grid = new Grid<GridObject>(gridWidth, gridHeight, cellSize, new Vector3(0, 0, 0), (Grid<GridObject> g, int x, int y) => new GridObject(g, x, y));

    }
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        SetVacio();
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

    public GameObject playerSpawner;


    public void SetPlatformInSpace()
    {
        if (gameManager.IsGameRunning())
        {
            Vector3 mousePosition = PlayerPositionWorld();

            grid.GetXY(mousePosition, out int x, out int y);

            GridObject gridObject = grid.GetGridObject(x, y);
            if (gridObject.CanBuild())
            {
                Transform builtTransform = Instantiate(platTranform, grid.GetWorldPosition(x * 1, y * 1), Quaternion.identity);
                gridObject.SetTransform(builtTransform);
            }
            else
            {
                UtilsClass.CreateWorldTextPopup("No Puede Aweonao", mousePosition);
            }
        }
        
    }

    public Vector3 PlayerPositionWorld()
    {
        Vector3 vec = playerSpawner.transform.position;
        return vec;
    }
    //////////////
    public GameObject vacioSpawner;
    [SerializeField] public Transform espacioEmpty;
    public void SetVacio()
    {
        Debug.Log('f');
        Vector3 position = PositionWorld();

        grid.GetXY(position, out int x, out int y);

        GridObject gridObject = grid.GetGridObject(x, y);
        if (gridObject.CanBuild())
        {
            Transform builtTransform = Instantiate(espacioEmpty, grid.GetWorldPosition(x * 1, y * 1), Quaternion.identity);
            gridObject.SetTransform(builtTransform);

        }
    }

    public Vector3 PositionWorld()
    {
        Vector3 vec = vacioSpawner.transform.position;
        return vec;
    }
}
