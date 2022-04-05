using StatusTask.Exeption;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatusTask.Models
{
    public class User
    {
        private int _id;
        public int Id { get;}
        private List<Status> _statuses;
        public string UserName { get; set; }
        public void ShareStatus(Status stat)
        {
            _statuses.Add(stat);
        }
        public Status GetStatusById(int? id)
        {
            if(id==null)
            {
                throw new NullReferenceException("Doldur be meyhaneci");
            }
            return _statuses.Find(m => m.Id == id);
        }
        public List<Status> GetAllStatuses()
        {
            List<Status> statusesCopy = new List<Status>();
            if (_statuses is null)
            {
                throw new NullReferenceException();
            }
            statusesCopy.AddRange(_statuses);
            return statusesCopy;

        }
        public List<Status> FilteredStatusByDate(DateTime datetime)
        {
            List<Status> statusesCopy = new List<Status>();
            statusesCopy.AddRange(_statuses.FindAll(m => m.SharedTime>datetime));
            if (statusesCopy is null)
            {
                throw new NotFoundException("Yoxdu");
            }
            
            return statusesCopy;
        }
        public User(string UserName)
        {
            Id = _id;
            _id++;
            this.UserName = UserName;
            _statuses=new List<Status>();
        }
    }
}
