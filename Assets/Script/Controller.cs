using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Controller : MonoBehaviour
{
    private float waitTime = 2f;
    private float jumptime = 1f;
    private float timer = 0;
    public float turnSpeed = 1000f;
    public float move_speed_man;
    private bool isup = false;
    private bool isback = false;
    public float jumpSpeed;
    private bool isGrounded = true;
    public static bool balltwocome = false;
    public static bool ballthreecome = false;
    public static bool ballfourcome = false;
    public static bool isgoal = false;
    public static int myscore = 0;
    AudioSource audio;

    public AudioClip getcoins;
    public AudioClip goal;
    public AudioClip startgamesound;
    public AudioClip speedupsound;
    public AudioClip gobacksound;
    public AudioClip jumpsound;
     public Vector3 moving_vector;
    Animator at;
    Transform t;
    Rigidbody rb;
    void Awake()
    {
        Debug.Log("awake");
    }
    // Use this for initialization

    void Start()
    {
        myscore = 0;
        isgoal = false;
        Debug.Log("start");
        audio= GetComponent<AudioSource>();
        at = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        //   t = GetComponent<Transform>();
        audio.clip = startgamesound;
        if (!audio.isPlaying)
        {
            audio.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //jumping
    //    float amountToMove = move_speed_man * Time.deltaTime;
    //    Vector3 movement = (Input.GetAxis("Horizontal") * -Vector3.left * amountToMove) + (Input.GetAxis("Vertical") * Vector3.forward * amountToMove);
    //    rb.AddForce(movement, ForceMode.Impulse);

        at.SetBool("Jump", false);
        at.SetFloat("Speed", 0f);
        //     t.localPosition += move_speed_man * Time.deltaTime * moving_vector;
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
        */
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += move_speed_man * Time.deltaTime * transform.forward;
            at.SetFloat("Speed", move_speed_man);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += move_speed_man * Time.deltaTime *- transform.right;
            at.SetFloat("Speed", move_speed_man);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += move_speed_man * Time.deltaTime * transform.right;
            at.SetFloat("Speed", move_speed_man);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += (move_speed_man)* Time.deltaTime * -transform.forward;
            at.SetFloat("Speed",- move_speed_man);
        }
        if (Input.GetKey(KeyCode.J))
        {
            transform.Rotate(0, -turnSpeed * Time.deltaTime,0);
           
            //   at.SetFloat("speed", move_speed_man);
        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.Rotate(0, +turnSpeed * Time.deltaTime,0);
            // at.SetFloat("speed", move_speed_man);
        }

        if (Input.GetKey(KeyCode.L))
        {
          rb.velocity = Vector3.zero;
          rb.angularVelocity = Vector3.zero;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpSpeed);
            at.SetBool("Jump", true);
            audio.clip = jumpsound;
            if (!audio.isPlaying)
            {
                 audio.Play();
            }
        }
        if(isup==true)
        {
            timer += Time.deltaTime;
            if (timer < waitTime)
            {
                rb.AddForce(transform.forward * 1000);

            }
            if (timer > waitTime)
            {
                timer = 0f;
                isup = false;
            }
        }
        if (isback == true)
        {
            timer += Time.deltaTime;
            if (timer < waitTime)
            {
                rb.AddForce(-transform.forward * 1000);

            }
            if (timer > waitTime)
            {
                timer = 0f;
               isback = false;
            }
        }       
    }

    /*
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entered");
        if (collision.gameObject.name=="Floor and Wall")
        {
            Debug.Log("is ground");
            isGrounded = true;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        Debug.Log("Exited");
        if (collision.gameObject.name == "Floor and Wall")
        {
            Debug.Log("is on air");
            isGrounded = false;
        }
    }
    */
    /*
    void OnCollisonStay(Collider other)
    {
        if (other.gameObject.name=="Floor and Wall")
        {
            Debug.Log("is ground");
            isGrounded = true; // if the player is in the ground, the bool "canjump" become true
        }
      

    }
    void OnColliderExit(Collider other)
    {
        if (other.gameObject.name == "Floor and Wall")
        {

            Debug.Log("is on air");
            isGrounded = false;//if the player quit the ground, the bool become false
        }
     
    }
    */
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "up1")
        {
            isup = true;
            audio.clip = speedupsound;
            if (!audio.isPlaying)
            {
                audio.Play();
            }

            Debug.Log("into up");
         //   rb.AddForce(Vector3.forward * 100000* Time.deltaTime);
        }
        if (other.gameObject.name == "up2")
        {
            isup = true;
            audio.clip = speedupsound;
            if (!audio.isPlaying)
            {
                audio.Play();
            }
            Debug.Log("into up");
            //   rb.AddForce(Vector3.forward * 100000* Time.deltaTime);
        }

        if (other.gameObject.name == "back1")
        {
            isback = true;
            audio.clip = gobacksound;
            if (!audio.isPlaying)
            {
                audio.Play();
            }
        }

        if (other.gameObject.name == "back2")
        {
            isback = true;
            audio.clip = gobacksound;
            if (!audio.isPlaying)
            {
                audio.Play();
            }
        }

        if (other.gameObject.name == "coin1")
        {
            
            Destroy(other.gameObject);
            audio.clip = getcoins;
            if(!audio.isPlaying)
            {
                audio.Play();
                myscore++;
            }
        }
        if (other.gameObject.name == "winarea")
        {
            isgoal = true;
            Debug.Log("you win");
            audio.clip = goal;
            if (!audio.isPlaying)
            {
                audio.Play();
            }
        }
        if (other.gameObject.name == "balltwocome")
        {
            balltwocome = true;
            Debug.Log("Enter ball2come");
        }
        if (other.gameObject.name == "ballthreecome")
        {
            ballthreecome = true;
            Debug.Log("Enter ball3come");
        }
        if (other.gameObject.name == "ballfourcome")
        {
            ballfourcome = true;
            Debug.Log("Enter ball4come");
        }
        /*
        if (other.gameObject.name == "coin_spawner1")
        {
            Destroy(other.gameObject);
        }
        */
    }
    void OnColliderEnter(Collider other)
    {
        if (other.gameObject.name == "Floor")
        {

            Debug.Log("touch the sky");
       
        }
    }



}
