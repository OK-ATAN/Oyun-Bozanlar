using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

	public Dialogue dialogue;

	bool isTallked = false;
	
	private void OnTriggerEnter(Collider other)
    	{
		if(!isTallked)
		{
			isTallked = true;
		}
    	}

}