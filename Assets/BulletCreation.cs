using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreation : MonoBehaviour
{
    [SerializeField] GameObject _bulletPrefab;
    [SerializeField] float _spawnCooldown;

    float _lastShoot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > _lastShoot + _spawnCooldown)
        {
            float rx = Random.Range(-1f, 1f);
            float ry = Random.Range(-1f, 1f);
            Vector3 randomDirection = new Vector2(rx, ry);
            _lastShoot = Time.time;
            GameObject.Instantiate(_bulletPrefab, transform.position + randomDirection, transform.rotation);
        }
    }
}
