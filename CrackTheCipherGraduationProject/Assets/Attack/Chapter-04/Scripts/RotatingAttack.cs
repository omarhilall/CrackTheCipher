using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ZakyAttack
{
    public class RotatingAttack : MonoBehaviour
    {
        [SerializeField]
        float rotX, rotY, rotZ;
        // Update is called once per frame
        void Update()
        {
            transform.Rotate(rotX, rotY, rotZ);
        }
    }
}