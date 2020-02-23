using UnityEngine;

public class earthMagic : MonoBehaviour
{
    public GameObject rightHand;
    public GameObject leftHand;

    void Start()
    {
        rockBarrage.rightHand = rightHand.transform;
        rockBarrage.rightHandParticleSystem = rightHand.GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        rockBarrage.rockBarrageCheck();
    }
    // Update is called once per frame
}
