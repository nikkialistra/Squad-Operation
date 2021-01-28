#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;

#if UNITY_EDITOR
    [InitializeOnLoad] // Make sure static constructor is called during startup.
#endif
    [InputControlLayout(stateType = typeof(KeyboardState), isGenericTypeOfDevice = true)]
    [UnityEngine.Scripting.Preserve]
    public class KeyboardEx : Keyboard
    {
        /// <summary>
        /// A Button control that returns the opposite of the pressed state.
        /// If the button is pressed, returns 0.0 and if not pressed, returns 1.0.
        /// </remarks>
        [UnityEngine.Scripting.Preserve]
        public class InvertButtonControl : ButtonControl
        {
            public override unsafe float ReadUnprocessedValueFromState(void* statePtr)
            {
                return base.ReadUnprocessedValueFromState(statePtr) > 0f ? 0f : 1f;
            }
        }

        /// <summary>
        /// An artificial inverted combination of <see cref="leftShiftKey"/>, <see cref="rightShiftKey"/>,
        /// <see cref="leftCtrlKey"/>, <see cref="rightCtrlKey"/>,
        /// <see cref="leftAltKey"/>, and <see cref="rightAltKey"/> into one control.
        /// </summary>
        /// <value>Control representing a combined left and right shift, control, and alt key.</value>
        /// <remarks>
        /// This is a <see cref="InputControl.synthetic"/> button which is considered pressed whenever the left and
        /// right shift, control, and alt keys are not pressed.
        /// </remarks>
        public InvertButtonControl noModifier { get; private set; }

        protected override void FinishSetup()
        {
            base.FinishSetup();

            noModifier = GetChildControl<InvertButtonControl>("noModifier");
        }

        static KeyboardEx()
        {
            const string json = @"
   {
       ""name"" : ""KeyboardEx"",
       ""extend"" : ""Keyboard"",
       ""controls"" : [
           {
               ""name"" : ""noModifier"",
               ""layout"" : ""DiscreteButton"",
               ""usage"" : ""Modifier"",
               ""offset"" : 0,
               ""bit"" : 51,
               ""sizeInBits"" : 8,
               ""synthetic"" : true
           }
       ]
   }";

            InputSystem.RegisterLayoutOverride(json);
        }

        // In the Player, trigger the calling of our static constructor
        // by having an empty method annotated with RuntimeInitializeOnLoadMethod.
        [RuntimeInitializeOnLoadMethod]
        private static void Init()
        {
        }
    }