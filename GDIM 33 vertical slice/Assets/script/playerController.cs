using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [SerializeField] private GameObject _hand;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private GameObject _shootPoint;
    private float _Xscensitivity = 10f;
    private float _Yscensitivity = 10f;

    
    void Update()
    {
        Mouse();
        shoot();
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
    
}
