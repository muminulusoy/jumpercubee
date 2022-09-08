using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GroundSpawner : MonoBehaviour
{
    private GameObject ground ;
    [SerializeField]private ObjectPool objectPool ;
    private Transform tr;
    
    //public int poolSize;
    public float groundWidth;
    public float maxY, miny;
    

    public void Start()
    {
    }

    public void SpawnGround()
    {
        Debug.Log(objectPool.GetPooledObject());
        StartCoroutine(Delay());
        IEnumerator Delay()
        {
            yield return new WaitForSeconds(1f);
            
            ground = objectPool.GetPooledObject();
            tr = ground.GetComponent<Transform>();
        
        
            Vector3 spawnPosition = new Vector3();
            Vector2 newScale = new Vector2();

            newScale.x = Random.Range(1.1f, 1.5f);
            newScale.y = Random.Range(1.1f, 1.5f);
            tr.localScale = newScale;

            spawnPosition.y += Random.Range(miny, maxY);
            spawnPosition.x = Random.Range(-groundWidth,groundWidth);
        }
        
        
        /*for (int i = 0; i < groundNumber; i++)
        {
            newScale.x = Random.Range(1.1f, 1.5f);
            newScale.y = Random.Range(1.1f, 1.5f);
            tr.localScale = newScale;

            spawnPosition.y += Random.Range(miny, maxY);
            spawnPosition.x = Random.Range(-groundWidth,groundWidth);
            
            //ground.SetActive(true);
            //Instantiate(ground, spawnPosition, Quaternion.identity);
        }*/
    }
    
}
