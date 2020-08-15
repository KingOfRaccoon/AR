using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ggf : MonoBehaviour
{
	public bool change = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (change)
		{
			SceneManager.LoadScene("SampleScene");
			change = false;
		}
	}
	void startChange()
	{
		change = true;
	}
	
}
