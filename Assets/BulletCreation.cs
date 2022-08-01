using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreation : MonoBehaviour
{
    [SerializeField] GameObject _bulletPrefab;
    [SerializeField] float _spawnCooldown;
    [SerializeField] float _circleSize;
    // [SerializeField] Vector2 _minMax;
    // [SerializeField] float _min;
    // [SerializeField] float _max;

    float _lastShoot;

    void Update()
    {

        // Methode 1
        // float rx = Random.Range(_min, _max);
        // float ry = Random.Range(_min, _max);
        // Vector3 randomDirection = new Vector2(rx, ry);

        //Methode 2
        Vector3 randomDirection = Random.insideUnitCircle;

        if (Time.time > _lastShoot + _spawnCooldown)
        {
            _lastShoot = Time.time;
            GameObject.Instantiate(_bulletPrefab, transform.position + randomDirection, transform.rotation);
        }

    }

    // Draw a green sphere for the gameObject
    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(transform.position, _circleSize);
    }
}
