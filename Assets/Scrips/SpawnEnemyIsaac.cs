using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyIsaac : MonoBehaviour
{
    float timer;
    public GameObject enemyPrefabUp, enemyPrefabDown, enemyPrefabDer, enemyPrefabIzqu;
   
    void Update()
    {
        timer += Time.deltaTime;
        //Abajo
        if (timer >= 2 /*&& timer < 1.1f*/)
        {
            timer = 0;
            Arriba();
            Abajo();
            Izq();
            Der();
        }
    }

    void Arriba()
    {
        float x = Random.Range(-25f, 25f);
        float y = 25f;
        Vector3 position = new Vector3(x, y, 0);
        Quaternion rotation = new Quaternion();
        Instantiate(enemyPrefabDown, position, rotation);
    }

    void Abajo()
    {
        float x = Random.Range(-25f, 25f);
        float y = -25f;
        Vector3 position = new Vector3(x, y, 0);
        Quaternion rotation = new Quaternion();
        Instantiate(enemyPrefabUp, position, rotation);
    }


    void Izq()
    {
        float x = -25f;
        float y = Random.Range(-25f, 25f);
        Vector3 position = new Vector3(x, y, 0);
        Quaternion rotation = new Quaternion();
        Instantiate(enemyPrefabDer, position, rotation);

    }

    void Der()
    {
        float x = 25f;
        float y = Random.Range(-25f, 25f);
        Vector3 position = new Vector3(x, y, 0);
        Quaternion rotation = new Quaternion();
        Instantiate(enemyPrefabIzqu, position, rotation);
    }
}

