using UnityEngine;

public class ChangeColorOnClick : MonoBehaviour
{
    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            camera.backgroundColor = Color.cyan;
        }
        if (Input.GetMouseButtonUp(0))
        {
            camera.backgroundColor = Color.black;
        }
    }
}