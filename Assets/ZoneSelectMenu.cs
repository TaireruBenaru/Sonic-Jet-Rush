using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ZoneSelectMenu : MonoBehaviour
{
    int Selection;

    public GameObject[] zoneCardObjects;
    public ZoneCard[] zoneCards;
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
            zoneCardObjects[i] = Instantiate(cardPrefab, GameObject.Find("ZoneCards").transform);
            zoneCardObjects[i].transform.localPosition = new Vector3(0, cardYPositions[i]);
            
            zoneCards[i] = zoneCardObjects[i].GetComponent<ZoneCard>();

            zoneCards[i].cardText.text =  GameManager.zoneNames[(int)GameManager.Instance.unlockedZones[i]] + " Zone";

            switch(GameManager.Instance.unlockedZones[i])
            {
                default:
                    zoneCards[i].bgText.text = "Zone " + i.ToString();
                break;
                case ZoneAccessFlag.NULL:
                    zoneCards[i].bgText.text = "X-Zone";
                break;
                case ZoneAccessFlag.UNDEFINED:
                    zoneCards[i].bgText.text = "Extra";
                break;
                case ZoneAccessFlag.SPECIALSTAGE:
                    zoneCards[i].bgText.text = "Special";
                break;
            }
            
        }
    }

    IEnumerator MainRoutine()
    {
        bool InMenu = true;

        while(InMenu)
        {
            
            yield return null;
        }
        yield return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
