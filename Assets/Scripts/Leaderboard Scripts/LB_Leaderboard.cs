using UnityEngine;
using System.Collections;

public class LB_Leaderboard : MonoBehaviour
{
    // -----------------------------------------------------------------------------------------
    // PUBLIC
    // -----------------------------------------------------------------------------------------
    public int scoreBoardIndex;

    [Space(10)]

    public int maxNameLength = 10; // <-- change this to allow longer names
    public int numberOfScores = 10; // <-- default value for leaderboard sizes

    [Space(10)]
    public string defaultName = "PsychicParrot";
    public float defaultScore = 0;

    [Space(10)]
    public bool lowestFirst;

    // -----------------------------------------------------------------------------------------
    // PRIVATE
    // -----------------------------------------------------------------------------------------

    private bool doneSetup;
    private int rank;

    private string[] names;
    private float[] scores;
    private float scoreToSet;

    // -----------------------------------------------------------------------------------------

    public void SetUpScores()
    {
        // check scores will either load scores from prefs or make a new board if there isn't one
        CheckScores();
    }

    // -----------------------------------------------------------------------------------------

    public void SetUpScores(int boardIndex)
    {
        // which scoreboard should we load?
        scoreBoardIndex = boardIndex;

        // check scores will either load scores from prefs or make a new board if there isn't one
        CheckScores();
    }

    // -----------------------------------------------------------------------------------------

    public void CheckScores()
    {
        // check to see if the leaderboard already exists (in prefs)
        if (PlayerPrefs.GetInt("hasLeaderboard" + scoreBoardIndex) != 2)
        {
            // there is no leaderboard for this game, so lets go ahead and make one
            BuildDefaultTable();

            // set the prefs flag to say 'yes, we made a leaderboard'
            PlayerPrefs.SetInt("hasLeaderboard" + scoreBoardIndex, 2);
        }
        else
        {
            // leaderboard exists in prefs
            LoadScores();
        }
    }

    // -----------------------------------------------------------------------------------------

    public void ResetAllScores()
    {
        // when the board is called to reset, we call the same function used to build it in the first place
        // so that it just constructs and entirely new leaderboard
        BuildDefaultTable();
    }

    public void ResetAllScores(string nameToUseInAllEntries, float minimumScoreForLeaderboard)
    {
        // this has the same effect as using just ResetAllScores() but you can pass in a name and score
        // so that all of the entries on the leaderboard will have that name and score to start with
        BuildDefaultTable(nameToUseInAllEntries, minimumScoreForLeaderboard);
    }

    public void ResetAllScores(string theName, float topScore, int decrementAmount)
    {
        // this has the same effect as using just ResetAllScores() but you can pass in a name and score
        // so that all of the entries on the leaderboard will have that name and score to start with
        BuildDefaultTableDecrementing(theName, topScore, decrementAmount);
    }

    // -----------------------------------------------------------------------------------------

    public void BuildDefaultTable()
    {
        // quick debug message to make it easy to track what's happening in the editor if needed
        Debug.Log(">Leaderboard.cs>Building default score table..");

        // set up default leaderboard table prefs
        for (var i = 0; i < numberOfScores; i++)
        {
            // PlayerPrefs, although it may not be the fastest, is the easiest, most easily transportable method
            // for storing data with Unity. If you're looking for performance then you might 
            PlayerPrefs.SetString(scoreBoardIndex + "leaderBoardName" + i, defaultName);
            PlayerPrefs.SetFloat(scoreBoardIndex + "leaderBoardScore" + i, defaultScore);
        }

        // set up arrays to store scores in for processing
        names = new string[numberOfScores];
        scores = new float[numberOfScores];

        // populate our arrays with playerprefs
        LoadScores();

        // set a flag to note this has been done
        doneSetup = true;
    }

    // You can also use BuildDefaultTable differntly. Pass in a name and score to set everything on the leaderboard to that.
    public void BuildDefaultTable(string aName, float aScore)
    {
        // quick debug message to make it easy to track what's happening in the editor if needed
        Debug.Log(">Leaderboard.cs>Building default score table..");

        // set up default leaderboard table prefs
        for (var i = 0; i < numberOfScores; i++)
        {
            // PlayerPrefs, although it may not be the fastest, is the easiest, most easily transportable method
            // for storing data with Unity. If you're looking for performance then you might 
            PlayerPrefs.SetString(scoreBoardIndex + "leaderBoardName" + i, aName);
            PlayerPrefs.SetFloat(scoreBoardIndex + "leaderBoardScore" + i, aScore);
        }

        // set up arrays to store scores in for processing
        names = new string[numberOfScores];
        scores = new float[numberOfScores];

        // populate our arrays with playerprefs
        LoadScores();

        // set a flag to note this has been done
        doneSetup = true;
    }

