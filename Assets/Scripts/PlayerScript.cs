using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody RigidBody;
    public float force = 1200f;
    public float speed = 10f;
    public float maxX;
    public float minX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //code to mkae sure the cube does not fall by setting boundaries
        Vector3 PlayerPos = transform.position;
        if (PlayerPos.x < minX)   //Condition if gone beyond boundary
        {
            PlayerPos.x = minX;
            transform.position = PlayerPos;
        }
        if (PlayerPos.x > maxX)   //Condition if gone beyond boundary
        {
            PlayerPos.x = maxX;
            transform.position = PlayerPos;
        }
//MII - By clamping
       /* Vector3 PlayerPos = transform.position;
        PlayerPos.x = Mathf.Clamp(PlayerPos.x, minX, maxX);
        transform.position = PlayerPos;*/
       
        //Code for movement
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(speed*Time.deltaTime,0,0);
            //RigidBody.AddForce(1000f*Time.deltaTime,0,0);   // With Rigid Body method we can achieve the same result the only differnec eis the movement will be kind of off becuase we are using forces to move the body. usually we use this method in car movement in racing games
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-speed*Time.deltaTime,0,0);  //transform.position = transform.position - new Vector3(+10f*Time.deltaTime,0,0);
            //RigidBody.AddForce(-1000f*Time.deltaTime,0,0);   // With Rigid Body method
        }

    }
    private void FixedUpdate()
    {
       RigidBody.AddForce(0,0,force*Time.deltaTime);   //A continuous force acting on body to make it move forward
         
    }
}
