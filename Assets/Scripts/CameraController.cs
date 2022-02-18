using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        //transform.Rotate(new Vector3(0, 1.5f, 0));
        transform.position = new Vector3(0, 6.0f, -10f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position + new Vector3(0, 6f, -10f);
        
    }
}
