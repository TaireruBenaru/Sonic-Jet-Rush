using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class EventManager
{
    public IEnumerator S1_B_Z1_A1()
    {
        textbox.ChangeBustup(BustupNames.SONIC_SMUG, SpeakerSide.LEFT);
        textbox.ChangeBustup(BustupNames.TAILS_NORMAL, SpeakerSide.RIGHT);
        yield return StartCoroutine(textbox.SlideBustup(true, SpeakerSide.LEFT));
        
        textbox.ShowFletch(SpeakerSide.LEFT, true);

        yield return StartCoroutine(textbox.PushMessage(MessageNames.SONIC, "Aw, yeah!\nI missed riding on the Tornado!", true));
        textbox.ShowFletch(SpeakerSide.LEFT, false);

        yield return StartCoroutine(textbox.SlideBustup(true, SpeakerSide.RIGHT));
        textbox.ShowFletch(SpeakerSide.RIGHT, true);

        yield return StartCoroutine(textbox.PushMessage(MessageNames.TAILS, "True, It has been a while, but we don't have time to relax today.", true));
        textbox.ShowFletch(SpeakerSide.RIGHT, false);

        textbox.ChangeBustup(BustupNames.SONIC_SHRUG, SpeakerSide.LEFT);
        textbox.ShowFletch(SpeakerSide.LEFT, true);

        yield return StartCoroutine(textbox.PushMessage(MessageNames.SONIC, "Yeah, yeah.", true));
        yield return StartCoroutine(textbox.PushMessage(MessageNames.SONIC, "You tracked the Chaos Emeralds here, right?", true));
        textbox.ShowFletch(SpeakerSide.LEFT, false);

        textbox.ShowFletch(SpeakerSide.RIGHT, true);
        yield return StartCoroutine(textbox.PushMessage(MessageNames.TAILS, "Yep, should be somewhere around here!", true));
        textbox.ShowFletch(SpeakerSide.RIGHT, false);

        textbox.ChangeBustup(BustupNames.SONIC_SMUG, SpeakerSide.LEFT);
        textbox.ShowFletch(SpeakerSide.LEFT, true);

        yield return StartCoroutine(textbox.PushMessage(MessageNames.SONIC, "I'll go on ahead and take a look!\nSee you down there, Tails!", true));
        textbox.ShowFletch(SpeakerSide.LEFT, false);
        StartCoroutine(textbox.SlideBustup(false, SpeakerSide.LEFT));

        textbox.ChangeBustup(BustupNames.TAILS_SAD, SpeakerSide.RIGHT);
        textbox.ShowFletch(SpeakerSide.RIGHT, true);
        yield return StartCoroutine(textbox.PushMessage(MessageNames.TAILS, "Wait up! Sonic! ", true));
        textbox.ShowFletch(SpeakerSide.RIGHT, false);
        yield return StartCoroutine(textbox.SlideBustup(false, SpeakerSide.RIGHT));
        textbox.ToggleTextbox(false);

        yield return null;
    }
}
