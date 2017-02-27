using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Utilities
{
    public class StartJourneyButtonGvrPointerHoverEvent : MonoBehaviour, IGvrPointerHoverTarget
    {
        public void Execute()
        {
            SceneManager.LoadScene(1);
        }
        
    }
}
