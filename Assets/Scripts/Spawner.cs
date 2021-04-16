using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<Transform> spawnPositions = null;
    public float spawnPeriod;
    public GameObject enemiPrefab = null;


    private float _nextSpawnTime;





    // Start is called before the first frame update
    void Start()
    {
        _nextSpawnTime = 0f;
    }





    // Update is called once per frame
    void Update()
    {
        if(Time.time >= _nextSpawnTime)
        {
            //apparition d'ennemis
            SpawnEnemy();
            _nextSpawnTime = Time.time + spawnPeriod;
        }
    }


    private void SpawnEnemy()  //void est le type de retour de la methode, ca pourrait être bool ou int ou float, mais alors il faut un return
        // methode sans retour = procedure
        // methode avec retour = fonction
    {
        //Apparition d'un Enemy à la position Vector3
        Vector3 randomPosition = spawnPositions[Random.Range(0, spawnPositions.Count)].position + new Vector3(0, 1, 0);
        //Instantiate(enemiPrefab, randomPosition, Quaternion.identity);   //marchait deja tres bien
        GameObject enemy = Instantiate(enemiPrefab, randomPosition, Quaternion.identity);
       
  
    }
}
