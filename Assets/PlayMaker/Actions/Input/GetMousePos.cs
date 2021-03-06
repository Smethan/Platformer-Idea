using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory(ActionCategory.GUI)]
    [Tooltip("Get Mouse Position in screen space.")]
    public class GetMousePosition : FsmStateAction
    {
        [RequiredField]
        [Tooltip("Store the position in this Vector3")]
        public FsmVector3 storeMousePosition;

        //[Tooltip("Distance to set from camera")]
        //public float Zdistance;

        [Tooltip("Do this every frame?")]
        public bool everyFrame;

        [Tooltip("Get the position relative to the center of the screen? (note: doesn't work with Invert Y checked)")]
        public bool fromScreenCenter;

        [Tooltip("Invery Y. For use with GUI space.")]
        public bool invertY;

        [Tooltip("Normalize the Vector3 result?")]
        public bool normalized;


        public override void Reset()
        {
            storeMousePosition = new FsmVector3 { UseVariable = true };
            everyFrame = false;
            fromScreenCenter = false;
            normalized = false;
            invertY = false;
            //Zdistance = 0f;
        }

        public override void OnEnter()
        {
            DoGetPosition();

            if (!everyFrame)
            {
                Finish();
            }
        }

        public override void OnUpdate()
        {
            DoGetPosition();
        }

        void DoGetPosition()
        {
            Vector3 mousePos = Input.mousePosition;
            if (invertY)
            {
                mousePos.y = Screen.height - mousePos.y;
            }

            if (fromScreenCenter)
            {
                mousePos.x -= Screen.width / 2;
                mousePos.y -= Screen.height / 2;
            }

            if (normalized)
            {
                mousePos.x /= Screen.width;
                mousePos.y /= Screen.height;
            }
            mousePos.z = 5.12f;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            storeMousePosition.Value = mousePos;
        }
    }
}
