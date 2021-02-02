using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace CricketDomain.Handlers
{
    public class CricketHandler
    {

        [Route("Handlers/Save")]
        public void SaveCricketDetails(CricketDomain cricketDomain)
        {
            //Mock of a save to a NHibernate domain tied to the DB
            /*ISession session = NHibernateHelper.GetCurrentSession();
            try
            {
                using (ITransaction t = session.BeginTransaction())
                {
                    session.Save(princess);
                    t.Commit();
                }
            }
            finally
            {
                NHibernateHelper.CloseSession();
            }
             */
        }
    }
}
