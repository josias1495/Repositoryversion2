using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using RepositoryDemo.Models;
using RepositoryDemo.Services;
using RepositoryDemo.Views;
using Xamarin.Forms;

namespace RepositoryDemo.ViewModels
{
    //Inyeccion de Dependencia. 
    public class AddCategoryViewModel
    {
        ICategoryRepository Repository;
        public AddCategoryViewModel(ICategoryRepository repository)
        {
            Repository = repository;
        }

        #region Properties
        public ObservableCollection<Product> Products { get; set; }
        public string CategoryNameF { get; set; }
        public string DescriptionF { get; set; }
        public string ProductNameF { get; set; }
        #endregion


        #region Command
        public Command AddProductCommand { get; set; }
        public Command SaveCategoryCommand { get; set; }

        #endregion
    }
}
