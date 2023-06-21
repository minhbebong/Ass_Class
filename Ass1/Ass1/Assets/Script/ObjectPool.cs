using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject objectPrefab;

    private List<GameObject> poolObject = new List<GameObject>();
    [SerializeField] private int amountInPool;

    // Start is called before the first frame update
    void Start()
    {
        MakePool(objectPrefab);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public GameObject GetPoolObject()
    {
        for (int i = 0; i < poolObject.Count; i++)
        {
            if (!poolObject[i].activeInHierarchy)
            {
                return poolObject[i];
                
            }
        }
        return null;
    }
    public void MakePool(GameObject objectToPool)
    {
        for (int i = 0; i < amountInPool; i++)
        {
            GameObject obj = Instantiate(objectToPool);
            obj.transform.SetParent(gameObject.transform);
            obj.SetActive(false);
            poolObject.Add(obj);
        }
    }

}