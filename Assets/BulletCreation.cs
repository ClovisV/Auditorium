using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreation : MonoBehaviour
{
    [SerializeField] GameObject _bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Instantiate(_bulletPrefab, transform.position, transform.rotation);
    }
}
