using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    //a contract to implement the interface properties, events-- does not contain implementation logic, only contains signatures of the functionality

    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}