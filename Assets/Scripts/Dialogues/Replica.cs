using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Replica : ScriptableObject
{
    public string ReplicaText = "Shall I clean this hummock of snow?";
    public string LeftAnswerText = "Get back to sleigh";
    public string RightAnswerText = "Clean it, could be treasure";

    public Replica NextReplica;
    
}
