using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonAnim : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetBool("OnClick", true);
            Debug.Log("Play game!");
        }
    }
}
