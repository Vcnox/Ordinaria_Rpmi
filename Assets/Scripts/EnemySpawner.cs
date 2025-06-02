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
    


    //Faltaria el puente debido que esta todo lo demas  :(
    void Start()
    {
        timeToSpawn = 0;
        spawnTime = Random.Range(minTimeToSpawn, maxTimeToSpawn);
    }
    void Update()
    {
        timeToSpawn += Time.deltaTime;
        if (timeToSpawn >= spawnTime )
        {
            GameObject o = Instantiate(RandomEnemy, new Vector2(Random.Range(-5, 5), transform.position.y), Quaternion.identity);
            InstanceEnemy(o);
            o.GetComponent<SpriteRenderer>().sprite = Enemy.GetSprite();
            o.GetComponent<EnemyBehaviour>().enemy = Enemy;
            timeToSpawn = 0;
            spawnTime = Random.Range(minTimeToSpawn, maxTimeToSpawn);
        }
    }

   
    // Objetos creados 
    public void InstanceEnemy(GameObject o)
    {
        EnemyType = (EnemyType)Random.Range((int)EnemyType.AVERAGE_ENEMY, (int)EnemyType.DUMB_ENEMY + 1);
        switch (EnemyType)
        {
            case EnemyType.AVERAGE_ENEMY:
                Enemy = new AverageEnemy(15f, o.GetComponent<Rigidbody2D>());
                break;

            case EnemyType.DUMB_ENEMY:
                Enemy = new DumbEnemy(30f, o.GetComponent<Rigidbody2D>());
                break;
            case EnemyType.RANDOM_ENEMY:
                Enemy = new RandomEnemy(10f, o.GetComponent<Rigidbody2D>());
                break;
        }

    }





}
