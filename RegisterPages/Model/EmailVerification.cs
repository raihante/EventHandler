using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace RegisterPages.Model
{
    class EmailVerification
    {
        public event EventHandler emailVerificationEvent;
        public void OnUserRegistered(object source, EventArgs e)
        {
            //any process and logic here...
            emailVerificationEvent(this, EventArgs.Empty);

        }
    }
}
