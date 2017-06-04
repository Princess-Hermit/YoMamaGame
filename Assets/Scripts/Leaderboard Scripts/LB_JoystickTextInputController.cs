using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

public class LB_JoystickTextInputController : MonoBehaviour {

    private string[] theAlphabet = new string[28] { " ", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "<" };

    public Text nameText;

    public Transform arrowTop;
    public Transform arrowBottom;

    public float updateInterval = 1f;
    public float joystickDeadzone = 0;
    public float arrowMoveXAmount = 17.2f;

    public int selectedLetter;
    
    private int currentLetterInString;
    private bool inputLocked;
    private bool advanceLocked;
    private float originalArrowX;

    public UnityEvent OnClick;

    // -----------------------------------------------------------------------------------

    [Space(20)]
    public bool SkipJoystickInput; // <-- this allows you to disable my joystick system and provide the letters for this field from elsewhere

    // if you wanted to not use my joystick input and you have your own keyboard system, when the user selects an item use the following functions:
    // JoystickTextInputController.SetLetterAndAdvance(string whichLetter);    // < ---to add a letter to the text field
    // JoystickTextInputController.DeleteLetter();    // <---to delete a letter
    // JoystickTextInputController.FinishedInput();    // <---when you are done, this will call the event OnClick

    // -----------------------------------------------------------------------------------

    void Start ()
    {
        // if we are not using my joystick input, let's start the field empty rather than with a letter in it
        if ( !SkipJoystickInput )
        {
            nameText.text = "A";
        } else
        {
            nameText.text = " ";
        }

        selectedLetter = 1;
        inputLocked = false;

        originalArrowX = arrowBottom.localPosition.x;
    }
	
	void Update ()
    {
        if( !SkipJoystickInput )
            GetInput();
    }

    void UpdateArrowPositions()
    {
        // update arrow positions to point to the letter being edited
        currentLetterInString = nameText.text.Length - 1;
        Vector3 arrowPos = arrowBottom.localPosition;
        arrowPos.x = originalArrowX + ( currentLetterInString * arrowMoveXAmount );
        arrowBottom.localPosition = arrowPos;

        // now update the top arrow
        arrowPos.y = arrowTop.localPosition.y;
        arrowTop.localPosition = arrowPos;
    }

    void GetInput()
    {
        // RIGHT / NEXT LETTER
        if (Input.GetAxis("Vertical") > joystickDeadzone && inputLocked == false)
        {
            NextLetter();
            UpdateArrowPositions();
        }

        // LEFT / PREV LETTER
        if (Input.GetAxis("Vertical") < -joystickDeadzone && inputLocked == false)
        {
            PrevLetter();
            UpdateArrowPositions();
        }

        // FIRE / ADVANCE INPUT STRING
        if (Input.GetButtonUp("Fire1") && advanceLocked == false)
        {
            if (theAlphabet[selectedLetter] == "<")
            {
                DeleteLetter();            
              } else {
                AdvanceInput();
            }
            UpdateArrowPositions();
        }

        if (Input.GetButtonUp("Fire2"))
        {
            DeleteLetter();

            // submit name (this calls whatever event is set up in the OnClick bit in the Inspector)
            OnClick.Invoke();
        }
    }

    // -----------------------------------------------------------------------------------

    void NextLetter ()
    {
        // change the currently selected letter
        selectedLetter++;

        UpdateLetter();

        // we use a boolean variable to lock out any changes to the current letter
        inputLocked = true;

        // we don't release the input lock right away, so that the letter won't just whizz through the alphabet too quickly
        Invoke("FreeInput", updateInterval);
    }

    void PrevLetter ()
    {
        // change the currently selected letter
        selectedLetter--;

        UpdateLetter();

        // we use a boolean variable to lock out any changes to the current letter
        inputLocked = true;

        // we don't release the input lock right away, so that the letter won't just whizz through the alphabet too quickly
        Invoke("FreeInput", updateInterval);
    }

    void UpdateLetter ()
    {
        // first, let's make sure that the (index) number held by the selectedLetter variable is within the alphabet array
        if ( selectedLetter > theAlphabet.Length - 1 )
            selectedLetter = 0;

        if ( selectedLetter < 0 )
            selectedLetter = theAlphabet.Length - 1;

        // now set the current letter of the string to the currently selected letter
        int charIndex = nameText.text.Length - 1;

        //Remove character
        nameText.text = nameText.text.Remove(charIndex, 1);

        //Assign the current char
        if ( !SkipJoystickInput )
        {
            nameText.text = nameText.text.Insert(charIndex, theAlphabet [selectedLetter]);
        }
        else
        {
            // if we are skipping joystick input and getting letters from somewhere else, let's clear the current letter until one comes in
            nameText.text = nameText.text.Insert(charIndex, theAlphabet [0]);  // <-- theAlphabet[0] is an empty space 
        }

    }

    void FreeInput ()
    {
        // reset the input lock so that the player can change letters again
        inputLocked = false;
    }

    void FreeAdvance ()
    {
        advanceLocked = false;
    }

    // ----------------------------------------------------------------

    void AdvanceInput()
    {
        // stop repeat advances from happening too soon
        advanceLocked = true;

        //to advance to the next letter, we just add a new one like this:

        // first set the current letter of the string to the currently selected letter
        int charIndex = nameText.text.Length - 1;

        // add the currently selected char to the input text
        nameText.text = nameText.text.Insert(charIndex, theAlphabet[selectedLetter]);

        Invoke("FreeAdvance", updateInterval);
    }

    public void DeleteLetter()
    {
        // stop repeat advances from happening too soon
        advanceLocked = true;

        // if we can't delete, we drop out
        if ( nameText.text.Length <= 1 )
            return;

        // to advance to the next letter, we just add a new one like this:

        // first set the current letter of the string to the currently selected letter
        int charIndex = nameText.text.Length - 1;

        // remove character
        nameText.text = nameText.text.Remove(charIndex, 1);

        // update the string
        UpdateLetter();

        Invoke("FreeAdvance", updateInterval);
    }

    public void SetLetterAndAdvance ( string whichLetter )
    {
        // stop repeat advances from happening too soon
        advanceLocked = true;

        // now set the current letter of the string to the currently selected letter
        int charIndex = nameText.text.Length - 1;

        //Assign the current char
        nameText.text = nameText.text.Insert(charIndex, whichLetter);

        Invoke("FreeAdvance", updateInterval);
    }


    public void FinishedInput ()
    {
        // submit name (this calls whatever event is set up in the OnClick bit in the Inspector)
        OnClick.Invoke();
    }

}
