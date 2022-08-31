using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{

    [SerializeField] int currentHealth;
    [SerializeField] int maxHealth;

    public HealthBar healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        ScoreManager.Instance.ScoreDown(ScoreManager.Instance.Damagane);
        healthBar.SetHealt(currentHealth);

    }
}