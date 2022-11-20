using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public CharacterFlag Character;
    public int[] Lives = new int[] { 3, 3 };
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



public enum CharacterFlag
{
    SONIC,
    JET,
    SONICANDJET
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
    CATHARTICJET,
    SPECIALSTAGE,
}
image.png
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
