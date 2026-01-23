using UnityEngine;
using System.Collections.Generic;
public class CanPool : MonoBehaviour
{
    public static CanPool instance;

    [SerializeField] GameObject prefabs;

    [SerializeField] int maxElements;

    Stack<GameObject> pool = new Stack<GameObject>();

    
    void Awake()
    {
        if (CanPool.instance == null)
        {
            CanPool.instance = this;
        }
        else
        {
            Destroy(this);
        }

        for (int i = 0; i < maxElements; i++)
        {
            GameObject lata = Instantiate(prefabs);
            lata.SetActive(false);
            pool.Push(lata); //En estas piscina meteremos la lata.
        }
    }

    public GameObject PopObject()
    {
        GameObject objectToReturn = null;
        if (pool.Count != 0)
        {
            objectToReturn = pool.Pop();
        }
        else
        {
            objectToReturn = Instantiate(prefabs);
            objectToReturn.SetActive(false);
        }
        return objectToReturn;
    }

    public void PushObject(GameObject obj)
    {
        obj.SetActive(false);
        pool.Push(obj);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
