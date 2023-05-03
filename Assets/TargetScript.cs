using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    
    public static List<TargetScript> Targets;

    void OnEnable()
    {
        
        if(Targets == null) { Targets = new List<TargetScript>(); }
        Targets.Add(this);
    }

    void Update()
    {
        
        Destroy(gameObject, Spawner.cooldown - 0.1f);
    }
}
