using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArissaControl : MonoBehaviour
{
    Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            _animator.SetTrigger("Flair");
        }
         if(Input.GetKeyDown(KeyCode.S))
        {
            _animator.SetTrigger("Hurricane");
        }
         if(Input.GetKeyDown(KeyCode.D))
        {
            _animator.SetBool("Martelo",true);
        }
        else if(Input.GetKeyUp(KeyCode.D))
        {
            _animator.SetBool("Martelo",false);
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            _animator.SetBool("Salsa Dance",true);
        }
        else if(Input.GetKeyUp(KeyCode.W))
        {
            _animator.SetBool("Salsa Dance",false);
        }
    }
}
