using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        transform.localScale = new Vector3(1.1f, 1.1f, 1);
        if (Input.GetMouseButtonDown(0))
        {
            Application.Quit();
        }
    }

    private void OnMouseExit()
    {
        transform.localScale = new Vector3(1, 1, 1);
    }
}
