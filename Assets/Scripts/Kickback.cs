using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kickback : MonoBehaviour
{

    public float KickBackForce = 100.0f;
    private GameObject player;
    private Rigidbody rb;
    public float maxVelocity = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        rb = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            RaycastHit Shot = Player.cast;
            
            player.transform.position += new Vector3(0, 0.2f, 0);

            Vector3 TargetDirection = transform.position - Shot.point;
            Vector3 v = TargetDirection.normalized * KickBackForce;

            StartCoroutine(kick(v));
        }
    }

    IEnumerator kick(Vector3 v) {
        yield return new WaitForSeconds(0.1f);
        rb.velocity += v;
        if (rb.velocity.magnitude > maxVelocity) {
            rb.velocity = rb.velocity.normalized * maxVelocity;
        }
    }
}
