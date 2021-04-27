using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    public static bool isGrounded;

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded = false;
    }
}
