// https://answers.unity.com/questions/742466/camp-fire-light-flicker-control.html
using UnityEngine;

namespace Abiogenesis3d
{
    [RequireComponent(typeof(Light))]
    public class LightFlicker : MonoBehaviour
    {
        new Light light;
        [Header("Intensity")]
        public float intensity;
        float nextIntensity;
        [SerializeField, Range(0, 5)] float difference = 1;
        [SerializeField, Range(0.1f, 1)] float maxFrequency = 1f;
        [SerializeField, Range(0.01f, 1)] float minFrequency = 0.1f;
        [SerializeField, Range(0, 20)] float lerpSpeed = 100f;
        float frequency;

        [Header("Position")]
        public Vector3 localPosition;
        [SerializeField, Range(0, 0.1f)] float maxOffset = 0.05f;

        float lastTime;

        void OnEnable()
        {
            light = GetComponent<Light>();
            lastTime = Time.time;
            Store();
        }

        void OnDisable()
        {
            Restore();
        }

        void Store()
        {
            intensity = light.intensity;
            localPosition = transform.localPosition;
        }

        void Restore()
        {
            light.intensity = intensity;
            transform.localPosition = localPosition;
        }

        void Update()
        {
            if (lastTime + frequency < Time.time)
            {
                lastTime = Time.time;
                nextIntensity = Random.Range(intensity -difference, intensity + difference);
                frequency = Random.Range(minFrequency, maxFrequency);

                transform.localPosition = localPosition + new Vector3(
                    Random.Range(-maxOffset, maxOffset),
                    Random.Range(-maxOffset, maxOffset),
                    Random.Range(-maxOffset, maxOffset));
            }
            else
            {
                var diff = Mathf.Sin(Time.time) *0.001f;
                transform.localPosition += Vector3.one * diff;
            }

            light.intensity = Mathf.Lerp(light.intensity, nextIntensity, lerpSpeed * Time.deltaTime);
        }
    }
}
