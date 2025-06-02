using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DumbEnemy : Enemy
{
    private Vector2 _Dir;
   
    
    public DumbEnemy(float speed, Rigidbody2D rb2D, Sprite sprite) : base(speed, rb2D, sprite)
    {
        Rigidbody2D rigidbody2D = rb2D;
        speed = 30f;

    }
    public void Start()
    {
        _rb2D.transform.position = _Dir;
    }

    public override void Move()
    {
        
      _Dir = new Vector2 (Random.Range(-5,5),_rb2D.transform.position.y);
    }

    public virtual void Hit()
    {

        _rb2D.IsDestroyed(); 
       
    }
    
    
}
