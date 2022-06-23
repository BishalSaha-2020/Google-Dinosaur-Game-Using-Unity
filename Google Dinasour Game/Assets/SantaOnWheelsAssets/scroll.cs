using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public Material material;
    public float xVel=0.1f;
    Vector2 offset;

    // Start is called before the first frame update
    void Start()
    {
        material=GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset=new Vector2();
        material.mainTextureOffset +=offset*Time.deltaTime;
    }
}
