using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCtrl : MonoBehaviour
{

    public ParticleSystem muzzleFlash;
    public ParticleSystem collisionExplosionPrefab;  //on ajoute prefab à la fin
    public float gizmoLength;
    private Transform _transform; //anciennement myTransform, c'est juste une question de convention,
    private RaycastHit _hitInfo;
    private bool _isHit;








    void Start() 
    {
        _transform = transform;
    }






    private void Update()
    {
        _isHit = Physics.Raycast(_transform.position, _transform.forward, out _hitInfo);

        if(Input.GetMouseButtonDown(0))   //zéro c'est le bouton gauche
        {
            muzzleFlash.Play();

            if(_isHit)
            {
                ParticleSystem collisionExplosion = Instantiate(collisionExplosionPrefab, _hitInfo.point, Quaternion.identity);
                collisionExplosion.transform.rotation = Quaternion.LookRotation(_hitInfo.normal);
                
                Destroy(collisionExplosion.gameObject, 1f); // le 1f c'est le timer avant distroy des particules "doublons" qui apparaissent dans le script
            }

          
        }
    }

    private void OnDrawGizmos() 
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(_hitInfo.point, _hitInfo.point + _hitInfo.normal * gizmoLength);  // aides visuelles dans le jeux
    }
}
