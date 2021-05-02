using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class GridDos  <TGridObject>
{
    //    //public const int HEAT_MAP_MAX_VALUE = 100;
    //    //public const int HEAT_MAP_MIN_VALUE = 0;

    //    public event EventHandler<OnGridObjectChangedEventArgs> OnGridObjectChanged;
    //    public class OnGridObjectChangedEventArgs : EventArgs
    //    {
    //        public int x;
    //        public int y;
    //    }

    //    private int width;
    //    private int height;
    //    private float cellSize;
    //    private Vector3 originPosition;
    //    //private TGridObject[,] gridArray;
    //    private int[,] gridArray;

    //    public GridDos(int width, int height, float cellSize, Vector3 originPosition/*, Func<GridDos<TGridObject>, int, int, TGridObject> createGridObject*/)
    //    {
    //        this.width = width;
    //        this.height = height;
    //        this.cellSize = cellSize;
    //        this.originPosition = originPosition;
    //        //gridArray = new TGridObject[width, height];
    //        //gridArray = new int[width, height];
    //        //for (int x = 0; x < gridArray.GetLength(0); x++)
    //        //{
    //        //    for (int y = 0; y < gridArray.GetLength(1); y++)
    //        //    {
    //        //        gridArray[x, y] = createGridObject(this, x, y);
    //        //    }
    //        //}

    //        bool showDebug = true;
    //        if (showDebug)
    //        {
    //            TextMesh[,] debugTextArray = new TextMesh[width, height];

    //            for (int x = 0; x < gridArray.GetLength(0); x++)
    //            {
    //                for (int y = 0; y < gridArray.GetLength(1); y++)
    //                {
    //                    debugTextArray[x, y] = UtilsClass.CreateWorldText(gridArray[x, y]/*?*/.ToString(), null, GetWorldPosition(x, y) + new Vector3(cellSize, cellSize) * .5f, 30, Color.white, TextAnchor.MiddleCenter);
    //                    Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x, y + 1), Color.white, 100f);
    //                    Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x + 1, y), Color.white, 100f);
    //                }
    //            }
    //            Debug.DrawLine(GetWorldPosition(0, height), GetWorldPosition(width, height), Color.white, 100f);
    //            Debug.DrawLine(GetWorldPosition(width, 0), GetWorldPosition(width, height), Color.white, 100f);

    //            //OnGridObjectChanged += (object sender, OnGridObjectChangedEventArgs eventArgs) =>
    //            //{
    //            //    debugTextArray[eventArgs.x, eventArgs.y].text = gridArray[eventArgs.x, eventArgs.y]/*?*/.ToString();
    //            //};
    //        }
    //    }

    //    public int GetWidth()
    //    {
    //        return width;
    //    }

    //    public int GetHeight()
    //    {
    //        return height;
    //    }

    //    public float GetCellSize()
    //    {
    //        return cellSize;
    //    }

    //    public Vector3 GetWorldPosition(int x, int y)
    //    {
    //        return new Vector3(x, y) * cellSize + originPosition;
    //    }

    //    private void GetXY(Vector3 worldPosition, out int x, out int y)
    //    {
    //        x = Mathf.FloorToInt((worldPosition - originPosition).x / cellSize);
    //        y = Mathf.FloorToInt((worldPosition - originPosition).y / cellSize);
    //    }



    //public void SetGridObject(int x, int y, TGridObject value)
    //{
    //    if (x >= 0 && y >= 0 && x < width && y < height)
    //    {
    //        gridArray[x, y] = value;
    //        if (OnGridObjectChanged != null) OnGridObjectChanged(this, new OnGridObjectChangedEventArgs { x = x, y = y });
    //    }
    //}

    //public void TriggerGridObjectChanged(int x, int y)
    //{
    //    if (OnGridObjectChanged != null)
    //    {
    //        OnGridObjectChanged(this, new OnGridObjectChangedEventArgs { x = x, y = y });
    //    }
    //}

    //public void SetGridObject(Vector3 worldPosition, TGridObject value)
    //{
    //    int x, y;
    //    GetXY(worldPosition, out x, out y);
    //    SetGridObject(x, y, value);
    //}

    //public TGridObject GetGridObject(int x, int y)
    //{
    //    if (x >= 0 && y >= 0 && x < width && y < height)
    //    {
    //        return gridArray[x, y];
    //    }
    //    else
    //    {
    //        return default(TGridObject);
    //    }
    //}

    //public TGridObject GetGridObject(Vector3 worldPosition)
    //{
    //    int x, y;
    //    GetXY(worldPosition, out x, out y);
    //    return GetGridObject(x, y);
    //}
    //private int width;
    //private int height;
    //private float cellSize;
    //private Vector3 originPosition;
    //private int[,] gridArray;
    //private TextMesh[,] debugTextArray;

    //public GridDos(int width, int height, float cellSize, Vector3 originPosition)
    //{
    //    this.width = width;
    //    this.height = height;
    //    this.cellSize = cellSize;
    //    this.originPosition = originPosition;

    //    gridArray = new int[width, height];
    //    debugTextArray = new TextMesh[width, height];

    //    for (int x = 0; x < gridArray.GetLength(0); x++)
    //    {
    //        for (int y = 0; y < gridArray.GetLength(1); y++)
    //        {
    //            debugTextArray[x, y] = UtilsClass.CreateWorldText(gridArray[x, y].ToString(), null, GetWorldPosition(x, y) + new Vector3(cellSize, cellSize) * .5f, 20, Color.white, TextAnchor.MiddleCenter);
    //            Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x, y + 1), Color.white, 100f);
    //            Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x + 1, y), Color.white, 100f);
    //        }
    //    }
    //    Debug.DrawLine(GetWorldPosition(0, height), GetWorldPosition(width, height), Color.white, 100f);
    //    Debug.DrawLine(GetWorldPosition(width, 0), GetWorldPosition(width, height), Color.white, 100f);
    //}

    //private Vector3 GetWorldPosition(int x, int y)
    //{
    //    return new Vector3(x, y) * cellSize;
    //}

    //private void GetXY(Vector3 worldPosition, out int x, out int y)  
    //{
    //    x = Mathf.FloorToInt((worldPosition - originPosition).x / cellSize);
    //    y = Mathf.FloorToInt((worldPosition - originPosition).y / cellSize);
    //}
    //public void SetValue(int x, int y, int value)
    //{
    //    if(x >= 0 && y >= 0 && x <width && y < height)
    //    {
    //        gridArray[x, y] = value;
    //        debugTextArray[x, y].text = gridArray[x, y].ToString();
    //    }
    //}

    //public void SetValue(Vector3 worldPosition, int value)
    //{
    //    int x, y;
    //    GetXY(worldPosition, out x, out y);
    //    SetValue(x, y, value);
    //}

    //public int GetValue(int x, int y)
    //{
    //    if (x >= 0 && y >= 0 && x < width && y < height)
    //    {
    //        return gridArray[x, y];
    //    }
    //    else
    //    {
    //        return 0;
    //    }
    //}

    //public int GetValue(Vector3 worldPosition)
    //{
    //    int x, y;
    //    GetXY(worldPosition, out x, out y);
    //    return GetValue(x, y);
    //}
    public event EventHandler<OnGridObjectChangedEventArgs> OnGridObjectChanged;
    public class OnGridObjectChangedEventArgs : EventArgs
    {
        public int x;
        public int y;
    }

    private int width;
    private int height;
    private float cellSize;
    private Vector3 originPosition;
    private TGridObject[,] gridArray;

    public GridDos(int width, int height, float cellSize, Vector3 originPosition, Func<GridDos<TGridObject>, int, int, TGridObject> createGridObject)
    {
        this.width = width;
        this.height = height;
        this.cellSize = cellSize;
        this.originPosition = originPosition;

        gridArray = new TGridObject[width, height];

        for (int x = 0; x < gridArray.GetLength(0); x++)
        {
            for (int y = 0; y < gridArray.GetLength(1); y++)
            {
                gridArray[x, y] = createGridObject(this, x, y);
            }
        }

        bool showDebug = true;
        if (showDebug)
        {
            TextMesh[,] debugTextArray = new TextMesh[width, height];

            for (int x = 0; x < gridArray.GetLength(0); x++)
            {
                for (int y = 0; y < gridArray.GetLength(1); y++)
                {
                    debugTextArray[x, y] = UtilsClass.CreateWorldText(gridArray[x, y]?.ToString(), null, GetWorldPosition(x, y) + new Vector3(cellSize, cellSize) * .5f, 20, Color.white, TextAnchor.MiddleCenter, TextAlignment.Center);
                    Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x, y + 1), Color.white, 100f);
                    Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x + 1, y), Color.white, 100f);
                }
            }
            Debug.DrawLine(GetWorldPosition(0, height), GetWorldPosition(width, height), Color.white, 100f);
            Debug.DrawLine(GetWorldPosition(width, 0), GetWorldPosition(width, height), Color.white, 100f);

            OnGridObjectChanged += (object sender, OnGridObjectChangedEventArgs eventArgs) => {
                debugTextArray[eventArgs.x, eventArgs.y].text = gridArray[eventArgs.x, eventArgs.y]?.ToString();
            };
        }
    }

    public int GetWidth()
    {
        return width;
    }

    public int GetHeight()
    {
        return height;
    }

    public float GetCellSize()
    {
        return cellSize;
    }

    public Vector3 GetWorldPosition(int x, int y)
    {
        return new Vector3(x, y) * cellSize + originPosition;
    }

    public void GetXY(Vector3 worldPosition, out int x, out int y)
    {
        x = Mathf.FloorToInt((worldPosition - originPosition).x / cellSize);
        y = Mathf.FloorToInt((worldPosition - originPosition).y / cellSize);
    }

    public void SetGridObject(int x, int y, TGridObject value)
    {
        if (x >= 0 && y >= 0 && x < width && y < height)
        {
            gridArray[x, y] = value;
            TriggerGridObjectChanged(x, y);
        }
    }

    public void TriggerGridObjectChanged(int x, int y)
    {
        OnGridObjectChanged?.Invoke(this, new OnGridObjectChangedEventArgs { x = x, y = y });
    }

    public void SetGridObject(Vector3 worldPosition, TGridObject value)
    {
        GetXY(worldPosition, out int x, out int y);
        SetGridObject(x, y, value);
    }

    public TGridObject GetGridObject(int x, int y)
    {
        if (x >= 0 && y >= 0 && x < width && y < height)
        {
            return gridArray[x, y];
        }
        else
        {
            return default(TGridObject);
        }
    }

    public TGridObject GetGridObject(Vector3 worldPosition)
    {
        int x, y;
        GetXY(worldPosition, out x, out y);
        return GetGridObject(x, y);
    }
}

