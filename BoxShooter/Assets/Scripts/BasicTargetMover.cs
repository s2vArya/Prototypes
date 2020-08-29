using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargetMover : MonoBehaviour
{
    [SerializeField]private float _rotateSpeed=180f;
    [SerializeField]private float _motionMagnitude=0.1f;

    public bool doSpin = true;
    public bool doMotion = false;

    // Update is called once per frame
    void Update()
    {
        if (doSpin)
        {
            // Rotating gameObject
            gameObject.transform.Rotate(Vector3.up * _rotateSpeed * Time.deltaTime);
        }

        if (doMotion)
        {
            //Moving game Object
            gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * _motionMagnitude);
        }
    }
}
