using UnityEngine;

public class AsteriodsMove : MonoBehaviour
{
    [Header("Speed for the Asteriods")]
    [SerializeField] private float speed = 0.5f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
