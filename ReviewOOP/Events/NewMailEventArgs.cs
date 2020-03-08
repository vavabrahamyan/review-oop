using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class NewMailEventArgs: EventArgs
    {
        private readonly string m_form;
        private readonly string m_to;
        private readonly string m_subject;

        public NewMailEventArgs(string form, string to, string subject)
        {
            m_form = form;
            m_to = to;
            m_subject = subject;
        }

        public string Form { get { return m_form; } }
        public string To { get { return m_to; } }
        public string Subject { get { return m_subject; } }
    }
}
