using UnityEngine;

public class BirdScrip : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float flyup = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true)
        {
            rigidbody.linearVelocity = Vector2.up * flyup;
        }
    }
}
