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
                Debug.Log("Space pressed, triggering attack.");
                _animator.SetTrigger("TrAttack");
            }

            if(Input.GetKeyDown(KeyCode.W))
            {
                Debug.Log("W pressed");
                _animator.SetTrigger("TrWalk");
            }

            if(Input.GetKeyDown(KeyCode.I))
            {
                Debug.Log("I pressed");
                _animator.SetTrigger("TrIdle");
            }
        }
    }
}
