using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCtrl : MonoBehaviour
{

    public ParticleSystem muzzleFlash;
    public ParticleSystem collisionExplosionPrefab;  //on ajoute prefab à la fin

    void Update()
    {
        if(Input.GetMouseButtonDown(0))   //zéro c'est le bouton gauche
        {
            muzzleFlash.Play();

            if(Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo))
            {
                // faire des trucs avec la collision detectin
                //Debug.Log("hit");
                Debug.Log(hitInfo.collider.name);
                //cree un gameoblet a partir d'un prefab
                ParticleSystem collisionExplosion = Instantiate(collisionExplosionPrefab, hitInfo.point, Quaternion.identity);
                collisionExplosion.transform.LookAt(hitInfo.normal);

                //Destroy(hitInfo.collider.gameObject);
                Destroy(hitInfo.transform.gameObject);
            }
        }
    }
}
