using UnityEngine;
public class ScoreIncrease : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ScoreManager.instance.AddScore(1);
        }
    }
}