using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public Queue<GameObject> pooledObjects;
    [SerializeField] private GameObject objectPrefab;
    [SerializeField] private int poolSize;

    public ObjectPool(GameObject objectPrefab,int poolSize)
    {
        this.objectPrefab = objectPrefab;
        this.poolSize = poolSize;
    }

    void Awake()
    {
        Debug.Log("awakeee");
        pooledObjects = new Queue<GameObject>();//yeni bir kuyruk nesnesi oluştur

        for (int i = 0; i < poolSize; i++)//havuzun boyutu kadar nesne oluştur ve kuyruğa ekle
        {
            GameObject obj = Instantiate(objectPrefab);
            obj.SetActive(false);
            
            pooledObjects.Enqueue(obj);
        }
    }

    public GameObject GetPooledObject()
    {
        GameObject obj = pooledObjects.Dequeue();//nesneyi kuyruktan al
        Debug.Log(obj.name);
        obj.SetActive(true);//görünür yap
        
        pooledObjects.Enqueue(obj);//kuyruğa geri sok

        return obj;
    }
    
}
