using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Utilities {
    public abstract class GazeHoverBehaviour : MonoBehaviour, IGvrPointerHoverTarget {

        [SerializeField]
        private GameObject m_player;

        public abstract void Execute();

        protected abstract void OnHover();

        protected abstract void OnHoverExit();

        public void OnGazePointerEnter() {
            OnHover();

            ExecuteEvents.Execute<IGvrPointerHoverEvent>(m_player, null, (x, y) => x.OnGvrPointerHover(this));
        }

        public void OnGazePointerExit() {
            OnHoverExit();

            ExecuteEvents.Execute<IGvrPointerHoverEvent>(m_player, null, (x, y) => x.OnGvrPointerHoverExit());
        }

    }
}
