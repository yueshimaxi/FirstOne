using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetactiveByTime : MonoBehaviour {
    public float timer=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer >= 5)
        {
            this.gameObject.SetActive(false);
            timer = 0;
            transform.localPosition = Vector3.zero;
        }
	}
}
