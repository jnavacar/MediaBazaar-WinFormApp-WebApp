﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarSystem
{
    public class Schedule
    {
        String startTime;
        String endTime;
        String workDate;
        String shifts;
        private List<Schedule> schedules;

        public String FirstName
        {
            get;
            set;
        }

        public String Role
        {
            get;
            set;
        }

        public DateTime StartTime
        {
            get;
            set;
        }

        public DateTime EndTime
        {
            get;
            set;
        }

        public DateTime WorkDate
        {
            get;
            set;
        }

        public Schedule(String firstName, String role, DateTime startTime, DateTime endTime, DateTime workDate)
        {
            schedules = new List<Schedule>();
            this.FirstName = firstName;
            this.Role = role;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.WorkDate = workDate;
        }

        public override string ToString()
        {
            return this.FirstName + this.Role + this.StartTime + this.EndTime + this.WorkDate;
        }

        public void AddSchedule( Schedule schedule )
        {
            schedules.Add( schedule );
        }

        public List<Schedule> GetSchedules()
        {
            return this.schedules;
        }
    }
}
