using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyType { AVERAGE_ENEMY, RANDOM_ENEMY, DUMB_ENEMY };

public abstract class Enemy
{
    // Script completo 

    protected float speed;
    protected Rigidbody2D _rb2D;
    private Sprite _sprite;

    public Enemy(float speed, Rigidbody2D rb2D, Sprite sprite )
    {
        this.speed = speed;
        _rb2D = rb2D;
        _sprite = sprite;
    }
    public Sprite GetSprite()
    {
        return _sprite; 
    }
    public abstract void Move();
    public virtual void Hit()
    {

    }
}
