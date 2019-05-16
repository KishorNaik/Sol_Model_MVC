using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Model.Models.Users
{
    public class UserModel
    {
        public String FirstName { get; set; }

        public String LastName { get; set; }

        #region Navigation Property

        // One to One
        public UserCommunicationModel UserCommunication { get; set; }

        public UserLoginModel UserLogin { get; set; }

        // One to Many
        public IEnumerable<UserCommunicationModel> ListUserCommunication { get; set; }

        public IEnumerable<UserAddressModel> ListUserAddress { get; set; }

        #endregion Navigation Property
    }
}