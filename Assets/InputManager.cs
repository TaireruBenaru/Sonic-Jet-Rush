using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public bool confirmButton, upButton, downButton;

    public static InputManager Instance = null;

    void Awake()
    {
        if (Instance != null) // meaning there's already an instance
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        confirmButton = Input.GetKeyUp(KeyCode.Z);
        //UpButton = Input.GetKeyDown(KeyCode.);
        //DownButton = Input.GetKeyDown(KeyCode.S);
    }
}
