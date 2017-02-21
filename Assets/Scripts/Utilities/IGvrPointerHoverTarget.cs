using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Utilities {

    internal interface IGvrPointerHoverTarget : IEventSystemHandler{

        void Execute();
    }
}
