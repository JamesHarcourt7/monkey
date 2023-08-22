using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noot : MonoBehaviour
{

    private Animator animator;
    public AudioSource nootnoot;

    public float nootTime = 3.0f;
    private float nootTimer = 0.0f;

    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (nootTimer > 0)
        {
            nootTimer -= Time.deltaTime;
        }
        else
        {
            animator.Play("noot");
            nootnoot.Play();
            nootTimer = nootTime;
        }

        // face player
        transform.LookAt(player.position);

        Vector3 direction = player.position - transform.position;
        if (direction.magnitude > 2.0f)
        {
            transform.position += direction.normalized * Time.deltaTime * 2.0f;
        }

    }
}
