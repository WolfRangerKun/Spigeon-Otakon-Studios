using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TextoNoPlataforma : MonoBehaviour
{
    public Transform end;
    public GameObject cartel;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 position = end.transform.position;
        cartel.transform.DOMove(position, 1);
        Destroy(gameObject, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
