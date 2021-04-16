using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform player = null;  // c'est mieux de l'initialiser
    private Vector3 offset;
    private Transform myTransform;

    void Start()
    {
        myTransform = transform; // transform c'st getcomponent.... qui est gourmand en ressource
        //Vector3 offset = PlayerMove.transform.position - transform.position;   //this.gameObject.transform.position
        offset = player.position - myTransform.position;   //this.gameObject.transform.position
        // Debug.Log(offset);
    }

    // Update is called once per frame
    void LateUpdate()  //remplace Update pour rendre mvt plus fluide **IMPORTANT**
    {
        myTransform.position = player.position - offset;
        myTransform.LookAt(player);
    }
}
