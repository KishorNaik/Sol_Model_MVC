using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sol_Model.Models.Users;
using Sol_Model.ViewModel.Users;

namespace Sol_Model.Controllers
{
    public class UsersController : Controller
    {
        #region Property

        [BindProperty]
        public UsersViewModel UsersVM { get; set; }

        #endregion Property

        #region Private Methods

        public void SetUsersData()
        {
            try
            {
                UsersVM = new UsersViewModel()
                {
                    Users = new UserModel()
                    {
                        FirstName = "Kishor",
                        LastName = "Naik",
                        UserCommunication = new UserCommunicationModel()
                        {
                            MobileNo = "9167791118",
                            EmailId = "kishor.naik011.net@gmail.com"
                        },
                        UserLogin = new UserLoginModel()
                        {
                            UserName = "Kishor11",
                            Password = "123"
                        },
                        ListUserCommunication = new List<UserCommunicationModel>()
                        {
                            new UserCommunicationModel()
                            {
                                MobileNo="9167791111",
                                EmailId="kishor.naik011.net1@gmail.com"
                            },
                            new UserCommunicationModel()
                            {
                                MobileNo="9167791112",
                                EmailId="kishor.naik011.net2@gmail.com"
                            },
                            new UserCommunicationModel()
                            {
                                MobileNo="9167791113",
                                EmailId="kishor.naik011.net3@gmail.com"
                            },
                        },
                        ListUserAddress = new List<UserAddressModel>()
                        {
                            new UserAddressModel()
                            {
                                Address="Kalwa"
                            },
                            new UserAddressModel()
                            {
                                Address="Mulund"
                            }
                        }
                    },
                    HideShowDiv = true
                };
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion Private Methods

        #region Actions

        public IActionResult Index()
        {
            // Set User Data
            this.SetUsersData();

            // return View with UserVm Model
            return View(UsersVM);
        }

        #endregion Actions
    }
}