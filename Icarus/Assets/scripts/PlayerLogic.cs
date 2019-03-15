using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour {
    public GameObject gulle;
    public GameObject fenix;        
    int n =0;
    public Camera kamera;
	// Use this for initialization
	void Start () {
		
	}
    
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-5, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(5, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, 4);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(gulle, transform.position, Quaternion.identity);
        }
        if (n == 3)
        {

        }
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "tuk")
        {
            Destroy(other.gameObject);
            n++;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "checkpoint1")
        {
            kamera.transform.position = new Vector3(kamera.transform.position.x + 30, kamera.transform.position.y,-10);
            Instantiate(fenix, new Vector2(14.7f, 2.999f), Quaternion.identity);
            Destroy(other.gameObject);
        }
    }

}
