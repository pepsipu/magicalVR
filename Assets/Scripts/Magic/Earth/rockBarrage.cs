using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class rockBarrage
{
    private static float timeHeld = 0f;
    public static Transform rightHand = null;
    public static ParticleSystem rightHandParticleSystem = null;
    private static bool active = false;
    public static void rockBarrageCheck()
    {
        if (OVRInput.Get(OVRInput.RawButton.A))
        {
            timeHeld += Time.deltaTime;
            if (timeHeld >= 1f && !active)
            {
                timeHeld = timeHeld % 1f;
                var emission = rightHandParticleSystem.emission;
                emission.rateOverTime = 10;
                active = true;
            }
        }
        else
        {
            timeHeld = 0f;
            if (active)
            {
                var emission = rightHandParticleSystem.emission;
                emission.rateOverTime = 0;
                active = false;
            }
        }

    }
}
