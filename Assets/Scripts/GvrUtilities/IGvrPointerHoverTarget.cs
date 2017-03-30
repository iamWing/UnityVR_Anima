using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GvrUtilities {

    internal interface IGvrPointerHoverTarget : IEventSystemHandler{

        void Execute();
    }
}
