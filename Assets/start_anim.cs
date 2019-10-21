using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_anim : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {
        Animator animator = GetComponent<Animator>();
        yield return new WaitForSeconds(5);
        animator.Play("New Animation");
        print(Time.time);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
