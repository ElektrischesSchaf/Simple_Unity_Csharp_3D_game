using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class backmenu : MonoBehaviour, IPointerClickHandler{
    public void OnPointerClick(PointerEventData e)
    {
        Scene cur_scene = SceneManager.GetActiveScene();
        string scenename = cur_scene.name;
        if (scenename == "scene1" || scenename=="guide")
        {
            SceneManager.LoadScene(0);
        }

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
