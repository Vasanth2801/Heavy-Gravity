using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [Header("Score System")]
    [SerializeField] private int score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;

    public static ScoreManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void AddScore(int amount)
    {
        score += amount;
    }
}