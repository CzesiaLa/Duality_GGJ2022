using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public Camera cam;
    Color white = Color.white;
    Color black = Color.black;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cam.backgroundColor == black)
            sr.color = white;
        else
            sr.color = black;
    }
}
