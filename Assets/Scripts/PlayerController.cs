using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    private float turnSpeed = 25.0f ;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
      //either use transform.Translate(0,0,1) or use transform.Translate(Vector3.forward)
      //and we want the vehicle to move slowly is multiply that with Time.deltaTime * 20(car moves 20m/sec)
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
      //for turning the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        
    }
}
