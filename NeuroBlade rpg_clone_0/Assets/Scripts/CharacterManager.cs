using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeuroBlade
{
    public class CharacterManager : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(this);
        }
    }
}

