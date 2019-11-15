using UnityEngine;

namespace BlitzyUI.UIExample
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        // Screen Ids
        public static readonly Screen.Id ScreenId_Empty = new Screen.Id("Empty");
        public static readonly Screen.Id ScreenId_ExampleMenu = new Screen.Id("ExampleMenu");
        public static readonly Screen.Id ScreenId_ExamplePopup = new Screen.Id("ExamplePopup");

        private void Awake() {
            if (Instance == null) {
                Instance = this;
            }
        }

        private void OnDestroy() {
            if (Instance == this) {
                Instance = null;
            }
        }

        private void Start() {
            // Push the example menu screen immediately.
            UIManager.Instance.QueuePush(ScreenId_ExampleMenu, null, "ExampleMenuScreen", null);
        }
    }
}
