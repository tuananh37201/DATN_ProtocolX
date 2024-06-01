using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatTestDummy : MonoBehaviour, IDamageable
{
    [SerializeField] private GameObject hitParticles;

    public float maxHealth = 100.0f;
    private float currentHealth;
    private Animator anim;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void Damage(float amount)
    {
        Debug.Log(amount + " Damage taken");

        Instantiate(hitParticles, transform.position, Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));

        anim.SetTrigger("damage");

        currentHealth -= amount;
        
        if(currentHealth <= 0){
            Destroy(gameObject);
        }

    }

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
}
