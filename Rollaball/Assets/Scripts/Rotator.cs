using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        //smooth rotation movement as the update is not per frame but per second
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}