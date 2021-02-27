using UnityEngine;
using System.Collections;

// Referências:
//      1. https://www.youtube.com/watch?v=32EIYs6Z18Q
//      2. https://www.youtube.com/watch?v=HrDxnMI7pCc

public class BackgroundScroll : MonoBehaviour
{
    public float speed = 0.2f;
    public Renderer r;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        r.material.mainTextureOffset += new Vector2(0, speed) * Time.deltaTime;
    }
}