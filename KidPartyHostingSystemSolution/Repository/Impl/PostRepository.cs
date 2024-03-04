﻿using BussinessObjects;
using BussinessObjects.Request;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Impl
{
    public class PostRepository : IPostRepository
    {
        private PostDAO postDAO;
        public PostRepository()
        {
            postDAO = new PostDAO();
        }

        public bool checkPostExistedBy(int by)
        {
            return postDAO.checkPostExistedBy(by);
        }

        public Post checkPostExistedByID(int id)
        {
            return postDAO.checkPostExistedByID(id);
        }

        public int CountPost()
        {
           return postDAO.CountPost();
        }

        public RequestPostDTO CreatePost(RequestPostDTO request)
        {
            return postDAO.CreatePost(request);
        }

        public bool DeletePost(int id)
        {
            return postDAO.DeletePost(id);
        }

        public List<Post> GetPost()
        {
           return postDAO.GetPosts();
        }

        public Post GetPostById(int id)
        {
            return postDAO.GetPostById(id);
        }

        public List<Post> searchPost(string context)
        {
            return postDAO.searchPost(context);
        }

        public Post UpdatePost(Post request)
        {
            return postDAO.UpdatePost(request);
        }
    }
}
