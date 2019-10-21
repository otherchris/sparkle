using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delaycrackle : MonoBehaviour
{ 
	void Start()
	{
		StartCoroutine(Delay());
	}

	IEnumerator Delay()
	{
		print(Time.time);
		AudioSource auddio = GetComponent<AudioSource>();
        yield return new WaitForSeconds(5);
		auddio.Play();
		print(Time.time);
	}
	// Update is called once per frame
	void Update()
	{

	}
}
