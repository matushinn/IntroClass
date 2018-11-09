using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMotion {

    Action<RobotScript, float> animation;
    float duration;
    float pastTime = 0;

    public RobotMotion(RobotMotion src) : this(src.animation,src.duration)
    {
    }
    public RobotMotion(Action<RobotScript, float> animation, float duration)
    {
        this.animation = animation;
        this.duration = duration;
    }
    public bool Animate(RobotScript robot, float deltaTime)
    {
        pastTime += deltaTime;
        animation(robot, pastTime / duration);
        return pastTime >= duration;
    }
}
