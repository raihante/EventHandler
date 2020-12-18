using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace RegisterPages.Model
{
    class WhatsappVerification
    {
        public event EventHandler waVerificationEvent;
        public void OnUserRegistered(object source, EventArgs e)
        {
            //any process and logic here...
            waVerificationEvent(this, EventArgs.Empty);

        }
    }
}
