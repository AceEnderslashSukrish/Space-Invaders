using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionChange : MonoBehaviour
{
    private EnemyMover enemyMoverScript;

    // Start is called before the first frame update
    void Start()
    {
        GameObject enemyMoverObj = GameObject.FindWithTag("EnemyMover");

        if (enemyMoverObj != null)
        {
            enemyMoverScript = enemyMoverObj.GetComponent<EnemyMover>();
        }
        if (enemyMoverObj == null)
        {
            Debug.Log("Cannot find enemy mover script on enemy mover object");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public char OnCollisionEnter2D(Collision2D other)
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
        return enemyMoverScript.direction;
    }
}
