    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner_1 : MonoBehaviour
{
    public float _maxTime = 0.5f;
    public float _height = 0f;
    public GameObject _seat;
    private float _timer;
    public static float counter;
    // Start is called before the first frame update
    private void Start()
    {
        Spawn();
        counter = 0.25f;
    }

    void Update()
    {
        if (_timer > _maxTime){
            Spawn();
            counter = counter + 0.25f;
            _timer = 1;
        }
        _timer += Time.deltaTime;
    }

    public void Spawn(){
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-_height, _height));
          GameObject seat = Instantiate(_seat, spawnPos, Quaternion.identity);

        Destroy(seat , 20f);
    }

    // Update is called once per frame
    
}
