using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

#pragma warning disable 0649

namespace BlitzyUI.UIExample
{
    public class ExampleMenuScreen : BlitzyUI.Screen
    {
        public Text headerLabel;
        public Button buttonA;
        public Button buttonB;
        public Button buttonC;
        public Button buttonD;

        public override void OnSetup()
        {
            // Run one-time setup operations here.
            buttonA.onClick.AddListener(HandleButtonAClicked);
            buttonB.onClick.AddListener(HandleButtonBClicked);
            buttonC.onClick.AddListener(HandleButtonCClicked);
            buttonD.onClick.AddListener(HandleButtonDClicked);
        }

        public override void OnPush(Data data)
        {
            headerLabel.text = "Click on a button...";

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
            headerLabel.gameObject.SetActive(true);
        }

        public override void OnFocusLost()
        {
            headerLabel.gameObject.SetActive(false);
        }

        private void HandleButtonAClicked ()
        {
            DisplayPopup("You clicked a button, good job!");
            headerLabel.text = "Button A clicked. Click another...";
        }

        private void HandleButtonBClicked ()
        {
            DisplayPopup("Look at those button mashing skills!");
            headerLabel.text = "Button B clicked. Click another...";
        }

        private void HandleButtonCClicked ()
        {
            DisplayPopup("Your a natural, do you think you could click another but with more pizzazz?");
            headerLabel.text = "Button C clicked. Click another...";
        }

        private void HandleButtonDClicked ()
        {
            DisplayPopup("If you keep clicking buttons like that, you are gonna put me out of the job!");
            headerLabel.text = "Button D clicked. Click another...";
        }

        private void DisplayPopup (string message)
        {
            var screenData = new Screen.Data();
            screenData.Add("message", message);

            UIManager.Instance.QueuePush(GameManager.ScreenId_ExamplePopup, screenData, "ExamplePopupScreen", null);
        }
    }
}

#pragma warning restore 0649