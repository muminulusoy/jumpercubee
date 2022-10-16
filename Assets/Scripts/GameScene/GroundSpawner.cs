using UnityEngine;
using Random = UnityEngine.Random;

public class GroundSpawner : MonoBehaviour
{
    private GameObject ground;
    [SerializeField] private GameObject deathGround;
    [SerializeField] private ObjectPool objectPool;
    private Transform tr;
    private Vector3 spawnPosition;
    private Vector3 deathPosition;
    public static Vector3 higherPlatform;

    public float groundWidth;
    public float maxY, miny;


    private void Start()
    {
        SpawnGround();
    }

    private void Awake()
    {
        Groundds.TriggerPointSpawn = SpawnTopGround;
    }

    private void SpawnGround()
    {
        for (int i = 0; i < objectPool.pooledObjects.Count; i++)
        {
            ground = objectPool.GetPooledObject();
            tr = ground.transform;
            tr.position = spawnPosition;
            Vector2 newScale = new Vector2();
        
            newScale.x = Random.Range(1.1f, 1.5f);
            newScale.y = Random.Range(1.1f, 1.5f);
            tr.localScale = newScale;

            spawnPosition.y += Random.Range(miny, maxY);
            spawnPosition.x = Random.Range(-groundWidth, groundWidth);
            
        }

        higherPlatform = spawnPosition;
    }

    private void SpawnTopGround()
    {
        float y;
        
        ground = objectPool.GetPooledObject();
        tr = ground.transform;
        tr.position = spawnPosition;
        Vector2 newScale = new Vector2();
        
        newScale.x = Random.Range(1.1f, 1.5f);
        newScale.y = Random.Range(1.1f, 1.5f);
        tr.localScale = newScale;
        
        y = Random.Range(miny, maxY);
        spawnPosition.y += y;
        spawnPosition.x = Random.Range(-groundWidth, groundWidth);
        SetDeathGround(y);
    }
    
    private void SetDeathGround(float y)
    {
        deathGround.transform.position = new Vector3(deathGround.transform.position.x, deathGround.transform.position.y + y, 0);
    }    
}