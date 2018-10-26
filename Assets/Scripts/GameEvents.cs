﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public struct GameEvent
    {
        public GameEventType Event;
    }

    public enum GameEventType
    {
        TrackStart,
        TrackRestart,
        TrackEnd
    }

    public struct ButtonPressedEvent
    {
        public GameObject target;
    }
}
