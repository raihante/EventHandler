using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterPages.Model
{
    interface Respon
    {
        public void Jikaverifwasukses(object source, EventArgs e);
        public void Jikaverifemailsukses(object source, EventArgs e);
    }
}
