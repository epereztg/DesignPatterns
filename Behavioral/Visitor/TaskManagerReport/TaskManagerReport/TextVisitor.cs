using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerReport
{
    public class TextVisitor : IVisitor
    {
        public string Output
        {
            get { return this.m_output; }
            set { this.m_output = value; }
        }

        private string m_output = "";

        public void Visit(TextReport docPart)
        {
            this.Output += docPart.Text;
        }

        //public void Visit(BoldText docPart)
        //{
        //    this.m_output += "<b>" + docPart.Text + "</b>";
        //}

        //public void Visit(Hyperlink docPart)
        //{
        //    this.m_output += "<a href=\"" + docPart.Url + "\">" + docPart.Text + "</a>";
        //}
    }
}
