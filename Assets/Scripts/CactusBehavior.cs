using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusBehavior : MonoBehaviour
{
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_animator != null)
        {
            if(Input.GetKeyDown("Space"))
            {
                _animator.Play("Attack");
            }

            if(Input.GetKeyDown("W"))
            {
                _animator.Play("Walk_Mec");
            }

            if(Input.GetKeyDown("I"))
            {
                _animator.Play("Idle");
            }
        }
    }
}
