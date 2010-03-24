using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DStreet.USAdvisory.Business.Security.DAL;

namespace DStreet.USAdvisory.Business.Security
{
   public class AdminSecurity
    {

       private SecurityDAL securityDAL = new SecurityDAL();


        // Check whether the admin user is valid or not

        #region "IsValidAdminUser - Check whether the user is admin or not"
       /// <summary>
       /// Username and Password parameters
       /// </summary>
       /// <param name="userName"></param>
       /// <param name="passWord"></param>
       /// <returns></returns>
       public bool IsValidAdminUser(string userName, string passWord)
       {
           return securityDAL.IsValidAdminUser(userName, passWord);
       }

        #endregion 


    }
}
