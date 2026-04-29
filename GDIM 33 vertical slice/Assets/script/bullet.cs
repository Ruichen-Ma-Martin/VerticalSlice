using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField] private float _speed = 100f;

    private Rigidbody2D _rb;
    public float _damage = 1f;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.AddForce(transform.up * _speed, ForceMode2D.Impulse);
        Destroy(gameObject,2f);
    }
     
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("enemy"))
        {
            
            Destroy(gameObject);
        }
    }


}
