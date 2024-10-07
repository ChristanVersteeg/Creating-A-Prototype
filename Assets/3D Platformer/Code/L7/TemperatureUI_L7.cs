using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
 
public class TemperatureUI_L7 : MonoBehaviour
{
	public Temperature_L7 temperature;
	public TextMeshProUGUI temperatureText;
 
	void Update()
	{
		float roundTemperature = Mathf.Round(temperature.temperatureCurrent * 10.0f) * 0.1f;
		temperatureText.text = roundTemperature.ToString();
	}
}