using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AutoScroller : MonoBehaviour
{
    public float scrollerSpeed= 0.5f;
    [SerializeField] private MeshRenderer mesh;
    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(0, Time.time*scrollerSpeed);
        mesh.material.mainTextureOffset= offset;
    }
}