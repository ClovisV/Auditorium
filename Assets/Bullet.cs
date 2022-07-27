using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField] Rigidbody2D _rb;
    [SerializeField] Vector2 _direction;
    [SerializeField] float _speed;

    // Start is called before the first frame update
    void Start()
    {
        _rb.velocity = _direction * _speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
