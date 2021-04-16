using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiMove : MonoBehaviour
{

    public Transform player;
    public float speed;
    private Transform _transform;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
        _transform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = new Vector3(player.position .x, _transform.position.y, player.position.z);
        _transform.LookAt(target);
        _transform.position += _transform.forward * Time.deltaTime * speed;
    }
}
