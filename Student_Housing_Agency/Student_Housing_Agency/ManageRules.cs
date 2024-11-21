using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing_Agency
{
    public class ManageRules
    {
        private List<string> rulelist;

        public ManageRules()
        {
            rulelist = new List<string>();
        }

        public List<string> RuleList
        {
            get
            {
                return rulelist;
            }

            set
            {
                rulelist = value;
            }
        }

        public void AddRule(string line)
        {
            rulelist.Add(line);
        }

        public void RemoveRule(int index)
        {
            rulelist.RemoveAt(index);
        }

        public void ShiftRuleUp(int index)
        {
            string itemString = rulelist[index];
            rulelist.RemoveAt(index);
            rulelist.Insert(index - 1, itemString);
        }

        public void ShiftRuleDown(int index)
        {
            string itemString = rulelist[index];
            rulelist.RemoveAt(index);
            rulelist.Insert(index + 1, itemString);
        }
    }
}
