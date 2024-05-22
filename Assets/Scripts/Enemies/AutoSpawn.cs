using UnityEngine;

public class AutoSpawn : MonoBehaviour
{
    public GameObject[] enemies;
    public Transform[] spawnPoints;

    void Start()
    {
        foreach (Transform spawnPoint in spawnPoints) 
        { 
            int randomIndex = Random.Range(0, enemies.Length); 
            GameObject enemy = Instantiate(enemies[randomIndex], spawnPoint.position, Quaternion.identity); 
            enemy.transform.SetParent(spawnPoint);
        }
    }
}