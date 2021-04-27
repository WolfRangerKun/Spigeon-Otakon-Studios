using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public bool deathOrHorda;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && deathOrHorda == false)
        {
            HordaScene();
        }
        if (other.CompareTag("Player") && deathOrHorda == true)
        {
            Death();
        }
    }

    public void HordaScene()
    {
        SceneManager.LoadScene("Horda Scene");
    }
    public void Death()
    {
        SceneManager.LoadScene("PlatformScene");
    }
}
