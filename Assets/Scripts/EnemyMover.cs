using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    private float timer = 0;
    private bool startMove = false;
    private bool done1 = false;
    private bool done2 = false;
    private bool done3 = false;
    private bool done4 = false;
    private DirectionChange directionChangeScript;

    [HideInInspector]
    public char direction = 'r';
    public GameObject SpawnLine1;
    public GameObject SpawnLine2;
    public GameObject SpawnLine3;
    public GameObject SpawnLine4;
    public GameObject SpawnLine5;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.E))
        {
            startMove = true;
        }
        if (startMove)
        {
            timer += 0.05f;
            float timercount = Mathf.Floor(timer);
            Debug.Log(timercount);

            if (timercount == 1 && direction == 'r' && !done1)
            {
                SpawnLine5.transform.position = SpawnLine5.transform.position + new Vector3(0.5f, 0, 0);
                done1 = true;
            }
            else if (timercount == 2 && direction == 'r' && !done2)
            {
                SpawnLine4.transform.position = SpawnLine4.transform.position + new Vector3(0.5f, 0, 0);
                done2 = true;
            }
            else if (timercount == 3 && direction == 'r' && !done3)
            {
                SpawnLine3.transform.position = SpawnLine3.transform.position + new Vector3(0.5f, 0, 0);
                done3 = true;
            }
            else if (timercount == 4 && direction == 'r' && !done4)
            {
                SpawnLine2.transform.position = SpawnLine2.transform.position + new Vector3(0.5f, 0, 0);
                done4 = true;
            }
            else if (timercount == 5 && direction == 'r')
            {
                SpawnLine1.transform.position = SpawnLine1.transform.position + new Vector3(0.5f, 0, 0);
                timer = 0;
                done1 = false;
                done2 = false;
                done3 = false;
                done4 = false;
            }

            if (timercount == 1 && direction == 'l' && !done1)
            {
                SpawnLine5.transform.position = SpawnLine5.transform.position + new Vector3(-0.5f, 0, 0);
                done1 = true;
            }
            else if (timercount == 2 && direction == 'l' && !done2)
            {
                SpawnLine4.transform.position = SpawnLine4.transform.position + new Vector3(-0.5f, 0, 0);
                done2 = true;
            }
            else if (timercount == 3 && direction == 'l' && !done3)
            {
                SpawnLine3.transform.position = SpawnLine3.transform.position + new Vector3(-0.5f, 0, 0);
                done3 = true;
            }
            else if (timercount == 4 && direction == 'l' && !done4)
            {
                SpawnLine2.transform.position = SpawnLine2.transform.position + new Vector3(-0.5f, 0, 0);
                done4 = true;
            }
            else if (timercount == 5 && direction == 'l')
            {
                SpawnLine1.transform.position = SpawnLine1.transform.position + new Vector3(-0.5f, 0, 0);
                timer = 0;
                done1 = false;
                done2 = false;
                done3 = false;
                done4 = false;
            }
        }
    }
}
