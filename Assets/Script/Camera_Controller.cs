using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour {

  
    public float move_speed_camera;
    public Vector3 moving_vector;
    public GameObject player;
    private Vector3 offset;
    [SerializeField]
    private Transform target;
    [SerializeField]
    private Space offsetspace = Space.Self;
    [SerializeField]
    private bool lookAt = true;

    
    void Start()
    {

        offset = transform.position - player.transform.position;
    }
    void LateUpdate()
    {
        Refresh();
    }
    public void Refresh()
    {
        if(offsetspace==Space.Self)
        {
            transform.position = target.TransformPoint(offset);
        }
        else
        {
            transform.position = target.position + offset;
        }

        if(lookAt)
        {
         //   Vector3 targetPostition = new Vector3(target.position.x,
         //                              target.position.y,
          //                             this.transform.position.z);
        //    this.transform.LookAt(targetPostition);
            transform.LookAt(target);

        }
        else
        {
            transform.rotation = target.rotation;
        
        }
    }
    /*
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
    */
    /*
    //Animator at;
    Transform t;
    void Awake()
    {

    }
    // Use this for initialization

    void Start()
    {
    //    at = GetComponent<Animator>();
        //   t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
    //    at.SetFloat("Speed", 0f);
        //     t.localPosition += move_speed_camera * Time.deltaTime * moving_vector;
        /*
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.z++;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.z--;
            this.transform.position = position;
        }
        
             if (Input.GetKey(KeyCode.W))
        {
          
            transform.position += move_speed_camera * Time.deltaTime * Vector3.forward;
     //       at.SetFloat("Speed", move_speed_camera);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += move_speed_camera * Time.deltaTime * Vector3.left;
      //      at.SetFloat("Speed", move_speed_camera);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += move_speed_camera * Time.deltaTime * Vector3.right;
      //      at.SetFloat("Speed", move_speed_camera);
        }
        if (Input.GetKey(KeyCode.S))
        {           
            transform.position += move_speed_camera * Time.deltaTime * Vector3.back;
   //         at.SetFloat("Speed", move_speed_camera);
        }
        if (Input.GetKey(KeyCode.J))
        {
       //     transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
            //   at.SetFloat("speed", move_speed_camera);
        }
        if (Input.GetKey(KeyCode.K))
        {
        //    transform.Rotate(Vector3.up, +turnSpeed * Time.deltaTime);
            // at.SetFloat("speed", move_speed_camera);
        }


        //   transform.Translate(Vector3.back * Time.deltaTime);
    }

    */
}
