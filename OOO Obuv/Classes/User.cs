using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOO_Obuv
{
    public class User
    {
        public enum UserRole
        {
            Клиент,
            Менеджер,
            Администратор
        }

        public int ID;
        public string Surname;
        public string Name;
        public string Patronymic;
        public UserRole Role;
        public User (int id, string surname, string name, string patronymic, UserRole role)
        {
            this.ID = id;
            this.Surname = surname;
            this.Name = name;
            this.Patronymic = patronymic;
            this.Role = role;
        }

        public static UserRole GetRole(string role)
        {
            return (UserRole)Enum.Parse(typeof(UserRole), role);
        }

    }
}
