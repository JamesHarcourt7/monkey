using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auuuuu : MonoBehaviour
{
    public AudioSource auuu;
    public AudioSource uaaa;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnMouseOver()
    {
        if (Player.DistanceFromTarget <= 2) 
        {
            if (Input.GetButtonDown("Fire1"))
            {
                StartCoroutine(go());
            }
        }
    }

    IEnumerator go() 
    {
        animator.Play("auuu");
        uaaa.Play();
        yield return new WaitForSeconds(1.5f);
        auuu.Play();
    }

}
