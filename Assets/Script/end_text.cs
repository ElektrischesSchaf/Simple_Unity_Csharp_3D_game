using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class end_text : MonoBehaviour {
    public Text m_MyText;

    // Use this for initialization
    void Start () {
        m_MyText.text = "";
    }
	
	// Update is called once per frame
	void Update () {
		if(Controller.isgoal==true)
        {
            m_MyText.text = "Goal !"+"\n"+"Got "+Controller.myscore.ToString()+" Coins";
        }
	}
}
