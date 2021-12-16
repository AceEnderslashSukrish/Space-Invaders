using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bullet;
    public float fireRate = 0.25f;

    private TextRemover textRemoverScript;
    private float timer = 0;
    private bool gameStart = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            gameStart = true;
        }
        if (Input.GetKey(KeyCode.Space) && timer > fireRate && gameStart)
        {
            BulletCreator();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    void BulletCreator()
    {
        Instantiate(bullet, new Vector2(transform.position.x, transform.position.y + 0.5f), Quaternion.identity);
    }
}
