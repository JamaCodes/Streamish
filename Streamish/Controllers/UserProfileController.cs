using Microsoft.AspNetCore.Mvc;
using Streamish.Models;
using Streamish.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Streamish.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : Controller
    {
        private readonly IUserProfileRepository _userRepository;
        public UserProfileController(IUserProfileRepository userRepositoryy)
        {
            _userRepository = userRepositoryy;
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, UserProfile user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _userRepository.Update(user);
            return NoContent();
        }

        [HttpPost]
        public IActionResult Post(UserProfile userProfile)
        {
            _userRepository.Add(userProfile);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userRepository.Delete(id);
            return NoContent();
        }
    }
}
