using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class LB_StandardHighScores : MonoBehaviour
{
    // enable this to use the joystick-based input box instead of keyboard
    public bool useJoystickEnterNameBox;

    // enable this to use floats instead of ints
    public bool useFloatScoresInsteadofInts;
       
    [Space (10)]

    // reference to our high score controller gameObject
    public LB_Leaderboard _scoreManager;

    // player name (to be inputted through a text field)
    private string nameInput = "";

    // flag to say whether or not the latest score is a new high score
    private bool newHighScore;

    // our final score from the last game
    private int finalGameScore;

    // UI text
    public Text leaderboardUIText_rank;
    public Text leaderboardUIText_name;
    public Text leaderboardUIText_score;

    [Space(10)]

    // UI player enter name input field Component
    public InputField playerNameInputField;

    // UI player enter name input field Component
    public Text playerNameInputField_Joystick;

    [Space(10)]
    // UI panel for entering player name via keyboard
    public GameObject enterNamePanel;

    // UI panel for entering player name via joystick
    public GameObject enterNamePanel_joystick;

    [Space(10)]

    // reset leaderboard button (to hide or show it)
    public bool showResetButton;
    public GameObject resetButton;

    // --------------------------------------------------------------------
    // SCENE LOADING - you'll need to change these scene names to make the
    // leaderboard buttons go to different scenes than those in the example
    public void GotoMainMenu()
    {
        // load the main menu
        SceneManager.LoadScene("MainMenu");
    }

    public void PlayAgain()
    {
        // load the game scene
        SceneManager.LoadScene("Game");
    }

    // ---------------------------------------------------------------------

    void Start()
    {
        // show or hide the reset leaderboard button (useful for development)
        if (showResetButton)
        {
            resetButton.SetActive(true);
        } else
        {
            resetButton.SetActive(false);
        }

        // first thing we need to do is make sure that the leaderboard is initialized.
        _scoreManager.SetUpScores();

        // when the game ends, it saves the final score into a player pref. we pick up the
        // final score out of the player pref to use here on the game over screen:
        finalGameScore = PlayerPrefs.GetInt("finalScore");

        // did the user get a high score? do they need to enter their name?
        newHighScore = _scoreManager.DidGetHighScore(finalGameScore);

        // a little debug message so we can easily see what's going on in the editor
        Debug.Log(">StandardHighScores.cs>This is a high score? " + newHighScore);

        // before we do anything else, populate the ui text fields
        UpdateUIText();

        // check to see if we need to display the enter name dialog box
        // but also making sure that the score is not zero (we don't want to submit zero scores, right?)
        if(newHighScore && finalGameScore!=0)
        {
            if (useJoystickEnterNameBox)
            {
                ShowEnterNamePanel_Joystick();
                HideEnterNamePanel();
            }
            else
            {
                ShowEnterNamePanel();
                HideEnterNamePanelJoystick();
            }
        } else
        {
            HideEnterNamePanel();
            HideEnterNamePanelJoystick();
        }
    }

    public void ShowEnterNamePanel()
    {
        // as a little touch of polish, we can set the allowed text input length on the enter name text box
        // to match the maximum length of name allowed by the leaderboard.
        playerNameInputField.characterLimit = _scoreManager.maxNameLength;
        
        // do whatever we need to do here to show the enter name panel
        enterNamePanel.SetActive(true);

        // as we display the enter name box, the Select() function gives it focus so the user can just start typing
        // without having to click on it
        playerNameInputField.Select();
    }

    public void ShowEnterNamePanel_Joystick()
    {
        enterNamePanel_joystick.SetActive(true);
        // hide the regular enter name panel
        HideEnterNamePanel();
    }

    // do whatever we need to do here to hide the enter name panels
    public void HideEnterNamePanel()
    {
        enterNamePanel.SetActive(false);
    }

    public void HideEnterNamePanelJoystick()
    {
        enterNamePanel_joystick.SetActive(false);
    }

    public void UpdateUIText()
    {
        // note: I use three seperate text objects so that they can be lined up correctly in the window
        // also, just incase you didn't know.. the \n is a 'line break' that we put at the end of every
        // entry to make the text move on to the next line

        // first, a quick debug message to make it easy to track what's going on in the editor
        Debug.Log(">StandardHighScores.cs>Updating UI text for "+_scoreManager.numberOfScores+" scores.");

        // clear out the text in the leaderboard UI fields, ready to rebuild them
        leaderboardUIText_rank.text = "";
        leaderboardUIText_name.text = "";
        leaderboardUIText_score.text = "";

        // go through from 1 to (however many scores the Leaderboard holds) and show scores line by line from our _scoreManager
        for (var i = 1; i <= _scoreManager.numberOfScores; i++)
        {
            // rank
            leaderboardUIText_rank.text = leaderboardUIText_rank.text + i.ToString() + ".\n";

            // name
            leaderboardUIText_name.text = leaderboardUIText_name.text + _scoreManager.GetNameAt(i) + "\n";

            // score
            if (useFloatScoresInsteadofInts)
            {
                leaderboardUIText_score.text = leaderboardUIText_score.text + _scoreManager.GetScoreAsFloatAt(i).ToString() + "\n";
            } else
            {
                leaderboardUIText_score.text = leaderboardUIText_score.text + _scoreManager.GetScoreAt(i).ToString() + "\n";
            }
        }

    }

    public void NameSubmit()
    {
        // hide the enter name box
        HideEnterNamePanel();
        HideEnterNamePanelJoystick();

        string nameToSubmit = playerNameInputField.text;

        if (useJoystickEnterNameBox)
        {
            nameToSubmit = playerNameInputField_Joystick.text;
        } 
        // check to make sure that we're not submitting an empty name to the leaderboard
        if (nameToSubmit == "")
            nameToSubmit = "Anon E. Mouse";

        // tell the leaderboard script to submit this score with the name from the UI text box
        _scoreManager.SubmitLocalScore(nameToSubmit, finalGameScore);

        // now we need to update the leaderboard text to show the new entry
        UpdateUIText();

        // reset the stored final score so that it won't be submitted again
        PlayerPrefs.SetInt("finalScore", 0);
    }

    public void ResetLeaderboard()
    {
        // tell leaderboard control to reset the scores
        _scoreManager.ResetAllScores();

        // now we need to update the leaderboard text to show the new data
        UpdateUIText();
    }
}