using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nakajima : MonoBehaviour
{
    [SerializeField] GameObject m_cube = default;
    
    void Update()
    {
        m_cube.transform.Rotate(1, 0, 0);
    }
}
