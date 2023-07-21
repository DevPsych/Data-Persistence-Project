using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI playerNameInput;

    public void SetPlayerName()
    {
        PersistentData.instance.playerName = playerNameInput.text;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void EndGame()
    {
#if UNITY_EDITOR
        EditorApplication.EnterPlaymode();
#else
        Application.Quit();
#endif
    }
}
