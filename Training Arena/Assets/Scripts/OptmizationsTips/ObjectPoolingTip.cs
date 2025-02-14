using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolingTip : MonoBehaviour
{
    // how to spawn objects withtout using much power of processing
    // instantiate is not good
    // Firts thing is create different pools
    // the best form for create pools is using a dictionary

    [System.Serializable]
    public class Pool
    {
        public string tag;
        public GameObject prefab;
        public int size; // this is the number of objects that can exist in scene
    }

    
    public List<Pool> pools; // we need to create a list of pools
    public Dictionary<string, Queue<GameObject>> poolDictionary; // we need a dictionary to store the pools and a queue to store the objects
    
    #region Singleton
    public static ObjectPoolingTip Instance;

    private void Awake()
    {
        Instance = this;
    }
    #endregion

    private void Start()
    {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();

        foreach(Pool pool in pools)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();

            for (int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                objectPool.Enqueue(obj);
            }

            poolDictionary.Add(pool.tag, objectPool);
        }
    }

    public GameObject SpawnFromPool(string tag, Vector3 position, Quaternion rotation)
    {

        if (!poolDictionary.ContainsKey(tag))
        {
            Debug.LogWarning("Pool with tag " + tag + " doesn't exist.");
            return null;
        }

        GameObject objectToSpawn = poolDictionary[tag].Dequeue();
        objectToSpawn.SetActive(true);
        objectToSpawn.transform.position = position;
        objectToSpawn.transform.rotation = rotation;

        /*
          IPooledObject pooledObj = objectToSpawn.GetCoponent<IPooledObject>();
         
        if(pooledObj != null)
        {
            pooledObj.OnObjectSpawn();
        }
         */
        poolDictionary[tag].Enqueue(objectToSpawn);

        return objectToSpawn;
    }

    // for sapwn objects we will call ObjectPoolingTip.Instance.SpawnFromPool("tag", position, rotation);
    // its good create a variable for the instance
    // ObjectPoolingTip objectPoolingTip;
    // start()
    // objectPoolingTip = ObjectPoolingTip.Instance;

    // after this we need to create a interface for the object that we want to pool
    // public interface IPooledObject
    // void OnObjectSpawn();

    // on cube object we insert the interface
    // public void onObjectSpawn()
    
    // we jave some assets that make object pools

}
