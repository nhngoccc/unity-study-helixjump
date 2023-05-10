using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayController : MonoBehaviour
{
    public static GameplayController Instance;
    public LevelController levelController;

   private void Awake()
   {
    if(Instance != null && Instance != this)
    {
        Destroy(this.gameObject);
    }
    else 
    {
        Instance = this;
    }
        OnAwake();
   }
   void OnAwake()
   {
        levelController.Init();
   }

}
