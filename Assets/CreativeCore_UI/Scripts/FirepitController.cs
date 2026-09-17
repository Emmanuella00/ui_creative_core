using UnityEngine;

public class FirepitController : MonoBehaviour
{
    public Light firepitLight;
    public ParticleSystem fireParticles;
    public float fadeSeconds = 1.5f;

    float originalIntensity, fadeFrom, fadeTo, fadeElapsed;
    bool fading;

    void Start()
    {
        if (firepitLight) originalIntensity = firepitLight.intensity;
    }

    // Wire to Fire Toggle's On Value Changed (Boolean), Dynamic bool
    public void ToggleFire(bool isOn)
    {
        if (firepitLight == null) return;

        firepitLight.gameObject.SetActive(true); // stays on while it fades
        fadeFrom = firepitLight.intensity;
        fadeTo = isOn ? originalIntensity : 0f;
        fadeElapsed = 0f;
        fading = true;

        if (isOn) fireParticles?.Play();
        else fireParticles?.Stop(); // existing embers finish their lifetime naturally
    }

    void Update()
    {
        if (!fading) return;
        fadeElapsed += Time.deltaTime;
        float t = Mathf.Clamp01(fadeElapsed / fadeSeconds);
        firepitLight.intensity = Mathf.Lerp(fadeFrom, fadeTo, t);
        if (t >= 1f)
        {
            fading = false;
            if (fadeTo == 0f) firepitLight.gameObject.SetActive(false);
        }
    }
}