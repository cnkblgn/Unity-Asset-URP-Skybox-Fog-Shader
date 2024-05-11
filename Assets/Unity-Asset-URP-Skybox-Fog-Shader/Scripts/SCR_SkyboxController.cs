using UnityEngine;

public class SCR_SkyboxController : MonoBehaviour
{
    [field: Header("_")]
    [field: SerializeField] private Material skyboxFogMaterial = null;

    [field: Space(10), Header("_")]
    [field: SerializeField] private Material skyboxDefaultMaterial = null;

    private Material skyboxCurrentMaterial = null;

    private void Start() => skyboxCurrentMaterial = skyboxFogMaterial;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            skyboxCurrentMaterial = skyboxFogMaterial;
            UpdateSkybox();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            skyboxCurrentMaterial = skyboxDefaultMaterial;
            UpdateSkybox();
        }
    }
    private void UpdateSkybox()
    {
        RenderSettings.skybox = skyboxCurrentMaterial;
        DynamicGI.UpdateEnvironment();
    }
}