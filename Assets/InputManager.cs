using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public bool upButton, rightButton, downButton, leftButton;
    public bool aButton, bButton;
    public bool lButton, rButton;
    public bool startButton, selectButton;

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
        upButton = Input.GetKeyDown(KeyCode.UpArrow);
        rightButton = Input.GetKeyDown(KeyCode.RightArrow);
        downButton = Input.GetKeyDown(KeyCode.DownArrow);
        leftButton = Input.GetKeyDown(KeyCode.LeftArrow);

        aButton = Input.GetKeyDown(KeyCode.Z);
        bButton = Input.GetKeyDown(KeyCode.X);

        lButton = Input.GetKeyDown(KeyCode.A);
        rButton = Input.GetKeyDown(KeyCode.S);

        startButton = Input.GetKeyDown(KeyCode.Return);
        selectButton = Input.GetKeyDown(KeyCode.Space);
    }
}
