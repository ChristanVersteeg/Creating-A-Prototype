using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Bonfire_L7 : MonoBehaviour
{
	//Lifetime of the fire
	public float lifeTime = 15;
	//Heat transfer
	public float heatPower = 0.1f;
 
	// Each frame the bonfire gradually fades, then disappears from the scene
	void Update()
	{
		lifeTime -= Time.deltaTime;
		if (lifeTime <= 0)
		{
			gameObject.SetActive(false);
		}
	}
 
	void OnTriggerStay(Collider other)
	{
		if (other.GetComponent<Temperature_L7>() != null)
		{
            Temperature_L7 temperature = other.GetComponent<Temperature_L7>();
			// If the player's body temperature is less than normal, then we warm him up
			if (temperature.temperatureCurrent < temperature.temperatureNormal)
			{
				temperature.temperatureCurrent += heatPower * Time.deltaTime;
			}
		}
	}
}