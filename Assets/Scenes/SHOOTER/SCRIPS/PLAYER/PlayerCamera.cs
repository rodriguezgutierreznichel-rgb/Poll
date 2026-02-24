using Unity.Mathematics;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public float sensibilidad = 100;

    float rotacionHorizontal = 0;
    float rotacionVertical = 0;

    public Transform player;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float ValorX = Input.GetAxis("Mouse X") * sensibilidad * Time.deltaTime;
        float ValorY = Input.GetAxis("Mouse Y") * sensibilidad * Time.deltaTime;

        rotacionHorizontal += ValorX;
        rotacionVertical -= ValorY;

        rotacionVertical = math.clamp(rotacionVertical, -90, 90);

        transform.localRotation = Quaternion.Euler(rotacionVertical, 0, 0);

        player.Rotate(Vector3.up * ValorX);
    }
}
