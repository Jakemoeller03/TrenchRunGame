using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 35f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
