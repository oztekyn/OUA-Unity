using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    public float speed = 0.0f;
    private Rigidbody2D  r2d;
    private Animator _animator;

    private void Start()
    {
        r2d = GetComponent<Rigidbody2D>(); //caching r2d
        _animator = GetComponent<Animator>(); //caching animator
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            speed = 1.0f;
            Debug.Log(message: "Hýz 1.0f");

        }

        else 
        {
            speed = 0.0f;
            Debug.Log(message: "Hiz 0.0f");
        }
    }

}
