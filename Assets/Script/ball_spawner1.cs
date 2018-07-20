using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_spawner1 : MonoBehaviour {
    public GameObject ballprefab;
    GameObject ball_clone1;
    // Use this for initialization
    void Start()
    {
        ball_clone1 = Instantiate(ballprefab, transform.position, Quaternion.identity) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
