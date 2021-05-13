using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraMachine : MonoBehaviour
{
    public CinemachineVirtualCamera cam;
    public GameObject canvas;
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
        yield return new WaitForSeconds(5f);
        cam.Priority = 12;
        canvas.SetActive(true);
        

    }
}
