using UnityEngine;

public class EndGameManager : MonoBehaviour
{

    private GameObject[] enemies;
    private bool hasWon = false;

    public int countEnemy = 0;
    public Stats stats;
    public Canvas winCanvas;
    public Canvas loseCanvas;

    void Start()
    {
        winCanvas.gameObject.SetActive(false);
        loseCanvas.gameObject.SetActive(false);
    }


    void Update()
    {
        if (!hasWon)
        {
            enemies = GameObject.FindGameObjectsWithTag("Enemy");

            countEnemy = enemies.Length;

            if (countEnemy == 0)
            {
                winCanvas.gameObject.SetActive(true);
                hasWon = true;
            }
        }

        if(stats.currentHealth <= 0)
        {
            loseCanvas.gameObject.SetActive(true);
        }
    }
}
