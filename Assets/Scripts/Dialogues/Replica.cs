using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Replica : ScriptableObject
{
    public string ReplicaText = "Shall I clean this hummock of snow?";
    public string LeftAnswerText = "Get back to sleigh";
    public string RightAnswerText = "Clean it, could be treasure";

    public Replica _leftOptionNextReplica;

    [SerializeField]
    public Replica LeftOptionNextReplica
    {
        get
        {
            return _leftOptionNextReplica;
        }
        set { _leftOptionNextReplica = value; }
    }


    public Replica _rightOptionNextReplica;

    [SerializeField]
    public Replica RightOptionNextReplica
    {
        get
        {
            return _rightOptionNextReplica;
        }
        set { _rightOptionNextReplica = value; }
    }

    public int MinutesCost = 0;
    public bool isOutroReplica;

}