    // You can also use BuildDefaultTableDecrementing to generate a high score table that starts at a certain value in the number 1 position
    // and then goes down as you get further down the leaderboard.. pass in a name, the top score and how much to decrement per position after the top
    public void BuildDefaultTableDecrementing(string theName, float topScore, int decrementAmount)
    {
        // quick debug message to make it easy to track what's happening in the editor if needed
        Debug.Log(">Leaderboard.cs>Building default score table..");

        if (!lowestFirst)
        {
            // HIGHEST FIRST
            scoreToSet = 0;
            // set up default leaderboard table prefs
            for (var i = 0; i < numberOfScores; i++)
            {
                // PlayerPrefs, although it may not be the fastest, is the easiest, most easily transportable method
                // for storing data with Unity. If you're looking for performance then you might 
                PlayerPrefs.SetString(scoreBoardIndex + "leaderBoardName" + i, theName);

                // here, we take the top score and deduct i * decrementAmount, using Mathf.Max to make sure we never get a number
                // below zero.
                scoreToSet += Mathf.Max((topScore - decrementAmount), 0);
                PlayerPrefs.SetFloat(scoreBoardIndex + "leaderBoardScore" + i, scoreToSet);
            }
        }
        else
        {
            // LOWEST FIRST
            scoreToSet = topScore;
            // set up default leaderboard table prefs
            for (var i = numberOfScores - 1; i>=0; i--)
            {
                // PlayerPrefs, although it may not be the fastest, is the easiest, most easily transportable method
                // for storing data with Unity. If you're looking for performance then you might 
                PlayerPrefs.SetString(scoreBoardIndex + "leaderBoardName" + i, theName);

                // here, we take the top score and deduct i * decrementAmount, using Mathf.Max to make sure we never get a number
                // below zero.
                scoreToSet -= Mathf.Max((topScore - decrementAmount), 0);
                PlayerPrefs.SetFloat(scoreBoardIndex + "leaderBoardScore" + i, scoreToSet);
            }
        }
        // set up arrays to store scores in for processing
        names = new string[numberOfScores];
        scores = new float[numberOfScores];

        // populate our arrays with playerprefs
        LoadScores();

        // set a flag to note this has been done
        doneSetup = true;
    }

    // GetNameAt(index)
    // -----------------------------------------------------------------------------------------

    public string GetNameAt(int index)
    {
        // quick check to make sure that the leaderboard was set up before it is accessed
        if (!doneSetup)
        {
            Debug.LogError("ERROR: Leaderboard not set up and something is calling getFormattedStringAt.");
        }
        // return the name at the passed in index num (+1 so that it makes sense)
        return names[index - 1];
    }

    // int getScoreAt(index)
    // -----------------------------------------------------------------------------------------

    public int GetScoreAt(int index)
    {
        // quick check to make sure that the leaderboard was set up before it is accessed
        if (!doneSetup)
        {
            Debug.LogError("ERROR: Leaderboard not set up and something is calling getFormattedStringAt.");
        }
        // grab the score and convert it into an integer
        int theScore = (int)scores[index - 1];

        // return the name at the passed in index num (+1 so that it makes sense)
        return theScore;
    }


    // float GetScoreAsFloatAt(index)
    // -----------------------------------------------------------------------------------------

    public float GetScoreAsFloatAt(int index)
    {
        // quick check to make sure that the leaderboard was set up before it is accessed
        if (!doneSetup)
        {
            Debug.LogError("ERROR: Leaderboard not set up and something is calling getFormattedStringAt.");
        }
        // return the name at the passed in index num (+1 so that it makes sense)
        return scores[index - 1];
    }

    // didGetHighScore(score) returns true/false
    // -----------------------------------------------------------------------------------------

    public bool DidGetHighScore(float aScore)
    {
        // grab the player's rank from our GetHighScoreRank function
        rank = GetRank(aScore);

        if (rank < numberOfScores)
        {
            // we have a high score!
            return true;
        }

        // the player has no high score, so return false
        return false;
    }

    // integer support to retain backward compatibility with older versions of this script
    public bool DidGetHighScore(int aScore)
    {
        // grab the player's rank from our GetHighScoreRank function
        rank = GetRank(aScore);

        if (rank < numberOfScores)
        {
            // we have a high score!
            return true;
        }

        // the player has no high score, so return false
        return false;
    }

