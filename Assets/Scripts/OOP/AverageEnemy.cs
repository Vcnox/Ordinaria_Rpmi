using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AverageEnemy : Enemy
{
    public Transform player;
    public GameObject target;
    public AverageEnemy(float speed, Rigidbody2D rb2D, Sprite sprite) : base(speed, rb2D, sprite)
    {
        speed = 15f;
    }

    public override void Move()
    {
        _rb2D.transform.position = Vector2.MoveTowards(_rb2D.transform.position, player.position, speed * Time.deltaTime); 
    }
}
