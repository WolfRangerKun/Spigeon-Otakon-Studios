using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVincent : MonoBehaviour
{
    public GameObject enemiesUp;
    public Transform ref1, ref2;
    public float speed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
        StartCoroutine(SpawnTiming());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        Instantiate(enemiesUp, ref1.position, Quaternion.identity);
    }

    IEnumerator SpawnTiming()
    {
        while (true)
        {
            yield return new WaitForSeconds(4f);
            Spawn();
        }
        
    }
}
