using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public static float DistanceFromTarget;
    public static RaycastHit cast;

    // Update is called once per frame
    void Update()
    {
        Vector3 origin = transform.position;
        Vector3 direction = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(origin, direction, out cast))
        {
            DistanceFromTarget = cast.distance;
        }
        else
        {
            DistanceFromTarget = 0;
        }
    }
}
