using Screens;
using System.Collections.Generic;
using UnityEngine;
public class ScreenController : MonoBehaviour
{
    private Stack<ScreenName> screensStack;
    private ScreenName currentScreenId = ScreenName.NONE, lastScreenId;
    private Dictionary<ScreenName, screen> screensCollection;
    public static ScreenController intance;
    public ScreenName startingScreen;//set this value from inspector
    private void Awake()
    {
        intance = this;
    }
    public void Start()
    {

        screensStack = new Stack<ScreenName>();
        screensCollection = new Dictionary<ScreenName, screen>();
        LoadScreens();
        Show(startingScreen);


    }
    private void LoadScreens()
    {
        screen[] s = this.GetComponentsInChildren<screen>(true);
        foreach (screen screen in s)
        {
            screen.Initialize(this);
            screensCollection.Add(screen.ScreenID, screen);
            screen.gameObject.SetActive(false);
        }

    }

    public void Show(ScreenName id, object data = null, bool iscomingfromBack = false)
    {

        if (currentScreenId == id) return;
        lastScreenId = currentScreenId;
        screensCollection[id].Show(data);
        if (!iscomingfromBack)
            screensStack.Push(lastScreenId);
        currentScreenId = id;
        SoundManager.instance.playClick();
        Hide();
    }

    void Hide()
    {
        if (lastScreenId == ScreenName.NONE) return;
        screensCollection[lastScreenId].Hide();

    }
    void Update()
    {
        // Make sure user is on Android platform
        if (Application.platform == RuntimePlatform.Android)
        {

            // Check if Back was pressed this frame

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (currentScreenId == ScreenName.HOME) return;
                Back();
            }
        }
        // Check if Back was pressed this frame
        if (Input.GetKeyDown(KeyCode.Escape) && Application.isEditor)
        {
            if (currentScreenId == ScreenName.HOME) return;
            Debug.Log("back");
            Back();
        }
    }






    public void Back(object data = null)
    {
        if (currentScreenId == ScreenName.LOBBY) return;
        if (screensStack.Count == 0) return;
        ScreenName screen = screensStack.Pop();
        Show(screen, data, true);
    }
}
public enum ScreenName
{
    NONE,
    HOME,
    LOBBY,
    PROFILE,
    SETTINGS,
    MATCHMAKING,
    PRIVATE,
    REGISTERTION,
    SPLASH,
    LOGIN,
    GAME,
    MORE,
    PRIVACY,
    TERMS_AND_CONDITONS,
    FAQ,
}