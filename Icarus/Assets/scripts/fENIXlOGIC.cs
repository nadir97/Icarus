using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class fENIXlOGIC : MonoBehaviour {
    public Camera kamera;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (kamera.transform.position.x == 0)
        {
            if (transform.position.x > 15)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-3, GetComponent<Rigidbody2D>().velocity.y);
            }
            if (transform.position.x < -15)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(3, GetComponent<Rigidbody2D>().velocity.y);
            }
            if (transform.position.y > 4.18)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, -0.5f);
            }
            if (transform.position.y < 3)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, 0.5f);
            }
        }
        if (kamera.transform.position.x == 30)
        {
            if (transform.position.x > 45)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-3, GetComponent<Rigidbody2D>().velocity.y);
            }
            if (transform.position.x < 15)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(3, GetComponent<Rigidbody2D>().velocity.y);
            }
            if (transform.position.y > 4.18)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, -0.5f);
            }
            if (transform.position.y < 3)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, 0.5f);
            }
        }
    }
}
