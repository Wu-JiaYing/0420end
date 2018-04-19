using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour {

    Rigidbody rb;
    public GameObject shot;
    public float speed;
    public float fireRate;
    public Transform shotSpawn;
    float nextFire;
    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        //transform.Translate(x,0,z);
        rb.AddForce(new Vector3(x, 0, z) * speed);


    }

    
}
