using UnityEngine;



public class Health : MonoBehaviour
{
	public float maxHealth = 100f;
	float currentHealth;



	public GameObject house1;
	public GameObject house2;
	public GameObject house3;



	void Start()
	{
		currentHealth = maxHealth;



		house1.SetActive(true);
		house2.SetActive(false);
		house3.SetActive(false);


	}



	public void TakeDamage(float damage)
	{


		currentHealth -= damage;



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



	}
	public void RebuildHouse(float damage)
	{
		currentHealth += damage;



		if (currentHealth >= 20)
		{
			house1.SetActive(false);
			house2.SetActive(false);
			house3.SetActive(true);
		}
		else if (currentHealth >= 50)
		{
			house1.SetActive(false);
			house2.SetActive(true);
			house3.SetActive(false);
		}
		else if (currentHealth >= 100)
		{
			house1.SetActive(true);
			house2.SetActive(false);
			house3.SetActive(false);
		}
	}



}
