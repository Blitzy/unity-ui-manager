using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

#pragma warning disable 0649

namespace BlitzyUI.UIExample
{
    public class ExamplePopupScreen : BlitzyUI.Screen
    {
        public Text messageLabel;
        public Button okButton;

        public override void OnSetup()
        {
            // Run one-time setup operations here.
            okButton.onClick.AddListener(HandleOkClicked);
        }

        public override void OnPush(Data data)
        {
            messageLabel.text = data.Get<string>("message");

            // Be sure to call PushFinished to signal the end of the push.
            PushFinished();
        }

        public override void OnPop()
        {
            // Be sure to call PopFinished to signal the end of the pop.
            PopFinished();
        }

        public override void OnFocus()
        {
        }

        public override void OnFocusLost()
        {
        }

        private void HandleOkClicked ()
        {
            UIManager.Instance.QueuePop(null);
        }
    }
}

#pragma warning restore 0649