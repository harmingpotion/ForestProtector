using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
	public float maxHealth = 100f;
	float currentHealth;

	public GameObject house1;
	public GameObject house2;
	public GameObject house3;

	public Slider healthBar;

	void Start()
	{
		currentHealth = maxHealth;

		// Zorg dat je healthbar goed werkt
		if (healthBar != null)
		{
			healthBar.maxValue = maxHealth;
			healthBar.value = currentHealth;
		}

		UpdateHouse();
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.D))
		{
			TakeDamage(1f);
		}

		if (Input.GetKeyDown(KeyCode.H))
		{
			RebuildHouse(1f);
		}
	}

	public void TakeDamage(float damage)
	{
		currentHealth -= damage;
		currentHealth = Mathf.Max(currentHealth, 0);

		UpdateHouse();
		UpdateHealthBar();

		Debug.Log("Health: " + currentHealth);
	}

	public void RebuildHouse(float amount)
	{
		currentHealth += amount;
		currentHealth = Mathf.Min(currentHealth, maxHealth);

		UpdateHouse();
		UpdateHealthBar();

		Debug.Log("Health: " + currentHealth);
	}

	void UpdateHouse()
	{
		if (currentHealth <= 20)
		{
			house1.SetActive(false);
			house2.SetActive(false);
			house3.SetActive(true);
		}
		else if (currentHealth <= 50)
		{
			house1.SetActive(false);
			house2.SetActive(true);
			house3.SetActive(false);
		}
		else
		{
			house1.SetActive(true);
			house2.SetActive(false);
			house3.SetActive(false);
		}
	}

	void UpdateHealthBar()
	{
		if (healthBar != null)
		{
			healthBar.value = currentHealth;
		}
	}
}