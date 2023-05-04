using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Design_Pattern
{
    public class SamsungRemoteControl : AbstractRemoteControl
    {
        public SamsungRemoteControl(ILEDTV ledTv)
        {
            this.ledTv = ledTv;
        }
        public override void SwitchOn()
        {
            ledTv.SwitchOn();
        }
        public override void SwitchOff()
        {
            ledTv.SwitchOff();
        }
        public override void SetChannel(int channelNumber)
        {
            ledTv.SetChannel(channelNumber);
        }
    }
}
