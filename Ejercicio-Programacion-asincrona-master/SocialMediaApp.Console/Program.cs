using System;
using System.Diagnostics;
using SocialMediaApp.Console.Repositories;
using System.Threading;
using System.Threading.Tasks;
using SocialMediaApp.Console.Models;
using System.Collections.Generic;

namespace SocialMediaApp.Console
{
    class Program
    {
        static void Main(string[] args)
        {
           

            var stopWatch = new Stopwatch();
            stopWatch.Start();
            System.Console.WriteLine("Loading users");
            LoadUsers();
            System.Console.WriteLine("Choose user to get posts: ");
            var userId = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Loading user posts");
            GetUserPostsWithComments(userId);
            stopWatch.Stop();
            var ts = stopWatch.Elapsed;
            System.Console.WriteLine($"Completed in: {ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds / 10:00}");
        }

        private static void GetUserPostsWithComments(int userId)
        {
            var postRepository = new PostRepository();
            var commentRepository = new CommentRepository();
            var posts = postRepository.GetByUserIdAsync(userId);
            foreach (var post in posts)
            {
                var comments = commentRepository.GetByPostId(post.Id);
                System.Console.WriteLine("-------------------Post--------------------");
                System.Console.WriteLine($"{post.Title} - {post.Body}");
                System.Console.WriteLine("-------------------Comments--------------------");
                foreach (var comment in comments)
                {
                    System.Console.WriteLine("-------------------Comment--------------------");
                    System.Console.WriteLine($"{comment.Name}: {comment.Body}");
                    System.Console.WriteLine("-------------------Comment--------------------");
                }
            }
        }

        private static void LoadUsers()
        {
            var userRepository = new UserRepository();
            var users = userRepository.Get();
            System.Console.WriteLine("Getting users");
            foreach (var user in users)
            {
                System.Console.WriteLine($"{user.Id} - {user.Name} - {user.UserName}");
            }
        }
    }
}
