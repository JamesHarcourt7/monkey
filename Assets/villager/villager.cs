using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class villager : MonoBehaviour
{

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion targetRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        targetRotation *= Quaternion.Euler(0, 0, 0);

        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.001f);
    }
}
