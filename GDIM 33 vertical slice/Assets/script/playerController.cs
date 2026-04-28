using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [SerializeField] private GameObject _hand;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private GameObject _shootPoint;
    [SerializeField] private Rigidbody2D _rb;  
    private float _moveSpeed = 5f;
    private bool _isfaceright = true;




    void Update()
    {
        Mouse();
        shoot();
        movement();
        jump();
    }

    void Mouse()
    {

        //Vector3 handposition = _hand.transform.position;
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = 0;
        Vector3 dir = mouseWorldPos - _hand.transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        _hand.transform.rotation = Quaternion.Euler(0, 0, angle-90);
        
    }
    void shoot()
    {
               if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_bullet, _shootPoint.transform.position, _shootPoint.transform.rotation);
        }
    }
    
    void movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2(horizontalInput * _moveSpeed, _rb.velocity.y);
        if ( horizontalInput > 0 && !_isfaceright)
        {
            _isfaceright = true;
            Debug.Log("face right");
        }
        else if (horizontalInput < 0 && _isfaceright)
        {
            _isfaceright = false;
            Debug.Log("face left");
        }
    }
    void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(Vector2.up * 5f, ForceMode2D.Impulse);
        }
    }
}
