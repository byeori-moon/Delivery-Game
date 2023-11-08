using System.Collections;
using UnityEngine;

public class TrafficLightController : MonoBehaviour
{
    public bool isRedLight;
    public Color redEmissionColor;
    public Color greenEmissionColor;
    public Material greenMaterial;
    public Material redMaterial;

    public float signalDuration = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        redEmissionColor = redMaterial.GetColor("_EmissionColor");
        greenEmissionColor = greenMaterial.GetColor("_EmissionColor");
        StartCoroutine(ControlTrafficLights());
    }

    IEnumerator ControlTrafficLights()
    {

        while (true) // 무한 루프로 계속 신호등을 제어
        {
            // 빨간색 신호
            SetEmissionColor(redMaterial, redEmissionColor);
            greenMaterial.DisableKeyword("_EMISSION");
            isRedLight = true;
            Debug.Log("red");
            yield return new WaitForSeconds(signalDuration);

            // 초록색 신호
            SetEmissionColor(greenMaterial, greenEmissionColor);
            redMaterial.DisableKeyword("_EMISSION");
            isRedLight = false;
            Debug.Log("green");
            yield return new WaitForSeconds(signalDuration);

        }
    }

    void SetEmissionColor(Material mat, Color color)
    {
        mat.EnableKeyword("_EMISSION");
        mat.SetColor("_EmissionColor", color);
    }
}