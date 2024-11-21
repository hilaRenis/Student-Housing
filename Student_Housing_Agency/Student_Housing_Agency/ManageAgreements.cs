using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing_Agency
{
    public class ManageAgreements
    {
        private List<Agreements> listAgreements = new List<Agreements>();

        public void AddAgreement(Agreements agreements)
        {
            listAgreements.Add(agreements);
        }

        public Agreements[] GetAllAgreements()
        {
            return listAgreements.ToArray();
        }

        public void RemoveSelectedAgreement(string removeAgreementText)
        {
            for (int i = 0; i < listAgreements.Count; i++)
            {
                Agreements agreements = listAgreements[i];
                if (removeAgreementText == agreements.GetRemoveAgreement())
                {
                    listAgreements.Remove(agreements);
                }
            }
        }
    }
}
