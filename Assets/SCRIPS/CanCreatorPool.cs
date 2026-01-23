using UnityEngine;

public class CanCreatorPool : MonoBehaviour
{
    [SerializeField]
    float timeSpawn;
    float currentTime;

    [SerializeField]
    GameObject prefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > timeSpawn)
        {
            GameObject lata = CanPool.instance.PopObject();
            lata.transform.position = Vector3.zero;
            lata.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
            lata.SetActive(true);
            currentTime = 0;
        }
    }
}
