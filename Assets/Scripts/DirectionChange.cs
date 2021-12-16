using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionChange : MonoBehaviour
{
    [HideInInspector]
    public EnemyMover enemyMoverScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("EnemyBlock"))
        {
            other.gameObject.transform.position = other.gameObject.transform.position + new Vector3(-1, -0.5f, 0);
            enemyMoverScript.direction = 'r';
        }
        else if (other.gameObject.CompareTag("LastEnemyBlock"))
        {
            other.gameObject.transform.position = other.gameObject.transform.position + new Vector3(-1, -0.5f, 0);
            enemyMoverScript.direction = 'l';
        }
    }
}
