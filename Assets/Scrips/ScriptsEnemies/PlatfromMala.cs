using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatfromMala : MonoBehaviour
{
    public int isGroundedLimit = 0;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(isGroundedLimit >= 3)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("CheckGround"))
        {
            isGroundedLimit++;
        }
        
    }
}
