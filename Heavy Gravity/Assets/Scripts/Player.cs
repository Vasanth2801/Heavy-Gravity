using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [Header("SpaceShip Settings")]
    [SerializeField] private float velocity = 1.5f;
    [SerializeField] private float rotationSpeed = 10f;

    [Header("References")]
    [SerializeField] private Rigidbody2D rb;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = Vector2.up * velocity;
        }
    }

    void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0,0,rb.linearVelocity.y *  rotationSpeed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(1);
    }
}