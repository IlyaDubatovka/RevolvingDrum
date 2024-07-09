
using UnityEngine;
using Random = UnityEngine.Random;


public class ColorRandomazer : MonoBehaviour
{
    private void Awake()
    {
        Renderer renderer = GetComponent<Renderer>();
        var randomColor = Random.ColorHSV();
        renderer.material.color = randomColor;
    }
}
