using UnityEngine;

public class PipeScrip : MonoBehaviour
{
    public float speed = 5f; // Speed of the pipe movement
    public float deadZone = -15f; // Height offset for the pipe's vertical position
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * speed * Time.deltaTime);
        //delete pipe if it goes below the dead zone

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
