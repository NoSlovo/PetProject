using IPAD_simulator.Enums;
using UnityEngine;

namespace IPAD_simulator.Scripts
{
    public abstract class BaseAdapter : MonoBehaviour
    {
        public void ActiveView(SystemTypeDevice deviceType)
        {
            switch (deviceType)
            {
                case SystemTypeDevice.IPhone:
                    ActiveViewIPad();
                    break;
                case SystemTypeDevice.IPAD:
                    ActiveViewIPhone();
                    break;
            }
        }
        protected abstract void ActiveViewIPad();

        protected abstract void ActiveViewIPhone();
    }
}