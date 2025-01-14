
using MealMap.Context;
using MealMap.Dto;
using MealMap.Dto.Request;
using MealMap.Dto.Response;
using MealMap.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace MealMap.Service
{
    public class UserService
    {
        private string GetHash(string str)
        {
            if (str == "" || str == null) return "";
            var sha = SHA256.Create();
            var hash = sha.ComputeHash(Encoding.UTF8.GetBytes(str));
            string result = Convert.ToBase64String(hash);
            return result;
        }

        public GetUserResponse Get()
        {
            using (MealMapContext context = new MealMapContext())
            {
                User u = context.Users.Include(u => u.Family).ThenInclude(f => f.Master).First();
                GetUserResponse user = new GetUserResponse()
                {
                    Id = u.Id,
                    Name = u.Name,
                    Email = u.Login,
                    IsMaster = u.Family.Master == u,
                    FamilyId = u.Family.Id
                    
                };
                return user;
            }

        }

        public IResult Create(PostUserRequest postUserRequest)
        {
            using (MealMapContext context = new MealMapContext())
            {
                User user = context.Users.Where(u => u.Login == postUserRequest.Email).FirstOrDefault();

                if (user == null)
                {
                    user = new User() { Login = postUserRequest.Email, Name = postUserRequest.Name, Password = GetHash(postUserRequest.Password) };
                    context.Users.Add(user);
                    context.SaveChanges();
                    return Results.Ok(new GetUserResponse() 
                    { 
                        Id = user.Id, 
                        Name = user.Name, 
                        Email = user.Login 
                    });
                }
                else
                {
                    return Results.Conflict("Пользователь с таким email уже существует!");
                }
            }
        }
    }
}
