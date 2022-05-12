﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TI_Sklep.Models.Identity;

namespace TI_Sklep.Controllers
{
    public class AccountController : Controller
    {
        UserManager<AppUser> userManager { get; }
        SignInManager<AppUser> signInManager { get; }
    
    public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
    {
        this.userManager = userManager;
        this.signInManager = signInManager;
    }

    public async Task<IActionResult> Zarejestruj()
    {
        var user = await userManager.FindByNameAsync("TestUser");
        if (user == null)
        {
            AppUser userApp = new AppUser()
            {
                UserName = "TestUser",
                Email = "testc@test.pl",
                FirstName = "Jan",
                LastName = "Kowalski",
                Password ="Test123",
            };
            var result = await userManager.CreateAsync(userApp, userApp.Password);
            ViewBag.message = "Uzytkownik utworzony! \n" + result;
        }
        else
        {
            ViewBag.message = "Taki Uzytkownik juz istnieje! \n";
        }
        return View();
    }
        public async Task<IActionResult> Zaloguj()
        {
            var result = await signInManager.PasswordSignInAsync("TestUser", "Test123",false, false);

            if(result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.message = result;
            }

            return View();
        }
        public async Task<IActionResult> Wyloguj()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
            public IActionResult Index()
    {
        return View();
    }
    }
}
