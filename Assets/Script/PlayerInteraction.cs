using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour {
    public enum InteractionType 
    {
        Click,
        Hold,
        Minigame,
    }

    public InteractionType interactionType;

}
