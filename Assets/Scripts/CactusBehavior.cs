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
            if(Input.GetKeyDown(KeyCode.Space))
            {
                _animator.SetTrigger("AttackTrigger");
            }

            if(Input.GetKeyDown(KeyCode.W))
            {
                _animator.SetTrigger("WalkTrigger");
            }

            if(Input.GetKeyDown(KeyCode.I))
            {
                _animator.SetTrigger("IdleTrigger");
            }
        }
    }
}
