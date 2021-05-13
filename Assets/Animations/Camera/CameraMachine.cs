using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraMachine : MonoBehaviour
{
    public CinemachineVirtualCamera cam;
    public GameObject canvas;
    public float timeToMove = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(timing());
    }

    IEnumerator timing()
    {
        yield return new WaitForSeconds(timeToMove);
        cam.Priority = 12;
        canvas.SetActive(true);
        

    }
}
