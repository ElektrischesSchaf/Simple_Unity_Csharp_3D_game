using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_spawner : MonoBehaviour {
    public GameObject coin;
    GameObject coin_clone1;
    //  GameObject coin_clone2;
    AudioSource audio;
    public AudioClip getcoins;
    // Use this for initialization
    void Start () {
        audio = GetComponent<AudioSource>();
        coin_clone1 = Instantiate(coin, transform.position, Quaternion.identity) as GameObject;
      //  coin_clone2 = Instantiate(coin, transform.position, Quaternion.identity) as GameObject;
        /*
        int N_coin = Random.Range(5, 10);
      
        float[] pos_X = { 7, -5, 3, -2, 2, -4, 1, 8, 4, 0, 6, -1 };
        float[] pos_Y = { -1, 1, -2, 3, -4, -6, 2, -3, 4, -5 };
        int random_X = Random.Range(0, 11);
        int random_Y = Random.Range(0, 9);

        Rigidbody[] c = new Rigidbody[N_coin];
    
        for (int i = 0; i < N_coin; i++)
        {
            c[i] = Instantiate(coin);
            c[i].parent = rigidbody;
            c[i].localPosition = new Vector3(pos_X[random_X], 0 , pos_Y[random_Y]);

         

            random_X++;
            random_Y++;
            if (random_X == 12) random_X = 0;
            if (random_Y == 10) random_Y = 0;

        }
        //c.localPosition = Vector3.one;
        */
    }

    // Update is called once per frame
    void Update () {
		
	}
    
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "unitychan")
        {
            
            Destroy(coin_clone1);
            Debug.Log("unitychan hit a prefab coin");
            audio.clip = getcoins;
            if (!audio.isPlaying)
            {
                audio.Play();
                Controller.myscore++;
            }
        }
    }
    
}
