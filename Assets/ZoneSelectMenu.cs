using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneSelectMenu : MonoBehaviour
{
    public GameObject[] zoneCards;
    public float[] cardYPositions;
    public GameObject cardPrefab;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(1f);
        SetupZoneCards();

        yield return null;
    }

    void SetupZoneCards()
    {
        for (int i = 0; i < GameManager.Instance.unlockedZones.Count; i++)
        {
            zoneCards[i] = Instantiate(cardPrefab, GameObject.Find("ZoneCards").transform);
            zoneCards[i].transform.localPosition = new Vector3(0, cardYPositions[i]);
        }
    }

    IEnumerator MainRoutine()
    {
        yield return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
