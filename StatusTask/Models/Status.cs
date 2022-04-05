using System;
using System.Collections.Generic;
using System.Text;

namespace StatusTask.Models
{
    public class Status
    {
        private static int _id;
        public int Id { get; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime SharedTime { get; }
        public string ShowInfo()
        {
            DateTime nowTime = DateTime.Now;
            string time = $"Title:{Title} Content: {Content}Shared";
            if ((nowTime - SharedTime).Days != 0)
            {
                time += Convert.ToString((nowTime - SharedTime).Days);
                time += " Day";
            }
            if ((nowTime - SharedTime).Hours != 0)
            {
                time += Convert.ToString((nowTime - SharedTime).Hours);
                time += " Hours";
            }
            if ((nowTime - SharedTime).Seconds != 0)
            {
                time += Convert.ToString((nowTime - SharedTime).Seconds);
                time += " Seconds";
            }
            time += "ago";
            return time;
        }
        public Status(string Title, string Content)
        {
            _id++;
            Id = _id;
            this.Title = Title;
            this.Content = Content;
            SharedTime = DateTime.Now;
        }
        public override string ToString()
        {
            return $"Title:{Title} Content:{Content} Date:{SharedTime}";
        }
    }
}
