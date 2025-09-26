using UnityEngine;
using UnityEngine.SceneManagement;
public class ShipMover : MonoBehaviour
{
    CharacterController characterController;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        Vector3 tempMovement = Vector3.zero;
        if (Input.GetKey(KeyCode.A))
        {
            tempMovement -= new Vector3(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            tempMovement += new Vector3(0, 0, 1);
        }
        tempMovement = tempMovement.normalized;

        GetComponent<CharacterController>().Move(tempMovement * 4 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Obstacle"))
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
}
