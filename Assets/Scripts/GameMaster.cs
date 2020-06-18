using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    public static GameMaster gm;
    public int currentLevel;

    void Awake()
    {
        if (gm == null)
        {
            Debug.Log("Assigning the GM!");
            gm = GameObject.FindWithTag("GM").GetComponent<GameMaster>();
            DontDestroyOnLoad(gm);
            gm.currentLevel = 0;
            Debug.Log(gm.currentLevel);
        }
    }

    public static void KillPlayer(GameObject player)
    {
        player.gameObject.SetActive(false);
        player.transform.position = new Vector3(0f, 0f, 0f);
        player.gameObject.SetActive(true);
    }

    public static void NextLevel()
    {
        SceneManager.LoadScene(gm.currentLevel + 1);
        gm.currentLevel += 1;
        Debug.Log(gm.currentLevel);
    }

    public static void Victory()
    {
        Debug.Log("You win!");
        Text winText = GameObject.Find("WinText").GetComponent<Text>();
        winText.text = "You Win!";
    }
}
