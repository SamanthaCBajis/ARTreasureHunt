using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChestScript : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () 
    {
        anim = GetComponent<Animator>();
	}

    public void OnPointerClick()
    {
        anim.SetTrigger("ChestOpen");  
    }
	
}
