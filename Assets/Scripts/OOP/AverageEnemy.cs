using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AverageEnemy : Enemy
{
    public Transform player;
    public GameObject target;
    public AverageEnemy(float speed, Rigidbody2D rb2D) : base(speed, rb2D, Resources.Load<Sprite>("AverageEnemy"))
    {
        speed = 15f;



    }

    public override void Move()
    {
        _rb2D.transform.position = Vector2.MoveTowards(_rb2D.transform.position, player.position, speed * Time.deltaTime); 
    }
    public virtual void Hit()
    {

    }
}
