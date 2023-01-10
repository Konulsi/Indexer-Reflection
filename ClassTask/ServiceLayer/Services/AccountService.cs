using ServiceLayer.Exceptions;
using ServiceLayer.Helpers.Constants;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class AccountService : IAccountService

    {

        public string Register(string username, string email, string password)
        {   
            try
            {
                var result = GetAll();
                if (result.Contains(email))
                {
                    throw new RegisterExceptions(ResponseMessages.InvalidRgisterMessage);
                }
                return ResponseMessages.SuccesRgisterMessage;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        private List<string> GetAll()
        {
            return new List<string>() { "konulsi@code.edu.az", "roya@code.edu.az", "Shaig@code.edu.az" };
        }


    }
}
