using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(Random.Range(10, 20), 4, 1);
        transform.localScale = Vector3.one * 5.2f;
        
        Material material = Renderer.material;
        
        material.color = new Color(1, 1, 2, 3);
    }
    
    void Update()
    {
        transform.Rotate(20.0f * Time.deltaTime * Random.Range(2, 13), 0.0f, 0.0f);
    }
}
