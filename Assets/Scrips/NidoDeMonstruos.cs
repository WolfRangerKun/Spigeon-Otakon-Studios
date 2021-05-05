using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NidoDeMonstruos : MonoBehaviour
{
    public static int nidoDeMonstruosIsDead;
    public GameObject destruisteElNido;
    public GameObject boton1;
    public GameObject boton2;
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
            boton1.SetActive(true);
            boton2.SetActive(true);
            nidoDeMonstruosIsDead = 0;
        }
    }
}
