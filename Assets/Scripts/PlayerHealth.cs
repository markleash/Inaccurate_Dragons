using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
	[SerializeField] private GameObject gameOverScreen;
	public int maxHealth = 100;
	public int currentHealth;
	public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
		if (currentHealth <= 0)
		{
			Destroy(gameObject);
			gameOverScreen.SetActive(true);
			

		}
    }

	public void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
		FMODUnity.RuntimeManager.PlayOneShot ("event:/Player/Attack/Damage");
	}

	public void IncreaseHealth(int pickupHealth)
	{
		currentHealth += pickupHealth;
		if (currentHealth >= 100)
		{
			currentHealth = 100;
		}
		healthBar.SetHealth(currentHealth);
		
	}
}
