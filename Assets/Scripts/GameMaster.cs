using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public static GameMaster gm;
    public int currentLevel;

    void Start()
    {
        if (gm == null)
        {
            gm = GameObject.FindWithTag("GM").GetComponent<GameMaster>();
        }
        currentLevel = 0;
    }

    public static void KillPlayer(GameObject player)
    {
        player.gameObject.SetActive(false);
        player.transform.position = new Vector3(0f, 0f, 0f);
        player.gameObject.SetActive(true);
    }

    public static void NextLevel()
    {
        //Debug.Log("SANDBOX: Go to next level");
        gm.currentLevel += 1;
        SceneManager.LoadScene(gm.currentLevel);
    }
}
