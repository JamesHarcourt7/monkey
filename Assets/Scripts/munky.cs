using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class munky : MonoBehaviour
{

    public float radius = 5.0f;
    public Transform center;
    public int angle_offset = 90;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(center.position);
        transform.position = center.position + new Vector3(Mathf.Sin(Time.time + angle_offset) * radius, 0, Mathf.Cos(Time.time + angle_offset) * radius);
    }
}
