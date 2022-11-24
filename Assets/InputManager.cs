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

        aButton = Input.GetKeyUp(KeyCode.Z);
        bButton = Input.GetKeyUp(KeyCode.X);

        lButton = Input.GetKeyUp(KeyCode.A);
        rButton = Input.GetKeyUp(KeyCode.S);

        startButton = Input.GetKeyUp(KeyCode.Return);
        selectButton = Input.GetKeyUp(KeyCode.Space);
    }
}