    public int GetRank(float aScore)
    {
        if (!lowestFirst)
        {
            // HIGHEST SCORE FIRST
            // to find out if we made it onto the leaderboard, we start out by assuming that the 
            // player is ranked just off the bottom of the board
            rank = numberOfScores + 1;
            bool onTheLeaderboard = false;

            // to find our rank on the leaderboard, we go from the bottom of the leaderboard
            // up to the top, moving the player's rank up each pass if the score is higher

            // find our rank on the scoreboard
            for (int i = (numberOfScores - 1); i>=0; i--)
            {
                if (scores[i] < aScore)
                {
                    rank = i;
                    onTheLeaderboard = true;
                }
            }

            // if we found a lower score, onTheLeaderboard will be true so we can return the rank
            if (onTheLeaderboard)
            {
                // here, we return the rank as it is
                return rank;
            } else
            {
                // if we didn't find a lower score, onTheLeaderboard will be false meaning we didn't get on the leaderboard
                // numberOfScores + 1 is just off the leaderboard, so it's not on the board..
                return numberOfScores + 1;
            }
        }
        else
        {
            // LOWEST SCORE FIRST
            // to find out if we made it onto the leaderboard, we start out by assuming that the 
            // player is ranked just off the bottom of the board
            rank = numberOfScores + 1;
            bool onTheLeaderboard = false;

            // to find our rank on the leaderboard, we go from the bottom of the leaderboard
            // up to the top, moving the player's rank up each pass if the score is lower

            // find our rank on the scoreboard
            for (int i = (numberOfScores - 1); i >=0; i--)
            {
                // if the score on the board is lower, or zero, we are at least at this rank
                if (scores[i] > aScore || scores[i] == 0)
                {
                    rank = i;
                    onTheLeaderboard = true;
                }
            }

            // if we found a higher score, onTheLeaderboard will be true so we can return the rank
            if (onTheLeaderboard)
            {
                // here, we return the rank as it is
                return rank;
            }
            else
            {
                // if we didn't find a higher score, onTheLeaderboard will be false meaning we didn't get on the leaderboard
                // numberOfScores + 1 is just off the leaderboard, so it's not on the board..
                return numberOfScores + 1;
            }
        }
    }

    // -----------------------------------------------------------------------------------------

    public void SubmitLocalScore(string playerName, float theScore)
    {
        // quick check to make sure that the leaderboard was set up before it is accessed
        if (!doneSetup)
        {
            Debug.LogError("ERROR: Leaderboard not set up and something is calling submitLocalScore.");
        }

        // if no name passed in, call him 'Anon'!
        if (playerName == "")
            playerName = "Anon";

        // restrict name lengths to stop long names messing up the high score display
        if (playerName.Length > maxNameLength)
        {
            // truncate the name
            playerName = playerName.Substring(0, maxNameLength);
        }

        // we use the GetHighScoreRank() function to get the rank for submitting
        rank = GetRank(theScore);

        // set up arrays
        float[] scoresCopy = new float[numberOfScores];
        string[] namesCopy = new string[numberOfScores];

        // build temp score board arrays for shuffling around 
        for (var i = (numberOfScores - 1); i>=0; i--)
        {
            if (i > rank)
            {
                scoresCopy[i] = scores[i - 1];
                namesCopy[i] = names[i - 1];
            }
            else if (i == rank)
            {
                scoresCopy[i] = theScore;
                namesCopy[i] = playerName;
            }
            else
            {
                scoresCopy[i] = scores[i];
                namesCopy[i] = names[i];
            }
        }

        // copy our shuffled leaderboard arrays into our 'real' board arrays
        for (int a = 0; a < numberOfScores; ++a)
        {
            names[a] = namesCopy[a];
            scores[a] = scoresCopy[a];
        }

        // now save our updated array into playerprefs
        SaveScores();
    }

    // backward compatibility with previous versions of the script requires support for integers, too.. so here it is!..
    public void SubmitLocalScore(string playerName, int theScore)
    {
        // if an integer is submitted to this function,
        // we just take this integer and pass it back as a float
        SubmitLocalScore(playerName, (float)theScore);
    }

    // file stuff
    // -----------------------------------------------------------------------------------------
    public void SaveScores()
    {
        // now save our scores out to player prefs
        for (var i = 0; i < numberOfScores; i++)
        {
            PlayerPrefs.SetString(scoreBoardIndex + "leaderBoardName" + i, names[i]);
            PlayerPrefs.SetFloat(scoreBoardIndex + "leaderBoardScore" + i, scores[i]);
        }
    }

    public void LoadScores()
    {
        // set up arrays to store scores in for processing
        names = new string[numberOfScores];
        scores = new float[numberOfScores];

        // load our scores out of player prefs
        for (var i = 0; i < numberOfScores; i++)
        {
            names[i] = PlayerPrefs.GetString(scoreBoardIndex + "leaderBoardName" + i);
            scores[i] = PlayerPrefs.GetFloat(scoreBoardIndex + "leaderBoardScore" + i);
        }

        // doneSetup is a bool just so that we can always be sure the leaderboard has been set up
        doneSetup = true;
    }
}