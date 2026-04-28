using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class enemyControl : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    private float _moveSpeed = 3f;
    private float moveDirection = -1f;
    [SerializeField] private GameObject player;

    [SerializeField] private Vector2 _areaSize = new Vector2(5f, 5f);
    [SerializeField] private Vector2 _AreaCenter;

    void Start()
    {
        SetArea();
        
    }
    void Update()
    {
        MoveInRange();
        //followPlayer();
        //hitplayer();
    }
        

    void SetArea()
    {
        float x = Random.Range(transform.position.x - _areaSize.x / 2, transform.position.x + _areaSize.x / 2);
        _AreaCenter = new Vector2(x,transform.position.y);
        
    }

    void MoveInRange()
    {

        
        _rb.velocity = new Vector2(moveDirection * _moveSpeed, _rb.velocity.y);
        if (transform.position.x >= _AreaCenter.x + _areaSize.x / 2)
        {
            
            //Debug.Log("change direction");
            moveDirection = -1f;
        }
        else if (transform.position.x <= _AreaCenter.x - _areaSize.x / 2)
        {
            //Debug.Log("change direction");
            moveDirection = 1f;
        }

    }

    void followPlayer()
    {
        
        if (player != null)
        {
            Vector2 direction = (player.transform.position - transform.position).normalized;
            _rb.velocity = new Vector2(direction.x * _moveSpeed, _rb.velocity.y);
        }
    }

    void hitplayer()
    {
        if (player != null)
        {
            Vector2 direction = (player.transform.position - transform.position).normalized;
            if (direction.x > 0f)
            {
                Debug.Log("Player hit from right!");
            }
            else if (direction.x < 0f)
            {
                Debug.Log("Player hit from left!");

            }
        }
    }

        void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireCube(_AreaCenter, _areaSize);
        }
    }

