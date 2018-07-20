using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_controller : MonoBehaviour {
    public float turnSpeed = 1000f;
    public float move_speed_FPS = 10f;
    public Vector3 moving_vector;
   
//    Animator at;
  //  Transform t;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up , -turnSpeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
         
            transform.Rotate(Vector3.up, +turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {

            transform.position += move_speed_FPS * Time.deltaTime * Vector3.forward;
            //       at.SetFloat("Speed", move_speed_camera);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += move_speed_FPS * Time.deltaTime * Vector3.left;
            //      at.SetFloat("Speed", move_speed_camera);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += move_speed_FPS * Time.deltaTime * Vector3.right;
            //      at.SetFloat("Speed", move_speed_camera);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += move_speed_FPS * Time.deltaTime * Vector3.back;
            //         at.SetFloat("Speed", move_speed_camera);
        }

    }
}
