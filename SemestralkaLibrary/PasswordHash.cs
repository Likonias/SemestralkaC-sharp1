using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SemestralkaLibrary
{
    public class PasswordHash
    {
        public PasswordHash()
        {
            
        }

        public string PasswordHashing(string password)
        {

            using var sha = SHA256.Create();

            var asBytes = Encoding.UTF8.GetBytes(password);

            var hashed = sha.ComputeHash(asBytes);

            return Convert.ToBase64String(hashed);

        }

    }
}
