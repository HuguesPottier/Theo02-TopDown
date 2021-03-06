using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;


    private Transform myTransform;
    private Rigidbody myRigidBody;






    private void Start() 
    {
        myTransform = transform;    
        myRigidBody = GetComponent<Rigidbody>();
    }
    private void Update() 
    {   
        Vector3 direction = Vector3.zero;

        if (Input.GetKey("z"))      //GetKey(KeyCode.Z)
        {
            direction += Vector3.forward;
        }
        if (Input.GetKey("s"))      //GetKey(KeyCode.Z)
        {
            direction += -Vector3.forward;   //-= Vector3.forward
        }
        if (Input.GetKey("q"))      //GetKey(KeyCode.Z)
        {
            direction += Vector3.left;
        }
        if (Input.GetKey("d"))      //GetKey(KeyCode.Z)
        {
            direction += Vector3.right;
        }
        direction = direction.normalized;

        myTransform.Translate(direction * Time.deltaTime * speed, Space.World);  //Utilise les valeurs locales  // tester aussi Space.local
        

        myRigidBody.velocity = Vector3.zero;
        //myRigidBody.velocity = new Vector3(0, 0, 0);  // explication de la ligne du haut

    }
}
// essayer de modifier avec publi Transform myTransform;    myTransform = transform