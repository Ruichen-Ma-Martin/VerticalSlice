using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Unity.VisualScripting;


public class enemyControl : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    private float _moveSpeed = 3f;
    private float moveDirection = -1f;
    [SerializeField] private GameObject player;

    [SerializeField] private Vector2 _areaSize = new Vector2(5f, 5f);
    [SerializeField] private Vector2 _AreaCenter;
    private float _timer;
    private float _CDattack = 2f;
    
    [SerializeField] private GameObject _attack;
    private Vector2 _attackR;
    private Vector2 _attackL;
    
    
    

    private void Awake()
    {
        _attackR = _attack.transform.localPosition;
        _attackL = -_attackR;
    }


    void Update()
    {
        _timer += Time.deltaTime;
        
        
    }
        

    public void SetArea()
    {
        float x = Random.Range(transform.position.x - _areaSize.x / 2, transform.position.x + _areaSize.x / 2);
        _AreaCenter = new Vector2(x,transform.position.y);
        
    }

    public void MoveInRange()
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

    public void followPlayer()
    {
        
        if (player != null)
        {
            Vector2 direction = (player.transform.position - transform.position).normalized;
            _rb.velocity = new Vector2(direction.x * _moveSpeed, _rb.velocity.y);
        }
    }

    public void hitplayer()
    {
        _rb.velocity = Vector2.zero;
        
        
        if (player != null)
        {
            Vector2 direction = (player.transform.position - transform.position).normalized;
            if (direction.x > 0f && _timer >= _CDattack)
            {
                Debug.Log("Player hit from right!");
                _attack.transform.localPosition = _attackR;

                _attack.SetActive(true);
                _timer = 0f;
            }
            else if (direction.x < 0f && _timer >= _CDattack)
            {
                Debug.Log("Player hit from left!");
                
                _attack.transform.localPosition = _attackL;
                _attack.SetActive(true);
                _timer = 0f;
            }
        }
    }
    

        void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireCube(_AreaCenter, _areaSize);
        }
        void OnCollisionEnter2D(Collision2D collision)
        {
        if (collision.gameObject.CompareTag("wall"))
        {
            moveDirection *= -1f;
        }
        if (collision.gameObject.CompareTag("enemy"))
        {
            moveDirection *= -1f;
        }
        }
}

