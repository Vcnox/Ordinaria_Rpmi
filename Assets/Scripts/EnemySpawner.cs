using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyType EnemyType;
    public GameObject RandomEnemy;
    private Enemy Enemy;
    public Rigidbody2D _rb2D;
    private Sprite sprite;

    void Start()
    {

    }
    public void InstanceEnemy()
    {
        switch (EnemyType)
        {
            case EnemyType.AVERAGE_ENEMY:
                Enemy = new AverageEnemy(15f, _rb2D, sprite);
                break;

            case EnemyType.DUMB_ENEMY:
                Enemy = new DumbEnemy(30f, _rb2D, sprite);
                break;
            case EnemyType.RANDOM_ENEMY:
                Enemy = new RandomEnemy(10f, _rb2D, sprite);
                break;
        }
    }





}
