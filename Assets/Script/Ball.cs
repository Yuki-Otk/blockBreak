using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    private float speed = 20.0f;
    private GameObject bar;
    private GameManager gms;
	// Use this for initialization
	void Start () {
        bar = GameObject.Find("bar");
        gms = GameObject.Find("GameManager").GetComponent<GameManager>();
        this.GetComponent<Rigidbody>().AddForce((-transform.up) * speed, ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {
        //this.GetComponent<Rigidbody>().AddForce((-transform.up) * speed/, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == bar)
        {
            float barDiff = transform.position.x- bar.transform.position.x;
            Debug.Log(barDiff);
            this.GetComponent<Rigidbody>().AddForce(transform.up*speed/2, ForceMode.VelocityChange);
            this.GetComponent<Rigidbody>().AddForce(new Vector3(barDiff * 10000, 0, 0), ForceMode.Impulse);
        }
        if (collision.gameObject.tag == "Block")
        {
            Destroy(collision.gameObject);
            gms.DoBlockDec();
        }
    }
}
