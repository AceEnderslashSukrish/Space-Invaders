using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextRemover : MonoBehaviour
{
    public GameObject ShootText;
    public GameObject MoveText;
    public GameObject StartText;

    // Start is called before the first frame update
    void Start()
    {
        ShootText.SetActive(true);
        MoveText.SetActive(true);
        StartText.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ShootText.SetActive(false);
            MoveText.SetActive(false);
            StartText.SetActive(false);
        }
    }
}
