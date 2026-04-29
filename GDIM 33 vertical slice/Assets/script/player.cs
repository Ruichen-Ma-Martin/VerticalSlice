using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private float _health = 5f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemyhitbox"))
        {
           Debug.Log("Player hit by enemy!");
            TakeDamage();
        }
    }
    void TakeDamage()
    {
        _health -= GameController.instance.enemyattack._damage;
        if (_health <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        Destroy(gameObject);
    }
}
