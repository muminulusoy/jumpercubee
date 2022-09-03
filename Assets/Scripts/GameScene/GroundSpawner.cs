using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class GroundSpawner : MonoBehaviour
{
    public GameObject ground;
    private Transform tr;
    
    public int groundNumber;
    public float groundWidth;
    public float maxY, miny;
    

    public void Start()
    {
        tr = ground.GetComponent<Transform>();
        Vector3 spawnPosition = new Vector3();
        Vector2 newScale = new Vector2();

        for (int i = 0; i < groundNumber; i++)
        {
            newScale.x = Random.Range(1.1f, 1.5f);
            newScale.y = Random.Range(1.1f, 1.5f);
            tr.localScale = newScale;

            spawnPosition.y += Random.Range(miny, maxY);
            spawnPosition.x = Random.Range(-groundWidth,groundWidth);

            Instantiate(ground, spawnPosition, Quaternion.identity);
        }

    }
}
