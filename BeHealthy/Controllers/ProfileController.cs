﻿using BeHealthy.Repositories;
using BeHealthy.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BeHealthy.Controllers
{
    [Route("Profile")]
    [Route("[controller]/[action]")]
    public class ProfileController : Controller
    {
        // GET: ProfileController
        private IUnitOfWork _unitOfWork;
        public ProfileController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Profile()
        {
            var profView = new ProfileViewModel();
            var curUser = await _unitOfWork.UserRepository.GetByUserName(this.User.Identity.Name);
            var curWeightData = await _unitOfWork.WeightRepository.GetByUserNameAsync(this.User.Identity.Name);
            profView.WeightData = curWeightData;
            profView.User = curUser;
            return View(profView);
        }
        public async Task<IActionResult> SetAge(int age)
        {
            var curUser = await _unitOfWork.UserRepository.GetByUserName(this.User.Identity.Name);
            curUser.Age = age;
            _unitOfWork.UserRepository.Update(curUser);
            await _unitOfWork.CompleteAsync();
            return RedirectToAction("Profile");
        }
        public async Task<IActionResult> SetHeight(double height)
        {
            var curUser = await _unitOfWork.UserRepository.GetByUserName(this.User.Identity.Name);
            curUser.Height = height;
            _unitOfWork.UserRepository.Update(curUser);
            await _unitOfWork.CompleteAsync();
            return RedirectToAction("Profile");

        }
    }
}
