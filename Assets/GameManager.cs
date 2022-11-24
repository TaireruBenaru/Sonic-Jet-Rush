using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public CharacterFlag Character;
    public int[] Lives = new int[] { 3, 3 };

    public List<ZoneAccessFlag> unlockedZones;
    

    public static List<ZoneAccessFlag> sonicStages = new List<ZoneAccessFlag> 
    {
        ZoneAccessFlag.LEAFCOAST,ZoneAccessFlag.CENTRIUMTURNPIKE,
        ZoneAccessFlag.ICERIDGE,
        ZoneAccessFlag.ETHERPARADISE,
        ZoneAccessFlag.MARINEFLEET,
        ZoneAccessFlag.DOOMSDAYSTATION,
        ZoneAccessFlag.COSMICEGG,
        ZoneAccessFlag.NULL,
        ZoneAccessFlag.SPECIALSTAGE
    };

    public static GameManager Instance = null;

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
        UnlockZone(ZoneAccessFlag.LEAFCOAST);
        UnlockZone(ZoneAccessFlag.SPECIALSTAGE);
        UnlockZone(ZoneAccessFlag.MARINEFLEET);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UnlockZone(ZoneAccessFlag Zone)
    {
        unlockedZones.Add(Zone);
        switch (Character)
        {
            case CharacterFlag.SONIC:
                unlockedZones = unlockedZones.OrderBy(s => sonicStages.IndexOf(s)).ToList();
            break;
        }
    }
}



public enum CharacterFlag
{
    SONIC,
    JET,
    SONICANDJET
}

public enum ChaosEmeraldFlags
{
    Green,
    Yellow,
    Purple,
    Pink,
    Grey,
    Blue,
    Red
}

public enum MiracleEmeraldFlags
{
    Orange,

}

public enum ZoneAccessFlag
{
    LEAFCOAST,
    CENTRIUMTURNPIKE,
    ICERIDGE,
    ETHERPARADISE,
    MARINEFLEET,
    DOOMSDAYSTATION,
    COSMICEGG,
    NULL,
    UNDEFINED,
    SPECIALSTAGE,
}

public enum ActAccessFlag
{
    //Event's before levels
    LASTRESORT, //Opening
    ACT1,
    ACT2,
    VSBOSS,
    //Events after bosses
    SCRAMBLEDEGG,
    
    

}

