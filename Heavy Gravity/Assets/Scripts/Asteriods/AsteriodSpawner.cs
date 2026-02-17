using UnityEngine;

public class AsteriodSpawner : MonoBehaviour
{
    [SerializeField] private float maxTime = 1.5f;
    [SerializeField] private float heightRange = 0.55f;
    [SerializeField] GameObject asteriods;
    private float timer;

    void Start()
    {
        SpawnAsteriod();
    }

    void Update()
    {
        if(timer > maxTime)
        {
            SpawnAsteriod();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    void SpawnAsteriod()
    {
        Vector3 spawnPos = transform.position + new Vector3(0,Random.Range(-heightRange,heightRange));
        GameObject asteriod = Instantiate(asteriods,spawnPos,Quaternion.identity);

        Destroy(asteriod, 10f);
    }
}
