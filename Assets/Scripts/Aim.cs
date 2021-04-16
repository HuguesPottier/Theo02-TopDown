using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{

    public Camera myCamera = null;
    public Transform gun;
    private Transform myTransform;
    void Start()
    {
        myTransform = transform;
    }




    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = Vector3.zero;
        Plane plane = new Plane(Vector3.up, gun.position); //Cree un plan avec une normale et un point de passage
        // Vector3.up, c'est une vertical, normale au plan bleu qui passe par le gun
        
        Ray ray = myCamera.ScreenPointToRay(Input.mousePosition);  //Cree un Ray depuis la camera, vers le cursuer souris
        if(plane.Raycast(ray, out float distance)) //Raycast retourne un float distance qu'on défini juste ici
        {
            targetPosition = ray.GetPoint(distance);
        } 
        myTransform.LookAt(new Vector3(targetPosition.x, myTransform.position.y, targetPosition.z));

    }
}
