using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class EventManager : MonoBehaviour
{
    TextboxManager textbox;

    public static EventManager Instance = null;

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
        textbox = TextboxManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
