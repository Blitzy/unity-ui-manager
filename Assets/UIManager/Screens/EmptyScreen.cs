using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

#pragma warning disable 0649

namespace BlitzyUI
{
    public class EmptyScreen : BlitzyUI.Screen
    {
        public override void OnSetup()
        {
            // Run one-time setup operations here.
        }

        public override void OnPush(Data data)
        {
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
    }
}

#pragma warning restore 0649