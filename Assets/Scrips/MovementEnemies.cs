using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEnemies : MonoBehaviour
{
    public Transform theTransform, ref1, ref2;
    public Transform target;
    public float speed = 3;
    public bool oneDirection;
    SpawnVincent spawn;

    private void Start()
    {
        if (!oneDirection)
        {
            target = ref1;
        }
        if (oneDirection)
        {
            Destroy(gameObject, 7);
        }
    }

    private void Update()
    {
        if (oneDirection)
        {
            OneDirection();
        }
        if (!oneDirection)
        {
            Movement1or2();
        }
    }

    public void Movement1or2()
    {
        if (Vector3.Distance(theTransform.position, target.position) > 0.1f)

        {
            theTransform.position = Vector3.MoveTowards(theTransform.position, target.position, speed * Time.deltaTime);
        }
        else
        {
            if (target == ref1)
            {
                target = ref2;
            }
            else if (target == ref2)
            {
                target = ref1;
            }

        }
    }

    public void OneDirection()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        
    }
}
