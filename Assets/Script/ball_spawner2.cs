using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
public class ball_spawner2 : MonoBehaviour {
    private float waitTime = 2f;
    private float timer = 0;
    public GameObject ballprefab;
    GameObject ball_clone2;
    GameObject ball_clone22;
    private bool yy = false;
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Controller.balltwocome == true && yy==false)
        {
            ball_clone2 = Instantiate(ballprefab, transform.position, Quaternion.identity) as GameObject;
            
           ball_clone22 = Instantiate(ballprefab, transform.position+new Vector3(0, 0, 2f), Quaternion.identity) as GameObject;

            yy = true;
            
          
        }

    }
}
