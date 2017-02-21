using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Utilities {

    internal interface IGvrPointerHoverEvent : IEventSystemHandler {

        void OnGvrPointerHover(IGvrPointerHoverTarget target);
        void OnGvrPointerHoverExit();
    }
}
