using UnityEngine;

public class CanReturned : MonoBehaviour
{
    [SerializeField]
    float timeDelete = 4f;
    float currentTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > timeDelete)
        {
            currentTime = 0;
            CanPool.instance.PushObject(gameObject);
        }
    }
}
