using UnityEngine;

public class earthMagic : MonoBehaviour
{
    private float timeHeld = 0f;
    public GameObject rockBarragePrefab;
    public Transform rightHand;
    public Transform leftHand;
    private GameObject currentRockBarrage;
    private bool active = false;

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.A))
        {
            timeHeld += Time.deltaTime;
            if (timeHeld >= 1f && !active)
            {
                timeHeld = timeHeld % 1f;
                currentRockBarrage = Instantiate(rockBarragePrefab, rightHand.position, rightHand.rotation);
                active = true;
            }
        }
        else
        {
            timeHeld = 0f;
            if (active)
            {
                active = false;
                Destroy(currentRockBarrage);
            }
        }

    }
}
