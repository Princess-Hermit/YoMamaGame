using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameMod : MonoBehaviour {

    private int turn;
    public bool nextTurn;
    public List<GameObject> greatFoodList = new List<GameObject>();
    public List<GameObject> goodFoodList = new List<GameObject>();
    public List<GameObject> badFoodList = new List<GameObject>();
    public List<GameObject> veryBadFoodList = new List<GameObject>();
    private int greatNum;
    private int goodNum;
    private int badNum;
    private int veryBadNum;
    int greatFoodIndex;
    int goodFoodIndex;
    int badFoodIndex;
    int veryBadFoodIndex;

    public static int sWidth;
    public static int sHeight;
    
    Vector3 pos1;
    Vector3 pos2;
    Vector3 pos3;
    Vector3 pos4;

    public GameObject parent;

    private UnityAction turnListener;
    private UnityAction startListener;
    private UnityAction restartListener;
    private UnityAction gameEndListener;

    private bool start = false;
    private bool restart = false;
    private bool gameOver = false;

    void Awake()
    {
        turnListener = new UnityAction(changeTurn);
        startListener = new UnityAction(startGame);
        restartListener = new UnityAction(restartGame);
        gameEndListener = new UnityAction(gameEnd);
    }

    void OnEnable()
    {
        EventManager.StartListening("nextTurn", turnListener);
        EventManager.StartListening("start", startListener);
        EventManager.StartListening("restart", restartListener);
        EventManager.StartListening("gameOver", gameEndListener);
    }
    void OnDisable()
    {
        EventManager.StopListening("nextTurn", turnListener);
        EventManager.StopListening("start", startListener);
        EventManager.StopListening("restart", restartListener);
        EventManager.StopListening("gameOver", gameEndListener);
    }

    // Use this for initialization
    void Start()
    {
        sWidth = Screen.width;
        sHeight = Screen.height;
        positionMod(sWidth, sHeight);
    }

    // Update is called once per frame
    void Update() {

        if (start == true || restart == true)
        {
            gameOver = false;
            turn = 1;
            nextTurn = true;
            start = false;
            restart = false;
        }

        if (nextTurn && !gameOver)
        {
            nextTurn = false;
            if (turn <= 5)
            {
                //easy
                greatNum = 2;
                goodNum = 2;
                badNum = 0;
                veryBadNum = 0;
                instFood(greatNum, goodNum, badNum, veryBadNum);
            }

            if (turn > 5 && turn <= 15)
            {
                //medium
                greatNum = 1;
                goodNum = 2;
                badNum = 1;
                veryBadNum = 0;
                instFood(greatNum, goodNum, badNum, veryBadNum);
            }

            if (turn > 15 && turn <= 30)
            {
                //hard
                greatNum = 1;
                goodNum = 1;
                badNum = 1;
                veryBadNum = 1;
                instFood(greatNum, goodNum, badNum, veryBadNum);
            }

            if(turn > 30)
            {
                //extreme
                greatNum = 0;
                goodNum = 1;
                badNum = 2;
                veryBadNum = 1;
                instFood(greatNum, goodNum, badNum, veryBadNum);
            }
            turn++;
            
        }
    }


    //methods

    public void startGame()
    {
        start = true;
    }

    public void restartGame()
    {
        restart = true;
    }

    public void gameEnd()
    {
        gameOver = true;
    }

    public void changeTurn()
    {
        nextTurn = true;
    }

    public void positionMod(int sWidth, int sHieght)
    {
        float equalDist = sWidth / 5f;
// Food Height
        float foodHeight = sHeight / 10f;
        pos1 = new Vector3(equalDist, foodHeight);
        pos2 = new Vector3(equalDist*2, foodHeight);
        pos3 = new Vector3(equalDist*3, foodHeight);
        pos4 = new Vector3(equalDist*4, foodHeight);
    }

    public void instFood(int great, int good, int bad, int veryBad)
    {
        int[] choices = new int[4];
        int[] foodTypes = new int[4];
        foodTypes[0] = great;
        foodTypes[1] = good;
        foodTypes[2] = bad;
        foodTypes[3] = veryBad;
        bool done = false;

        Vector3 pos = new Vector3(0, 0, 0);


        for (int i = 0; i < 4; i++)
        {
            if (i == 0)
                pos = pos1;
            if (i == 1)
                pos = pos2;
            if (i == 2)
                pos = pos3;
            if (i == 3)
                pos = pos4;

            while (done == false)
            {
                choices[i] = UnityEngine.Random.Range(0, 4);
                if (foodTypes[0] != 0)
                {
                    if (choices[i] == 0)
                    {
                        greatFoodIndex = UnityEngine.Random.Range(0, greatFoodList.Count);
                        Gvar.position = i;
                        Instantiate(greatFoodList[greatFoodIndex], pos, Quaternion.identity, parent.transform);
                        foodTypes[0] -= 1;
                        done = true;
                    }
                }
                if (foodTypes[1] != 0)
                {
                    if (choices[i] == 1)
                    {
                        goodFoodIndex = UnityEngine.Random.Range(0, goodFoodList.Count);
                        Gvar.position = i;
                        Instantiate(goodFoodList[goodFoodIndex], pos, Quaternion.identity, parent.transform);
                        foodTypes[1] -= 1;
                        done = true;
                    }
                }
                if (foodTypes[2] != 0)
                {
                    if (choices[i] == 2)
                    {
                        badFoodIndex = UnityEngine.Random.Range(0, badFoodList.Count);
                        Gvar.position = i;
                        Instantiate(badFoodList[badFoodIndex], pos, Quaternion.identity, parent.transform);
                        foodTypes[2] -= 1;
                        done = true;
                    }
                }
                if (foodTypes[3] != 0)
                {
                    if (choices[i] == 3)
                    {
                        veryBadFoodIndex = UnityEngine.Random.Range(0, veryBadFoodList.Count);
                        Gvar.position = i;
                        Instantiate(veryBadFoodList[veryBadFoodIndex], pos, Quaternion.identity, parent.transform);
                        foodTypes[3] -= 1;
                        done = true;
                    }
                }
            }
            done = false;
        }


    }

	
}
