using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEnemies : MonoBehaviour
{
    public Transform theTransform, ref1, ref2;
    public Transform target;
    public float speed = 3;

    private void Start()
    {
        target = ref1;
    }

    private void Update()
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
}
