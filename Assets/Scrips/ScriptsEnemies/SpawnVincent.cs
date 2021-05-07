using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVincent : MonoBehaviour
{
    public GameObject enemiesUp;
    public Transform ref1, ref2 ,ref3;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
        StartCoroutine(SpawnTiming());
    }

    void Spawn()
    {
        Instantiate(enemiesUp, ref1.position, Quaternion.identity);
        Instantiate(enemiesUp, ref2.position, Quaternion.identity);
        Instantiate(enemiesUp, ref3.position, Quaternion.identity);

    }

    IEnumerator SpawnTiming()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            Spawn();
        }
        
    }
}
