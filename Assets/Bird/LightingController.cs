using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingController : MonoBehaviour
{
    public GameObject player;
    public Material skybox;
    public Material spookySkybox;
    public GameObject light;
    public GameObject spookyLight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.z > 15.0)
        {
            RenderSettings.fogColor = new Color(0.3964934f, 0.4398963f, 0.7075472f, 1.0f);
            RenderSettings.skybox = spookySkybox;
            light.SetActive(false);
            spookyLight.SetActive(true);
        } 
        else
        {
            RenderSettings.fogColor = new Color(0.4862745f, 0.6941177f, 0.8117647f, 1.0f);
            RenderSettings.skybox = skybox;
            light.SetActive(true);
            spookyLight.SetActive(false);
        }
    }
}
