﻿using Homework_mvc.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_mvc.DAL
{
    public class UnitOfWork : IDisposable
    {
        private BlogContext db = new BlogContext();

        private ArticleRepository articleRepository;
        private ReviewRepository reviewRepository;
        private QuestionRepository questionRepository;
        private UserRepository userRepository;

        public UnitOfWork()
        {
            articleRepository = new ArticleRepository(db);
            reviewRepository = new ReviewRepository(db);
            questionRepository = new QuestionRepository(db);
            userRepository = new UserRepository(db);
        }

        public ArticleRepository Articles
        {
            get
            {
                return articleRepository;
            }
        }
        public ReviewRepository Reviews
        {
            get
            {
                return reviewRepository;
            }
        }
        public QuestionRepository Questions
        {
            get
            {
                return questionRepository;
            }
        }
        public UserRepository Users
        {
            get
            {
                return userRepository;
            }
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}