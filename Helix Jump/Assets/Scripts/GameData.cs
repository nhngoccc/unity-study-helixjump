using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public List<PlatformData> platformDatas;
}
[System.Serializable]
public class PlatformData
{
    public List<PlatformType> data;
}
public enum PlatformType
{
        Empty = 0,
        Normal = 1,
        Hard = 2
        
}