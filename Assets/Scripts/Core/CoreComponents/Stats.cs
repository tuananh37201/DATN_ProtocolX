using System;
using TMPro;
using UnityEngine;

public class Stats : CoreComponent
{
    public event Action OnHealthZero;

    [SerializeField] private float maxHealth;
    public float currentHealth;

    public TMP_Text healthText;

    protected override void Awake()
    {
        base.Awake();

        currentHealth = maxHealth;
    }

    public void DecreaseHealth(float amount)
    {
        currentHealth -= amount;
        
        int dashes = Mathf.FloorToInt(currentHealth / (maxHealth / 10));
        string healthString = new string('-', dashes);
        healthText.text = healthString;

        if (currentHealth <= 0)
        {
            currentHealth = 0;

            OnHealthZero?.Invoke();

            Debug.Log("Health is zero!!");
        }
    }

    public void IncreaseHealth(float amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
    }
}