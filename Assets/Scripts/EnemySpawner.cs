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
    public float minTimeToSpawn, maxTimeToSpawn;    
    private float timeToSpawn, spawnTime;
    


    //Faltaria el puente :(
    void Start()
    {
        timeToSpawn = 0;
        spawnTime = Random.Range(minTimeToSpawn, maxTimeToSpawn);
        InstanceEnemy();
    }
    void Update()
    {
        timeToSpawn += Time.deltaTime;
        if (timeToSpawn >= spawnTime )
        {
            Instantiate(RandomEnemy, new Vector2(Random.Range(-5, 5), transform.position.y), Quaternion.identity);
        }
        timeToSpawn = 0;
        spawnTime = Random.Range(-minTimeToSpawn, maxTimeToSpawn);
    }

   
    // Objetos creados 
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
        GetComponent<SpriteRenderer>().sprite = Enemy.GetSprite();
    }





}
