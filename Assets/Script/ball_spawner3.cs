using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_spawner3 : MonoBehaviour {
    private float waitTime = 2f;
    private float timer = 0;
    public GameObject ballprefab;
    GameObject ball_clone3;
    GameObject ball_clone33;
    private bool yy = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Controller.ballthreecome == true && yy == false)
        {
            ball_clone3 = Instantiate(ballprefab, transform.position, Quaternion.identity) as GameObject;
            ball_clone33= Instantiate(ballprefab, transform.position + new Vector3(2f, 0, 0), Quaternion.identity) as GameObject;
            yy = true;


        }

    }
}
