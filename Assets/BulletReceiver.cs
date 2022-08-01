using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletReceiver : MonoBehaviour
{

    [SerializeField] int _bulletMax;
    [SerializeField] float _idleDuration;

    int _currentScore;
    float _lastTime;

    void Start()
    {
        _currentScore = 0;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Bullet bullet = collision.GetComponentInParent<Bullet>();
        if (bullet != null)
        {
            //if (_currentScore < _bulletMax) _currentScore++;
            _currentScore = Mathf.Min(_currentScore + 1, _bulletMax);
            _lastTime = Time.time;
        }
        Debug.Log(_currentScore);
    }

    void Update()
    {
        if (Time.time > _lastTime + _idleDuration)
        {
            _currentScore = Mathf.Max(_currentScore - 1, 0);
        }
        Debug.Log(_currentScore);
    }

}
