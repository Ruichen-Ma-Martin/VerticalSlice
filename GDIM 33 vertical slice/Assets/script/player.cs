using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private float _health = 5f;
    public int _currentlevel = 1;
    private float _angleDistance = 10f;
    public List<Transform> shootPoints = new List<Transform>();
    [SerializeField] private GameObject shootPointBag;
    public GameObject _bullet;

    void Start()
    {
        UpdateShootingpoint(_currentlevel);
    }
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
    public void LevelUp()
    {
        _currentlevel++;
        UpdateShootingpoint(_currentlevel);

    }
    void UpdateShootingpoint(int level)
    {
        foreach (var point in shootPoints)
        {
            Destroy(point.gameObject);
        }
        shootPoints.Clear();
        for (int i = 0; i < level; i++)
        {
            GameObject newshootpoint = new GameObject("shootPoint_" + (i + 1));
            newshootpoint.transform.parent = shootPointBag.transform;
            newshootpoint.transform.localPosition = Vector3.zero;
            float zRot = (i - (level - 1) / 2f) * _angleDistance;
            newshootpoint.transform.localEulerAngles = new Vector3(0, 0, zRot);
            shootPoints.Add(newshootpoint.transform);
        }
    }
    public void Shoot()
            {
        foreach (var point in shootPoints)
        {
            Instantiate(_bullet, point.position, point.rotation);
        }
    }
}
