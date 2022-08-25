using UnityEngine;

public class spawnningObstacles : MonoBehaviour
{
    [SerializeField] private GameObject obstacle;
    [SerializeField] private float spawnDelay;

    void Start()
    {
        InvokeRepeating("SpawnBall", spawnDelay, spawnDelay);
    }

    void SpawnBall()
    {
        var newBall = GameObject.Instantiate(obstacle);
    }

}
