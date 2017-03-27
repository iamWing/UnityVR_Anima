using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GvrUtilities {

    internal interface IGvrPointerHoverEvent : IEventSystemHandler {

        void OnGvrPointerHover(IGvrPointerHoverTarget target);
        void OnGvrPointerHoverExit();
    }
}
