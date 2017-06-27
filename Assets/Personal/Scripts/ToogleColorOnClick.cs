using UnityEngine;
using HoloToolkit.Unity.InputModule;
using Random = UnityEngine.Random;

public class ToogleColorOnClick : MonoBehaviour, IInputClickHandler
{
    private MeshRenderer _meshRenderer;
    void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        SetCubeColor();
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        SetCubeColor();
    }

    private void SetCubeColor()
    {
        _meshRenderer.material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
    }
}
