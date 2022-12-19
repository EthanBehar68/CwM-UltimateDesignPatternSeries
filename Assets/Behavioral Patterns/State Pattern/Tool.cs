using UnityEngine;

namespace Vectorform.DesignPatternCookbook.StatePattern
{

    // Could've been a interface if I didn't need the sprite icon for my example.
    public abstract class Tool : MonoBehaviour
    {
        [SerializeField]
        private Sprite _toolIcon;

        public Sprite ToolIcon { get => _toolIcon; private set => _toolIcon = value; }

        public abstract void DoMouseDown();
        public abstract void DoMouseUp();
    }
}
