using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthLogic : MonoBehaviour {

    public Sprite healthFull;
    public Sprite healthEmpty;

    float timer = 1f;
    float delay = 1f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            if(this.gameObject.GetComponent<SpriteRenderer>().sprite == healthFull)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = healthEmpty;
                timer = delay;
                return;
            }
            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == healthEmpty)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = healthFull;
            }
        }
	}
}
