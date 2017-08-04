﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using DataAccessLayer;
using System.Data;

namespace Services
{
    public class PriorityServices
    {
        private static PriorityServices instance;
        public static PriorityServices Instance
        {
            get { return instance ?? (instance = new PriorityServices()); }
        }

        public void InsertPriority(string typePriority)
        {
            PriorityPersister.Instance.InsertPriority(typePriority);
        }

        public DataTable GetAllPriorities()
        {
            return DataTableCreator.Instance.ConvertListToDataTable(PriorityPersister.Instance.GetAllPriorities().ToList<Entities.Priorities>());
        }

        public List<Tuple<int, string>> GetAllPrioritiesToDropDown()
        {
           var priority = PriorityPersister.Instance.GetAllPriorities();
           var list = new List<Tuple<int, string>>();
           foreach (var item in priority)
           {
               list.Add(new Tuple<int, string>(item.idPriority, item.TypePriority));
           }
           return list;
        }
        public void DeletePriority(int idPriority)
        {
            PriorityPersister.Instance.DeletePriority(idPriority);
        }

        public bool CheckPriorityId(int idPriority)
        {
            var priority = PriorityPersister.Instance.GetAllPriorities();
            foreach (var item in priority)
            {
                if (item.idPriority == idPriority) return false;
            }
            return true;
        }
    }
}
