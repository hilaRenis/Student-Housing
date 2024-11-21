using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing_Agency
{
    public class Agreements
    {
        private string textAgreement;
        private string partyA;
        private string partyB;
        private string removeAgreement;

        public void SetAgreementText(string text)
        {
            this.textAgreement = text;
        }

        public string GetAgreementText()
        {
            return this.textAgreement;
        }

        public void SetPartyA(string partyA)
        {
            this.partyA = partyA;
        }

        public string GetPartyA()
        {
            return this.partyA;
        }

        public void SetPartyB(string partyB)
        {
            this.partyB = partyB;
        }

        public string GetPartyB()
        {
            return this.partyB;
        }

        public void SetRemoveAgreement()
        {
            this.removeAgreement = $" ➤ ({this.partyA} & {this.partyB})--> {this.textAgreement}";
        }

        public string GetRemoveAgreement()
        {
            return this.removeAgreement;
        }
    }
}
