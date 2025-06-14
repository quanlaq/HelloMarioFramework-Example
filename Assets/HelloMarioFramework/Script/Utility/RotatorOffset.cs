/*
 *  Copyright (c) 2024 Hello Fangaming
 *
 *  Use of this source code is governed by an MIT-style
 *  license that can be found in the LICENSE file or at
 *  https://opensource.org/licenses/MIT.
 *  
 * */
using UnityEngine;
using System.Collections;

namespace HelloMarioFramework
{
    public class OffsetRotator : MonoBehaviour
    {
        [Tooltip("Rotation angles to rotate by")]
        [SerializeField]
        private Vector3 angleOffset;
        
        [Tooltip("Rotation speed in degrees per second")]
        [SerializeField]
        private float speed = 90f;
        
        [Tooltip("Delay before rotating")]
        [SerializeField]
        private float delay;
        
        [Tooltip("Wait time before rotating again")]
        [SerializeField]
        private float pause = 1f;

        private Quaternion startRotation;
        private Quaternion endRotation;
        private bool rotateForward = true;
        private bool wait = false;

        void Start()
        {
            startRotation = transform.localRotation;
            endRotation = startRotation * Quaternion.Euler(angleOffset);
            
            if (delay > 0f)
            {
                wait = true;
                StartCoroutine(WaitToRotate(delay));
            }
        }

        void FixedUpdate()
        {
            if (!wait)
            {
                if (rotateForward)
                {
                    transform.localRotation = Quaternion.RotateTowards(transform.localRotation, endRotation, speed * Time.fixedDeltaTime);
                    if (Quaternion.Angle(transform.localRotation, endRotation) < 0.01f)
                    {
                        rotateForward = false;
                        wait = true;
                        StartCoroutine(WaitToRotate(pause));
                    }
                }
                else
                {
                    transform.localRotation = Quaternion.RotateTowards(transform.localRotation, startRotation, speed * Time.fixedDeltaTime);
                    if (Quaternion.Angle(transform.localRotation, startRotation) < 0.01f)
                    {
                        rotateForward = true;
                        wait = true;
                        StartCoroutine(WaitToRotate(pause));
                    }
                }
            }
        }

        private IEnumerator WaitToRotate(float duration)
        {
            yield return new WaitForSeconds(duration);
            wait = false;
        }
    }
}