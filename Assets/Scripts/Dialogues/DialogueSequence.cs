using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSequence
{
    [SerializeField]
    private Replica[] Replicas = { new Replica() };//TODO: parsed from doc

    public Replica CurrentReplica = new Replica();//Replicas[0];
    public Replica LastReplica;


}
