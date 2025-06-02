using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public EnemyType type;
    public Enemy enemy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        enemy.Move();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        enemy.Hit();
    }
}
