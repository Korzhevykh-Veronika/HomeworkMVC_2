using Homework_mvc.DAL;
using Homework_mvc.Entities;
using Homework_mvc.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_mvc.Services
{
    public class MainService
    {
        UnitOfWork unitOfWork;
        public MainService()
        {
            unitOfWork = new UnitOfWork();
        }
        public IEnumerable<Entities.Article> GetArticles()
        {            
            return unitOfWork.Articles.GetAll();
        }

        public IEnumerable<Entities.Review> GetReviews()
        {
            return unitOfWork.Reviews.GetAll();
        }

        public IEnumerable<Question> GetQuestions()
        {
            return unitOfWork.Questions.GetAll();
        }

        internal void CreateReview(Entities.Review review)
        {
            unitOfWork.Reviews.Create(review);
        }

        public void CreateUser(User user)
        {
            for (int i = 0; i < user.Profiles.Count; i++)
            {
                user.Profiles[i].QuestionId = user.Questions[i].Id;
            }

            user.Profiles = user.Profiles.Where(profile => profile.Text != null).ToList();
            user.Questions.Clear();

            unitOfWork.Users.Create(user);
        }
    }
}