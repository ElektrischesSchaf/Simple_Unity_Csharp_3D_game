using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_spawner4 : MonoBehaviour {
    private float waitTime = 2f;
    private float timer = 0;
    public GameObject ballprefab;
    GameObject ball_clone4;
    GameObject ball_clone44;
    private bool yy = false;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Controller.ballfourcome == true && yy == false)
        {
            ball_clone4 = Instantiate(ballprefab, transform.position, Quaternion.identity) as GameObject;
            ball_clone44 = Instantiate(ballprefab, transform.position + new Vector3(0, 0, 2f), Quaternion.identity) as GameObject;
            yy = true;
        }
    }
}
