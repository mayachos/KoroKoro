using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float power = 5.0f;

     //float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            //transform.position += new Vector3(0, 0, speed * Time.deltaTime);
            // RigidBodyのConstraintsを外す
            this.gameObject.GetComponent<Rigidbody>().AddForce(0, 0, power);
            Debug.Log("Go");
        }

        if (Input.GetKey("down"))
        {
            //transform.position += new Vector3(0, 0, -speed * Time.deltaTime);
            this.gameObject.GetComponent<Rigidbody>().AddForce(0, 0, -power);
            Debug.Log("Down");
        }

        if (Input.GetKey("left"))
        {
            //transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
            this.gameObject.GetComponent<Rigidbody>().AddForce(-power, 0, 0);
            Debug.Log("Left");
        }

        if (Input.GetKey("right"))
        {
            //transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            this.gameObject.GetComponent<Rigidbody>().AddForce(power, 0, 0);
            Debug.Log("Right");
        }

        if (transform.position.y <= -10)
        {
            //transform.position = new Vector3(0, 1.5f, 0);
            //Debug.Log("Fall");
            FadeManager.Instance.LoadLevel("GameOver", 1.0f);
        }
    }
}
