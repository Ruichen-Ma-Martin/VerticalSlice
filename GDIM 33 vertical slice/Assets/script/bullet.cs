using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;

    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.AddForce(transform.up * _speed, ForceMode2D.Impulse);
        Destroy(gameObject,2f);
    }
     
     
         
    
}
