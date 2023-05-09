using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController Instance;
    private void Awake() {
        if(Instance != null && Instance !=this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
        DontDestroyOnLoad(Instance.gameObject);
        OnAwake();
    }
    private void OnAwake()
    {
        SceneManager.LoadScene("MainScene");
    }
}
