using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public interface NewBehaviourScript : IEventSystemHandler{
    void HandleTimedInput();
}
