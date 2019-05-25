using System;
using System.Windows.Forms;

namespace Exam
{
    internal class BusinessClass
    {
        public BusinessClass()
        {
        }

        public string NameProj { get; set; }
        public DateTime DateProject { get; set; }
        public TimeSpan TimeProject { get; set; }
        public string PriorityProject { get; set; }
        public string TagsProject { get; set; }
        public string CommentProject { get; set; }
    }
}