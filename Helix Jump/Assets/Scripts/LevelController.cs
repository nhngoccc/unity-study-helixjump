using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class LevelController : MonoBehaviour
{
    public Transform platformPrefab;
    public Transform culumnPos;
    public float platformDistance = 1f;
    public void Init()
    {
        GameData gameData = GameController.Instance.gameData;
        List<PlatformData> platformData = gameData.platformDatas;
        for(int i = 0; i < 30; i++ )
        {
            PlatformData currentPlatformData = platformData[(int)Random.Range(0, platformData.Count)];

            for(int j = 0; j < 21; j++)
            {
            Transform platformTransform = Instantiate(platformPrefab, culumnPos);
            Vector3 platformPos = new Vector3(0, -i*platformDistance, 0);
            platformTransform.position = platformPos;
            platformTransform.rotation = Quaternion.Euler(0, 17f*j, 0);
            switch(currentPlatformData.data[j])
            {
                case PlatformType.Empty:
                {
                    platformTransform.gameObject.SetActive(false);
                    break;
                }
                case PlatformType.Normal:
                {
                    platformTransform.GetComponent<MeshRenderer>().material.color = Color.gray;
                    break;
                }
                case PlatformType.Hard:
                {
                    platformTransform.GetComponent<MeshRenderer>().material.color = Color.red;
                    break;
                }
            }
            }
        }



    }

}
