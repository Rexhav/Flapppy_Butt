using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_1 : MonoBehaviour
{
    private float _speed = 6.0f;
    // Start is called before the first frame update
    void Start()
    {
        _speed = _speed + spawner_1.counter;
      //  Debug.Log(_speed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}
