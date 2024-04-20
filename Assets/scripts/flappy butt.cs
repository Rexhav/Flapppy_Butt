using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class flappybutt : MonoBehaviour
{
  private float _velocity = 4f;
  private  float _rotationSpeed = 5f;
    private Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
          if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
       {
            _rb.velocity = Vector2.up * _velocity;
        }
    }
    private void FixedUpdate(){
        transform.rotation = Quaternion.Euler(0,0, _rb.velocity.y * _rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision){
        Game_Manager.instance.GameOver();
        Destroy(transform);
        Debug.Log("Over"); 
        
    }
}

