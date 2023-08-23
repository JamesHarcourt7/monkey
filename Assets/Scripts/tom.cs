using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tom : MonoBehaviour
{

    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.position);

        Vector3 direction = player.position - transform.position;
        if (direction.magnitude > 5.0f)
        {
            transform.position += direction.normalized * Time.deltaTime * 2.0f;
        }
    }
}
