using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GulleLogic : MonoBehaviour {
    public GameObject tuk;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,5);
	}
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "feniks")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            Instantiate(tuk, transform.position, Quaternion.identity);
        }
    }
}
