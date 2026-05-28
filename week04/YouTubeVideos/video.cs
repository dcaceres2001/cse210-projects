using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    public class Video
    {
        private string _title;
        private string _author;
        private int _lengthInSeconds;
        private List<Comment> _comments;

        public Video(string title, string author, int lengthInSeconds, int maxComments = 100)
        {
            _title = title;
            _author = author;
            _lengthInSeconds = lengthInSeconds;
            _comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            if (_comments.Count < 100) // Assuming maxComments is 100
            {
                _comments.Add(comment);
            }
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetAuthor()
        {
            return _author;
        }

        public int GetLengthInSeconds()
        {
            return _lengthInSeconds;
        }

        public List<Comment> GetComments()
        {
            return _comments;
        }
    }
}