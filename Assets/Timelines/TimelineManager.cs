using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class TimelineManager : MonoBehaviour
{
    public static TimelineManager Instance = null;

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

    public IEnumerator PlayTimeline(int zone)
    {
        CharacterFlag character = GameManager.Instance.character;
        string timeLineFunction = string.Format("T_{0}_Z_{1}", ((int)character).ToString(), zone+1);
        
        Debug.Log("Starting timeline: " + timeLineFunction);
        yield return StartCoroutine(timeLineFunction);
    }
}
