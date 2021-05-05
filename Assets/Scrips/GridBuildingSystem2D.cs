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

    public int limitPlatforms = 4;

    private void Awake()
    {

        int gridWidth = 40;
        int gridHeight = 60;
        float cellSize = 5f;
        grid = new Grid<GridObject>(gridWidth, gridHeight, cellSize, new Vector3(0, 0, 0), (Grid<GridObject> g, int x, int y) => new GridObject(g, x, y));
        vaciosSpawners = GameObject.FindGameObjectsWithTag("EspacioEscenario");

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
            if(limitPlatforms > 0)
            {
                Vector3 mousePosition = PlayerPositionWorld();

                grid.GetXY(mousePosition, out int x, out int y);

                GridObject gridObject = grid.GetGridObject(x, y);
                if (gridObject.CanBuild())
                {
                    Transform builtTransform = Instantiate(platTranform, grid.GetWorldPosition(x * 1, y * 1), Quaternion.identity);
                    gridObject.SetTransform(builtTransform);
                    limitPlatforms--;
                }
                else
                {
                    UtilsClass.CreateWorldTextPopup("No Puedes Aqui!", mousePosition);
                }
            }
            
        }
        
    }

    public Vector3 PlayerPositionWorld()
    {
        Vector3 vec = playerSpawner.transform.position;
        return vec;
    }
    //////////////
    /////Lista Vacio
    public GameObject[] vaciosSpawners;
    //Lista Vacio

    public GameObject vacioSpawner;
    [SerializeField] public Transform espacioEmpty;
    public void SetVacio()
    {
        foreach (GameObject vacio in vaciosSpawners)
        {           
            Debug.Log('f');
            Vector3 position = PositionWorld(vacio);

            grid.GetXY(position, out int x, out int y);

            GridObject gridObject = grid.GetGridObject(x, y);
            if (gridObject.CanBuild())
            {
                Transform builtTransform = Instantiate(espacioEmpty, grid.GetWorldPosition(x * 1, y * 1), Quaternion.identity);
                gridObject.SetTransform(builtTransform);
            }
        }        
    }

    //public Vector3 PositionWorld()
    //{
    //    Vector3 vec = vacioSpawner.transform.position;
    //    return vec;
    //}
    public Vector3 PositionWorld(GameObject vaciO)
    {
        Vector3 vec = vaciO.transform.position;
        return vec;
    }
}
