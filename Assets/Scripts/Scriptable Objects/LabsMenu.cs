using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/ Labs Available")]
public class LabsMenu : ScriptableObject
{

    public string id;
    public string displayName;
    public Sprite icon;
    public GameObject prefab;

   
}
