using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour,IPointerClickHandler {
    public void OnPointerClick(PointerEventData e)
    {
        Scene cur_scene = SceneManager.GetActiveScene();
        string scenename = cur_scene.name;
        if (scenename == "menu")
        {
            SceneManager.LoadScene(1);
        }

    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
