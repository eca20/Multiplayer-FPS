using UnityEngine;
using UnityEngine.UIElements;

namespace Assets.Scripts.ScreenStates
{
    internal class MainDashboardSubState : WalletBaseScreen
    {
        public VisualElement _velAvatarSmallElement;

        public WalletScreenState MainScreenState => ParentState as WalletScreenState;

        public GameObject UIDocument;
        private static ILogger logger = Debug.unityLogger;

        public bool isActive;

        void Start()
           {
               if(UIDocument == null){
                   UIDocument = GameObject.Find("UIDocument");
               }
               logger.Log("UIDocument is:" + UIDocument.activeSelf);
           }

        public MainDashboardSubState(DemoWalletController flowController, WalletBaseScreen parent)
            : base(flowController, parent) { }

        public override void EnterState()
        {
            Debug.Log($"[{this.GetType().Name}][SUB] EnterState");

            var floatBody = FlowController.VelContainer.Q<VisualElement>("FloatBody");
            floatBody.style.backgroundColor = DemoWalletConstants.ColorLightGrey;
            floatBody.Clear();

            TemplateContainer elementInstance = ElementInstance("DemoWallet/UI/Frames/DashboardFrame");

            if(UIDocument == null){
                UIDocument = GameObject.Find("UIDocument");
            }
            logger.Log("UIDocument is:" + UIDocument.activeSelf);

            isActive = UIDocument.activeSelf;

            if(isActive)
                    {
                         UIDocument.SetActive(false);
                     //    Cursor.visible = false;
                      //   isActive = false;
                    }

            // add element
            floatBody.Add(elementInstance);
        }

        public override void ExitState()
        {
            Debug.Log($"[{this.GetType().Name}][SUB] ExitState");
        }
    }
}
