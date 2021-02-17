﻿using UnityEngine;

 namespace Units.Units
{
    public interface ITargetable
    {
        bool TryAcceptPoint(GameObject point);
    }
}