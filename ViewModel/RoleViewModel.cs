﻿using System.Collections.ObjectModel;
using WpfApplDemo2018.Model;
namespace WpfApplDemo2018.ViewModel
{
    public class RoleViewModel
    {
        public ObservableCollection<Role> ListRole { get; set; } =
        new ObservableCollection<Role>();
        public RoleViewModel()
        {
            this.ListRole.Add(
                new Role
            {
                Id = 1,
                NameRole = "Директор"
            });
            this.ListRole.Add(
                new Role
            {
                Id = 2,
                NameRole = "Бухгалтер"
            });
            this.ListRole.Add(
                new Role
            {
                Id = 3,
                NameRole = "Менеджер"
            });
        }
    }
}