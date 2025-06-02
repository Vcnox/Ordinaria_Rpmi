using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class RandomEnemy : Enemy
{

    private Vector2 _Dir;
    private float _timeToSpin;
    private float _currentTime;
    private bool _confused;
    private float Speed = 10f;
    private int direction = 1;
    public float distance = 5f;




    public RandomEnemy(float speed, Rigidbody2D rb2D, Sprite sprite) : base(speed, rb2D, sprite)
    {
      Speed = speed;
     _timeToSpin = 0;
     _currentTime = 1;   
      

    }
    void Start()
    {
        _Dir = _rb2D.transform.position; 
    }



    public override void Move()
    {
        _rb2D.transform.Translate(Vector2.right * direction * Speed *  Time.deltaTime); 
        if (Mathf.Abs(_rb2D.transform.position.x - _Dir.x)>= distance)
        {
            direction = -1;
        }
    }
}
