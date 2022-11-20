using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class TextboxManager : MonoBehaviour
{
    public MeshRenderer nameboxRenderer;
    public TextMeshPro nameboxText;

    public TextMeshPro messageText;
    public MeshRenderer messageBox;

    public SpriteRenderer[] bustupRenderer;
    public Sprite[] bustupImages;

    public SpriteRenderer[] fletchRenderer;

    public SpriteRenderer advancePrompt;

    public SpriteRenderer textboxRenderer;
    
    public static float charWaitTime = 0.025f;

    public bool isFinished;

    public string[] names;

    public static TextboxManager Instance = null;

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
    IEnumerator Start()
    {
        textboxRenderer = GetComponent<SpriteRenderer>();
        yield return StartCoroutine(DialogueTest());
    }

    IEnumerator DialogueTest()
    {
        yield return new WaitForSeconds(2f);

        ChangeBustup(BustupNames.SONIC_NORMAL, SpeakerSide.LEFT);
        ChangeBustup(BustupNames.SONIC_NORMAL, SpeakerSide.RIGHT);

        StartCoroutine(SlideBustup(true, SpeakerSide.LEFT));
        ShowFletch(SpeakerSide.LEFT, true);

        yield return StartCoroutine(SlideBustup(true, SpeakerSide.RIGHT));

        yield return StartCoroutine(PushMessage(MessageNames.SONIC, "Hi Tails.", true));

        ChangeBustup(BustupNames.SONIC_ANGRY, SpeakerSide.RIGHT);
        ShowFletch(SpeakerSide.LEFT, false);
        ShowFletch(SpeakerSide.RIGHT, true);

        yield return StartCoroutine(PushMessage(MessageNames.TAILS, "Hi Sonic!!!!!!!!\nThis is...", true));

        ChangeBustup(BustupNames.SONIC_SMUG, SpeakerSide.LEFT);
        ChangeBustup(BustupNames.SONIC_SMUG, SpeakerSide.RIGHT);
        ShowFletch(SpeakerSide.LEFT, true);

        yield return StartCoroutine(PushMessage(MessageNames.SONICANDTAILS, "Sonic Rush!!", true));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator PushMessage(MessageNames name, string message, bool wait)
    {
        messageBox.enabled = false;
        nameboxRenderer.enabled = false;

        nameboxText.text = names[(int)name];
        
        messageText.text = message; 
        messageText.ForceMeshUpdate();

        int maxIndex = messageText.textInfo.characterCount+1;
        int index = 0;

        textboxRenderer.enabled = true;
        messageBox.enabled = true;
        nameboxRenderer.enabled = true;

        while (index < maxIndex)
        {
            messageText.maxVisibleCharacters = index;
            index++;
            yield return new WaitForSeconds(charWaitTime);
        }
        
        if(wait)
        {
            advancePrompt.enabled = true;
            yield return new WaitUntil(() => InputManager.Instance.confirmButton);
            advancePrompt.enabled = false;
        }
        else
        {
            yield return new WaitForSeconds(0.5f);
        }

        yield return null;
    }

    IEnumerator SlideBustup(bool slideIn, SpeakerSide side)
    {
        float[] inPos = new float[] { -5f, 5f };
        float[] outPos = new float[] { -15f, 15f };

        if(slideIn)
        {
            bustupRenderer[(int)side].gameObject.transform.DOMoveX(inPos[(int)side], 0.2f);
        }
        else
        {
            bustupRenderer[(int)side].gameObject.transform.DOMoveX(outPos[(int)side], 0.2f);
        }

        yield return new WaitForSeconds(0.3f);
    }

    void ChangeBustup(BustupNames bustup, SpeakerSide side)
    {
        bustupRenderer[(int)side].sprite = bustupImages[(int)bustup];
    }
 
    void ShowFletch(SpeakerSide side, bool show)
    {
        fletchRenderer[(int)side].enabled = show;
    }
}

public enum MessageNames
{
    NONE,
    SONIC,
    TAILS,
    SURGE,
    AMY,
    EGGMAN,
    SONICANDTAILS,
}

public enum BustupNames
{
    SONIC_SMUG,
    SONIC_ANGRY,
    SONIC_SHRUG,
    SONIC_NORMAL,
}

public enum SpeakerSide
{
    LEFT,
    RIGHT,
    MIDDLE
}

