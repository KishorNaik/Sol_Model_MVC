using Sol_Model.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Model.ViewModel.Users
{
    public class UsersViewModel
    {
        #region Business Model

        public UserModel Users { get; set; }

        #endregion Business Model

        #region Ui Model

        public bool HideShowDiv { get; set; }

        #endregion Ui Model
    }
}