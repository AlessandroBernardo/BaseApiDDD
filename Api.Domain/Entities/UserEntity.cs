using System.Runtime.ConstrainedExecution;
using System;
using System.ComponentModel.DataAnnotations;
namespace Api.Domain.Entities
{
    public class UserEntity : BaseEntity
    {

        //public int IdUser { get; set; }
        public string Name { get; set; }


        [EmailAddress]
        public string Email { get; set; }

        public DateTime? BirthDay { get; set; }
    }
}
