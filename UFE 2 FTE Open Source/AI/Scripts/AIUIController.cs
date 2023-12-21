using UnityEngine;
using UnityEngine.UI;

namespace UFE2FTE
{
    public class AIUIController : MonoBehaviour
    {
        [SerializeField]
        private Text aiModeText;
        [SerializeField]
        private Text aiThrowTechModeText;

        private void Update()
        {
            UFE2FTE.SetTextMessage(aiModeText, UFE2FTE.Instance.GetStringFromEnum(UFE2FTE.Instance.aiMode));

            UFE2FTE.SetTextMessage(aiThrowTechModeText, UFE2FTE.GetStringFromEnum(UFE2FTE.Instance.aiThrowTechMode));
        }

        public void NextAIMode()
        {
            UFE2FTE.Instance.aiMode = UFE2FTE.GetNextEnum(UFE2FTE.Instance.aiMode);
        }

        public void PreviousAIMode()
        {
            UFE2FTE.Instance.aiMode = UFE2FTE.GetPreviousEnum(UFE2FTE.Instance.aiMode);
        }

        public void NextAIThrowTechMode()
        {
            UFE2FTE.Instance.aiThrowTechMode = UFE2FTE.GetNextEnum(UFE2FTE.Instance.aiThrowTechMode);
        }

        public void PreviousAIThrowTechMode()
        {
            UFE2FTE.Instance.aiThrowTechMode = UFE2FTE.GetPreviousEnum(UFE2FTE.Instance.aiThrowTechMode);
        }
    }
}