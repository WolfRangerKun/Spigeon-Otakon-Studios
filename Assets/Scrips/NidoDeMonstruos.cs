using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NidoDeMonstruos : MonoBehaviour
{
    public static int nidoDeMonstruosIsDead;
    public GameObject destruisteElNido;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nidoDeMonstruosIsDead == 1)
        {
            destruisteElNido.SetActive(true);
            nidoDeMonstruosIsDead = 0;
        }
    }
}
